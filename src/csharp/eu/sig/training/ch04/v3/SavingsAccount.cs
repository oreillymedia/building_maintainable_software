namespace eu.sig.training.ch04.v3
{

    // tag::SavingsAccount[]
    public class SavingsAccount : Account
    {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        public override Transfer MakeTransfer(string counterAccount, Money amount)
        {
            Transfer result = base.MakeTransfer(counterAccount, amount);
            if (result.CounterAccount.Equals(this.RegisteredCounterAccount))
            {
                return result;
            }
            else
            {
                throw new BusinessException("Counter-account not registered!");
            }
        }
    }
    // end::SavingsAccount[]

}