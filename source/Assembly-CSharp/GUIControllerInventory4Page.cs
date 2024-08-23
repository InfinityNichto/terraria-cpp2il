﻿using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000093 RID: 147
[global::Cpp2ILInjected.Token(Token = "0x20000CD")]
public class GUIControllerInventory4Page : GUIControllerInventory
{
	// Token: 0x06000474 RID: 1140 RVA: 0x000228A1 File Offset: 0x00020AA1
	[global::Cpp2ILInjected.Token(Token = "0x600050E")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1CB58", Offset = "0xB1CB58", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_Instance", ReturnType = typeof(BuilderAccToggles_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_ToggleOptionsGrid", ReturnType = typeof(ItemGrid_Layout))]
	private ItemGrid_Layout GetInfoGrid()
	{
		throw null;
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x000228A4 File Offset: 0x00020AA4
	[global::Cpp2ILInjected.Token(Token = "0x600050F")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1CB70", Offset = "0xB1CB70", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuilderAccToggles), Member = "get_ItemCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private int GetInfoCollectionCount()
	{
		throw null;
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x000228A7 File Offset: 0x00020AA7
	[global::Cpp2ILInjected.Token(Token = "0x6000510")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1CBC0", Offset = "0xB1CBC0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float GetInfoItemScale()
	{
		throw null;
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x000228AA File Offset: 0x00020AAA
	[global::Cpp2ILInjected.Token(Token = "0x6000511")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1CBC8", Offset = "0xB1CBC8", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000478 RID: 1144 RVA: 0x000228AD File Offset: 0x00020AAD
	[global::Cpp2ILInjected.Token(Token = "0x1700008E")]
	private GUIControllerPageMenuPopupGridNavigator BuilderToolNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000512")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1CC08", Offset = "0xB1CC08", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator.GetGrid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator.GetCollectionCount), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator.GetItemScale), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GUIPageContentController),
			typeof(GUIControllerPageMenuPopupGridNavigator.GetGrid),
			typeof(GUIControllerPageMenuPopupGridNavigator.GetCollectionCount),
			typeof(GUIControllerPageMenuPopupGridNavigator.GetItemScale)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x000228B0 File Offset: 0x00020AB0
	[global::Cpp2ILInjected.Token(Token = "0x6000513")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1CD60", Offset = "0xB1CD60", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInventory4Page), Member = "get_BuilderToolNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x000228B3 File Offset: 0x00020AB3
	[global::Cpp2ILInjected.Token(Token = "0x6000514")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1CE08", Offset = "0xB1CE08", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void NavigateToItem(int item)
	{
		throw null;
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x000228B6 File Offset: 0x00020AB6
	[global::Cpp2ILInjected.Token(Token = "0x6000515")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1CEEC", Offset = "0xB1CEEC", Length = "0x1DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInventory4Page), Member = "get_BuilderToolNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Coins", ReturnType = typeof(GUIControllerCoins))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_MenuController", ReturnType = typeof(GUIControllerPageGroup))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Trash", ReturnType = typeof(GUIControllerTrash))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x000228B9 File Offset: 0x00020AB9
	[global::Cpp2ILInjected.Token(Token = "0x6000516")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1D0C8", Offset = "0xB1D0C8", Length = "0x348")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInventory4Page), Member = "get_BuilderToolNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x000228BC File Offset: 0x00020ABC
	[global::Cpp2ILInjected.Token(Token = "0x6000517")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1D410", Offset = "0xB1D410", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerInventory4Page()
	{
		throw null;
	}

	// Token: 0x040002EA RID: 746
	[global::Cpp2ILInjected.Token(Token = "0x4000474")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;
}