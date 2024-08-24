using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000A1 RID: 161
[global::Cpp2ILInjected.Token(Token = "0x20000DC")]
public class GUIControllerShop : GUIPageContentController
{
	// Token: 0x06000518 RID: 1304 RVA: 0x00022A8D File Offset: 0x00020C8D
	[global::Cpp2ILInjected.Token(Token = "0x60005B2")]
	[global::Cpp2ILInjected.Address(RVA = "0xB20444", Offset = "0xB20444", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerShop()
	{
		throw null;
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00022A90 File Offset: 0x00020C90
	[global::Cpp2ILInjected.Token(Token = "0x60005B3")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22C4C", Offset = "0xB22C4C", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00022A93 File Offset: 0x00020C93
	[global::Cpp2ILInjected.Token(Token = "0x60005B4")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22CBC", Offset = "0xB22CBC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual bool IsInMenu()
	{
		throw null;
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00022A96 File Offset: 0x00020C96
	[global::Cpp2ILInjected.Token(Token = "0x60005B5")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22CC4", Offset = "0xB22CC4", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x00022A99 File Offset: 0x00020C99
	[global::Cpp2ILInjected.Token(Token = "0x60005B6")]
	[global::Cpp2ILInjected.Address(RVA = "0xB22D80", Offset = "0xB22D80", Length = "0x224")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

	// Token: 0x04000327 RID: 807
	[global::Cpp2ILInjected.Token(Token = "0x40004B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x04000328 RID: 808
	[global::Cpp2ILInjected.Token(Token = "0x40004B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;
}
