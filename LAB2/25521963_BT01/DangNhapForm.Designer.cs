namespace _25521963_BT01
{
	partial class DangNhapForm
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
			lbDangNhap = new Label();
			label1 = new Label();
			tbTenDangNhap = new TextBox();
			tbMatKhau = new TextBox();
			label2 = new Label();
			btnDangNhap = new Button();
			btnHuy = new Button();
			SuspendLayout();
			// 
			// lbDangNhap
			// 
			lbDangNhap.AutoSize = true;
			lbDangNhap.Font = new Font("Segoe UI", 16F);
			lbDangNhap.Location = new Point(306, 50);
			lbDangNhap.Name = "lbDangNhap";
			lbDangNhap.Size = new Size(153, 37);
			lbDangNhap.TabIndex = 0;
			lbDangNhap.Text = "Đăng Nhập";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(103, 145);
			label1.Name = "label1";
			label1.Size = new Size(110, 20);
			label1.TabIndex = 1;
			label1.Text = "Tên đăng nhập:";
			// 
			// tbTenDangNhap
			// 
			tbTenDangNhap.Location = new Point(240, 142);
			tbTenDangNhap.Name = "tbTenDangNhap";
			tbTenDangNhap.Size = new Size(455, 27);
			tbTenDangNhap.TabIndex = 2;
			// 
			// tbMatKhau
			// 
			tbMatKhau.Location = new Point(241, 212);
			tbMatKhau.Name = "tbMatKhau";
			tbMatKhau.Size = new Size(455, 27);
			tbMatKhau.TabIndex = 4;
			tbMatKhau.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(104, 215);
			label2.Name = "label2";
			label2.Size = new Size(73, 20);
			label2.TabIndex = 3;
			label2.Text = "Mật khẩu:";
			// 
			// btnDangNhap
			// 
			btnDangNhap.Location = new Point(440, 280);
			btnDangNhap.Name = "btnDangNhap";
			btnDangNhap.Size = new Size(125, 29);
			btnDangNhap.TabIndex = 5;
			btnDangNhap.Text = "Đăng nhập";
			btnDangNhap.UseVisualStyleBackColor = true;
			btnDangNhap.Click += btnDangNhap_Click;
			// 
			// btnHuy
			// 
			btnHuy.Location = new Point(571, 280);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(125, 29);
			btnHuy.TabIndex = 6;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = true;
			btnHuy.Click += btnHuy_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnHuy);
			Controls.Add(btnDangNhap);
			Controls.Add(tbMatKhau);
			Controls.Add(label2);
			Controls.Add(tbTenDangNhap);
			Controls.Add(label1);
			Controls.Add(lbDangNhap);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbDangNhap;
		private Label label1;
		private TextBox tbTenDangNhap;
		private TextBox tbMatKhau;
		private Label label2;
		private Button btnDangNhap;
		private Button btnHuy;
	}
}
