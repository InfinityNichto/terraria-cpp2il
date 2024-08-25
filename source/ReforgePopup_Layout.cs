using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000233")]
public class ReforgePopup_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D01")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D191C", Offset = "0x9D191C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D02")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1968", Offset = "0x9D1968", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ReforgePopup_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40016E8")]
	public static ReforgePopup_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40016E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int BackingTextPadding;

	[global::Cpp2ILInjected.Token(Token = "0x40016EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int BackingTextPaddingController;

	[global::Cpp2ILInjected.Token(Token = "0x40016EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int MinTextHeight;

	[global::Cpp2ILInjected.Token(Token = "0x40016EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int TextBackingOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int MaxWidthLastLineAddition;

	[global::Cpp2ILInjected.Token(Token = "0x40016EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40016EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout Text;

	[global::Cpp2ILInjected.Token(Token = "0x40016F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout TextBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40016F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40016F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x40016F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Reforge;

	[global::Cpp2ILInjected.Token(Token = "0x40016F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout SavingsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40016F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public String_Layout Savings;

	[global::Cpp2ILInjected.Token(Token = "0x40016F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout SavingsTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40016F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Vector2 Savings1IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Vector2 Savings2IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Vector2 Savings3IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Vector2 Savings4IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40016FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout ReforgeCost;

	[global::Cpp2ILInjected.Token(Token = "0x40016FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout ReforgeCostController;

	[global::Cpp2ILInjected.Token(Token = "0x40016FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout ReforgeItemName;

	[global::Cpp2ILInjected.Token(Token = "0x40016FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout ReforgeItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40016FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout ReforgeItem;

	[global::Cpp2ILInjected.Token(Token = "0x4001700")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout ReforgeItemBacking;
}
