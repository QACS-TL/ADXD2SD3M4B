using System.Text;

namespace LabsSolutions.Lab4;
public class Program{
    public static void Main()
    {
        Console.WriteLine("Please run the GameApplication Windows Form program.");
        Console.WriteLine("Or you can create your own Windows Form app and use the");
        Console.WriteLine("Ball class code and ShapeType enum included in this project.");

        Lab04();

    }

    static void Lab04()
    {
        string name = "Samantha";

        Console.WriteLine($"{char.ToLower(name[2])}");
        Console.WriteLine($"{name.Substring(2,1).ToUpper()}");

        foreach(char c in name)
        {
            Console.Write($"{c}\t");
        }
        Console.WriteLine();
        string searchVal = "Sam";
        Console.WriteLine($"Does {name} start with {searchVal}? {(name.StartsWith("Sam")?true:false)}");
        
        Console.WriteLine($"Does {name} end with {searchVal}? {(name.EndsWith("Sam") ? true : false)}");
        char searchChar = 'x';
        Console.WriteLine($"Does {name} contain {searchChar}? {(name.Contains(searchChar) ? true : false)}. It is located at {name.IndexOf(searchChar)}");

        searchChar = 'n';
        Console.WriteLine($"Does {name} contain {searchChar}? {(name.Contains(searchChar) ? true : false)}. It is located at {name.IndexOf(searchChar)}");

        string surname = "Smith";
        string fullname = name + " " + surname;
        Console.WriteLine($"Fullname: {fullname}");

        StringBuilder sb = new StringBuilder("Bruce Springsteen ");
        sb.Append("is the artist ever.");
        Console.WriteLine(sb.ToString());
        int location = sb.ToString().IndexOf("artist");
        sb.Insert(location, "greatest ");
        sb.Replace("artist", "rock singer");
        Console.WriteLine(sb.ToString());   
    }

}
