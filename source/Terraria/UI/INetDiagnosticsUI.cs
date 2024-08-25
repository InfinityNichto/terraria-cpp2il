using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000715")]
	public interface INetDiagnosticsUI
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003C02")]
		void Reset();

		[global::Cpp2ILInjected.Token(Token = "0x6003C03")]
		void Draw(SpriteBatch spriteBatch);

		[global::Cpp2ILInjected.Token(Token = "0x6003C04")]
		void CountReadMessage(int messageId, int messageLength);

		[global::Cpp2ILInjected.Token(Token = "0x6003C05")]
		void CountSentMessage(int messageId, int messageLength);

		[global::Cpp2ILInjected.Token(Token = "0x6003C06")]
		void CountReadModuleMessage(int moduleMessageId, int messageLength);

		[global::Cpp2ILInjected.Token(Token = "0x6003C07")]
		void CountSentModuleMessage(int moduleMessageId, int messageLength);
	}
}
