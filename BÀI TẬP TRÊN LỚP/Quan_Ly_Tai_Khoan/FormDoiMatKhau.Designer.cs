namespace WinFormsApp2
{
	partial class FormDoiMatKhau
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lbDangKy = new Label();
			lbUsername = new Label();
			lbMatKhauCu = new Label();
			lbMatKhauMoi = new Label();
			lbXacNhanMatKhau = new Label();
			tbUsername = new TextBox();
			tbMatKhauCu = new TextBox();
			tbMatKhauMoi = new TextBox();
			tbXacNhanMatKhau = new TextBox();
			btnLuu = new Button();
			btnHuy = new Button();
			SuspendLayout();
			// 
			// lbDangKy
			// 
			lbDangKy.AutoSize = true;
			lbDangKy.Font = new Font("Segoe UI", 20F);
			lbDangKy.Location = new Point(257, 47);
			lbDangKy.Name = "lbDangKy";
			lbDangKy.Size = new Size(225, 46);
			lbDangKy.TabIndex = 1;
			lbDangKy.Text = "Đổi Mật Khẩu";
			// 
			// lbUsername
			// 
			lbUsername.AutoSize = true;
			lbUsername.Location = new Point(112, 124);
			lbUsername.Name = "lbUsername";
			lbUsername.Size = new Size(75, 20);
			lbUsername.TabIndex = 2;
			lbUsername.Text = "Username";
			// 
			// lbMatKhauCu
			// 
			lbMatKhauCu.AutoSize = true;
			lbMatKhauCu.Location = new Point(112, 180);
			lbMatKhauCu.Name = "lbMatKhauCu";
			lbMatKhauCu.Size = new Size(89, 20);
			lbMatKhauCu.TabIndex = 3;
			lbMatKhauCu.Text = "Mật khẩu cũ";
			// 
			// lbMatKhauMoi
			// 
			lbMatKhauMoi.AutoSize = true;
			lbMatKhauMoi.Location = new Point(112, 242);
			lbMatKhauMoi.Name = "lbMatKhauMoi";
			lbMatKhauMoi.Size = new Size(100, 20);
			lbMatKhauMoi.TabIndex = 4;
			lbMatKhauMoi.Text = "Mật khẩu mới";
			// 
			// lbXacNhanMatKhau
			// 
			lbXacNhanMatKhau.AutoSize = true;
			lbXacNhanMatKhau.Location = new Point(112, 305);
			lbXacNhanMatKhau.Name = "lbXacNhanMatKhau";
			lbXacNhanMatKhau.Size = new Size(134, 20);
			lbXacNhanMatKhau.TabIndex = 5;
			lbXacNhanMatKhau.Text = "Xác nhận mật khẩu";
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(268, 121);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(383, 27);
			tbUsername.TabIndex = 6;
			// 
			// tbMatKhauCu
			// 
			tbMatKhauCu.Location = new Point(268, 177);
			tbMatKhauCu.Name = "tbMatKhauCu";
			tbMatKhauCu.Size = new Size(383, 27);
			tbMatKhauCu.TabIndex = 7;
			tbMatKhauCu.UseSystemPasswordChar = true;
			// 
			// tbMatKhauMoi
			// 
			tbMatKhauMoi.Location = new Point(268, 239);
			tbMatKhauMoi.Name = "tbMatKhauMoi";
			tbMatKhauMoi.Size = new Size(383, 27);
			tbMatKhauMoi.TabIndex = 8;
			tbMatKhauMoi.UseSystemPasswordChar = true;
			// 
			// tbXacNhanMatKhau
			// 
			tbXacNhanMatKhau.Location = new Point(268, 302);
			tbXacNhanMatKhau.Name = "tbXacNhanMatKhau";
			tbXacNhanMatKhau.Size = new Size(383, 27);
			tbXacNhanMatKhau.TabIndex = 9;
			tbXacNhanMatKhau.UseSystemPasswordChar = true;
			// 
			// btnLuu
			// 
			btnLuu.Location = new Point(464, 370);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(85, 32);
			btnLuu.TabIndex = 10;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// btnHuy
			// 
			btnHuy.Location = new Point(566, 370);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(85, 32);
			btnHuy.TabIndex = 11;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = true;
			btnHuy.Click += btnHuy_Click;
			// 
			// FormDoiMatKhau
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnHuy);
			Controls.Add(btnLuu);
			Controls.Add(tbXacNhanMatKhau);
			Controls.Add(tbMatKhauMoi);
			Controls.Add(tbMatKhauCu);
			Controls.Add(tbUsername);
			Controls.Add(lbXacNhanMatKhau);
			Controls.Add(lbMatKhauMoi);
			Controls.Add(lbMatKhauCu);
			Controls.Add(lbUsername);
			Controls.Add(lbDangKy);
			Name = "FormDoiMatKhau";
			Text = "FormDoiMatKhau";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbDangKy;
		private Label lbUsername;
		private Label lbMatKhauCu;
		private Label lbMatKhauMoi;
		private Label lbXacNhanMatKhau;
		private TextBox tbUsername;
		private TextBox tbMatKhauCu;
		private TextBox tbMatKhauMoi;
		private TextBox tbXacNhanMatKhau;
		private Button btnLuu;
		private Button btnHuy;
	}
}