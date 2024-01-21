using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x2000506")]
public class NPCHeadRenderer : INeedRenderTargetContent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40067E4")]
	private NPCHeadDrawRenderTargetContent[] _contents;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40067E5")]
	private Asset<Texture2D>[] _matchingArray;

	[Cpp2IlInjected.Token(Token = "0x170006F5")]
	public bool IsReady
	{
		[Cpp2IlInjected.Token(Token = "0x60037D5")]
		[Cpp2IlInjected.Address(RVA = "0x12445B0", Offset = "0x12445B0", VA = "0x12445B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60037D2")]
	[Cpp2IlInjected.Address(RVA = "0x12442D4", Offset = "0x12442D4", VA = "0x12442D4")]
	public NPCHeadRenderer(Asset<Texture2D>[] matchingArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037D3")]
	[Cpp2IlInjected.Address(RVA = "0x12442FC", Offset = "0x12442FC", VA = "0x12442FC", Slot = "6")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037D4")]
	[Cpp2IlInjected.Address(RVA = "0x1244360", Offset = "0x1244360", VA = "0x1244360")]
	public void DrawWithOutlines(Entity entity, int headId, Vector2 position, Color color, float rotation, float scale, SpriteEffects effects)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037D6")]
	[Cpp2IlInjected.Address(RVA = "0x12445B8", Offset = "0x12445B8", VA = "0x12445B8", Slot = "5")]
	public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
	{
	}
}
