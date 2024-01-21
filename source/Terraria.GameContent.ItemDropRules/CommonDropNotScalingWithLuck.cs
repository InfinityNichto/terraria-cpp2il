using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D0")]
public class CommonDropNotScalingWithLuck : CommonDrop
{
	[Cpp2IlInjected.Token(Token = "0x6003CBD")]
	[Cpp2IlInjected.Address(RVA = "0xE72C40", Offset = "0xE72C40", VA = "0xE72C40")]
	public CommonDropNotScalingWithLuck(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CBE")]
	[Cpp2IlInjected.Address(RVA = "0xE72C64", Offset = "0xE72C64", VA = "0xE72C64", Slot = "9")]
	public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}
}
