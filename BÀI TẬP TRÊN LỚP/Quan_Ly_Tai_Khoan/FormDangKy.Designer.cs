namespace WinFormsApp2
{
	partial class FormDangKy
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			tbUsername = new TextBox();
			tbPassword = new TextBox();
			tbRePass = new TextBox();
			tbDiaChi = new TextBox();
			tbTen = new TextBox();
			btnDangKy = new Button();
			btnHuy = new Button();
			SuspendLayout();
			// 
			// lbDangKy
			// 
			lbDangKy.AutoSize = true;
			lbDangKy.Font = new Font("Segoe UI", 20F);
			lbDangKy.Location = new Point(324, 23);
			lbDangKy.Name = "lbDangKy";
			lbDangKy.Size = new Size(144, 46);
			lbDangKy.TabIndex = 0;
			lbDangKy.Text = "Đăng Ký";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(144, 99);
			label1.Name = "label1";
			label1.Size = new Size(75, 20);
			label1.TabIndex = 1;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(144, 146);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 2;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(144, 199);
			label3.Name = "label3";
			label3.Size = new Size(93, 20);
			label3.TabIndex = 3;
			label3.Text = "Re-Password";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(144, 254);
			label4.Name = "label4";
			label4.Size = new Size(55, 20);
			label4.TabIndex = 4;
			label4.Text = "Địa chỉ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(144, 301);
			label5.Name = "label5";
			label5.Size = new Size(32, 20);
			label5.TabIndex = 5;
			label5.Text = "Tên";
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(249, 96);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(353, 27);
			tbUsername.TabIndex = 6;
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(249, 143);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(353, 27);
			tbPassword.TabIndex = 7;
			tbPassword.UseSystemPasswordChar = true;
			// 
			// tbRePass
			// 
			tbRePass.Location = new Point(249, 196);
			tbRePass.Name = "tbRePass";
			tbRePass.Size = new Size(353, 27);
			tbRePass.TabIndex = 8;
			tbRePass.UseSystemPasswordChar = true;
			// 
			// tbDiaChi
			// 
			tbDiaChi.Location = new Point(249, 251);
			tbDiaChi.Name = "tbDiaChi";
			tbDiaChi.Size = new Size(353, 27);
			tbDiaChi.TabIndex = 9;
			// 
			// tbTen
			// 
			tbTen.Location = new Point(249, 298);
			tbTen.Name = "tbTen";
			tbTen.Size = new Size(353, 27);
			tbTen.TabIndex = 10;
			// 
			// btnDangKy
			// 
			btnDangKy.Location = new Point(418, 369);
			btnDangKy.Name = "btnDangKy";
			btnDangKy.Size = new Size(94, 29);
			btnDangKy.TabIndex = 11;
			btnDangKy.Text = "Đăng ký";
			btnDangKy.UseVisualStyleBackColor = true;
			btnDangKy.Click += btnDangKy_Click;
			// 
			// btnHuy
			// 
			btnHuy.Location = new Point(545, 369);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(94, 29);
			btnHuy.TabIndex = 12;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = true;
			btnHuy.Click += btnHuy_Click;
			// 
			// FormDangKy
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnHuy);
			Controls.Add(btnDangKy);
			Controls.Add(tbTen);
			Controls.Add(tbDiaChi);
			Controls.Add(tbRePass);
			Controls.Add(tbPassword);
			Controls.Add(tbUsername);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lbDangKy);
			Name = "FormDangKy";
			Text = "FormDangKy";
			FormClosed += Form2_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbDangKy;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox tbUsername;
		private TextBox tbPassword;
		private TextBox tbRePass;
		private TextBox tbDiaChi;
		private TextBox tbTen;
		private Button btnDangKy;
		private Button btnHuy;
	}
}
