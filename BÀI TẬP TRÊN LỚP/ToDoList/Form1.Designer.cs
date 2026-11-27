namespace ToDoList
{
	partial class Form1
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
			dgvToDo = new DataGridView();
			label2 = new Label();
			tbSTT = new TextBox();
			tbTitle = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			dtpStartDate = new DateTimePicker();
			dtpDueDate = new DateTimePicker();
			btnNew = new Button();
			STT = new DataGridViewTextBoxColumn();
			Title = new DataGridViewTextBoxColumn();
			StartDate = new DataGridViewTextBoxColumn();
			DueDate = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvToDo).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F);
			label1.Location = new Point(217, 9);
			label1.Name = "label1";
			label1.Size = new Size(125, 35);
			label1.TabIndex = 0;
			label1.Text = "To-do List";
			// 
			// dgvToDo
			// 
			dgvToDo.AllowUserToAddRows = false;
			dgvToDo.AllowUserToDeleteRows = false;
			dgvToDo.AutoGenerateColumns = false;
			dgvToDo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvToDo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvToDo.Columns.AddRange(new DataGridViewColumn[] { STT, Title, StartDate, DueDate });
			dgvToDo.Location = new Point(12, 155);
			dgvToDo.Name = "dgvToDo";
			dgvToDo.ReadOnly = true;
			dgvToDo.RowHeadersWidth = 51;
			dgvToDo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvToDo.Size = new Size(553, 363);
			dgvToDo.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(22, 54);
			label2.Name = "label2";
			label2.Size = new Size(33, 20);
			label2.TabIndex = 2;
			label2.Text = "STT";
			// 
			// tbSTT
			// 
			tbSTT.Location = new Point(101, 51);
			tbSTT.Name = "tbSTT";
			tbSTT.ReadOnly = true;
			tbSTT.Size = new Size(152, 27);
			tbSTT.TabIndex = 3;
			// 
			// tbTitle
			// 
			tbTitle.Location = new Point(388, 51);
			tbTitle.Name = "tbTitle";
			tbTitle.Size = new Size(152, 27);
			tbTitle.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(309, 54);
			label3.Name = "label3";
			label3.Size = new Size(38, 20);
			label3.TabIndex = 4;
			label3.Text = "Title";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(309, 87);
			label4.Name = "label4";
			label4.Size = new Size(72, 20);
			label4.TabIndex = 8;
			label4.Text = "Due Date";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(22, 87);
			label5.Name = "label5";
			label5.Size = new Size(76, 20);
			label5.TabIndex = 6;
			label5.Text = "Start Date";
			// 
			// dtpStartDate
			// 
			dtpStartDate.CustomFormat = "dd/MM/yyyy";
			dtpStartDate.Format = DateTimePickerFormat.Custom;
			dtpStartDate.Location = new Point(101, 82);
			dtpStartDate.Name = "dtpStartDate";
			dtpStartDate.Size = new Size(152, 27);
			dtpStartDate.TabIndex = 10;
			// 
			// dtpDueDate
			// 
			dtpDueDate.CustomFormat = "dd/MM/yyyy";
			dtpDueDate.Format = DateTimePickerFormat.Custom;
			dtpDueDate.Location = new Point(388, 82);
			dtpDueDate.Name = "dtpDueDate";
			dtpDueDate.Size = new Size(152, 27);
			dtpDueDate.TabIndex = 11;
			// 
			// btnNew
			// 
			btnNew.Location = new Point(446, 120);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(94, 29);
			btnNew.TabIndex = 12;
			btnNew.Text = "New";
			btnNew.UseVisualStyleBackColor = true;
			btnNew.Click += btnNew_Click;
			// 
			// STT
			// 
			STT.DataPropertyName = "STT";
			STT.HeaderText = "STT";
			STT.MinimumWidth = 6;
			STT.Name = "STT";
			STT.ReadOnly = true;
			// 
			// Title
			// 
			Title.DataPropertyName = "Title";
			Title.HeaderText = "Title";
			Title.MinimumWidth = 6;
			Title.Name = "Title";
			Title.ReadOnly = true;
			// 
			// StartDate
			// 
			StartDate.DataPropertyName = "StartDate";
			StartDate.HeaderText = "Start Date";
			StartDate.MinimumWidth = 6;
			StartDate.Name = "StartDate";
			StartDate.ReadOnly = true;
			// 
			// DueDate
			// 
			DueDate.DataPropertyName = "DueDate";
			DueDate.HeaderText = "Due Date";
			DueDate.MinimumWidth = 6;
			DueDate.Name = "DueDate";
			DueDate.ReadOnly = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(577, 530);
			Controls.Add(btnNew);
			Controls.Add(dtpDueDate);
			Controls.Add(dtpStartDate);
			Controls.Add(label4);
			Controls.Add(label5);
			Controls.Add(tbTitle);
			Controls.Add(label3);
			Controls.Add(tbSTT);
			Controls.Add(label2);
			Controls.Add(dgvToDo);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dgvToDo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private DataGridView dgvToDo;
		private Label label2;
		private TextBox tbSTT;
		private TextBox tbTitle;
		private Label label3;
		private Label label4;
		private Label label5;
		private DateTimePicker dtpStartDate;
		private DateTimePicker dtpDueDate;
		private Button btnNew;
		private DataGridViewTextBoxColumn STT;
		private DataGridViewTextBoxColumn Title;
		private DataGridViewTextBoxColumn StartDate;
		private DataGridViewTextBoxColumn DueDate;
	}
}
