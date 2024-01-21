using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005DA")]
public class ItemDropWithConditionRule : CommonDrop
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006BB2")]
	public IItemDropRuleCondition condition;

	[Cpp2IlInjected.Token(Token = "0x6003CF0")]
	[Cpp2IlInjected.Address(RVA = "0x104B29C", Offset = "0x104B29C", VA = "0x104B29C")]
	public ItemDropWithConditionRule(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition condition, int chanceNumerator = 1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CF1")]
	[Cpp2IlInjected.Address(RVA = "0x104C0A4", Offset = "0x104C0A4", VA = "0x104C0A4", Slot = "8")]
	public override bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CF2")]
	[Cpp2IlInjected.Address(RVA = "0x104C198", Offset = "0x104C198", VA = "0x104C198", Slot = "10")]
	public override void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
