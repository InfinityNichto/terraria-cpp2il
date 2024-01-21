using System.IO;
using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000325")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384EA8", Offset = "0x384EA8")]
public struct BitsByte
{
	[Cpp2IlInjected.Token(Token = "0x4002C7F")]
	private static bool Null;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002C80")]
	private byte value;

	[Cpp2IlInjected.Token(Token = "0x17000528")]
	public bool Item
	{
		[Cpp2IlInjected.Token(Token = "0x600258C")]
		[Cpp2IlInjected.Address(RVA = "0x39D2F4", Offset = "0x39D2F4", VA = "0x39D2F4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600258D")]
		[Cpp2IlInjected.Address(RVA = "0x39D310", Offset = "0x39D310", VA = "0x39D310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002589")]
	[Cpp2IlInjected.Address(RVA = "0x39D288", Offset = "0x39D288", VA = "0x39D288")]
	public BitsByte(bool b1 = false, bool b2 = false, bool b3 = false, bool b4 = false, bool b5 = false, bool b6 = false, bool b7 = false, bool b8 = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600258A")]
	[Cpp2IlInjected.Address(RVA = "0x39D2DC", Offset = "0x39D2DC", VA = "0x39D2DC")]
	public void ClearAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600258B")]
	[Cpp2IlInjected.Address(RVA = "0x39D2E8", Offset = "0x39D2E8", VA = "0x39D2E8")]
	public void SetAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600258E")]
	[Cpp2IlInjected.Address(RVA = "0x39D338", Offset = "0x39D338", VA = "0x39D338")]
	public void Retrieve(ref bool b0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600258F")]
	[Cpp2IlInjected.Address(RVA = "0x39D340", Offset = "0x39D340", VA = "0x39D340")]
	public void Retrieve(ref bool b0, ref bool b1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002590")]
	[Cpp2IlInjected.Address(RVA = "0x39D348", Offset = "0x39D348", VA = "0x39D348")]
	public void Retrieve(ref bool b0, ref bool b1, ref bool b2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002591")]
	[Cpp2IlInjected.Address(RVA = "0x39D364", Offset = "0x39D364", VA = "0x39D364")]
	public void Retrieve(ref bool b0, ref bool b1, ref bool b2, ref bool b3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002592")]
	[Cpp2IlInjected.Address(RVA = "0x39D388", Offset = "0x39D388", VA = "0x39D388")]
	public void Retrieve(ref bool b0, ref bool b1, ref bool b2, ref bool b3, ref bool b4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002593")]
	[Cpp2IlInjected.Address(RVA = "0x39D3B0", Offset = "0x39D3B0", VA = "0x39D3B0")]
	public void Retrieve(ref bool b0, ref bool b1, ref bool b2, ref bool b3, ref bool b4, ref bool b5)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002594")]
	[Cpp2IlInjected.Address(RVA = "0x39D3E0", Offset = "0x39D3E0", VA = "0x39D3E0")]
	public void Retrieve(ref bool b0, ref bool b1, ref bool b2, ref bool b3, ref bool b4, ref bool b5, ref bool b6)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002595")]
	[Cpp2IlInjected.Address(RVA = "0x39D41C", Offset = "0x39D41C", VA = "0x39D41C")]
	public void Retrieve(ref bool b0, ref bool b1, ref bool b2, ref bool b3, ref bool b4, ref bool b5, ref bool b6, ref bool b7)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002596")]
	[Cpp2IlInjected.Address(RVA = "0x11CADF8", Offset = "0x11CADF8", VA = "0x11CADF8")]
	public static implicit operator byte(BitsByte bb)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002597")]
	[Cpp2IlInjected.Address(RVA = "0x11CAE00", Offset = "0x11CAE00", VA = "0x11CAE00")]
	public static implicit operator BitsByte(byte b)
	{
		return default(BitsByte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002598")]
	[Cpp2IlInjected.Address(RVA = "0x11CAE04", Offset = "0x11CAE04", VA = "0x11CAE04")]
	public static BitsByte[] ComposeBitsBytesChain(bool optimizeLength, params bool[] flags)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002599")]
	[Cpp2IlInjected.Address(RVA = "0x11CAFBC", Offset = "0x11CAFBC", VA = "0x11CAFBC")]
	public static BitsByte[] DecomposeBitsBytesChain(BinaryReader reader)
	{
		return null;
	}
}
