using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[Cpp2IlInjected.Token(Token = "0x20004E4")]
public struct VertexColors
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006726")]
	public Color TopLeftColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006727")]
	public Color TopRightColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006728")]
	public Color BottomLeftColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006729")]
	public Color BottomRightColor;

	[Cpp2IlInjected.Token(Token = "0x60036EB")]
	[Cpp2IlInjected.Address(RVA = "0x39DF7C", Offset = "0x39DF7C", VA = "0x39DF7C")]
	public VertexColors(Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036EC")]
	[Cpp2IlInjected.Address(RVA = "0x39DF8C", Offset = "0x39DF8C", VA = "0x39DF8C")]
	public VertexColors(Color topLeft, Color topRight, Color bottomRight, Color bottomLeft)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036ED")]
	[Cpp2IlInjected.Address(RVA = "0x124DF70", Offset = "0x124DF70", VA = "0x124DF70")]
	public static implicit operator VertexColors(Color color)
	{
		return default(VertexColors);
	}
}
