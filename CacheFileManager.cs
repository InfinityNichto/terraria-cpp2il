using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000045")]
public class CacheFileManager : FileAPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool UploadingFiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private List<CachedFile> allFiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private List<CachedFile> modifications;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private ManualResetEvent uploadPending;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly FileManager fileManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly FileAPI fileAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly bool PrimaryUser;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly PlatformUser User;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private ManagedThread UploadThread;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private ManagedThread SyncThread;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private string _userSavePath;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1202F60", Offset = "0x1202F60", VA = "0x1202F60")]
	public CacheFileManager(FileManager fileMan, FileAPI api, bool primaryUser, PlatformUser user)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x12030C8", Offset = "0x12030C8", VA = "0x12030C8", Slot = "16")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x12031CC", Offset = "0x12031CC", VA = "0x12031CC")]
	public void ResyncFiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1203294", Offset = "0x1203294", VA = "0x1203294")]
	public void FileSyncInternal(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x120375C", Offset = "0x120375C", VA = "0x120375C")]
	private void SyncFolder(string folderPath, bool recursive = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1203C24", Offset = "0x1203C24", VA = "0x1203C24")]
	private CachedFile GetFile(string path, bool create = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1203A8C", Offset = "0x1203A8C", VA = "0x1203A8C")]
	public void SyncFile(string filePath)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1203EA4", Offset = "0x1203EA4", VA = "0x1203EA4")]
	private void FileUpload(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x12045A0", Offset = "0x12045A0", VA = "0x12045A0", Slot = "4")]
	public string GetUserSavePath()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x12045A8", Offset = "0x12045A8", VA = "0x12045A8", Slot = "5")]
	public void LegacySync()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x12045AC", Offset = "0x12045AC", VA = "0x12045AC", Slot = "6")]
	public void Mount(bool forSync)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x12045B0", Offset = "0x12045B0", VA = "0x12045B0", Slot = "7")]
	public void Unmount(bool forSync)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x12045B4", Offset = "0x12045B4", VA = "0x12045B4", Slot = "8")]
	public void CreateDirectory(string directory)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x12039B8", Offset = "0x12039B8", VA = "0x12039B8")]
	public void InSync()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x12045B8", Offset = "0x12045B8", VA = "0x12045B8", Slot = "9")]
	public void WriteFile(string filename, byte[] fileData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x120473C", Offset = "0x120473C", VA = "0x120473C", Slot = "10")]
	public void Delete(string filename)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1204888", Offset = "0x1204888", VA = "0x1204888", Slot = "11")]
	public byte[] ReadFile(string filename)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1203DC4", Offset = "0x1203DC4", VA = "0x1203DC4")]
	public string CleanPath(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x12048A8", Offset = "0x12048A8", VA = "0x12048A8", Slot = "13")]
	public string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1204A9C", Offset = "0x1204A9C", VA = "0x1204A9C", Slot = "14")]
	public string[] GetFolders(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x120449C", Offset = "0x120449C", VA = "0x120449C")]
	public void GetFileModifications(List<CachedFile> files)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1204AF4", Offset = "0x1204AF4", VA = "0x1204AF4", Slot = "12")]
	public bool Exists(string filename)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x1204B24", Offset = "0x1204B24", VA = "0x1204B24", Slot = "15")]
	public void SetAttributes(string filename, FileAttributes fileAttributes)
	{
	}
}
