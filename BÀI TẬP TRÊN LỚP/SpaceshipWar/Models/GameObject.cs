namespace SpaceshipWar.Models;

public abstract class GameObject
{
	public float X {get; set; }
	public float Y {get; set; }
	public float Width {get; set; }
	public float Height {get; set; }

	// Hitbox dùng để tính toán va chạm
	public virtual RectangleF Bounds => new RectangleF(X, Y, Width, Height);

	protected GameObject(float x, float y, float width, float height)
	{
		X = x;
		Y = y;
		Width = width;
		Height = height;
	}

	// Mỗi đối tượng con tự định nghĩa cách di chuyển và vẽ
	public abstract void Update();
	public abstract void Draw(Graphics g);
}
