using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000639")]
public class BestiaryPortraitBackgroundProviderPreferenceInfoElement : IPreferenceProviderElement, IBestiaryInfoElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C75")]
	private IBestiaryBackgroundImagePathAndColorProvider _preferredProvider;

	[Cpp2IlInjected.Token(Token = "0x6003F0C")]
	[Cpp2IlInjected.Address(RVA = "0x10F8BE4", Offset = "0x10F8BE4", VA = "0x10F8BE4")]
	public BestiaryPortraitBackgroundProviderPreferenceInfoElement(IBestiaryBackgroundImagePathAndColorProvider preferredProvider)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F0D")]
	[Cpp2IlInjected.Address(RVA = "0x10F8C04", Offset = "0x10F8C04", VA = "0x10F8C04", Slot = "6")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F0E")]
	[Cpp2IlInjected.Address(RVA = "0x10F8C0C", Offset = "0x10F8C0C", VA = "0x10F8C0C", Slot = "5")]
	public bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003F0F")]
	[Cpp2IlInjected.Address(RVA = "0x10F8C20", Offset = "0x10F8C20", VA = "0x10F8C20", Slot = "4")]
	public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
	{
		return null;
	}
}
