using Cpp2IlInjected;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000643")]
public class UnlockProgressDisplayBestiaryInfoElement : IBestiaryInfoElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C85")]
	private BestiaryUnlockProgressReport _progressReport;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C86")]
	private UIElement _text1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006C87")]
	private UIElement _text2;

	[Cpp2IlInjected.Token(Token = "0x6003F38")]
	[Cpp2IlInjected.Address(RVA = "0x1104F18", Offset = "0x1104F18", VA = "0x1104F18")]
	public UnlockProgressDisplayBestiaryInfoElement(BestiaryUnlockProgressReport progressReport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F39")]
	[Cpp2IlInjected.Address(RVA = "0x1104F40", Offset = "0x1104F40", VA = "0x1104F40", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F3A")]
	[Cpp2IlInjected.Address(RVA = "0x1105410", Offset = "0x1105410", VA = "0x1105410")]
	private void AddDynamicResize(UIElement container, UIText text)
	{
	}
}
