using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.UI;

// Token: 0x020000E8 RID: 232
[global::Cpp2ILInjected.Token(Token = "0x200014D")]
public class GUIInventoryTransactions
{
	// Token: 0x170000BF RID: 191
	// (get) Token: 0x0600081A RID: 2074 RVA: 0x00023393 File Offset: 0x00021593
	[global::Cpp2ILInjected.Token(Token = "0x170000E4")]
	public Item SelectedItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000914")]
		[global::Cpp2ILInjected.Address(RVA = "0x91B34C", Offset = "0x91B34C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "EquipItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "PlaceItemDoll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "PlaceItemHat", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawSellButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00023396 File Offset: 0x00021596
	[global::Cpp2ILInjected.Token(Token = "0x6000915")]
	[global::Cpp2ILInjected.Address(RVA = "0x91B3E0", Offset = "0x91B3E0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawInventoryPage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x00023399 File Offset: 0x00021599
	[global::Cpp2ILInjected.Token(Token = "0x6000916")]
	[global::Cpp2ILInjected.Address(RVA = "0x91B3E4", Offset = "0x91B3E4", Length = "0x1C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawSellButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_shop", ReturnType = typeof(Chest[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SellItem", MemberParameters = new object[]
	{
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "AddItemToShop", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TurnToAir", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void SellItem()
	{
		throw null;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x0002339C File Offset: 0x0002159C
	[global::Cpp2ILInjected.Token(Token = "0x6000917")]
	[global::Cpp2ILInjected.Address(RVA = "0x91B5A8", Offset = "0x91B5A8", Length = "0x35C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventoryTransactions), Member = "get_SelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SwapEquip", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(ref object),
		typeof(ref object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSource", MemberParameters = new object[] { typeof(Item[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public void EquipItem()
	{
		throw null;
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x0002339F File Offset: 0x0002159F
	[global::Cpp2ILInjected.Token(Token = "0x6000918")]
	[global::Cpp2ILInjected.Address(RVA = "0x91B904", Offset = "0x91B904", Length = "0x278")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "GetTileEntity", ReturnType = typeof(TileEntity))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventoryTransactions), Member = "get_SelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDisplayDoll), Member = "CanBeEquipedAccessory", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void PlaceItemDoll()
	{
		throw null;
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x000233A2 File Offset: 0x000215A2
	[global::Cpp2ILInjected.Token(Token = "0x6000919")]
	[global::Cpp2ILInjected.Address(RVA = "0x91BB7C", Offset = "0x91BB7C", Length = "0x218")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "GetTileEntity", ReturnType = typeof(TileEntity))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventoryTransactions), Member = "get_SelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void PlaceItemHat()
	{
		throw null;
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x000233A5 File Offset: 0x000215A5
	[global::Cpp2ILInjected.Token(Token = "0x600091A")]
	[global::Cpp2ILInjected.Address(RVA = "0x91BD94", Offset = "0x91BD94", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawDepositButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "Deposit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void DepositItem()
	{
		throw null;
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x000233A8 File Offset: 0x000215A8
	[global::Cpp2ILInjected.Token(Token = "0x600091B")]
	[global::Cpp2ILInjected.Address(RVA = "0x915FC8", Offset = "0x915FC8", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIInventoryTransactions()
	{
		throw null;
	}

	// Token: 0x0400062C RID: 1580
	[global::Cpp2ILInjected.Token(Token = "0x4000887")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float sellButtonScale;

	// Token: 0x0400062D RID: 1581
	[global::Cpp2ILInjected.Token(Token = "0x4000888")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float equipButtonScale;

	// Token: 0x0400062E RID: 1582
	[global::Cpp2ILInjected.Token(Token = "0x4000889")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float depositButtonScale;

	// Token: 0x0400062F RID: 1583
	[global::Cpp2ILInjected.Token(Token = "0x400088A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public bool canBeDeposited;
}
