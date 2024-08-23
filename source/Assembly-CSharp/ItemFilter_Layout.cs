using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200015D RID: 349
[global::Cpp2ILInjected.Token(Token = "0x20001E2")]
public class ItemFilter_Layout : PageControllerLayoutDefinition<ItemFilter_Layout>
{
	// Token: 0x06000B35 RID: 2869 RVA: 0x00023CE4 File Offset: 0x00021EE4
	[global::Cpp2ILInjected.Token(Token = "0x6000C48")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAE6C", Offset = "0x9CAE6C", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public ItemFilter_Layout()
	{
		throw null;
	}

	// Token: 0x04000D3C RID: 3388
	[global::Cpp2ILInjected.Token(Token = "0x400113F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000D3D RID: 3389
	[global::Cpp2ILInjected.Token(Token = "0x4001140")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout Backing_Horizontal;

	// Token: 0x04000D3E RID: 3390
	[global::Cpp2ILInjected.Token(Token = "0x4001141")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout ItemFilters;

	// Token: 0x04000D3F RID: 3391
	[global::Cpp2ILInjected.Token(Token = "0x4001142")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float ItemFilterScale;

	// Token: 0x04000D40 RID: 3392
	[global::Cpp2ILInjected.Token(Token = "0x4001143")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ControllerButtonCollapsed;

	// Token: 0x04000D41 RID: 3393
	[global::Cpp2ILInjected.Token(Token = "0x4001144")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout ControllerButtonExpanded;

	// Token: 0x04000D42 RID: 3394
	[global::Cpp2ILInjected.Token(Token = "0x4001145")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ButtonCollapsed;

	// Token: 0x04000D43 RID: 3395
	[global::Cpp2ILInjected.Token(Token = "0x4001146")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout ButtonExpanded;

	// Token: 0x04000D44 RID: 3396
	[global::Cpp2ILInjected.Token(Token = "0x4001147")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout ButtonCollapsed_Horizontal;

	// Token: 0x04000D45 RID: 3397
	[global::Cpp2ILInjected.Token(Token = "0x4001148")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ButtonExpanded_Horizontal;

	// Token: 0x04000D46 RID: 3398
	[global::Cpp2ILInjected.Token(Token = "0x4001149")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Everything;

	// Token: 0x04000D47 RID: 3399
	[global::Cpp2ILInjected.Token(Token = "0x400114A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Weapon;

	// Token: 0x04000D48 RID: 3400
	[global::Cpp2ILInjected.Token(Token = "0x400114B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Armor;

	// Token: 0x04000D49 RID: 3401
	[global::Cpp2ILInjected.Token(Token = "0x400114C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Vanity;

	// Token: 0x04000D4A RID: 3402
	[global::Cpp2ILInjected.Token(Token = "0x400114D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout BuildingBlock;

	// Token: 0x04000D4B RID: 3403
	[global::Cpp2ILInjected.Token(Token = "0x400114E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout Furniture;

	// Token: 0x04000D4C RID: 3404
	[global::Cpp2ILInjected.Token(Token = "0x400114F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout Accessories;

	// Token: 0x04000D4D RID: 3405
	[global::Cpp2ILInjected.Token(Token = "0x4001150")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout Equipment;

	// Token: 0x04000D4E RID: 3406
	[global::Cpp2ILInjected.Token(Token = "0x4001151")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public TransactionButton_Layout Consumables;

	// Token: 0x04000D4F RID: 3407
	[global::Cpp2ILInjected.Token(Token = "0x4001152")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout Tools;

	// Token: 0x04000D50 RID: 3408
	[global::Cpp2ILInjected.Token(Token = "0x4001153")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout Materials;

	// Token: 0x04000D51 RID: 3409
	[global::Cpp2ILInjected.Token(Token = "0x4001154")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout GameplayItems;

	// Token: 0x04000D52 RID: 3410
	[global::Cpp2ILInjected.Token(Token = "0x4001155")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout Everything_Horizontal;

	// Token: 0x04000D53 RID: 3411
	[global::Cpp2ILInjected.Token(Token = "0x4001156")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout Weapon_Horizontal;

	// Token: 0x04000D54 RID: 3412
	[global::Cpp2ILInjected.Token(Token = "0x4001157")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout Armor_Horizontal;

	// Token: 0x04000D55 RID: 3413
	[global::Cpp2ILInjected.Token(Token = "0x4001158")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout Vanity_Horizontal;

	// Token: 0x04000D56 RID: 3414
	[global::Cpp2ILInjected.Token(Token = "0x4001159")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout BuildingBlock_Horizontal;

	// Token: 0x04000D57 RID: 3415
	[global::Cpp2ILInjected.Token(Token = "0x400115A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout Furniture_Horizontal;

	// Token: 0x04000D58 RID: 3416
	[global::Cpp2ILInjected.Token(Token = "0x400115B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout Accessories_Horizontal;

	// Token: 0x04000D59 RID: 3417
	[global::Cpp2ILInjected.Token(Token = "0x400115C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout Equipment_Horizontal;

	// Token: 0x04000D5A RID: 3418
	[global::Cpp2ILInjected.Token(Token = "0x400115D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public TransactionButton_Layout Consumables_Horizontal;

	// Token: 0x04000D5B RID: 3419
	[global::Cpp2ILInjected.Token(Token = "0x400115E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout Tools_Horizontal;

	// Token: 0x04000D5C RID: 3420
	[global::Cpp2ILInjected.Token(Token = "0x400115F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public TransactionButton_Layout Materials_Horizontal;

	// Token: 0x04000D5D RID: 3421
	[global::Cpp2ILInjected.Token(Token = "0x4001160")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public TransactionButton_Layout GameplayItems_Horizontal;

	// Token: 0x04000D5E RID: 3422
	[global::Cpp2ILInjected.Token(Token = "0x4001161")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Panel_Layout SearchSeperator;

	// Token: 0x04000D5F RID: 3423
	[global::Cpp2ILInjected.Token(Token = "0x4001162")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout BeginSearch;

	// Token: 0x04000D60 RID: 3424
	[global::Cpp2ILInjected.Token(Token = "0x4001163")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout BeginSearch_Horizontal;

	// Token: 0x04000D61 RID: 3425
	[global::Cpp2ILInjected.Token(Token = "0x4001164")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public float TextWrapSize;

	// Token: 0x04000D62 RID: 3426
	[global::Cpp2ILInjected.Token(Token = "0x4001165")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public String_Layout SearchText;

	// Token: 0x04000D63 RID: 3427
	[global::Cpp2ILInjected.Token(Token = "0x4001166")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public String_Layout SearchTextTouch;

	// Token: 0x04000D64 RID: 3428
	[global::Cpp2ILInjected.Token(Token = "0x4001167")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public Color SearchValidTextColor;

	// Token: 0x04000D65 RID: 3429
	[global::Cpp2ILInjected.Token(Token = "0x4001168")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	public Color SearchInvalidTextColor;

	// Token: 0x04000D66 RID: 3430
	[global::Cpp2ILInjected.Token(Token = "0x4001169")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public TransactionButton_Layout Duplication;

	// Token: 0x04000D67 RID: 3431
	[global::Cpp2ILInjected.Token(Token = "0x400116A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public TransactionButton_Layout DuplicationController;

	// Token: 0x04000D68 RID: 3432
	[global::Cpp2ILInjected.Token(Token = "0x400116B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public TransactionButton_Layout Crafting;

	// Token: 0x04000D69 RID: 3433
	[global::Cpp2ILInjected.Token(Token = "0x400116C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public TransactionButton_Layout CraftingController;

	// Token: 0x04000D6A RID: 3434
	[global::Cpp2ILInjected.Token(Token = "0x400116D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public TransactionButton_Layout Duplication_Horizontal;

	// Token: 0x04000D6B RID: 3435
	[global::Cpp2ILInjected.Token(Token = "0x400116E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public TransactionButton_Layout Crafting_Horizontal;
}
