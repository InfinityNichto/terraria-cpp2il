using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020000AE RID: 174
[global::Cpp2ILInjected.Token(Token = "0x20000F4")]
public class GUIPlayerCreateController_MainButtons : GUIControllerItem
{
	// Token: 0x060005A6 RID: 1446 RVA: 0x00022C37 File Offset: 0x00020E37
	[global::Cpp2ILInjected.Token(Token = "0x600066C")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16CC0", Offset = "0xD16CC0", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIPlayerCreateController_MainButtons(GUIPlayerCreateController controller)
	{
		throw null;
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00022C3A File Offset: 0x00020E3A
	[global::Cpp2ILInjected.Token(Token = "0x600066D")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17290", Offset = "0xD17290", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00022C3D File Offset: 0x00020E3D
	[global::Cpp2ILInjected.Token(Token = "0x600066E")]
	[global::Cpp2ILInjected.Address(RVA = "0xD18060", Offset = "0xD18060", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00022C40 File Offset: 0x00020E40
	[global::Cpp2ILInjected.Token(Token = "0x600066F")]
	[global::Cpp2ILInjected.Address(RVA = "0xD18068", Offset = "0xD18068", Length = "0x16C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_MainButtons), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_HairStyle), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem NavigateIntoCurrentPage()
	{
		throw null;
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00022C43 File Offset: 0x00020E43
	[global::Cpp2ILInjected.Token(Token = "0x6000670")]
	[global::Cpp2ILInjected.Address(RVA = "0xD181D4", Offset = "0xD181D4", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_MainButtons), Member = "NavigateIntoCurrentPage", ReturnType = typeof(GUIControllerItem))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00022C46 File Offset: 0x00020E46
	[global::Cpp2ILInjected.Token(Token = "0x6000671")]
	[global::Cpp2ILInjected.Address(RVA = "0xD18214", Offset = "0xD18214", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x04000363 RID: 867
	[global::Cpp2ILInjected.Token(Token = "0x40004F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x04000364 RID: 868
	[global::Cpp2ILInjected.Token(Token = "0x40004F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int element;
}
