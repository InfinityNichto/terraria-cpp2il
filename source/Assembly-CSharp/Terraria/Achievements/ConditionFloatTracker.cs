using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Achievements;

namespace Terraria.Achievements
{
	// Token: 0x02000491 RID: 1169
	[global::Cpp2ILInjected.Token(Token = "0x2000698")]
	public class ConditionFloatTracker : AchievementTracker<float>
	{
		// Token: 0x0600332F RID: 13103 RVA: 0x0002B271 File Offset: 0x00029471
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

		// Token: 0x06003330 RID: 13104 RVA: 0x0002B274 File Offset: 0x00029474
		[global::Cpp2ILInjected.Token(Token = "0x6003866")]
		[global::Cpp2ILInjected.Address(RVA = "0x143ADDC", Offset = "0x143ADDC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<float>), Member = ".ctor", MemberParameters = new object[] { typeof(TrackerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ConditionFloatTracker()
		{
			throw null;
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x0002B277 File Offset: 0x00029477
		[global::Cpp2ILInjected.Token(Token = "0x6003867")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AE28", Offset = "0x143AE28", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void ReportUpdate()
		{
			throw null;
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x0002B27A File Offset: 0x0002947A
		[global::Cpp2ILInjected.Token(Token = "0x6003868")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AE98", Offset = "0x143AE98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Load()
		{
			throw null;
		}
	}
}
