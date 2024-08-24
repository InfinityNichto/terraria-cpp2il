using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200006F RID: 111
[global::Cpp2ILInjected.Token(Token = "0x20000A1")]
public class GUIControllerPlayerSelect : GUIControllerItem
{
	// Token: 0x06000338 RID: 824 RVA: 0x000224ED File Offset: 0x000206ED
	[global::Cpp2ILInjected.Token(Token = "0x60003D2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81034", Offset = "0xA81034", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000339 RID: 825 RVA: 0x000224F0 File Offset: 0x000206F0
	[global::Cpp2ILInjected.Token(Token = "0x60003D3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA812CC", Offset = "0xA812CC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x0600033A RID: 826 RVA: 0x000224F3 File Offset: 0x000206F3
	[global::Cpp2ILInjected.Token(Token = "0x60003D4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA810B8", Offset = "0xA810B8", Length = "0x214")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPlayerSelect), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x0600033B RID: 827 RVA: 0x000224F6 File Offset: 0x000206F6
	[global::Cpp2ILInjected.Token(Token = "0x60003D5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA812D4", Offset = "0xA812D4", Length = "0x148")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPlayerSelect), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600033C RID: 828 RVA: 0x000224F9 File Offset: 0x000206F9
	[global::Cpp2ILInjected.Token(Token = "0x60003D6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8141C", Offset = "0xA8141C", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x0600033D RID: 829 RVA: 0x000224FC File Offset: 0x000206FC
	[global::Cpp2ILInjected.Token(Token = "0x60003D7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81508", Offset = "0xA81508", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerPlayerSelect()
	{
		throw null;
	}

	// Token: 0x0400027F RID: 639
	[global::Cpp2ILInjected.Token(Token = "0x40003B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int selectedControl;

	// Token: 0x02000794 RID: 1940
	[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
	public enum Controls
	{
		// Token: 0x0400791D RID: 31005
		[global::Cpp2ILInjected.Token(Token = "0x40003B8")]
		Back,
		// Token: 0x0400791E RID: 31006
		[global::Cpp2ILInjected.Token(Token = "0x40003B9")]
		Delete,
		// Token: 0x0400791F RID: 31007
		[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
		Favourite,
		// Token: 0x04007920 RID: 31008
		[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
		EditName,
		// Token: 0x04007921 RID: 31009
		[global::Cpp2ILInjected.Token(Token = "0x40003BC")]
		Play,
		// Token: 0x04007922 RID: 31010
		[global::Cpp2ILInjected.Token(Token = "0x40003BD")]
		New
	}
}
