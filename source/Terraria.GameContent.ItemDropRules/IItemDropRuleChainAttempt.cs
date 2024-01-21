using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005CB")]
public interface IItemDropRuleChainAttempt
{
	[Cpp2IlInjected.Token(Token = "0x1700072F")]
	IItemDropRule RuleToChain
	{
		[Cpp2IlInjected.Token(Token = "0x6003CAD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6003CAE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanChainIntoRule(ItemDropAttemptResult parentResult);

	[Cpp2IlInjected.Token(Token = "0x6003CAF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);
}
