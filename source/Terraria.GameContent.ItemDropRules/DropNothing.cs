using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D4")]
public class DropNothing : IItemDropRule
{
	[Cpp2IlInjected.Token(Token = "0x17000731")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CC8")]
		[Cpp2IlInjected.Address(RVA = "0xE788E8", Offset = "0xE788E8", VA = "0xE788E8", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003CC9")]
		[Cpp2IlInjected.Address(RVA = "0xE788F0", Offset = "0xE788F0", VA = "0xE788F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003CCA")]
	[Cpp2IlInjected.Address(RVA = "0xE788F8", Offset = "0xE788F8", VA = "0xE788F8")]
	public DropNothing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CCB")]
	[Cpp2IlInjected.Address(RVA = "0xE7897C", Offset = "0xE7897C", VA = "0xE7897C", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CCC")]
	[Cpp2IlInjected.Address(RVA = "0xE78984", Offset = "0xE78984", VA = "0xE78984", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CCD")]
	[Cpp2IlInjected.Address(RVA = "0xE7898C", Offset = "0xE7898C", VA = "0xE7898C", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
