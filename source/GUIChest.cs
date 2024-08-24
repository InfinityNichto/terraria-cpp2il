using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.UI;
using UnityEngine;

// Token: 0x020000CE RID: 206
[global::Cpp2ILInjected.Token(Token = "0x2000129")]
public class GUIChest
{
	// Token: 0x060006B8 RID: 1720 RVA: 0x00022F6D File Offset: 0x0002116D
	[global::Cpp2ILInjected.Token(Token = "0x60007AB")]
	[global::Cpp2ILInjected.Address(RVA = "0x1324318", Offset = "0x1324318", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public GUIChest()
	{
		throw null;
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00022F70 File Offset: 0x00021170
	[global::Cpp2ILInjected.Token(Token = "0x60007AC")]
	[global::Cpp2ILInjected.Address(RVA = "0x1324480", Offset = "0x1324480", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "LoadPageRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest_Layout), Member = "get_DisplayChestGrid", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "set_PageContentRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void LoadPageRegion()
	{
		throw null;
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00022F73 File Offset: 0x00021173
	[global::Cpp2ILInjected.Token(Token = "0x60007AD")]
	[global::Cpp2ILInjected.Address(RVA = "0x1324524", Offset = "0x1324524", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChestSplitStack), Member = "Open", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChestSplitStack), Member = "RefreshItemToSplit", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChestSplitStack), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "get_CanLootAll", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestLoot", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestFavourite", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public Item GetSelectedItem()
	{
		throw null;
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00022F76 File Offset: 0x00021176
	[global::Cpp2ILInjected.Token(Token = "0x60007AE")]
	[global::Cpp2ILInjected.Address(RVA = "0x1324608", Offset = "0x1324608", Length = "0x1C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void EquipChestItem()
	{
		throw null;
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00022F79 File Offset: 0x00021179
	[global::Cpp2ILInjected.Token(Token = "0x60007AF")]
	[global::Cpp2ILInjected.Address(RVA = "0x13247C8", Offset = "0x13247C8", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChestSplitStack), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(NetworkText),
		typeof(int),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void UpdateSelectedItem()
	{
		throw null;
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060006BD RID: 1725 RVA: 0x00022F7C File Offset: 0x0002117C
	[global::Cpp2ILInjected.Token(Token = "0x170000D0")]
	public bool collapsed
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x13248AC", Offset = "0x13248AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00022F7F File Offset: 0x0002117F
	[global::Cpp2ILInjected.Token(Token = "0x60007B1")]
	[global::Cpp2ILInjected.Address(RVA = "0x13248B4", Offset = "0x13248B4", Length = "0x20C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "get_ActiveCulture", ReturnType = typeof(GameCulture))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(char),
		typeof(char)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void RefreshLangStrings()
	{
		throw null;
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060006BF RID: 1727 RVA: 0x00022F82 File Offset: 0x00021182
	[global::Cpp2ILInjected.Token(Token = "0x170000D1")]
	public bool HasFocus
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1324AC0", Offset = "0x1324AC0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChestSplitStack), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestSort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestRestock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestLootAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestRename", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestLoot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Chest", ReturnType = typeof(GUIControllerChest))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00022F85 File Offset: 0x00021185
	[global::Cpp2ILInjected.Token(Token = "0x60007B3")]
	[global::Cpp2ILInjected.Address(RVA = "0x1324B48", Offset = "0x1324B48", Length = "0x240")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawPageContent", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Chest", ReturnType = typeof(GUIControllerChest))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "DrawName", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "DrawSlots", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00022F88 File Offset: 0x00021188
	[global::Cpp2ILInjected.Token(Token = "0x60007B4")]
	[global::Cpp2ILInjected.Address(RVA = "0x1325240", Offset = "0x1325240", Length = "0x544")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "DrawName", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetItemNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_editChest", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcChatText", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
	public string GetName()
	{
		throw null;
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00022F8B File Offset: 0x0002118B
	[global::Cpp2ILInjected.Token(Token = "0x60007B5")]
	[global::Cpp2ILInjected.Address(RVA = "0x1325784", Offset = "0x1325784", Length = "0x3D4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "GetPageString", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "RightDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetItemNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
	public string GetTitle()
	{
		throw null;
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00022F8E File Offset: 0x0002118E
	[global::Cpp2ILInjected.Token(Token = "0x60007B6")]
	[global::Cpp2ILInjected.Address(RVA = "0x1324D88", Offset = "0x1324D88", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "GetName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void DrawName(SpriteBatch spritebatch)
	{
		throw null;
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00022F91 File Offset: 0x00021191
	[global::Cpp2ILInjected.Token(Token = "0x60007B7")]
	[global::Cpp2ILInjected.Address(RVA = "0x132523C", Offset = "0x132523C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void DrawButtons(SpriteBatch spritebatch)
	{
		throw null;
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00022F94 File Offset: 0x00021194
	[global::Cpp2ILInjected.Token(Token = "0x60007B8")]
	[global::Cpp2ILInjected.Address(RVA = "0x1325B58", Offset = "0x1325B58", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float ItemScale(int index)
	{
		throw null;
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00022F97 File Offset: 0x00021197
	[global::Cpp2ILInjected.Token(Token = "0x60007B9")]
	[global::Cpp2ILInjected.Address(RVA = "0x1325BA0", Offset = "0x1325BA0", Length = "0xA5C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyDown", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "GetSelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_HoldingItem", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_IsItemDropped", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Chest", ReturnType = typeof(GUIControllerChest))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChest4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorOverride", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "TakeOne", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
	public void ItemOver(int index)
	{
		throw null;
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00022F9A File Offset: 0x0002119A
	[global::Cpp2ILInjected.Token(Token = "0x60007BA")]
	[global::Cpp2ILInjected.Address(RVA = "0x1326604", Offset = "0x1326604", Length = "0x4C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Chest", ReturnType = typeof(GUIControllerChest))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00022F9D File Offset: 0x0002119D
	[global::Cpp2ILInjected.Token(Token = "0x60007BB")]
	[global::Cpp2ILInjected.Address(RVA = "0x1324E78", Offset = "0x1324E78", Length = "0x3C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest_Layout), Member = "get_DisplayChestGrid", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private void DrawSlots(SpriteBatch spriteBatch)
	{
		throw null;
	}

	// Token: 0x0400042F RID: 1071
	[global::Cpp2ILInjected.Token(Token = "0x4000633")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public float scrollOffset;

	// Token: 0x04000430 RID: 1072
	[global::Cpp2ILInjected.Token(Token = "0x4000634")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float scrollMomentum;

	// Token: 0x04000431 RID: 1073
	[global::Cpp2ILInjected.Token(Token = "0x4000635")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int scrollDragging;

	// Token: 0x04000432 RID: 1074
	[global::Cpp2ILInjected.Token(Token = "0x4000636")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private Microsoft.Xna.Framework.Vector2 dragOffset;

	// Token: 0x04000433 RID: 1075
	[global::Cpp2ILInjected.Token(Token = "0x4000637")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int itemSelected;

	// Token: 0x04000434 RID: 1076
	[global::Cpp2ILInjected.Token(Token = "0x4000638")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private int itemOver;

	// Token: 0x04000435 RID: 1077
	[global::Cpp2ILInjected.Token(Token = "0x4000639")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private int itemDragStart;

	// Token: 0x04000436 RID: 1078
	[global::Cpp2ILInjected.Token(Token = "0x400063A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private int cursorOver;

	// Token: 0x04000437 RID: 1079
	[global::Cpp2ILInjected.Token(Token = "0x400063B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private int lastLang;

	// Token: 0x04000438 RID: 1080
	[global::Cpp2ILInjected.Token(Token = "0x400063C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public string[] options;

	// Token: 0x04000439 RID: 1081
	[global::Cpp2ILInjected.Token(Token = "0x400063D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private int lastItemClicked;

	// Token: 0x0400043A RID: 1082
	[global::Cpp2ILInjected.Token(Token = "0x400063E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float doubleClickTimer;

	// Token: 0x0400043B RID: 1083
	[global::Cpp2ILInjected.Token(Token = "0x400063F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private bool rightClickHeld;

	// Token: 0x0400043C RID: 1084
	[global::Cpp2ILInjected.Token(Token = "0x4000640")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private float LootButtonScale;

	// Token: 0x0400043D RID: 1085
	[global::Cpp2ILInjected.Token(Token = "0x4000641")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private bool canLoot;

	// Token: 0x0400043E RID: 1086
	[global::Cpp2ILInjected.Token(Token = "0x4000642")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
	private bool canLootAll;

	// Token: 0x0400043F RID: 1087
	[global::Cpp2ILInjected.Token(Token = "0x4000643")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x52")]
	private bool canDepositAll;

	// Token: 0x04000440 RID: 1088
	[global::Cpp2ILInjected.Token(Token = "0x4000644")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x53")]
	public bool menuOpen;

	// Token: 0x04000441 RID: 1089
	[global::Cpp2ILInjected.Token(Token = "0x4000645")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private float menuButtonScale;

	// Token: 0x04000442 RID: 1090
	[global::Cpp2ILInjected.Token(Token = "0x4000646")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private float[] buttonScale;

	// Token: 0x04000443 RID: 1091
	[global::Cpp2ILInjected.Token(Token = "0x4000647")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private Rectangle menuRegion;

	// Token: 0x04000444 RID: 1092
	[global::Cpp2ILInjected.Token(Token = "0x4000648")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private Item[] dummySlots;

	// Token: 0x04000445 RID: 1093
	[global::Cpp2ILInjected.Token(Token = "0x4000649")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private GUIItemGrid.GetItemScaleHandler itemScaleHandler;

	// Token: 0x04000446 RID: 1094
	[global::Cpp2ILInjected.Token(Token = "0x400064A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private GUIItemGrid.CursorOver itemOverHandler;

	// Token: 0x04000447 RID: 1095
	[global::Cpp2ILInjected.Token(Token = "0x400064B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private GUIItemGrid.DrawItemHandler itemDrawHandler;
}
