namespace eu.sig.training.ch04.v3
{

    public class Transfer
    {
        public CheckingAccount CounterAccount { get; set; }

        public Transfer(Account acct1, CheckingAccount acct2, Money m)
        {
            CounterAccount = acct2;
        }
    }
}