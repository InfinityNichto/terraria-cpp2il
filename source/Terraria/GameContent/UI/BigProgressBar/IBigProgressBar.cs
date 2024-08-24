using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x020006F8 RID: 1784
	[global::Cpp2ILInjected.Token(Token = "0x2000AE6")]
	internal interface IBigProgressBar
	{
		// Token: 0x06004584 RID: 17796
		[global::Cpp2ILInjected.Token(Token = "0x60051F7")]
		bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info);

		// Token: 0x06004585 RID: 17797
		[global::Cpp2ILInjected.Token(Token = "0x60051F8")]
		void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch);
	}
}
