using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005E0")]
public class OneFromRulesRule : IItemDropRule, INestedItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BC4")]
	public IItemDropRule[] options;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BC5")]
	public int chanceDenominator;

	[Cpp2IlInjected.Token(Token = "0x1700073C")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003D11")]
		[Cpp2IlInjected.Address(RVA = "0x104CDF8", Offset = "0x104CDF8", VA = "0x104CDF8", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003D12")]
		[Cpp2IlInjected.Address(RVA = "0x104CE00", Offset = "0x104CE00", VA = "0x104CE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003D13")]
	[Cpp2IlInjected.Address(RVA = "0x104CE08", Offset = "0x104CE08", VA = "0x104CE08")]
	public OneFromRulesRule(int chanceDenominator, params IItemDropRule[] options)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D14")]
	[Cpp2IlInjected.Address(RVA = "0x104CE9C", Offset = "0x104CE9C", VA = "0x104CE9C", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D15")]
	[Cpp2IlInjected.Address(RVA = "0x104CEA4", Offset = "0x104CEA4", VA = "0x104CEA4", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D16")]
	[Cpp2IlInjected.Address(RVA = "0x104CEAC", Offset = "0x104CEAC", VA = "0x104CEAC", Slot = "8")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D17")]
	[Cpp2IlInjected.Address(RVA = "0x104CF30", Offset = "0x104CF30", VA = "0x104CF30", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
