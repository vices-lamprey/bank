// Transaction.cs

public class Transaction
{
    private Account sender;
    private Account receiver;

    public Transaction(Account sender, Account receiver)
    {
        this.sender = sender;
        this.receiver = receiver;
    }

    public void Perform(double amount)
    {
        // Perform a basic funds transfer transaction
        sender.Withdraw(amount);
        receiver.Deposit(amount);
    }
}
