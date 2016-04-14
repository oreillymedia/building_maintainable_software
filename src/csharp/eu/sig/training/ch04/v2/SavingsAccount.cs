namespace eu.sig.training.ch04.v2
{

    // tag::SavingsAccount[]
    public class SavingsAccount
    {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        public Transfer MakeTransfer(string counterAccount, Money amount)
        {
            // 1. Assuming result is 9-digit bank account number, validate 11-test:
            if (Accounts.IsValid(counterAccount))
            { // <1>
                // 2. Look up counter account and make transfer object:
                CheckingAccount acct = Accounts.FindAcctByNumber(counterAccount);
                Transfer result = new Transfer(this, acct, amount); // <2>
                if (result.CounterAccount.Equals(this.RegisteredCounterAccount))
                {
                    return result;
                }
                else
                {
                    throw new BusinessException("Counter-account not registered!");
                }
            }
            else
            {
                throw new BusinessException("Invalid account number!!");
            }
        }
    }
    // end::SavingsAccount[]
}
