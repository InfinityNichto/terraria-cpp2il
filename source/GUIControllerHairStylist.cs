using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x0200008D RID: 141
[global::Cpp2ILInjected.Token(Token = "0x20000C6")]
public class GUIControllerHairStylist : GUIControllerItem
{
	// Token: 0x0600043E RID: 1086 RVA: 0x000227FF File Offset: 0x000209FF
	[global::Cpp2ILInjected.Token(Token = "0x60004D8")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18F80", Offset = "0xB18F80", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00022802 File Offset: 0x00020A02
	[global::Cpp2ILInjected.Token(Token = "0x60004D9")]
	[global::Cpp2ILInjected.Address(RVA = "0xB18F88", Offset = "0xB18F88", Length = "0x1B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHairWindow), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHairWindow), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHairWindow), Member = "HairOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHairStylist), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00022805 File Offset: 0x00020A05
	[global::Cpp2ILInjected.Token(Token = "0x60004DA")]
	[global::Cpp2ILInjected.Address(RVA = "0xB19138", Offset = "0xB19138", Length = "0x234")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHairStylist), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHairStylist), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHairWindow), Member = "LoadRegion", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00022808 File Offset: 0x00020A08
	[global::Cpp2ILInjected.Token(Token = "0x60004DB")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1936C", Offset = "0xB1936C", Length = "0x234")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHairStylist), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x0002280B File Offset: 0x00020A0B
	[global::Cpp2ILInjected.Token(Token = "0x60004DC")]
	[global::Cpp2ILInjected.Address(RVA = "0xB195A0", Offset = "0xB195A0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void ClampPosition()
	{
		throw null;
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x0002280E File Offset: 0x00020A0E
	[global::Cpp2ILInjected.Token(Token = "0x60004DD")]
	[global::Cpp2ILInjected.Address(RVA = "0xB195A4", Offset = "0xB195A4", Length = "0x340")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHairWindow), Member = "LoadRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "GetRegion", MemberParameters = new object[] { typeof(Slider_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00022811 File Offset: 0x00020A11
	[global::Cpp2ILInjected.Token(Token = "0x60004DE")]
	[global::Cpp2ILInjected.Address(RVA = "0xB198E4", Offset = "0xB198E4", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHairWindow), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerHairStylist()
	{
		throw null;
	}

	// Token: 0x040002DA RID: 730
	[global::Cpp2ILInjected.Token(Token = "0x400045E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerHairStylist.Controls selectedControl;

	// Token: 0x040002DB RID: 731
	[global::Cpp2ILInjected.Token(Token = "0x400045F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x040002DC RID: 732
	[global::Cpp2ILInjected.Token(Token = "0x4000460")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int itemColumn;

	// Token: 0x040002DD RID: 733
	[global::Cpp2ILInjected.Token(Token = "0x4000461")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int scrollOffset;

	// Token: 0x040002DE RID: 734
	[global::Cpp2ILInjected.Token(Token = "0x4000462")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemSlider;

	// Token: 0x040002DF RID: 735
	[global::Cpp2ILInjected.Token(Token = "0x4000463")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int maxRowIndex;

	// Token: 0x040002E0 RID: 736
	[global::Cpp2ILInjected.Token(Token = "0x4000464")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int maxRowColumn;

	// Token: 0x0200079B RID: 1947
	[global::Cpp2ILInjected.Token(Token = "0x20000C7")]
	public enum Controls
	{
		// Token: 0x0400796A RID: 31082
		[global::Cpp2ILInjected.Token(Token = "0x4000466")]
		Style,
		// Token: 0x0400796B RID: 31083
		[global::Cpp2ILInjected.Token(Token = "0x4000467")]
		Colour,
		// Token: 0x0400796C RID: 31084
		[global::Cpp2ILInjected.Token(Token = "0x4000468")]
		Element,
		// Token: 0x0400796D RID: 31085
		[global::Cpp2ILInjected.Token(Token = "0x4000469")]
		Back,
		// Token: 0x0400796E RID: 31086
		[global::Cpp2ILInjected.Token(Token = "0x400046A")]
		Buy
	}
}
