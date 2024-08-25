using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000871")]
	public interface INestedItemDropRule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60043DE")]
		ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction);
	}
}
