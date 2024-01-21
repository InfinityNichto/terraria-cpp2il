using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x20006FB")]
internal interface IBigProgressBar
{
	[Cpp2IlInjected.Token(Token = "0x60045C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info);

	[Cpp2IlInjected.Token(Token = "0x60045C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch);
}
