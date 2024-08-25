using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000241")]
public class Shop_Layout : PageControllerLayoutDefinition<Shop_Layout>
{
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

	[global::Cpp2ILInjected.Token(Token = "0x40017EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40017F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x40017F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout ShopGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40017F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout ShopGridHorizontal;

	[global::Cpp2ILInjected.Token(Token = "0x40017F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout SavingsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout Savings;

	[global::Cpp2ILInjected.Token(Token = "0x40017F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 Savings1IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40017F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 Savings2IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40017F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 Savings3IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40017F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Vector2 Savings4IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40017F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout SavingsTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40017FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout Cost;

	[global::Cpp2ILInjected.Token(Token = "0x40017FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout ControllerCost;

	[global::Cpp2ILInjected.Token(Token = "0x40017FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public String_Layout OtherCurrencyCost;

	[global::Cpp2ILInjected.Token(Token = "0x40017FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout BuyButton;

	[global::Cpp2ILInjected.Token(Token = "0x40017FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public float SlotMultiPurchaseDelay;

	[global::Cpp2ILInjected.Token(Token = "0x40017FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public int[] BartenderShopOrder;

	[global::Cpp2ILInjected.Token(Token = "0x4001800")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public int[] BartenderShopOrderHorizontal;
}
