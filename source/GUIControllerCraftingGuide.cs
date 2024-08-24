using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000085 RID: 133
[global::Cpp2ILInjected.Token(Token = "0x20000BC")]
public class GUIControllerCraftingGuide : GUIPageContentController
{
	// Token: 0x060003F2 RID: 1010 RVA: 0x0002271B File Offset: 0x0002091B
	[global::Cpp2ILInjected.Token(Token = "0x600048C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A990", Offset = "0xA8A990", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerCraftingGuide()
	{
		throw null;
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x0002271E File Offset: 0x0002091E
	[global::Cpp2ILInjected.Token(Token = "0x600048D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A99C", Offset = "0xA8A99C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CraftGuide_Layout), Member = "get_DisplayGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private DraggableItemGrid_Layout GetGrid()
	{
		throw null;
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00022721 File Offset: 0x00020921
	[global::Cpp2ILInjected.Token(Token = "0x600048E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8A9E4", Offset = "0xA8A9E4", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private int GetCollectionCount()
	{
		throw null;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00022724 File Offset: 0x00020924
	[global::Cpp2ILInjected.Token(Token = "0x600048F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AA44", Offset = "0xA8AA44", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetItemScale()
	{
		throw null;
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00022727 File Offset: 0x00020927
	[global::Cpp2ILInjected.Token(Token = "0x6000490")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AA8C", Offset = "0xA8AA8C", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetScrollOffset()
	{
		throw null;
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x0002272A File Offset: 0x0002092A
	[global::Cpp2ILInjected.Token(Token = "0x6000491")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AADC", Offset = "0xA8AADC", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void SetScrollOffset(float offset)
	{
		throw null;
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x0002272D File Offset: 0x0002092D
	[global::Cpp2ILInjected.Token(Token = "0x6000492")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AB38", Offset = "0xA8AB38", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "DrawGuideList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_InMenu", ReturnType = typeof(bool))]
	public bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00022730 File Offset: 0x00020930
	[global::Cpp2ILInjected.Token(Token = "0x6000493")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8ADA8", Offset = "0xA8ADA8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetMenuItemCount()
	{
		throw null;
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00022733 File Offset: 0x00020933
	[global::Cpp2ILInjected.Token(Token = "0x6000494")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8ADB0", Offset = "0xA8ADB0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetDisplayItemCount()
	{
		throw null;
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060003FB RID: 1019 RVA: 0x00022736 File Offset: 0x00020936
	[global::Cpp2ILInjected.Token(Token = "0x17000083")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000495")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8AB4C", Offset = "0xA8AB4C", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "GuideItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
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

	// Token: 0x060003FC RID: 1020 RVA: 0x00022739 File Offset: 0x00020939
	[global::Cpp2ILInjected.Token(Token = "0x6000496")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8ADB8", Offset = "0xA8ADB8", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x0002273C File Offset: 0x0002093C
	[global::Cpp2ILInjected.Token(Token = "0x6000497")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8ADDC", Offset = "0xA8ADDC", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x0002273F File Offset: 0x0002093F
	[global::Cpp2ILInjected.Token(Token = "0x6000498")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8ADF4", Offset = "0xA8ADF4", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
	public void RefreshScrollOffset()
	{
		throw null;
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00022742 File Offset: 0x00020942
	[global::Cpp2ILInjected.Token(Token = "0x6000499")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AE18", Offset = "0xA8AE18", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00022745 File Offset: 0x00020945
	[global::Cpp2ILInjected.Token(Token = "0x600049A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AE1C", Offset = "0xA8AE1C", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00022748 File Offset: 0x00020948
	[global::Cpp2ILInjected.Token(Token = "0x600049B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AE58", Offset = "0xA8AE58", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected void ClampPosition()
	{
		throw null;
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x0002274B File Offset: 0x0002094B
	[global::Cpp2ILInjected.Token(Token = "0x600049C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AE5C", Offset = "0xA8AE5C", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x0002274E File Offset: 0x0002094E
	[global::Cpp2ILInjected.Token(Token = "0x600049D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8AE80", Offset = "0xA8AE80", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerCraftingGuide), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x040002CD RID: 717
	[global::Cpp2ILInjected.Token(Token = "0x4000443")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private GUIControllerDynamicGridNavigator _gridNav;
}
