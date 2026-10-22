using System.Diagnostics;

namespace BuoiTiepTheo;

public partial class Form1 : Form
{
	private readonly List<string> _clipboardPath = new List<string>();
	private bool _isCut = false;

	public Form1()
	{
		InitializeComponent();
		toolStrip1.Dock = DockStyle.Top;
		splitContainer1.Dock = DockStyle.Fill;

		// Gán context menu chuột phải cho cả ListView và TreeView
		listViewFiles.ContextMenuStrip = contextMenuStrip1;
		treeViewFolders.ContextMenuStrip = contextMenuStrip1;

		// Cho phép giữ Ctrl / Shift hoặc quét chuột để chọn nhiều file
		listViewFiles.MultiSelect = true;

		// Đảm bảo ToolStrip được hiển thị trước SplitContainer
		Controls.SetChildIndex(splitContainer1, 0);
		Controls.SetChildIndex(toolStrip1, 1);
		PerformLayout();

		LoadDrives();

		// Mặc định hiển thị chế độ Details
		cboView.SelectedItem = "Details";
	}

	#region NẠP DỮ LIỆU CÂY THƯ MỤC VÀ TẬP TIN

	private void LoadDrives()
	{
		treeViewFolders.Nodes.Clear();

		foreach (DriveInfo drive in DriveInfo.GetDrives())
		{
			if (!drive.IsReady) continue;

			TreeNode node = new TreeNode(drive.Name)
			{
				Tag = drive.RootDirectory.FullName
			};

			node.Nodes.Add("Đang tải...");
			treeViewFolders.Nodes.Add(node);
		}
	}

