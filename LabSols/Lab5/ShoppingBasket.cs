using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.Lab5;

public class ShoppingBasket
{
    private string productName;
    private int quantity;
    private double price;

    public ShoppingBasket(string productName, int quantity, double price)
    {
        this.productName = productName;
        this.quantity = quantity;
        this.price = price;
    }
    public void Pay()
    {
        Console.WriteLine($"Payment of £{quantity * price} taken for {productName}.");
    }

    public string GetDetails()
    {
        return $"Name: {productName} Quantity: {quantity} Price: {price}";
    }
}

