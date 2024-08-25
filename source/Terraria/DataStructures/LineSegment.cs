using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000635")]
	public struct LineSegment
	{
		[global::Cpp2ILInjected.Token(Token = "0x600362C")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCBD4", Offset = "0x13DCBD4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public LineSegment(Vector2 start, Vector2 end)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector2 Start;

		[global::Cpp2ILInjected.Token(Token = "0x40076ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector2 End;
	}
}
