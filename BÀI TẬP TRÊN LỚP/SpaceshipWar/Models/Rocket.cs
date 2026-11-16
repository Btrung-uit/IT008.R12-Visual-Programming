namespace SpaceshipWar.Models;

public class Rocket : GameObject
{
	private readonly Image image;
	public float DX {get; set; }
	public float DY {get; set; }

	public Rocket(float x, float y, float width, float height, float dx, float dy, Image img) : base(x, y, width, height)
	{
		DX = dx;
		DY = dy;
		image = img;
	}

	// Điểm bắt đầu vẽ theo tâm của Rocket
	public override RectangleF Bounds => 
		new RectangleF(X - Width / 2f, Y - Height / 2f, Width, Height);

	public override void Update()
	{
		X += DX;
		Y += DY;
	}

	public override void Draw(Graphics g)
	{
		var state = g.Save();
		g.TranslateTransform(X, Y);
		g.DrawImage(image, -Width / 2f, -Height / 2f, Width, Height);
		g.Restore(state);
	}
 }
