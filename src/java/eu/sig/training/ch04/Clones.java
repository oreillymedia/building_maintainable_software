package eu.sig.training.ch04;

public class Clones {
    private String givenName;
    private String familyName;
    private float pageWidthInCm;

    // tag::one-six-line-clone[]
    public void setGivenName(String givenName) {
        this.givenName = givenName;
    }

    public void setFamilyName(String familyName) {
        this.familyName = familyName;
    }
    // end::one-six-line-clone[]

    public String getGivenName() {
        return givenName;
    }

    public String getFamilyName() {
        return familyName;
    }

    // tag::type-2-clone[]
    public void setPageWidthInInches(float newWidth) {
        float cmPerInch = 2.54f;
        this.pageWidthInCm = newWidth * cmPerInch;
        // A few more lines.
    }

    public void setPageWidthInPoints(float newWidth) {
        float cmPerPoint = 0.0352777f;
        this.pageWidthInCm = newWidth * cmPerPoint;
        // A few more lines (same as in setPageWidthInInches).
    }
    // end::type-2-clone[]

    public float getPageWidthInCm() {
        return pageWidthInCm;
    }
}
