package eu.sig.training.ch03;

import static eu.sig.training.ch03.JenkinsUser.LOGGER.Level.FINE;
import static eu.sig.training.ch03.JenkinsUser.XmlFile.XSTREAM;

import java.io.File;
import java.io.IOException;

import eu.sig.training.ch03.JenkinsUser.LOGGER.Level;

@SuppressWarnings("unused")
public class JenkinsUser {

    // tag::getOrCreate[]
    /**
     * Retrieve a user by its ID, and create a new one if requested.
     * @return
     *      An existing or created user. May be {@code null} if
     *      a user does not exist and {@code create} is false.
     */
    private static User getOrCreate(String id, String fullName,
        boolean create) {
        String idkey = idStrategy().keyFor(id);

        byNameLock.readLock().lock();
        User u;
        try {
            u = byName.get(idkey);
        } finally {
            byNameLock.readLock().unlock();
        }
        final File configFile = getConfigFileFor(id);
        if (!configFile.isFile() && !configFile.getParentFile().isDirectory()) {
            // check for legacy users and migrate if safe to do so.
            File[] legacy = getLegacyConfigFilesFor(id);
            if (legacy != null && legacy.length > 0) {
                for (File legacyUserDir : legacy) {
                    final XmlFile legacyXml = new XmlFile(XSTREAM,
                        new File(legacyUserDir, "config.xml"));
                    try {
                        Object o = legacyXml.read();
                        if (o instanceof User) {
                            if (idStrategy().equals(id, legacyUserDir.getName())
                                && !idStrategy()
                                    .filenameOf(legacyUserDir.getName())
                                    .equals(legacyUserDir.getName())) {
                                if (!legacyUserDir
                                    .renameTo(configFile.getParentFile())) {
                                    LOGGER.log(Level.WARNING,
                                        "Failed to migrate user record " +
                                        "from {0} to {1}",
                                        new Object[] {legacyUserDir,
                                            configFile.getParentFile()});
                                }
                                break;
                            }
                        } else {
                            LOGGER.log(FINE,
                                "Unexpected object loaded from {0}: {1}",
                                new Object[] {legacyUserDir, o});
                        }
                    } catch (IOException e) {
                        LOGGER.log(Level.FINE,
                            String.format(
                                "Exception trying to load user from {0}: {1}",
                                new Object[] {legacyUserDir, e.getMessage()}),
                            e);
                    }
                }
            }
        }
        if (u == null && (create || configFile.exists())) {
            User tmp = new User(id, fullName);
            User prev;
            byNameLock.readLock().lock();
            try {
                prev = byName.putIfAbsent(idkey, u = tmp);
            } finally {
                byNameLock.readLock().unlock();
            }
            if (prev != null) {
                u = prev; // if someone has already put a value in the map, use it
                if (LOGGER.isLoggable(Level.FINE)
                    && !fullName.equals(prev.getFullName())) {
                    LOGGER.log(Level.FINE,
                        "mismatch on fullName (‘" + fullName + "’ vs. ‘"
                            + prev.getFullName() + "’) for ‘" + id + "’",
                        new Throwable());
                }
            } else
                if (!id.equals(fullName) && !configFile.exists()) {
                // JENKINS-16332: since the fullName may not be recoverable 
                // from the id, and various code may store the id only, we 
                // must save the fullName
                try {
                    u.save();
                } catch (IOException x) {
                    LOGGER.log(Level.WARNING, null, x);
                }
            }
        }
        return u;
    }
    // end::getOrCreate[]

    public static class User {
        public User(Object... o) {}

        public void save() throws IOException {}

        public Object getFullName() {
            return null;
        }
    }

    public static class XmlFile {
        public static final Object XSTREAM = new Object();

        public XmlFile(Object... o) {}

        public Object read() throws IOException {
            return null;
        }
    }

    public static class LOGGER {
        public static enum Level {
            FINE, WARNING
        }

        public static void log(Object... o) {}

        public static boolean isLoggable(Level fine) {
            return false;
        }
    }

    public static class Strategy {
        public String keyFor(String id) {
            return null;
        }

        public boolean equals(String id, String name) {
            return false;
        }

        public Object filenameOf(String name) {
            return null;
        }
    }

    public static Strategy idStrategy() {
        return new Strategy();
    }

    public static class Lock {
        public Lock readLock() {
            return null;
        }

        public void lock() {}

        public void unlock() {}

        public User putIfAbsent(String idkey, User user) {
            return null;
        }

        public User get(String idkey) {
            return null;
        }
    }

    private static Lock byName = new Lock();

    private static Lock byNameLock = new Lock();

    private static File[] getLegacyConfigFilesFor(String id) {
        return null;
    }

    private static File getConfigFileFor(String id) {
        return null;
    }

}
