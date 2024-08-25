using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000874")]
	public interface IItemDropRuleChainAttempt
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007D3")]
		IItemDropRule RuleToChain
		{
			[global::Cpp2ILInjected.Token(Token = "0x60043DF")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043E0")]
		bool CanChainIntoRule(ItemDropAttemptResult parentResult);

		[global::Cpp2ILInjected.Token(Token = "0x60043E1")]
		void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);
	}
}
