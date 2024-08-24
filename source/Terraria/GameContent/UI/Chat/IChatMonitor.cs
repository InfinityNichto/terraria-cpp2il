using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x020006EF RID: 1775
	[global::Cpp2ILInjected.Token(Token = "0x2000ADB")]
	public interface IChatMonitor
	{
		// Token: 0x06004542 RID: 17730
		[global::Cpp2ILInjected.Token(Token = "0x60051AE")]
		void NewText(string newText, byte R = 255, byte G = 255, byte B = 255);

		// Token: 0x06004543 RID: 17731
		[global::Cpp2ILInjected.Token(Token = "0x60051AF")]
		void NewTextMultiline(string text, bool force = false, Color c = default(Color), int WidthLimit = -1);

		// Token: 0x06004544 RID: 17732
		[global::Cpp2ILInjected.Token(Token = "0x60051B0")]
		void DrawChat(bool drawingPlayerChat);

		// Token: 0x06004545 RID: 17733
		[global::Cpp2ILInjected.Token(Token = "0x60051B1")]
		void Clear();

		// Token: 0x06004546 RID: 17734
		[global::Cpp2ILInjected.Token(Token = "0x60051B2")]
		void Update();

		// Token: 0x06004547 RID: 17735
		[global::Cpp2ILInjected.Token(Token = "0x60051B3")]
		void Offset(int linesOffset);

		// Token: 0x06004548 RID: 17736
		[global::Cpp2ILInjected.Token(Token = "0x60051B4")]
		void ResetOffset();

		// Token: 0x06004549 RID: 17737
		[global::Cpp2ILInjected.Token(Token = "0x60051B5")]
		void OnResolutionChange();
	}
}
