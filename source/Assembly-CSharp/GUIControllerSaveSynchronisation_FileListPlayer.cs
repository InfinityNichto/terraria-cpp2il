using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000071 RID: 113
[global::Cpp2ILInjected.Token(Token = "0x20000A4")]
public class GUIControllerSaveSynchronisation_FileListPlayer : GUIControllerItem
{
	// Token: 0x06000345 RID: 837 RVA: 0x00022514 File Offset: 0x00020714
	[global::Cpp2ILInjected.Token(Token = "0x60003DF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81DA0", Offset = "0xA81DA0", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00022517 File Offset: 0x00020717
	[global::Cpp2ILInjected.Token(Token = "0x60003E0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82010", Offset = "0xA82010", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000347 RID: 839 RVA: 0x0002251A File Offset: 0x0002071A
	[global::Cpp2ILInjected.Token(Token = "0x60003E1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA81E48", Offset = "0xA81E48", Length = "0x1C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSaveSynchronisation_FileListPlayer), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
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

	// Token: 0x06000348 RID: 840 RVA: 0x0002251D File Offset: 0x0002071D
	[global::Cpp2ILInjected.Token(Token = "0x60003E2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82018", Offset = "0xA82018", Length = "0x124")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerSaveSynchronisation_FileListPlayer), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00022520 File Offset: 0x00020720
	[global::Cpp2ILInjected.Token(Token = "0x60003E3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8213C", Offset = "0xA8213C", Length = "0x160")]
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

	// Token: 0x0600034A RID: 842 RVA: 0x00022523 File Offset: 0x00020723
	[global::Cpp2ILInjected.Token(Token = "0x60003E4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8229C", Offset = "0xA8229C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = ".cctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerSaveSynchronisation_FileListPlayer()
	{
		throw null;
	}
}
