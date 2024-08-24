using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000096 RID: 150
[global::Cpp2ILInjected.Token(Token = "0x20000D0")]
public class GUIControllerItemFilter : GUIPageContentController
{
	// Token: 0x0600049A RID: 1178 RVA: 0x00022913 File Offset: 0x00020B13
	[global::Cpp2ILInjected.Token(Token = "0x6000534")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E794", Offset = "0xB1E794", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private ItemGrid_Layout GetInfoGrid()
	{
		throw null;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00022916 File Offset: 0x00020B16
	[global::Cpp2ILInjected.Token(Token = "0x6000535")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E7DC", Offset = "0xB1E7DC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetInfoCollectionCount()
	{
		throw null;
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00022919 File Offset: 0x00020B19
	[global::Cpp2ILInjected.Token(Token = "0x6000536")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E7E4", Offset = "0xB1E7E4", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetInfoItemScale()
	{
		throw null;
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x0600049D RID: 1181 RVA: 0x0002291C File Offset: 0x00020B1C
	[global::Cpp2ILInjected.Token(Token = "0x17000092")]
	private GUIControllerPageMenuPopupGridNavigator AccessoryNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000537")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1E82C", Offset = "0xB1E82C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemFilter), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemFilter), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemFilter), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
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

	// Token: 0x0600049E RID: 1182 RVA: 0x0002291F File Offset: 0x00020B1F
	[global::Cpp2ILInjected.Token(Token = "0x6000538")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E984", Offset = "0xB1E984", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerItemFilter(GUIPageIcons.Category cat)
	{
		throw null;
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00022922 File Offset: 0x00020B22
	[global::Cpp2ILInjected.Token(Token = "0x6000539")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E9B0", Offset = "0xB1E9B0", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemFilter), Member = "get_AccessoryNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00022925 File Offset: 0x00020B25
	[global::Cpp2ILInjected.Token(Token = "0x600053A")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E9C8", Offset = "0xB1E9C8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void NavigateInto(Vector2 source, Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00022928 File Offset: 0x00020B28
	[global::Cpp2ILInjected.Token(Token = "0x600053B")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E9CC", Offset = "0xB1E9CC", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemFilter), Member = "get_AccessoryNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x0002292B File Offset: 0x00020B2B
	[global::Cpp2ILInjected.Token(Token = "0x600053C")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1EA0C", Offset = "0xB1EA0C", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemFilter), Member = "get_AccessoryNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002EF RID: 751
	[global::Cpp2ILInjected.Token(Token = "0x4000479")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;

	// Token: 0x040002F0 RID: 752
	[global::Cpp2ILInjected.Token(Token = "0x400047A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private int selectedRow;

	// Token: 0x040002F1 RID: 753
	[global::Cpp2ILInjected.Token(Token = "0x400047B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private int selectedColumn;

	// Token: 0x040002F2 RID: 754
	[global::Cpp2ILInjected.Token(Token = "0x400047C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private bool selectedSearch;
}
