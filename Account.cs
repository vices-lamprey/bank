// Account.cs

using System;

public class Account
{
    private int accountNumber;
    private double balance;

    public Account(int accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return true;  // Successful withdrawal
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
            return false; // Failed withdrawal
        }
    }

    public void Display()
    {
        Console.WriteLine($"Account Number: {accountNumber}, Balance: ${balance:F2}");
    }
}
