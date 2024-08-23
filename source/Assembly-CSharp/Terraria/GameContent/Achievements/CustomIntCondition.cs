using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.Achievements;
using Terraria.Initializers;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000652 RID: 1618
	[global::Cpp2ILInjected.Token(Token = "0x20009AC")]
	public class CustomIntCondition : AchievementCondition
	{
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06003F54 RID: 16212 RVA: 0x0002D4D9 File Offset: 0x0002B6D9
		// (set) Token: 0x06003F55 RID: 16213 RVA: 0x0002D4DC File Offset: 0x0002B6DC
		[global::Cpp2ILInjected.Token(Token = "0x1700084C")]
		public int Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004941")]
			[global::Cpp2ILInjected.Address(RVA = "0x82BEE0", Offset = "0x82BEE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004942")]
			[global::Cpp2ILInjected.Address(RVA = "0x82AC28", Offset = "0x82AC28", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleAnglerService", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleMining", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<>), Member = "SetValue", MemberParameters = new object[]
			{
				"T",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x0002D4DF File Offset: 0x0002B6DF
		[global::Cpp2ILInjected.Token(Token = "0x6004943")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BEE8", Offset = "0x82BEE8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private CustomIntCondition(string name, int maxValue)
		{
			throw null;
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x0002D4E2 File Offset: 0x0002B6E2
		[global::Cpp2ILInjected.Token(Token = "0x6004944")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BF10", Offset = "0x82BF10", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = "Clear", ReturnType = typeof(void))]
		public override void Clear()
		{
			throw null;
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x0002D4E5 File Offset: 0x0002B6E5
		[global::Cpp2ILInjected.Token(Token = "0x6004945")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BF1C", Offset = "0x82BF1C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<>), Member = "SetValue", MemberParameters = new object[]
		{
			"T",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Load(JObject state)
		{
			throw null;
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x0002D4E8 File Offset: 0x0002B6E8
		[global::Cpp2ILInjected.Token(Token = "0x6004946")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C04C", Offset = "0x82C04C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionIntTracker), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override IAchievementTracker CreateAchievementTracker()
		{
			throw null;
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x0002D4EB File Offset: 0x0002B6EB
		[global::Cpp2ILInjected.Token(Token = "0x6004947")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C0AC", Offset = "0x82C0AC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(string name, int maxValue)
		{
			throw null;
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x0002D4EE File Offset: 0x0002B6EE
		[global::Cpp2ILInjected.Token(Token = "0x6004948")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C118", Offset = "0x82C118", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<>), Member = "SetValue", MemberParameters = new object[]
		{
			"T",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Complete()
		{
			throw null;
		}

		// Token: 0x04006CA8 RID: 27816
		[JsonProperty("Value")]
		[global::Cpp2ILInjected.Token(Token = "0x400843A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int _value;

		// Token: 0x04006CA9 RID: 27817
		[global::Cpp2ILInjected.Token(Token = "0x400843B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _maxValue;
	}
}
