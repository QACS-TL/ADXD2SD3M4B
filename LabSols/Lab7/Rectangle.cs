using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.Lab7;

public class Rectangle : Shape
{
    int sideA, sideB;

    public Rectangle(int sideA, int sideB, Color colour, Point position)
    : base(colour, position)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    public override double Area
    {
        get
        {
            return sideA * sideB;
        }
    }
    public override double Circumference
    {
        get
        {
            return 2 * (sideA + sideB);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", SideA:{sideA}, SideB: {sideB}, Area: {Area}, Perimeter: {Circumference}";
    }
}
