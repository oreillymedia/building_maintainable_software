using System;
using eu.sig.training.ch04.v3;

namespace eu.sig.training.ch04.v4
{

    public static class Accounts
    {
        public static CheckingAccount FindAcctByNumber(string number)
        {
            return new CheckingAccount();
        }

        // Version that should make tests succeed (not used in book):
        public static bool IsValid(string number)
        {
            if (number.Length != 9)
            {
                return false;
            }
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (!Char.IsDigit(number[i]))
                {
                    return false;
                }
                sum = sum + (9 - i) * (int)Char.GetNumericValue(number[i]);
            }
            return sum % 11 == 0;
        }

    }

}