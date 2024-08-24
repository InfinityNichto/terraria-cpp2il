using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using Terraria.GameContent.Achievements;

namespace Terraria.Achievements
{
	// Token: 0x02000490 RID: 1168
	[global::Cpp2ILInjected.Token(Token = "0x2000697")]
	public abstract class AchievementTracker<T> : IAchievementTracker
	{
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x0002B256 File Offset: 0x00029456
		[global::Cpp2ILInjected.Token(Token = "0x170006CD")]
		public T Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600385A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C0D30", Offset = "0x15C0D30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06003325 RID: 13093 RVA: 0x0002B259 File Offset: 0x00029459
		[global::Cpp2ILInjected.Token(Token = "0x170006CE")]
		public T MaxValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600385B")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C0D38", Offset = "0x15C0D38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x0002B25C File Offset: 0x0002945C
		[global::Cpp2ILInjected.Token(Token = "0x600385C")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0D40", Offset = "0x15C0D40", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionIntTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionIntTracker), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AchievementTracker(TrackerType type)
		{
			throw null;
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x0002B25F File Offset: 0x0002945F
		[global::Cpp2ILInjected.Token(Token = "0x600385D")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0D68", Offset = "0x15C0D68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Terraria.Achievements.IAchievementTracker.ReportAs(string name)
		{
			throw null;
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x0002B262 File Offset: 0x00029462
		[global::Cpp2ILInjected.Token(Token = "0x600385E")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0D70", Offset = "0x15C0D70", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private TrackerType Terraria.Achievements.IAchievementTracker.GetTrackerType()
		{
			throw null;
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x0002B265 File Offset: 0x00029465
		[global::Cpp2ILInjected.Token(Token = "0x600385F")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0D78", Offset = "0x15C0D78", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Terraria.Achievements.IAchievementTracker.Clear()
		{
			throw null;
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x0002B268 File Offset: 0x00029468
		[global::Cpp2ILInjected.Token(Token = "0x6003860")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0D94", Offset = "0x15C0D94", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionsCompletedTracker), Member = "OnConditionCompleted", MemberParameters = new object[] { typeof(AchievementCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomIntCondition), Member = "set_Value", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomIntCondition), Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomIntCondition), Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void SetValue(T newValue, bool reportUpdate = true)
		{
			throw null;
		}

		// Token: 0x0600332B RID: 13099
		[global::Cpp2ILInjected.Token(Token = "0x6003861")]
		public abstract void ReportUpdate();

		// Token: 0x0600332C RID: 13100
		[global::Cpp2ILInjected.Token(Token = "0x6003862")]
		protected abstract void Load();

		// Token: 0x0600332D RID: 13101 RVA: 0x0002B26B File Offset: 0x0002946B
		[global::Cpp2ILInjected.Token(Token = "0x6003863")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0E88", Offset = "0x15C0E88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Terraria.Achievements.IAchievementTracker.Load()
		{
			throw null;
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x0002B26E File Offset: 0x0002946E
		[global::Cpp2ILInjected.Token(Token = "0x6003864")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0E94", Offset = "0x15C0E94", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void OnComplete()
		{
			throw null;
		}

		// Token: 0x04006532 RID: 25906
		[global::Cpp2ILInjected.Token(Token = "0x400792F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected T _value;

		// Token: 0x04006533 RID: 25907
		[global::Cpp2ILInjected.Token(Token = "0x4007930")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected T _maxValue;

		// Token: 0x04006534 RID: 25908
		[global::Cpp2ILInjected.Token(Token = "0x4007931")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected string _name;

		// Token: 0x04006535 RID: 25909
		[global::Cpp2ILInjected.Token(Token = "0x4007932")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TrackerType _type;
	}
}
