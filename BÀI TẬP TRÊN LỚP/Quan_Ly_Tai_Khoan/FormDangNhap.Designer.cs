namespace WinFormsApp2
{
	partial class FormDangNhap
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tbUsername = new TextBox();
			tbPassword = new TextBox();
			lbUsername = new Label();
			lbPassword = new Label();
			lbTaoTaiKhoan = new LinkLabel();
			btnDangNhap = new Button();
			lbDangNhap = new Label();
			llbDoiMatKhau = new LinkLabel();
			SuspendLayout();
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(281, 140);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(306, 27);
			tbUsername.TabIndex = 0;
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(281, 207);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(306, 27);
			tbPassword.TabIndex = 1;
			tbPassword.UseSystemPasswordChar = true;
			// 
			// lbUsername
			// 
			lbUsername.AutoSize = true;
			lbUsername.Location = new Point(179, 143);
			lbUsername.Name = "lbUsername";
			lbUsername.Size = new Size(75, 20);
			lbUsername.TabIndex = 2;
			lbUsername.Text = "Username";
			// 
			// lbPassword
			// 
			lbPassword.AutoSize = true;
			lbPassword.Location = new Point(179, 210);
			lbPassword.Name = "lbPassword";
			lbPassword.Size = new Size(70, 20);
			lbPassword.TabIndex = 3;
			lbPassword.Text = "Password";
			// 
			// lbTaoTaiKhoan
			// 
			lbTaoTaiKhoan.AutoSize = true;
			lbTaoTaiKhoan.Font = new Font("Segoe UI", 8F);
			lbTaoTaiKhoan.Location = new Point(495, 237);
			lbTaoTaiKhoan.Name = "lbTaoTaiKhoan";
			lbTaoTaiKhoan.Size = new Size(92, 19);
			lbTaoTaiKhoan.TabIndex = 4;
			lbTaoTaiKhoan.TabStop = true;
			lbTaoTaiKhoan.Text = "Tạo tài khoản";
			lbTaoTaiKhoan.LinkClicked += lbTaoTaiKhoan_LinkClicked;
			// 
			// btnDangNhap
			// 
			btnDangNhap.Font = new Font("Segoe UI", 14F);
			btnDangNhap.Location = new Point(324, 307);
			btnDangNhap.Name = "btnDangNhap";
			btnDangNhap.Size = new Size(164, 42);
			btnDangNhap.TabIndex = 5;
			btnDangNhap.Text = "Đăng nhập";
			btnDangNhap.UseVisualStyleBackColor = true;
			btnDangNhap.Click += btnDangNhap_Click;
			// 
			// lbDangNhap
			// 
			lbDangNhap.AutoSize = true;
			lbDangNhap.Font = new Font("Segoe UI", 20F);
			lbDangNhap.Location = new Point(304, 57);
			lbDangNhap.Name = "lbDangNhap";
			lbDangNhap.Size = new Size(184, 46);
			lbDangNhap.TabIndex = 10;
			lbDangNhap.Text = "Đăng nhập";
			// 
			// llbDoiMatKhau
			// 
			llbDoiMatKhau.AutoSize = true;
			llbDoiMatKhau.Font = new Font("Segoe UI", 8F);
			llbDoiMatKhau.Location = new Point(396, 237);
			llbDoiMatKhau.Name = "llbDoiMatKhau";
			llbDoiMatKhau.Size = new Size(92, 19);
			llbDoiMatKhau.TabIndex = 11;
			llbDoiMatKhau.TabStop = true;
			llbDoiMatKhau.Text = "Đổi mật khẩu";
			llbDoiMatKhau.LinkClicked += llbDoiMatKhau_LinkClicked;
			// 
			// FormDangNhap
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(llbDoiMatKhau);
			Controls.Add(lbDangNhap);
			Controls.Add(btnDangNhap);
			Controls.Add(lbTaoTaiKhoan);
			Controls.Add(lbPassword);
			Controls.Add(lbUsername);
			Controls.Add(tbPassword);
			Controls.Add(tbUsername);
			Name = "FormDangNhap";
			Text = "FormDangNhap";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbUsername;
		private TextBox tbPassword;
		private Label lbUsername;
		private Label lbPassword;
		private LinkLabel lbTaoTaiKhoan;
		private Button btnDangNhap;
		private Label lbDangNhap;
		private LinkLabel llbDoiMatKhau;
	}
}
