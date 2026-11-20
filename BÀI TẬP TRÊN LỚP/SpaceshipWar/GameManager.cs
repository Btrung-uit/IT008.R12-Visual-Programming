using SpaceshipWar.Models;

namespace SpaceshipWar;

public class GameManager : IDisposable
{
	private readonly Size screenSize;

	// Ảnh tài nguyên
	private readonly Image spaceshipImage;
	private readonly Image rocketImage;
	private readonly Image meteorImage;
	private readonly Image rocketRefillImage;
	private readonly Image heartImage;
	private readonly Image explosionImage;
	private readonly Background background;
	private readonly HudRenderer hudRenderer;
	private readonly Spawner spawner;

	// Các thực thể
	public Spaceship Player1 { get; private set; }
	public Spaceship Player2 { get; private set; }
	public List<Meteor> Meteors { get; } = new();
	public List<Rocket> Rockets { get; } = new();
	public List<Explosion> Explosions { get; } = new();
	public List<RocketRefill> RocketRefills { get; } = new();
	public List<Heart> Hearts { get; } = new();

	public int Score { get; private set; } = 0;

	// Kích thước hằng số
	public const int SpaceshipSize = 50;
	public const int RocketWidth = 12;
	public const int RocketHeight = 35;
	public const int ExplosionSize = 40;

	public bool IsGameOver => !Player1.IsAlive && !Player2.IsAlive;


