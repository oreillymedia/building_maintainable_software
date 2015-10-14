// tag::AccountsTest[]
package eu.sig.training.ch04.v1;

import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import org.junit.Test;

public class AccountsTest {

    @Test
    public void testIsValidNormalCases() {
        assertTrue(Accounts.isValid("123456789"));
        assertFalse(Accounts.isValid("123456788"));
    }

    // end::AccountsTest[]

    // tag::testEmptyString[]
    @Test
    public void testEmptyString() {
        assertFalse(Accounts.isValid(""));
    }
    // end::testEmptyString[]

    @SuppressWarnings("unused")
    // tag::showError[]
    @Test
    public void showError() {
        int dummy = 1 / 0;
        // Next line is never executed because the previous one raises an
        // exception.
        // If it were executed, you'll never see the assert message because
        // the test always succeeds.
        assertTrue("You will never see this text.", true);
    }
    // end::showError[]
}
