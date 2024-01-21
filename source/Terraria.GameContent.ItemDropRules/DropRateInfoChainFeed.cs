using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005C6")]
public struct DropRateInfoChainFeed
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006B93")]
	public float parentDroprateChance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006B94")]
	public List<IItemDropRuleCondition> conditions;

	[Cpp2IlInjected.Token(Token = "0x6003CA5")]
	[Cpp2IlInjected.Address(RVA = "0x39A2F4", Offset = "0x39A2F4", VA = "0x39A2F4")]
	public void AddCondition(IItemDropRuleCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CA6")]
	[Cpp2IlInjected.Address(RVA = "0x39A2FC", Offset = "0x39A2FC", VA = "0x39A2FC")]
	public DropRateInfoChainFeed(float droprate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CA7")]
	[Cpp2IlInjected.Address(RVA = "0x39A30C", Offset = "0x39A30C", VA = "0x39A30C")]
	public DropRateInfoChainFeed With(float multiplier)
	{
		return default(DropRateInfoChainFeed);
	}
}
