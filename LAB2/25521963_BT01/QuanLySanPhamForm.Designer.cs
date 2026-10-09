namespace _25521963_BT01
{
	partial class QuanLySanPhamForm
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
			label1 = new Label();
			label2 = new Label();
			tbMaSanPham = new TextBox();
			tbTenSanPham = new TextBox();
			label3 = new Label();
			tbDonGia = new TextBox();
			label4 = new Label();
			tbSoLuong = new TextBox();
			label5 = new Label();
			tbTimKiem = new TextBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnTimKiem = new Button();
			dgvSanPham = new DataGridView();
			MaSanPham = new DataGridViewTextBoxColumn();
			TenSanPham = new DataGridViewTextBoxColumn();
			SoLuong = new DataGridViewTextBoxColumn();
			DonGia = new DataGridViewTextBoxColumn();
			DonViTinh = new DataGridViewTextBoxColumn();
			label6 = new Label();
			cbbDonViTinh = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F);
			label1.Location = new Point(258, 43);
			label1.Name = "label1";
			label1.Size = new Size(266, 37);
			label1.TabIndex = 0;
			label1.Text = "QUẢN LÝ SẢN PHẨM";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 109);
			label2.Name = "label2";
			label2.Size = new Size(98, 20);
			label2.TabIndex = 1;
			label2.Text = "Mã sản phẩm";
			// 
			// tbMaSanPham
			// 
			tbMaSanPham.Enabled = false;
			tbMaSanPham.Location = new Point(116, 106);
			tbMaSanPham.Name = "tbMaSanPham";
			tbMaSanPham.ReadOnly = true;
			tbMaSanPham.Size = new Size(267, 27);
			tbMaSanPham.TabIndex = 2;
			// 
			// tbTenSanPham
			// 
			tbTenSanPham.Location = new Point(521, 109);
			tbTenSanPham.Name = "tbTenSanPham";
			tbTenSanPham.Size = new Size(267, 27);
			tbTenSanPham.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(417, 112);
			label3.Name = "label3";
			label3.Size = new Size(100, 20);
			label3.TabIndex = 3;
			label3.Text = "Tên sản phẩm";
			// 
			// tbDonGia
			// 
			tbDonGia.Location = new Point(521, 142);
			tbDonGia.Name = "tbDonGia";
			tbDonGia.Size = new Size(267, 27);
			tbDonGia.TabIndex = 8;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(417, 145);
			label4.Name = "label4";
			label4.Size = new Size(62, 20);
			label4.TabIndex = 7;
			label4.Text = "Đơn giá";
			// 
			// tbSoLuong
			// 
			tbSoLuong.Location = new Point(116, 139);
			tbSoLuong.Name = "tbSoLuong";
			tbSoLuong.Size = new Size(267, 27);
			tbSoLuong.TabIndex = 6;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 142);
			label5.Name = "label5";
			label5.Size = new Size(69, 20);
			label5.TabIndex = 5;
			label5.Text = "Số lượng";
			// 
			// tbTimKiem
			// 
			tbTimKiem.Location = new Point(320, 210);
			tbTimKiem.Name = "tbTimKiem";
			tbTimKiem.Size = new Size(352, 27);
			tbTimKiem.TabIndex = 9;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(16, 208);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 10;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(116, 208);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 11;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(216, 208);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 12;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnTimKiem
			// 
			btnTimKiem.Location = new Point(678, 208);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(94, 29);
			btnTimKiem.TabIndex = 13;
			btnTimKiem.Text = "Tìm kiếm";
			btnTimKiem.UseVisualStyleBackColor = true;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// dgvSanPham
			// 
			dgvSanPham.AllowUserToAddRows = false;
			dgvSanPham.AllowUserToDeleteRows = false;
			dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSanPham, TenSanPham, SoLuong, DonGia, DonViTinh });
			dgvSanPham.Location = new Point(12, 243);
			dgvSanPham.Name = "dgvSanPham";
			dgvSanPham.ReadOnly = true;
			dgvSanPham.RowHeadersWidth = 51;
			dgvSanPham.Size = new Size(776, 383);
			dgvSanPham.TabIndex = 14;
			dgvSanPham.CellClick += dgvSanPham_CellClick;
			dgvSanPham.CellContentClick += dgvSanPham_CellClick;
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
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 175);
			label6.Name = "label6";
			label6.Size = new Size(86, 20);
			label6.TabIndex = 15;
			label6.Text = "Đơn Vị Tính";
			// 
			// cbbDonViTinh
			// 
			cbbDonViTinh.FormattingEnabled = true;
			cbbDonViTinh.Location = new Point(116, 172);
			cbbDonViTinh.Name = "cbbDonViTinh";
			cbbDonViTinh.Size = new Size(267, 28);
			cbbDonViTinh.TabIndex = 16;
			// 
			// QuanLySanPhamForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 638);
			Controls.Add(cbbDonViTinh);
			Controls.Add(label6);
			Controls.Add(dgvSanPham);
			Controls.Add(btnTimKiem);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(tbTimKiem);
			Controls.Add(tbDonGia);
			Controls.Add(label4);
			Controls.Add(tbSoLuong);
			Controls.Add(label5);
			Controls.Add(tbTenSanPham);
			Controls.Add(label3);
			Controls.Add(tbMaSanPham);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "QuanLySanPhamForm";
			Text = "QuanLySanPhamForm";
			Load += QuanLySanPhamForm_Load;
			((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox tbMaSanPham;
		private TextBox tbTenSanPham;
		private Label label3;
		private TextBox tbDonGia;
		private Label label4;
		private TextBox tbSoLuong;
		private Label label5;
		private TextBox tbTimKiem;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
		private Button btnTimKiem;
		private DataGridView dgvSanPham;
		private Label label6;
		private ComboBox cbbDonViTinh;
		private DataGridViewTextBoxColumn MaSanPham;
		private DataGridViewTextBoxColumn TenSanPham;
		private DataGridViewTextBoxColumn SoLuong;
		private DataGridViewTextBoxColumn DonGia;
		private DataGridViewTextBoxColumn DonViTinh;
	}
}