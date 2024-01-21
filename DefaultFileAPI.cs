using System.IO;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000047")]
public class DefaultFileAPI : FileAPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int mountCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private string _userSavePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private PlatformUser platformUser;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x20C93B8", Offset = "0x20C93B8", VA = "0x20C93B8")]
	public DefaultFileAPI(PlatformUser user)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x20C945C", Offset = "0x20C945C", VA = "0x20C945C", Slot = "16")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x20C9460", Offset = "0x20C9460", VA = "0x20C9460", Slot = "4")]
	public string GetUserSavePath()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x20C9750", Offset = "0x20C9750", VA = "0x20C9750", Slot = "5")]
	public void LegacySync()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x20C9754", Offset = "0x20C9754", VA = "0x20C9754", Slot = "6")]
	public void Mount(bool forSync)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x20C97E4", Offset = "0x20C97E4", VA = "0x20C97E4", Slot = "7")]
	public void Unmount(bool forSync)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x20C97E8", Offset = "0x20C97E8", VA = "0x20C97E8", Slot = "8")]
	public void CreateDirectory(string directory)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x20C97F4", Offset = "0x20C97F4", VA = "0x20C97F4", Slot = "9")]
	public void WriteFile(string filename, byte[] fileData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x20C98A4", Offset = "0x20C98A4", VA = "0x20C98A4", Slot = "10")]
	public void Delete(string filename)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x20C98B0", Offset = "0x20C98B0", VA = "0x20C98B0", Slot = "11")]
	public byte[] ReadFile(string filename)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x20C98BC", Offset = "0x20C98BC", VA = "0x20C98BC", Slot = "13")]
	public string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x20C9944", Offset = "0x20C9944", VA = "0x20C9944", Slot = "14")]
	public string[] GetFolders(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x20C99C4", Offset = "0x20C99C4", VA = "0x20C99C4", Slot = "12")]
	public bool Exists(string filename)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x20C99D0", Offset = "0x20C99D0", VA = "0x20C99D0", Slot = "15")]
	public void SetAttributes(string filename, FileAttributes fileAttributes)
	{
	}
}
