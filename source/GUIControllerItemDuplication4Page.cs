using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000095 RID: 149
[global::Cpp2ILInjected.Token(Token = "0x20000CF")]
public class GUIControllerItemDuplication4Page : GUIControllerItemDuplication
{
	// Token: 0x06000488 RID: 1160 RVA: 0x000228DD File Offset: 0x00020ADD
	[global::Cpp2ILInjected.Token(Token = "0x6000522")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1DF84", Offset = "0xB1DF84", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Crafting_Layout), Member = "get_DuplicateGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private DraggableItemGrid_Layout GetGrid()
	{
		throw null;
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x000228E0 File Offset: 0x00020AE0
	[global::Cpp2ILInjected.Token(Token = "0x6000523")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1DFCC", Offset = "0xB1DFCC", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private int GetCollectionCount()
	{
		throw null;
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x000228E3 File Offset: 0x00020AE3
	[global::Cpp2ILInjected.Token(Token = "0x6000524")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E02C", Offset = "0xB1E02C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetItemScale()
	{
		throw null;
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x000228E6 File Offset: 0x00020AE6
	[global::Cpp2ILInjected.Token(Token = "0x6000525")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E074", Offset = "0xB1E074", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetScrollOffset()
	{
		throw null;
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x000228E9 File Offset: 0x00020AE9
	[global::Cpp2ILInjected.Token(Token = "0x6000526")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E0C4", Offset = "0xB1E0C4", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void SetScrollOffset(float offset)
	{
		throw null;
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x000228EC File Offset: 0x00020AEC
	[global::Cpp2ILInjected.Token(Token = "0x6000527")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E120", Offset = "0xB1E120", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	public override bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x000228EF File Offset: 0x00020AEF
	[global::Cpp2ILInjected.Token(Token = "0x6000528")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E374", Offset = "0xB1E374", Length = "0xC8")]
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

	// Token: 0x0600048F RID: 1167 RVA: 0x000228F2 File Offset: 0x00020AF2
	[global::Cpp2ILInjected.Token(Token = "0x6000529")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E43C", Offset = "0xB1E43C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetDisplayItemCount()
	{
		throw null;
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000490 RID: 1168 RVA: 0x000228F5 File Offset: 0x00020AF5
	[global::Cpp2ILInjected.Token(Token = "0x17000091")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x600052A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1E140", Offset = "0xB1E140", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x000228F8 File Offset: 0x00020AF8
	[global::Cpp2ILInjected.Token(Token = "0x600052B")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E444", Offset = "0xB1E444", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x000228FB File Offset: 0x00020AFB
	[global::Cpp2ILInjected.Token(Token = "0x600052C")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E458", Offset = "0xB1E458", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x000228FE File Offset: 0x00020AFE
	[global::Cpp2ILInjected.Token(Token = "0x600052D")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E474", Offset = "0xB1E474", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	public override void RefreshScrollOffset()
	{
		throw null;
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00022901 File Offset: 0x00020B01
	[global::Cpp2ILInjected.Token(Token = "0x600052E")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E6F0", Offset = "0xB1E6F0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected override void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00022904 File Offset: 0x00020B04
	[global::Cpp2ILInjected.Token(Token = "0x600052F")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E6F4", Offset = "0xB1E6F4", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00022907 File Offset: 0x00020B07
	[global::Cpp2ILInjected.Token(Token = "0x6000530")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E728", Offset = "0xB1E728", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected override void ClampPosition()
	{
		throw null;
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x0002290A File Offset: 0x00020B0A
	[global::Cpp2ILInjected.Token(Token = "0x6000531")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E72C", Offset = "0xB1E72C", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x0002290D File Offset: 0x00020B0D
	[global::Cpp2ILInjected.Token(Token = "0x6000532")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E748", Offset = "0xB1E748", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemDuplication4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00022910 File Offset: 0x00020B10
	[global::Cpp2ILInjected.Token(Token = "0x6000533")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E770", Offset = "0xB1E770", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerItemDuplication4Page()
	{
		throw null;
	}

	// Token: 0x040002EE RID: 750
	[global::Cpp2ILInjected.Token(Token = "0x4000478")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIControllerDynamicGridNavigator _gridNav;
}
