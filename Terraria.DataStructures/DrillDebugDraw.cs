using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200042A")]
public struct DrillDebugDraw
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062D5")]
	public Vector2 point;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062D6")]
	public Color color;

	[Cpp2IlInjected.Token(Token = "0x6003106")]
	[Cpp2IlInjected.Address(RVA = "0x39AE0C", Offset = "0x39AE0C", VA = "0x39AE0C")]
	public DrillDebugDraw(Vector2 p, Color c)
	{
	}
}
