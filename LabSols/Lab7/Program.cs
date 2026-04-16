using System.Drawing;

namespace LabsSolutions.Lab7;

public class Program
{
    public static void Main()
    {
        Rectangle shape1 = new Rectangle(10, 20, Color.Black, new Point(1, 1));
        Circle shape2 = new Circle(10, Color.Red, new Point(1, 1));
        Sphere shape3 = new Sphere(10, Color.Blue, new Point(1, 1));

        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Circumference of {shape.Colour.Name} {shape.GetType().Name} is {shape.Circumference:0.00}");

            if(shape is Circle)
                Console.WriteLine($"Diameter of {shape.GetType().Name} is {((Circle)shape).Diameter:0.00}");
            
            Console.WriteLine($"Area of {shape.GetType().Name} is {shape.Area:0.00}");
            if (shape is Sphere)
                Console.WriteLine($"Volume of {shape.GetType().Name} is {((Sphere)shape).Volume:0.00}");
        }


    }
}
