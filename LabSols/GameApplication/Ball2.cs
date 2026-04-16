using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.v2;

public class Ball
{
    public Rectangle Rec;
    public Rectangle World;
    private int dirX, dirY;

    public Ball(Rectangle rec, int dirX, int dirY)
    {
        World = new Rectangle(10, 10, 600, 400);
        this.Rec = rec;
        this.dirX = dirX;
        this.dirY = dirY;
    }
    public void Move()
    {
        Rec.Offset(dirX, dirY);
        int dx=0, dy=0;
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


