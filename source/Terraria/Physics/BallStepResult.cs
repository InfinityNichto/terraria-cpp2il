using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Physics
{
	// Token: 0x020003A3 RID: 931
	[global::Cpp2ILInjected.Token(Token = "0x2000542")]
	public struct BallStepResult
	{
		// Token: 0x06002E06 RID: 11782 RVA: 0x0002A383 File Offset: 0x00028583
		[global::Cpp2ILInjected.Token(Token = "0x6003265")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E33C", Offset = "0x132E33C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private BallStepResult(BallState state)
		{
			throw null;
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x0002A386 File Offset: 0x00028586
		[global::Cpp2ILInjected.Token(Token = "0x6003266")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D15C", Offset = "0x132D15C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BallStepResult OutOfBounds()
		{
			throw null;
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x0002A389 File Offset: 0x00028589
		[global::Cpp2ILInjected.Token(Token = "0x6003267")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D4A0", Offset = "0x132D4A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BallStepResult Moving()
		{
			throw null;
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x0002A38C File Offset: 0x0002858C
		[global::Cpp2ILInjected.Token(Token = "0x6003268")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D4A8", Offset = "0x132D4A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BallStepResult Resting()
		{
			throw null;
		}

		// Token: 0x04003202 RID: 12802
		[global::Cpp2ILInjected.Token(Token = "0x4003BA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly BallState State;
	}
}
