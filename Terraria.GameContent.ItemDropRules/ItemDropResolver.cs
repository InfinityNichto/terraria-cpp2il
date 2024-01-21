using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005E4")]
public class ItemDropResolver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BCB")]
	private ItemDropDatabase _database;

	[Cpp2IlInjected.Token(Token = "0x6003D54")]
	[Cpp2IlInjected.Address(RVA = "0x104A624", Offset = "0x104A624", VA = "0x104A624")]
	public ItemDropResolver(ItemDropDatabase database)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D55")]
	[Cpp2IlInjected.Address(RVA = "0x104A644", Offset = "0x104A644", VA = "0x104A644")]
	public void TryDropping(DropAttemptInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D56")]
	[Cpp2IlInjected.Address(RVA = "0x104A708", Offset = "0x104A708", VA = "0x104A708")]
	private ItemDropAttemptResult ResolveRule(IItemDropRule rule, DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D57")]
	[Cpp2IlInjected.Address(RVA = "0x104A9F0", Offset = "0x104A9F0", VA = "0x104A9F0")]
	private void ResolveRuleChains(IItemDropRule rule, DropAttemptInfo info, ItemDropAttemptResult parentResult)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D58")]
	[Cpp2IlInjected.Address(RVA = "0x104AAFC", Offset = "0x104AAFC", VA = "0x104AAFC")]
	private void ResolveRuleChains(ref DropAttemptInfo info, ref ItemDropAttemptResult parentResult, List<IItemDropRuleChainAttempt> ruleChains)
	{
	}
}
