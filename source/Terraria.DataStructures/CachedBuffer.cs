using System.IO;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000423")]
public class CachedBuffer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062B1")]
	public readonly byte[] Data;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40062B2")]
	public readonly BinaryWriter Writer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40062B3")]
	public readonly BinaryReader Reader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40062B4")]
	private readonly MemoryStream _memoryStream;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40062B5")]
	private bool _isActive;

	[Cpp2IlInjected.Token(Token = "0x17000609")]
	public int Length
	{
		[Cpp2IlInjected.Token(Token = "0x60030DF")]
		[Cpp2IlInjected.Address(RVA = "0x10123E8", Offset = "0x10123E8", VA = "0x10123E8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700060A")]
	public bool IsActive
	{
		[Cpp2IlInjected.Token(Token = "0x60030E0")]
		[Cpp2IlInjected.Address(RVA = "0x1012728", Offset = "0x1012728", VA = "0x1012728")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60030E1")]
	[Cpp2IlInjected.Address(RVA = "0x1012020", Offset = "0x1012020", VA = "0x1012020")]
	public CachedBuffer(byte[] data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030E2")]
	[Cpp2IlInjected.Address(RVA = "0x10120FC", Offset = "0x10120FC", VA = "0x10120FC")]
	internal CachedBuffer Activate()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030E3")]
	[Cpp2IlInjected.Address(RVA = "0x1012730", Offset = "0x1012730", VA = "0x1012730")]
	public void Recycle()
	{
	}
}
