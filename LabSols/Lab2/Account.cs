namespace LabsSolutions.Lab2;
public class Account
{
    private int id;
    private string owner;
    private decimal balance;

    public Account(int id, string owner, decimal balance)
    {
        this.id = id;
        this.owner = owner;
        this.Balance = balance;
    }

    public decimal Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    public string Owner
    {
        get { return owner; }
        private set {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Owner name cannot be empty.");
            }
            owner = value; 
        }
    }

    public string GetDetails()
    {
        return $"ID: {id}, Owner: {owner}, Balance: {balance}";
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
    }
}
