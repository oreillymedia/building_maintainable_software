package eu.sig.training.ch04.v4;

import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import org.junit.Test;

public class AccountsTest {

    @Test
    public void testIsValidNormalCases() {
        assertTrue("isValid(\"123456789\") should return true",
            Accounts.isValid("123456789"));
        assertFalse("isValid(\"123456788\") should return false",
            Accounts.isValid("123456788"));
    }

    @Test
    public void testIsValidLetters() {
        assertFalse("isValid(\"abcdefghi\") should return false",
            Accounts.isValid("ABCDEFGHK"));
    }

    @Test
    public void testIsValidNonNormal() {
        assertFalse("Empty string is not a valid number", Accounts.isValid(""));
    }

    @Test
    public void testIsValidNonNumeric() {
        assertFalse("Non-numerics always invalid",
            Accounts.isValid("12.34.56."));
    }

    @Test
    public void testIsValidToolong() {
        assertFalse("More than 9 digits is always invalid",
            Accounts.isValid("1234567890"));
    }

    @Test
    public void testIsValidTooshort() {
        assertFalse("Less than 9 digits is always invalid",
            Accounts.isValid("12345677"));
    }

}
