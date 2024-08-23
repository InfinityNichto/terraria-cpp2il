using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000070 RID: 112
[global::Cpp2ILInjected.Token(Token = "0x20000A3")]
public class GUIControllerRubbleMaker : GUIControllerItem
{
	// Token: 0x0600033E RID: 830 RVA: 0x000224FF File Offset: 0x000206FF
	[global::Cpp2ILInjected.Token(Token = "0x60003D8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81510", Offset = "0xA81510", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "get_RubbleCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00022502 File Offset: 0x00020702
	[global::Cpp2ILInjected.Token(Token = "0x60003D9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81594", Offset = "0xA81594", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00022505 File Offset: 0x00020705
	[global::Cpp2ILInjected.Token(Token = "0x60003DA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8159C", Offset = "0xA8159C", Length = "0x2A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "get_MaterialCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RubbleMakerUI_Layout), Member = "get_Instance", ReturnType = typeof(RubbleMakerUI_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "get_RubbleCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerRubbleMaker), Member = "ClampMaterialGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerRubbleMaker), Member = "ClampRubbleGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00022508 File Offset: 0x00020708
	[global::Cpp2ILInjected.Token(Token = "0x60003DB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81840", Offset = "0xA81840", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerRubbleMaker), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerRubbleMaker), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "get_MaterialCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RubbleMakerUI_Layout), Member = "get_Instance", ReturnType = typeof(RubbleMakerUI_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void ClampMaterialGrid()
	{
		throw null;
	}

	// Token: 0x06000342 RID: 834 RVA: 0x0002250B File Offset: 0x0002070B
	[global::Cpp2ILInjected.Token(Token = "0x60003DC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81928", Offset = "0xA81928", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerRubbleMaker), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerRubbleMaker), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "get_RubbleCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RubbleMakerUI_Layout), Member = "get_Instance", ReturnType = typeof(RubbleMakerUI_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void ClampRubbleGrid()
	{
		throw null;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x0002250E File Offset: 0x0002070E
	[global::Cpp2ILInjected.Token(Token = "0x60003DD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81A18", Offset = "0xA81A18", Length = "0x380")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "CalculateRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetMainMenuPageRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerRubbleMaker), Member = "ClampMaterialGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerRubbleMaker), Member = "ClampRubbleGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RubbleMakerUI_Layout), Member = "get_Instance", ReturnType = typeof(RubbleMakerUI_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetPickRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00022511 File Offset: 0x00020711
	[global::Cpp2ILInjected.Token(Token = "0x60003DE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81D98", Offset = "0xA81D98", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerRubbleMaker()
	{
		throw null;
	}

	// Token: 0x04000280 RID: 640
	[global::Cpp2ILInjected.Token(Token = "0x40003BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool wasInFilterGrid;

	// Token: 0x04000281 RID: 641
	[global::Cpp2ILInjected.Token(Token = "0x40003BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int filterGridRow;

	// Token: 0x04000282 RID: 642
	[global::Cpp2ILInjected.Token(Token = "0x40003C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int filterGridCol;

	// Token: 0x04000283 RID: 643
	[global::Cpp2ILInjected.Token(Token = "0x40003C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private bool inGrid;

	// Token: 0x04000284 RID: 644
	[global::Cpp2ILInjected.Token(Token = "0x40003C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int gridRow;

	// Token: 0x04000285 RID: 645
	[global::Cpp2ILInjected.Token(Token = "0x40003C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private int gridCol;

	// Token: 0x04000286 RID: 646
	[global::Cpp2ILInjected.Token(Token = "0x40003C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool filterButton;

	// Token: 0x04000287 RID: 647
	[global::Cpp2ILInjected.Token(Token = "0x40003C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	private bool sizeButton;
}
