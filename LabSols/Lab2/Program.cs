namespace LabsSolutions.Lab2;
public class Program{
    public static void Start()
    {
        Account account = new Account(111, "Mike", 100);
        account.Deposit(100);
        account.Deposit(-1000); // should have no effect
        account.Withdraw(100);  // back to 100
        account.Withdraw(-10);  // should have no effect
        account.Withdraw(50);
        Console.WriteLine(account.GetDetails());
    }
}
