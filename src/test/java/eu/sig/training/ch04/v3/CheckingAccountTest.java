package eu.sig.training.ch04.v3;

import org.junit.Before;
import org.junit.Test;

import eu.sig.training.ch04.BusinessException;
import eu.sig.training.ch04.Money;

public class CheckingAccountTest {

    CheckingAccount myAccount;
    CheckingAccount counterAccount;

    @Before
    public void setUp() {
        myAccount = Accounts.makeAccount(CheckingAccount.class, "123456789");
        counterAccount =
            Accounts.makeAccount(CheckingAccount.class, "497164833");
    }

    @Test(expected = BusinessException.class)
    public void TestTransferLimit() throws BusinessException {
        myAccount.makeTransfer(Accounts.getAccountNumber(counterAccount),
            new Money());
    }
}
