using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x20008CF")]
	public delegate ItemDropAttemptResult ItemDropRuleResolveAction(IItemDropRule rule, DropAttemptInfo info);
}
