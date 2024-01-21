using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D9")]
public class SlimeBodyItemDropRule : IItemDropRule
{
	[Cpp2IlInjected.Token(Token = "0x17000736")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CE9")]
		[Cpp2IlInjected.Address(RVA = "0x104D0D4", Offset = "0x104D0D4", VA = "0x104D0D4", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003CEA")]
		[Cpp2IlInjected.Address(RVA = "0x104D0DC", Offset = "0x104D0DC", VA = "0x104D0DC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003CEB")]
	[Cpp2IlInjected.Address(RVA = "0x104D0E4", Offset = "0x104D0E4", VA = "0x104D0E4")]
	public SlimeBodyItemDropRule()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CEC")]
	[Cpp2IlInjected.Address(RVA = "0x104D168", Offset = "0x104D168", VA = "0x104D168", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CED")]
	[Cpp2IlInjected.Address(RVA = "0x104D1B0", Offset = "0x104D1B0", VA = "0x104D1B0", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CEE")]
	[Cpp2IlInjected.Address(RVA = "0x104D22C", Offset = "0x104D22C", VA = "0x104D22C")]
	public void GetDropInfo(int itemId, out int amountDroppedMinimum, out int amountDroppedMaximum)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CEF")]
	[Cpp2IlInjected.Address(RVA = "0x104D328", Offset = "0x104D328", VA = "0x104D328", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
