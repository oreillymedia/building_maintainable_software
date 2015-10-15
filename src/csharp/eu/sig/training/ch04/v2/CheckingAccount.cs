using System;
using eu.sig.training.ch04;

namespace eu.sig.training.ch04.v2 {

    // tag::CheckingAccount[]
    public class CheckingAccount {
        private int transferLimit = 100;

        public Transfer makeTransfer(string counterAccount, Money amount) {
            // 1. Check withdrawal limit:
            if (amount.greaterThan(this.transferLimit)) {
                throw new BusinessException("Limit exceeded!");
            }
            if (Accounts.isValid(counterAccount)) { // <1>
                // 2. Look up counter account and make transfer object:
                CheckingAccount acct = Accounts.findAcctByNumber(counterAccount);
                Transfer result = new Transfer(this, acct, amount); // <2>
                return result;
            } else {
                throw new BusinessException("Invalid account number!");
            }
        }

    }
    // end::CheckingAccount[]

}