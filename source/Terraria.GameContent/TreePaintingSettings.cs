using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000557")]
public class TreePaintingSettings
{
	[Cpp2IlInjected.Token(Token = "0x200097E")]
	public enum TreePaintingSettingsId
	{
		[Cpp2IlInjected.Token(Token = "0x4008C08")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4008C09")]
		DefaultDirt,
		[Cpp2IlInjected.Token(Token = "0x4008C0A")]
		CullMud,
		[Cpp2IlInjected.Token(Token = "0x4008C0B")]
		WoodPurity,
		[Cpp2IlInjected.Token(Token = "0x4008C0C")]
		WoodCorruption,
		[Cpp2IlInjected.Token(Token = "0x4008C0D")]
		WoodJungle,
		[Cpp2IlInjected.Token(Token = "0x4008C0E")]
		WoodHallow,
		[Cpp2IlInjected.Token(Token = "0x4008C0F")]
		WoodSnow,
		[Cpp2IlInjected.Token(Token = "0x4008C10")]
		WoodCrimson,
		[Cpp2IlInjected.Token(Token = "0x4008C11")]
		WoodJungleUnderground,
		[Cpp2IlInjected.Token(Token = "0x4008C12")]
		WoodGlowingMushroom,
		[Cpp2IlInjected.Token(Token = "0x4008C13")]
		VanityCherry,
		[Cpp2IlInjected.Token(Token = "0x4008C14")]
		VanityYellowWillow,
		[Cpp2IlInjected.Token(Token = "0x4008C15")]
		GemTree,
		[Cpp2IlInjected.Token(Token = "0x4008C16")]
		PalmTreePurity,
		[Cpp2IlInjected.Token(Token = "0x4008C17")]
		PalmTreeCorruption,
		[Cpp2IlInjected.Token(Token = "0x4008C18")]
		PalmTreeCrimson,
		[Cpp2IlInjected.Token(Token = "0x4008C19")]
		PalmTreeHallow,
		[Cpp2IlInjected.Token(Token = "0x4008C1A")]
		Count
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40068FC")]
	public TreePaintingSettingsId Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40068FD")]
	public float SpecialGroupMinimalHueValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40068FE")]
	public float SpecialGroupMaximumHueValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40068FF")]
	public float SpecialGroupMinimumSaturationValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006900")]
	public float SpecialGroupMaximumSaturationValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006901")]
	public float HueTestOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006902")]
	public bool UseSpecialGroups;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4006903")]
	public bool UseWallShaderHacks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4006904")]
	public bool InvertSpecialGroupResult;

	[Cpp2IlInjected.Token(Token = "0x6003A1B")]
	[Cpp2IlInjected.Address(RVA = "0x117B654", Offset = "0x117B654", VA = "0x117B654")]
	public TreePaintingSettings()
	{
	}
}
