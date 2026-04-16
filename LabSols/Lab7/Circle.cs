using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.Lab7;

public class Circle : Shape
{
    protected int radius;

    public Circle(int radius, Color colour, Point position)
    : base(colour, position)
    {
        this.radius = radius;
    }

    public int Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public int Diameter
    {
        get { return 2 * radius; }
    }

    public override double Area
    {
        get
        {
            return Math.PI * this.radius * this.radius;
        }
    }
    public override double Circumference
    {
        get
        {
            return 2 * Math.PI * this.radius;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", Radius: {radius}, Area: {Area}, Circumference: {Circumference}";
    }
}
