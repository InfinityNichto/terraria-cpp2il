using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000870")]
	public interface IItemDropRule
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007D2")]
		List<IItemDropRuleChainAttempt> ChainedRules
		{
			[global::Cpp2ILInjected.Token(Token = "0x60043DA")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043DB")]
		bool CanDrop(DropAttemptInfo info);

		[global::Cpp2ILInjected.Token(Token = "0x60043DC")]
		void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);

		[global::Cpp2ILInjected.Token(Token = "0x60043DD")]
		ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info);
	}
}
