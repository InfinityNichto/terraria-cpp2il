using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000080 RID: 128
[global::Cpp2ILInjected.Token(Token = "0x20000B7")]
public class GUIControllerChest4Page : GUIControllerChest
{
	// Token: 0x060003BE RID: 958 RVA: 0x0002267F File Offset: 0x0002087F
	[global::Cpp2ILInjected.Token(Token = "0x6000458")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88A80", Offset = "0xA88A80", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest_Layout), Member = "get_DisplayChestGrid", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private ItemGrid_Layout GetGrid()
	{
		throw null;
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00022682 File Offset: 0x00020882
	[global::Cpp2ILInjected.Token(Token = "0x6000459")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88AC8", Offset = "0xA88AC8", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetItemScale()
	{
		throw null;
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00022685 File Offset: 0x00020885
	[global::Cpp2ILInjected.Token(Token = "0x600045A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88B10", Offset = "0xA88B10", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChest4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "get_InMenu", ReturnType = typeof(bool))]
	public override bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00022688 File Offset: 0x00020888
	[global::Cpp2ILInjected.Token(Token = "0x600045B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88CB0", Offset = "0xA88CB0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetMenuItemCount()
	{
		throw null;
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x0002268B File Offset: 0x0002088B
	[global::Cpp2ILInjected.Token(Token = "0x600045C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88CB8", Offset = "0xA88CB8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetDisplayItemCount()
	{
		throw null;
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x060003C3 RID: 963 RVA: 0x0002268E File Offset: 0x0002088E
	[global::Cpp2ILInjected.Token(Token = "0x1700007F")]
	public GUIControllerStaticGridNavigator GridNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x600045D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA88B24", Offset = "0xA88B24", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator.GetGrid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator.GetItemScale), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator.GetCollectionCount), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GUIPageContentController),
			typeof(GUIControllerStaticGridNavigator.GetGrid),
			typeof(GUIControllerStaticGridNavigator.GetItemScale),
			typeof(GUIControllerStaticGridNavigator.GetCollectionCount),
			typeof(GUIControllerStaticGridNavigator.GetCollectionCount)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00022691 File Offset: 0x00020891
	[global::Cpp2ILInjected.Token(Token = "0x600045E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88CC0", Offset = "0xA88CC0", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChest4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00022694 File Offset: 0x00020894
	[global::Cpp2ILInjected.Token(Token = "0x600045F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88CE4", Offset = "0xA88CE4", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChest4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00022697 File Offset: 0x00020897
	[global::Cpp2ILInjected.Token(Token = "0x6000460")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88D0C", Offset = "0xA88D0C", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChest4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x0002269A File Offset: 0x0002089A
	[global::Cpp2ILInjected.Token(Token = "0x6000461")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88DA8", Offset = "0xA88DA8", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChest4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x0002269D File Offset: 0x0002089D
	[global::Cpp2ILInjected.Token(Token = "0x6000462")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88E64", Offset = "0xA88E64", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChest4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x000226A0 File Offset: 0x000208A0
	[global::Cpp2ILInjected.Token(Token = "0x6000463")]
	[global::Cpp2ILInjected.Address(RVA = "0xA88EA0", Offset = "0xA88EA0", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerChest4Page()
	{
		throw null;
	}

	// Token: 0x040002C7 RID: 711
	[global::Cpp2ILInjected.Token(Token = "0x400043D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIControllerStaticGridNavigator _gridNav;
}
