using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x020000BC RID: 188
[global::Cpp2ILInjected.Token(Token = "0x200010C")]
public static class GUIItemGrid
{
	// Token: 0x060005EC RID: 1516 RVA: 0x00022D09 File Offset: 0x00020F09
	[global::Cpp2ILInjected.Token(Token = "0x60006C6")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6426C", Offset = "0xF6426C", Length = "0x2E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private static void DummyDraw(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00022D0C File Offset: 0x00020F0C
	[global::Cpp2ILInjected.Token(Token = "0x60006C7")]
	[global::Cpp2ILInjected.Address(RVA = "0xF61298", Offset = "0xF61298", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Vector2),
		typeof(Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "CalculateRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Rectangle CalculateRegion(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, Vector2 itemSize, int overloadedItemCount = -1)
	{
		throw null;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00022D0F File Offset: 0x00020F0F
	[global::Cpp2ILInjected.Token(Token = "0x60006C8")]
	[global::Cpp2ILInjected.Address(RVA = "0xF64554", Offset = "0xF64554", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 60)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(Vector2),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public static Rectangle CalculateRegion(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, int overloadedItemCount = -1, Texture2D overloadBackingTexture = null)
	{
		throw null;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00022D12 File Offset: 0x00020F12
	[global::Cpp2ILInjected.Token(Token = "0x60006C9")]
	[global::Cpp2ILInjected.Address(RVA = "0xF64650", Offset = "0xF64650", Length = "0x12C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public static void Draw(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int overloadedItemCount = -1, Texture2D overloadBackingTexture = null)
	{
		throw null;
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00022D15 File Offset: 0x00020F15
	[global::Cpp2ILInjected.Token(Token = "0x60006CA")]
	[global::Cpp2ILInjected.Address(RVA = "0xF631E4", Offset = "0xF631E4", Length = "0x778")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Vector2),
		typeof(GUIItemGrid.GetItemSizeHandler),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawControlsBanner", MemberParameters = new object[] { typeof(GUIControlsBanner.ActionSource) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawPickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public static void Draw(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, GUIItemGrid.GetItemSizeHandler itemSizeHandler, int overloadedItemCount = -1, int reverseOrverOffset = 0, int maxRowSize = -1, int maxRowSizeLineCount = 1)
	{
		throw null;
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00022D18 File Offset: 0x00020F18
	[global::Cpp2ILInjected.Token(Token = "0x60006CB")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6138C", Offset = "0xF6138C", Length = "0x11B8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Vector2),
		typeof(Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(Vector2),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawOrders", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIClothesWindow), Member = "DrawStyles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawPageIcons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawInventoryItems", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "DrawOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "PageDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawStylesGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawPickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hotbar_Layout), Member = "get_Instance", ReturnType = typeof(Hotbar_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
	public static void Draw(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, Vector2 itemSize, int overloadedItemCount = -1)
	{
		throw null;
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00022D1B File Offset: 0x00020F1B
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60006CC")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6477C", Offset = "0xF6477C", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	static GUIItemGrid()
	{
		throw null;
	}

	// Token: 0x0400037A RID: 890
	[global::Cpp2ILInjected.Token(Token = "0x4000560")]
	public static bool disablePickingCallbacks;

	// Token: 0x0400037B RID: 891
	[global::Cpp2ILInjected.Token(Token = "0x4000561")]
	private static Rectangle calculatedRegion;

	// Token: 0x0400037C RID: 892
	[global::Cpp2ILInjected.Token(Token = "0x4000562")]
	private static int calcBackingWidth;

	// Token: 0x0400037D RID: 893
	[global::Cpp2ILInjected.Token(Token = "0x4000563")]
	private static int calcBackingHeight;

	// Token: 0x0400037E RID: 894
	[global::Cpp2ILInjected.Token(Token = "0x4000564")]
	private static bool calcRegionInitialised;

	// Token: 0x0400037F RID: 895
	[global::Cpp2ILInjected.Token(Token = "0x4000565")]
	private static GUIItemGrid.DrawItemHandler dummyDraw;

	// Token: 0x020007B2 RID: 1970
	// (Invoke) Token: 0x060048AE RID: 18606
	[global::Cpp2ILInjected.Token(Token = "0x200010D")]
	public delegate void CursorOver(int itemIndex);

	// Token: 0x020007B3 RID: 1971
	// (Invoke) Token: 0x060048B2 RID: 18610
	[global::Cpp2ILInjected.Token(Token = "0x200010E")]
	public delegate float GetItemScaleHandler(int itemIndex);

	// Token: 0x020007B4 RID: 1972
	// (Invoke) Token: 0x060048B6 RID: 18614
	[global::Cpp2ILInjected.Token(Token = "0x200010F")]
	public delegate void DrawItemHandler(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale);

	// Token: 0x020007B5 RID: 1973
	// (Invoke) Token: 0x060048BA RID: 18618
	[global::Cpp2ILInjected.Token(Token = "0x2000110")]
	public delegate Vector2 GetItemSizeHandler(int itemIndex);
}
