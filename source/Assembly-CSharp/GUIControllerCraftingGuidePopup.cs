using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000087 RID: 135
[global::Cpp2ILInjected.Token(Token = "0x20000BE")]
public class GUIControllerCraftingGuidePopup : GUIControllerItem
{
	// Token: 0x06000405 RID: 1029 RVA: 0x00022754 File Offset: 0x00020954
	[global::Cpp2ILInjected.Token(Token = "0x600049F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AEC8", Offset = "0xA8AEC8", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private DraggableItemGrid_Layout GetGrid()
	{
		throw null;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00022757 File Offset: 0x00020957
	[global::Cpp2ILInjected.Token(Token = "0x60004A0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AF4C", Offset = "0xA8AF4C", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "get_SelectedNumMaterials", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private int GetCollectionCount()
	{
		throw null;
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x0002275A File Offset: 0x0002095A
	[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AFB4", Offset = "0xA8AFB4", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private float GetItemScale()
	{
		throw null;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x0002275D File Offset: 0x0002095D
	[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B038", Offset = "0xA8B038", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetScrollOffset()
	{
		throw null;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00022760 File Offset: 0x00020960
	[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B09C", Offset = "0xA8B09C", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void SetScrollOffset(float offset)
	{
		throw null;
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00022763 File Offset: 0x00020963
	[global::Cpp2ILInjected.Token(Token = "0x60004A4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B10C", Offset = "0xA8B10C", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuidePopup), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_InMenu", ReturnType = typeof(bool))]
	public bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00022766 File Offset: 0x00020966
	[global::Cpp2ILInjected.Token(Token = "0x60004A5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B37C", Offset = "0xA8B37C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetMenuItemCount()
	{
		throw null;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00022769 File Offset: 0x00020969
	[global::Cpp2ILInjected.Token(Token = "0x60004A6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B384", Offset = "0xA8B384", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetDisplayItemCount()
	{
		throw null;
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x0600040D RID: 1037 RVA: 0x0002276C File Offset: 0x0002096C
	[global::Cpp2ILInjected.Token(Token = "0x17000084")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004A7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8B120", Offset = "0xA8B120", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "MaterialItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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

	// Token: 0x0600040E RID: 1038 RVA: 0x0002276F File Offset: 0x0002096F
	[global::Cpp2ILInjected.Token(Token = "0x60004A8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B38C", Offset = "0xA8B38C", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuidePopup), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00022772 File Offset: 0x00020972
	[global::Cpp2ILInjected.Token(Token = "0x60004A9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B3F0", Offset = "0xA8B3F0", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuidePopup), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00022775 File Offset: 0x00020975
	[global::Cpp2ILInjected.Token(Token = "0x60004AA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B408", Offset = "0xA8B408", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuidePopup), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void RefreshScrollOffset()
	{
		throw null;
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00022778 File Offset: 0x00020978
	[global::Cpp2ILInjected.Token(Token = "0x60004AB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B46C", Offset = "0xA8B46C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x0002277B File Offset: 0x0002097B
	[global::Cpp2ILInjected.Token(Token = "0x60004AC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B470", Offset = "0xA8B470", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuidePopup), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuidePopup), Member = "GetCollectionCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuidePopup), Member = "GetGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x0002277E File Offset: 0x0002097E
	[global::Cpp2ILInjected.Token(Token = "0x60004AD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B570", Offset = "0xA8B570", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected void ClampPosition()
	{
		throw null;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00022781 File Offset: 0x00020981
	[global::Cpp2ILInjected.Token(Token = "0x60004AE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B574", Offset = "0xA8B574", Length = "0x13C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "get_SelectedNumMaterials", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuidePopup), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00022784 File Offset: 0x00020984
	[global::Cpp2ILInjected.Token(Token = "0x60004AF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B6B0", Offset = "0xA8B6B0", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuidePopup), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00022787 File Offset: 0x00020987
	[global::Cpp2ILInjected.Token(Token = "0x60004B0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8B72C", Offset = "0xA8B72C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerCraftingGuidePopup()
	{
		throw null;
	}

	// Token: 0x040002CE RID: 718
	[global::Cpp2ILInjected.Token(Token = "0x4000444")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerCraftingGuidePopup.Controls selectedControl;

	// Token: 0x040002CF RID: 719
	[global::Cpp2ILInjected.Token(Token = "0x4000445")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private GUIControllerDynamicGridNavigator _gridNav;

	// Token: 0x02000799 RID: 1945
	[global::Cpp2ILInjected.Token(Token = "0x20000BF")]
	public enum Controls
	{
		// Token: 0x0400795C RID: 31068
		[global::Cpp2ILInjected.Token(Token = "0x4000447")]
		Element,
		// Token: 0x0400795D RID: 31069
		[global::Cpp2ILInjected.Token(Token = "0x4000448")]
		Back
	}
}
