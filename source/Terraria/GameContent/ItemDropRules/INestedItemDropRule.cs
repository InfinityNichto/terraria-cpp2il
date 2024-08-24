using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005C5 RID: 1477
	[global::Cpp2ILInjected.Token(Token = "0x2000871")]
	public interface INestedItemDropRule
	{
		// Token: 0x06003C70 RID: 15472
		[global::Cpp2ILInjected.Token(Token = "0x60043DE")]
		ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction);
	}
}
