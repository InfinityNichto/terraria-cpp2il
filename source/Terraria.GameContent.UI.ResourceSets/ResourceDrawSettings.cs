using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.ResourceSets;

[Cpp2IlInjected.Token(Token = "0x20006B3")]
public struct ResourceDrawSettings
{
	[Cpp2IlInjected.Token(Token = "0x2000AAB")]
	public delegate void TextureGetter(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> texture, out Vector2 drawOffset, out float drawScale, out Rectangle? sourceRect);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F6D")]
	public Vector2 TopLeftAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006F6E")]
	public int ElementCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006F6F")]
	public int ElementIndexOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006F70")]
	public TextureGetter GetTextureMethod;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006F71")]
	public Vector2 OffsetPerDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006F72")]
	public Vector2 OffsetPerDrawByTexturePercentile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006F73")]
	public Vector2 OffsetSpriteAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006F74")]
	public Vector2 OffsetSpriteAnchorByTexturePercentile;

	[Cpp2IlInjected.Token(Token = "0x60043B4")]
	[Cpp2IlInjected.Address(RVA = "0x39BD7C", Offset = "0x39BD7C", VA = "0x39BD7C")]
	public void Draw(SpriteBatch spriteBatch, ref bool isHovered)
	{
	}
}
