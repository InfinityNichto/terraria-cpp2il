using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000644")]
public class NamePlateInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C88")]
	private string _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C89")]
	private int _npcNetId;

	[Cpp2IlInjected.Token(Token = "0x6003F3B")]
	[Cpp2IlInjected.Address(RVA = "0x10F7C5C", Offset = "0x10F7C5C", VA = "0x10F7C5C")]
	public NamePlateInfoElement(string languageKey, int npcNetId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F3C")]
	[Cpp2IlInjected.Address(RVA = "0x11027F4", Offset = "0x11027F4", VA = "0x11027F4")]
	public string GetName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F3D")]
	[Cpp2IlInjected.Address(RVA = "0x1102800", Offset = "0x1102800", VA = "0x1102800", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F3E")]
	[Cpp2IlInjected.Address(RVA = "0x11029B0", Offset = "0x11029B0", VA = "0x11029B0", Slot = "5")]
	public string GetSearchString(ref BestiaryUICollectionInfo info)
	{
		return null;
	}
}
