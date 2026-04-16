namespace GameApp.v1;
public class Ball
{
    public int x, y, w, h;
    public int worldX = 10, worldY = 10, worldW = 600, worldH = 400;
    private int dirX, dirY;

    public Ball(int x, int y, int w, int h, int dirX, int dirY)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
        this.dirX = dirX;
        this.dirY = dirY;
    }
    public void Move()
    {
        x += dirX;
        y += dirY;

        if (x < worldX)
        {
            x = 10;
            dirX = -dirX;
        }
        if (x > worldW - w)
        {
            x = worldW - w;
            dirX = -dirX;

        }
        if (y < worldY)
        {
            y = worldY;
            dirY = -dirY;
        }
        if (y > worldH - h)
        {
            y = worldH - h;
            dirY = -dirY;
        }
    }
}


