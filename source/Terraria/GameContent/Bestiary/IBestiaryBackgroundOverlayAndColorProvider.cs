using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200062A RID: 1578
	[global::Cpp2ILInjected.Token(Token = "0x200094D")]
	public interface IBestiaryBackgroundOverlayAndColorProvider
	{
		// Token: 0x06003E9D RID: 16029
		[global::Cpp2ILInjected.Token(Token = "0x60047B1")]
		Asset<Texture2D> GetBackgroundOverlayImage();

		// Token: 0x06003E9E RID: 16030
		[global::Cpp2ILInjected.Token(Token = "0x60047B2")]
		Color? GetBackgroundOverlayColor();

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06003E9F RID: 16031
		[global::Cpp2ILInjected.Token(Token = "0x17000823")]
		float DisplayPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60047B3")]
			get;
		}
	}
}
