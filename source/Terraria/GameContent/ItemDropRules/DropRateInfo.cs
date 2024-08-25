using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x200086E")]
	public struct DropRateInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x60043D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A7084", Offset = "0x7A7084", Length = "0xC8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public DropRateInfo(int itemId, int stackMin, int stackMax, float dropRate, List<IItemDropRuleCondition> conditions = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A714C", Offset = "0x7A714C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddCondition(IItemDropRuleCondition condition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40081AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int itemId;

		[global::Cpp2ILInjected.Token(Token = "0x40081B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int stackMin;

		[global::Cpp2ILInjected.Token(Token = "0x40081B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int stackMax;

		[global::Cpp2ILInjected.Token(Token = "0x40081B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float dropRate;

		[global::Cpp2ILInjected.Token(Token = "0x40081B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<IItemDropRuleCondition> conditions;
	}
}
