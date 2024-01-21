using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004BF")]
public struct Alignment
{
	[Cpp2IlInjected.Token(Token = "0x4006679")]
	public static readonly Alignment TopLeft;

	[Cpp2IlInjected.Token(Token = "0x400667A")]
	public static readonly Alignment Top;

	[Cpp2IlInjected.Token(Token = "0x400667B")]
	public static readonly Alignment TopRight;

	[Cpp2IlInjected.Token(Token = "0x400667C")]
	public static readonly Alignment Left;

	[Cpp2IlInjected.Token(Token = "0x400667D")]
	public static readonly Alignment Center;

	[Cpp2IlInjected.Token(Token = "0x400667E")]
	public static readonly Alignment Right;

	[Cpp2IlInjected.Token(Token = "0x400667F")]
	public static readonly Alignment BottomLeft;

	[Cpp2IlInjected.Token(Token = "0x4006680")]
	public static readonly Alignment Bottom;

	[Cpp2IlInjected.Token(Token = "0x4006681")]
	public static readonly Alignment BottomRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006682")]
	public readonly float VerticalOffsetMultiplier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006683")]
	public readonly float HorizontalOffsetMultiplier;

	[Cpp2IlInjected.Token(Token = "0x170006C5")]
	public Vector2 OffsetMultiplier
	{
		[Cpp2IlInjected.Token(Token = "0x60035AB")]
		[Cpp2IlInjected.Address(RVA = "0x39F468", Offset = "0x39F468", VA = "0x39F468")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60035AC")]
	[Cpp2IlInjected.Address(RVA = "0x39F490", Offset = "0x39F490", VA = "0x39F490")]
	private Alignment(float horizontal, float vertical)
	{
	}
}
