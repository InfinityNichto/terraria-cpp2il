using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000072 RID: 114
[global::Cpp2ILInjected.Token(Token = "0x20000A5")]
public class GUIControllerSaveSynchronisation_FileListWorld : GUIControllerItem
{
	// Token: 0x0600034B RID: 843 RVA: 0x00022526 File Offset: 0x00020726
	[global::Cpp2ILInjected.Token(Token = "0x60003E5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA822A4", Offset = "0xA822A4", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00022529 File Offset: 0x00020729
	[global::Cpp2ILInjected.Token(Token = "0x60003E6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82514", Offset = "0xA82514", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x0600034D RID: 845 RVA: 0x0002252C File Offset: 0x0002072C
	[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8234C", Offset = "0xA8234C", Length = "0x1C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSaveSynchronisation_FileListWorld), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
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

	// Token: 0x0600034E RID: 846 RVA: 0x0002252F File Offset: 0x0002072F
	[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8251C", Offset = "0xA8251C", Length = "0x124")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerSaveSynchronisation_FileListWorld), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00022532 File Offset: 0x00020732
	[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA82640", Offset = "0xA82640", Length = "0x164")]
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

	// Token: 0x06000350 RID: 848 RVA: 0x00022535 File Offset: 0x00020735
	[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA827A4", Offset = "0xA827A4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = ".cctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerSaveSynchronisation_FileListWorld()
	{
		throw null;
	}
}
