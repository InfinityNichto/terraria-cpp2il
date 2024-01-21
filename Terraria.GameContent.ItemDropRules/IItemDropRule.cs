using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005C7")]
public interface IItemDropRule
{
	[Cpp2IlInjected.Token(Token = "0x1700072E")]
	List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CA8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6003CA9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanDrop(DropAttemptInfo info);

	[Cpp2IlInjected.Token(Token = "0x6003CAA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);

	[Cpp2IlInjected.Token(Token = "0x6003CAB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info);
}
