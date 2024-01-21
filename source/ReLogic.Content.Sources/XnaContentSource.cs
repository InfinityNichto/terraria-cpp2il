using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace ReLogic.Content.Sources;

[Cpp2IlInjected.Token(Token = "0x2000750")]
public class XnaContentSource : IContentSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007377")]
	private readonly string _rootDirectory;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007378")]
	private readonly HashSet<string> _files;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400737A")]
	private readonly RejectedAssetCollection _rejections;

	[Cpp2IlInjected.Token(Token = "0x17000825")]
	public IContentValidator ContentValidator
	{
		[Cpp2IlInjected.Token(Token = "0x60047B3")]
		[Cpp2IlInjected.Address(RVA = "0x10BF648", Offset = "0x10BF648", VA = "0x10BF648", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60047B4")]
		[Cpp2IlInjected.Address(RVA = "0x10BF650", Offset = "0x10BF650", VA = "0x10BF650", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60047B5")]
	[Cpp2IlInjected.Address(RVA = "0x10BF658", Offset = "0x10BF658", VA = "0x10BF658")]
	public XnaContentSource(string rootDirectory)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047B6")]
	[Cpp2IlInjected.Address(RVA = "0x10BF720", Offset = "0x10BF720", VA = "0x10BF720")]
	private void BuildFileMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047B7")]
	[Cpp2IlInjected.Address(RVA = "0x10BF7F0", Offset = "0x10BF7F0", VA = "0x10BF7F0", Slot = "6")]
	public bool HasAsset(string assetName)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047B8")]
	[Cpp2IlInjected.Address(RVA = "0x10BF8DC", Offset = "0x10BF8DC", VA = "0x10BF8DC", Slot = "7")]
	public string GetExtension(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047B9")]
	[Cpp2IlInjected.Address(RVA = "0x10BF92C", Offset = "0x10BF92C", VA = "0x10BF92C", Slot = "8")]
	public Stream OpenStream(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047BA")]
	[Cpp2IlInjected.Address(RVA = "0x10BFA70", Offset = "0x10BFA70", VA = "0x10BFA70")]
	public static string GetTitleLocationPath()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047BB")]
	[Cpp2IlInjected.Address(RVA = "0x10BFB64", Offset = "0x10BFB64", VA = "0x10BFB64", Slot = "9")]
	public void RejectAsset(string assetName, IRejectionReason reason)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047BC")]
	[Cpp2IlInjected.Address(RVA = "0x10BFB6C", Offset = "0x10BFB6C", VA = "0x10BFB6C", Slot = "10")]
	public void ClearRejections()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047BD")]
	[Cpp2IlInjected.Address(RVA = "0x10BFB74", Offset = "0x10BFB74", VA = "0x10BFB74", Slot = "11")]
	public bool TryGetRejections(List<string> rejectionReasons)
	{
		return default(bool);
	}
}
