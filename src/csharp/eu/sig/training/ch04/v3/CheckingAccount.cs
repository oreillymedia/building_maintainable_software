namespace eu.sig.training.ch04.v3
{

    // tag::CheckingAccount[]
    public class CheckingAccount : Account
    {
        private int transferLimit = 100;

        public override Transfer MakeTransfer(string counterAccount, Money amount)
        {
            if (amount.GreaterThan(this.transferLimit))
            {
                throw new BusinessException("Limit exceeded!");
            }
            return base.MakeTransfer(counterAccount, amount);
        }
    }
    // end::CheckingAccount[]

}