using System;

namespace eu.sig.training.ch04.v1
{
    // tag::SavingsAccount[]
    public class SavingsAccount
    {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        public Transfer makeTransfer(string counterAccount, Money amount)
        {
            // 1. Assuming result is 9-digit bank account number, validate 11-test:
            int sum = 0; // <1>
            for (int i = 0; i < counterAccount.Length; i++)
            {
                sum = sum + (9 - i) * (int)Char.GetNumericValue(
                    counterAccount[i]);
            }
            if (sum % 11 == 0)
            {
                // 2. Look up counter account and make transfer object:
                CheckingAccount acct = Accounts.FindAcctByNumber(counterAccount);
                Transfer result = new Transfer(this, acct, amount); // <2>
                // 3. Check whether withdrawal is to registered counter account:
                if (result.CounterAccount.Equals(this.RegisteredCounterAccount))
                {
                    return result;
                }
                else
                {
                    throw new BusinessException("Counter-account not registered!");
                }
            }
            else
            {
                throw new BusinessException("Invalid account number!!");
            }
        }
    }
    // end::SavingsAccount[]
}
