using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000625")]
public interface IBestiaryInfoElement
{
	[Cpp2IlInjected.Token(Token = "0x6003ED3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	UIElement ProvideUIElement(BestiaryUICollectionInfo info);
}
