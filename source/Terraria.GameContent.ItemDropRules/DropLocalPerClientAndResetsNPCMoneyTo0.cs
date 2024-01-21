using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D1")]
public class DropLocalPerClientAndResetsNPCMoneyTo0 : CommonDrop
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006BA1")]
	public IItemDropRuleCondition condition;

	[Cpp2IlInjected.Token(Token = "0x6003CBF")]
	[Cpp2IlInjected.Address(RVA = "0xE78730", Offset = "0xE78730", VA = "0xE78730")]
	public DropLocalPerClientAndResetsNPCMoneyTo0(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition optionalCondition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CC0")]
	[Cpp2IlInjected.Address(RVA = "0xE78768", Offset = "0xE78768", VA = "0xE78768", Slot = "8")]
	public override bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CC1")]
	[Cpp2IlInjected.Address(RVA = "0xE78870", Offset = "0xE78870", VA = "0xE78870", Slot = "9")]
	public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}
}
