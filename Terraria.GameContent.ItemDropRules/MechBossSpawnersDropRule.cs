using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D8")]
public class MechBossSpawnersDropRule : IItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BB0")]
	public Conditions.MechanicalBossesDummyCondition dummyCondition;

	[Cpp2IlInjected.Token(Token = "0x17000735")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CE3")]
		[Cpp2IlInjected.Address(RVA = "0x104C4B4", Offset = "0x104C4B4", VA = "0x104C4B4", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003CE4")]
		[Cpp2IlInjected.Address(RVA = "0x104C4BC", Offset = "0x104C4BC", VA = "0x104C4BC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003CE5")]
	[Cpp2IlInjected.Address(RVA = "0x104C4C4", Offset = "0x104C4C4", VA = "0x104C4C4")]
	public MechBossSpawnersDropRule()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CE6")]
	[Cpp2IlInjected.Address(RVA = "0x104C56C", Offset = "0x104C56C", VA = "0x104C56C", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CE7")]
	[Cpp2IlInjected.Address(RVA = "0x104C6B8", Offset = "0x104C6B8", VA = "0x104C6B8", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CE8")]
	[Cpp2IlInjected.Address(RVA = "0x104C848", Offset = "0x104C848", VA = "0x104C848", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
