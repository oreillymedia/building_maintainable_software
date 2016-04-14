using System;
using System.Collections.Generic;

namespace eu.sig.training.ch04.v3
{

    public static class Accounts
    {

        // The Java version of the Account class does not have a string Number as property, 
        // and the Java edition of the book is already in print. So we add an external 
        // association of Accounts and their numbers.
        public static Dictionary<string, Account> ACCOUNTS = new Dictionary<string, Account>();
        public static Dictionary<Account, string> NUMBERS = new Dictionary<Account, string>();

        public static CheckingAccount FindAcctByNumber(string number)
        {
            var myAccount = ACCOUNTS[number];
            if (myAccount is CheckingAccount)
            {
                return (CheckingAccount)myAccount;
            }
            else
            {
                throw new BusinessException("Not a checking account.");
            }
        }

        public static T MakeAccount<T>(string number) where T : Account, new()
        {
            var myAccount = new T();
            ACCOUNTS[number] = myAccount;
            NUMBERS[myAccount] = number;
            return myAccount;
        }

        public static string GetAccountNumber(Account acct)
        {
            return NUMBERS[acct];
        }

        // tag::isValid[]
        public static bool IsValid(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + (9 - i) * (int)Char.GetNumericValue(number[i]);
            }
            return sum % 11 == 0;
        }
        // end::isValid[]
    }

}