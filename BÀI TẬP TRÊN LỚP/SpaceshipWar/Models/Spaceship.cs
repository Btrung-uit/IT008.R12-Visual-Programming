namespace SpaceshipWar.Models;

public class Spaceship : GameObject
{
	private readonly Image image;
	public float Speed {get; set; } = 5f;
	public int Hp {get; set; } = 10;
	public int RocketLeft {get; set; } = 30;

	public bool MoveLeft {get; set; }
	public bool MoveRight {get; set; }
	public bool MoveUp {get; set; }
	public bool MoveDown {get; set; }

	public Spaceship(float x, float y, float size, Image img) : base(x, y, size, size)
	{
		image = img;
	}

	public override void Update()
	{
		if(MoveLeft) X -= Speed;
		if(MoveRight) X += Speed;
		if(MoveUp) Y -= Speed;
		if(MoveDown) Y += Speed;
	}

	// Giữ tàu không bay ra khỏi màn hình
	public void ClampToBounds(int screenWidth, int screenHeight)
	{
		X = Math.Clamp(X, 0, screenWidth - Width);
		Y = Math.Clamp(Y, 0, screenHeight - Height);
	}

	public override void Draw(Graphics g)
	{
		g.DrawImage(image, X, Y, Width, Height);
	}
}
