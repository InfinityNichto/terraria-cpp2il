using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000AA RID: 170
[global::Cpp2ILInjected.Token(Token = "0x20000F0")]
public class GUIPlayerCreateController_Gender : GUIControllerItem
{
	// Token: 0x0600058B RID: 1419 RVA: 0x00022BE6 File Offset: 0x00020DE6
	[global::Cpp2ILInjected.Token(Token = "0x6000651")]
	[global::Cpp2ILInjected.Address(RVA = "0xD16D38", Offset = "0xD16D38", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIPlayerCreateController_Gender(GUIPlayerCreateController controller)
	{
		throw null;
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00022BE9 File Offset: 0x00020DE9
	[global::Cpp2ILInjected.Token(Token = "0x6000652")]
	[global::Cpp2ILInjected.Address(RVA = "0xD170AC", Offset = "0xD170AC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00022BEC File Offset: 0x00020DEC
	[global::Cpp2ILInjected.Token(Token = "0x6000653")]
	[global::Cpp2ILInjected.Address(RVA = "0xD170B4", Offset = "0xD170B4", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateController_Tabs), Member = "NavigateIntoCurrentPage", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawStylesGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_PendingPlayer", ReturnType = typeof(Player))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
	{
		typeof(int[]),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00022BEF File Offset: 0x00020DEF
	[global::Cpp2ILInjected.Token(Token = "0x6000654")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17168", Offset = "0xD17168", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateController_Tabs), Member = "Activate", ReturnType = typeof(void))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00022BF2 File Offset: 0x00020DF2
	[global::Cpp2ILInjected.Token(Token = "0x6000655")]
	[global::Cpp2ILInjected.Address(RVA = "0xD1729C", Offset = "0xD1729C", Length = "0x19C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00022BF5 File Offset: 0x00020DF5
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000656")]
	[global::Cpp2ILInjected.Address(RVA = "0xD17438", Offset = "0xD17438", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	static GUIPlayerCreateController_Gender()
	{
		throw null;
	}

	// Token: 0x04000357 RID: 855
	[global::Cpp2ILInjected.Token(Token = "0x40004E4")]
	private static int[] actualStyleOrder;

	// Token: 0x04000358 RID: 856
	[global::Cpp2ILInjected.Token(Token = "0x40004E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x04000359 RID: 857
	[global::Cpp2ILInjected.Token(Token = "0x40004E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int selectionIndex;
}
