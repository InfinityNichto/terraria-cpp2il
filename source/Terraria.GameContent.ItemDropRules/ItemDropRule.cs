using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005C3")]
public class ItemDropRule
{
	[Cpp2IlInjected.Token(Token = "0x6003C8E")]
	[Cpp2IlInjected.Address(RVA = "0x104ACB8", Offset = "0x104ACB8", VA = "0x104ACB8")]
	public static IItemDropRule Common(int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C8F")]
	[Cpp2IlInjected.Address(RVA = "0x104AD54", Offset = "0x104AD54", VA = "0x104AD54")]
	public static IItemDropRule BossBag(int itemId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C90")]
	[Cpp2IlInjected.Address(RVA = "0x104AE78", Offset = "0x104AE78", VA = "0x104AE78")]
	public static IItemDropRule BossBagByCondition(IItemDropRuleCondition condition, int itemId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C91")]
	[Cpp2IlInjected.Address(RVA = "0x104AF38", Offset = "0x104AF38", VA = "0x104AF38")]
	public static IItemDropRule ExpertGetsRerolls(int itemId, int chanceDenominator, int expertRerolls)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C92")]
	[Cpp2IlInjected.Address(RVA = "0x104B090", Offset = "0x104B090", VA = "0x104B090")]
	public static IItemDropRule MasterModeCommonDrop(int itemId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C93")]
	[Cpp2IlInjected.Address(RVA = "0x104B1C0", Offset = "0x104B1C0", VA = "0x104B1C0")]
	public static IItemDropRule MasterModeDropOnAllPlayers(int itemId, int chanceDenominator = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C94")]
	[Cpp2IlInjected.Address(RVA = "0x104AFF4", Offset = "0x104AFF4", VA = "0x104AFF4")]
	public static IItemDropRule WithRerolls(int itemId, int rerolls, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C95")]
	[Cpp2IlInjected.Address(RVA = "0x104B11C", Offset = "0x104B11C", VA = "0x104B11C")]
	public static IItemDropRule ByCondition(IItemDropRuleCondition condition, int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1, int chanceNumerator = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C96")]
	[Cpp2IlInjected.Address(RVA = "0x104B2DC", Offset = "0x104B2DC", VA = "0x104B2DC")]
	public static IItemDropRule NotScalingWithLuck(int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C97")]
	[Cpp2IlInjected.Address(RVA = "0x104B370", Offset = "0x104B370", VA = "0x104B370")]
	public static IItemDropRule OneFromOptionsNotScalingWithLuck(int chanceDenominator, params int[] options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C98")]
	[Cpp2IlInjected.Address(RVA = "0x104B488", Offset = "0x104B488", VA = "0x104B488")]
	public static IItemDropRule OneFromOptionsNotScalingWithLuckWithX(int chanceDenominator, int chanceNumerator, params int[] options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C99")]
	[Cpp2IlInjected.Address(RVA = "0x104B508", Offset = "0x104B508", VA = "0x104B508")]
	public static IItemDropRule OneFromOptions(int chanceDenominator, params int[] options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C9A")]
	[Cpp2IlInjected.Address(RVA = "0x104B620", Offset = "0x104B620", VA = "0x104B620")]
	public static IItemDropRule OneFromOptionsWithNumerator(int chanceDenominator, int chanceNumerator, params int[] options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C9B")]
	[Cpp2IlInjected.Address(RVA = "0x104AE14", Offset = "0x104AE14", VA = "0x104AE14")]
	public static IItemDropRule DropNothing()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C9C")]
	[Cpp2IlInjected.Address(RVA = "0x104B6A0", Offset = "0x104B6A0", VA = "0x104B6A0")]
	public static IItemDropRule NormalvsExpert(int itemId, int chanceDenominatorInNormal, int chanceDenominatorInExpert)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C9D")]
	[Cpp2IlInjected.Address(RVA = "0x104B750", Offset = "0x104B750", VA = "0x104B750")]
	public static IItemDropRule NormalvsExpertNotScalingWithLuck(int itemId, int chanceDenominatorInNormal, int chanceDenominatorInExpert)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C9E")]
	[Cpp2IlInjected.Address(RVA = "0x104B800", Offset = "0x104B800", VA = "0x104B800")]
	public static IItemDropRule NormalvsExpertOneFromOptionsNotScalingWithLuck(int chanceDenominatorInNormal, int chanceDenominatorInExpert, params int[] options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C9F")]
	[Cpp2IlInjected.Address(RVA = "0x104B898", Offset = "0x104B898", VA = "0x104B898")]
	public static IItemDropRule NormalvsExpertOneFromOptions(int chanceDenominatorInNormal, int chanceDenominatorInExpert, params int[] options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003CA0")]
	[Cpp2IlInjected.Address(RVA = "0x104B930", Offset = "0x104B930", VA = "0x104B930")]
	public static IItemDropRule Food(int itemId, int chanceDenominator, int minimumDropped = 1, int maximumDropped = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003CA1")]
	[Cpp2IlInjected.Address(RVA = "0x104B9EC", Offset = "0x104B9EC", VA = "0x104B9EC")]
	public static IItemDropRule StatusImmunityItem(int itemId, int dropsOutOfX)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003CA2")]
	[Cpp2IlInjected.Address(RVA = "0x104B9F4", Offset = "0x104B9F4", VA = "0x104B9F4")]
	public ItemDropRule()
	{
	}
}
