using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Bestiary;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x200086F")]
	public struct DropRateInfoChainFeed
	{
		[global::Cpp2ILInjected.Token(Token = "0x60043D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A723C", Offset = "0x7A723C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddCondition(IItemDropRuleCondition condition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A732C", Offset = "0x7A732C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabase), Member = "ExtractDropsForNPC", MemberParameters = new object[]
		{
			typeof(ItemDropDatabase),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public DropRateInfoChainFeed(float droprate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A7338", Offset = "0x7A7338", Length = "0x98")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropWithConditionRule), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneFromRulesRule), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chains.TryIfFailedRandomRoll), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chains.TryIfSucceeded), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chains.TryIfDoesntFillConditions), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DropRateInfoChainFeed With(float multiplier)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40081B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float parentDroprateChance;

		[global::Cpp2ILInjected.Token(Token = "0x40081B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public List<IItemDropRuleCondition> conditions;
	}
}
