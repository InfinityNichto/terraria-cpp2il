using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001A5")]
public class ReforgePopup_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x400123C")]
	public static ReforgePopup_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400123D")]
	public int BackingTextPadding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400123E")]
	public int BackingTextPaddingController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400123F")]
	public int MinTextHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001240")]
	public int TextBackingOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001241")]
	public int MaxWidthLastLineAddition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001242")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001243")]
	public String_Layout Text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001244")]
	public Panel_Layout TextBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001245")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001246")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001247")]
	public TransactionButton_Layout Reforge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001248")]
	public Panel_Layout SavingsBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001249")]
	public String_Layout Savings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400124A")]
	public String_Layout SavingsTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400124B")]
	public Vector2 Savings1IconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400124C")]
	public Vector2 Savings2IconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400124D")]
	public Vector2 Savings3IconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400124E")]
	public Vector2 Savings4IconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400124F")]
	public String_Layout ReforgeCost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001250")]
	public String_Layout ReforgeCostController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4001251")]
	public String_Layout ReforgeItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001252")]
	public Panel_Layout ReforgeItemNameDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001253")]
	public Panel_Layout ReforgeItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4001254")]
	public Panel_Layout ReforgeItemBacking;

	[Cpp2IlInjected.Token(Token = "0x6000BFA")]
	[Cpp2IlInjected.Address(RVA = "0xF990B0", Offset = "0xF990B0", VA = "0xF990B0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFB")]
	[Cpp2IlInjected.Address(RVA = "0xF9910C", Offset = "0xF9910C", VA = "0xF9910C")]
	public ReforgePopup_Layout()
	{
	}
}
