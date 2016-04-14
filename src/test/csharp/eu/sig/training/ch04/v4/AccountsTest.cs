using NUnit.Framework;

namespace eu.sig.training.ch04.v4
{
    [TestFixture]
    public class AccountsTest
    {

        [Test]
        public void TestIsValidNormalCases()
        {
            Assert.IsTrue(Accounts.IsValid("123456789"));
            Assert.IsFalse(Accounts.IsValid("123456788"));
        }

        [Test]
        public void TestIsValidLetters()
        {
            Assert.IsFalse(Accounts.IsValid("ABCDEFGHK"));
        }

        [Test]
        public void TestIsValidNonNormal()
        {
            Assert.IsFalse(Accounts.IsValid(""));
        }

        [Test]
        public void TestIsValidNonNumeric()
        {
            Assert.IsFalse(Accounts.IsValid("12.34.56."));
        }

        [Test]
        public void TestIsValidToolong()
        {
            Assert.IsFalse(Accounts.IsValid("1234567890"));
        }

        [Test]
        public void TestIsValidTooshort()
        {
            Assert.IsFalse(Accounts.IsValid("12345677"));
        }
    }
}
