namespace eu.sig.training.ch04
{
    public class Clones
    {
        private string givenName;
        private string familyName;
        private float pageWidthInCm;

        // tag::one-six-line-clone[]
        public void SetGivenName(string givenName)
        {
            this.givenName = givenName;
        }

        public void SetFamilyName(string familyName)
        {
            this.familyName = familyName;
        }
        // end::one-six-line-clone[]

        public string GetGivenName()
        {
            return givenName;
        }

        public string GetFamilyName()
        {
            return familyName;
        }

        // tag::type-2-clone[]
        public void SetPageWidthInInches(float newWidth)
        {
            float cmPerInch = 2.54f;
            this.pageWidthInCm = newWidth * cmPerInch;
            // A few more lines.
        }

        public void SetPageWidthInPoints(float newWidth)
        {
            float cmPerPoint = 0.0352777f;
            this.pageWidthInCm = newWidth * cmPerPoint;
            // A few more lines (same as in setPageWidthInInches).
        }
        // end::type-2-clone[]

        public float GetPageWidthInCm()
        {
            return pageWidthInCm;
        }
    }
}
