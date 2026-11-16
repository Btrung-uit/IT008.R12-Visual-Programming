namespace SpaceshipWar.Models;

public class HudRenderer : IDisposable
{
	private readonly Size screenSize;
	private readonly Font generalFont = new Font("Arial", 11, FontStyle.Bold);
	private readonly Font gameOverFont = new Font("Arial", 26, FontStyle.Bold);
	private readonly Font restartFont = new Font("Arial", 12, FontStyle.Bold);

	public HudRenderer(Size screenSize)
	{
		this.screenSize = screenSize;
	}

	public void DrawHUD(Graphics g, Spaceship player, int score)
	{
		// 1. HP
		string hpText = $"HP: {player.Hp}";
		g.DrawString(hpText, generalFont, Brushes.Black, 271, 11);
		g.DrawString(hpText, generalFont, Brushes.White, 270, 10);
		// 2. Rocket
		string rocketText = $"Rocket: {player.RocketLeft}";
		g.DrawString(rocketText, generalFont, Brushes.Black, 271, 31);
		g.DrawString(rocketText, generalFont, Brushes.Yellow, 270, 30);
		// 3. Score
		string pointText = $"Point: {score}";
		g.DrawString(pointText, generalFont, Brushes.Black, 271, 51);
		g.DrawString(pointText, generalFont, Brushes.Cyan, 270, 50);
	}

	public void DrawGameOver(Graphics g)
	{
		// Phủ mờ nền đen cho dễ nhìn
		using (var darkBrush = new SolidBrush(Color.FromArgb(150, 0, 0, 0)))
		{
			g.FillRectangle(darkBrush, 0, 0, screenSize.Width, screenSize.Height);
		}

		// Chữ GAMEOVER
		string gameOverText = "GAME OVER";
		SizeF titleSize = g.MeasureString(gameOverText, gameOverFont);
		g.DrawString(gameOverText, gameOverFont, Brushes.Red,
					(screenSize.Width - titleSize.Width) / 2,
					 screenSize.Height / 2 - 50);

		// 3. Vẽ hướng dẫn nhấn phím R để chơi lại
		string restartText = "Nhấn 'R' để chơi lại";
		SizeF restartSize = g.MeasureString(restartText, restartFont);
		g.DrawString(restartText, restartFont, Brushes.White,
					(screenSize.Width - restartSize.Width) / 2,
					 screenSize.Height / 2 + 10);
	}
	public void Dispose()
	{
		gameOverFont.Dispose();
		restartFont.Dispose();
	}
}
