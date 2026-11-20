namespace SpaceshipWar;

public partial class Form1 : Form
{
	private readonly GameManager gameManager;
	private bool spaceHeld;

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
		SetMovement(e.KeyCode, true);
		switch (e.KeyCode)
		{
			case Keys.Space when !spaceHeld:
				spaceHeld = true;
				gameManager.FireRocket(gameManager.Player1);
				break;

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
		SetMovement(e.KeyCode, false);
		if (e.KeyCode == Keys.Space) spaceHeld = false;
	}

	protected override bool IsInputKey(Keys keyData)
	{
		return (keyData & Keys.KeyCode) is Keys.Left or Keys.Right or Keys.Up or Keys.Down
			|| base.IsInputKey(keyData);
	}

	protected override void OnDeactivate(EventArgs e)
	{
		gameManager.Player1.StopMoving();
		gameManager.Player2.StopMoving();
		spaceHeld = false;
		base.OnDeactivate(e);
	}

	private void SetMovement(Keys key, bool pressed)
	{
		switch (key)
		{
			case Keys.A: gameManager.Player1.MoveLeft = pressed; break;
			case Keys.D: gameManager.Player1.MoveRight = pressed; break;
			case Keys.W: gameManager.Player1.MoveUp = pressed; break;
			case Keys.S: gameManager.Player1.MoveDown = pressed; break;
			case Keys.Left: gameManager.Player2.MoveLeft = pressed; break;
			case Keys.Right: gameManager.Player2.MoveRight = pressed; break;
			case Keys.Up: gameManager.Player2.MoveUp = pressed; break;
			case Keys.Down: gameManager.Player2.MoveDown = pressed; break;
		}
	}

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			gameManager.FireRocket(gameManager.Player2);
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
