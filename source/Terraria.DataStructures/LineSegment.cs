using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200043D")]
public struct LineSegment
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006303")]
	public Vector2 Start;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006304")]
	public Vector2 End;

	[Cpp2IlInjected.Token(Token = "0x600314B")]
	[Cpp2IlInjected.Address(RVA = "0x39B0C0", Offset = "0x39B0C0", VA = "0x39B0C0")]
	public LineSegment(Vector2 start, Vector2 end)
	{
	}
}
