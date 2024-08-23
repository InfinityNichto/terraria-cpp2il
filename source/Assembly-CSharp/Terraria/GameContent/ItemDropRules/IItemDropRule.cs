using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005C4 RID: 1476
	[global::Cpp2ILInjected.Token(Token = "0x2000870")]
	public interface IItemDropRule
	{
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06003C6C RID: 15468
		[global::Cpp2ILInjected.Token(Token = "0x170007D2")]
		List<IItemDropRuleChainAttempt> ChainedRules
		{
			[global::Cpp2ILInjected.Token(Token = "0x60043DA")]
			get;
		}

		// Token: 0x06003C6D RID: 15469
		[global::Cpp2ILInjected.Token(Token = "0x60043DB")]
		bool CanDrop(DropAttemptInfo info);

		// Token: 0x06003C6E RID: 15470
		[global::Cpp2ILInjected.Token(Token = "0x60043DC")]
		void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);

		// Token: 0x06003C6F RID: 15471
		[global::Cpp2ILInjected.Token(Token = "0x60043DD")]
		ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info);
	}
}
