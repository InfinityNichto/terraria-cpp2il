using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200019D RID: 413
[global::Cpp2ILInjected.Token(Token = "0x200022C")]
public class PageIconsExtended_Layout : LayoutDefinition
{
	// Token: 0x06000BD5 RID: 3029 RVA: 0x00023EC4 File Offset: 0x000220C4
	[global::Cpp2ILInjected.Token(Token = "0x6000CEF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1190", Offset = "0x9D1190", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x00023EC7 File Offset: 0x000220C7
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

	// Token: 0x06000BD7 RID: 3031 RVA: 0x00023ECA File Offset: 0x000220CA
	[global::Cpp2ILInjected.Token(Token = "0x6000CF1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D12A0", Offset = "0x9D12A0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PageIconsExtended_Layout()
	{
		throw null;
	}

	// Token: 0x04001147 RID: 4423
	[global::Cpp2ILInjected.Token(Token = "0x40015FC")]
	public static PageIconsExtended_Layout Instance;

	// Token: 0x04001148 RID: 4424
	[global::Cpp2ILInjected.Token(Token = "0x40015FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout InventoryPageGrid;

	// Token: 0x04001149 RID: 4425
	[global::Cpp2ILInjected.Token(Token = "0x40015FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout CraftingPageGrid;

	// Token: 0x0400114A RID: 4426
	[global::Cpp2ILInjected.Token(Token = "0x40015FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout InteractionPageGrid;

	// Token: 0x0400114B RID: 4427
	[global::Cpp2ILInjected.Token(Token = "0x4001600")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout EquipmentPageGrid;

	// Token: 0x0400114C RID: 4428
	[global::Cpp2ILInjected.Token(Token = "0x4001601")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout PageGridLeft;

	// Token: 0x0400114D RID: 4429
	[global::Cpp2ILInjected.Token(Token = "0x4001602")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout PageGridRight;

	// Token: 0x0400114E RID: 4430
	[global::Cpp2ILInjected.Token(Token = "0x4001603")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout SingleEntry;

	// Token: 0x0400114F RID: 4431
	[global::Cpp2ILInjected.Token(Token = "0x4001604")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout TopEntry;

	// Token: 0x04001150 RID: 4432
	[global::Cpp2ILInjected.Token(Token = "0x4001605")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout MiddleEntry;

	// Token: 0x04001151 RID: 4433
	[global::Cpp2ILInjected.Token(Token = "0x4001606")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout BottomEntry;

	// Token: 0x04001152 RID: 4434
	[global::Cpp2ILInjected.Token(Token = "0x4001607")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ClosedEntry;

	// Token: 0x04001153 RID: 4435
	[global::Cpp2ILInjected.Token(Token = "0x4001608")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout Expaned;

	// Token: 0x04001154 RID: 4436
	[global::Cpp2ILInjected.Token(Token = "0x4001609")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout Collapsed;

	// Token: 0x04001155 RID: 4437
	[global::Cpp2ILInjected.Token(Token = "0x400160A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Color InventoryBackingColour;

	// Token: 0x04001156 RID: 4438
	[global::Cpp2ILInjected.Token(Token = "0x400160B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public Color InventorySelectedBackingColour;

	// Token: 0x04001157 RID: 4439
	[global::Cpp2ILInjected.Token(Token = "0x400160C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Color CraftingBackingColour;

	// Token: 0x04001158 RID: 4440
	[global::Cpp2ILInjected.Token(Token = "0x400160D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public Color CraftingSelectedBackingColour;

	// Token: 0x04001159 RID: 4441
	[global::Cpp2ILInjected.Token(Token = "0x400160E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Color CraftingGuideBackingColour;

	// Token: 0x0400115A RID: 4442
	[global::Cpp2ILInjected.Token(Token = "0x400160F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public Color CraftingGuideSelectedBackingColour;

	// Token: 0x0400115B RID: 4443
	[global::Cpp2ILInjected.Token(Token = "0x4001610")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Color ReforgeBackingColour;

	// Token: 0x0400115C RID: 4444
	[global::Cpp2ILInjected.Token(Token = "0x4001611")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public Color ReforgeSelectedBackingColour;

	// Token: 0x0400115D RID: 4445
	[global::Cpp2ILInjected.Token(Token = "0x4001612")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color ResearchBackingColour;

	// Token: 0x0400115E RID: 4446
	[global::Cpp2ILInjected.Token(Token = "0x4001613")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public Color ResearchSelectedBackingColour;

	// Token: 0x0400115F RID: 4447
	[global::Cpp2ILInjected.Token(Token = "0x4001614")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Color PVPBackingColour;

	// Token: 0x04001160 RID: 4448
	[global::Cpp2ILInjected.Token(Token = "0x4001615")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	public Color PVPSelectedBackingColour;

	// Token: 0x04001161 RID: 4449
	[global::Cpp2ILInjected.Token(Token = "0x4001616")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color ChestBackingColour;

	// Token: 0x04001162 RID: 4450
	[global::Cpp2ILInjected.Token(Token = "0x4001617")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public Color ChestSelectedBackingColour;

	// Token: 0x04001163 RID: 4451
	[global::Cpp2ILInjected.Token(Token = "0x4001618")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Color BankBackingColour;

	// Token: 0x04001164 RID: 4452
	[global::Cpp2ILInjected.Token(Token = "0x4001619")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public Color BankSelectedBackingColour;

	// Token: 0x04001165 RID: 4453
	[global::Cpp2ILInjected.Token(Token = "0x400161A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Color ChatBackingColour;

	// Token: 0x04001166 RID: 4454
	[global::Cpp2ILInjected.Token(Token = "0x400161B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public Color ChatSelectedBackingColour;

	// Token: 0x04001167 RID: 4455
	[global::Cpp2ILInjected.Token(Token = "0x400161C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Color EquipmentBackingColour;

	// Token: 0x04001168 RID: 4456
	[global::Cpp2ILInjected.Token(Token = "0x400161D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	public Color EquipmentSelectedBackingColour;

	// Token: 0x04001169 RID: 4457
	[global::Cpp2ILInjected.Token(Token = "0x400161E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Color HousingBackingColour;

	// Token: 0x0400116A RID: 4458
	[global::Cpp2ILInjected.Token(Token = "0x400161F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
	public Color HousingSelectedBackingColour;

	// Token: 0x0400116B RID: 4459
	[global::Cpp2ILInjected.Token(Token = "0x4001620")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Color ShopBackingColour;

	// Token: 0x0400116C RID: 4460
	[global::Cpp2ILInjected.Token(Token = "0x4001621")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	public Color ShopSelectedBackingColour;

	// Token: 0x0400116D RID: 4461
	[global::Cpp2ILInjected.Token(Token = "0x4001622")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Color DuplicateBackingColour;

	// Token: 0x0400116E RID: 4462
	[global::Cpp2ILInjected.Token(Token = "0x4001623")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	public Color DuplicateSelectedBackingColour;

	// Token: 0x0400116F RID: 4463
	[global::Cpp2ILInjected.Token(Token = "0x4001624")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Color HatRackBackingColour;

	// Token: 0x04001170 RID: 4464
	[global::Cpp2ILInjected.Token(Token = "0x4001625")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	public Color HatRackSelectedBackingColour;

	// Token: 0x04001171 RID: 4465
	[global::Cpp2ILInjected.Token(Token = "0x4001626")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Color DisplayDollBackingColour;

	// Token: 0x04001172 RID: 4466
	[global::Cpp2ILInjected.Token(Token = "0x4001627")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public Color DisplayDollSelectedBackingColour;

	// Token: 0x04001173 RID: 4467
	[global::Cpp2ILInjected.Token(Token = "0x4001628")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Color BankButtonNormalColour;

	// Token: 0x04001174 RID: 4468
	[global::Cpp2ILInjected.Token(Token = "0x4001629")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	public Color BankButtonPressedColour;

	// Token: 0x04001175 RID: 4469
	[global::Cpp2ILInjected.Token(Token = "0x400162A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Color BankButtonDisabledColour;

	// Token: 0x04001176 RID: 4470
	[global::Cpp2ILInjected.Token(Token = "0x400162B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public DraggableItemGrid_Layout Left_ConsoleGrid;

	// Token: 0x04001177 RID: 4471
	[global::Cpp2ILInjected.Token(Token = "0x400162C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public DraggableItemGrid_Layout Left_ConsoleGridCollapsed;

	// Token: 0x04001178 RID: 4472
	[global::Cpp2ILInjected.Token(Token = "0x400162D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public DraggableItemGrid_Layout Left_TouchGrid;

	// Token: 0x04001179 RID: 4473
	[global::Cpp2ILInjected.Token(Token = "0x400162E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public DraggableItemGrid_Layout Left_TouchGridCollapsed;

	// Token: 0x0400117A RID: 4474
	[global::Cpp2ILInjected.Token(Token = "0x400162F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public DraggableItemGrid_Layout Right_ConsoleGrid;

	// Token: 0x0400117B RID: 4475
	[global::Cpp2ILInjected.Token(Token = "0x4001630")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public DraggableItemGrid_Layout Right_ConsoleGridCollapsed;

	// Token: 0x0400117C RID: 4476
	[global::Cpp2ILInjected.Token(Token = "0x4001631")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public DraggableItemGrid_Layout Right_TouchGrid;

	// Token: 0x0400117D RID: 4477
	[global::Cpp2ILInjected.Token(Token = "0x4001632")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public DraggableItemGrid_Layout Right_TouchGridCollapsed;
}
