package eu.sig.training.ch04.v4;

import eu.sig.training.ch04.Money;
import eu.sig.training.ch04.v3.CheckingAccount;

public class Transfer {
    CheckingAccount counterAccount;

    @SuppressWarnings("unused")
    public Transfer(Account acct1, CheckingAccount acct2, Money m) {}

    public CheckingAccount getCounterAccount() {
        return this.counterAccount;
    }

}
