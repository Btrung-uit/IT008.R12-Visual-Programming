namespace WinFormsApp2
{
	partial class FormHome
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
			lbHoSoCaNhan = new Label();
			lbUsername = new Label();
			lbDiaChi = new Label();
			lbTen = new Label();
			lbNgaySinh = new Label();
			lbSDT = new Label();
			label1 = new Label();
			tbUsername = new TextBox();
			tbDiaChi = new TextBox();
			tbTen = new TextBox();
			tbSDT = new TextBox();
			tbSoThich = new TextBox();
			dtpNgaySinh = new DateTimePicker();
			btnDangXuat = new Button();
			btnCapNhat = new Button();
			SuspendLayout();
			// 
			// lbHoSoCaNhan
			// 
			lbHoSoCaNhan.AutoSize = true;
			lbHoSoCaNhan.Font = new Font("Segoe UI", 20F);
			lbHoSoCaNhan.Location = new Point(268, 9);
			lbHoSoCaNhan.Name = "lbHoSoCaNhan";
			lbHoSoCaNhan.Size = new Size(247, 46);
			lbHoSoCaNhan.TabIndex = 0;
			lbHoSoCaNhan.Text = "Hồ Sơ Cá Nhân";
			// 
			// lbUsername
			// 
			lbUsername.AutoSize = true;
			lbUsername.Location = new Point(125, 92);
			lbUsername.Name = "lbUsername";
			lbUsername.Size = new Size(75, 20);
			lbUsername.TabIndex = 1;
			lbUsername.Text = "Username";
			// 
			// lbDiaChi
			// 
			lbDiaChi.AutoSize = true;
			lbDiaChi.Location = new Point(125, 135);
			lbDiaChi.Name = "lbDiaChi";
			lbDiaChi.Size = new Size(57, 20);
			lbDiaChi.TabIndex = 2;
			lbDiaChi.Text = "Địa Chỉ";
			// 
			// lbTen
			// 
			lbTen.AutoSize = true;
			lbTen.Location = new Point(125, 186);
			lbTen.Name = "lbTen";
			lbTen.Size = new Size(32, 20);
			lbTen.TabIndex = 3;
			lbTen.Text = "Tên";
			// 
			// lbNgaySinh
			// 
			lbNgaySinh.AutoSize = true;
			lbNgaySinh.Location = new Point(125, 237);
			lbNgaySinh.Name = "lbNgaySinh";
			lbNgaySinh.Size = new Size(76, 20);
			lbNgaySinh.TabIndex = 4;
			lbNgaySinh.Text = "Ngày Sinh";
			// 
			// lbSDT
			// 
			lbSDT.AutoSize = true;
			lbSDT.Location = new Point(125, 295);
			lbSDT.Name = "lbSDT";
			lbSDT.Size = new Size(102, 20);
			lbSDT.TabIndex = 5;
			lbSDT.Text = "Số Điện Thoại";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(125, 354);
			label1.Name = "label1";
			label1.Size = new Size(65, 20);
			label1.TabIndex = 6;
			label1.Text = "Sở Thích";
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(252, 92);
			tbUsername.Name = "tbUsername";
			tbUsername.ReadOnly = true;
			tbUsername.Size = new Size(392, 27);
			tbUsername.TabIndex = 7;
			// 
			// tbDiaChi
			// 
			tbDiaChi.Location = new Point(252, 132);
			tbDiaChi.Name = "tbDiaChi";
			tbDiaChi.ReadOnly = true;
			tbDiaChi.Size = new Size(392, 27);
			tbDiaChi.TabIndex = 8;
			// 
			// tbTen
			// 
			tbTen.Location = new Point(252, 183);
			tbTen.Name = "tbTen";
			tbTen.ReadOnly = true;
			tbTen.Size = new Size(392, 27);
			tbTen.TabIndex = 9;
			// 
			// tbSDT
			// 
			tbSDT.Location = new Point(252, 292);
			tbSDT.Name = "tbSDT";
			tbSDT.Size = new Size(392, 27);
			tbSDT.TabIndex = 11;
			// 
			// tbSoThich
			// 
			tbSoThich.Location = new Point(252, 351);
			tbSoThich.Name = "tbSoThich";
			tbSoThich.Size = new Size(392, 27);
			tbSoThich.TabIndex = 12;
			// 
			// dtpNgaySinh
			// 
			dtpNgaySinh.Format = DateTimePickerFormat.Custom;
			dtpNgaySinh.Location = new Point(252, 232);
			dtpNgaySinh.Name = "dtpNgaySinh";
			dtpNgaySinh.Size = new Size(392, 27);
			dtpNgaySinh.TabIndex = 13;
			dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
			// 
			// btnDangXuat
			// 
			btnDangXuat.Location = new Point(550, 400);
			btnDangXuat.Name = "btnDangXuat";
			btnDangXuat.Size = new Size(94, 29);
			btnDangXuat.TabIndex = 14;
			btnDangXuat.Text = "Đăng Xuất";
			btnDangXuat.UseVisualStyleBackColor = true;
			btnDangXuat.Click += btnDangXuat_Click;
			// 
			// btnCapNhat
			// 
			btnCapNhat.Location = new Point(437, 400);
			btnCapNhat.Name = "btnCapNhat";
			btnCapNhat.Size = new Size(94, 29);
			btnCapNhat.TabIndex = 15;
			btnCapNhat.Text = "Cập Nhật";
			btnCapNhat.UseVisualStyleBackColor = true;
			btnCapNhat.Click += btnCapNhat_Click;
			// 
			// FormHome
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnCapNhat);
			Controls.Add(btnDangXuat);
			Controls.Add(dtpNgaySinh);
			Controls.Add(tbSoThich);
			Controls.Add(tbSDT);
			Controls.Add(tbTen);
			Controls.Add(tbDiaChi);
			Controls.Add(tbUsername);
			Controls.Add(label1);
			Controls.Add(lbSDT);
			Controls.Add(lbNgaySinh);
			Controls.Add(lbTen);
			Controls.Add(lbDiaChi);
			Controls.Add(lbUsername);
			Controls.Add(lbHoSoCaNhan);
			Name = "FormHome";
			Text = "FormHome";
			Load += FormHome_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbHoSoCaNhan;
		private Label lbUsername;
		private Label lbDiaChi;
		private Label lbTen;
		private Label lbNgaySinh;
		private Label lbSDT;
		private Label label1;
		private TextBox tbUsername;
		private TextBox tbDiaChi;
		private TextBox tbTen;
		private TextBox tbSDT;
		private TextBox tbSoThich;
		private DateTimePicker dtpNgaySinh;
		private Button btnDangXuat;
		private Button btnCapNhat;
	}
}