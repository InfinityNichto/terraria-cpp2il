using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000123 RID: 291
[global::Cpp2ILInjected.Token(Token = "0x200019B")]
public class Chest_Layout : PageControllerLayoutDefinition<Chest_Layout>
{
	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00023A47 File Offset: 0x00021C47
	[global::Cpp2ILInjected.Token(Token = "0x17000123")]
	public ItemGrid_Layout DisplayChestGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B63")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AC504", Offset = "0x9AC504", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "GetGrid", ReturnType = typeof(ItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "DrawSlots", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x00023A4A File Offset: 0x00021C4A
	[global::Cpp2ILInjected.Token(Token = "0x6000B64")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC570", Offset = "0x9AC570", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Chest_Layout()
	{
		throw null;
	}

	// Token: 0x040009B3 RID: 2483
	[global::Cpp2ILInjected.Token(Token = "0x4000CD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x040009B4 RID: 2484
	[global::Cpp2ILInjected.Token(Token = "0x4000CD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout TitleController;

	// Token: 0x040009B5 RID: 2485
	[global::Cpp2ILInjected.Token(Token = "0x4000CD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout TitleTouch;

	// Token: 0x040009B6 RID: 2486
	[global::Cpp2ILInjected.Token(Token = "0x4000CD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float ItemScale;

	// Token: 0x040009B7 RID: 2487
	[global::Cpp2ILInjected.Token(Token = "0x4000CD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float ItemHighlightScale;

	// Token: 0x040009B8 RID: 2488
	[global::Cpp2ILInjected.Token(Token = "0x4000CDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout ChestGrid;

	// Token: 0x040009B9 RID: 2489
	[global::Cpp2ILInjected.Token(Token = "0x4000CDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout HorizontalChestGrid;

	// Token: 0x040009BA RID: 2490
	[global::Cpp2ILInjected.Token(Token = "0x4000CDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public PopoutMenu_Layout Menu;

	// Token: 0x040009BB RID: 2491
	[global::Cpp2ILInjected.Token(Token = "0x4000CDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout ChestRename;

	// Token: 0x040009BC RID: 2492
	[global::Cpp2ILInjected.Token(Token = "0x4000CDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout ChestRename_Horizontal;

	// Token: 0x040009BD RID: 2493
	[global::Cpp2ILInjected.Token(Token = "0x4000CDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ChestRestock;

	// Token: 0x040009BE RID: 2494
	[global::Cpp2ILInjected.Token(Token = "0x4000CE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout ChestRestock_Horizontal;

	// Token: 0x040009BF RID: 2495
	[global::Cpp2ILInjected.Token(Token = "0x4000CE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout ChestQuickStack;

	// Token: 0x040009C0 RID: 2496
	[global::Cpp2ILInjected.Token(Token = "0x4000CE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout ChestDepositAll;

	// Token: 0x040009C1 RID: 2497
	[global::Cpp2ILInjected.Token(Token = "0x4000CE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout ChestDepositAll_Horizontal;

	// Token: 0x040009C2 RID: 2498
	[global::Cpp2ILInjected.Token(Token = "0x4000CE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout ChestLootAll;

	// Token: 0x040009C3 RID: 2499
	[global::Cpp2ILInjected.Token(Token = "0x4000CE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout ChestLootAll_Horizontal;

	// Token: 0x040009C4 RID: 2500
	[global::Cpp2ILInjected.Token(Token = "0x4000CE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout LootButton;

	// Token: 0x040009C5 RID: 2501
	[global::Cpp2ILInjected.Token(Token = "0x4000CE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout Favorite;
}
