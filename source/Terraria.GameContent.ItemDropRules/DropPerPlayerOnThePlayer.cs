using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D2")]
public class DropPerPlayerOnThePlayer : CommonDrop
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006BA2")]
	public IItemDropRuleCondition condition;

	[Cpp2IlInjected.Token(Token = "0x6003CC2")]
	[Cpp2IlInjected.Address(RVA = "0xE78CEC", Offset = "0xE78CEC", VA = "0xE78CEC")]
	public DropPerPlayerOnThePlayer(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition optionalCondition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CC3")]
	[Cpp2IlInjected.Address(RVA = "0xE78D24", Offset = "0xE78D24", VA = "0xE78D24", Slot = "8")]
	public override bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CC4")]
	[Cpp2IlInjected.Address(RVA = "0xE78E2C", Offset = "0xE78E2C", VA = "0xE78E2C", Slot = "9")]
	public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}
}
