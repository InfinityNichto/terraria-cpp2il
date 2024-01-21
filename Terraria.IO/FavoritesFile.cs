using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003C5")]
public class FavoritesFile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400327F")]
	public readonly string Path;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003280")]
	public readonly bool IsCloudSave;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003281")]
	private Dictionary<string, Dictionary<string, bool>> _data;

	[Cpp2IlInjected.Token(Token = "0x6002F6F")]
	[Cpp2IlInjected.Address(RVA = "0xE3C960", Offset = "0xE3C960", VA = "0xE3C960")]
	public FavoritesFile(string path, bool isCloud)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F70")]
	[Cpp2IlInjected.Address(RVA = "0xE3C9F4", Offset = "0xE3C9F4", VA = "0xE3C9F4")]
	public void SaveFavorite(FileData fileData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F71")]
	[Cpp2IlInjected.Address(RVA = "0xE3CD30", Offset = "0xE3CD30", VA = "0xE3CD30")]
	public void ClearEntry(FileData fileData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F72")]
	[Cpp2IlInjected.Address(RVA = "0xE3CDF0", Offset = "0xE3CDF0", VA = "0xE3CDF0")]
	public bool IsFavorite(FileData fileData)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002F73")]
	[Cpp2IlInjected.Address(RVA = "0xE3CB94", Offset = "0xE3CB94", VA = "0xE3CB94")]
	public void Save()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F74")]
	[Cpp2IlInjected.Address(RVA = "0xE3CECC", Offset = "0xE3CECC", VA = "0xE3CECC")]
	public void Load()
	{
	}
}
