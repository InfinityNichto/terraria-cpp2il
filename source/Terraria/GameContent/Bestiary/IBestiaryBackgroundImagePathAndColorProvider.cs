using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000628 RID: 1576
	[global::Cpp2ILInjected.Token(Token = "0x200094B")]
	public interface IBestiaryBackgroundImagePathAndColorProvider
	{
		// Token: 0x06003E9A RID: 16026
		[global::Cpp2ILInjected.Token(Token = "0x60047AE")]
		Asset<Texture2D> GetBackgroundImage();

		// Token: 0x06003E9B RID: 16027
		[global::Cpp2ILInjected.Token(Token = "0x60047AF")]
		Color? GetBackgroundColor();
	}
}
