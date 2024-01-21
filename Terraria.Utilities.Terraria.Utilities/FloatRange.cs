using Cpp2IlInjected;
using Newtonsoft.Json;

namespace Terraria.Utilities.Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x200037F")]
public struct FloatRange
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40031A3")]
	[JsonProperty]
	public readonly float Minimum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40031A4")]
	[JsonProperty]
	public readonly float Maximum;

	[Cpp2IlInjected.Token(Token = "0x6002D34")]
	[Cpp2IlInjected.Address(RVA = "0x39C954", Offset = "0x39C954", VA = "0x39C954")]
	public FloatRange(float minimum, float maximum)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D35")]
	[Cpp2IlInjected.Address(RVA = "0x10DE204", Offset = "0x10DE204", VA = "0x10DE204")]
	public static FloatRange operator *(FloatRange range, float scale)
	{
		return default(FloatRange);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D36")]
	[Cpp2IlInjected.Address(RVA = "0x10DE224", Offset = "0x10DE224", VA = "0x10DE224")]
	public static FloatRange operator *(float scale, FloatRange range)
	{
		return default(FloatRange);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D37")]
	[Cpp2IlInjected.Address(RVA = "0x10DE244", Offset = "0x10DE244", VA = "0x10DE244")]
	public static FloatRange operator /(FloatRange range, float scale)
	{
		return default(FloatRange);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D38")]
	[Cpp2IlInjected.Address(RVA = "0x10DE264", Offset = "0x10DE264", VA = "0x10DE264")]
	public static FloatRange operator /(float scale, FloatRange range)
	{
		return default(FloatRange);
	}
}
