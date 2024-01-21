using Cpp2IlInjected;

namespace Terraria.Graphics.Capture;

[Cpp2IlInjected.Token(Token = "0x2000508")]
public class CaptureBiome
{
	[Cpp2IlInjected.Token(Token = "0x2000960")]
	public enum TileColorStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4008B8C")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4008B8D")]
		Jungle,
		[Cpp2IlInjected.Token(Token = "0x4008B8E")]
		Crimson,
		[Cpp2IlInjected.Token(Token = "0x4008B8F")]
		Corrupt,
		[Cpp2IlInjected.Token(Token = "0x4008B90")]
		Mushroom
	}

	[Cpp2IlInjected.Token(Token = "0x2000961")]
	public class Sets
	{
		[Cpp2IlInjected.Token(Token = "0x2000B9F")]
		public class WaterStyles
		{
			[Cpp2IlInjected.Token(Token = "0x40090ED")]
			public const int BloodMoon = 9;

			[Cpp2IlInjected.Token(Token = "0x6005451")]
			[Cpp2IlInjected.Address(RVA = "0x1313A00", Offset = "0x1313A00", VA = "0x1313A00")]
			public WaterStyles()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D88")]
		[Cpp2IlInjected.Address(RVA = "0x13139F8", Offset = "0x13139F8", VA = "0x13139F8")]
		public Sets()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000962")]
	public class Styles
	{
		[Cpp2IlInjected.Token(Token = "0x4008B91")]
		public static CaptureBiome Purity;

		[Cpp2IlInjected.Token(Token = "0x4008B92")]
		public static CaptureBiome Purity2;

		[Cpp2IlInjected.Token(Token = "0x4008B93")]
		public static CaptureBiome Purity3;

		[Cpp2IlInjected.Token(Token = "0x4008B94")]
		public static CaptureBiome Purity4;

		[Cpp2IlInjected.Token(Token = "0x4008B95")]
		public static CaptureBiome Corruption;

		[Cpp2IlInjected.Token(Token = "0x4008B96")]
		public static CaptureBiome Jungle;

		[Cpp2IlInjected.Token(Token = "0x4008B97")]
		public static CaptureBiome Hallow;

		[Cpp2IlInjected.Token(Token = "0x4008B98")]
		public static CaptureBiome Snow;

		[Cpp2IlInjected.Token(Token = "0x4008B99")]
		public static CaptureBiome Desert;

		[Cpp2IlInjected.Token(Token = "0x4008B9A")]
		public static CaptureBiome DirtLayer;

		[Cpp2IlInjected.Token(Token = "0x4008B9B")]
		public static CaptureBiome RockLayer;

		[Cpp2IlInjected.Token(Token = "0x4008B9C")]
		public static CaptureBiome BloodMoon;

		[Cpp2IlInjected.Token(Token = "0x4008B9D")]
		public static CaptureBiome Crimson;

		[Cpp2IlInjected.Token(Token = "0x4008B9E")]
		public static CaptureBiome UndergroundDesert;

		[Cpp2IlInjected.Token(Token = "0x4008B9F")]
		public static CaptureBiome Ocean;

		[Cpp2IlInjected.Token(Token = "0x4008BA0")]
		public static CaptureBiome Mushroom;

		[Cpp2IlInjected.Token(Token = "0x6004D89")]
		[Cpp2IlInjected.Address(RVA = "0x1313A08", Offset = "0x1313A08", VA = "0x1313A08")]
		public Styles()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000963")]
	private enum BiomeChoiceIndex
	{
		[Cpp2IlInjected.Token(Token = "0x4008BA2")]
		AutomatedForPlayer = -1,
		[Cpp2IlInjected.Token(Token = "0x4008BA3")]
		Purity = 1,
		[Cpp2IlInjected.Token(Token = "0x4008BA4")]
		Corruption = 2,
		[Cpp2IlInjected.Token(Token = "0x4008BA5")]
		Jungle = 3,
		[Cpp2IlInjected.Token(Token = "0x4008BA6")]
		Hallow = 4,
		[Cpp2IlInjected.Token(Token = "0x4008BA7")]
		Snow = 5,
		[Cpp2IlInjected.Token(Token = "0x4008BA8")]
		Desert = 6,
		[Cpp2IlInjected.Token(Token = "0x4008BA9")]
		DirtLayer = 7,
		[Cpp2IlInjected.Token(Token = "0x4008BAA")]
		RockLayer = 8,
		[Cpp2IlInjected.Token(Token = "0x4008BAB")]
		Crimson = 9,
		[Cpp2IlInjected.Token(Token = "0x4008BAC")]
		UndergroundDesert = 10,
		[Cpp2IlInjected.Token(Token = "0x4008BAD")]
		Ocean = 11,
		[Cpp2IlInjected.Token(Token = "0x4008BAE")]
		Mushroom = 12
	}

	[Cpp2IlInjected.Token(Token = "0x40067E8")]
	public static readonly CaptureBiome DefaultPurity;

	[Cpp2IlInjected.Token(Token = "0x40067E9")]
	public static CaptureBiome[] BiomesByWaterStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40067EA")]
	public readonly int WaterStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40067EB")]
	public readonly int BackgroundIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40067EC")]
	public readonly TileColorStyle TileColor;

	[Cpp2IlInjected.Token(Token = "0x60037DE")]
	[Cpp2IlInjected.Address(RVA = "0x1312BC4", Offset = "0x1312BC4", VA = "0x1312BC4")]
	public CaptureBiome(int backgroundIndex, int waterStyle, TileColorStyle tileColorStyle = TileColorStyle.Normal)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037DF")]
	[Cpp2IlInjected.Address(RVA = "0x1312BF4", Offset = "0x1312BF4", VA = "0x1312BF4")]
	public static CaptureBiome GetCaptureBiome(int biomeChoice)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60037E0")]
	[Cpp2IlInjected.Address(RVA = "0x1313540", Offset = "0x1313540", VA = "0x1313540")]
	private static CaptureBiome GetBiomeByWater()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60037E1")]
	[Cpp2IlInjected.Address(RVA = "0x13131B0", Offset = "0x13131B0", VA = "0x13131B0")]
	private static CaptureBiome GetBiomeByLocation()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60037E2")]
	[Cpp2IlInjected.Address(RVA = "0x1312FB0", Offset = "0x1312FB0", VA = "0x1312FB0")]
	private static CaptureBiome GetPurityForPlayer()
	{
		return null;
	}
}
