using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Chat
{
	[global::Cpp2ILInjected.Token(Token = "0x2000ADB")]
	public interface IChatMonitor
	{
		[global::Cpp2ILInjected.Token(Token = "0x60051AE")]
		void NewText(string newText, byte R = 255, byte G = 255, byte B = 255);

		[global::Cpp2ILInjected.Token(Token = "0x60051AF")]
		void NewTextMultiline(string text, bool force = false, Color c = default(Color), int WidthLimit = -1);

		[global::Cpp2ILInjected.Token(Token = "0x60051B0")]
		void DrawChat(bool drawingPlayerChat);

		[global::Cpp2ILInjected.Token(Token = "0x60051B1")]
		void Clear();

		[global::Cpp2ILInjected.Token(Token = "0x60051B2")]
		void Update();

		[global::Cpp2ILInjected.Token(Token = "0x60051B3")]
		void Offset(int linesOffset);

		[global::Cpp2ILInjected.Token(Token = "0x60051B4")]
		void ResetOffset();

		[global::Cpp2ILInjected.Token(Token = "0x60051B5")]
		void OnResolutionChange();
	}
}
