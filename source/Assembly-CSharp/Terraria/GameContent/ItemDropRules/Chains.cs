using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005DE RID: 1502
	[global::Cpp2ILInjected.Token(Token = "0x200088B")]
	public static class Chains
	{
		// Token: 0x06003CDC RID: 15580 RVA: 0x0002CDE0 File Offset: 0x0002AFE0
		[global::Cpp2ILInjected.Token(Token = "0x600444B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9B04", Offset = "0x7A9B04", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonDrop), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonDropWithRerolls), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropNothing), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnExpertMode), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnMasterMode), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnMasterAndExpertMode), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MechBossSpawnersDropRule), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropWithConditionRule), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LeadingConditionRule), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropOneByOne), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneFromOptionsNotScaledWithLuckDropRule), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneFromOptionsDropRule), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FromOptionsWithoutRepeatsDropRule), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneFromRulesRule), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void ReportDroprates(List<IItemDropRuleChainAttempt> ChainedRules, float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x0002CDE3 File Offset: 0x0002AFE3
		[global::Cpp2ILInjected.Token(Token = "0x600444C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AB024", Offset = "0x7AB024", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMimic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenBee", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Skeletron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterGlobalRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static IItemDropRule OnFailedRoll(this IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
		{
			throw null;
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x0002CDE6 File Offset: 0x0002AFE6
		[global::Cpp2ILInjected.Token(Token = "0x600444D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AB1A4", Offset = "0x7AB1A4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCsNotRemixSeed", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCsRemixSeed", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterEclipse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMimic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Plantera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Twins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_WOF", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_MoonLord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Golem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_DukeFishron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 113)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static IItemDropRule OnSuccess(this IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
		{
			throw null;
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x0002CDE9 File Offset: 0x0002AFE9
		[global::Cpp2ILInjected.Token(Token = "0x600444E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AB324", Offset = "0x7AB324", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Plantera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static IItemDropRule OnFailedConditions(this IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
		{
			throw null;
		}

		// Token: 0x020009B7 RID: 2487
		[global::Cpp2ILInjected.Token(Token = "0x200088C")]
		public class TryIfFailedRandomRoll : IItemDropRuleChainAttempt
		{
			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x06004E41 RID: 20033 RVA: 0x0002FCF3 File Offset: 0x0002DEF3
			// (set) Token: 0x06004E42 RID: 20034 RVA: 0x0002FCF6 File Offset: 0x0002DEF6
			[global::Cpp2ILInjected.Token(Token = "0x170007E1")]
			public IItemDropRule RuleToChain
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600444F")]
				[global::Cpp2ILInjected.Address(RVA = "0x7AB4A4", Offset = "0x7AB4A4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004450")]
				[global::Cpp2ILInjected.Address(RVA = "0x7AB4AC", Offset = "0x7AB4AC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06004E43 RID: 20035 RVA: 0x0002FCF9 File Offset: 0x0002DEF9
			[global::Cpp2ILInjected.Token(Token = "0x6004451")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB174", Offset = "0x7AB174", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TryIfFailedRandomRoll(IItemDropRule rule, bool hideLootReport = false)
			{
				throw null;
			}

			// Token: 0x06004E44 RID: 20036 RVA: 0x0002FCFC File Offset: 0x0002DEFC
			[global::Cpp2ILInjected.Token(Token = "0x6004452")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB4B4", Offset = "0x7AB4B4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
			{
				throw null;
			}

			// Token: 0x06004E45 RID: 20037 RVA: 0x0002FCFF File Offset: 0x0002DEFF
			[global::Cpp2ILInjected.Token(Token = "0x6004453")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB4C0", Offset = "0x7AB4C0", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "With", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(DropRateInfoChainFeed))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
			{
				throw null;
			}

			// Token: 0x04008CDD RID: 36061
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40081F0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private IItemDropRule <RuleToChain>k__BackingField;

			// Token: 0x04008CDE RID: 36062
			[global::Cpp2ILInjected.Token(Token = "0x40081F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public bool hideLootReport;
		}

		// Token: 0x020009B8 RID: 2488
		[global::Cpp2ILInjected.Token(Token = "0x200088D")]
		public class TryIfSucceeded : IItemDropRuleChainAttempt
		{
			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x06004E46 RID: 20038 RVA: 0x0002FD02 File Offset: 0x0002DF02
			// (set) Token: 0x06004E47 RID: 20039 RVA: 0x0002FD05 File Offset: 0x0002DF05
			[global::Cpp2ILInjected.Token(Token = "0x170007E2")]
			public IItemDropRule RuleToChain
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004454")]
				[global::Cpp2ILInjected.Address(RVA = "0x7AB5B8", Offset = "0x7AB5B8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004455")]
				[global::Cpp2ILInjected.Address(RVA = "0x7AB5C0", Offset = "0x7AB5C0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06004E48 RID: 20040 RVA: 0x0002FD08 File Offset: 0x0002DF08
			[global::Cpp2ILInjected.Token(Token = "0x6004456")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB2F4", Offset = "0x7AB2F4", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TryIfSucceeded(IItemDropRule rule, bool hideLootReport = false)
			{
				throw null;
			}

			// Token: 0x06004E49 RID: 20041 RVA: 0x0002FD0B File Offset: 0x0002DF0B
			[global::Cpp2ILInjected.Token(Token = "0x6004457")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB5C8", Offset = "0x7AB5C8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
			{
				throw null;
			}

			// Token: 0x06004E4A RID: 20042 RVA: 0x0002FD0E File Offset: 0x0002DF0E
			[global::Cpp2ILInjected.Token(Token = "0x6004458")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB5D4", Offset = "0x7AB5D4", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "With", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(DropRateInfoChainFeed))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
			{
				throw null;
			}

			// Token: 0x04008CDF RID: 36063
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40081F2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private IItemDropRule <RuleToChain>k__BackingField;

			// Token: 0x04008CE0 RID: 36064
			[global::Cpp2ILInjected.Token(Token = "0x40081F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public bool hideLootReport;
		}

		// Token: 0x020009B9 RID: 2489
		[global::Cpp2ILInjected.Token(Token = "0x200088E")]
		public class TryIfDoesntFillConditions : IItemDropRuleChainAttempt
		{
			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06004E4B RID: 20043 RVA: 0x0002FD11 File Offset: 0x0002DF11
			// (set) Token: 0x06004E4C RID: 20044 RVA: 0x0002FD14 File Offset: 0x0002DF14
			[global::Cpp2ILInjected.Token(Token = "0x170007E3")]
			public IItemDropRule RuleToChain
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004459")]
				[global::Cpp2ILInjected.Address(RVA = "0x7AB6C8", Offset = "0x7AB6C8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600445A")]
				[global::Cpp2ILInjected.Address(RVA = "0x7AB6D0", Offset = "0x7AB6D0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06004E4D RID: 20045 RVA: 0x0002FD17 File Offset: 0x0002DF17
			[global::Cpp2ILInjected.Token(Token = "0x600445B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB474", Offset = "0x7AB474", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TryIfDoesntFillConditions(IItemDropRule rule, bool hideLootReport = false)
			{
				throw null;
			}

			// Token: 0x06004E4E RID: 20046 RVA: 0x0002FD1A File Offset: 0x0002DF1A
			[global::Cpp2ILInjected.Token(Token = "0x600445C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB6D8", Offset = "0x7AB6D8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
			{
				throw null;
			}

			// Token: 0x06004E4F RID: 20047 RVA: 0x0002FD1D File Offset: 0x0002DF1D
			[global::Cpp2ILInjected.Token(Token = "0x600445D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB6E4", Offset = "0x7AB6E4", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "With", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(DropRateInfoChainFeed))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
			{
				throw null;
			}

			// Token: 0x04008CE1 RID: 36065
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40081F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private IItemDropRule <RuleToChain>k__BackingField;

			// Token: 0x04008CE2 RID: 36066
			[global::Cpp2ILInjected.Token(Token = "0x40081F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public bool hideLootReport;
		}
	}
}
