using System.Runtime.InteropServices;
using System.Text;

namespace SpaceshipWar;

public static class SoundManager
{
	// Sử dụng winmm.dll của Windows để phát cả .mp3 và .wav
	[DllImport("winmm.dll", CharSet = CharSet.Unicode)]
	private static extern long mciSendString(string strCommand, StringBuilder? strReturn, int iReturnLength, IntPtr hwndCallback);

	// Khởi tạo và nạp file âm thanh với 1 bí danh (alias)
	public static void Load(string fileName, string alias)
	{
		string path = Path.Combine(AppContext.BaseDirectory, "asset", fileName);
		if (File.Exists(path))
		{
			// Đóng trước phòng trường hợp đã mở
			Close(alias);
			mciSendString($"open \"{path}\" type mpegvideo alias {alias}", null, 0, IntPtr.Zero);
		}
	}

	// Phát âm thanh từ đầu (loop = true nếu muốn lặp lại như nhạc nền)
	public static void Play(string alias, bool loop = false)
	{
		string command = $"play {alias} from 0";
		if (loop)
		{
			command += " repeat";
		}
		mciSendString(command, null, 0, IntPtr.Zero);
	}

	// Dừng âm thanh
	public static void Stop(string alias)
	{
		mciSendString($"stop {alias}", null, 0, IntPtr.Zero);
	}

	// Giải phóng âm thanh
	public static void Close(string alias)
	{
		mciSendString($"close {alias}", null, 0, IntPtr.Zero);
	}
}