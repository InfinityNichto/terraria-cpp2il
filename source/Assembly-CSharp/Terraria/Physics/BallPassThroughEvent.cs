using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Physics
{
	// Token: 0x020003A0 RID: 928
	[global::Cpp2ILInjected.Token(Token = "0x200053F")]
	public struct BallPassThroughEvent
	{
		// Token: 0x06002E05 RID: 11781 RVA: 0x0002A380 File Offset: 0x00028580
		[global::Cpp2ILInjected.Token(Token = "0x6003264")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D050", Offset = "0x132D050", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public BallPassThroughEvent(float timeScale, Tile tile, Entity entity, BallPassThroughType type)
		{
			throw null;
		}

		// Token: 0x040031F4 RID: 12788
		[global::Cpp2ILInjected.Token(Token = "0x4003B93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly Tile Tile;

		// Token: 0x040031F5 RID: 12789
		[global::Cpp2ILInjected.Token(Token = "0x4003B94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly Entity Entity;

		// Token: 0x040031F6 RID: 12790
		[global::Cpp2ILInjected.Token(Token = "0x4003B95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly BallPassThroughType Type;

		// Token: 0x040031F7 RID: 12791
		[global::Cpp2ILInjected.Token(Token = "0x4003B96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly float TimeScale;
	}
}
