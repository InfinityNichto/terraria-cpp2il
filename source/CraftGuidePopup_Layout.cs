using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001CD")]
public class CraftGuidePopup_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BF7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5764", Offset = "0x9B5764", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000BF8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B57B0", Offset = "0x9B57B0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public CraftGuidePopup_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000FE3")]
	public static CraftGuidePopup_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000FE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000FE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout GridBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000FE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout CraftItems;

	[global::Cpp2ILInjected.Token(Token = "0x4000FE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float CraftItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000FE8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4000FE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x4000FEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x4000FEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout ItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4000FEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout Item;

	[global::Cpp2ILInjected.Token(Token = "0x4000FED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000FEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x4000FEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public DraggableItemGrid_Layout MaterialsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public float MaterialItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public String_Layout RequiredObjects;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public String_Layout Required1;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout Required2;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout Text;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Panel_Layout TextBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public int MinTextHeight;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public int TextBackingOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000FF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public int BackingTextPadding;

	[global::Cpp2ILInjected.Token(Token = "0x4000FFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public int BackingTextPaddingController;

	[global::Cpp2ILInjected.Token(Token = "0x4000FFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public int ExtraMaterialLineOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000FFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public int ControllerMaterialLineOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000FFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public int CraftItemOffset;
}
