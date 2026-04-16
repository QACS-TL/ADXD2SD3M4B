using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.Lab6;

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
        else
        {
            throw new ArgumentException("Not enough money in this account to withdraw £" + amount);
        }
    }
    public void Close()
    {
        Console.WriteLine("Account closed!");
    }

}


