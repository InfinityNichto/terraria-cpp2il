using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000082 RID: 130
[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
public class GUIControllerCoins4Page : GUIControllerCoins
{
	// Token: 0x060003D0 RID: 976 RVA: 0x000226B5 File Offset: 0x000208B5
	[global::Cpp2ILInjected.Token(Token = "0x600046A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA892FC", Offset = "0xA892FC", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void NavigateFromInventoryRow(int row)
	{
		throw null;
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x000226B8 File Offset: 0x000208B8
	[global::Cpp2ILInjected.Token(Token = "0x600046B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA89324", Offset = "0xA89324", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x000226BB File Offset: 0x000208BB
	[global::Cpp2ILInjected.Token(Token = "0x600046C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA89348", Offset = "0xA89348", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override int GetInventoryRow()
	{
		throw null;
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x000226BE File Offset: 0x000208BE
	[global::Cpp2ILInjected.Token(Token = "0x600046D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA89354", Offset = "0xA89354", Length = "0x1F8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Trash", ReturnType = typeof(GUIControllerTrash))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Ammo", ReturnType = typeof(GUIControllerAmmo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Inventory", ReturnType = typeof(GUIControllerInventory))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x000226C1 File Offset: 0x000208C1
	[global::Cpp2ILInjected.Token(Token = "0x600046E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8954C", Offset = "0xA8954C", Length = "0x294")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x000226C4 File Offset: 0x000208C4
	[global::Cpp2ILInjected.Token(Token = "0x600046F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA897E0", Offset = "0xA897E0", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerCoins4Page()
	{
		throw null;
	}
}
