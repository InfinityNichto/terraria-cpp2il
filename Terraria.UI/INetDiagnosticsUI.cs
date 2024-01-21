using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004CC")]
public interface INetDiagnosticsUI
{
	[Cpp2IlInjected.Token(Token = "0x6003601")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6003602")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Draw(SpriteBatch spriteBatch);

	[Cpp2IlInjected.Token(Token = "0x6003603")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CountReadMessage(int messageId, int messageLength);

	[Cpp2IlInjected.Token(Token = "0x6003604")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CountSentMessage(int messageId, int messageLength);

	[Cpp2IlInjected.Token(Token = "0x6003605")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CountReadModuleMessage(int moduleMessageId, int messageLength);

	[Cpp2IlInjected.Token(Token = "0x6003606")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CountSentModuleMessage(int moduleMessageId, int messageLength);
}
