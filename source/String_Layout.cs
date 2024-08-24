using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200013E RID: 318
[global::Cpp2ILInjected.Token(Token = "0x20001BE")]
[Serializable]
public class String_Layout
{
	// Token: 0x06000AC5 RID: 2757 RVA: 0x00023B94 File Offset: 0x00021D94
	[global::Cpp2ILInjected.Token(Token = "0x6000BD4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B3C04", Offset = "0x9B3C04", Length = "0x44")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Copy(String_Layout other)
	{
		throw null;
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00023B97 File Offset: 0x00021D97
	[global::Cpp2ILInjected.Token(Token = "0x6000BD5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B3C48", Offset = "0x9B3C48", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 154)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public SpriteFont GetFont()
	{
		throw null;
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00023B9A File Offset: 0x00021D9A
	[global::Cpp2ILInjected.Token(Token = "0x6000BD6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B26C8", Offset = "0x9B26C8", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransactionButtonStyle_Definition), Member = "Copy", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public String_Layout()
	{
		throw null;
	}

	// Token: 0x04000AF2 RID: 2802
	[global::Cpp2ILInjected.Token(Token = "0x4000EDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000AF3 RID: 2803
	[global::Cpp2ILInjected.Token(Token = "0x4000EE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000AF4 RID: 2804
	[global::Cpp2ILInjected.Token(Token = "0x4000EE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;

	// Token: 0x04000AF5 RID: 2805
	[global::Cpp2ILInjected.Token(Token = "0x4000EE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Color Color;

	// Token: 0x04000AF6 RID: 2806
	[global::Cpp2ILInjected.Token(Token = "0x4000EE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public LayoutCalculator.AnchorType Alignment;

	// Token: 0x04000AF7 RID: 2807
	[global::Cpp2ILInjected.Token(Token = "0x4000EE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float Scale;

	// Token: 0x04000AF8 RID: 2808
	[global::Cpp2ILInjected.Token(Token = "0x4000EE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public String_Layout.FontType RenderFont;

	// Token: 0x04000AF9 RID: 2809
	[global::Cpp2ILInjected.Token(Token = "0x4000EE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool MultiLineUseAlignment;

	// Token: 0x04000AFA RID: 2810
	[global::Cpp2ILInjected.Token(Token = "0x4000EE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float WrapWidth;

	// Token: 0x04000AFB RID: 2811
	[global::Cpp2ILInjected.Token(Token = "0x4000EE8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int MaxLines;

	// Token: 0x04000AFC RID: 2812
	[global::Cpp2ILInjected.Token(Token = "0x4000EE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float MultilineScale;

	// Token: 0x020007E1 RID: 2017
	[global::Cpp2ILInjected.Token(Token = "0x20001BF")]
	public enum FontType
	{
		// Token: 0x04007BB8 RID: 31672
		[global::Cpp2ILInjected.Token(Token = "0x4000EEB")]
		MouseText,
		// Token: 0x04007BB9 RID: 31673
		[global::Cpp2ILInjected.Token(Token = "0x4000EEC")]
		DeathText
	}
}
