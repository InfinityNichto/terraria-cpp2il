using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005DB")]
public class LeadingConditionRule : IItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BB3")]
	public IItemDropRuleCondition condition;

	[Cpp2IlInjected.Token(Token = "0x17000737")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CF3")]
		[Cpp2IlInjected.Address(RVA = "0x104C2C8", Offset = "0x104C2C8", VA = "0x104C2C8", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003CF4")]
		[Cpp2IlInjected.Address(RVA = "0x104C2D0", Offset = "0x104C2D0", VA = "0x104C2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003CF5")]
	[Cpp2IlInjected.Address(RVA = "0x104C2D8", Offset = "0x104C2D8", VA = "0x104C2D8")]
	public LeadingConditionRule(IItemDropRuleCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CF6")]
	[Cpp2IlInjected.Address(RVA = "0x104C364", Offset = "0x104C364", VA = "0x104C364", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CF7")]
	[Cpp2IlInjected.Address(RVA = "0x104C458", Offset = "0x104C458", VA = "0x104C458", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CF8")]
	[Cpp2IlInjected.Address(RVA = "0x104C4AC", Offset = "0x104C4AC", VA = "0x104C4AC", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}
}
