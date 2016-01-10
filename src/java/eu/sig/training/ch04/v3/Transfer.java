package eu.sig.training.ch04.v3;

import eu.sig.training.ch04.Money;

public class Transfer {
    CheckingAccount counterAccount;

    @SuppressWarnings("unused")
    public Transfer(Account acct1, CheckingAccount acct2, Money m) {
        this.counterAccount = acct2;
    }

    public CheckingAccount getCounterAccount() {
        return this.counterAccount;
    }

}
