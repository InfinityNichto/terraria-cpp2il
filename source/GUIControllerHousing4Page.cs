using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000091 RID: 145
[global::Cpp2ILInjected.Token(Token = "0x20000CB")]
public class GUIControllerHousing4Page : GUIControllerHousing
{
	// Token: 0x0600045A RID: 1114 RVA: 0x00022853 File Offset: 0x00020A53
	[global::Cpp2ILInjected.Token(Token = "0x60004F4")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1AB84", Offset = "0xB1AB84", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HousingMenu_Layout), Member = "get_DisplayNPCGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private DraggableItemGrid_Layout GetGrid()
	{
		throw null;
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00022856 File Offset: 0x00020A56
	[global::Cpp2ILInjected.Token(Token = "0x60004F5")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1ABCC", Offset = "0xB1ABCC", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private int GetCollectionCount()
	{
		throw null;
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00022859 File Offset: 0x00020A59
	[global::Cpp2ILInjected.Token(Token = "0x60004F6")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1AC20", Offset = "0xB1AC20", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetItemScale()
	{
		throw null;
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x0002285C File Offset: 0x00020A5C
	[global::Cpp2ILInjected.Token(Token = "0x60004F7")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1AC68", Offset = "0xB1AC68", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float GetScrollOffset()
	{
		throw null;
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x0002285F File Offset: 0x00020A5F
	[global::Cpp2ILInjected.Token(Token = "0x60004F8")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1ACB8", Offset = "0xB1ACB8", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void SetScrollOffset(float offset)
	{
		throw null;
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00022862 File Offset: 0x00020A62
	[global::Cpp2ILInjected.Token(Token = "0x60004F9")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1AD14", Offset = "0xB1AD14", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NextItem", ReturnType = typeof(void))]
	public override void NextItem()
	{
		throw null;
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00022865 File Offset: 0x00020A65
	[global::Cpp2ILInjected.Token(Token = "0x60004FA")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B084", Offset = "0xB1B084", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	public override void PreviousItem()
	{
		throw null;
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00022868 File Offset: 0x00020A68
	[global::Cpp2ILInjected.Token(Token = "0x60004FB")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B1AC", Offset = "0xB1B1AC", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	public override bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x0002286B File Offset: 0x00020A6B
	[global::Cpp2ILInjected.Token(Token = "0x60004FC")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B1E8", Offset = "0xB1B1E8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetMenuItemCount()
	{
		throw null;
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x0002286E File Offset: 0x00020A6E
	[global::Cpp2ILInjected.Token(Token = "0x60004FD")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B1F0", Offset = "0xB1B1F0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private int GetDisplayItemCount()
	{
		throw null;
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000464 RID: 1124 RVA: 0x00022871 File Offset: 0x00020A71
	[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004FE")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1AD30", Offset = "0xB1AD30", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "NextItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "PreviousItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NPCOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
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

	// Token: 0x06000465 RID: 1125 RVA: 0x00022874 File Offset: 0x00020A74
	[global::Cpp2ILInjected.Token(Token = "0x60004FF")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B494", Offset = "0xB1B494", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	public override int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00022877 File Offset: 0x00020A77
	[global::Cpp2ILInjected.Token(Token = "0x6000500")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B844", Offset = "0xB1B844", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x0002287A File Offset: 0x00020A7A
	[global::Cpp2ILInjected.Token(Token = "0x6000501")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BA08", Offset = "0xB1BA08", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x0002287D File Offset: 0x00020A7D
	[global::Cpp2ILInjected.Token(Token = "0x6000502")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BB00", Offset = "0xB1BB00", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected override void ClampPosition()
	{
		throw null;
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00022880 File Offset: 0x00020A80
	[global::Cpp2ILInjected.Token(Token = "0x6000503")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BB04", Offset = "0xB1BB04", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00022883 File Offset: 0x00020A83
	[global::Cpp2ILInjected.Token(Token = "0x6000504")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BE78", Offset = "0xB1BE78", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHousing4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00022886 File Offset: 0x00020A86
	[global::Cpp2ILInjected.Token(Token = "0x6000505")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BF60", Offset = "0xB1BF60", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerHousing4Page()
	{
		throw null;
	}

	// Token: 0x040002E5 RID: 741
	[global::Cpp2ILInjected.Token(Token = "0x400046F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIControllerDynamicGridNavigator _gridNav;
}
