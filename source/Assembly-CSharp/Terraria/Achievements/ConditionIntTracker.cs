using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Achievements;

namespace Terraria.Achievements
{
	// Token: 0x02000492 RID: 1170
	[global::Cpp2ILInjected.Token(Token = "0x2000699")]
	public class ConditionIntTracker : AchievementTracker<int>
	{
		// Token: 0x06003333 RID: 13107 RVA: 0x0002B27D File Offset: 0x0002947D
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

		// Token: 0x06003334 RID: 13108 RVA: 0x0002B280 File Offset: 0x00029480
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

		// Token: 0x06003335 RID: 13109 RVA: 0x0002B283 File Offset: 0x00029483
		[global::Cpp2ILInjected.Token(Token = "0x600386B")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AF48", Offset = "0x143AF48", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void ReportUpdate()
		{
			throw null;
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x0002B286 File Offset: 0x00029486
		[global::Cpp2ILInjected.Token(Token = "0x600386C")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AFB8", Offset = "0x143AFB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Load()
		{
			throw null;
		}
	}
}
