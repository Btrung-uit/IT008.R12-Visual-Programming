namespace SpaceshipWar.Models;

public class Meteor : GameObject
{
	private readonly Image image;
	public float Speed {get; set; }

	public Meteor(float x, float y, float size, float speed, Image img) : base(x, y, size, size)
	{
		Speed = speed;
		image = img;
	}

	public override void Update()
	{
		Y += Speed;
	}

	public override void Draw(Graphics g)
	{
		g.DrawImage(image, X, Y, Width, Height);
	}
}
