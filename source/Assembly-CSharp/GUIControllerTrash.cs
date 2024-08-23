using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000A3 RID: 163
[global::Cpp2ILInjected.Token(Token = "0x20000DE")]
public class GUIControllerTrash : GUIPageContentController
{
	// Token: 0x06000529 RID: 1321 RVA: 0x00022AC0 File Offset: 0x00020CC0
	[global::Cpp2ILInjected.Token(Token = "0x60005C3")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2048C", Offset = "0xB2048C", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerTrash()
	{
		throw null;
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00022AC3 File Offset: 0x00020CC3
	[global::Cpp2ILInjected.Token(Token = "0x60005C4")]
	[global::Cpp2ILInjected.Address(RVA = "0xB232F0", Offset = "0xB232F0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00022AC6 File Offset: 0x00020CC6
	[global::Cpp2ILInjected.Token(Token = "0x60005C5")]
	[global::Cpp2ILInjected.Address(RVA = "0xB232F4", Offset = "0xB232F4", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Inventory", ReturnType = typeof(GUIControllerInventory))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x00022AC9 File Offset: 0x00020CC9
	[global::Cpp2ILInjected.Token(Token = "0x60005C6")]
	[global::Cpp2ILInjected.Address(RVA = "0xB233A4", Offset = "0xB233A4", Length = "0x1CC")]
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
}
