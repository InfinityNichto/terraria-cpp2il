using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Physics
{
	// Token: 0x0200039F RID: 927
	[global::Cpp2ILInjected.Token(Token = "0x200053E")]
	public struct BallCollisionEvent
	{
		// Token: 0x06002E04 RID: 11780 RVA: 0x0002A37D File Offset: 0x0002857D
		[global::Cpp2ILInjected.Token(Token = "0x6003263")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D488", Offset = "0x132D488", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public BallCollisionEvent(float timeScale, Vector2 normal, Vector2 impactPoint, Tile tile, Entity entity)
		{
			throw null;
		}

		// Token: 0x040031EF RID: 12783
		[global::Cpp2ILInjected.Token(Token = "0x4003B8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly Vector2 Normal;

		// Token: 0x040031F0 RID: 12784
		[global::Cpp2ILInjected.Token(Token = "0x4003B8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly Vector2 ImpactPoint;

		// Token: 0x040031F1 RID: 12785
		[global::Cpp2ILInjected.Token(Token = "0x4003B90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Tile Tile;

		// Token: 0x040031F2 RID: 12786
		[global::Cpp2ILInjected.Token(Token = "0x4003B91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly Entity Entity;

		// Token: 0x040031F3 RID: 12787
		[global::Cpp2ILInjected.Token(Token = "0x4003B92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly float TimeScale;
	}
}
