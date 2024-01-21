using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.Net;

[Cpp2IlInjected.Token(Token = "0x200049D")]
public struct NetPacket
{
	[Cpp2IlInjected.Token(Token = "0x400654D")]
	private const int HEADER_SIZE = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400654E")]
	public readonly ushort Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006550")]
	public readonly CachedBuffer Buffer;

	[Cpp2IlInjected.Token(Token = "0x1700064F")]
	public int Length
	{
		[Cpp2IlInjected.Token(Token = "0x6003399")]
		[Cpp2IlInjected.Address(RVA = "0x39F134", Offset = "0x39F134", VA = "0x39F134")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600339A")]
		[Cpp2IlInjected.Address(RVA = "0x39F13C", Offset = "0x39F13C", VA = "0x39F13C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000650")]
	public BinaryWriter Writer
	{
		[Cpp2IlInjected.Token(Token = "0x600339B")]
		[Cpp2IlInjected.Address(RVA = "0x39F144", Offset = "0x39F144", VA = "0x39F144")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000651")]
	public BinaryReader Reader
	{
		[Cpp2IlInjected.Token(Token = "0x600339C")]
		[Cpp2IlInjected.Address(RVA = "0x39F150", Offset = "0x39F150", VA = "0x39F150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600339D")]
	[Cpp2IlInjected.Address(RVA = "0x39F15C", Offset = "0x39F15C", VA = "0x39F15C")]
	public NetPacket(ushort id, int size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600339E")]
	[Cpp2IlInjected.Address(RVA = "0x39F164", Offset = "0x39F164", VA = "0x39F164")]
	public void Recycle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600339F")]
	[Cpp2IlInjected.Address(RVA = "0x39F170", Offset = "0x39F170", VA = "0x39F170")]
	public void ShrinkToFit()
	{
	}
}
