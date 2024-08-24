using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200005C RID: 92
[global::Cpp2ILInjected.Token(Token = "0x2000088")]
public class GUIControllerBestiary : GUIControllerItem
{
	// Token: 0x060002A8 RID: 680 RVA: 0x00022349 File Offset: 0x00020549
	[global::Cpp2ILInjected.Token(Token = "0x6000342")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1144", Offset = "0x9C1144", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0002234C File Offset: 0x0002054C
	[global::Cpp2ILInjected.Token(Token = "0x6000343")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C114C", Offset = "0x9C114C", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0002234F File Offset: 0x0002054F
	[global::Cpp2ILInjected.Token(Token = "0x6000344")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1420", Offset = "0x9C1420", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public int GetSelectedIndex()
	{
		throw null;
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00022352 File Offset: 0x00020552
	[global::Cpp2ILInjected.Token(Token = "0x6000345")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C148C", Offset = "0x9C148C", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateFilters()
	{
		throw null;
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00022355 File Offset: 0x00020555
	[global::Cpp2ILInjected.Token(Token = "0x6000346")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C14A8", Offset = "0x9C14A8", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "CloseFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "SelectEntry", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void DeactivateFilters()
	{
		throw null;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00022358 File Offset: 0x00020558
	[global::Cpp2ILInjected.Token(Token = "0x6000347")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C15E4", Offset = "0x9C15E4", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawOrders", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateOrders(int maxOrders, int selectedOrder)
	{
		throw null;
	}

	// Token: 0x060002AE RID: 686 RVA: 0x0002235B File Offset: 0x0002055B
	[global::Cpp2ILInjected.Token(Token = "0x6000348")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C160C", Offset = "0x9C160C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "CloseSortOrder", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateOrders()
	{
		throw null;
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0002235E File Offset: 0x0002055E
	[global::Cpp2ILInjected.Token(Token = "0x6000349")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1614", Offset = "0x9C1614", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateDrops(int maxDrops)
	{
		throw null;
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00022361 File Offset: 0x00020561
	[global::Cpp2ILInjected.Token(Token = "0x600034A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C163C", Offset = "0x9C163C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "CloseLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateDrops()
	{
		throw null;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00022364 File Offset: 0x00020564
	[global::Cpp2ILInjected.Token(Token = "0x600034B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1548", Offset = "0x9C1548", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBestiary), Member = "DeactivateFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void SelectEntry(int index)
	{
		throw null;
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00022367 File Offset: 0x00020567
	[global::Cpp2ILInjected.Token(Token = "0x600034C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1644", Offset = "0x9C1644", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "NPCOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void SelectNPCEntry(int index)
	{
		throw null;
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x0002236A File Offset: 0x0002056A
	[global::Cpp2ILInjected.Token(Token = "0x600034D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C16B0", Offset = "0x9C16B0", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "FilterOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void SelectFilterEntry(int index)
	{
		throw null;
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x0002236D File Offset: 0x0002056D
	[global::Cpp2ILInjected.Token(Token = "0x600034E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C171C", Offset = "0x9C171C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SelectDropEntry(int index)
	{
		throw null;
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060002B5 RID: 693 RVA: 0x00022370 File Offset: 0x00020570
	[global::Cpp2ILInjected.Token(Token = "0x17000076")]
	private int maxRowIndex
	{
		[global::Cpp2ILInjected.Token(Token = "0x600034F")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C1724", Offset = "0x9C1724", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBestiary), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBestiary), Member = "ClampGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060002B6 RID: 694 RVA: 0x00022373 File Offset: 0x00020573
	[global::Cpp2ILInjected.Token(Token = "0x17000077")]
	private int maxRowColumn
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000350")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C17F8", Offset = "0x9C17F8", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBestiary), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBestiary), Member = "ClampGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00022376 File Offset: 0x00020576
	[global::Cpp2ILInjected.Token(Token = "0x6000351")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1158", Offset = "0x9C1158", Length = "0x2C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBestiary), Member = "DeactivateFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBestiary), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBestiary), Member = "ClampGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetMainMenuPageRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00022379 File Offset: 0x00020579
	[global::Cpp2ILInjected.Token(Token = "0x6000352")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C18E4", Offset = "0x9C18E4", Length = "0x284")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "get_maxRowIndex", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "get_maxRowColumn", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0002237C File Offset: 0x0002057C
	[global::Cpp2ILInjected.Token(Token = "0x6000353")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1B68", Offset = "0x9C1B68", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBestiary), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "get_maxRowIndex", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "get_maxRowColumn", ReturnType = typeof(int))]
	private void ClampGrid()
	{
		throw null;
	}

	// Token: 0x060002BA RID: 698 RVA: 0x0002237F File Offset: 0x0002057F
	[global::Cpp2ILInjected.Token(Token = "0x6000354")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1BD8", Offset = "0x9C1BD8", Length = "0x400")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetMainMenuPageRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "ClampGrid", ReturnType = typeof(void))]
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

	// Token: 0x060002BB RID: 699 RVA: 0x00022382 File Offset: 0x00020582
	[global::Cpp2ILInjected.Token(Token = "0x6000355")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1FD8", Offset = "0x9C1FD8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerBestiary()
	{
		throw null;
	}

	// Token: 0x0400022D RID: 557
	[global::Cpp2ILInjected.Token(Token = "0x4000346")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int SelectedRow;

	// Token: 0x0400022E RID: 558
	[global::Cpp2ILInjected.Token(Token = "0x4000347")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int SelectedColumn;

	// Token: 0x0400022F RID: 559
	[global::Cpp2ILInjected.Token(Token = "0x4000348")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int SelectedIndex;

	// Token: 0x04000230 RID: 560
	[global::Cpp2ILInjected.Token(Token = "0x4000349")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private int filterSelectedColumn;

	// Token: 0x04000231 RID: 561
	[global::Cpp2ILInjected.Token(Token = "0x400034A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int filterSelectedRow;

	// Token: 0x04000232 RID: 562
	[global::Cpp2ILInjected.Token(Token = "0x400034B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private bool onFilterSearchItem;

	// Token: 0x04000233 RID: 563
	[global::Cpp2ILInjected.Token(Token = "0x400034C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
	private bool filtersActive;

	// Token: 0x04000234 RID: 564
	[global::Cpp2ILInjected.Token(Token = "0x400034D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
	private bool ordersActive;

	// Token: 0x04000235 RID: 565
	[global::Cpp2ILInjected.Token(Token = "0x400034E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x27")]
	private bool dropsActive;

	// Token: 0x04000236 RID: 566
	[global::Cpp2ILInjected.Token(Token = "0x400034F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private int maxItemIndex;
}
