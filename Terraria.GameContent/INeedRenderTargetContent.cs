using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200054F")]
public interface INeedRenderTargetContent
{
	[Cpp2IlInjected.Token(Token = "0x1700071E")]
	bool IsReady
	{
		[Cpp2IlInjected.Token(Token = "0x60039FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60039FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch);

	[Cpp2IlInjected.Token(Token = "0x60039FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void Reset();
}
