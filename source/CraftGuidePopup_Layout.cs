using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000148 RID: 328
[global::Cpp2ILInjected.Token(Token = "0x20001CD")]
public class CraftGuidePopup_Layout : LayoutDefinition
{
	// Token: 0x06000AE4 RID: 2788 RVA: 0x00023BF1 File Offset: 0x00021DF1
	[global::Cpp2ILInjected.Token(Token = "0x6000BF7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5764", Offset = "0x9B5764", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00023BF4 File Offset: 0x00021DF4
	[global::Cpp2ILInjected.Token(Token = "0x6000BF8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B57B0", Offset = "0x9B57B0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public CraftGuidePopup_Layout()
	{
		throw null;
	}

	// Token: 0x04000BE0 RID: 3040
	[global::Cpp2ILInjected.Token(Token = "0x4000FE3")]
	public static CraftGuidePopup_Layout Instance;

	// Token: 0x04000BE1 RID: 3041
	[global::Cpp2ILInjected.Token(Token = "0x4000FE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000BE2 RID: 3042
	[global::Cpp2ILInjected.Token(Token = "0x4000FE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout GridBacking;

	// Token: 0x04000BE3 RID: 3043
	[global::Cpp2ILInjected.Token(Token = "0x4000FE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout CraftItems;

	// Token: 0x04000BE4 RID: 3044
	[global::Cpp2ILInjected.Token(Token = "0x4000FE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float CraftItemScale;

	// Token: 0x04000BE5 RID: 3045
	[global::Cpp2ILInjected.Token(Token = "0x4000FE8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000BE6 RID: 3046
	[global::Cpp2ILInjected.Token(Token = "0x4000FE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider2;

	// Token: 0x04000BE7 RID: 3047
	[global::Cpp2ILInjected.Token(Token = "0x4000FEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout ItemName;

	// Token: 0x04000BE8 RID: 3048
	[global::Cpp2ILInjected.Token(Token = "0x4000FEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x04000BE9 RID: 3049
	[global::Cpp2ILInjected.Token(Token = "0x4000FEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout Item;

	// Token: 0x04000BEA RID: 3050
	[global::Cpp2ILInjected.Token(Token = "0x4000FED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout ItemBacking;

	// Token: 0x04000BEB RID: 3051
	[global::Cpp2ILInjected.Token(Token = "0x4000FEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Close;

	// Token: 0x04000BEC RID: 3052
	[global::Cpp2ILInjected.Token(Token = "0x4000FEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Back;

	// Token: 0x04000BED RID: 3053
	[global::Cpp2ILInjected.Token(Token = "0x4000FF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public DraggableItemGrid_Layout MaterialsGrid;

	// Token: 0x04000BEE RID: 3054
	[global::Cpp2ILInjected.Token(Token = "0x4000FF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public float MaterialItemScale;

	// Token: 0x04000BEF RID: 3055
	[global::Cpp2ILInjected.Token(Token = "0x4000FF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public String_Layout RequiredObjects;

	// Token: 0x04000BF0 RID: 3056
	[global::Cpp2ILInjected.Token(Token = "0x4000FF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public String_Layout Required1;

	// Token: 0x04000BF1 RID: 3057
	[global::Cpp2ILInjected.Token(Token = "0x4000FF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout Required2;

	// Token: 0x04000BF2 RID: 3058
	[global::Cpp2ILInjected.Token(Token = "0x4000FF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout Text;

	// Token: 0x04000BF3 RID: 3059
	[global::Cpp2ILInjected.Token(Token = "0x4000FF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Panel_Layout TextBacking;

	// Token: 0x04000BF4 RID: 3060
	[global::Cpp2ILInjected.Token(Token = "0x4000FF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public int MinTextHeight;

	// Token: 0x04000BF5 RID: 3061
	[global::Cpp2ILInjected.Token(Token = "0x4000FF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public int TextBackingOffset;

	// Token: 0x04000BF6 RID: 3062
	[global::Cpp2ILInjected.Token(Token = "0x4000FF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public int BackingTextPadding;

	// Token: 0x04000BF7 RID: 3063
	[global::Cpp2ILInjected.Token(Token = "0x4000FFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public int BackingTextPaddingController;

	// Token: 0x04000BF8 RID: 3064
	[global::Cpp2ILInjected.Token(Token = "0x4000FFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public int ExtraMaterialLineOffset;

	// Token: 0x04000BF9 RID: 3065
	[global::Cpp2ILInjected.Token(Token = "0x4000FFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public int ControllerMaterialLineOffset;

	// Token: 0x04000BFA RID: 3066
	[global::Cpp2ILInjected.Token(Token = "0x4000FFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public int CraftItemOffset;
}
