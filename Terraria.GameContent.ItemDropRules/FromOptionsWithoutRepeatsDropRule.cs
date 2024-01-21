using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005DF")]
public class FromOptionsWithoutRepeatsDropRule : IItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BC0")]
	public int[] dropIds;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BC1")]
	public int dropCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006BC3")]
	private List<int> _temporaryAvailableItems;

	[Cpp2IlInjected.Token(Token = "0x1700073B")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003D0B")]
		[Cpp2IlInjected.Address(RVA = "0xE78F3C", Offset = "0xE78F3C", VA = "0xE78F3C", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003D0C")]
		[Cpp2IlInjected.Address(RVA = "0xE78F44", Offset = "0xE78F44", VA = "0xE78F44")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003D0D")]
	[Cpp2IlInjected.Address(RVA = "0xE78F4C", Offset = "0xE78F4C", VA = "0xE78F4C")]
	public FromOptionsWithoutRepeatsDropRule(int dropCount, params int[] options)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D0E")]
	[Cpp2IlInjected.Address(RVA = "0xE79014", Offset = "0xE79014", VA = "0xE79014", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D0F")]
	[Cpp2IlInjected.Address(RVA = "0xE7901C", Offset = "0xE7901C", VA = "0xE7901C", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D10")]
	[Cpp2IlInjected.Address(RVA = "0xE79138", Offset = "0xE79138", VA = "0xE79138", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
