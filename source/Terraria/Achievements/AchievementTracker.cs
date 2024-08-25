using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using Terraria.GameContent.Achievements;

namespace Terraria.Achievements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000697")]
	public abstract class AchievementTracker<T> : IAchievementTracker
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600385D")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0D68", Offset = "0x15C0D68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Terraria.Achievements.IAchievementTracker.ReportAs(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600385E")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0D70", Offset = "0x15C0D70", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private TrackerType Terraria.Achievements.IAchievementTracker.GetTrackerType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600385F")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0D78", Offset = "0x15C0D78", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Terraria.Achievements.IAchievementTracker.Clear()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003861")]
		public abstract void ReportUpdate();

		[global::Cpp2ILInjected.Token(Token = "0x6003862")]
		protected abstract void Load();

		[global::Cpp2ILInjected.Token(Token = "0x6003863")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0E88", Offset = "0x15C0E88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Terraria.Achievements.IAchievementTracker.Load()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003864")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C0E94", Offset = "0x15C0E94", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void OnComplete()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400792F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected T _value;

		[global::Cpp2ILInjected.Token(Token = "0x4007930")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected T _maxValue;

		[global::Cpp2ILInjected.Token(Token = "0x4007931")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected string _name;

		[global::Cpp2ILInjected.Token(Token = "0x4007932")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TrackerType _type;
	}
}
