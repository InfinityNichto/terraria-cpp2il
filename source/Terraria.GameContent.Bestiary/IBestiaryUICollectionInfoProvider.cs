using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000627")]
public interface IBestiaryUICollectionInfoProvider
{
	[Cpp2IlInjected.Token(Token = "0x6003ED5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BestiaryUICollectionInfo GetEntryUICollectionInfo();
}
