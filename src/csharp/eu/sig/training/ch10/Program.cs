using System;
using eu.sig.training.ch04.v1;

namespace eu.sig.training.ch10
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            string acct;
            do
            {
                Console.WriteLine("Type a bank account number on the next line.");
                acct = Console.ReadLine();
                Console.WriteLine($"Bank account number '{acct}' is" +
                    (Accounts.IsValid(acct) ? "" : " not") + " valid.");
            } while (!String.IsNullOrEmpty(acct));
        }
    }
}
