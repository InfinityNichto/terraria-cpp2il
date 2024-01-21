using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005DE")]
public class OneFromOptionsDropRule : IItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BBC")]
	public int[] dropIds;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BBD")]
	public int chanceDenominator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BBE")]
	public int chanceNumerator;

	[Cpp2IlInjected.Token(Token = "0x1700073A")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003D05")]
		[Cpp2IlInjected.Address(RVA = "0x104CA00", Offset = "0x104CA00", VA = "0x104CA00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003D06")]
		[Cpp2IlInjected.Address(RVA = "0x104CA08", Offset = "0x104CA08", VA = "0x104CA08")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003D07")]
	[Cpp2IlInjected.Address(RVA = "0x104B584", Offset = "0x104B584", VA = "0x104B584")]
	public OneFromOptionsDropRule(int chanceDenominator, int chanceNumerator, params int[] options)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D08")]
	[Cpp2IlInjected.Address(RVA = "0x104CA10", Offset = "0x104CA10", VA = "0x104CA10", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D09")]
	[Cpp2IlInjected.Address(RVA = "0x104CA18", Offset = "0x104CA18", VA = "0x104CA18", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D0A")]
	[Cpp2IlInjected.Address(RVA = "0x104CA94", Offset = "0x104CA94", VA = "0x104CA94", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
