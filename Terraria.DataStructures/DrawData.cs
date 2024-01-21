using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000429")]
public struct DrawData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062CA")]
	public Texture2D texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40062CB")]
	public Vector2 position;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40062CC")]
	public Rectangle sourceRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40062CD")]
	public Color color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40062CE")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40062CF")]
	public Vector2 origin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40062D0")]
	public Vector2 scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40062D1")]
	public SpriteEffects effect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40062D2")]
	public int shader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40062D3")]
	public bool ignorePlayerRotation;

	[Cpp2IlInjected.Token(Token = "0x40062D4")]
	public static Rectangle? nullRectangle;

	[Cpp2IlInjected.Token(Token = "0x60030FE")]
	[Cpp2IlInjected.Address(RVA = "0x39AC4C", Offset = "0x39AC4C", VA = "0x39AC4C")]
	public DrawData(Texture2D texture, Vector2 position, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030FF")]
	[Cpp2IlInjected.Address(RVA = "0x39AC70", Offset = "0x39AC70", VA = "0x39AC70")]
	public DrawData(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003100")]
	[Cpp2IlInjected.Address(RVA = "0x39ACBC", Offset = "0x39ACBC", VA = "0x39ACBC")]
	public DrawData(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003101")]
	[Cpp2IlInjected.Address(RVA = "0x39AD10", Offset = "0x39AD10", VA = "0x39AD10")]
	public DrawData(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003102")]
	[Cpp2IlInjected.Address(RVA = "0x39AD78", Offset = "0x39AD78", VA = "0x39AD78")]
	public DrawData(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003103")]
	[Cpp2IlInjected.Address(RVA = "0x39ADE8", Offset = "0x39ADE8", VA = "0x39ADE8")]
	public void Draw(SpriteBatch sb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003104")]
	[Cpp2IlInjected.Address(RVA = "0x39ADF0", Offset = "0x39ADF0", VA = "0x39ADF0")]
	public void Draw(SpriteBatch sb, Vector2 offset)
	{
	}
}
