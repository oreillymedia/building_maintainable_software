package eu.sig.training.ch04.v3;

import eu.sig.training.ch04.BusinessException;
import eu.sig.training.ch04.Money;

// tag::SavingsAccount[]
public class SavingsAccount extends Account {
    CheckingAccount registeredCounterAccount;

    @Override
    public Transfer makeTransfer(String counterAccount, Money amount)
        throws BusinessException {
        Transfer result = super.makeTransfer(counterAccount, amount);
        if (result.getCounterAccount().equals(this.registeredCounterAccount)) {
            return result;
        } else {
            throw new BusinessException("Counter-account not registered!");
        }
    }
}
// end::SavingsAccount[]