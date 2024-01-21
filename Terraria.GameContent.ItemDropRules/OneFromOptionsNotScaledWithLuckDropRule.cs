using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005DD")]
public class OneFromOptionsNotScaledWithLuckDropRule : IItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BB8")]
	public int[] dropIds;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BB9")]
	public int chanceDenominator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BBA")]
	public int chanceNumerator;

	[Cpp2IlInjected.Token(Token = "0x17000739")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CFF")]
		[Cpp2IlInjected.Address(RVA = "0x104CBFC", Offset = "0x104CBFC", VA = "0x104CBFC", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003D00")]
		[Cpp2IlInjected.Address(RVA = "0x104CC04", Offset = "0x104CC04", VA = "0x104CC04")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003D01")]
	[Cpp2IlInjected.Address(RVA = "0x104B3EC", Offset = "0x104B3EC", VA = "0x104B3EC")]
	public OneFromOptionsNotScaledWithLuckDropRule(int chanceDenominator, int chanceNumerator, params int[] options)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D02")]
	[Cpp2IlInjected.Address(RVA = "0x104CC0C", Offset = "0x104CC0C", VA = "0x104CC0C", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D03")]
	[Cpp2IlInjected.Address(RVA = "0x104CC14", Offset = "0x104CC14", VA = "0x104CC14", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D04")]
	[Cpp2IlInjected.Address(RVA = "0x104CC90", Offset = "0x104CC90", VA = "0x104CC90", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
