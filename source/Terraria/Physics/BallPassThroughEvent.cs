using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Physics
{
	[global::Cpp2ILInjected.Token(Token = "0x200053F")]
	public struct BallPassThroughEvent
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003264")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D050", Offset = "0x132D050", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public BallPassThroughEvent(float timeScale, Tile tile, Entity entity, BallPassThroughType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003B93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly Tile Tile;

		[global::Cpp2ILInjected.Token(Token = "0x4003B94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly Entity Entity;

		[global::Cpp2ILInjected.Token(Token = "0x4003B95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly BallPassThroughType Type;

		[global::Cpp2ILInjected.Token(Token = "0x4003B96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly float TimeScale;
	}
}
