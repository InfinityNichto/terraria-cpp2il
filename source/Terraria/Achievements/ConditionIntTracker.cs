using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Achievements;

namespace Terraria.Achievements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000699")]
	public class ConditionIntTracker : AchievementTracker<int>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003869")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AE9C", Offset = "0x143AE9C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionsCompletedTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<>), Member = ".ctor", MemberParameters = new object[] { typeof(TrackerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ConditionIntTracker()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600386A")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AEE8", Offset = "0x143AEE8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomIntCondition), Member = "CreateAchievementTracker", ReturnType = typeof(IAchievementTracker))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<>), Member = ".ctor", MemberParameters = new object[] { typeof(TrackerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ConditionIntTracker(int maxValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600386B")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AF48", Offset = "0x143AF48", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void ReportUpdate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600386C")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AFB8", Offset = "0x143AFB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Load()
		{
			throw null;
		}
	}
}
