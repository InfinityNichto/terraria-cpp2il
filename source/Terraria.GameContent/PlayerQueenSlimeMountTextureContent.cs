using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000555")]
public class PlayerQueenSlimeMountTextureContent : ARenderTargetContentByRequest
{
	[Cpp2IlInjected.Token(Token = "0x6003A15")]
	[Cpp2IlInjected.Address(RVA = "0x1199094", Offset = "0x1199094", VA = "0x1199094", Slot = "7")]
	protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A16")]
	[Cpp2IlInjected.Address(RVA = "0x1199098", Offset = "0x1199098", VA = "0x1199098")]
	public PlayerQueenSlimeMountTextureContent()
	{
	}
}
