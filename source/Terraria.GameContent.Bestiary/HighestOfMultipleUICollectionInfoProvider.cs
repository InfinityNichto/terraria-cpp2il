using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000631")]
public class HighestOfMultipleUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C68")]
	private IBestiaryUICollectionInfoProvider[] _providers;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C69")]
	private int _mainProviderIndex;

	[Cpp2IlInjected.Token(Token = "0x6003EE8")]
	[Cpp2IlInjected.Address(RVA = "0x10FD34C", Offset = "0x10FD34C", VA = "0x10FD34C")]
	public HighestOfMultipleUICollectionInfoProvider(params IBestiaryUICollectionInfoProvider[] providers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EE9")]
	[Cpp2IlInjected.Address(RVA = "0x10FD374", Offset = "0x10FD374", VA = "0x10FD374", Slot = "4")]
	public BestiaryUICollectionInfo GetEntryUICollectionInfo()
	{
		return default(BestiaryUICollectionInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EEA")]
	[Cpp2IlInjected.Address(RVA = "0x10FD520", Offset = "0x10FD520", VA = "0x10FD520")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}
}
