using System;

namespace eu.sig.training.ch11 {
    public class StandardContext {

        // tag::validateFilterMap[]
        private void validateFilterMap(FilterMap filterMap) {
            // Validate the proposed filter mapping
            string filterName = filterMap.getFilterName();
            string[] servletNames = filterMap.getServletNames();
            string[] urlPatterns = filterMap.getURLPatterns();
            if (findFilterDef(filterName) == null)
                throw new Exception(
                    sm.getString("standardContext.filterMap.name", filterName));

            if (!filterMap.getMatchAllServletNames() &&
                !filterMap.getMatchAllUrlPatterns() &&
                (servletNames.Length == 0) && (urlPatterns.Length == 0))
                throw new Exception(
                    sm.getString("standardContext.filterMap.either"));
            // FIXME: Older spec revisions may still check this
            /*
            if ((servletNames.length != 0) && (urlPatterns.length != 0))
                throw new IllegalArgumentException
                    (sm.getString("standardContext.filterMap.either"));
            */
            for (int i = 0; i < urlPatterns.Length; i++) {
                if (!validateURLPattern(urlPatterns[i])) {
                    throw new Exception(
                        sm.getString("standardContext.filterMap.pattern",
                            urlPatterns[i]));
                }
            }
        }
        // end::validateFilterMap[]

        public class GetStringObject {
            public string getString(string s) {
                return s;
            }

            public string getString(string s, object o) {
                return s;
            }
        }

        private GetStringObject sm = new GetStringObject();

        public class FilterMap {

            public bool getMatchAllUrlPatterns() {
                return false;
            }

            public string[] getURLPatterns() {
                return null;
            }

            public string[] getServletNames() {
                return null;
            }

            public string getFilterName() {
                return null;
            }

            public bool getMatchAllServletNames() {
                return false;
            }

        }

        private bool validateURLPattern(string s) {
            return false;
        }

        private object findFilterDef(string filterName) {
            return null;
        }
    }
}
