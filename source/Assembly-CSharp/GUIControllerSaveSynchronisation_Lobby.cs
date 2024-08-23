using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000073 RID: 115
[global::Cpp2ILInjected.Token(Token = "0x20000A6")]
public class GUIControllerSaveSynchronisation_Lobby : GUIControllerItem
{
	// Token: 0x06000351 RID: 849 RVA: 0x00022538 File Offset: 0x00020738
	[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA827AC", Offset = "0xA827AC", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation_Lobby), Member = "RefreshServers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000352 RID: 850 RVA: 0x0002253B File Offset: 0x0002073B
	[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA827FC", Offset = "0xA827FC", Length = "0x1C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSaveSynchronisation_Lobby), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x0002253E File Offset: 0x0002073E
	[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
	[global::Cpp2ILInjected.Address(RVA = "0xA829C4", Offset = "0xA829C4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00022541 File Offset: 0x00020741
	[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA829CC", Offset = "0xA829CC", Length = "0x158")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerSaveSynchronisation_Lobby), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00022544 File Offset: 0x00020744
	[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82B24", Offset = "0xA82B24", Length = "0x160")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00022547 File Offset: 0x00020747
	[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82C84", Offset = "0xA82C84", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Lobby), Member = ".cctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerSaveSynchronisation_Lobby()
	{
		throw null;
	}
}
