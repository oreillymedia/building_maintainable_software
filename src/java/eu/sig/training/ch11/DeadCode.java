package eu.sig.training.ch11;

public class DeadCode {
    public class Transaction {
        public Transaction(@SuppressWarnings("unused") long uid) {
        }
    }

    @SuppressWarnings("unused")
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

    private Transaction lookupTransaction(
        @SuppressWarnings("unused") long uid) {
        return null;
    }
}