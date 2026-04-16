using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabsSolutions.QALibrary;

namespace LabsSolutions.Lab9;

public class Program
{
    public static void Main()
    {
        Animal[] animals = { new Duck("Donald"), new Penguin("Happy Feet"), new Fish("Mino") };
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Name);
            if (animal is Bird)
            {
                Console.WriteLine(((Bird)animal).MakeNest());
            }
        }

    }
}
