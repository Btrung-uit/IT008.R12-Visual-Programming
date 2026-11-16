namespace SpaceshipWar.Models;

public class Explosion : GameObject
{
	private readonly Image image;
	public int TicksLeft {get; set; } = 8;
	public bool IsFinished => TicksLeft <= 0;

	public Explosion(float x, float y, float size, Image img) : base(x, y, size, size)
	{
		image = img;
	}

	public override void Update()
	{
		TicksLeft--;
	}

	public override void Draw(Graphics g)
	{
		g.DrawImage(image, X, Y, Width, Height);
	}
}
