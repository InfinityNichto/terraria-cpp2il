using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000084 RID: 132
[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
public class GUIControllerCrafting4Page : GUIControllerCrafting
{
	// Token: 0x060003E0 RID: 992 RVA: 0x000226E5 File Offset: 0x000208E5
	[global::Cpp2ILInjected.Token(Token = "0x600047A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A3A4", Offset = "0xA8A3A4", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Crafting_Layout), Member = "get_CraftGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private DraggableItemGrid_Layout GetGrid()
	{
		throw null;
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x000226E8 File Offset: 0x000208E8
	[global::Cpp2ILInjected.Token(Token = "0x600047B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A3EC", Offset = "0xA8A3EC", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private int GetCollectionCount()
	{
		throw null;
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x000226EB File Offset: 0x000208EB
	[global::Cpp2ILInjected.Token(Token = "0x600047C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A44C", Offset = "0xA8A44C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetItemScale()
	{
		throw null;
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x000226EE File Offset: 0x000208EE
	[global::Cpp2ILInjected.Token(Token = "0x600047D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A494", Offset = "0xA8A494", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetScrollOffset()
	{
		throw null;
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x000226F1 File Offset: 0x000208F1
	[global::Cpp2ILInjected.Token(Token = "0x600047E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A4E4", Offset = "0xA8A4E4", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void SetScrollOffset(float offset)
	{
		throw null;
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x000226F4 File Offset: 0x000208F4
	[global::Cpp2ILInjected.Token(Token = "0x600047F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A540", Offset = "0xA8A540", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_InMenu", ReturnType = typeof(bool))]
	public override bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x000226F7 File Offset: 0x000208F7
	[global::Cpp2ILInjected.Token(Token = "0x6000480")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A7B0", Offset = "0xA8A7B0", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GameMode", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "GetCategoryGrouping", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private int GetMenuItemCount()
	{
		throw null;
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x000226FA File Offset: 0x000208FA
	[global::Cpp2ILInjected.Token(Token = "0x6000481")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A878", Offset = "0xA8A878", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetDisplayItemCount()
	{
		throw null;
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000226FD File Offset: 0x000208FD
	[global::Cpp2ILInjected.Token(Token = "0x17000082")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000482")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8A554", Offset = "0xA8A554", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "RefreshGridNav", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator.GetGrid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator.GetCollectionCount), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator.GetItemScale), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator.GetScrollOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator.SetScrollOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GUIPageContentController),
			typeof(GUIControllerDynamicGridNavigator.GetGrid),
			typeof(GUIControllerDynamicGridNavigator.GetCollectionCount),
			typeof(GUIControllerDynamicGridNavigator.GetItemScale),
			typeof(GUIControllerDynamicGridNavigator.GetScrollOffset),
			typeof(GUIControllerDynamicGridNavigator.SetScrollOffset),
			typeof(GUIControllerDynamicGridNavigator.GetCollectionCount),
			typeof(GUIControllerDynamicGridNavigator.GetCollectionCount)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00022700 File Offset: 0x00020900
	[global::Cpp2ILInjected.Token(Token = "0x6000483")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A880", Offset = "0xA8A880", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00022703 File Offset: 0x00020903
	[global::Cpp2ILInjected.Token(Token = "0x6000484")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A8A4", Offset = "0xA8A8A4", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00022706 File Offset: 0x00020906
	[global::Cpp2ILInjected.Token(Token = "0x6000485")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A8BC", Offset = "0xA8A8BC", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
	public override void RefreshScrollOffset()
	{
		throw null;
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00022709 File Offset: 0x00020909
	[global::Cpp2ILInjected.Token(Token = "0x6000486")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A8E0", Offset = "0xA8A8E0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected override void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x0002270C File Offset: 0x0002090C
	[global::Cpp2ILInjected.Token(Token = "0x6000487")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A8E4", Offset = "0xA8A8E4", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x0002270F File Offset: 0x0002090F
	[global::Cpp2ILInjected.Token(Token = "0x6000488")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A920", Offset = "0xA8A920", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected override void ClampPosition()
	{
		throw null;
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00022712 File Offset: 0x00020912
	[global::Cpp2ILInjected.Token(Token = "0x6000489")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A924", Offset = "0xA8A924", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00022715 File Offset: 0x00020915
	[global::Cpp2ILInjected.Token(Token = "0x600048A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A948", Offset = "0xA8A948", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCrafting4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00022718 File Offset: 0x00020918
	[global::Cpp2ILInjected.Token(Token = "0x600048B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A984", Offset = "0xA8A984", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerCrafting4Page()
	{
		throw null;
	}

	// Token: 0x040002CC RID: 716
	[global::Cpp2ILInjected.Token(Token = "0x4000442")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIControllerDynamicGridNavigator _gridNav;
}
