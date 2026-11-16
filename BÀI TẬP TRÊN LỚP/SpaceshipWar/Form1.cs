namespace SpaceshipWar;

public partial class Form1 : Form
{
	private readonly GameManager gameManager;

	public Form1()
	{
		InitializeComponent();
		FormBorderStyle = FormBorderStyle.FixedSingle;
		this.StartPosition = FormStartPosition.CenterScreen;
		MaximizeBox = false;
		DoubleBuffered = true;
		KeyPreview = true;

		// Khởi tạo Game Manager
		gameManager = new GameManager(ClientSize);

		FormClosed += (_, _) => gameManager.Dispose();

		timer1.Interval = 16;
		timer1.Start();
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
			case Keys.A: gameManager.Player.MoveLeft = true; break;
			case Keys.D: gameManager.Player.MoveRight = true; break;
			case Keys.W: gameManager.Player.MoveUp = true; break;
			case Keys.S: gameManager.Player.MoveDown = true; break;

			// Nhấn phím R khi Game Over để chơi lại
			case Keys.R:
				if (gameManager.IsGameOver)
				{
					gameManager.Restart();
				}
				break;
		}
	}

	private void Form1_KeyUp(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
			case Keys.A: gameManager.Player.MoveLeft = false; break;
			case Keys.D: gameManager.Player.MoveRight = false; break;
			case Keys.W: gameManager.Player.MoveUp = false; break;
			case Keys.S: gameManager.Player.MoveDown = false; break;
		}
	}

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			gameManager.FireRocket();
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		gameManager.Update();
		Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		gameManager.Draw(e.Graphics, Font);
	}
}