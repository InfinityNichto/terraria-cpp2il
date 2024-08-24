using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000136 RID: 310
[global::Cpp2ILInjected.Token(Token = "0x20001B3")]
[Serializable]
public class Panel_Layout
{
	// Token: 0x06000AAF RID: 2735 RVA: 0x00023B52 File Offset: 0x00021D52
	[global::Cpp2ILInjected.Token(Token = "0x6000BBE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2780", Offset = "0x9B2780", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransactionButtonStyle_Definition), Member = "Apply", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransactionButtonStyle_Definition), Member = "Copy", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void Copy(Panel_Layout other)
	{
		throw null;
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00023B55 File Offset: 0x00021D55
	[global::Cpp2ILInjected.Token(Token = "0x6000BBF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2808", Offset = "0x9B2808", Length = "0x1F0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransactionButtonStyle_Definition), Member = "Copy", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public Panel_Layout()
	{
		throw null;
	}

	// Token: 0x04000A87 RID: 2695
	[global::Cpp2ILInjected.Token(Token = "0x4000E4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000A88 RID: 2696
	[global::Cpp2ILInjected.Token(Token = "0x4000E4E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000A89 RID: 2697
	[global::Cpp2ILInjected.Token(Token = "0x4000E4F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;

	// Token: 0x04000A8A RID: 2698
	[global::Cpp2ILInjected.Token(Token = "0x4000E50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 Size;

	// Token: 0x04000A8B RID: 2699
	[global::Cpp2ILInjected.Token(Token = "0x4000E51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool AnchorForSize;

	// Token: 0x04000A8C RID: 2700
	[global::Cpp2ILInjected.Token(Token = "0x4000E52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public ControlAnchor.ControlId SizeAnchorControl;

	// Token: 0x04000A8D RID: 2701
	[global::Cpp2ILInjected.Token(Token = "0x4000E53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public LayoutCalculator.AnchorType SizeAnchor;

	// Token: 0x04000A8E RID: 2702
	[global::Cpp2ILInjected.Token(Token = "0x4000E54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 SizeLocation;

	// Token: 0x04000A8F RID: 2703
	[global::Cpp2ILInjected.Token(Token = "0x4000E55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Vector2 PickBorder;

	// Token: 0x04000A90 RID: 2704
	[global::Cpp2ILInjected.Token(Token = "0x4000E56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Vector2 PickOffset;

	// Token: 0x04000A91 RID: 2705
	[global::Cpp2ILInjected.Token(Token = "0x4000E57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public Color BackingColor;

	// Token: 0x04000A92 RID: 2706
	[global::Cpp2ILInjected.Token(Token = "0x4000E58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Color BorderColor;

	// Token: 0x04000A93 RID: 2707
	[global::Cpp2ILInjected.Token(Token = "0x4000E59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public Color HighlightColor;

	// Token: 0x04000A94 RID: 2708
	[global::Cpp2ILInjected.Token(Token = "0x4000E5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Texture_Layout Backing;

	// Token: 0x04000A95 RID: 2709
	[global::Cpp2ILInjected.Token(Token = "0x4000E5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Texture_Layout Border;

	// Token: 0x04000A96 RID: 2710
	[global::Cpp2ILInjected.Token(Token = "0x4000E5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Texture_Layout CursorHighlight;
}
