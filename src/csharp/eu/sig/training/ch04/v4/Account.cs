using System;
using eu.sig.training.ch04;
using eu.sig.training.ch04.v3;

namespace eu.sig.training.ch04.v4 {

    // tag::Account[]
    public class Account {
        public Transfer makeTransfer(string counterAccount, Money amount) {
            if (isValid(counterAccount)) {
                CheckingAccount acct = eu.sig.training.ch04.v3.Accounts.findAcctByNumber(counterAccount);
                return new Transfer(this, acct, amount);
            } else {
                throw new BusinessException("Invalid account number!");
            }
        }

        public static bool isValid(string number) {
            int sum = 0;
            for (int i = 0; i < number.Length; i++) {
                sum = sum + (9 - i) * (int)Char.GetNumericValue(number[i]);
            }
            return sum % 11 == 0;
        }
    }
    // end::Account[]

}