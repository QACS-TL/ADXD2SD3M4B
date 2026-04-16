using System.Drawing;

namespace LabsSolutions.Lab7;
public class Shape
{
    public Color Colour { get; set; }
    Point Position { get; set; }

    public Shape(Color colour, Point position)
    {
        this.Colour = colour;
        this.Position = position;
    }
    public virtual double Area
    {
        get { return 0; }
    }
    public virtual double Circumference
    {
        get { return 0; }
    }

    public override string ToString()
    {
        return $"Colour: {Colour}, X: {Position.X}, Y: {Position.Y}";
    }
}
