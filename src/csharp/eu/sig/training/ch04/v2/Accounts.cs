using System;

namespace eu.sig.training.ch04.v2
{

    public static class Accounts
    {

        public static CheckingAccount FindAcctByNumber(string number)
        {
            return new CheckingAccount();
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