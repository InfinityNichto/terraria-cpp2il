using Cpp2IlInjected;
using Terraria.Enums;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000420")]
public struct AnchorData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062A5")]
	public AnchorType type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40062A6")]
	public int tileCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062A7")]
	public int checkStart;

	[Cpp2IlInjected.Token(Token = "0x40062A8")]
	public static AnchorData Empty;

	[Cpp2IlInjected.Token(Token = "0x60030D1")]
	[Cpp2IlInjected.Address(RVA = "0x39AB4C", Offset = "0x39AB4C", VA = "0x39AB4C")]
	public AnchorData(AnchorType type, int count, int start)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030D2")]
	[Cpp2IlInjected.Address(RVA = "0x10113D0", Offset = "0x10113D0", VA = "0x10113D0")]
	public static bool operator ==(AnchorData data1, AnchorData data2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60030D3")]
	[Cpp2IlInjected.Address(RVA = "0x10113FC", Offset = "0x10113FC", VA = "0x10113FC")]
	public static bool operator !=(AnchorData data1, AnchorData data2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60030D4")]
	[Cpp2IlInjected.Address(RVA = "0x39AB58", Offset = "0x39AB58", VA = "0x39AB58", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60030D5")]
	[Cpp2IlInjected.Address(RVA = "0x39AB60", Offset = "0x39AB60", VA = "0x39AB60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
