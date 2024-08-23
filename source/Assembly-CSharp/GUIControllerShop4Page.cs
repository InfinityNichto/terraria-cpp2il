using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000A2 RID: 162
[global::Cpp2ILInjected.Token(Token = "0x20000DD")]
public class GUIControllerShop4Page : GUIControllerShop
{
	// Token: 0x0600051D RID: 1309 RVA: 0x00022A9C File Offset: 0x00020C9C
	[global::Cpp2ILInjected.Token(Token = "0x60005B7")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22FA4", Offset = "0xB22FA4", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private ItemGrid_Layout GetGrid()
	{
		throw null;
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x00022A9F File Offset: 0x00020C9F
	[global::Cpp2ILInjected.Token(Token = "0x60005B8")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23030", Offset = "0xB23030", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetItemScale()
	{
		throw null;
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00022AA2 File Offset: 0x00020CA2
	[global::Cpp2ILInjected.Token(Token = "0x60005B9")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23078", Offset = "0xB23078", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerShop4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "get_InMenu", ReturnType = typeof(bool))]
	public override bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x00022AA5 File Offset: 0x00020CA5
	[global::Cpp2ILInjected.Token(Token = "0x60005BA")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23218", Offset = "0xB23218", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetMenuItemCount()
	{
		throw null;
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x00022AA8 File Offset: 0x00020CA8
	[global::Cpp2ILInjected.Token(Token = "0x60005BB")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23220", Offset = "0xB23220", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetDisplayItemCount()
	{
		throw null;
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000522 RID: 1314 RVA: 0x00022AAB File Offset: 0x00020CAB
	[global::Cpp2ILInjected.Token(Token = "0x170000AA")]
	public GUIControllerStaticGridNavigator GridNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005BC")]
		[global::Cpp2ILInjected.Address(RVA = "0xB2308C", Offset = "0xB2308C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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

	// Token: 0x06000523 RID: 1315 RVA: 0x00022AAE File Offset: 0x00020CAE
	[global::Cpp2ILInjected.Token(Token = "0x60005BD")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23228", Offset = "0xB23228", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerShop4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00022AB1 File Offset: 0x00020CB1
	[global::Cpp2ILInjected.Token(Token = "0x60005BE")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23240", Offset = "0xB23240", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerShop4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00022AB4 File Offset: 0x00020CB4
	[global::Cpp2ILInjected.Token(Token = "0x60005BF")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23278", Offset = "0xB23278", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerShop4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x00022AB7 File Offset: 0x00020CB7
	[global::Cpp2ILInjected.Token(Token = "0x60005C0")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23298", Offset = "0xB23298", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerShop4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x00022ABA File Offset: 0x00020CBA
	[global::Cpp2ILInjected.Token(Token = "0x60005C1")]
	[global::Cpp2ILInjected.Address(RVA = "0xB232B8", Offset = "0xB232B8", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerShop4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00022ABD File Offset: 0x00020CBD
	[global::Cpp2ILInjected.Token(Token = "0x60005C2")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20468", Offset = "0xB20468", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerShop4Page()
	{
		throw null;
	}

	// Token: 0x04000329 RID: 809
	[global::Cpp2ILInjected.Token(Token = "0x40004B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIControllerStaticGridNavigator _gridNav;
}
