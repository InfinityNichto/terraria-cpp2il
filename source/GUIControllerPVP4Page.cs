using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200009B RID: 155
[global::Cpp2ILInjected.Token(Token = "0x20000D5")]
public class GUIControllerPVP4Page : GUIControllerPVP
{
	// Token: 0x060004D3 RID: 1235 RVA: 0x000229BE File Offset: 0x00020BBE
	[global::Cpp2ILInjected.Token(Token = "0x600056D")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20E5C", Offset = "0xB20E5C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PVPIcons_Layout), Member = "get_Grid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private DraggableItemGrid_Layout GetGrid()
	{
		throw null;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x000229C1 File Offset: 0x00020BC1
	[global::Cpp2ILInjected.Token(Token = "0x600056E")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20EA4", Offset = "0xB20EA4", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPVP4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x000229C4 File Offset: 0x00020BC4
	[global::Cpp2ILInjected.Token(Token = "0x600056F")]
	[global::Cpp2ILInjected.Address(RVA = "0xB210F4", Offset = "0xB210F4", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private int GetCollectionCount()
	{
		throw null;
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x000229C7 File Offset: 0x00020BC7
	[global::Cpp2ILInjected.Token(Token = "0x6000570")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21144", Offset = "0xB21144", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetItemScale()
	{
		throw null;
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x000229CA File Offset: 0x00020BCA
	[global::Cpp2ILInjected.Token(Token = "0x6000571")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2118C", Offset = "0xB2118C", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetScrollOffset()
	{
		throw null;
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x000229CD File Offset: 0x00020BCD
	[global::Cpp2ILInjected.Token(Token = "0x6000572")]
	[global::Cpp2ILInjected.Address(RVA = "0xB211DC", Offset = "0xB211DC", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void SetScrollOffset(float offset)
	{
		throw null;
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x000229D0 File Offset: 0x00020BD0
	[global::Cpp2ILInjected.Token(Token = "0x6000573")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21238", Offset = "0xB21238", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPVP4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	public override bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x000229D3 File Offset: 0x00020BD3
	[global::Cpp2ILInjected.Token(Token = "0x6000574")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21258", Offset = "0xB21258", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private int GetMenuItemCount()
	{
		throw null;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x000229D6 File Offset: 0x00020BD6
	[global::Cpp2ILInjected.Token(Token = "0x6000575")]
	[global::Cpp2ILInjected.Address(RVA = "0xB212D0", Offset = "0xB212D0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetDisplayItemCount()
	{
		throw null;
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060004DC RID: 1244 RVA: 0x000229D9 File Offset: 0x00020BD9
	[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000576")]
		[global::Cpp2ILInjected.Address(RVA = "0xB20EC0", Offset = "0xB20EC0", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
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

	// Token: 0x060004DD RID: 1245 RVA: 0x000229DC File Offset: 0x00020BDC
	[global::Cpp2ILInjected.Token(Token = "0x6000577")]
	[global::Cpp2ILInjected.Address(RVA = "0xB212D8", Offset = "0xB212D8", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PVPIcons_Layout), Member = "get_TeamGridLayout", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private ItemGrid_Layout GetTeamGrid()
	{
		throw null;
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x000229DF File Offset: 0x00020BDF
	[global::Cpp2ILInjected.Token(Token = "0x6000578")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21320", Offset = "0xB21320", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetTeamCollectionCount()
	{
		throw null;
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x000229E2 File Offset: 0x00020BE2
	[global::Cpp2ILInjected.Token(Token = "0x6000579")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21328", Offset = "0xB21328", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetTeamItemScale()
	{
		throw null;
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060004E0 RID: 1248 RVA: 0x000229E5 File Offset: 0x00020BE5
	[global::Cpp2ILInjected.Token(Token = "0x170000A5")]
	private GUIControllerPageMenuPopupGridNavigator TeamNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x600057A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB21370", Offset = "0xB21370", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
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

	// Token: 0x060004E1 RID: 1249 RVA: 0x000229E8 File Offset: 0x00020BE8
	[global::Cpp2ILInjected.Token(Token = "0x600057B")]
	[global::Cpp2ILInjected.Address(RVA = "0xB214C8", Offset = "0xB214C8", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPVP4Page), Member = "get_TeamNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPVP4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x000229EB File Offset: 0x00020BEB
	[global::Cpp2ILInjected.Token(Token = "0x600057C")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21560", Offset = "0xB21560", Length = "0x178")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPVP4Page), Member = "get_TeamNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPVP4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x000229EE File Offset: 0x00020BEE
	[global::Cpp2ILInjected.Token(Token = "0x600057D")]
	[global::Cpp2ILInjected.Address(RVA = "0xB216D8", Offset = "0xB216D8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected override void ClampPosition()
	{
		throw null;
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x000229F1 File Offset: 0x00020BF1
	[global::Cpp2ILInjected.Token(Token = "0x600057E")]
	[global::Cpp2ILInjected.Address(RVA = "0xB216DC", Offset = "0xB216DC", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPVP4Page), Member = "get_TeamNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPVP4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x000229F4 File Offset: 0x00020BF4
	[global::Cpp2ILInjected.Token(Token = "0x600057F")]
	[global::Cpp2ILInjected.Address(RVA = "0xB217F4", Offset = "0xB217F4", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPVP4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x000229F7 File Offset: 0x00020BF7
	[global::Cpp2ILInjected.Token(Token = "0x6000580")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20420", Offset = "0xB20420", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerPVP4Page()
	{
		throw null;
	}

	// Token: 0x0400031E RID: 798
	[global::Cpp2ILInjected.Token(Token = "0x40004A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIControllerDynamicGridNavigator _gridNav;

	// Token: 0x0400031F RID: 799
	[global::Cpp2ILInjected.Token(Token = "0x40004A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private int selectedButton;

	// Token: 0x04000320 RID: 800
	[global::Cpp2ILInjected.Token(Token = "0x40004AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private GUIControllerPageMenuPopupGridNavigator _teamNav;
}
