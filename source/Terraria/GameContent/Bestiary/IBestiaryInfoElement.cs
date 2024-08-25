using System;
using Cpp2ILInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000945")]
	public interface IBestiaryInfoElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047AB")]
		UIElement ProvideUIElement(BestiaryUICollectionInfo info);
	}
}
