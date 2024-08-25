using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Achievements;

namespace Terraria.Achievements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000698")]
	public class ConditionFloatTracker : AchievementTracker<float>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003865")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AD7C", Offset = "0x143AD7C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomFloatCondition), Member = "CreateAchievementTracker", ReturnType = typeof(IAchievementTracker))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<float>), Member = ".ctor", MemberParameters = new object[] { typeof(TrackerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ConditionFloatTracker(float maxValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003866")]
		[global::Cpp2ILInjected.Address(RVA = "0x143ADDC", Offset = "0x143ADDC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<float>), Member = ".ctor", MemberParameters = new object[] { typeof(TrackerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ConditionFloatTracker()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003867")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AE28", Offset = "0x143AE28", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void ReportUpdate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003868")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AE98", Offset = "0x143AE98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Load()
		{
			throw null;
		}
	}
}
