using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000638")]
public interface IPreferenceProviderElement : IBestiaryInfoElement
{
	[Cpp2IlInjected.Token(Token = "0x6003F0A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider();

	[Cpp2IlInjected.Token(Token = "0x6003F0B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider);
}
