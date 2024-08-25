using System;
using Cpp2ILInjected;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A35")]
	public interface IProvideSliderElement : IPowerSubcategoryElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004CA8")]
		UIElement ProvideSlider();
	}
}
