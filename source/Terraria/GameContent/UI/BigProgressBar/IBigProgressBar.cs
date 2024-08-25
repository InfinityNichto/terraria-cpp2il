using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AE6")]
	internal interface IBigProgressBar
	{
		[global::Cpp2ILInjected.Token(Token = "0x60051F7")]
		bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info);

		[global::Cpp2ILInjected.Token(Token = "0x60051F8")]
		void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch);
	}
}
