using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005C8 RID: 1480
	[global::Cpp2ILInjected.Token(Token = "0x2000874")]
	public interface IItemDropRuleChainAttempt
	{
		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06003C71 RID: 15473
		[global::Cpp2ILInjected.Token(Token = "0x170007D3")]
		IItemDropRule RuleToChain
		{
			[global::Cpp2ILInjected.Token(Token = "0x60043DF")]
			get;
		}

		// Token: 0x06003C72 RID: 15474
		[global::Cpp2ILInjected.Token(Token = "0x60043E0")]
		bool CanChainIntoRule(ItemDropAttemptResult parentResult);

		// Token: 0x06003C73 RID: 15475
		[global::Cpp2ILInjected.Token(Token = "0x60043E1")]
		void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);
	}
}
