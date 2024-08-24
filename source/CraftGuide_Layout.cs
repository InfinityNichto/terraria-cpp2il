using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000149 RID: 329
[global::Cpp2ILInjected.Token(Token = "0x20001CE")]
public class CraftGuide_Layout : PageControllerLayoutDefinition<CraftGuide_Layout>
{
	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00023BF7 File Offset: 0x00021DF7
	[global::Cpp2ILInjected.Token(Token = "0x17000147")]
	public DraggableItemGrid_Layout DisplayGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B5808", Offset = "0x9B5808", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "GetGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuide), Member = "get_Collapsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageIconsExtended_Layout), Member = "GetDisplayGrid", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00023BFA File Offset: 0x00021DFA
	[global::Cpp2ILInjected.Token(Token = "0x6000BFA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B58A8", Offset = "0x9B58A8", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public CraftGuide_Layout()
	{
		throw null;
	}

	// Token: 0x04000BFB RID: 3067
	[global::Cpp2ILInjected.Token(Token = "0x4000FFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x04000BFC RID: 3068
	[global::Cpp2ILInjected.Token(Token = "0x4000FFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float CraftItemScale;

	// Token: 0x04000BFD RID: 3069
	[global::Cpp2ILInjected.Token(Token = "0x4001000")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float CraftItemHighlightScale;

	// Token: 0x04000BFE RID: 3070
	[global::Cpp2ILInjected.Token(Token = "0x4001001")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public DraggableItemGrid_Layout CraftItemGrid;

	// Token: 0x04000BFF RID: 3071
	[global::Cpp2ILInjected.Token(Token = "0x4001002")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	// Token: 0x04000C00 RID: 3072
	[global::Cpp2ILInjected.Token(Token = "0x4001003")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	// Token: 0x04000C01 RID: 3073
	[global::Cpp2ILInjected.Token(Token = "0x4001004")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	// Token: 0x04000C02 RID: 3074
	[global::Cpp2ILInjected.Token(Token = "0x4001005")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Button_Layout SelectedCraftItem;

	// Token: 0x04000C03 RID: 3075
	[global::Cpp2ILInjected.Token(Token = "0x4001006")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float MaterialItemScale;

	// Token: 0x04000C04 RID: 3076
	[global::Cpp2ILInjected.Token(Token = "0x4001007")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ItemGrid_Layout MaterialsGrid;

	// Token: 0x04000C05 RID: 3077
	[global::Cpp2ILInjected.Token(Token = "0x4001008")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ItemGrid_Layout MaterialsGridController;

	// Token: 0x04000C06 RID: 3078
	[global::Cpp2ILInjected.Token(Token = "0x4001009")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout CraftItemName;

	// Token: 0x04000C07 RID: 3079
	[global::Cpp2ILInjected.Token(Token = "0x400100A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout CraftItemName2;

	// Token: 0x04000C08 RID: 3080
	[global::Cpp2ILInjected.Token(Token = "0x400100B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout CraftItemNameController;

	// Token: 0x04000C09 RID: 3081
	[global::Cpp2ILInjected.Token(Token = "0x400100C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public String_Layout CraftItemName2Controller;

	// Token: 0x04000C0A RID: 3082
	[global::Cpp2ILInjected.Token(Token = "0x400100D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public String_Layout MaterialsTitle;

	// Token: 0x04000C0B RID: 3083
	[global::Cpp2ILInjected.Token(Token = "0x400100E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout RequiredObjects;

	// Token: 0x04000C0C RID: 3084
	[global::Cpp2ILInjected.Token(Token = "0x400100F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout Required1;

	// Token: 0x04000C0D RID: 3085
	[global::Cpp2ILInjected.Token(Token = "0x4001010")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout Required2;

	// Token: 0x04000C0E RID: 3086
	[global::Cpp2ILInjected.Token(Token = "0x4001011")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout RequiredObjectsController;

	// Token: 0x04000C0F RID: 3087
	[global::Cpp2ILInjected.Token(Token = "0x4001012")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public String_Layout Required1Controller;

	// Token: 0x04000C10 RID: 3088
	[global::Cpp2ILInjected.Token(Token = "0x4001013")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout Required2Controller;

	// Token: 0x04000C11 RID: 3089
	[global::Cpp2ILInjected.Token(Token = "0x4001014")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public bool ReverseScroll;

	// Token: 0x04000C12 RID: 3090
	[global::Cpp2ILInjected.Token(Token = "0x4001015")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC9")]
	public bool DrawEmptySlots;

	// Token: 0x04000C13 RID: 3091
	[global::Cpp2ILInjected.Token(Token = "0x4001016")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Texture_Layout DisabledBacking;

	// Token: 0x04000C14 RID: 3092
	[global::Cpp2ILInjected.Token(Token = "0x4001017")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Color DisabledBackingColor;

	// Token: 0x04000C15 RID: 3093
	[global::Cpp2ILInjected.Token(Token = "0x4001018")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x04000C16 RID: 3094
	[global::Cpp2ILInjected.Token(Token = "0x4001019")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Color DisabledBackingIconColor;

	// Token: 0x04000C17 RID: 3095
	[global::Cpp2ILInjected.Token(Token = "0x400101A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout GuideButton;
}
