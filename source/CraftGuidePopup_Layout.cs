using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000149")]
public class CraftGuidePopup_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000BE9")]
	public static CraftGuidePopup_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000BEA")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000BEB")]
	public Panel_Layout GridBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000BEC")]
	public DraggableItemGrid_Layout CraftItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000BED")]
	public float CraftItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000BEE")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000BEF")]
	public Panel_Layout MenuDivider2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000BF0")]
	public String_Layout ItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000BF1")]
	public Panel_Layout ItemNameDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000BF2")]
	public Panel_Layout Item;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000BF3")]
	public Panel_Layout ItemBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000BF4")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000BF5")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000BF6")]
	public DraggableItemGrid_Layout MaterialsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000BF7")]
	public float MaterialItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000BF8")]
	public String_Layout RequiredObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000BF9")]
	public String_Layout Required1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000BFA")]
	public String_Layout Required2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000BFB")]
	public String_Layout Text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000BFC")]
	public Panel_Layout TextBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000BFD")]
	public int MinTextHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000BFE")]
	public int TextBackingOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000BFF")]
	public int BackingTextPadding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000C00")]
	public int BackingTextPaddingController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000C01")]
	public int ExtraMaterialLineOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000C02")]
	public int ControllerMaterialLineOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000C03")]
	public int CraftItemOffset;

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x20C5548", Offset = "0x20C5548", VA = "0x20C5548")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x20C55A4", Offset = "0x20C55A4", VA = "0x20C55A4")]
	public CraftGuidePopup_Layout()
	{
	}
}
