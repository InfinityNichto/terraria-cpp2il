using Cpp2IlInjected;
using Newtonsoft.Json;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000378")]
public struct IntRange
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400318E")]
	[JsonProperty]
	public readonly int Minimum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400318F")]
	[JsonProperty]
	public readonly int Maximum;

	[Cpp2IlInjected.Token(Token = "0x6002D08")]
	[Cpp2IlInjected.Address(RVA = "0x39C7C0", Offset = "0x39C7C0", VA = "0x39C7C0")]
	public IntRange(int minimum, int maximum)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D09")]
	[Cpp2IlInjected.Address(RVA = "0x10DBB54", Offset = "0x10DBB54", VA = "0x10DBB54")]
	public static IntRange operator *(IntRange range, float scale)
	{
		return default(IntRange);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D0A")]
	[Cpp2IlInjected.Address(RVA = "0x10DBB84", Offset = "0x10DBB84", VA = "0x10DBB84")]
	public static IntRange operator *(float scale, IntRange range)
	{
		return default(IntRange);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D0B")]
	[Cpp2IlInjected.Address(RVA = "0x10DBBB4", Offset = "0x10DBBB4", VA = "0x10DBBB4")]
	public static IntRange operator /(IntRange range, float scale)
	{
		return default(IntRange);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D0C")]
	[Cpp2IlInjected.Address(RVA = "0x10DBBE4", Offset = "0x10DBBE4", VA = "0x10DBBE4")]
	public static IntRange operator /(float scale, IntRange range)
	{
		return default(IntRange);
	}
}
