using System;
using System.IO;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200004B")]
public class FileManager
{
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	[ThreadStatic]
	public static FileManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public bool CacheFiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public FileAPI fileAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public CacheFileManager FileCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool IsSyncingUserFiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public bool IsWritingFiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public SyncStatus syncStatus;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x20D339C", Offset = "0x20D339C", VA = "0x20D339C")]
	public FileManager(PlatformUser user, bool primaryUser)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x20D3468", Offset = "0x20D3468", VA = "0x20D3468")]
	public static void SynchroniseFiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x20D3544", Offset = "0x20D3544", VA = "0x20D3544")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x20D3618", Offset = "0x20D3618", VA = "0x20D3618")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x20D375C", Offset = "0x20D375C", VA = "0x20D375C")]
	public static void Delete(string path)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x20D39F0", Offset = "0x20D39F0", VA = "0x20D39F0")]
	public static void CreateDirectory(string path)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x20D3B34", Offset = "0x20D3B34", VA = "0x20D3B34")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x20D3C78", Offset = "0x20D3C78", VA = "0x20D3C78")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x20D3DC8", Offset = "0x20D3DC8", VA = "0x20D3DC8")]
	public static void WriteAllBytes(string path, byte[] fileData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x20D3F8C", Offset = "0x20D3F8C", VA = "0x20D3F8C")]
	public static void SetAttributes(string path, FileAttributes fileAttributes)
	{
	}
}
