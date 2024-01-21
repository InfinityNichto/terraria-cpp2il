using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005E5")]
public delegate ItemDropAttemptResult ItemDropRuleResolveAction(IItemDropRule rule, DropAttemptInfo info);
