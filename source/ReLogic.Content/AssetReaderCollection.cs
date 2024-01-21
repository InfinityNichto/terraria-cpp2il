using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using ReLogic.Content.Readers;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x2000744")]
public class AssetReaderCollection
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400735A")]
	private readonly Dictionary<string, IAssetReader> _readersByExtension;

	[Cpp2IlInjected.Token(Token = "0x6004768")]
	[Cpp2IlInjected.Address(RVA = "0x10BD548", Offset = "0x10BD548", VA = "0x10BD548")]
	public void RegisterReader(IAssetReader reader, params string[] extensions)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004769")]
	[Cpp2IlInjected.Address(RVA = "0x15AD8B8", Offset = "0x15AD8B8", VA = "0x15AD8B8")]
	public T Read<T>(Stream stream, string extension) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600476A")]
	[Cpp2IlInjected.Address(RVA = "0x10BD5F0", Offset = "0x10BD5F0", VA = "0x10BD5F0")]
	public bool CanReadExtension(string extension)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600476B")]
	[Cpp2IlInjected.Address(RVA = "0x10BD664", Offset = "0x10BD664", VA = "0x10BD664")]
	public AssetReaderCollection()
	{
	}
}
