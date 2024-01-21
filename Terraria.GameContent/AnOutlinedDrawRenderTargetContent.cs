using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000551")]
public abstract class AnOutlinedDrawRenderTargetContent : ARenderTargetContentByRequest
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40068F0")]
	protected int width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40068F1")]
	protected int height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40068F2")]
	public Color _borderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40068F3")]
	private EffectPass _coloringShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40068F4")]
	private RenderTarget2D _helperTarget;

	[Cpp2IlInjected.Token(Token = "0x6003A09")]
	[Cpp2IlInjected.Address(RVA = "0xFB1364", Offset = "0xFB1364", VA = "0xFB1364")]
	public void UseColor(Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A0A")]
	[Cpp2IlInjected.Address(RVA = "0xFB136C", Offset = "0xFB136C", VA = "0xFB136C", Slot = "7")]
	protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A0B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	internal abstract void DrawTheContent(SpriteBatch spriteBatch);

	[Cpp2IlInjected.Token(Token = "0x6003A0C")]
	[Cpp2IlInjected.Address(RVA = "0xFB1370", Offset = "0xFB1370", VA = "0xFB1370")]
	protected AnOutlinedDrawRenderTargetContent()
	{
	}
}
