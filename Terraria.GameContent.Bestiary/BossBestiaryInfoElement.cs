using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000635")]
public class BossBestiaryInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
{
	[Cpp2IlInjected.Token(Token = "0x6003EF9")]
	[Cpp2IlInjected.Address(RVA = "0x10FA024", Offset = "0x10FA024", VA = "0x10FA024", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003EFA")]
	[Cpp2IlInjected.Address(RVA = "0x10FA02C", Offset = "0x10FA02C", VA = "0x10FA02C", Slot = "5")]
	public string GetSearchString(ref BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003EFB")]
	[Cpp2IlInjected.Address(RVA = "0x10F7EC8", Offset = "0x10F7EC8", VA = "0x10F7EC8")]
	public BossBestiaryInfoElement()
	{
	}
}
