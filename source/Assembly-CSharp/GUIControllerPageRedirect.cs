using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000099 RID: 153
[global::Cpp2ILInjected.Token(Token = "0x20000D3")]
public class GUIControllerPageRedirect
{
	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060004AF RID: 1199 RVA: 0x00022952 File Offset: 0x00020B52
	[global::Cpp2ILInjected.Token(Token = "0x17000093")]
	public GUIControllerAmmo Ammo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000549")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1C198", Offset = "0xB1C198", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCoins), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCoins4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "NavigateIntoCoinsAmmo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "RefreshInvCursorPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "GetControllerNavigateController", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "ActivateLeftController", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "get_LastActiveLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00022955 File Offset: 0x00020B55
	[global::Cpp2ILInjected.Token(Token = "0x17000094")]
	public GUIControllerCoins Coins
	{
		[global::Cpp2ILInjected.Token(Token = "0x600054A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1C200", Offset = "0xB1C200", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerAmmo), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerAmmo4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "NavigateIntoCoinsAmmo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerTrash4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "RefreshInvCursorPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "GetControllerNavigateController", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "ActivateLeftController", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "get_LastActiveLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00022958 File Offset: 0x00020B58
	[global::Cpp2ILInjected.Token(Token = "0x17000095")]
	public GUIControllerEquipment Equipment
	{
		[global::Cpp2ILInjected.Token(Token = "0x600054B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F270", Offset = "0xB1F270", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0002295B File Offset: 0x00020B5B
	[global::Cpp2ILInjected.Token(Token = "0x17000096")]
	public GUIControllerInventory Inventory
	{
		[global::Cpp2ILInjected.Token(Token = "0x600054C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F2D8", Offset = "0xB1F2D8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerAmmo), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCoins), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCoins4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerTrash), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerTrash4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "RefreshInvCursorPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "GetControllerNavigateController", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "ActivateController", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(GUIPageIcons.Category)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "ActivateLeftController", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "get_LastActiveLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0002295E File Offset: 0x00020B5E
	[global::Cpp2ILInjected.Token(Token = "0x17000097")]
	public GUIControllerHousing Housing
	{
		[global::Cpp2ILInjected.Token(Token = "0x600054D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F340", Offset = "0xB1F340", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NPCOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "PreviousItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NextItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "ActivateLeftController", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawInventoryItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "get_LastActiveLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00022961 File Offset: 0x00020B61
	[global::Cpp2ILInjected.Token(Token = "0x17000098")]
	public GUIControllerPVP PVP
	{
		[global::Cpp2ILInjected.Token(Token = "0x600054E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F3A8", Offset = "0xB1F3A8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "ActivateLeftController", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawInventoryItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "get_LastActiveLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "PlayerOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00022964 File Offset: 0x00020B64
	[global::Cpp2ILInjected.Token(Token = "0x17000099")]
	public GUIControllerShop Shop
	{
		[global::Cpp2ILInjected.Token(Token = "0x600054F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F410", Offset = "0xB1F410", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(GUIPageIcons.Category)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "DrawPurchaseButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00022967 File Offset: 0x00020B67
	[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
	public GUIControllerTrash Trash
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000550")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1C6A4", Offset = "0xB1C6A4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCoins4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "GetControllerNavigateController", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "get_LastActiveLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0002296A File Offset: 0x00020B6A
	[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
	public GUIControllerChest Chest
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000551")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F478", Offset = "0xB1F478", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(GUIPageIcons.Category)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0002296D File Offset: 0x00020B6D
	[global::Cpp2ILInjected.Token(Token = "0x1700009C")]
	public GUIControllerCrafting Crafting
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000552")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F4E0", Offset = "0xB1F4E0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "DrawCraftButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "RefreshGridNav", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawFilter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00022970 File Offset: 0x00020B70
	[global::Cpp2ILInjected.Token(Token = "0x1700009D")]
	public GUIControllerItemDuplication Duplicate
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000553")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F548", Offset = "0xB1F548", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "DrawCraftButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "CraftItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawFilter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060004BA RID: 1210 RVA: 0x00022973 File Offset: 0x00020B73
	[global::Cpp2ILInjected.Token(Token = "0x1700009E")]
	public GUIControllerDisplayDoll DisplayDoll
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000554")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F5B0", Offset = "0xB1F5B0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIDisplayDoll.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(GUIPageIcons.Category)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x060004BB RID: 1211 RVA: 0x00022976 File Offset: 0x00020B76
	[global::Cpp2ILInjected.Token(Token = "0x1700009F")]
	public GUIControllerHatRack HatRack
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000555")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F618", Offset = "0xB1F618", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIHatRack.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(GUIPageIcons.Category)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060004BC RID: 1212 RVA: 0x00022979 File Offset: 0x00020B79
	[global::Cpp2ILInjected.Token(Token = "0x170000A0")]
	public GUIControllerReforge Reforge
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000556")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F680", Offset = "0xB1F680", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(GUIPageIcons.Category)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "DrawReforge", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060004BD RID: 1213 RVA: 0x0002297C File Offset: 0x00020B7C
	[global::Cpp2ILInjected.Token(Token = "0x170000A1")]
	public GUIControllerCraftingGuide CraftingGuide
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000557")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1F6E8", Offset = "0xB1F6E8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetCategoryFromNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(GUIPageIcons.Category))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "GetItemController", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "get_HasFocus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "DrawGuideList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "GuideItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(GUIPageIcons.Category)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x0002297F File Offset: 0x00020B7F
	[global::Cpp2ILInjected.Token(Token = "0x6000558")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1F750", Offset = "0xB1F750", Length = "0x1A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public bool IsPageController(GUIControllerItem item)
	{
		throw null;
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00022982 File Offset: 0x00020B82
	[global::Cpp2ILInjected.Token(Token = "0x6000559")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1F8F4", Offset = "0xB1F8F4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "RefreshRightItems", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "RightOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem GetDefaultRightController()
	{
		throw null;
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00022985 File Offset: 0x00020B85
	[global::Cpp2ILInjected.Token(Token = "0x600055A")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1FB1C", Offset = "0xB1FB1C", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "GetCategoryFromActiveController", ReturnType = typeof(GUIPageIcons.Category))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Chest", ReturnType = typeof(GUIControllerChest))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Crafting", ReturnType = typeof(GUIControllerCrafting))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Duplicate", ReturnType = typeof(GUIControllerItemDuplication))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_HatRack", ReturnType = typeof(GUIControllerHatRack))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_DisplayDoll", ReturnType = typeof(GUIControllerDisplayDoll))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Shop", ReturnType = typeof(GUIControllerShop))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Housing", ReturnType = typeof(GUIControllerHousing))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Reforge", ReturnType = typeof(GUIControllerReforge))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_CraftingGuide", ReturnType = typeof(GUIControllerCraftingGuide))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_PVP", ReturnType = typeof(GUIControllerPVP))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Ammo", ReturnType = typeof(GUIControllerAmmo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Coins", ReturnType = typeof(GUIControllerCoins))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Inventory", ReturnType = typeof(GUIControllerInventory))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Trash", ReturnType = typeof(GUIControllerTrash))]
	public GUIPageIcons.Category GetCategoryFromNavigationItem(GUIControllerItem item)
	{
		throw null;
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00022988 File Offset: 0x00020B88
	[global::Cpp2ILInjected.Token(Token = "0x600055B")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1F94C", Offset = "0xB1F94C", Length = "0x1D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "GetControllerNavigateController", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "ActivateController", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "NavigateFromMenuIntoPage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "PageOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "SortOptionsAndRefresh", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Crafting", ReturnType = typeof(GUIControllerCrafting))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Duplicate", ReturnType = typeof(GUIControllerItemDuplication))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_DisplayDoll", ReturnType = typeof(GUIControllerDisplayDoll))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_CraftingGuide", ReturnType = typeof(GUIControllerCraftingGuide))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Ammo", ReturnType = typeof(GUIControllerAmmo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Chest", ReturnType = typeof(GUIControllerChest))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Shop", ReturnType = typeof(GUIControllerShop))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Housing", ReturnType = typeof(GUIControllerHousing))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_PVP", ReturnType = typeof(GUIControllerPVP))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Reforge", ReturnType = typeof(GUIControllerReforge))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_HatRack", ReturnType = typeof(GUIControllerHatRack))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Inventory", ReturnType = typeof(GUIControllerInventory))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Coins", ReturnType = typeof(GUIControllerCoins))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public GUIControllerItem GetItemController(GUIPageIcons.Category item)
	{
		throw null;
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x0002298B File Offset: 0x00020B8B
	[global::Cpp2ILInjected.Token(Token = "0x600055C")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1FCB0", Offset = "0xB1FCB0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem NavigateIntoEquipment(int itemColumn)
	{
		throw null;
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0002298E File Offset: 0x00020B8E
	[global::Cpp2ILInjected.Token(Token = "0x600055D")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1FCB8", Offset = "0xB1FCB8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem NavigateIntoInteraction(int itemColumn)
	{
		throw null;
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00022991 File Offset: 0x00020B91
	[global::Cpp2ILInjected.Token(Token = "0x600055E")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1A44C", Offset = "0xB1A44C", Length = "0x4EC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerAmmo), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCoins), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Crafting", ReturnType = typeof(GUIControllerCrafting))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_CraftingGuide", ReturnType = typeof(GUIControllerCraftingGuide))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Chest", ReturnType = typeof(GUIControllerChest))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Shop", ReturnType = typeof(GUIControllerShop))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Reforge", ReturnType = typeof(GUIControllerReforge))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Duplicate", ReturnType = typeof(GUIControllerItemDuplication))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_DisplayDoll", ReturnType = typeof(GUIControllerDisplayDoll))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_HatRack", ReturnType = typeof(GUIControllerHatRack))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem NavigateIntoRight(int itemRow)
	{
		throw null;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00022994 File Offset: 0x00020B94
	[global::Cpp2ILInjected.Token(Token = "0x600055F")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1FCC0", Offset = "0xB1FCC0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem NavigateIntoCraftColumn(int itemColumn)
	{
		throw null;
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00022997 File Offset: 0x00020B97
	[global::Cpp2ILInjected.Token(Token = "0x6000560")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1FCC8", Offset = "0xB1FCC8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem NavigateIntoLeftColumn(int itemColumn)
	{
		throw null;
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x0002299A File Offset: 0x00020B9A
	[global::Cpp2ILInjected.Token(Token = "0x6000561")]
	[global::Cpp2ILInjected.Address(RVA = "0xB19A0C", Offset = "0xB19A0C", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChat), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDisplayDoll), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInventory), Member = "NavigateIntoCoinsAmmo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_PVP", ReturnType = typeof(GUIControllerPVP))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Housing", ReturnType = typeof(GUIControllerHousing))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem NavigateIntoLeft(int itemRow)
	{
		throw null;
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x0002299D File Offset: 0x00020B9D
	[global::Cpp2ILInjected.Token(Token = "0x6000562")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1FCD0", Offset = "0xB1FCD0", Length = "0x724")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerAmmo), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerAmmo4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCoins), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCoins4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChest), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChest4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDisplayDoll), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDisplayDoll4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDresser), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide4Page), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChat), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 72)]
	public GUIControllerPageRedirect()
	{
		throw null;
	}

	// Token: 0x040002F6 RID: 758
	[global::Cpp2ILInjected.Token(Token = "0x4000480")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerLeftPageSelector LeftSelector;

	// Token: 0x040002F7 RID: 759
	[global::Cpp2ILInjected.Token(Token = "0x4000481")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIControllerRightPageSelector RightSelector;

	// Token: 0x040002F8 RID: 760
	[global::Cpp2ILInjected.Token(Token = "0x4000482")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public GUIControllerAmmo AmmoNormal;

	// Token: 0x040002F9 RID: 761
	[global::Cpp2ILInjected.Token(Token = "0x4000483")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public GUIControllerAmmo4Page Ammo4Page;

	// Token: 0x040002FA RID: 762
	[global::Cpp2ILInjected.Token(Token = "0x4000484")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerCoins CoinsNormal;

	// Token: 0x040002FB RID: 763
	[global::Cpp2ILInjected.Token(Token = "0x4000485")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public GUIControllerCoins4Page Coins4Page;

	// Token: 0x040002FC RID: 764
	[global::Cpp2ILInjected.Token(Token = "0x4000486")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public GUIControllerEquipment EquipmentNormal;

	// Token: 0x040002FD RID: 765
	[global::Cpp2ILInjected.Token(Token = "0x4000487")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public GUIControllerEquipment4Page Equipment4Page;

	// Token: 0x040002FE RID: 766
	[global::Cpp2ILInjected.Token(Token = "0x4000488")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private GUIControllerInventory InventoryNormal;

	// Token: 0x040002FF RID: 767
	[global::Cpp2ILInjected.Token(Token = "0x4000489")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private GUIControllerInventory4Page Inventory4Page;

	// Token: 0x04000300 RID: 768
	[global::Cpp2ILInjected.Token(Token = "0x400048A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private GUIControllerHousing HousingNormal;

	// Token: 0x04000301 RID: 769
	[global::Cpp2ILInjected.Token(Token = "0x400048B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private GUIControllerHousing4Page Housing4Page;

	// Token: 0x04000302 RID: 770
	[global::Cpp2ILInjected.Token(Token = "0x400048C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private GUIControllerPVP PVPNormal;

	// Token: 0x04000303 RID: 771
	[global::Cpp2ILInjected.Token(Token = "0x400048D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private GUIControllerPVP4Page PVP4Page;

	// Token: 0x04000304 RID: 772
	[global::Cpp2ILInjected.Token(Token = "0x400048E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private GUIControllerShop ShopNormal;

	// Token: 0x04000305 RID: 773
	[global::Cpp2ILInjected.Token(Token = "0x400048F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private GUIControllerShop4Page Shop4Page;

	// Token: 0x04000306 RID: 774
	[global::Cpp2ILInjected.Token(Token = "0x4000490")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private GUIControllerTrash TrashNormal;

	// Token: 0x04000307 RID: 775
	[global::Cpp2ILInjected.Token(Token = "0x4000491")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private GUIControllerTrash4Page Trash4Page;

	// Token: 0x04000308 RID: 776
	[global::Cpp2ILInjected.Token(Token = "0x4000492")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private GUIControllerChest ChestNormal;

	// Token: 0x04000309 RID: 777
	[global::Cpp2ILInjected.Token(Token = "0x4000493")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private GUIControllerChest4Page Chest4Page;

	// Token: 0x0400030A RID: 778
	[global::Cpp2ILInjected.Token(Token = "0x4000494")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private GUIControllerCrafting CraftingNormal;

	// Token: 0x0400030B RID: 779
	[global::Cpp2ILInjected.Token(Token = "0x4000495")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private GUIControllerCrafting4Page Crafting4Page;

	// Token: 0x0400030C RID: 780
	[global::Cpp2ILInjected.Token(Token = "0x4000496")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private GUIControllerItemDuplication DuplicateNormal;

	// Token: 0x0400030D RID: 781
	[global::Cpp2ILInjected.Token(Token = "0x4000497")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private GUIControllerItemDuplication4Page Duplicate4Page;

	// Token: 0x0400030E RID: 782
	[global::Cpp2ILInjected.Token(Token = "0x4000498")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private GUIControllerDisplayDoll DisplayDollNormal;

	// Token: 0x0400030F RID: 783
	[global::Cpp2ILInjected.Token(Token = "0x4000499")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	private GUIControllerDisplayDoll4Page DisplayDoll4Page;

	// Token: 0x04000310 RID: 784
	[global::Cpp2ILInjected.Token(Token = "0x400049A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	private GUIControllerHatRack HatRackNormal;

	// Token: 0x04000311 RID: 785
	[global::Cpp2ILInjected.Token(Token = "0x400049B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	private GUIControllerHatRack4Page HatRack4Page;

	// Token: 0x04000312 RID: 786
	[global::Cpp2ILInjected.Token(Token = "0x400049C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	private GUIControllerReforge ReforgeNormal;

	// Token: 0x04000313 RID: 787
	[global::Cpp2ILInjected.Token(Token = "0x400049D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	private GUIControllerReforge4Page Reforge4Page;

	// Token: 0x04000314 RID: 788
	[global::Cpp2ILInjected.Token(Token = "0x400049E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public GUIControllerResearchPage4Page ResearchPage;

	// Token: 0x04000315 RID: 789
	[global::Cpp2ILInjected.Token(Token = "0x400049F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public GUIControllerDresser Dresser;

	// Token: 0x04000316 RID: 790
	[global::Cpp2ILInjected.Token(Token = "0x40004A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public GUIControllerHairStylist Hair;

	// Token: 0x04000317 RID: 791
	[global::Cpp2ILInjected.Token(Token = "0x40004A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	private GUIControllerCraftingGuide CraftingGuideNormal;

	// Token: 0x04000318 RID: 792
	[global::Cpp2ILInjected.Token(Token = "0x40004A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	private GUIControllerCraftingGuide4Page CraftingGuide4Page;

	// Token: 0x04000319 RID: 793
	[global::Cpp2ILInjected.Token(Token = "0x40004A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public GUIControllerChat Chat;
}
