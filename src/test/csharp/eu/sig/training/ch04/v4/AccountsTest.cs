using System;
using NUnit.Framework;

namespace eu.sig.training.ch04.v4 {
    [TestFixture]
    public class AccountsTest {

        [Test]
        public void testIsValidNormalCases() {
            Assert.IsTrue(Accounts.isValid("123456789"));
            Assert.IsFalse(Accounts.isValid("123456788"));
        }

        [Test]
        public void testIsValidLetters() {
            Assert.IsFalse(Accounts.isValid("ABCDEFGHK"));
        }

        [Test]
        public void testIsValidNonNormal() {
            Assert.IsFalse(Accounts.isValid(""));
        }

        [Test]
        public void testIsValidNonNumeric() {
            Assert.IsFalse(Accounts.isValid("12.34.56."));
        }

        [Test]
        public void testIsValidToolong() {
            Assert.IsFalse(Accounts.isValid("1234567890"));
        }

        [Test]
        public void testIsValidTooshort() {
            Assert.IsFalse(Accounts.isValid("12345677"));
        }
    }
}
