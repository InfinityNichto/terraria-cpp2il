using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[Cpp2IlInjected.Token(Token = "0x20004E3")]
public class TileBatch : SpriteBatch
{
	[Cpp2IlInjected.Token(Token = "0x60036E6")]
	[Cpp2IlInjected.Address(RVA = "0x124D978", Offset = "0x124D978", VA = "0x124D978")]
	public TileBatch(GraphicsDevice graphicsDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036E7")]
	[Cpp2IlInjected.Address(RVA = "0x124D9FC", Offset = "0x124D9FC", VA = "0x124D9FC")]
	public void Draw(Texture2D texture, Vector4 destination, VertexColors colors)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036E8")]
	[Cpp2IlInjected.Address(RVA = "0x124DBC8", Offset = "0x124DBC8", VA = "0x124DBC8")]
	public void Draw(Texture2D texture, Vector4 destination, Rectangle? sourceRectangle, VertexColors colors)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036E9")]
	[Cpp2IlInjected.Address(RVA = "0x124DD8C", Offset = "0x124DD8C", VA = "0x124DD8C")]
	public void Draw(Texture2D texture, Vector4 destination, Rectangle? sourceRectangle, VertexColors colors, Vector2 origin, SpriteEffects effects, float rotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036EA")]
	[Cpp2IlInjected.Address(RVA = "0x124DE9C", Offset = "0x124DE9C", VA = "0x124DE9C")]
	public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors colors, Vector2 origin, float scale, SpriteEffects effects)
	{
	}
}
