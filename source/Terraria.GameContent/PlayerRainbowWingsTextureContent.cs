using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000554")]
public class PlayerRainbowWingsTextureContent : ARenderTargetContentByRequest
{
	[Cpp2IlInjected.Token(Token = "0x6003A13")]
	[Cpp2IlInjected.Address(RVA = "0x11990A0", Offset = "0x11990A0", VA = "0x11990A0", Slot = "7")]
	protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A14")]
	[Cpp2IlInjected.Address(RVA = "0x11990A4", Offset = "0x11990A4", VA = "0x11990A4")]
	public PlayerRainbowWingsTextureContent()
	{
	}
}
