namespace QuanLySanPham
{
	partial class QuanLySanPhamForm
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
			label1 = new Label();
			tbMaSanPham = new TextBox();
			tbSoLuong = new TextBox();
			label2 = new Label();
			tbDonGia = new TextBox();
			label3 = new Label();
			tbTenSanPham = new TextBox();
			label4 = new Label();
			label5 = new Label();
			cbbDonViTinh = new ComboBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnTimKiem = new Button();
			tbTimKiem = new TextBox();
			label6 = new Label();
			dgvSanPham = new DataGridView();
			MaSanPham = new DataGridViewTextBoxColumn();
			TenSanPham = new DataGridViewTextBoxColumn();
			SoLuong = new DataGridViewTextBoxColumn();
			DonGia = new DataGridViewTextBoxColumn();
			DonViTinh = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 68);
			label1.Name = "label1";
			label1.Size = new Size(99, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã Sản Phẩm";
			// 
			// tbMaSanPham
			// 
			tbMaSanPham.Location = new Point(126, 65);
			tbMaSanPham.Name = "tbMaSanPham";
			tbMaSanPham.ReadOnly = true;
			tbMaSanPham.Size = new Size(233, 27);
			tbMaSanPham.TabIndex = 1;
			// 
			// tbSoLuong
			// 
			tbSoLuong.Location = new Point(126, 116);
			tbSoLuong.Name = "tbSoLuong";
			tbSoLuong.Size = new Size(233, 27);
			tbSoLuong.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 119);
			label2.Name = "label2";
			label2.Size = new Size(72, 20);
			label2.TabIndex = 2;
			label2.Text = "Số Lượng";
			// 
			// tbDonGia
			// 
			tbDonGia.Location = new Point(490, 116);
			tbDonGia.Name = "tbDonGia";
			tbDonGia.Size = new Size(233, 27);
			tbDonGia.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(386, 119);
			label3.Name = "label3";
			label3.Size = new Size(63, 20);
			label3.TabIndex = 6;
			label3.Text = "Đơn Giá";
			// 
			// tbTenSanPham
			// 
			tbTenSanPham.Location = new Point(490, 65);
			tbTenSanPham.Name = "tbTenSanPham";
			tbTenSanPham.Size = new Size(233, 27);
			tbTenSanPham.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(386, 68);
			label4.Name = "label4";
			label4.Size = new Size(101, 20);
			label4.TabIndex = 4;
			label4.Text = "Tên Sản Phẩm";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(18, 175);
			label5.Name = "label5";
			label5.Size = new Size(86, 20);
			label5.TabIndex = 8;
			label5.Text = "Đơn Vị Tính";
			// 
			// cbbDonViTinh
			// 
			cbbDonViTinh.FormattingEnabled = true;
			cbbDonViTinh.Location = new Point(126, 172);
			cbbDonViTinh.Name = "cbbDonViTinh";
			cbbDonViTinh.Size = new Size(233, 28);
			cbbDonViTinh.TabIndex = 9;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(18, 218);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 10;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(126, 218);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 11;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(236, 218);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 12;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnTimKiem
			// 
			btnTimKiem.Location = new Point(629, 218);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(94, 29);
			btnTimKiem.TabIndex = 13;
			btnTimKiem.Text = "TÌm Kiếm";
			btnTimKiem.UseVisualStyleBackColor = true;
			btnTimKiem.Click += this.btnTimKiem_Click;
			// 
			// tbTimKiem
			// 
			tbTimKiem.Location = new Point(361, 219);
			tbTimKiem.Name = "tbTimKiem";
			tbTimKiem.Size = new Size(262, 27);
			tbTimKiem.TabIndex = 14;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			label6.Font = new Font("Segoe UI", 20F);
			label6.Location = new Point(222, 9);
			label6.Name = "label6";
			label6.Size = new Size(296, 46);
			label6.TabIndex = 15;
			label6.Text = "Quản Lý Sản Phẩm";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dgvSanPham
			// 
			dgvSanPham.AllowUserToAddRows = false;
			dgvSanPham.AllowUserToDeleteRows = false;
			dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSanPham, TenSanPham, SoLuong, DonGia, DonViTinh });
			dgvSanPham.Location = new Point(18, 262);
			dgvSanPham.Name = "dgvSanPham";
			dgvSanPham.ReadOnly = true;
			dgvSanPham.RowHeadersWidth = 51;
			dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvSanPham.Size = new Size(705, 338);
			dgvSanPham.TabIndex = 16;
			dgvSanPham.CellClick += dgvSanPham_CellClick;
			// 
			// MaSanPham
			// 
			MaSanPham.DataPropertyName = "MaSanPham";
			MaSanPham.HeaderText = "Mã Sản Phẩm";
			MaSanPham.MinimumWidth = 6;
			MaSanPham.Name = "MaSanPham";
			MaSanPham.ReadOnly = true;
			// 
			// TenSanPham
			// 
			TenSanPham.DataPropertyName = "TenSanPham";
			TenSanPham.HeaderText = "Tên Sản Phẩm";
			TenSanPham.MinimumWidth = 6;
			TenSanPham.Name = "TenSanPham";
			TenSanPham.ReadOnly = true;
			// 
			// SoLuong
			// 
			SoLuong.DataPropertyName = "SoLuong";
			SoLuong.HeaderText = "Số Lượng";
			SoLuong.MinimumWidth = 6;
			SoLuong.Name = "SoLuong";
			SoLuong.ReadOnly = true;
			// 
			// DonGia
			// 
			DonGia.DataPropertyName = "DonGia";
			DonGia.HeaderText = "Đơn Giá";
			DonGia.MinimumWidth = 6;
			DonGia.Name = "DonGia";
			DonGia.ReadOnly = true;
			// 
			// DonViTinh
			// 
			DonViTinh.DataPropertyName = "DonViTinh";
			DonViTinh.HeaderText = "Đơn Vị Tính";
			DonViTinh.MinimumWidth = 6;
			DonViTinh.Name = "DonViTinh";
			DonViTinh.ReadOnly = true;
			// 
			// QuanLySanPhamForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(737, 612);
			Controls.Add(dgvSanPham);
			Controls.Add(label6);
			Controls.Add(tbTimKiem);
			Controls.Add(btnTimKiem);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(cbbDonViTinh);
			Controls.Add(label5);
			Controls.Add(tbDonGia);
			Controls.Add(label3);
			Controls.Add(tbTenSanPham);
			Controls.Add(label4);
			Controls.Add(tbSoLuong);
			Controls.Add(label2);
			Controls.Add(tbMaSanPham);
			Controls.Add(label1);
			Name = "QuanLySanPhamForm";
			Text = "Quản Lý  Sản Phẩm";
			Load += QuanLySanPhamForm_Load;
			((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox tbMaSanPham;
		private TextBox tbSoLuong;
		private Label label2;
		private TextBox tbDonGia;
		private Label label3;
		private TextBox tbTenSanPham;
		private Label label4;
		private Label label5;
		private ComboBox cbbDonViTinh;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
		private Button btnTimKiem;
		private TextBox tbTimKiem;
		private Label label6;
		private DataGridView dgvSanPham;
		private DataGridViewTextBoxColumn MaSanPham;
		private DataGridViewTextBoxColumn TenSanPham;
		private DataGridViewTextBoxColumn SoLuong;
		private DataGridViewTextBoxColumn DonGia;
		private DataGridViewTextBoxColumn DonViTinh;
	}
}
