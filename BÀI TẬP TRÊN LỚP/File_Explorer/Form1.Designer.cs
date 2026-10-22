namespace BuoiTiepTheo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			splitContainer1 = new SplitContainer();
			treeViewFolders = new TreeView();
			imageListIcons = new ImageList(components);
			listViewFiles = new ListView();
			columnHeader1 = new ColumnHeader();
			contextMenuStrip1 = new ContextMenuStrip(components);
			newToolStripMenuItem1 = new ToolStripMenuItem();
			copyToolStripMenuItem1 = new ToolStripMenuItem();
			cutToolStripMenuItem1 = new ToolStripMenuItem();
			pasteToolStripMenuItem1 = new ToolStripMenuItem();
			deleteToolStripMenuItem1 = new ToolStripMenuItem();
			exitToolStripMenuItem1 = new ToolStripMenuItem();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			tsmNew = new ToolStripMenuItem();
			tsmExit = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			tsmCopy = new ToolStripMenuItem();
			tsmCut = new ToolStripMenuItem();
			tsmPaste = new ToolStripMenuItem();
			tsmDelete = new ToolStripMenuItem();
			toolStrip1 = new ToolStrip();
			tsbNew = new ToolStripButton();
			tsbExit = new ToolStripButton();
			tsbCopy = new ToolStripButton();
			tsbCut = new ToolStripButton();
			tsbPaste = new ToolStripButton();
			tsbDelete = new ToolStripButton();
			toolStripSeparatorView = new ToolStripSeparator();
			tslView = new ToolStripLabel();
			cboView = new ToolStripComboBox();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			contextMenuStrip1.SuspendLayout();
			menuStrip1.SuspendLayout();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(treeViewFolders);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(listViewFiles);
			splitContainer1.Size = new Size(800, 450);
			splitContainer1.SplitterDistance = 165;
			splitContainer1.TabIndex = 0;
			// 
			// treeViewFolders
			// 
			treeViewFolders.Dock = DockStyle.Fill;
			treeViewFolders.ImageIndex = 0;
			treeViewFolders.ImageList = imageListIcons;
			treeViewFolders.Location = new Point(0, 0);
			treeViewFolders.Name = "treeViewFolders";
			treeViewFolders.SelectedImageIndex = 0;
			treeViewFolders.Size = new Size(165, 450);
			treeViewFolders.TabIndex = 0;
			treeViewFolders.BeforeExpand += TreeViewFolders_BeforeExpand;
			treeViewFolders.AfterSelect += TreeViewFolders_AfterSelect;
			// 
			// imageListIcons
			// 
			imageListIcons.ColorDepth = ColorDepth.Depth32Bit;
			imageListIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons.ImageStream");
			imageListIcons.TransparentColor = Color.Transparent;
			imageListIcons.Images.SetKeyName(0, "folder");
			imageListIcons.Images.SetKeyName(1, "file");
			// 
			// listViewFiles
			// 
			listViewFiles.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
			listViewFiles.ContextMenuStrip = contextMenuStrip1;
			listViewFiles.Dock = DockStyle.Fill;
			listViewFiles.FullRowSelect = true;
			listViewFiles.LargeImageList = imageListIcons;
			listViewFiles.Location = new Point(0, 0);
			listViewFiles.MultiSelect = false;
			listViewFiles.Name = "listViewFiles";
			listViewFiles.Size = new Size(631, 450);
			listViewFiles.SmallImageList = imageListIcons;
			listViewFiles.TabIndex = 0;
			listViewFiles.UseCompatibleStateImageBehavior = false;
			listViewFiles.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Name";
			columnHeader1.Width = 500;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem1, copyToolStripMenuItem1, cutToolStripMenuItem1, pasteToolStripMenuItem1, deleteToolStripMenuItem1, exitToolStripMenuItem1 });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(123, 148);
			// 
			// newToolStripMenuItem1
			// 
			newToolStripMenuItem1.Name = "newToolStripMenuItem1";
			newToolStripMenuItem1.Size = new Size(122, 24);
			newToolStripMenuItem1.Text = "New";
			newToolStripMenuItem1.Click += New_Click;
			// 
			// copyToolStripMenuItem1
			// 
			copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
			copyToolStripMenuItem1.Size = new Size(122, 24);
			copyToolStripMenuItem1.Text = "Copy";
			copyToolStripMenuItem1.Click += Copy_Click;
			// 
			// cutToolStripMenuItem1
			// 
			cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
			cutToolStripMenuItem1.Size = new Size(122, 24);
			cutToolStripMenuItem1.Text = "Cut";
			cutToolStripMenuItem1.Click += Cut_Click;
			// 
			// pasteToolStripMenuItem1
			// 
			pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
			pasteToolStripMenuItem1.Size = new Size(122, 24);
			pasteToolStripMenuItem1.Text = "Paste";
			pasteToolStripMenuItem1.Click += Paste_Click;
			// 
			// deleteToolStripMenuItem1
			// 
			deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			deleteToolStripMenuItem1.Size = new Size(122, 24);
			deleteToolStripMenuItem1.Text = "Delete";
			deleteToolStripMenuItem1.Click += Delete_Click;
			// 
			// exitToolStripMenuItem1
			// 
			exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			exitToolStripMenuItem1.Size = new Size(122, 24);
			exitToolStripMenuItem1.Text = "Exit";
			exitToolStripMenuItem1.Click += Exit_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 28);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmNew, tsmExit });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(46, 24);
			fileToolStripMenuItem.Text = "File";
			// 
			// tsmNew
			// 
			tsmNew.Name = "tsmNew";
			tsmNew.Size = new Size(122, 26);
			tsmNew.Text = "New";
			tsmNew.Click += New_Click;
			// 
			// tsmExit
			// 
			tsmExit.Name = "tsmExit";
			tsmExit.Size = new Size(122, 26);
			tsmExit.Text = "Exit";
			tsmExit.Click += Exit_Click;
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmCopy, tsmCut, tsmPaste, tsmDelete });
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.Size = new Size(49, 24);
			editToolStripMenuItem.Text = "Edit";
			// 
			// tsmCopy
			// 
			tsmCopy.Name = "tsmCopy";
			tsmCopy.Size = new Size(136, 26);
			tsmCopy.Text = "Copy";
			tsmCopy.Click += Copy_Click;
			// 
			// tsmCut
			// 
			tsmCut.Name = "tsmCut";
			tsmCut.Size = new Size(136, 26);
			tsmCut.Text = "Cut";
			tsmCut.Click += Cut_Click;
			// 
			// tsmPaste
			// 
			tsmPaste.Name = "tsmPaste";
			tsmPaste.Size = new Size(136, 26);
			tsmPaste.Text = "Paste";
			tsmPaste.Click += Paste_Click;
			// 
			// tsmDelete
			// 
			tsmDelete.Name = "tsmDelete";
			tsmDelete.Size = new Size(136, 26);
			tsmDelete.Text = "Delete";
			tsmDelete.Click += Delete_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNew, tsbExit, tsbCopy, tsbCut, tsbPaste, tsbDelete, toolStripSeparatorView, tslView, cboView });
			toolStrip1.Location = new Point(0, 28);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 28);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbNew
			// 
			tsbNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbNew.Image = (Image)resources.GetObject("tsbNew.Image");
			tsbNew.ImageTransparentColor = Color.Magenta;
			tsbNew.Name = "tsbNew";
			tsbNew.Size = new Size(29, 25);
			tsbNew.Text = "New";
			tsbNew.Click += New_Click;
			// 
			// tsbExit
			// 
			tsbExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbExit.Image = (Image)resources.GetObject("tsbExit.Image");
			tsbExit.ImageTransparentColor = Color.Magenta;
			tsbExit.Name = "tsbExit";
			tsbExit.Size = new Size(29, 25);
			tsbExit.Text = "Exit";
			tsbExit.Click += Exit_Click;
			// 
			// tsbCopy
			// 
			tsbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbCopy.Image = (Image)resources.GetObject("tsbCopy.Image");
			tsbCopy.ImageTransparentColor = Color.Magenta;
			tsbCopy.Name = "tsbCopy";
			tsbCopy.Size = new Size(29, 25);
			tsbCopy.Text = "Copy";
			tsbCopy.Click += Copy_Click;
			// 
			// tsbCut
			// 
			tsbCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbCut.Image = (Image)resources.GetObject("tsbCut.Image");
			tsbCut.ImageTransparentColor = Color.Magenta;
			tsbCut.Name = "tsbCut";
			tsbCut.Size = new Size(29, 25);
			tsbCut.Text = "Cut";
			tsbCut.Click += Cut_Click;
			// 
			// tsbPaste
			// 
			tsbPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbPaste.Image = (Image)resources.GetObject("tsbPaste.Image");
			tsbPaste.ImageTransparentColor = Color.Magenta;
			tsbPaste.Name = "tsbPaste";
			tsbPaste.Size = new Size(29, 25);
			tsbPaste.Text = "Paste";
			tsbPaste.Click += Paste_Click;
			// 
			// tsbDelete
			// 
			tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
			tsbDelete.ImageTransparentColor = Color.Magenta;
			tsbDelete.Name = "tsbDelete";
			tsbDelete.Size = new Size(29, 25);
			tsbDelete.Text = "Delete";
			tsbDelete.Click += Delete_Click;
			// 
			// toolStripSeparatorView
			// 
			toolStripSeparatorView.Name = "toolStripSeparatorView";
			toolStripSeparatorView.Size = new Size(6, 28);
			// 
			// tslView
			// 
			tslView.Alignment = ToolStripItemAlignment.Right;
			tslView.Name = "tslView";
			tslView.Size = new Size(41, 25);
			tslView.Text = "View";
			// 
			// cboView
			// 
			cboView.Alignment = ToolStripItemAlignment.Right;
			cboView.DropDownStyle = ComboBoxStyle.DropDownList;
			cboView.Items.AddRange(new object[] { "Details", "Large Icon", "Small Icon", "List", "Tile" });
			cboView.Name = "cboView";
			cboView.Size = new Size(121, 28);
			cboView.SelectedIndexChanged += CboView_SelectedIndexChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(toolStrip1);
			Controls.Add(menuStrip1);
			Controls.Add(splitContainer1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "File Explorer";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			contextMenuStrip1.ResumeLayout(false);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private SplitContainer splitContainer1;
		private TreeView treeViewFolders;
		private ImageList imageListIcons;
		private ToolStrip toolStrip1;
		private ToolStripButton tsbDelete;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem tsmNew;
		private ToolStripMenuItem tsmExit;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem tsmCut;
		private ToolStripMenuItem tsmDelete;
		private ToolStripMenuItem tsmCopy;
		private ToolStripMenuItem tsmPaste;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem deleteToolStripMenuItem1;
		private ToolStripMenuItem newToolStripMenuItem1;
		private ToolStripMenuItem exitToolStripMenuItem1;
		private ToolStripButton tsbNew;
		private ToolStripButton tsbExit;
		private ToolStripButton tsbCopy;
		private ToolStripButton tsbCut;
		private ToolStripButton tsbPaste;
		private ListView listViewFiles;
		private ColumnHeader columnHeader1;
		private ToolStripSeparator toolStripSeparatorView;
		private ToolStripLabel tslView;
		private ToolStripComboBox cboView;
		private ToolStripMenuItem copyToolStripMenuItem1;
		private ToolStripMenuItem cutToolStripMenuItem1;
		private ToolStripMenuItem pasteToolStripMenuItem1;
	}
}
