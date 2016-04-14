using NUnit.Framework;

namespace eu.sig.training.ch04.v3
{

    [TestFixture]
    public class CheckingsAccountTest
    {

        CheckingAccount myAccount;
        CheckingAccount counterAccount;

        [SetUp]
        public void Init()
        {
            myAccount = Accounts.MakeAccount<CheckingAccount>("123456789");
            counterAccount = Accounts.MakeAccount<CheckingAccount>("497164833");
        }

        [Test]
        [ExpectedException(typeof(BusinessException))]
        public void TestTransferLimit()
        {
            myAccount.MakeTransfer(Accounts.GetAccountNumber(counterAccount), new Money());
        }
    }
}

