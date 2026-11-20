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

	public void DrawPlayers(Graphics g, Spaceship player1, Spaceship player2)
	{
		if (player1.IsAlive) player1.Draw(g);
		if (player2.IsAlive) player2.Draw(g);

		if (player1.IsAlive)
		{
			DrawText(g, "P1", Brushes.Cyan, player1.X, Math.Max(0, player1.Y - generalFont.Height));
		}
		if (player2.IsAlive)
		{
			float labelX = player2.Bounds.Right - g.MeasureString("P2", generalFont).Width;
			DrawText(g, "P2", Brushes.Yellow, labelX, Math.Max(0, player2.Y - generalFont.Height));
		}
	}

	public void DrawHUD(Graphics g, Spaceship player1, Spaceship player2, int score)
	{
		string p1Text = $"P1  HP: {player1.Hp}\nRocket: {player1.RocketLeft}";
		string p2Text = $"P2  HP: {player2.Hp}\nRocket: {player2.RocketLeft}";
		string pointText = $"Point: {score}";
		DrawText(g, p1Text, Brushes.Cyan, 10, 10);
		DrawText(g, p2Text, Brushes.Yellow, screenSize.Width - g.MeasureString(p2Text, generalFont).Width - 10, 10);
		DrawText(g, pointText, Brushes.White, (screenSize.Width - g.MeasureString(pointText, generalFont).Width) / 2, 10);
	}

	private void DrawText(Graphics g, string text, Brush color, float x, float y)
	{
		g.DrawString(text, generalFont, Brushes.Black, x + 1, y + 1);
		g.DrawString(text, generalFont, color, x, y);
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
		generalFont.Dispose();
		gameOverFont.Dispose();
		restartFont.Dispose();
	}
}
