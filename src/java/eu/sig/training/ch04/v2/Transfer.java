package eu.sig.training.ch04.v2;

import eu.sig.training.ch04.Money;

public class Transfer {
    CheckingAccount counterAccount;

    @SuppressWarnings("unused")
    public Transfer(CheckingAccount acct1, CheckingAccount acct2, Money m) {}

    @SuppressWarnings("unused")
    public Transfer(SavingsAccount acct1, CheckingAccount acct2, Money m) {}

    public CheckingAccount getCounterAccount() {
        return this.counterAccount;
    }

}
