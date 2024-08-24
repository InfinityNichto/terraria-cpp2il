using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200015A RID: 346
[global::Cpp2ILInjected.Token(Token = "0x20001DF")]
public class InventoryTransactions_Layout : PageControllerLayoutDefinition<InventoryTransactions_Layout>
{
	// Token: 0x06000B32 RID: 2866 RVA: 0x00023CDB File Offset: 0x00021EDB
	[global::Cpp2ILInjected.Token(Token = "0x6000C45")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CACBC", Offset = "0x9CACBC", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public InventoryTransactions_Layout()
	{
		throw null;
	}

	// Token: 0x04000D21 RID: 3361
	[global::Cpp2ILInjected.Token(Token = "0x4001124")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout SellButton;

	// Token: 0x04000D22 RID: 3362
	[global::Cpp2ILInjected.Token(Token = "0x4001125")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout SellValue;

	// Token: 0x04000D23 RID: 3363
	[global::Cpp2ILInjected.Token(Token = "0x4001126")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout ControllerSellValue;

	// Token: 0x04000D24 RID: 3364
	[global::Cpp2ILInjected.Token(Token = "0x4001127")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout OpenButton;

	// Token: 0x04000D25 RID: 3365
	[global::Cpp2ILInjected.Token(Token = "0x4001128")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout UseButton;

	// Token: 0x04000D26 RID: 3366
	[global::Cpp2ILInjected.Token(Token = "0x4001129")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout EquipButton;

	// Token: 0x04000D27 RID: 3367
	[global::Cpp2ILInjected.Token(Token = "0x400112A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout DepositButton;

	// Token: 0x04000D28 RID: 3368
	[global::Cpp2ILInjected.Token(Token = "0x400112B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout PlaceHatButton;

	// Token: 0x04000D29 RID: 3369
	[global::Cpp2ILInjected.Token(Token = "0x400112C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout PlaceDollButton;
}
