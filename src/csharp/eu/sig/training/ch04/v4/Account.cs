using System;
using eu.sig.training.ch04.v3;

namespace eu.sig.training.ch04.v4
{

    // tag::Account[]
    public class Account
    {
        public Transfer MakeTransfer(string counterAccount, Money amount)
        {
            if (IsValid(counterAccount))
            {
                CheckingAccount acct = Accounts.FindAcctByNumber(counterAccount);
                return new Transfer(this, acct, amount);
            }
            else
            {
                throw new BusinessException("Invalid account number!");
            }
        }

        public static bool IsValid(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + (9 - i) * (int)Char.GetNumericValue(number[i]);
            }
            return sum % 11 == 0;
        }
    }
    // end::Account[]

}