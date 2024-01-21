using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005CF")]
public class CommonDrop : IItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B9B")]
	public int itemId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B9C")]
	public int chanceDenominator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006B9D")]
	public int amountDroppedMinimum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006B9E")]
	public int amountDroppedMaximum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006B9F")]
	public int chanceNumerator;

	[Cpp2IlInjected.Token(Token = "0x17000730")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CB7")]
		[Cpp2IlInjected.Address(RVA = "0xE72944", Offset = "0xE72944", VA = "0xE72944", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003CB8")]
		[Cpp2IlInjected.Address(RVA = "0xE7294C", Offset = "0xE7294C", VA = "0xE7294C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003CB9")]
	[Cpp2IlInjected.Address(RVA = "0xE72954", Offset = "0xE72954", VA = "0xE72954")]
	public CommonDrop(int itemId, int chanceDenominator, int amountDroppedMinimum = 1, int amountDroppedMaximum = 1, int chanceNumerator = 1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CBA")]
	[Cpp2IlInjected.Address(RVA = "0xE72A08", Offset = "0xE72A08", VA = "0xE72A08", Slot = "8")]
	public virtual bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CBB")]
	[Cpp2IlInjected.Address(RVA = "0xE72A10", Offset = "0xE72A10", VA = "0xE72A10", Slot = "9")]
	public virtual ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CBC")]
	[Cpp2IlInjected.Address(RVA = "0xE72A88", Offset = "0xE72A88", VA = "0xE72A88", Slot = "10")]
	public virtual void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
