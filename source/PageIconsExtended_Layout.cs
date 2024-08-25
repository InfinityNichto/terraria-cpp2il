using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x200022C")]
public class PageIconsExtended_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CEF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1190", Offset = "0x9D1190", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CF0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D11DC", Offset = "0x9D11DC", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CraftGuide_Layout), Member = "get_DisplayGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Crafting_Layout), Member = "get_CraftGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Crafting_Layout), Member = "get_DuplicateGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HousingMenu_Layout), Member = "get_DisplayNPCGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PVPIcons_Layout), Member = "get_Grid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Reforge_Layout), Member = "get_DisplayItemGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResearchPage_Layout), Member = "get_DisplayItemGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public DraggableItemGrid_Layout GetDisplayGrid(bool rightGrid, bool collapsedGrid)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CF1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D12A0", Offset = "0x9D12A0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PageIconsExtended_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40015FC")]
	public static PageIconsExtended_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40015FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout InventoryPageGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40015FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout CraftingPageGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40015FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout InteractionPageGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001600")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout EquipmentPageGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001601")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout PageGridLeft;

	[global::Cpp2ILInjected.Token(Token = "0x4001602")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout PageGridRight;

	[global::Cpp2ILInjected.Token(Token = "0x4001603")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout SingleEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4001604")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout TopEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4001605")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout MiddleEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4001606")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout BottomEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4001607")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ClosedEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4001608")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout Expaned;

	[global::Cpp2ILInjected.Token(Token = "0x4001609")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout Collapsed;

	[global::Cpp2ILInjected.Token(Token = "0x400160A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Color InventoryBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400160B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public Color InventorySelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400160C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Color CraftingBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400160D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public Color CraftingSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400160E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Color CraftingGuideBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400160F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public Color CraftingGuideSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001610")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Color ReforgeBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001611")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public Color ReforgeSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001612")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color ResearchBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001613")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public Color ResearchSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001614")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Color PVPBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001615")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	public Color PVPSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001616")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color ChestBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001617")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public Color ChestSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001618")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Color BankBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001619")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public Color BankSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400161A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Color ChatBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400161B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public Color ChatSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400161C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Color EquipmentBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400161D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	public Color EquipmentSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400161E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Color HousingBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400161F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
	public Color HousingSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001620")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Color ShopBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001621")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	public Color ShopSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001622")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Color DuplicateBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001623")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	public Color DuplicateSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001624")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Color HatRackBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001625")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	public Color HatRackSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001626")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Color DisplayDollBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001627")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public Color DisplayDollSelectedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001628")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Color BankButtonNormalColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001629")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	public Color BankButtonPressedColour;

	[global::Cpp2ILInjected.Token(Token = "0x400162A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Color BankButtonDisabledColour;

	[global::Cpp2ILInjected.Token(Token = "0x400162B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public DraggableItemGrid_Layout Left_ConsoleGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400162C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public DraggableItemGrid_Layout Left_ConsoleGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x400162D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public DraggableItemGrid_Layout Left_TouchGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400162E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public DraggableItemGrid_Layout Left_TouchGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x400162F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public DraggableItemGrid_Layout Right_ConsoleGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001630")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public DraggableItemGrid_Layout Right_ConsoleGridCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4001631")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public DraggableItemGrid_Layout Right_TouchGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001632")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public DraggableItemGrid_Layout Right_TouchGridCollapsed;
}
