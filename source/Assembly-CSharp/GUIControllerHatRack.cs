using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200008E RID: 142
[global::Cpp2ILInjected.Token(Token = "0x20000C8")]
public class GUIControllerHatRack : GUIPageContentController
{
	// Token: 0x06000445 RID: 1093 RVA: 0x00022814 File Offset: 0x00020A14
	[global::Cpp2ILInjected.Token(Token = "0x60004DF")]
	[global::Cpp2ILInjected.Address(RVA = "0xB198F8", Offset = "0xB198F8", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerHatRack()
	{
		throw null;
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00022817 File Offset: 0x00020A17
	[global::Cpp2ILInjected.Token(Token = "0x60004E0")]
	[global::Cpp2ILInjected.Address(RVA = "0xB19948", Offset = "0xB19948", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x0002281A File Offset: 0x00020A1A
	[global::Cpp2ILInjected.Token(Token = "0x60004E1")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1994C", Offset = "0xB1994C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x0002281D File Offset: 0x00020A1D
	[global::Cpp2ILInjected.Token(Token = "0x60004E2")]
	[global::Cpp2ILInjected.Address(RVA = "0xB19950", Offset = "0xB19950", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00022820 File Offset: 0x00020A20
	[global::Cpp2ILInjected.Token(Token = "0x60004E3")]
	[global::Cpp2ILInjected.Address(RVA = "0xB19B14", Offset = "0xB19B14", Length = "0x1F4")]
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

	// Token: 0x040002E1 RID: 737
	[global::Cpp2ILInjected.Token(Token = "0x400046B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x040002E2 RID: 738
	[global::Cpp2ILInjected.Token(Token = "0x400046C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;
}
