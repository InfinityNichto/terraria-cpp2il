using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000558")]
public class TreePaintSystemData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006905")]
	public TreePaintingSettings DefaultNoSpecialGroups;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006906")]
	public TreePaintingSettings DefaultNoSpecialGroups_ForWalls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006907")]
	public TreePaintingSettings DefaultDirt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006908")]
	public TreePaintingSettings CullMud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006909")]
	public TreePaintingSettings WoodPurity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400690A")]
	public TreePaintingSettings WoodCorruption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400690B")]
	public TreePaintingSettings WoodJungle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400690C")]
	public TreePaintingSettings WoodHallow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400690D")]
	public TreePaintingSettings WoodSnow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400690E")]
	public TreePaintingSettings WoodCrimson;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400690F")]
	public TreePaintingSettings WoodJungleUnderground;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006910")]
	public TreePaintingSettings WoodGlowingMushroom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006911")]
	public TreePaintingSettings VanityCherry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4006912")]
	public TreePaintingSettings VanityYellowWillow;

	[Cpp2IlInjected.Token(Token = "0x4006913")]
	private static TreePaintingSettings TreeAsh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006914")]
	public TreePaintingSettings GemTreeRuby;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4006915")]
	private TreePaintingSettings GemTreeAmber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4006916")]
	private TreePaintingSettings GemTreeSapphire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4006917")]
	private TreePaintingSettings GemTreeEmerald;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4006918")]
	private TreePaintingSettings GemTreeAmethyst;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4006919")]
	private TreePaintingSettings GemTreeTopaz;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400691A")]
	private TreePaintingSettings GemTreeDiamond;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400691B")]
	public TreePaintingSettings PalmTreePurity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400691C")]
	public TreePaintingSettings PalmTreeCorruption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400691D")]
	public TreePaintingSettings PalmTreeCrimson;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400691E")]
	public TreePaintingSettings PalmTreeHallow;

	[Cpp2IlInjected.Token(Token = "0x6003A1C")]
	[Cpp2IlInjected.Address(RVA = "0x117ABF0", Offset = "0x117ABF0", VA = "0x117ABF0")]
	public TreePaintingSettings GetTileSettings(int tileType, int tileStyle)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A1D")]
	[Cpp2IlInjected.Address(RVA = "0x117AEAC", Offset = "0x117AEAC", VA = "0x117AEAC")]
	public TreePaintingSettings GetTreeFoliageSettings(int foliageIndex, int foliageStyle)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A1E")]
	[Cpp2IlInjected.Address(RVA = "0x117B01C", Offset = "0x117B01C", VA = "0x117B01C")]
	public TreePaintingSettings GetWallSettings(int wallType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A1F")]
	[Cpp2IlInjected.Address(RVA = "0x117B028", Offset = "0x117B028", VA = "0x117B028")]
	public TreePaintSystemData()
	{
	}
}
