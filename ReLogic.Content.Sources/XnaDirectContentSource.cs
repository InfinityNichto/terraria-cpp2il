using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace ReLogic.Content.Sources;

[Cpp2IlInjected.Token(Token = "0x2000751")]
public class XnaDirectContentSource : IContentSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400737B")]
	private readonly string _rootDirectory;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400737C")]
	private readonly HashSet<string> _files;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400737E")]
	private readonly RejectedAssetCollection _rejections;

	[Cpp2IlInjected.Token(Token = "0x17000826")]
	public IContentValidator ContentValidator
	{
		[Cpp2IlInjected.Token(Token = "0x60047BE")]
		[Cpp2IlInjected.Address(RVA = "0x10BFB7C", Offset = "0x10BFB7C", VA = "0x10BFB7C", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60047BF")]
		[Cpp2IlInjected.Address(RVA = "0x10BFB84", Offset = "0x10BFB84", VA = "0x10BFB84", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60047C0")]
	[Cpp2IlInjected.Address(RVA = "0x10BFB8C", Offset = "0x10BFB8C", VA = "0x10BFB8C")]
	public XnaDirectContentSource(string rootDirectory)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047C1")]
	[Cpp2IlInjected.Address(RVA = "0x10BFC54", Offset = "0x10BFC54", VA = "0x10BFC54")]
	private void BuildFileMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047C2")]
	[Cpp2IlInjected.Address(RVA = "0x10BFD24", Offset = "0x10BFD24", VA = "0x10BFD24", Slot = "6")]
	public bool HasAsset(string assetName)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047C3")]
	[Cpp2IlInjected.Address(RVA = "0x10BFE10", Offset = "0x10BFE10", VA = "0x10BFE10", Slot = "7")]
	public string GetExtension(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047C4")]
	[Cpp2IlInjected.Address(RVA = "0x10BFE60", Offset = "0x10BFE60", VA = "0x10BFE60", Slot = "8")]
	public Stream OpenStream(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047C5")]
	[Cpp2IlInjected.Address(RVA = "0x10BFFA4", Offset = "0x10BFFA4", VA = "0x10BFFA4", Slot = "9")]
	public void RejectAsset(string assetName, IRejectionReason reason)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047C6")]
	[Cpp2IlInjected.Address(RVA = "0x10BFFAC", Offset = "0x10BFFAC", VA = "0x10BFFAC", Slot = "10")]
	public void ClearRejections()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047C7")]
	[Cpp2IlInjected.Address(RVA = "0x10BFFB4", Offset = "0x10BFFB4", VA = "0x10BFFB4", Slot = "11")]
	public bool TryGetRejections(List<string> rejectionReasons)
	{
		return default(bool);
	}
}
