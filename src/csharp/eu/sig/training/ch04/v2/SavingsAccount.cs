using eu.sig.training.ch04;

namespace eu.sig.training.ch04.v2 {

    // tag::SavingsAccount[]
    public class SavingsAccount {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        public Transfer makeTransfer(string counterAccount, Money amount) {
            // 1. Assuming result is 9-digit bank account number, validate with 11-test:
            if (Accounts.isValid(counterAccount)) { // <1>
                // 2. Look up counter account and make transfer object:
                CheckingAccount acct = Accounts.findAcctByNumber(counterAccount);
                Transfer result = new Transfer(this, acct, amount); // <2>
                if (result.getCounterAccount().Equals(this.RegisteredCounterAccount)) {
                    return result;
                } else {
                    throw new BusinessException("Counter-account not registered!");
                }
            } else {
                throw new BusinessException("Invalid account number!!");
            }
        }

    }
    // end::SavingsAccount[]

}