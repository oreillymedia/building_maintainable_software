package eu.sig.training.ch04.v3;

import org.junit.Before;
import org.junit.Test;

import eu.sig.training.ch04.BusinessException;
import eu.sig.training.ch04.Money;

public class SavingsAccountTest {

    SavingsAccount myAccount;
    CheckingAccount registeredCounterAccount;

    @Before
    public void setUp() {
        myAccount = Accounts.makeAccount(SavingsAccount.class, "123456789");
        registeredCounterAccount =
            Accounts.makeAccount(CheckingAccount.class, "497164833");
        myAccount.registeredCounterAccount = registeredCounterAccount;
    }

    @Test
    public void testCounterAccount() throws BusinessException {
        myAccount.makeTransfer("497164833", new Money());
    }

    @Test(expected = BusinessException.class)
    public void testNoCounterAccount() throws BusinessException {
        CheckingAccount unRegisteredCounterAccount =
            Accounts.makeAccount(CheckingAccount.class, "1439");
        myAccount.makeTransfer(
            Accounts.getAccountNumber(unRegisteredCounterAccount), new Money());
    }
}
