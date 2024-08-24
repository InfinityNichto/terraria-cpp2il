﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.Achievements;
using Terraria.Initializers;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000651 RID: 1617
	[global::Cpp2ILInjected.Token(Token = "0x20009AB")]
	public class CustomFloatCondition : AchievementCondition
	{
		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06003F4C RID: 16204 RVA: 0x0002D4C1 File Offset: 0x0002B6C1
		// (set) Token: 0x06003F4D RID: 16205 RVA: 0x0002D4C4 File Offset: 0x0002B6C4
		[global::Cpp2ILInjected.Token(Token = "0x1700084B")]
		public float Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004939")]
			[global::Cpp2ILInjected.Address(RVA = "0x82BBFC", Offset = "0x82BBFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600493A")]
			[global::Cpp2ILInjected.Address(RVA = "0x82A8AC", Offset = "0x82A8AC", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleRunning", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<float>), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x0002D4C7 File Offset: 0x0002B6C7
		[global::Cpp2ILInjected.Token(Token = "0x600493B")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BC04", Offset = "0x82BC04", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private CustomFloatCondition(string name, float maxValue)
		{
			throw null;
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x0002D4CA File Offset: 0x0002B6CA
		[global::Cpp2ILInjected.Token(Token = "0x600493C")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BC30", Offset = "0x82BC30", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = "Clear", ReturnType = typeof(void))]
		public override void Clear()
		{
			throw null;
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x0002D4CD File Offset: 0x0002B6CD
		[global::Cpp2ILInjected.Token(Token = "0x600493D")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BC3C", Offset = "0x82BC3C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<float>), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Load(JObject state)
		{
			throw null;
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x0002D4D0 File Offset: 0x0002B6D0
		[global::Cpp2ILInjected.Token(Token = "0x600493E")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BD5C", Offset = "0x82BD5C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionFloatTracker), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override IAchievementTracker CreateAchievementTracker()
		{
			throw null;
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x0002D4D3 File Offset: 0x0002B6D3
		[global::Cpp2ILInjected.Token(Token = "0x600493F")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BDC4", Offset = "0x82BDC4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(string name, float maxValue)
		{
			throw null;
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x0002D4D6 File Offset: 0x0002B6D6
		[global::Cpp2ILInjected.Token(Token = "0x6004940")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BE34", Offset = "0x82BE34", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTracker<float>), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Complete()
		{
			throw null;
		}

		// Token: 0x04006CA6 RID: 27814
		[JsonProperty("Value")]
		[global::Cpp2ILInjected.Token(Token = "0x4008438")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _value;

		// Token: 0x04006CA7 RID: 27815
		[global::Cpp2ILInjected.Token(Token = "0x4008439")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private float _maxValue;
	}
}