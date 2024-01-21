using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D3")]
public class CommonDropWithRerolls : CommonDrop
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006BA3")]
	public int timesToRoll;

	[Cpp2IlInjected.Token(Token = "0x6003CC5")]
	[Cpp2IlInjected.Address(RVA = "0xE72CDC", Offset = "0xE72CDC", VA = "0xE72CDC")]
	public CommonDropWithRerolls(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, int rerolls)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CC6")]
	[Cpp2IlInjected.Address(RVA = "0xE72D18", Offset = "0xE72D18", VA = "0xE72D18", Slot = "9")]
	public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CC7")]
	[Cpp2IlInjected.Address(RVA = "0xE72DDC", Offset = "0xE72DDC", VA = "0xE72DDC", Slot = "10")]
	public override void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
