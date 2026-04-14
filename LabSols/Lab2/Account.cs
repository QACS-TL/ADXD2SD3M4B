namespace LabsSolutions.Lab2;
public class Account
{
    private int id;
    private string owner;
    private double balance;

    public Account(int id, string owner, double balance)
    {
        this.id = id;
        this.owner = owner;
        this.balance = balance;
    }

    public string GetDetails()
    {
        return $"ID: {id}, Owner: {owner}, Balance: {balance}";
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
    }
}
