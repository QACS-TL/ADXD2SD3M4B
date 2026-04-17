namespace LabsSolutions.Lab10;
public class Program{
    public static void Start()
    {
        Animal[] animals = { new Duck("Donald"), new Penguin("Happy feet"), new Fish("Mino") };
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.getName());
            if (animal is Bird)
            {
                ((Bird)animal).makeNest();
            }
            if (animal is Flyable)
            {
                ((Flyable)animal).fly();
            }
        }
    }
}
