using System.Text;

namespace LabsSolutions.Lab3;
public class Program{
    public static void Main()
    {
        Vehicle[] vehicles = {
            new Vehicle(1,0),
            new Vehicle(2,0),
            new Vehicle(3,0)
        };

        Random rand = new Random();
        bool endOfRace = false;
        while (!endOfRace)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine(vehicles[i].GetDetails());
                vehicles[i].Accelerate(rand.Next(10) + 1);
                if (vehicles[i].DistanceTravelled > 1000)
                {
                    Console.WriteLine("Winner!!! " + vehicles[i].GetDetails());

                    endOfRace = true;
                    break;
                }
            }
        }
    }
}
