using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Physics
{
	[global::Cpp2ILInjected.Token(Token = "0x200053E")]
	public struct BallCollisionEvent
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003263")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D488", Offset = "0x132D488", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public BallCollisionEvent(float timeScale, Vector2 normal, Vector2 impactPoint, Tile tile, Entity entity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003B8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly Vector2 Normal;

		[global::Cpp2ILInjected.Token(Token = "0x4003B8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly Vector2 ImpactPoint;

		[global::Cpp2ILInjected.Token(Token = "0x4003B90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Tile Tile;

		[global::Cpp2ILInjected.Token(Token = "0x4003B91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly Entity Entity;

		[global::Cpp2ILInjected.Token(Token = "0x4003B92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly float TimeScale;
	}
}
