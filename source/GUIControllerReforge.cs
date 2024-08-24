using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200009C RID: 156
[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
public class GUIControllerReforge : GUIPageContentController
{
	// Token: 0x060004E7 RID: 1255 RVA: 0x000229FA File Offset: 0x00020BFA
	[global::Cpp2ILInjected.Token(Token = "0x6000581")]
	[global::Cpp2ILInjected.Address(RVA = "0xB204D4", Offset = "0xB204D4", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerReforge()
	{
		throw null;
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x000229FD File Offset: 0x00020BFD
	[global::Cpp2ILInjected.Token(Token = "0x6000582")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2181C", Offset = "0xB2181C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00022A00 File Offset: 0x00020C00
	[global::Cpp2ILInjected.Token(Token = "0x170000A6")]
	public int MinRow
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000583")]
		[global::Cpp2ILInjected.Address(RVA = "0xB21820", Offset = "0xB21820", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x060004EA RID: 1258 RVA: 0x00022A03 File Offset: 0x00020C03
	[global::Cpp2ILInjected.Token(Token = "0x170000A7")]
	public int MinColumns
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000584")]
		[global::Cpp2ILInjected.Address(RVA = "0xB218AC", Offset = "0xB218AC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00022A06 File Offset: 0x00020C06
	[global::Cpp2ILInjected.Token(Token = "0x6000585")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21940", Offset = "0xB21940", Length = "0xCC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00022A09 File Offset: 0x00020C09
	[global::Cpp2ILInjected.Token(Token = "0x6000586")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21A0C", Offset = "0xB21A0C", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge), Member = "get_MinColumns", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge), Member = "get_MinRow", ReturnType = typeof(int))]
	private void ClampPosition()
	{
		throw null;
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00022A0C File Offset: 0x00020C0C
	[global::Cpp2ILInjected.Token(Token = "0x6000587")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21A6C", Offset = "0xB21A6C", Length = "0x240")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerReforge), Member = "ClampPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Reforge_Layout), Member = "get_DisplayItemGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00022A0F File Offset: 0x00020C0F
	[global::Cpp2ILInjected.Token(Token = "0x6000588")]
	[global::Cpp2ILInjected.Address(RVA = "0xB21CAC", Offset = "0xB21CAC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x04000321 RID: 801
	[global::Cpp2ILInjected.Token(Token = "0x40004AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x04000322 RID: 802
	[global::Cpp2ILInjected.Token(Token = "0x40004AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;
}
