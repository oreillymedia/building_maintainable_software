namespace eu.sig.training.ch11 {

    public class DeadCode {
        public class Transaction {
            public Transaction(long uid) {
            }
        }

        // tag::getTransaction[]
        public Transaction getTransaction(long uid) {
            Transaction result = new Transaction(uid);
            if (result != null) {
                return result;
            } else {
                return lookupTransaction(uid); // <1>
            }
        }
        // end::getTransaction[]

        private Transaction lookupTransaction(long uid) {
            return null;
        }
    }
}