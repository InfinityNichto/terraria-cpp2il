using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Achievements
{
	// Token: 0x02000493 RID: 1171
	[global::Cpp2ILInjected.Token(Token = "0x200069A")]
	public class ConditionsCompletedTracker : ConditionIntTracker
	{
		// Token: 0x06003337 RID: 13111 RVA: 0x0002B289 File Offset: 0x00029489
		[global::Cpp2ILInjected.Token(Token = "0x600386D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438B1C", Offset = "0x1438B1C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "UseConditionsCompletedTracker", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "UseConditionsCompletedTracker", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition.AchievementUpdate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = "add_OnComplete", MemberParameters = new object[] { typeof(AchievementCondition.AchievementUpdate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddCondition(AchievementCondition condition)
		{
			throw null;
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0002B28C File Offset: 0x0002948C
		[global::Cpp2ILInjected.Token(Token = "0x600386E")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AFBC", Offset = "0x143AFBC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<>), Member = "SetValue", MemberParameters = new object[]
		{
			"T",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnConditionCompleted(AchievementCondition condition)
		{
			throw null;
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x0002B28F File Offset: 0x0002948F
		[global::Cpp2ILInjected.Token(Token = "0x600386F")]
		[global::Cpp2ILInjected.Address(RVA = "0x143B04C", Offset = "0x143B04C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void Load()
		{
			throw null;
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x0002B292 File Offset: 0x00029492
		[global::Cpp2ILInjected.Token(Token = "0x6003870")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438AA4", Offset = "0x1438AA4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "UseConditionsCompletedTracker", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "UseConditionsCompletedTracker", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionIntTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ConditionsCompletedTracker()
		{
			throw null;
		}

		// Token: 0x04006536 RID: 25910
		[global::Cpp2ILInjected.Token(Token = "0x4007933")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<AchievementCondition> _conditions;
	}
}
