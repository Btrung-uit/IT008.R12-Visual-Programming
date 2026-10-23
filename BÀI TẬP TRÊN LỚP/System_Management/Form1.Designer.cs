namespace System_Management
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
			components = new System.ComponentModel.Container();
			panelTitle = new Panel();
			label1 = new Label();
			panelContent = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			cbbAction = new ComboBox();
			tbRemainingTime = new TextBox();
			btnRunCancel = new Button();
			panelTimeInput = new Panel();
			tbTime = new TextBox();
			cbbTimeType = new ComboBox();
			timer1 = new System.Windows.Forms.Timer(components);
			panelTitle.SuspendLayout();
			panelContent.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			panelTimeInput.SuspendLayout();
			SuspendLayout();
			// 
			// panelTitle
			// 
			panelTitle.Controls.Add(label1);
			panelTitle.Dock = DockStyle.Top;
			panelTitle.Location = new Point(0, 0);
			panelTitle.Name = "panelTitle";
			panelTitle.Size = new Size(800, 74);
			panelTitle.TabIndex = 0;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Segoe UI", 20F);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(800, 74);
			label1.TabIndex = 0;
			label1.Text = "SYSTEM MANAGEMENT";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panelContent
			// 
			panelContent.Controls.Add(tableLayoutPanel1);
			panelContent.Dock = DockStyle.Fill;
			panelContent.Location = new Point(0, 74);
			panelContent.Name = "panelContent";
			panelContent.Size = new Size(800, 376);
			panelContent.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.375F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.375F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.75F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
			tableLayoutPanel1.Controls.Add(label2, 1, 0);
			tableLayoutPanel1.Controls.Add(label3, 1, 1);
			tableLayoutPanel1.Controls.Add(label4, 1, 2);
			tableLayoutPanel1.Controls.Add(cbbAction, 2, 0);
			tableLayoutPanel1.Controls.Add(tbRemainingTime, 2, 2);
			tableLayoutPanel1.Controls.Add(btnRunCancel, 0, 3);
			tableLayoutPanel1.Controls.Add(panelTimeInput, 2, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.6875F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.3125F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(800, 376);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.Font = new Font("Segoe UI", 10F);
			label2.Location = new Point(150, 38);
			label2.Name = "label2";
			label2.Size = new Size(62, 25);
			label2.TabIndex = 0;
			label2.Text = "Action";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Left;
			label3.Font = new Font("Segoe UI", 10F);
			label3.Location = new Point(150, 132);
			label3.Name = "label3";
			label3.Size = new Size(62, 25);
			label3.TabIndex = 1;
			label3.Text = "Time";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Left;
			label4.Font = new Font("Segoe UI", 10F);
			label4.Location = new Point(150, 221);
			label4.Name = "label4";
			label4.Size = new Size(117, 25);
			label4.TabIndex = 2;
			label4.Text = "Remaining Time";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// cbbAction
			// 
			cbbAction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			cbbAction.DropDownStyle = ComboBoxStyle.DropDownList;
			cbbAction.Font = new Font("Segoe UI", 10F);
			cbbAction.FormattingEnabled = true;
			cbbAction.Items.AddRange(new object[] { "Shutdown", "Logout", "Restart" });
			cbbAction.Location = new Point(273, 35);
			cbbAction.Name = "cbbAction";
			cbbAction.Size = new Size(304, 31);
			cbbAction.TabIndex = 3;
			// 
			// tbRemainingTime
			// 
			tbRemainingTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbRemainingTime.Font = new Font("Segoe UI", 10F);
			tbRemainingTime.Location = new Point(273, 219);
			tbRemainingTime.Name = "tbRemainingTime";
			tbRemainingTime.ReadOnly = true;
			tbRemainingTime.Size = new Size(304, 30);
			tbRemainingTime.TabIndex = 5;
			tbRemainingTime.TabStop = false;
			tbRemainingTime.Text = "00:00:00";
			// 
			// btnRunCancel
			// 
			btnRunCancel.Anchor = AnchorStyles.None;
			tableLayoutPanel1.SetColumnSpan(btnRunCancel, 4);
			btnRunCancel.Font = new Font("Segoe UI", 10F);
			btnRunCancel.Location = new Point(353, 314);
			btnRunCancel.Name = "btnRunCancel";
			btnRunCancel.Size = new Size(94, 29);
			btnRunCancel.TabIndex = 6;
			btnRunCancel.Text = "Run";
			btnRunCancel.UseVisualStyleBackColor = true;
			btnRunCancel.Click += btnRunCancel_Click;
			// 
			// panelTimeInput
			// 
			panelTimeInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			panelTimeInput.Controls.Add(tbTime);
			panelTimeInput.Controls.Add(cbbTimeType);
			panelTimeInput.Location = new Point(273, 129);
			panelTimeInput.Name = "panelTimeInput";
			panelTimeInput.Size = new Size(304, 31);
			panelTimeInput.TabIndex = 7;
			// 
			// tbTime
			// 
			tbTime.Dock = DockStyle.Fill;
			tbTime.Font = new Font("Segoe UI", 10F);
			tbTime.Location = new Point(0, 0);
			tbTime.Name = "tbTime";
			tbTime.Size = new Size(204, 30);
			tbTime.TabIndex = 5;
			// 
			// cbbTimeType
			// 
			cbbTimeType.Dock = DockStyle.Right;
			cbbTimeType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbbTimeType.Font = new Font("Segoe UI", 10F);
			cbbTimeType.FormattingEnabled = true;
			cbbTimeType.Items.AddRange(new object[] { "seconds", "minutes", "hours" });
			cbbTimeType.Location = new Point(204, 0);
			cbbTimeType.Name = "cbbTimeType";
			cbbTimeType.Size = new Size(100, 31);
			cbbTimeType.TabIndex = 6;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panelContent);
			Controls.Add(panelTitle);
			Name = "Form1";
			Text = "Form1";
			panelTitle.ResumeLayout(false);
			panelContent.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			panelTimeInput.ResumeLayout(false);
			panelTimeInput.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelTitle;
		private Label label1;
		private Panel panelContent;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label2;
		private Label label3;
		private Label label4;
		private ComboBox cbbAction;
		private Button btnRunCancel;
		private Panel panelTimeInput;
		private TextBox tbTime;
		private ComboBox cbbTimeType;
		private TextBox tbRemainingTime;
		private System.Windows.Forms.Timer timer1;
	}
}
