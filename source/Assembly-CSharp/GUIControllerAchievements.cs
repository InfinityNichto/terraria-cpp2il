using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200005B RID: 91
[global::Cpp2ILInjected.Token(Token = "0x2000086")]
public class GUIControllerAchievements : GUIControllerItem
{
	// Token: 0x060002A2 RID: 674 RVA: 0x00022337 File Offset: 0x00020537
	[global::Cpp2ILInjected.Token(Token = "0x600033C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C0BB8", Offset = "0x9C0BB8", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0002233A File Offset: 0x0002053A
	[global::Cpp2ILInjected.Token(Token = "0x600033D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C0C30", Offset = "0x9C0C30", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0002233D File Offset: 0x0002053D
	[global::Cpp2ILInjected.Token(Token = "0x600033E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C0C38", Offset = "0x9C0C38", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerAchievements), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00022340 File Offset: 0x00020540
	[global::Cpp2ILInjected.Token(Token = "0x600033F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C0DC0", Offset = "0x9C0DC0", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerAchievements), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00022343 File Offset: 0x00020543
	[global::Cpp2ILInjected.Token(Token = "0x6000340")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C0F48", Offset = "0x9C0F48", Length = "0x1EC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00022346 File Offset: 0x00020546
	[global::Cpp2ILInjected.Token(Token = "0x6000341")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C1134", Offset = "0x9C1134", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerAchievements()
	{
		throw null;
	}

	// Token: 0x0400022C RID: 556
	[global::Cpp2ILInjected.Token(Token = "0x400033E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerAchievements.Controls selectedControl;

	// Token: 0x0200078D RID: 1933
	[global::Cpp2ILInjected.Token(Token = "0x2000087")]
	public enum Controls
	{
		// Token: 0x040078F8 RID: 30968
		[global::Cpp2ILInjected.Token(Token = "0x4000340")]
		FilterSlayer,
		// Token: 0x040078F9 RID: 30969
		[global::Cpp2ILInjected.Token(Token = "0x4000341")]
		FilterCollector,
		// Token: 0x040078FA RID: 30970
		[global::Cpp2ILInjected.Token(Token = "0x4000342")]
		FilterExplorer,
		// Token: 0x040078FB RID: 30971
		[global::Cpp2ILInjected.Token(Token = "0x4000343")]
		FilterChallenger,
		// Token: 0x040078FC RID: 30972
		[global::Cpp2ILInjected.Token(Token = "0x4000344")]
		Element,
		// Token: 0x040078FD RID: 30973
		[global::Cpp2ILInjected.Token(Token = "0x4000345")]
		Back
	}
}
