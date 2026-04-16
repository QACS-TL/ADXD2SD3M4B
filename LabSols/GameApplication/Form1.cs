namespace GameApplication;

using Timer = System.Windows.Forms.Timer;
public partial class Form1 : Form
{
    private GameApp.v1.Ball[] balls = new GameApp.v1.Ball[3];
    private GameApp.v2.Ball[] balls2 = new GameApp.v2.Ball[3];
    private GameApp.v3.Ball[] balls3 = new GameApp.v3.Ball[3]; 
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.Clear(Color.Gray);
        // Draw the world!
        e.Graphics.FillRectangle(Brushes.LightBlue, 10, 10, 600, 400);

        foreach (var b in balls)
        {
            b.Move();
            e.Graphics.DrawEllipse(Pens.Black, b.x, b.y, b.w, b.h);
        }
        foreach (var b in balls2)
        {
            b.Move();
            e.Graphics.DrawRectangle(Pens.Red, b.Rec);
        }
        foreach (var b in balls3)
        {
            b.Move();
            switch(b.ShapeType)
            {
                case GameApp.v3.SHAPE_TYPE.RoundRectangle:
                    e.Graphics.DrawRoundedRectangle(Pens.Green, b.Rec, new Size(10,10));
                    break;
                case GameApp.v3.SHAPE_TYPE.ThreeDRectangle:
                    e.Graphics.DrawRectangle(Pens.Green, b.Rec);
                    e.Graphics.DrawLine(Pens.Green, b.Rec.Left, b.Rec.Top, b.Rec.Left + 10, b.Rec.Top - 10);
                    e.Graphics.DrawLine(Pens.Green, b.Rec.Right, b.Rec.Top, b.Rec.Right + 10, b.Rec.Top - 10);
                    e.Graphics.DrawLine(Pens.Green, b.Rec.Left, b.Rec.Bottom, b.Rec.Left + 10, b.Rec.Bottom - 10);
                    e.Graphics.DrawLine(Pens.Green, b.Rec.Right, b.Rec.Bottom, b.Rec.Right + 10, b.Rec.Bottom - 10);
                    Rectangle backFace = new Rectangle(
                        b.Rec.Left + 10,
                        b.Rec.Top - 10,
                        b.Rec.Width,
                        b.Rec.Height
                    );
                    e.Graphics.DrawRectangle(Pens.Green, backFace);
                    break;
                case GameApp.v3.SHAPE_TYPE.Oval:
                    e.Graphics.DrawEllipse(Pens.Green, b.Rec);
                    break;
            }
            //e.Graphics.DrawRectangle(Pens.Green, b.Rec);
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        balls[0] = new GameApp.v1.Ball(100, 100, 50, 50, 3, 4);
        balls[1] = new GameApp.v1.Ball(200, 300, 50, 50, 4, 2);
        balls[2] = new GameApp.v1.Ball(300, 100, 50, 50, 2, 1);

        balls2[0] = new GameApp.v2.Ball(new Rectangle(100, 100, 50, 50), 5, 6);
        balls2[1] = new GameApp.v2.Ball(new Rectangle(200, 300, 50, 50), 6, 3);
        balls2[2] = new GameApp.v2.Ball(new Rectangle(300, 100, 50, 50), 4, 5);


        balls3[0] = new GameApp.v3.Ball(new Rectangle(100, 100, 50, 50), 7, 8, GameApp.v3.SHAPE_TYPE.RoundRectangle );
        balls3[1] = new GameApp.v3.Ball(new Rectangle(200, 300, 50, 50), 9, 10, GameApp.v3.SHAPE_TYPE.ThreeDRectangle);
        balls3[2] = new GameApp.v3.Ball(new Rectangle(300, 100, 40, 60), 8, 4, GameApp.v3.SHAPE_TYPE.Oval);


        Timer t = new Timer();
        t.Interval = 50;
        t.Tick += T_Tick;
        t.Start();
    }

    private void T_Tick(object? sender, EventArgs e)
    {
        this.Invalidate();
    }
}