package eu.sig.training.ch11;

import java.io.File;
import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;

public class PluginManager {

    // tag::doUploadPlugin[]
    public HttpResponse doUploadPlugin(StaplerRequest req)
        throws IOException, ServletException {
        try {
            Jenkins.getInstance().checkPermission(UPLOAD_PLUGINS);

            ServletFileUpload upload = new ServletFileUpload(
                new DiskFileItemFactory());

            // Parse the request
            FileItem fileItem = (FileItem)upload.parseRequest(req).get(0);
            String fileName = Util.getFileName(fileItem.getName());
            if ("".equals(fileName)) {
                return new HttpRedirect("advanced");
            }
            // we allow the upload of the new jpi's and the legacy hpi's
            if (!fileName.endsWith(".jpi") && !fileName.endsWith(".hpi")) {
                throw new Failure("Not a plugin: " + fileName);
            }

            // first copy into a temporary file name
            File t = File.createTempFile("uploaded", ".jpi");
            t.deleteOnExit();
            fileItem.write(t);
            fileItem.delete();

            final String baseName = identifyPluginShortName(t);

            pluginUploaded = true;

            // Now create a dummy plugin that we can dynamically load
            // (the InstallationJob will force a restart if one is needed):
            JSONObject cfg = new JSONObject().element("name", baseName)
                .element("version", "0"). // unused but mandatory
                element("url", t.toURI().toString())
                .element("dependencies", new JSONArray());
            new UpdateSite(UpdateCenter.ID_UPLOAD, null).new Plugin(
                UpdateCenter.ID_UPLOAD, cfg).deploy(true);
            return new HttpRedirect("../updateCenter");
        } catch (IOException e) {
            throw e;
        } catch (Exception e) {// grrr. fileItem.write throws this
            throw new ServletException(e);
        }
    }
    // end::doUploadPlugin[]

    private static final String UPLOAD_PLUGINS = "";
    @SuppressWarnings("unused")
    private boolean pluginUploaded = false;

    public interface HttpResponse {}

    public class HttpRedirect implements HttpResponse {
        public HttpRedirect(@SuppressWarnings("unused") String s) {}
    }

    public class StaplerRequest {}

    private String identifyPluginShortName(@SuppressWarnings("unused") File t) {
        return null;
    }

    public static class Jenkins {
        public static Jenkins getInstance() {
            return new Jenkins();
        }

        public void checkPermission(@SuppressWarnings("unused") String s) {}
    }

    public class JSONObject {

        public JSONObject element(@SuppressWarnings("unused") String string,
            @SuppressWarnings("unused") Object o) {
            return null;
        }
    }

    public class JSONArray {}

    public class FileItem {
        public void write(@SuppressWarnings("unused") File t) {}

        public void delete() {}

        public Object getName() {
            return null;
        }
    }

    public class DiskFileItemFactory {}

    public class ServletFileUpload {
        public ServletFileUpload(
            @SuppressWarnings("unused") DiskFileItemFactory dfif) {}

        public List<FileItem> parseRequest(
            @SuppressWarnings("unused") StaplerRequest req) {
            return null;
        }
    }

    public static class Util {
        public static String getFileName(
            @SuppressWarnings("unused") Object name) {
            return null;
        }
    }

    public class UpdateSite {
        public UpdateSite(@SuppressWarnings("unused") Object o1,
            @SuppressWarnings("unused") Object o2) {}

        public class Plugin {
            public Plugin(@SuppressWarnings("unused") Object o1,
                @SuppressWarnings("unused") Object o2) {}

            public void deploy(@SuppressWarnings("unused") boolean b) {}
        }
    }

    public interface UpdateCenter {
        String ID_UPLOAD = "";
    }

    public class Failure extends RuntimeException {
        private static final long serialVersionUID = 1L;

        public Failure(String message) {
            super(message);
        }
    }
}