	private void RefreshListView(string path)
	{
		if (string.IsNullOrEmpty(path) || !Directory.Exists(path)) return;

		listViewFiles.Items.Clear();

		try
		{
			// Nạp danh sách thư mục con
			foreach (string folder in Directory.GetDirectories(path))
			{
				ListViewItem item = new ListViewItem(Path.GetFileName(folder))
				{
					ImageKey = "folder",
					Tag = folder
				};
				listViewFiles.Items.Add(item);
			}

			// Nạp danh sách tập tin
			foreach (string file in Directory.GetFiles(path))
			{
				ListViewItem item = new ListViewItem(Path.GetFileName(file))
				{
					ImageKey = "file",
					Tag = file
				};
				listViewFiles.Items.Add(item);
			}
		}
		catch (UnauthorizedAccessException)
		{
			MessageBox.Show("Bạn không có quyền truy cập vào thư mục này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex);
		}
	}

	#endregion

	#region PHƯƠNG THỨC NGHIỆP VỤ (BUSINESS METHODS)

	private void CreateNewFile()
	{
		if (treeViewFolders.SelectedNode?.Tag is not string folderPath || !Directory.Exists(folderPath))
		{
			MessageBox.Show("Vui lòng chọn thư mục cần tạo file ở cây bên trái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		string createName = Microsoft.VisualBasic.Interaction.InputBox(
			"Nhập tên, mặc định tạo folder thêm đuôi .txt để tạo file",
			"Tạo folder hoặc file mới",
			"").Trim();

		if (string.IsNullOrWhiteSpace(createName)) return;

		// Kiểm tra ký tự cấm trong tên file
		if (createName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
		{
			MessageBox.Show("Tên folder hoặc file chứa ký tự không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		string fullPath = Path.Combine(folderPath, createName);

		if (File.Exists(fullPath) || Directory.Exists(fullPath))
		{
			MessageBox.Show($"File hoặc thư mục \"{createName}\" đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		try
		{
			if (createName.Contains(".txt"))
			{
				File.WriteAllText(fullPath, string.Empty);
				RefreshListView(folderPath);
				MessageBox.Show($"Đã tạo file \"{createName}\" thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				Directory.CreateDirectory(fullPath);
				RefreshListView(folderPath);
				MessageBox.Show($"Đã tạo folder \"{createName}\" thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex);
		}
	}

	private void CopySelectedItem()
	{
		if (listViewFiles.SelectedItems.Count == 0)
		{
			MessageBox.Show("Vui lòng chọn file hoặc thư mục cần Copy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		_clipboardPath.Clear();

		foreach (ListViewItem item in listViewFiles.SelectedItems)
		{
			if (item.Tag is string path)
			{
				_clipboardPath.Add(path);
			}
		}
		_isCut = false;
		MessageBox.Show($"Đã Copy {_clipboardPath.Count} mục vào bộ nhớ tạm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	private void CutSelectedItem()
	{
		if (listViewFiles.SelectedItems.Count == 0)
		{
			MessageBox.Show("Vui lòng chọn file hoặc thư mục cần Cut.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		_clipboardPath.Clear();

		foreach (ListViewItem item in listViewFiles.SelectedItems)
		{
			if (item.Tag is string path)
			{
				_clipboardPath.Add(path);
			}
		}
		_isCut = false;
		MessageBox.Show($"Đã Cut {_clipboardPath.Count} mục vào bộ nhớ tạm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	private void PasteItem()
	{
		if (_clipboardPath.Count == 0)
		{
			MessageBox.Show("Chưa có file hoặc thư mục nào trong bộ nhớ tạm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		if (treeViewFolders.SelectedNode?.Tag is not string destFolder || !Directory.Exists(destFolder))
		{
			MessageBox.Show("Vui lòng chọn thư mục đích ở cây bên trái để Paste.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		int successCount = 0;

		try
		{
			foreach (string sourcePath in _clipboardPath)
			{
				// Bỏ qua nếu nó không phải là file và không phải là thư mục
				if (!File.Exists(sourcePath) && !Directory.Exists(sourcePath)) continue;

				string itemName = Path.GetFileName(sourcePath);
				string destPath = Path.Combine(destFolder, itemName);

				// Bỏ qua nếu dán thư mục vào chính nó
				if (sourcePath.Equals(destPath, StringComparison.OrdinalIgnoreCase)) continue;

				// Xử lí file
				if (File.Exists(sourcePath))
				{
					if (_isCut)
					{
						File.Move(sourcePath, destPath, overwrite: true);
					}
					else
					{
						File.Copy(sourcePath, destPath, overwrite: true);
					}
					successCount++;
				}
				else if (Directory.Exists(sourcePath))
				{
					if (_isCut)
					{
						Directory.Move(sourcePath, destPath);
					}
					else
					{
						CopyDirectory(sourcePath, destPath);
					}
					successCount++;
				}
			}
			if (_isCut)
			{
				_clipboardPath.Clear();
				_isCut = false;
			}

			RefreshListView(destFolder);
			MessageBox.Show($"Đã Paste thành công {successCount} mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Lỗi Paste: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private void CopyDirectory(string sourceDir, string destDir)
	{
		Directory.CreateDirectory(destDir);

		foreach (string file in Directory.GetFiles(sourceDir))
		{
			string destFile = Path.Combine(destDir, Path.GetFileName(file));
			File.Copy(file, destFile, overwrite: true);
		}

		foreach (string subDir in Directory.GetDirectories(sourceDir))
		{
			string destSubDir = Path.Combine(destDir, Path.GetFileName(subDir));
			CopyDirectory(subDir, destSubDir);
		}
	}

	private void DeleteSelectedItem()
	{
		if (listViewFiles.SelectedItems.Count == 0)
		{
			MessageBox.Show("Hãy chọn file hoặc thư mục cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa {listViewFiles.SelectedItems.Count} mục đã chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (result != DialogResult.Yes) return;

		try
		{
			// Gom vào mảng để tránh thay đổi khi xóa
			var itemToDelete = listViewFiles.SelectedItems.Cast<ListViewItem>().ToList();
			foreach (ListViewItem item in itemToDelete)
			{
				string? path = item.Tag?.ToString();

				if (string.IsNullOrEmpty(path)) continue;

				if (File.Exists(path))
				{
					File.Delete(path);
				}
				else if (Directory.Exists(path))
				{
					Directory.Delete(path, recursive: true);
				}

				listViewFiles.Items.Remove(item);
			}

			MessageBox.Show("Đã xóa các mục thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex);
		}
	}

	private void ExitApplication()
	{
		DialogResult result = MessageBox.Show(
			"Bạn có chắc chắn muốn thoát không?",
			"Xác nhận",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);

		if (result == DialogResult.Yes)
		{
			Application.Exit();
		}
	}

	#endregion

	#region BẮT SỰ KIỆN GIAO DIỆN (EVENT HANDLERS)

	private void TreeViewFolders_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
	{
		string? path = e.Node?.Tag?.ToString();
		if (string.IsNullOrEmpty(path)) return;

		e.Node?.Nodes.Clear();

		try
		{
			foreach (string folder in Directory.GetDirectories(path))
			{
				TreeNode child = new TreeNode(Path.GetFileName(folder))
				{
					Tag = folder
				};

				child.Nodes.Add("Đang tải...");
				e.Node?.Nodes.Add(child);
			}
		}
		catch (UnauthorizedAccessException)
		{
			// Bỏ qua thư mục hệ thống không có quyền truy cập
		}
	}

	private void TreeViewFolders_AfterSelect(object? sender, TreeViewEventArgs e)
	{
		string? path = e.Node?.Tag?.ToString();
		if (string.IsNullOrEmpty(path)) return;

		RefreshListView(path);
	}

	private void CboView_SelectedIndexChanged(object? sender, EventArgs e)
	{
		switch (cboView.SelectedItem?.ToString())
		{
			case "Large Icon":
				listViewFiles.View = View.LargeIcon;
				break;
			case "Small Icon":
				listViewFiles.View = View.SmallIcon;
				break;
			case "List":
				listViewFiles.View = View.List;
				break;
			case "Details":
				listViewFiles.View = View.Details;
				break;
			case "Tile":
				listViewFiles.View = View.Tile;
				break;
		}
	}

	// Các sự kiện nút bấm dùng chung cho MenuStrip, ToolStrip và ContextMenuStrip
	private void New_Click(object? sender, EventArgs e) => CreateNewFile();
	private void Copy_Click(object? sender, EventArgs e) => CopySelectedItem();
	private void Cut_Click(object? sender, EventArgs e) => CutSelectedItem();
	private void Paste_Click(object? sender, EventArgs e) => PasteItem();
	private void Delete_Click(object? sender, EventArgs e) => DeleteSelectedItem();
	private void Exit_Click(object? sender, EventArgs e) => ExitApplication();

	#endregion
}
