using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001CF")]
public class Crafting_Layout : PageControllerLayoutDefinition<Crafting_Layout>
{
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

	[global::Cpp2ILInjected.Token(Token = "0x400101B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400101C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float CraftItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x400101D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float CraftItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x400101E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public DraggableItemGrid_Layout CraftItemGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400101F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001020")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4001021")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4001022")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float MaterialItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001023")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public Vector2 MaterialTooltipOriginOffsetLeft;

	[global::Cpp2ILInjected.Token(Token = "0x4001024")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public Vector2 MaterialTooltipOriginOffsetRight;

	[global::Cpp2ILInjected.Token(Token = "0x4001025")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ItemGrid_Layout MaterialsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001026")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ItemGrid_Layout MaterialsGridController;

	[global::Cpp2ILInjected.Token(Token = "0x4001027")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout MaterialsTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001028")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout NoRecipes;

	[global::Cpp2ILInjected.Token(Token = "0x4001029")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public String_Layout NoRecipesController;

	[global::Cpp2ILInjected.Token(Token = "0x400102A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public bool ReverseScroll;

	[global::Cpp2ILInjected.Token(Token = "0x400102B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x91")]
	public bool DrawEmptySlots;

	[global::Cpp2ILInjected.Token(Token = "0x400102C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Texture_Layout DisabledBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400102D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color DisabledBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x400102E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Texture_Layout DisabledBackingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x400102F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color DisabledBackingIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001030")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout CraftButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001031")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout DuplicationButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001032")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public bool DisableMaterialBackings;

	[global::Cpp2ILInjected.Token(Token = "0x4001033")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Texture_Layout MaterialBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001034")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Texture_Layout MaterialBackingHighlght;

	[global::Cpp2ILInjected.Token(Token = "0x4001035")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Color MaterialBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001036")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	public Color MaterialBackingHighlightColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001037")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public bool OverrideMaterialItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001038")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	public float OverridenMaterialItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001039")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public bool OverrideMaterialTextScale;

	[global::Cpp2ILInjected.Token(Token = "0x400103A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public float OverridenMaterialTextScale;

	[global::Cpp2ILInjected.Token(Token = "0x400103B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Vector2 MaterialItemTextOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400103C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Color DisabledDuplicationBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x400103D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Texture_Layout DisabledDuplicationBackingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x400103E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Color DisabledDuplicationBackingIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x400103F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
	public Color DuplicationBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001040")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Color DuplicationBackingHighlightColor;
}
