using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x200068E")]
public interface IProvideSliderElement : IPowerSubcategoryElement
{
	[Cpp2IlInjected.Token(Token = "0x60041F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	UIElement ProvideSlider();
}
