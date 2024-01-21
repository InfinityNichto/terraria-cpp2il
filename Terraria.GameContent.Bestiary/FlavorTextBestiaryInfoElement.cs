using Cpp2IlInjected;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000642")]
public class FlavorTextBestiaryInfoElement : IBestiaryInfoElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C84")]
	public string _key;

	[Cpp2IlInjected.Token(Token = "0x6003F35")]
	[Cpp2IlInjected.Address(RVA = "0x10F7F04", Offset = "0x10F7F04", VA = "0x10F7F04")]
	public FlavorTextBestiaryInfoElement(string languageKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F36")]
	[Cpp2IlInjected.Address(RVA = "0x10FCB58", Offset = "0x10FCB58", VA = "0x10FCB58", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F37")]
	[Cpp2IlInjected.Address(RVA = "0x10FCEB8", Offset = "0x10FCEB8", VA = "0x10FCEB8")]
	private static void AddDynamicResize(UIElement container, UIText text)
	{
	}
}
