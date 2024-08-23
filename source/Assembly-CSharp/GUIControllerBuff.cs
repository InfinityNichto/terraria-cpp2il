using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200005D RID: 93
[global::Cpp2ILInjected.Token(Token = "0x2000089")]
public class GUIControllerBuff : GUIControllerItem
{
	// Token: 0x060002BC RID: 700 RVA: 0x00022385 File Offset: 0x00020585
	[global::Cpp2ILInjected.Token(Token = "0x6000356")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1FE0", Offset = "0x9C1FE0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "NextItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "PreviousItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "UpdateBuffNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00022388 File Offset: 0x00020588
	[global::Cpp2ILInjected.Token(Token = "0x6000357")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1FE8", Offset = "0x9C1FE8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060002BE RID: 702 RVA: 0x0002238B File Offset: 0x0002058B
	[global::Cpp2ILInjected.Token(Token = "0x6000358")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C1FF0", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBuff), Member = "NavigateNext", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBuff), Member = "NavigatePrevious", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBuff), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Clamp()
	{
		throw null;
	}

	// Token: 0x060002BF RID: 703 RVA: 0x0002238E File Offset: 0x0002058E
	[global::Cpp2ILInjected.Token(Token = "0x6000359")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C205C", Offset = "0x9C205C", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBuff), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "NextItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBuff), Member = "Clamp", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void NavigateNext()
	{
		throw null;
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00022391 File Offset: 0x00020591
	[global::Cpp2ILInjected.Token(Token = "0x600035A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C20D4", Offset = "0x9C20D4", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerBuff), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "PreviousItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBuff), Member = "Clamp", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void NavigatePrevious()
	{
		throw null;
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00022394 File Offset: 0x00020594
	[global::Cpp2ILInjected.Token(Token = "0x600035B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C214C", Offset = "0x9C214C", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBuff), Member = "NavigatePrevious", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBuff), Member = "NavigateNext", ReturnType = typeof(void))]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00022397 File Offset: 0x00020597
	[global::Cpp2ILInjected.Token(Token = "0x600035C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C2180", Offset = "0x9C2180", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetSelectedItem()
	{
		throw null;
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0002239A File Offset: 0x0002059A
	[global::Cpp2ILInjected.Token(Token = "0x600035D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C2188", Offset = "0x9C2188", Length = "0x274")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBuff), Member = "Clamp", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "GetCategoryGrouping", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffs_Layout), Member = "get_Instance", ReturnType = typeof(Buffs_Layout))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0002239D File Offset: 0x0002059D
	[global::Cpp2ILInjected.Token(Token = "0x600035E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C23FC", Offset = "0x9C23FC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerBuff()
	{
		throw null;
	}

	// Token: 0x04000237 RID: 567
	[global::Cpp2ILInjected.Token(Token = "0x4000350")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int selectedItem;
}
