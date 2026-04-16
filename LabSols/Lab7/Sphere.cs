using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.Lab7;

public class Sphere : Circle
{
    public Sphere(int radius, Color colour, Point position)
        : base(radius, colour, position)
    {
    }

    public override double Area
    {
        get
        {
            return 4 * Math.PI * Math.Pow(this.radius, 2);
        }
    }

    public double Volume
    {
        get
        {
            return (4 / 3F) * Math.PI * Math.Pow(this.radius, 3);
        }
    }

    public override string ToString()
    {
        return base.ToString() + ", Volume:" + Volume;
    }
}

