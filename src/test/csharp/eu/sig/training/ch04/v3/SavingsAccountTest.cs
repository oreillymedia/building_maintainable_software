using NUnit.Framework;

namespace eu.sig.training.ch04.v3
{

    [TestFixture]
    public class SavingsAccountTest
    {

        SavingsAccount myAccount;
        CheckingAccount registeredCounterAccount;

        [SetUp]
        public void Init()
        {
            myAccount = Accounts.MakeAccount<SavingsAccount>("123456789");
            registeredCounterAccount = Accounts.MakeAccount<CheckingAccount>("497164833");
            myAccount.RegisteredCounterAccount = registeredCounterAccount;
        }

        [Test]
        public void TestCounterAccount()
        {
            myAccount.MakeTransfer("497164833", new Money());
        }

        [Test]
        [ExpectedException(typeof(BusinessException))]
        public void TestNoCounterAccount()
        {
            CheckingAccount unRegisteredCounterAccount = Accounts.MakeAccount<CheckingAccount>("1439");
            myAccount.MakeTransfer(Accounts.GetAccountNumber(unRegisteredCounterAccount), new Money());
        }

    }
}
