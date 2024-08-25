using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Physics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000542")]
	public struct BallStepResult
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003265")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E33C", Offset = "0x132E33C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private BallStepResult(BallState state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003266")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D15C", Offset = "0x132D15C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BallStepResult OutOfBounds()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003267")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D4A0", Offset = "0x132D4A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BallStepResult Moving()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003268")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D4A8", Offset = "0x132D4A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BallStepResult Resting()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003BA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly BallState State;
	}
}
