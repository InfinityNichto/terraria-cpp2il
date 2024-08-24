using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x0200054C RID: 1356
	[global::Cpp2ILInjected.Token(Token = "0x20007C8")]
	public interface INeedRenderTargetContent
	{
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060039BF RID: 14783
		[global::Cpp2ILInjected.Token(Token = "0x170007BC")]
		bool IsReady
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004095")]
			get;
		}

		// Token: 0x060039C0 RID: 14784
		[global::Cpp2ILInjected.Token(Token = "0x6004096")]
		void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch);

		// Token: 0x060039C1 RID: 14785
		[global::Cpp2ILInjected.Token(Token = "0x6004097")]
		void Reset();
	}
}
