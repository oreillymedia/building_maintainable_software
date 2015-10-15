using eu.sig.training.ch04;

namespace eu.sig.training.ch04.v3 {

    // tag::SavingsAccount[]
    public class SavingsAccount : Account {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        new public Transfer makeTransfer(string counterAccount, Money amount) {
            Transfer result = base.makeTransfer(counterAccount, amount);
            if (result.getCounterAccount().Equals(this.RegisteredCounterAccount)) {
                return result;
            } else {
                throw new BusinessException("Counter-account not registered!");
            }
        }
    }
    // end::SavingsAccount[]

}