using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001CE")]
public class CraftGuide_Layout : PageControllerLayoutDefinition<CraftGuide_Layout>
{
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

	[global::Cpp2ILInjected.Token(Token = "0x4000FFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4000FFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float CraftItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001000")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float CraftItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001001")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public DraggableItemGrid_Layout CraftItemGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001002")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4001003")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001004")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4001005")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Button_Layout SelectedCraftItem;

	[global::Cpp2ILInjected.Token(Token = "0x4001006")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float MaterialItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001007")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ItemGrid_Layout MaterialsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001008")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ItemGrid_Layout MaterialsGridController;

	[global::Cpp2ILInjected.Token(Token = "0x4001009")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout CraftItemName;

	[global::Cpp2ILInjected.Token(Token = "0x400100A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout CraftItemName2;

	[global::Cpp2ILInjected.Token(Token = "0x400100B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout CraftItemNameController;

	[global::Cpp2ILInjected.Token(Token = "0x400100C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public String_Layout CraftItemName2Controller;

	[global::Cpp2ILInjected.Token(Token = "0x400100D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public String_Layout MaterialsTitle;

	[global::Cpp2ILInjected.Token(Token = "0x400100E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout RequiredObjects;

	[global::Cpp2ILInjected.Token(Token = "0x400100F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout Required1;

	[global::Cpp2ILInjected.Token(Token = "0x4001010")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout Required2;

	[global::Cpp2ILInjected.Token(Token = "0x4001011")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout RequiredObjectsController;

	[global::Cpp2ILInjected.Token(Token = "0x4001012")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public String_Layout Required1Controller;

	[global::Cpp2ILInjected.Token(Token = "0x4001013")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout Required2Controller;

	[global::Cpp2ILInjected.Token(Token = "0x4001014")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public bool ReverseScroll;

	[global::Cpp2ILInjected.Token(Token = "0x4001015")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC9")]
	public bool DrawEmptySlots;

	[global::Cpp2ILInjected.Token(Token = "0x4001016")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Texture_Layout DisabledBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001017")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Color DisabledBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001018")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Texture_Layout DisabledBackingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4001019")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Color DisabledBackingIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x400101A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout GuideButton;
}
