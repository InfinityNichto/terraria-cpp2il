using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200063C RID: 1596
	[global::Cpp2ILInjected.Token(Token = "0x200095F")]
	public interface IFilterInfoProvider
	{
		// Token: 0x06003EEE RID: 16110
		[global::Cpp2ILInjected.Token(Token = "0x6004802")]
		UIElement GetFilterImage();

		// Token: 0x06003EEF RID: 16111
		[global::Cpp2ILInjected.Token(Token = "0x6004803")]
		string GetDisplayNameKey();

		// Token: 0x06003EF0 RID: 16112
		[global::Cpp2ILInjected.Token(Token = "0x6004804")]
		void GetDisplay(out Texture2D texture, out Rectangle frame);
	}
}
