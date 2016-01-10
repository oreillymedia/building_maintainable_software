package eu.sig.training.ch04.v3;

import java.util.HashMap;
import java.util.Map;

import eu.sig.training.ch04.BusinessException;

public class Accounts {
    
    // The Java version of the Account class does not have a string Number as property, 
    // and the Java edition of the book is already in print. So we add an external 
    // association of Accounts and their numbers.
    public static Map<String, Account> ACCOUNTS = new HashMap<String, Account>();
    public static Map<Account, String> NUMBERS = new HashMap<Account, String>();
    
    // @SuppressWarnings("unused")
    public static CheckingAccount findAcctByNumber(String number)
        throws BusinessException {
        Object myAccount = ACCOUNTS.get(number);
        if (myAccount instanceof CheckingAccount) {
            return (CheckingAccount)myAccount;
        } else {
            throw new BusinessException("Not a checking account.");
        }
    }
    
    public static <T extends Account> T makeAccount(Class<T> clazz,
        String number) {
        try {
            T myAccount = clazz.newInstance();
            ACCOUNTS.put(number, myAccount);
            NUMBERS.put(myAccount, number);
            return myAccount;
        } catch (Exception e) {
            System.exit(1);
            return null;
        }
    }
    
    public static String getAccountNumber(Account acct) {
        return NUMBERS.get(acct);
    }
}
