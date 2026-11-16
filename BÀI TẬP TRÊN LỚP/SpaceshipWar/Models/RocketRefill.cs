namespace SpaceshipWar.Models;

public class RocketRefill : GameObject
{
	private readonly Image image;
	public RocketRefill(float x, float y, float size, Image img) : base(x, y, size, size)
	{ 
		image = img;
	}
	public override void Update()
	{
		Y += 2f;
	}
	public override void Draw(Graphics g)
	{
		g.DrawImage(image, X, Y, Width, Height);
	}
}
