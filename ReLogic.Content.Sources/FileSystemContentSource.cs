using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace ReLogic.Content.Sources;

[Cpp2IlInjected.Token(Token = "0x200074E")]
public class FileSystemContentSource : IContentSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007374")]
	private readonly string _basePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007375")]
	private readonly Dictionary<string, string> _nameToAbsolutePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4007376")]
	private readonly RejectedAssetCollection _rejections;

	[Cpp2IlInjected.Token(Token = "0x17000822")]
	public IContentValidator ContentValidator
	{
		[Cpp2IlInjected.Token(Token = "0x60047A0")]
		[Cpp2IlInjected.Address(RVA = "0x10BF014", Offset = "0x10BF014", VA = "0x10BF014", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60047A1")]
		[Cpp2IlInjected.Address(RVA = "0x10BF01C", Offset = "0x10BF01C", VA = "0x10BF01C", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000823")]
	public int FileCount
	{
		[Cpp2IlInjected.Token(Token = "0x60047A2")]
		[Cpp2IlInjected.Address(RVA = "0x10BF024", Offset = "0x10BF024", VA = "0x10BF024")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60047A3")]
	[Cpp2IlInjected.Address(RVA = "0x10BF080", Offset = "0x10BF080", VA = "0x10BF080")]
	public FileSystemContentSource(string basePath)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047A4")]
	[Cpp2IlInjected.Address(RVA = "0x10BF370", Offset = "0x10BF370", VA = "0x10BF370", Slot = "6")]
	public bool HasAsset(string assetName)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047A5")]
	[Cpp2IlInjected.Address(RVA = "0x10BF3F0", Offset = "0x10BF3F0", VA = "0x10BF3F0", Slot = "7")]
	public string GetExtension(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047A6")]
	[Cpp2IlInjected.Address(RVA = "0x10BF4E8", Offset = "0x10BF4E8", VA = "0x10BF4E8", Slot = "8")]
	public Stream OpenStream(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047A7")]
	[Cpp2IlInjected.Address(RVA = "0x10BF214", Offset = "0x10BF214", VA = "0x10BF214")]
	private void BuildNameToAbsolutePathDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047A8")]
	[Cpp2IlInjected.Address(RVA = "0x10BF630", Offset = "0x10BF630", VA = "0x10BF630", Slot = "9")]
	public void RejectAsset(string assetName, IRejectionReason reason)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047A9")]
	[Cpp2IlInjected.Address(RVA = "0x10BF638", Offset = "0x10BF638", VA = "0x10BF638", Slot = "10")]
	public void ClearRejections()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047AA")]
	[Cpp2IlInjected.Address(RVA = "0x10BF640", Offset = "0x10BF640", VA = "0x10BF640", Slot = "11")]
	public bool TryGetRejections(List<string> rejectionReasons)
	{
		return default(bool);
	}
}
