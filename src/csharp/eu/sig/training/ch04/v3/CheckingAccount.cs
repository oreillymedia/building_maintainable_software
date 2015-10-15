using eu.sig.training.ch04;

namespace eu.sig.training.ch04.v3 {

    // tag::CheckingAccount[]
    public class CheckingAccount : Account {
        private int transferLimit = 100;

        new public Transfer makeTransfer(string counterAccount, Money amount) {
            if (amount.greaterThan(this.transferLimit)) {
                throw new BusinessException("Limit exceeded!");
            }
            return base.makeTransfer(counterAccount, amount);
        }
    }
    // end::CheckingAccount[]

}