using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004C0")]
public struct CalculatedStyle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006684")]
	public float X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006685")]
	public float Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006686")]
	public float Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006687")]
	public float Height;

	[Cpp2IlInjected.Token(Token = "0x60035AE")]
	[Cpp2IlInjected.Address(RVA = "0x39F49C", Offset = "0x39F49C", VA = "0x39F49C")]
	public CalculatedStyle(float x, float y, float width, float height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035AF")]
	[Cpp2IlInjected.Address(RVA = "0x39F4B0", Offset = "0x39F4B0", VA = "0x39F4B0")]
	public Rectangle ToRectangle()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60035B0")]
	[Cpp2IlInjected.Address(RVA = "0x39F508", Offset = "0x39F508", VA = "0x39F508")]
	public Vector2 Position()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60035B1")]
	[Cpp2IlInjected.Address(RVA = "0x39F534", Offset = "0x39F534", VA = "0x39F534")]
	public Vector2 Center()
	{
		return default(Vector2);
	}
}
