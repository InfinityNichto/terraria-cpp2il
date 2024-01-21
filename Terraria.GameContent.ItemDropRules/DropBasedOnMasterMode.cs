using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D6")]
public class DropBasedOnMasterMode : IItemDropRule, INestedItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BA8")]
	public IItemDropRule ruleForDefault;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BA9")]
	public IItemDropRule ruleForMasterMode;

	[Cpp2IlInjected.Token(Token = "0x17000733")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CD5")]
		[Cpp2IlInjected.Address(RVA = "0xE782B4", Offset = "0xE782B4", VA = "0xE782B4", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003CD6")]
		[Cpp2IlInjected.Address(RVA = "0xE782BC", Offset = "0xE782BC", VA = "0xE782BC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003CD7")]
	[Cpp2IlInjected.Address(RVA = "0xE782C4", Offset = "0xE782C4", VA = "0xE782C4")]
	public DropBasedOnMasterMode(IItemDropRule ruleForDefault, IItemDropRule ruleForMasterMode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CD8")]
	[Cpp2IlInjected.Address(RVA = "0xE78358", Offset = "0xE78358", VA = "0xE78358", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CD9")]
	[Cpp2IlInjected.Address(RVA = "0xE784A4", Offset = "0xE784A4", VA = "0xE784A4", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CDA")]
	[Cpp2IlInjected.Address(RVA = "0xE784AC", Offset = "0xE784AC", VA = "0xE784AC", Slot = "8")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CDB")]
	[Cpp2IlInjected.Address(RVA = "0xE784F8", Offset = "0xE784F8", VA = "0xE784F8", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
