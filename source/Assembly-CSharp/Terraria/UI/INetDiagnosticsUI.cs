using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x020004C9 RID: 1225
	[global::Cpp2ILInjected.Token(Token = "0x2000715")]
	public interface INetDiagnosticsUI
	{
		// Token: 0x060035C5 RID: 13765
		[global::Cpp2ILInjected.Token(Token = "0x6003C02")]
		void Reset();

		// Token: 0x060035C6 RID: 13766
		[global::Cpp2ILInjected.Token(Token = "0x6003C03")]
		void Draw(SpriteBatch spriteBatch);

		// Token: 0x060035C7 RID: 13767
		[global::Cpp2ILInjected.Token(Token = "0x6003C04")]
		void CountReadMessage(int messageId, int messageLength);

		// Token: 0x060035C8 RID: 13768
		[global::Cpp2ILInjected.Token(Token = "0x6003C05")]
		void CountSentMessage(int messageId, int messageLength);

		// Token: 0x060035C9 RID: 13769
		[global::Cpp2ILInjected.Token(Token = "0x6003C06")]
		void CountReadModuleMessage(int moduleMessageId, int messageLength);

		// Token: 0x060035CA RID: 13770
		[global::Cpp2ILInjected.Token(Token = "0x6003C07")]
		void CountSentModuleMessage(int moduleMessageId, int messageLength);
	}
}
