using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200014A RID: 330
[global::Cpp2ILInjected.Token(Token = "0x20001CF")]
public class Crafting_Layout : PageControllerLayoutDefinition<Crafting_Layout>
{
	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00023BFD File Offset: 0x00021DFD
	[global::Cpp2ILInjected.Token(Token = "0x17000148")]
	public DraggableItemGrid_Layout CraftGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B59DC", Offset = "0x9B59DC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "GetGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = "get_Collapsed", ReturnType = typeof(bool))]
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

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00023C00 File Offset: 0x00021E00
	[global::Cpp2ILInjected.Token(Token = "0x17000149")]
	public DraggableItemGrid_Layout DuplicateGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B5A7C", Offset = "0x9B5A7C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "GetGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemDuplication), Member = "get_Collapsed", ReturnType = typeof(bool))]
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

	// Token: 0x06000AEA RID: 2794 RVA: 0x00023C03 File Offset: 0x00021E03
	[global::Cpp2ILInjected.Token(Token = "0x6000BFD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5B1C", Offset = "0x9B5B1C", Length = "0x23C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public Crafting_Layout()
	{
		throw null;
	}

	// Token: 0x04000C18 RID: 3096
	[global::Cpp2ILInjected.Token(Token = "0x400101B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x04000C19 RID: 3097
	[global::Cpp2ILInjected.Token(Token = "0x400101C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float CraftItemScale;

	// Token: 0x04000C1A RID: 3098
	[global::Cpp2ILInjected.Token(Token = "0x400101D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float CraftItemHighlightScale;

	// Token: 0x04000C1B RID: 3099
	[global::Cpp2ILInjected.Token(Token = "0x400101E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public DraggableItemGrid_Layout CraftItemGrid;

	// Token: 0x04000C1C RID: 3100
	[global::Cpp2ILInjected.Token(Token = "0x400101F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	// Token: 0x04000C1D RID: 3101
	[global::Cpp2ILInjected.Token(Token = "0x4001020")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	// Token: 0x04000C1E RID: 3102
	[global::Cpp2ILInjected.Token(Token = "0x4001021")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	// Token: 0x04000C1F RID: 3103
	[global::Cpp2ILInjected.Token(Token = "0x4001022")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float MaterialItemScale;

	// Token: 0x04000C20 RID: 3104
	[global::Cpp2ILInjected.Token(Token = "0x4001023")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public Vector2 MaterialTooltipOriginOffsetLeft;

	// Token: 0x04000C21 RID: 3105
	[global::Cpp2ILInjected.Token(Token = "0x4001024")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public Vector2 MaterialTooltipOriginOffsetRight;

	// Token: 0x04000C22 RID: 3106
	[global::Cpp2ILInjected.Token(Token = "0x4001025")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ItemGrid_Layout MaterialsGrid;

	// Token: 0x04000C23 RID: 3107
	[global::Cpp2ILInjected.Token(Token = "0x4001026")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ItemGrid_Layout MaterialsGridController;

	// Token: 0x04000C24 RID: 3108
	[global::Cpp2ILInjected.Token(Token = "0x4001027")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout MaterialsTitle;

	// Token: 0x04000C25 RID: 3109
	[global::Cpp2ILInjected.Token(Token = "0x4001028")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout NoRecipes;

	// Token: 0x04000C26 RID: 3110
	[global::Cpp2ILInjected.Token(Token = "0x4001029")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public String_Layout NoRecipesController;

	// Token: 0x04000C27 RID: 3111
	[global::Cpp2ILInjected.Token(Token = "0x400102A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public bool ReverseScroll;

	// Token: 0x04000C28 RID: 3112
	[global::Cpp2ILInjected.Token(Token = "0x400102B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x91")]
	public bool DrawEmptySlots;

	// Token: 0x04000C29 RID: 3113
	[global::Cpp2ILInjected.Token(Token = "0x400102C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Texture_Layout DisabledBacking;

	// Token: 0x04000C2A RID: 3114
	[global::Cpp2ILInjected.Token(Token = "0x400102D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color DisabledBackingColor;

	// Token: 0x04000C2B RID: 3115
	[global::Cpp2ILInjected.Token(Token = "0x400102E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x04000C2C RID: 3116
	[global::Cpp2ILInjected.Token(Token = "0x400102F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color DisabledBackingIconColor;

	// Token: 0x04000C2D RID: 3117
	[global::Cpp2ILInjected.Token(Token = "0x4001030")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout CraftButton;

	// Token: 0x04000C2E RID: 3118
	[global::Cpp2ILInjected.Token(Token = "0x4001031")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout DuplicationButton;

	// Token: 0x04000C2F RID: 3119
	[global::Cpp2ILInjected.Token(Token = "0x4001032")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public bool DisableMaterialBackings;

	// Token: 0x04000C30 RID: 3120
	[global::Cpp2ILInjected.Token(Token = "0x4001033")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Texture_Layout MaterialBacking;

	// Token: 0x04000C31 RID: 3121
	[global::Cpp2ILInjected.Token(Token = "0x4001034")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Texture_Layout MaterialBackingHighlght;

	// Token: 0x04000C32 RID: 3122
	[global::Cpp2ILInjected.Token(Token = "0x4001035")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Color MaterialBackingColor;

	// Token: 0x04000C33 RID: 3123
	[global::Cpp2ILInjected.Token(Token = "0x4001036")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	public Color MaterialBackingHighlightColor;

	// Token: 0x04000C34 RID: 3124
	[global::Cpp2ILInjected.Token(Token = "0x4001037")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public bool OverrideMaterialItemScale;

	// Token: 0x04000C35 RID: 3125
	[global::Cpp2ILInjected.Token(Token = "0x4001038")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	public float OverridenMaterialItemScale;

	// Token: 0x04000C36 RID: 3126
	[global::Cpp2ILInjected.Token(Token = "0x4001039")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public bool OverrideMaterialTextScale;

	// Token: 0x04000C37 RID: 3127
	[global::Cpp2ILInjected.Token(Token = "0x400103A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public float OverridenMaterialTextScale;

	// Token: 0x04000C38 RID: 3128
	[global::Cpp2ILInjected.Token(Token = "0x400103B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Vector2 MaterialItemTextOffset;

	// Token: 0x04000C39 RID: 3129
	[global::Cpp2ILInjected.Token(Token = "0x400103C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Color DisabledDuplicationBackingColor;

	// Token: 0x04000C3A RID: 3130
	[global::Cpp2ILInjected.Token(Token = "0x400103D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Texture_Layout DisabledDuplicationBackingIcon;

	// Token: 0x04000C3B RID: 3131
	[global::Cpp2ILInjected.Token(Token = "0x400103E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Color DisabledDuplicationBackingIconColor;

	// Token: 0x04000C3C RID: 3132
	[global::Cpp2ILInjected.Token(Token = "0x400103F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
	public Color DuplicationBackingColor;

	// Token: 0x04000C3D RID: 3133
	[global::Cpp2ILInjected.Token(Token = "0x4001040")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Color DuplicationBackingHighlightColor;
}
