using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005E1")]
public static class Chains
{
	[Cpp2IlInjected.Token(Token = "0x20009AE")]
	public class TryIfFailedRandomRoll : IItemDropRuleChainAttempt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CCB")]
		public bool hideLootReport;

		[Cpp2IlInjected.Token(Token = "0x170008C7")]
		public IItemDropRule RuleToChain
		{
			[Cpp2IlInjected.Token(Token = "0x6004E78")]
			[Cpp2IlInjected.Address(RVA = "0xE71854", Offset = "0xE71854", VA = "0xE71854", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E79")]
			[Cpp2IlInjected.Address(RVA = "0xE7185C", Offset = "0xE7185C", VA = "0xE7185C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E7A")]
		[Cpp2IlInjected.Address(RVA = "0xE713E8", Offset = "0xE713E8", VA = "0xE713E8")]
		public TryIfFailedRandomRoll(IItemDropRule rule, bool hideLootReport = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E7B")]
		[Cpp2IlInjected.Address(RVA = "0xE71864", Offset = "0xE71864", VA = "0xE71864", Slot = "5")]
		public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E7C")]
		[Cpp2IlInjected.Address(RVA = "0xE71874", Offset = "0xE71874", VA = "0xE71874", Slot = "6")]
		public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009AF")]
	public class TryIfSucceeded : IItemDropRuleChainAttempt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CCD")]
		public bool hideLootReport;

		[Cpp2IlInjected.Token(Token = "0x170008C8")]
		public IItemDropRule RuleToChain
		{
			[Cpp2IlInjected.Token(Token = "0x6004E7D")]
			[Cpp2IlInjected.Address(RVA = "0xE7198C", Offset = "0xE7198C", VA = "0xE7198C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E7E")]
			[Cpp2IlInjected.Address(RVA = "0xE71994", Offset = "0xE71994", VA = "0xE71994")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E7F")]
		[Cpp2IlInjected.Address(RVA = "0xE71520", Offset = "0xE71520", VA = "0xE71520")]
		public TryIfSucceeded(IItemDropRule rule, bool hideLootReport = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E80")]
		[Cpp2IlInjected.Address(RVA = "0xE7199C", Offset = "0xE7199C", VA = "0xE7199C", Slot = "5")]
		public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E81")]
		[Cpp2IlInjected.Address(RVA = "0xE719AC", Offset = "0xE719AC", VA = "0xE719AC", Slot = "6")]
		public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009B0")]
	public class TryIfDoesntFillConditions : IItemDropRuleChainAttempt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CCF")]
		public bool hideLootReport;

		[Cpp2IlInjected.Token(Token = "0x170008C9")]
		public IItemDropRule RuleToChain
		{
			[Cpp2IlInjected.Token(Token = "0x6004E82")]
			[Cpp2IlInjected.Address(RVA = "0xE71680", Offset = "0xE71680", VA = "0xE71680", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E83")]
			[Cpp2IlInjected.Address(RVA = "0xE71688", Offset = "0xE71688", VA = "0xE71688")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E84")]
		[Cpp2IlInjected.Address(RVA = "0xE71658", Offset = "0xE71658", VA = "0xE71658")]
		public TryIfDoesntFillConditions(IItemDropRule rule, bool hideLootReport = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E85")]
		[Cpp2IlInjected.Address(RVA = "0xE71690", Offset = "0xE71690", VA = "0xE71690", Slot = "5")]
		public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E86")]
		[Cpp2IlInjected.Address(RVA = "0xE7169C", Offset = "0xE7169C", VA = "0xE7169C", Slot = "6")]
		public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003D18")]
	[Cpp2IlInjected.Address(RVA = "0xE71140", Offset = "0xE71140", VA = "0xE71140")]
	public static void ReportDroprates(List<IItemDropRuleChainAttempt> ChainedRules, float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D19")]
	[Cpp2IlInjected.Address(RVA = "0xE712D8", Offset = "0xE712D8", VA = "0xE712D8")]
	public static IItemDropRule OnFailedRoll(this IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D1A")]
	[Cpp2IlInjected.Address(RVA = "0xE71410", Offset = "0xE71410", VA = "0xE71410")]
	public static IItemDropRule OnSuccess(this IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D1B")]
	[Cpp2IlInjected.Address(RVA = "0xE71548", Offset = "0xE71548", VA = "0xE71548")]
	public static IItemDropRule OnFailedConditions(this IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
	{
		return null;
	}
}
