package eu.sig.training.ch11;

public class StandardContext {

    @SuppressWarnings("unused")
    // tag::validateFilterMap[]
    private void validateFilterMap(FilterMap filterMap) {
        // Validate the proposed filter mapping
        String filterName = filterMap.getFilterName();
        String[] servletNames = filterMap.getServletNames();
        String[] urlPatterns = filterMap.getURLPatterns();
        if (findFilterDef(filterName) == null)
            throw new IllegalArgumentException(
                sm.getString("standardContext.filterMap.name", filterName));

        if (!filterMap.getMatchAllServletNames() &&
            !filterMap.getMatchAllUrlPatterns() &&
            (servletNames.length == 0) && (urlPatterns.length == 0))
            throw new IllegalArgumentException(
                sm.getString("standardContext.filterMap.either"));
        // FIXME: Older spec revisions may still check this
        /*
        if ((servletNames.length != 0) && (urlPatterns.length != 0))
            throw new IllegalArgumentException
                (sm.getString("standardContext.filterMap.either"));
        */
        for (int i = 0; i < urlPatterns.length; i++) {
            if (!validateURLPattern(urlPatterns[i])) {
                throw new IllegalArgumentException(
                    sm.getString("standardContext.filterMap.pattern",
                        urlPatterns[i]));
            }
        }
    }
    // end::validateFilterMap[]

    public class GetStringObject {
        public String getString(String string) {
            return string;
        }

        public String getString(String string,
            @SuppressWarnings("unused") Object o) {
            return string;
        }
    }

    private GetStringObject sm = new GetStringObject();

    public class FilterMap {

        public boolean getMatchAllUrlPatterns() {
            return false;
        }

        public String[] getURLPatterns() {
            return null;
        }

        public String[] getServletNames() {
            return null;
        }

        public String getFilterName() {
            return null;
        }

        public boolean getMatchAllServletNames() {
            return false;
        }

    }

    private boolean validateURLPattern(
        @SuppressWarnings("unused") String string) {
        return false;
    }

    private Object findFilterDef(
        @SuppressWarnings("unused") String filterName) {
        return null;
    }
}
