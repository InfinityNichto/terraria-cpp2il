using Cpp2IlInjected;
using Newtonsoft.Json;
using Terraria.Utilities;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200036F")]
public class WorldGenRange
{
	[Cpp2IlInjected.Token(Token = "0x20008C9")]
	public enum ScalingMode
	{
		[Cpp2IlInjected.Token(Token = "0x40080B3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40080B4")]
		WorldArea,
		[Cpp2IlInjected.Token(Token = "0x40080B5")]
		WorldWidth
	}

	[Cpp2IlInjected.Token(Token = "0x4003179")]
	public static readonly WorldGenRange Empty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400317A")]
	[JsonProperty]
	public readonly int Minimum;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400317B")]
	[JsonProperty]
	public readonly int Maximum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400317C")]
	[JsonProperty]
	[Cpp2IlInjected.Attribute(Name = "JsonConverterAttribute", RVA = "0x38B148", Offset = "0x38B148")]
	public readonly ScalingMode ScaleWith;

	[Cpp2IlInjected.Token(Token = "0x170005A0")]
	public int ScaledMinimum
	{
		[Cpp2IlInjected.Token(Token = "0x6002CB1")]
		[Cpp2IlInjected.Address(RVA = "0xA1195C", Offset = "0xA1195C", VA = "0xA1195C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005A1")]
	public int ScaledMaximum
	{
		[Cpp2IlInjected.Token(Token = "0x6002CB2")]
		[Cpp2IlInjected.Address(RVA = "0xA11A80", Offset = "0xA11A80", VA = "0xA11A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002CB3")]
	[Cpp2IlInjected.Address(RVA = "0xA11A88", Offset = "0xA11A88", VA = "0xA11A88")]
	public WorldGenRange(int minimum, int maximum)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CB4")]
	[Cpp2IlInjected.Address(RVA = "0xA11AB0", Offset = "0xA11AB0", VA = "0xA11AB0")]
	public int GetRandom(UnifiedRandom random)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CB5")]
	[Cpp2IlInjected.Address(RVA = "0xA11968", Offset = "0xA11968", VA = "0xA11968")]
	private int ScaleValue(int value)
	{
		return default(int);
	}
}
