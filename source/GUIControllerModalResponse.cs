using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000068 RID: 104
[global::Cpp2ILInjected.Token(Token = "0x2000096")]
public class GUIControllerModalResponse : GUIControllerItem
{
	// Token: 0x060002FF RID: 767 RVA: 0x00022442 File Offset: 0x00020642
	[global::Cpp2ILInjected.Token(Token = "0x6000399")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5820", Offset = "0x9C5820", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "DrawHUD", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeletePlayer), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteWorld), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuitConfirm), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResetSettings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00022445 File Offset: 0x00020645
	[global::Cpp2ILInjected.Token(Token = "0x600039A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5828", Offset = "0x9C5828", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00022448 File Offset: 0x00020648
	[global::Cpp2ILInjected.Token(Token = "0x600039B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C5848", Offset = "0x9C5848", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x0002244B File Offset: 0x0002064B
	[global::Cpp2ILInjected.Token(Token = "0x600039C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C58D0", Offset = "0x9C58D0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000303 RID: 771 RVA: 0x0002244E File Offset: 0x0002064E
	[global::Cpp2ILInjected.Token(Token = "0x600039D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C58D8", Offset = "0x9C58D8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeletePlayer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteWorld), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuitConfirm), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResetSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerModalResponse()
	{
		throw null;
	}

	// Token: 0x04000259 RID: 601
	[global::Cpp2ILInjected.Token(Token = "0x4000382")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerModalResponse.Controls selectedControl;

	// Token: 0x02000790 RID: 1936
	[global::Cpp2ILInjected.Token(Token = "0x2000097")]
	public enum Controls
	{
		// Token: 0x0400790F RID: 30991
		[global::Cpp2ILInjected.Token(Token = "0x4000384")]
		Cancel,
		// Token: 0x04007910 RID: 30992
		[global::Cpp2ILInjected.Token(Token = "0x4000385")]
		Confirm
	}
}
