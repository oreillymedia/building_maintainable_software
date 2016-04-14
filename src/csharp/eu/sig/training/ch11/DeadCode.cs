namespace eu.sig.training.ch11
{

    public class DeadCode
    {
        public class Transaction
        {
            public Transaction(long uid)
            {
            }
        }

        // tag::getTransaction[]
        public Transaction GetTransaction(long uid)
        {
            Transaction result = new Transaction(uid);
            if (result != null)
            {
                return result;
            }
            else
            {
                return LookupTransaction(uid); // <1>
            }
        }
        // end::getTransaction[]

        private Transaction LookupTransaction(long uid)
        {
            return null;
        }
    }
}
