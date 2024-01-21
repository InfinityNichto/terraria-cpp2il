using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200064A")]
public class SearchAliasInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C95")]
	private readonly string _alias;

	[Cpp2IlInjected.Token(Token = "0x6003F59")]
	[Cpp2IlInjected.Address(RVA = "0x1102F54", Offset = "0x1102F54", VA = "0x1102F54")]
	public SearchAliasInfoElement(string alias)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F5A")]
	[Cpp2IlInjected.Address(RVA = "0x1102F74", Offset = "0x1102F74", VA = "0x1102F74", Slot = "5")]
	public string GetSearchString(ref BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F5B")]
	[Cpp2IlInjected.Address(RVA = "0x1102F88", Offset = "0x1102F88", VA = "0x1102F88", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}
}
