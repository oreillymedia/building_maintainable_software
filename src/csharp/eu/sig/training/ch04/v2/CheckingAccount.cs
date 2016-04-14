namespace eu.sig.training.ch04.v2
{

    // tag::CheckingAccount[]
    public class CheckingAccount
    {
        private int transferLimit = 100;

        public Transfer MakeTransfer(string counterAccount, Money amount)
        {
            // 1. Check withdrawal limit:
            if (amount.GreaterThan(this.transferLimit))
            {
                throw new BusinessException("Limit exceeded!");
            }
            if (Accounts.IsValid(counterAccount))
            { // <1>
                // 2. Look up counter account and make transfer object:
                CheckingAccount acct = Accounts.FindAcctByNumber(counterAccount);
                Transfer result = new Transfer(this, acct, amount); // <2>
                return result;
            }
            else
            {
                throw new BusinessException("Invalid account number!");
            }
        }
    }
    // end::CheckingAccount[]
}
