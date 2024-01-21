using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Ionic.Zip;

namespace ReLogic.Content.Sources;

[Cpp2IlInjected.Token(Token = "0x2000752")]
public class ZipContentSource : IContentSource, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007380")]
	private readonly ZipFile _zipFile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007381")]
	private readonly Dictionary<string, ZipEntry> _entries;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4007382")]
	private readonly string _basePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007383")]
	private bool _isDisposed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4007384")]
	private readonly RejectedAssetCollection _rejections;

	[Cpp2IlInjected.Token(Token = "0x17000827")]
	public int EntryCount
	{
		[Cpp2IlInjected.Token(Token = "0x60047C8")]
		[Cpp2IlInjected.Address(RVA = "0x10BFFBC", Offset = "0x10BFFBC", VA = "0x10BFFBC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000828")]
	public IContentValidator ContentValidator
	{
		[Cpp2IlInjected.Token(Token = "0x60047C9")]
		[Cpp2IlInjected.Address(RVA = "0x10C0018", Offset = "0x10C0018", VA = "0x10C0018", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60047CA")]
		[Cpp2IlInjected.Address(RVA = "0x10C0020", Offset = "0x10C0020", VA = "0x10C0020", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60047CB")]
	[Cpp2IlInjected.Address(RVA = "0x10C0028", Offset = "0x10C0028", VA = "0x10C0028")]
	public ZipContentSource(string path)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047CC")]
	[Cpp2IlInjected.Address(RVA = "0x10C008C", Offset = "0x10C008C", VA = "0x10C008C")]
	public ZipContentSource(string path, string contentDir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047CD")]
	[Cpp2IlInjected.Address(RVA = "0x10C0754", Offset = "0x10C0754", VA = "0x10C0754", Slot = "6")]
	public bool HasAsset(string assetName)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047CE")]
	[Cpp2IlInjected.Address(RVA = "0x10C07E8", Offset = "0x10C07E8", VA = "0x10C07E8", Slot = "7")]
	public string GetExtension(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047CF")]
	[Cpp2IlInjected.Address(RVA = "0x10C08E4", Offset = "0x10C08E4", VA = "0x10C08E4", Slot = "8")]
	public Stream OpenStream(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047D0")]
	[Cpp2IlInjected.Address(RVA = "0x10C0384", Offset = "0x10C0384", VA = "0x10C0384")]
	private void BuildExtensionFreeEntryList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047D1")]
	[Cpp2IlInjected.Address(RVA = "0x10C01F8", Offset = "0x10C01F8", VA = "0x10C01F8")]
	private static bool ZipPathContainsInvalidCharacters(string path)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047D2")]
	[Cpp2IlInjected.Address(RVA = "0x10C0284", Offset = "0x10C0284", VA = "0x10C0284")]
	private static string CleanZipPath(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047D3")]
	[Cpp2IlInjected.Address(RVA = "0x10C09E8", Offset = "0x10C09E8", VA = "0x10C09E8", Slot = "13")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047D4")]
	[Cpp2IlInjected.Address(RVA = "0x10C0A70", Offset = "0x10C0A70", VA = "0x10C0A70", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047D5")]
	[Cpp2IlInjected.Address(RVA = "0x10C0A84", Offset = "0x10C0A84", VA = "0x10C0A84", Slot = "9")]
	public void RejectAsset(string assetName, IRejectionReason reason)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047D6")]
	[Cpp2IlInjected.Address(RVA = "0x10C0A8C", Offset = "0x10C0A8C", VA = "0x10C0A8C", Slot = "10")]
	public void ClearRejections()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047D7")]
	[Cpp2IlInjected.Address(RVA = "0x10C0A94", Offset = "0x10C0A94", VA = "0x10C0A94", Slot = "11")]
	public bool TryGetRejections(List<string> rejectionReasons)
	{
		return default(bool);
	}
}
