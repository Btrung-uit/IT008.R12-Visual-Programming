namespace SpaceshipWar.Models;

public class Spawner
{
	private readonly Size screenSize;
	private readonly Random random = new();

	// Ảnh tài nguyên cần để sinh đối tượng
	private readonly Image meteorImage;
	private readonly Image rocketRefillImage;
	private readonly Image heartImage;
	
	// Kích thước các vật phẩm
	public const int MeteorSize = 40;
	public const int RocketRefillSize = 30;
	public const int HeartSize = 20;

	// Các biến đếm nhịp sinh
	private int spawnMeteorCounter = 0;
	private int spawnRocketRefillCounter = 0;
	private int spawnHeartCounter = 0;

	// 5 giây đâu tiên không xuất hiện nạp rocket
	public int timeToSpawnRocket = 300;
	public bool isSpawnRocket = false;

	// 10 giây đầu tiên không xuất hiện trái tim
	private int timeToSpawnHeart = 600;
	private bool isSpawnHeart = false;

	public Spawner(Size screenSize, Image meteorImg, Image rocketRefillImg, Image heartImg)
	{
		this.screenSize = screenSize;
		this.meteorImage = meteorImg;
		this.rocketRefillImage = rocketRefillImg;
		this.heartImage = heartImg;
	}

	// Hàm cập nhậ sinh đồ mỗi frame
	public void Update(List<Meteor> meteors, List<RocketRefill> rocketRefills, List<Heart> hearts)
	{
		// 1.1 Sinh thiên thạch
		if (++spawnMeteorCounter >= 10)
		{
			meteors.Add(CreateMeteor());
			spawnMeteorCounter = 0;
		}
		// 1.2 Sinh nạp tên lửa
		// isSpawnRocket mục đích là để 5 giây đầu không sinh Nạp Rocket
		if (isSpawnRocket)
		{
			if (++spawnRocketRefillCounter >= random.Next(250, 350))
			{
				rocketRefills.Add(CreateRocketRefill());
				spawnRocketRefillCounter = 0;
			}
		}
		else
		{
			// Đếm ngược 5s
			if (--timeToSpawnRocket <= 0)
			{
				isSpawnRocket = true;
			}
		}
		// 1.3 Sinh trái tim
		// isSpawnRocket mục đích là để 10 giây đầu không sinh Heart
		if (isSpawnHeart)
		{
			if (++spawnHeartCounter >= random.Next(250, 350))
			{
				hearts.Add(CreateHeart());
				spawnHeartCounter = 0;
			}
		}
		else
		{
			// Đếm ngược 10s
			if (--timeToSpawnHeart <= 0)
			{
				isSpawnHeart = true;
			}
		}
	}
	// Hàm sinh thiên thạch ngẫu nhiên
	public Meteor CreateMeteor()
	{
		int x = random.Next(screenSize.Width - MeteorSize + 1);
		int speed = random.Next(4, 10);
		return new Meteor(x, -MeteorSize, MeteorSize, speed, meteorImage);
	}
	// Hàm sinh nạp rocket ngẫu nhiên
	public RocketRefill CreateRocketRefill()
	{
		int x = random.Next(10, screenSize.Width - RocketRefillSize - 10);
		int y = random.Next(50, screenSize.Height - RocketRefillSize - 30);
		return new RocketRefill(x, y, RocketRefillSize, rocketRefillImage);
	}
	// Hàm sinh heart ngẫu nhiên
	public Heart CreateHeart()
	{
		int x = random.Next(10, screenSize.Width - RocketRefillSize - 10);
		int y = random.Next(50, screenSize.Height - RocketRefillSize - 30);
		return new Heart(x, y, HeartSize, heartImage);
	}

	public void Reset()
	{
		spawnMeteorCounter = 0;
		timeToSpawnRocket = 300;
		isSpawnRocket = false;
		timeToSpawnHeart = 300;
		isSpawnHeart = false;
	}
}
