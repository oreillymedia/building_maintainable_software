// tag::AccountsTest[]
using NUnit.Framework;

namespace eu.sig.training.ch04.v1
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

        // end::AccountsTest[]

        // This test is meant to fail.
        [Ignore("Deliberately fails for illustration purpose")]
        // tag::testEmptyString[]
        [Test]
        public void TestEmptyString()
        {
            Assert.IsFalse(Accounts.IsValid(""));
        }
        // end::testEmptyString[]

#pragma warning disable 219
        // This test is meant to fail, that's why we ignore it.
        [Ignore("Deliberately fails for illustration purpose")]
        // tag::showError[]
        [Test]
        public void ShowError()
        {
            int tmp = 0, dummy = 1 / tmp;
            // Next line is never executed because the previous one raises an
            // exception.
            // If it were executed, you'll never see the assert message because
            // the test always succeeds.
            Assert.IsTrue(true);
        }
        // end::showError[]
#pragma warning restore 219
    }
}
