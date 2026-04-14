using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.Lab1;

public class Utils
{
    public int GetInt(string prompt)
    {
        Console.Write(prompt);
        string ans = Console.ReadLine();
        return int.Parse(ans);
    }

    public string Getstring(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}
