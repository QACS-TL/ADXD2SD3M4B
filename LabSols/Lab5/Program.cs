namespace LabsSolutions.Lab5;
public class Program
{
    private static Queue<ShoppingBasket> baskets = new Queue<ShoppingBasket>();
    public static void Main()
    {
        Buy(new ShoppingBasket("Pen",10,50));
        Buy(new ShoppingBasket("Ruler",3,150));
        Buy(new ShoppingBasket("Paper",20,250));
        ProcessBaskets();

        Console.WriteLine("*********************************************");

        Zoo zoo = new Zoo();
        zoo.Open();
        Console.WriteLine(zoo.ShowDetails());
    }
    private static void Buy(ShoppingBasket basket)
    {
        baskets.Enqueue(basket);
    }
    private static void ProcessBaskets()
    {
        while(baskets.Count > 0)
        {
            ShoppingBasket basket = baskets.Dequeue();
            basket.Pay();
            Console.WriteLine(basket.GetDetails());
        }
    }

}
