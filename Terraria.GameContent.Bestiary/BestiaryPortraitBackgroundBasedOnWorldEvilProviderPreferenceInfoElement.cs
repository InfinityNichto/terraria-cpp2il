using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200063A")]
public class BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement : IPreferenceProviderElement, IBestiaryInfoElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C76")]
	private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCorrupt;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C77")]
	private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCrimson;

	[Cpp2IlInjected.Token(Token = "0x6003F10")]
	[Cpp2IlInjected.Address(RVA = "0x10F89FC", Offset = "0x10F89FC", VA = "0x10F89FC")]
	public BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement(IBestiaryBackgroundImagePathAndColorProvider preferredProviderCorrupt, IBestiaryBackgroundImagePathAndColorProvider preferredProviderCrimson)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F11")]
	[Cpp2IlInjected.Address(RVA = "0x10F8A24", Offset = "0x10F8A24", VA = "0x10F8A24", Slot = "6")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F12")]
	[Cpp2IlInjected.Address(RVA = "0x10F8A2C", Offset = "0x10F8A2C", VA = "0x10F8A2C", Slot = "5")]
	public bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003F13")]
	[Cpp2IlInjected.Address(RVA = "0x10F8B10", Offset = "0x10F8B10", VA = "0x10F8B10", Slot = "4")]
	public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
	{
		return null;
	}
}
