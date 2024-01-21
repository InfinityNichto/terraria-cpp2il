using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005C8")]
public interface INestedItemDropRule
{
	[Cpp2IlInjected.Token(Token = "0x6003CAC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction);
}
