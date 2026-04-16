using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.v3;

public class Ball
{
    public Rectangle Rec;
    public Rectangle World;
    private int dirX, dirY;
    public SHAPE_TYPE ShapeType { get; set; } = SHAPE_TYPE.Rectangle;
    public Ball(Rectangle rec, int dirX, int dirY)
                : this(rec, dirX, dirY, SHAPE_TYPE.Rectangle)
    // or set a default value during declaration
    {
    }
    public Ball(Rectangle rec, int dirX, int dirY, SHAPE_TYPE shapeType)
    {
        World = new Rectangle(10, 10, 600, 400);
        this.Rec = rec;
        this.dirX = dirX;
        this.dirY = dirY;
        this.ShapeType = shapeType;
    }
    public void Move()
    {
        Rec.Offset(dirX, dirY);
        int dx = 0, dy = 0;
        if (Rec.Left < World.Left || Rec.Right > World.Right)
        {
            dirX = -dirX;
            dx = dirX;
        }
        if (Rec.Top < World.Top || Rec.Bottom > World.Bottom)
        {
            dirY = -dirY;
            dy = dirY;
        }
        Rec.Offset(dx, dy);
    }
}
