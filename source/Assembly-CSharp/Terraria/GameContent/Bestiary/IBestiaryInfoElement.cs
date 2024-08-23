using System;
using Cpp2ILInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000622 RID: 1570
	[global::Cpp2ILInjected.Token(Token = "0x2000945")]
	public interface IBestiaryInfoElement
	{
		// Token: 0x06003E97 RID: 16023
		[global::Cpp2ILInjected.Token(Token = "0x60047AB")]
		UIElement ProvideUIElement(BestiaryUICollectionInfo info);
	}
}
