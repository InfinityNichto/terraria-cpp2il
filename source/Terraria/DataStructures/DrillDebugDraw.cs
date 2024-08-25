using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000622")]
	public struct DrillDebugDraw
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC3FC", Offset = "0x13DC3FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public DrillDebugDraw(Vector2 p, Color c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector2 point;

		[global::Cpp2ILInjected.Token(Token = "0x40076BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Color color;
	}
}
