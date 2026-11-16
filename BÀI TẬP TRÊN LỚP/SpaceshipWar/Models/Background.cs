namespace SpaceshipWar.Models;

public class Background : IDisposable
{
	private readonly Image image;
	private readonly Size screenSize;
	private float y = 0f;
	public float Speed {get; set; } = 2.5f;

	public Background(Size screenSize, string imagePath)
	{
		this.screenSize = screenSize;
		image = Image.FromFile(imagePath);
	}

	public void Update()
	{
		y += Speed;
		if (y >= screenSize.Height)
		{
			y-= screenSize.Height;
		}
	}

	public void Draw(Graphics g)
	{
		g.DrawImage(image, 0, y, screenSize.Width, screenSize.Height + 1);
		g.DrawImage(image, 0, y - screenSize.Height, screenSize.Width, screenSize.Height + 1);
	}

	public void Dispose()
	{
		image.Dispose();
	}
}
