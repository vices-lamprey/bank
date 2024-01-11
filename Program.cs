// Program.cs

using System;

class Program
{
    static void Main()
    {
        // Create accounts
        Account account1 = new Account(12345, 1000.0);
        Account account2 = new Account(67890, 2000.0);

        // Create a transaction
        Transaction transaction = new Transaction(account1, account2);

        // Perform a transaction
        transaction.Perform(500.0);

        // Display account details after the transaction
        account1.Display();
        account2.Display();
    }
}
