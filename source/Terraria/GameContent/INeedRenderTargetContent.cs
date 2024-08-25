using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007C8")]
	public interface INeedRenderTargetContent
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007BC")]
		bool IsReady
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004095")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004096")]
		void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch);

		[global::Cpp2ILInjected.Token(Token = "0x6004097")]
		void Reset();
	}
}
