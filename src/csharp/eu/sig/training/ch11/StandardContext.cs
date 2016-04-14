using System;

namespace eu.sig.training.ch11 {
    public class StandardContext {

        // tag::validateFilterMap[]
        private void ValidateFilterMap(FilterMap filterMap) {
            // Validate the proposed filter mapping
            string filterName = filterMap.GetFilterName();
            string[] servletNames = filterMap.GetServletNames();
            string[] urlPatterns = filterMap.GetURLPatterns();
            if (FindFilterDef(filterName) == null)
                throw new Exception(
                    sm.GetString("standardContext.filterMap.name", filterName));

            if (!filterMap.GetMatchAllServletNames() &&
                !filterMap.GetMatchAllUrlPatterns() &&
                (servletNames.Length == 0) && (urlPatterns.Length == 0))
                throw new Exception(
                    sm.GetString("standardContext.filterMap.either"));
            // FIXME: Older spec revisions may still check this
            /*
            if ((servletNames.length != 0) && (urlPatterns.length != 0))
                throw new IllegalArgumentException
                    (sm.getString("standardContext.filterMap.either"));
            */
            for (int i = 0; i < urlPatterns.Length; i++) {
                if (!ValidateURLPattern(urlPatterns[i])) {
                    throw new Exception(
                        sm.GetString("standardContext.filterMap.pattern",
                            urlPatterns[i]));
                }
            }
        }
        // end::validateFilterMap[]

        public class GetStringObject {
            public string GetString(string s) {
                return s;
            }

            public string GetString(string s, object o) {
                return s;
            }
        }

        private GetStringObject sm = new GetStringObject();

        public class FilterMap {

            public bool GetMatchAllUrlPatterns() {
                return false;
            }

            public string[] GetURLPatterns() {
                return null;
            }

            public string[] GetServletNames() {
                return null;
            }

            public string GetFilterName() {
                return null;
            }

            public bool GetMatchAllServletNames() {
                return false;
            }

        }

        private bool ValidateURLPattern(string s) {
            return false;
        }

        private object FindFilterDef(string filterName) {
            return null;
        }
    }
}
