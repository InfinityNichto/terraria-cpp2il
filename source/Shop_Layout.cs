using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020001B2 RID: 434
[global::Cpp2ILInjected.Token(Token = "0x2000241")]
public class Shop_Layout : PageControllerLayoutDefinition<Shop_Layout>
{
	// Token: 0x06000C10 RID: 3088 RVA: 0x00023F75 File Offset: 0x00022175
	[global::Cpp2ILInjected.Token(Token = "0x6000D2A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5630", Offset = "0x9D5630", Length = "0x170")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public Shop_Layout()
	{
		throw null;
	}

	// Token: 0x0400133A RID: 4922
	[global::Cpp2ILInjected.Token(Token = "0x40017EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x0400133B RID: 4923
	[global::Cpp2ILInjected.Token(Token = "0x40017F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	// Token: 0x0400133C RID: 4924
	[global::Cpp2ILInjected.Token(Token = "0x40017F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout ShopGrid;

	// Token: 0x0400133D RID: 4925
	[global::Cpp2ILInjected.Token(Token = "0x40017F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout ShopGridHorizontal;

	// Token: 0x0400133E RID: 4926
	[global::Cpp2ILInjected.Token(Token = "0x40017F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout SavingsBacking;

	// Token: 0x0400133F RID: 4927
	[global::Cpp2ILInjected.Token(Token = "0x40017F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout Savings;

	// Token: 0x04001340 RID: 4928
	[global::Cpp2ILInjected.Token(Token = "0x40017F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 Savings1IconOffset;

	// Token: 0x04001341 RID: 4929
	[global::Cpp2ILInjected.Token(Token = "0x40017F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 Savings2IconOffset;

	// Token: 0x04001342 RID: 4930
	[global::Cpp2ILInjected.Token(Token = "0x40017F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 Savings3IconOffset;

	// Token: 0x04001343 RID: 4931
	[global::Cpp2ILInjected.Token(Token = "0x40017F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Vector2 Savings4IconOffset;

	// Token: 0x04001344 RID: 4932
	[global::Cpp2ILInjected.Token(Token = "0x40017F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout SavingsTitle;

	// Token: 0x04001345 RID: 4933
	[global::Cpp2ILInjected.Token(Token = "0x40017FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout Cost;

	// Token: 0x04001346 RID: 4934
	[global::Cpp2ILInjected.Token(Token = "0x40017FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout ControllerCost;

	// Token: 0x04001347 RID: 4935
	[global::Cpp2ILInjected.Token(Token = "0x40017FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public String_Layout OtherCurrencyCost;

	// Token: 0x04001348 RID: 4936
	[global::Cpp2ILInjected.Token(Token = "0x40017FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout BuyButton;

	// Token: 0x04001349 RID: 4937
	[global::Cpp2ILInjected.Token(Token = "0x40017FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public float SlotMultiPurchaseDelay;

	// Token: 0x0400134A RID: 4938
	[global::Cpp2ILInjected.Token(Token = "0x40017FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public int[] BartenderShopOrder;

	// Token: 0x0400134B RID: 4939
	[global::Cpp2ILInjected.Token(Token = "0x4001800")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public int[] BartenderShopOrderHorizontal;
}
