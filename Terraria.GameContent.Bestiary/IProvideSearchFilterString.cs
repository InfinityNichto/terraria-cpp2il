using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000645")]
public interface IProvideSearchFilterString
{
	[Cpp2IlInjected.Token(Token = "0x6003F3F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GetSearchString(ref BestiaryUICollectionInfo info);
}
