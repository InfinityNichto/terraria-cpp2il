using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001DF")]
public class InventoryTransactions_Layout : PageControllerLayoutDefinition<InventoryTransactions_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C45")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CACBC", Offset = "0x9CACBC", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public InventoryTransactions_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001124")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout SellButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001125")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout SellValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001126")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout ControllerSellValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001127")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout OpenButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001128")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout UseButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001129")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout EquipButton;

	[global::Cpp2ILInjected.Token(Token = "0x400112A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout DepositButton;

	[global::Cpp2ILInjected.Token(Token = "0x400112B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout PlaceHatButton;

	[global::Cpp2ILInjected.Token(Token = "0x400112C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout PlaceDollButton;
}
