using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200009D RID: 157
[global::Cpp2ILInjected.Token(Token = "0x20000D7")]
public class GUIControllerReforge4Page : GUIControllerReforge
{
	// Token: 0x060004EF RID: 1263 RVA: 0x00022A12 File Offset: 0x00020C12
	[global::Cpp2ILInjected.Token(Token = "0x6000589")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21CB4", Offset = "0xB21CB4", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Reforge_Layout), Member = "get_DisplayItemGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private DraggableItemGrid_Layout GetGrid()
	{
		throw null;
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00022A15 File Offset: 0x00020C15
	[global::Cpp2ILInjected.Token(Token = "0x600058A")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21CFC", Offset = "0xB21CFC", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private int GetCollectionCount()
	{
		throw null;
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00022A18 File Offset: 0x00020C18
	[global::Cpp2ILInjected.Token(Token = "0x600058B")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21D5C", Offset = "0xB21D5C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetItemScale()
	{
		throw null;
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00022A1B File Offset: 0x00020C1B
	[global::Cpp2ILInjected.Token(Token = "0x600058C")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21DA4", Offset = "0xB21DA4", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetScrollOffset()
	{
		throw null;
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00022A1E File Offset: 0x00020C1E
	[global::Cpp2ILInjected.Token(Token = "0x600058D")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21DF4", Offset = "0xB21DF4", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void SetScrollOffset(float offset)
	{
		throw null;
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00022A21 File Offset: 0x00020C21
	[global::Cpp2ILInjected.Token(Token = "0x600058E")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21E50", Offset = "0xB21E50", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	public override bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x00022A24 File Offset: 0x00020C24
	[global::Cpp2ILInjected.Token(Token = "0x600058F")]
	[global::Cpp2ILInjected.Address(RVA = "0xB220A4", Offset = "0xB220A4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetMenuItemCount()
	{
		throw null;
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00022A27 File Offset: 0x00020C27
	[global::Cpp2ILInjected.Token(Token = "0x6000590")]
	[global::Cpp2ILInjected.Address(RVA = "0xB220AC", Offset = "0xB220AC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetDisplayItemCount()
	{
		throw null;
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00022A2A File Offset: 0x00020C2A
	[global::Cpp2ILInjected.Token(Token = "0x170000A8")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000591")]
		[global::Cpp2ILInjected.Address(RVA = "0xB21E70", Offset = "0xB21E70", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "Draw", ReturnType = typeof(void))]
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

	// Token: 0x060004F8 RID: 1272 RVA: 0x00022A2D File Offset: 0x00020C2D
	[global::Cpp2ILInjected.Token(Token = "0x6000592")]
	[global::Cpp2ILInjected.Address(RVA = "0xB220B4", Offset = "0xB220B4", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00022A30 File Offset: 0x00020C30
	[global::Cpp2ILInjected.Token(Token = "0x6000593")]
	[global::Cpp2ILInjected.Address(RVA = "0xB220C8", Offset = "0xB220C8", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00022A33 File Offset: 0x00020C33
	[global::Cpp2ILInjected.Token(Token = "0x6000594")]
	[global::Cpp2ILInjected.Address(RVA = "0xB220E4", Offset = "0xB220E4", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00022A36 File Offset: 0x00020C36
	[global::Cpp2ILInjected.Token(Token = "0x6000595")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22118", Offset = "0xB22118", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00022A39 File Offset: 0x00020C39
	[global::Cpp2ILInjected.Token(Token = "0x6000596")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22134", Offset = "0xB22134", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x00022A3C File Offset: 0x00020C3C
	[global::Cpp2ILInjected.Token(Token = "0x6000597")]
	[global::Cpp2ILInjected.Address(RVA = "0xB204F4", Offset = "0xB204F4", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerReforge4Page()
	{
		throw null;
	}

	// Token: 0x04000323 RID: 803
	[global::Cpp2ILInjected.Token(Token = "0x40004AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIControllerDynamicGridNavigator _gridNav;
}
