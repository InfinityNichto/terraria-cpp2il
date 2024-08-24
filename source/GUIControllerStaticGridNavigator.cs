using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000A8 RID: 168
[global::Cpp2ILInjected.Token(Token = "0x20000EB")]
public class GUIControllerStaticGridNavigator
{
	// Token: 0x0600056F RID: 1391 RVA: 0x00022B92 File Offset: 0x00020D92
	[global::Cpp2ILInjected.Token(Token = "0x6000629")]
	[global::Cpp2ILInjected.Address(RVA = "0xD15AF8", Offset = "0xD15AF8", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerStaticGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerStaticGridNavigator(GUIPageContentController controller, GUIControllerStaticGridNavigator.GetGrid grid, GUIControllerStaticGridNavigator.GetItemScale itemScale, GUIControllerStaticGridNavigator.GetCollectionCount menuItemCount, GUIControllerStaticGridNavigator.GetCollectionCount displayItemCount)
	{
		throw null;
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000570 RID: 1392 RVA: 0x00022B95 File Offset: 0x00020D95
	[global::Cpp2ILInjected.Token(Token = "0x170000C4")]
	private ItemGrid_Layout GridLayout
	{
		[global::Cpp2ILInjected.Token(Token = "0x600062A")]
		[global::Cpp2ILInjected.Address(RVA = "0xD15B48", Offset = "0xD15B48", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000571 RID: 1393 RVA: 0x00022B98 File Offset: 0x00020D98
	[global::Cpp2ILInjected.Token(Token = "0x170000C5")]
	private float itemScale
	{
		[global::Cpp2ILInjected.Token(Token = "0x600062B")]
		[global::Cpp2ILInjected.Address(RVA = "0xD15B5C", Offset = "0xD15B5C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000572 RID: 1394 RVA: 0x00022B9B File Offset: 0x00020D9B
	[global::Cpp2ILInjected.Token(Token = "0x170000C6")]
	private int MenuItemCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x600062C")]
		[global::Cpp2ILInjected.Address(RVA = "0xD15B70", Offset = "0xD15B70", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000573 RID: 1395 RVA: 0x00022B9E File Offset: 0x00020D9E
	[global::Cpp2ILInjected.Token(Token = "0x170000C7")]
	private int DisplayItemCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x600062D")]
		[global::Cpp2ILInjected.Address(RVA = "0xD15B84", Offset = "0xD15B84", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00022BA1 File Offset: 0x00020DA1
	[global::Cpp2ILInjected.Token(Token = "0x600062E")]
	[global::Cpp2ILInjected.Address(RVA = "0xD15B98", Offset = "0xD15B98", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	public void Activate(int itemIndex = -1)
	{
		throw null;
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00022BA4 File Offset: 0x00020DA4
	[global::Cpp2ILInjected.Token(Token = "0x600062F")]
	[global::Cpp2ILInjected.Address(RVA = "0xD15C00", Offset = "0xD15C00", Length = "0x1B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00022BA7 File Offset: 0x00020DA7
	[global::Cpp2ILInjected.Token(Token = "0x6000630")]
	[global::Cpp2ILInjected.Address(RVA = "0xD15E60", Offset = "0xD15E60", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000577 RID: 1399 RVA: 0x00022BAA File Offset: 0x00020DAA
	[global::Cpp2ILInjected.Token(Token = "0x170000C8")]
	private int MenuColumn
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000631")]
		[global::Cpp2ILInjected.Address(RVA = "0xD15E3C", Offset = "0xD15E3C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000578 RID: 1400 RVA: 0x00022BAD File Offset: 0x00020DAD
	[global::Cpp2ILInjected.Token(Token = "0x170000C9")]
	private bool LeftSideController
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000632")]
		[global::Cpp2ILInjected.Address(RVA = "0xD15E00", Offset = "0xD15E00", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateInnerOutOfGrid", ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000579 RID: 1401 RVA: 0x00022BB0 File Offset: 0x00020DB0
	[global::Cpp2ILInjected.Token(Token = "0x170000CA")]
	private bool HasMenu
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000633")]
		[global::Cpp2ILInjected.Address(RVA = "0xD15DB0", Offset = "0xD15DB0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x0600057A RID: 1402 RVA: 0x00022BB3 File Offset: 0x00020DB3
	[global::Cpp2ILInjected.Token(Token = "0x170000CB")]
	public bool InMenu
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000634")]
		[global::Cpp2ILInjected.Address(RVA = "0xD160B0", Offset = "0xD160B0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00022BB6 File Offset: 0x00020DB6
	[global::Cpp2ILInjected.Token(Token = "0x6000635")]
	[global::Cpp2ILInjected.Address(RVA = "0xD160E0", Offset = "0xD160E0", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateInnerOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	private void ClampMenu(bool preferUp = true)
	{
		throw null;
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00022BB9 File Offset: 0x00020DB9
	[global::Cpp2ILInjected.Token(Token = "0x6000636")]
	[global::Cpp2ILInjected.Address(RVA = "0xD161A0", Offset = "0xD161A0", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_MenuController", ReturnType = typeof(GUIControllerPageGroup))]
	private GUIControllerItem NavigateMenuOutOfGrid()
	{
		throw null;
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00022BBC File Offset: 0x00020DBC
	[global::Cpp2ILInjected.Token(Token = "0x6000637")]
	[global::Cpp2ILInjected.Address(RVA = "0xD161F4", Offset = "0xD161F4", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateUp", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	private GUIControllerItem NavigateUpOutOfGrid()
	{
		throw null;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00022BBF File Offset: 0x00020DBF
	[global::Cpp2ILInjected.Token(Token = "0x6000638")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16224", Offset = "0xD16224", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	private GUIControllerItem NavigateDownOutOfGrid()
	{
		throw null;
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00022BC2 File Offset: 0x00020DC2
	[global::Cpp2ILInjected.Token(Token = "0x6000639")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16254", Offset = "0xD16254", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	private GUIControllerItem NavigateInnerOutOfGrid()
	{
		throw null;
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00022BC5 File Offset: 0x00020DC5
	[global::Cpp2ILInjected.Token(Token = "0x600063A")]
	[global::Cpp2ILInjected.Address(RVA = "0xD15E98", Offset = "0xD15E98", Length = "0x218")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateUpOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateMenuOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateInnerOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateDownOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00022BC8 File Offset: 0x00020DC8
	[global::Cpp2ILInjected.Token(Token = "0x600063B")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16360", Offset = "0xD16360", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerStaticGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	protected void ClampPosition()
	{
		throw null;
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00022BCB File Offset: 0x00020DCB
	[global::Cpp2ILInjected.Token(Token = "0x600063C")]
	[global::Cpp2ILInjected.Address(RVA = "0xD1640C", Offset = "0xD1640C", Length = "0x2BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
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

	// Token: 0x06000583 RID: 1411 RVA: 0x00022BCE File Offset: 0x00020DCE
	[global::Cpp2ILInjected.Token(Token = "0x600063D")]
	[global::Cpp2ILInjected.Address(RVA = "0xD166C8", Offset = "0xD166C8", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerChest4Page), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerShop4Page), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerStaticGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
	public void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x04000342 RID: 834
	[global::Cpp2ILInjected.Token(Token = "0x40004CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIControllerStaticGridNavigator.GetGrid _grid;

	// Token: 0x04000343 RID: 835
	[global::Cpp2ILInjected.Token(Token = "0x40004D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private readonly GUIControllerStaticGridNavigator.GetItemScale _itemScale;

	// Token: 0x04000344 RID: 836
	[global::Cpp2ILInjected.Token(Token = "0x40004D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private readonly GUIPageContentController _controller;

	// Token: 0x04000345 RID: 837
	[global::Cpp2ILInjected.Token(Token = "0x40004D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private readonly GUIControllerStaticGridNavigator.GetCollectionCount _displayItemCount;

	// Token: 0x04000346 RID: 838
	[global::Cpp2ILInjected.Token(Token = "0x40004D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private readonly GUIControllerStaticGridNavigator.GetCollectionCount _menuItemCount;

	// Token: 0x04000347 RID: 839
	[global::Cpp2ILInjected.Token(Token = "0x40004D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int itemRow;

	// Token: 0x04000348 RID: 840
	[global::Cpp2ILInjected.Token(Token = "0x40004D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public int itemColumn;

	// Token: 0x04000349 RID: 841
	[global::Cpp2ILInjected.Token(Token = "0x40004D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public int menuRow;

	// Token: 0x020007A5 RID: 1957
	// (Invoke) Token: 0x0600488E RID: 18574
	[global::Cpp2ILInjected.Token(Token = "0x20000EC")]
	public delegate ItemGrid_Layout GetGrid();

	// Token: 0x020007A6 RID: 1958
	// (Invoke) Token: 0x06004892 RID: 18578
	[global::Cpp2ILInjected.Token(Token = "0x20000ED")]
	public delegate int GetCollectionCount();

	// Token: 0x020007A7 RID: 1959
	// (Invoke) Token: 0x06004896 RID: 18582
	[global::Cpp2ILInjected.Token(Token = "0x20000EE")]
	public delegate float GetItemScale();
}
