using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x0200008C RID: 140
[global::Cpp2ILInjected.Token(Token = "0x20000C5")]
public class GUIControllerEquipment4Page : GUIControllerEquipment
{
	// Token: 0x0600042E RID: 1070 RVA: 0x000227CF File Offset: 0x000209CF
	[global::Cpp2ILInjected.Token(Token = "0x60004C8")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18128", Offset = "0xB18128", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Equipment_Layout), Member = "get_DisplayInfoAccessories", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private ItemGrid_Layout GetInfoGrid()
	{
		throw null;
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x000227D2 File Offset: 0x000209D2
	[global::Cpp2ILInjected.Token(Token = "0x60004C9")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18170", Offset = "0xB18170", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private int GetInfoCollectionCount()
	{
		throw null;
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x000227D5 File Offset: 0x000209D5
	[global::Cpp2ILInjected.Token(Token = "0x60004CA")]
	[global::Cpp2ILInjected.Address(RVA = "0xB181C0", Offset = "0xB181C0", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetInfoItemScale()
	{
		throw null;
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x000227D8 File Offset: 0x000209D8
	[global::Cpp2ILInjected.Token(Token = "0x60004CB")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18208", Offset = "0xB18208", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Equipment_Layout), Member = "get_DisplayLoadouts", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private ItemGrid_Layout GetLoadoutGrid()
	{
		throw null;
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x000227DB File Offset: 0x000209DB
	[global::Cpp2ILInjected.Token(Token = "0x60004CC")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18250", Offset = "0xB18250", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetLoadoutCollectionCount()
	{
		throw null;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x000227DE File Offset: 0x000209DE
	[global::Cpp2ILInjected.Token(Token = "0x60004CD")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18258", Offset = "0xB18258", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetLoadoutItemScale()
	{
		throw null;
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000434 RID: 1076 RVA: 0x000227E1 File Offset: 0x000209E1
	[global::Cpp2ILInjected.Token(Token = "0x17000087")]
	private GUIControllerPageMenuPopupGridNavigator AccessoryNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004CE")]
		[global::Cpp2ILInjected.Address(RVA = "0xB182A0", Offset = "0xB182A0", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
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

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000435 RID: 1077 RVA: 0x000227E4 File Offset: 0x000209E4
	[global::Cpp2ILInjected.Token(Token = "0x17000088")]
	private GUIControllerPageMenuPopupGridNavigator LoadoutNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004CF")]
		[global::Cpp2ILInjected.Address(RVA = "0xB183F8", Offset = "0xB183F8", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
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

	// Token: 0x06000436 RID: 1078 RVA: 0x000227E7 File Offset: 0x000209E7
	[global::Cpp2ILInjected.Token(Token = "0x60004D0")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18550", Offset = "0xB18550", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "get_AccessoryNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "get_LoadoutNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x000227EA File Offset: 0x000209EA
	[global::Cpp2ILInjected.Token(Token = "0x60004D1")]
	[global::Cpp2ILInjected.Address(RVA = "0xB185A0", Offset = "0xB185A0", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x000227ED File Offset: 0x000209ED
	[global::Cpp2ILInjected.Token(Token = "0x60004D2")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1873C", Offset = "0xB1873C", Length = "0x348")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "get_AccessoryNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "get_LoadoutNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_MenuController", ReturnType = typeof(GUIControllerPageGroup))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateUp", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x000227F0 File Offset: 0x000209F0
	[global::Cpp2ILInjected.Token(Token = "0x60004D3")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18AB0", Offset = "0xB18AB0", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void ClampMenu(bool preferUp = true)
	{
		throw null;
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x000227F3 File Offset: 0x000209F3
	[global::Cpp2ILInjected.Token(Token = "0x60004D4")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18B30", Offset = "0xB18B30", Length = "0x2B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "get_AccessoryNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "get_LoadoutNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "ClampExtraAccessories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x000227F6 File Offset: 0x000209F6
	[global::Cpp2ILInjected.Token(Token = "0x60004D5")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18DE0", Offset = "0xB18DE0", Length = "0xCC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void ClampExtraAccessories()
	{
		throw null;
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x000227F9 File Offset: 0x000209F9
	[global::Cpp2ILInjected.Token(Token = "0x60004D6")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18EAC", Offset = "0xB18EAC", Length = "0xCC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "ClampExtraAccessories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment4Page), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x000227FC File Offset: 0x000209FC
	[global::Cpp2ILInjected.Token(Token = "0x60004D7")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18F78", Offset = "0xB18F78", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerEquipment), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerEquipment4Page()
	{
		throw null;
	}

	// Token: 0x040002D8 RID: 728
	[global::Cpp2ILInjected.Token(Token = "0x400045C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;

	// Token: 0x040002D9 RID: 729
	[global::Cpp2ILInjected.Token(Token = "0x400045D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIControllerPageMenuPopupGridNavigator _loadoutNav;
}
