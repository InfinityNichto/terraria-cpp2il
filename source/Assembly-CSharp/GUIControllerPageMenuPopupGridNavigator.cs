using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000A7 RID: 167
[global::Cpp2ILInjected.Token(Token = "0x20000E7")]
public class GUIControllerPageMenuPopupGridNavigator
{
	// Token: 0x06000561 RID: 1377 RVA: 0x00022B68 File Offset: 0x00020D68
	[global::Cpp2ILInjected.Token(Token = "0x600060F")]
	[global::Cpp2ILInjected.Address(RVA = "0xD14F6C", Offset = "0xD14F6C", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "get_AccessoryNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "get_LoadoutNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "get_BuilderToolNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemFilter), Member = "get_AccessoryNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "get_TeamNav", ReturnType = typeof(GUIControllerPageMenuPopupGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerPageMenuPopupGridNavigator(GUIPageContentController controller, GUIControllerPageMenuPopupGridNavigator.GetGrid grid, GUIControllerPageMenuPopupGridNavigator.GetCollectionCount collectionCount, GUIControllerPageMenuPopupGridNavigator.GetItemScale itemScale)
	{
		throw null;
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000562 RID: 1378 RVA: 0x00022B6B File Offset: 0x00020D6B
	[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
	private ItemGrid_Layout GridLayout
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000610")]
		[global::Cpp2ILInjected.Address(RVA = "0xD14FAC", Offset = "0xD14FAC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000563 RID: 1379 RVA: 0x00022B6E File Offset: 0x00020D6E
	[global::Cpp2ILInjected.Token(Token = "0x170000BD")]
	private int itemCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000611")]
		[global::Cpp2ILInjected.Address(RVA = "0xD14FC0", Offset = "0xD14FC0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000564 RID: 1380 RVA: 0x00022B71 File Offset: 0x00020D71
	[global::Cpp2ILInjected.Token(Token = "0x170000BE")]
	private float itemScale
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000612")]
		[global::Cpp2ILInjected.Address(RVA = "0xD14FD4", Offset = "0xD14FD4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00022B74 File Offset: 0x00020D74
	[global::Cpp2ILInjected.Token(Token = "0x6000613")]
	[global::Cpp2ILInjected.Address(RVA = "0xD14FE8", Offset = "0xD14FE8", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemFilter), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	public void Activate(int itemIndex = -1)
	{
		throw null;
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00022B77 File Offset: 0x00020D77
	[global::Cpp2ILInjected.Token(Token = "0x6000614")]
	[global::Cpp2ILInjected.Address(RVA = "0xD15050", Offset = "0xD15050", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemFilter), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000567 RID: 1383 RVA: 0x00022B7A File Offset: 0x00020D7A
	[global::Cpp2ILInjected.Token(Token = "0x170000BF")]
	private int MaxRow_Horizontal
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000615")]
		[global::Cpp2ILInjected.Address(RVA = "0xD1523C", Offset = "0xD1523C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000568 RID: 1384 RVA: 0x00022B7D File Offset: 0x00020D7D
	[global::Cpp2ILInjected.Token(Token = "0x170000C0")]
	private int MaxRowColumn_Horizontal
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000616")]
		[global::Cpp2ILInjected.Address(RVA = "0xD152B4", Offset = "0xD152B4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000569 RID: 1385 RVA: 0x00022B80 File Offset: 0x00020D80
	[global::Cpp2ILInjected.Token(Token = "0x170000C1")]
	private bool LeftSideController
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000617")]
		[global::Cpp2ILInjected.Address(RVA = "0xD15098", Offset = "0xD15098", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x0600056A RID: 1386 RVA: 0x00022B83 File Offset: 0x00020D83
	[global::Cpp2ILInjected.Token(Token = "0x170000C2")]
	private int MaxScrollOffset_Horizontal
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000618")]
		[global::Cpp2ILInjected.Address(RVA = "0xD15328", Offset = "0xD15328", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x0600056B RID: 1387 RVA: 0x00022B86 File Offset: 0x00020D86
	[global::Cpp2ILInjected.Token(Token = "0x170000C3")]
	private int MaxDisplayRow_Horizontal
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000619")]
		[global::Cpp2ILInjected.Address(RVA = "0xD153DC", Offset = "0xD153DC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00022B89 File Offset: 0x00020D89
	[global::Cpp2ILInjected.Token(Token = "0x600061A")]
	[global::Cpp2ILInjected.Address(RVA = "0xD150B4", Offset = "0xD150B4", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "get_MaxRow_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "get_MaxRowColumn_Horizontal", ReturnType = typeof(int))]
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00022B8C File Offset: 0x00020D8C
	[global::Cpp2ILInjected.Token(Token = "0x600061B")]
	[global::Cpp2ILInjected.Address(RVA = "0xD15420", Offset = "0xD15420", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "get_MaxRow_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "get_MaxRowColumn_Horizontal", ReturnType = typeof(int))]
	protected void ClampPosition()
	{
		throw null;
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00022B8F File Offset: 0x00020D8F
	[global::Cpp2ILInjected.Token(Token = "0x600061C")]
	[global::Cpp2ILInjected.Address(RVA = "0xD15538", Offset = "0xD15538", Length = "0x2A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemFilter), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageMenuPopupGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x0400033C RID: 828
	[global::Cpp2ILInjected.Token(Token = "0x40004C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIControllerPageMenuPopupGridNavigator.GetGrid _grid;

	// Token: 0x0400033D RID: 829
	[global::Cpp2ILInjected.Token(Token = "0x40004CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private readonly GUIControllerPageMenuPopupGridNavigator.GetCollectionCount _collectionCount;

	// Token: 0x0400033E RID: 830
	[global::Cpp2ILInjected.Token(Token = "0x40004CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private readonly GUIControllerPageMenuPopupGridNavigator.GetItemScale _itemScale;

	// Token: 0x0400033F RID: 831
	[global::Cpp2ILInjected.Token(Token = "0x40004CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private readonly GUIPageContentController _controller;

	// Token: 0x04000340 RID: 832
	[global::Cpp2ILInjected.Token(Token = "0x40004CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int itemRow;

	// Token: 0x04000341 RID: 833
	[global::Cpp2ILInjected.Token(Token = "0x40004CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int itemColumn;

	// Token: 0x020007A2 RID: 1954
	// (Invoke) Token: 0x06004882 RID: 18562
	[global::Cpp2ILInjected.Token(Token = "0x20000E8")]
	public delegate ItemGrid_Layout GetGrid();

	// Token: 0x020007A3 RID: 1955
	// (Invoke) Token: 0x06004886 RID: 18566
	[global::Cpp2ILInjected.Token(Token = "0x20000E9")]
	public delegate int GetCollectionCount();

	// Token: 0x020007A4 RID: 1956
	// (Invoke) Token: 0x0600488A RID: 18570
	[global::Cpp2ILInjected.Token(Token = "0x20000EA")]
	public delegate float GetItemScale();
}