	// Constructor
	public GameManager(Size clientSize)
	{
		screenSize = clientSize;
		hudRenderer = new HudRenderer(screenSize);

		// Load ảnh
		background = new Background(screenSize,	Path.Combine(AppContext.BaseDirectory, "asset", "space_bg.png"));
		meteorImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "asset", "thien_thach.png"));
		spaceshipImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "asset", "spaceship.png"));
		rocketImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "asset", "rocket.png"));
		rocketRefillImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "asset", "rocket_refill.png"));
		explosionImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "asset", "explosion.png"));
		heartImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "asset", "heart.png"));

		// Sinh vật phẩm
		spawner = new Spawner(screenSize, meteorImage, rocketRefillImage, heartImage);

		// Khởi tạo tàu
		Player1 = CreatePlayer(screenSize.Width / 4f);
		Player2 = CreatePlayer(screenSize.Width * 3 / 4f);

		// Nạp âm thanh
		SoundManager.Load("bgm.mp3", "bgm");
		SoundManager.Load("laser.WAV", "laser");
		SoundManager.Load("explosion_sound.wav", "explosion_sound");
		SoundManager.Load("crash.wav", "crash");
		SoundManager.Load("game_over.wav", "game_over");
		SoundManager.Load("get_point.wav", "get_point");
		SoundManager.Load("level_up.wav", "level_up");
		SoundManager.Load("falling_gameover.wav", "falling_gameover");
		SoundManager.Load("no_rocket.wav", "no_rocket");
		SoundManager.Load("heart_recharge.wav", "heart_recharge");

		// Phát nền lặp lại
		SoundManager.Play("bgm", loop: true);
	}

	// Tạo người chơi
	private Spaceship CreatePlayer(float centerX)
	{
		float startY = screenSize.Height - SpaceshipSize - 10;
		return new Spaceship(centerX - SpaceshipSize / 2f, startY, SpaceshipSize, spaceshipImage);
	}

	// Hàm bắn rocket
	public void FireRocket(Spaceship player)
	{
		if (!player.IsAlive) return;

		float startX = player.X + player.Width / 2f;
		// Kiểm tra xem có còn rocket không, nếu hết thì không cho bắn
		if (player.RocketLeft <= 0)
		{
			// phát âm thanh hết đạn
			SoundManager.Play("no_rocket");
			return;
		}
		player.RocketLeft--;
		Rockets.Add(new Rocket(startX, player.Y, RocketWidth, RocketHeight, 0, -10, rocketImage));

		// Phát tiếng bắn đạn
		SoundManager.Play("laser");
	}
	
	// Cập nhật các thực thể
	public void Update()
	{
		if (IsGameOver) return; // Dừng toàn bộ logic khi thua

		background.Update();
		spawner.Update(Meteors, RocketRefills, Hearts);
		CleanupOutOfBounds();
		UpdateEntity();
		CheckCollisions();

	}

	// Xóa vật phẩm vượt ra khỏi màn hình
	private void CleanupOutOfBounds()
	{
		Meteors.RemoveAll(m => m.Y >= screenSize.Height);
		Rockets.RemoveAll(r => r.Y + RocketHeight / 2f < 0);
		RocketRefills.RemoveAll(r => r.Y >= screenSize.Height);
		Hearts.RemoveAll(r => r.Y >= screenSize.Height);
		Explosions.RemoveAll(e => e.IsFinished);
	}

	// Cập nhật các vật thể
	private void UpdateEntity()
	{
		UpdatePlayer(Player1);
		UpdatePlayer(Player2);
		Meteors.ForEach(m => m.Update());
		Rockets.ForEach(r => r.Update());
		Explosions.ForEach(e => e.Update());
		RocketRefills.ForEach(r => r.Update());
		Hearts.ForEach(h => h.Update());
	}

	// Cập nhật player
	private void UpdatePlayer(Spaceship player)
	{
		if (!player.IsAlive) return;

		player.Update();
		player.ClampToBounds(screenSize.Width, screenSize.Height);
	}

	// Kiểm tra va chạm
	private void CheckCollisions()
	{
		CheckPlayerCollision(Player1);
		CheckPlayerCollision(Player2);
		CheckRocketCollision();

		if (IsGameOver)
		{
			SoundManager.Stop("bgm");
			SoundManager.Play("game_over");
			SoundManager.Play("falling_gameover");
		}
	}
	private void CheckPlayerCollision(Spaceship player)
	{
		if (!player.IsAlive) return;

		// Va chạm giữa Player và Meteor
		for (int i = Meteors.Count - 1; i >= 0; i--)
		{
			if (player.Bounds.IntersectsWith(Meteors[i].Bounds))
			{
				player.Hp--;
				RectangleF collision = RectangleF.Intersect(player.Bounds, Meteors[i].Bounds);
				Explosions.Add(new Explosion(collision.Left + collision.Width / 2f - ExplosionSize / 2f,
											 collision.Top + collision.Height / 2f - ExplosionSize / 2f,
											 ExplosionSize, explosionImage));
				Meteors.RemoveAt(i);

				// Phát âm thanh tàu bị tông
				SoundManager.Play("crash");
				if (!player.IsAlive) return;
			}
		}
		// Va chạm giữa Player và RocketRefill
		for (int i = RocketRefills.Count - 1; i >= 0; i--)
		{
			if (player.Bounds.IntersectsWith(RocketRefills[i].Bounds))
			{
				// Mỗi lần nhặt được RocketRefill thì + 10 rocket
				player.RocketLeft += 20;
				RocketRefills.RemoveAt(i);

				// Phát âm thanh get point
				SoundManager.Play("get_point");
			}
		}
		// Va chạm giữa Player và Heart
		for (int i = Hearts.Count - 1; i >= 0; i--)
		{
			if (player.Bounds.IntersectsWith(Hearts[i].Bounds))
			{
				// Mỗi lần nhặt được Heart thì + 1 heart
				player.Hp += 1;
				Hearts.RemoveAt(i);

				// Phát âm thanh get point
				SoundManager.Play("heart_recharge");
			}
		}
	}
	private void CheckRocketCollision()
	{
		for (int i = Rockets.Count - 1; i >= 0; i--)
		{
			for (int j = Meteors.Count - 1; j >= 0; j--)
			{
				if (Rockets[i].Bounds.IntersectsWith(Meteors[j].Bounds))
				{
					RectangleF collision = RectangleF.Intersect(Rockets[i].Bounds, Meteors[j].Bounds);
					Explosions.Add(new Explosion(collision.Left + collision.Width / 2f - ExplosionSize / 2f,
												 collision.Top + collision.Height / 2f - ExplosionSize / 2f,
												 ExplosionSize, explosionImage));
					Rockets.RemoveAt(i);
					Meteors.RemoveAt(j);
					Score++;
					SoundManager.Play("explosion_sound");
					break;
				}
			}
		}
	}

	// Chơi lại
	public void Restart()
	{
		// Reset các thông số về mặc định
		Score = 0;
		spawner.Reset();
		Meteors.Clear();
		Rockets.Clear();
		Explosions.Clear();
		RocketRefills.Clear();
		Hearts.Clear();
		Player1 = CreatePlayer(screenSize.Width / 4f);
		Player2 = CreatePlayer(screenSize.Width * 3 / 4f);

		// Dừng các âm thanh gameover và phát nhạc nền lại
		SoundManager.Stop("game_over");
		SoundManager.Stop("falling_gameover");
		SoundManager.Play("bgm", loop: true);
	}
	public void Draw(Graphics g, Font font)
	{
		background.Draw(g);
		Meteors.ForEach(m => m.Draw(g));
		Rockets.ForEach(r => r.Draw(g));
		RocketRefills.ForEach(r => r.Draw(g));
		Hearts.ForEach(h => h.Draw(g));
		hudRenderer.DrawPlayers(g, Player1, Player2);
		Explosions.ForEach(e => e.Draw(g));
		hudRenderer.DrawHUD(g, Player1, Player2, Score);

		if (IsGameOver)
		{
			hudRenderer.DrawGameOver(g);

		}
	}
	public void Dispose()
	{
		background.Dispose();
		meteorImage.Dispose();
		spaceshipImage.Dispose();
		rocketImage.Dispose();
		rocketRefillImage.Dispose();
		explosionImage.Dispose();
		heartImage.Dispose();
		hudRenderer.Dispose();

		// Dọn dẹp âm thanh
		SoundManager.Close("bgm");
		SoundManager.Close("laser");
		SoundManager.Close("explosion_sound");
		SoundManager.Close("crash");
		SoundManager.Close("game_over");
		SoundManager.Close("falling_gameover");
		SoundManager.Close("heart_recharge");
	}

}
