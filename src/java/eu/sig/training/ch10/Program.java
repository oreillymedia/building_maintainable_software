package eu.sig.training.ch10;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import eu.sig.training.ch04.v1.Accounts;

public class Program {
    public static void main(String[] args) throws IOException {
        BufferedReader isr = 
            new BufferedReader(new InputStreamReader(System.in));
        String acct;
        do {
            System.out.println("Type a bank account number on the next line.");
            acct = isr.readLine();
            System.out.println("Bank account number '" + acct + "' is" +
                (Accounts.isValid(acct) ? "" : " not") + " valid.");
        } while (acct != null && acct.length() != 0);
    }
}
