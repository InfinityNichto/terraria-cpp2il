using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200012D RID: 301
[global::Cpp2ILInjected.Token(Token = "0x20001A8")]
[Serializable]
public class AnimatedTexture_Layout
{
	// Token: 0x06000A67 RID: 2663 RVA: 0x00023A7A File Offset: 0x00021C7A
	[global::Cpp2ILInjected.Token(Token = "0x6000B76")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE910", Offset = "0x9AE910", Length = "0x158")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public AnimatedTexture_Layout()
	{
		throw null;
	}

	// Token: 0x04000A2C RID: 2604
	[global::Cpp2ILInjected.Token(Token = "0x4000DC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000A2D RID: 2605
	[global::Cpp2ILInjected.Token(Token = "0x4000DC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000A2E RID: 2606
	[global::Cpp2ILInjected.Token(Token = "0x4000DC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;

	// Token: 0x04000A2F RID: 2607
	[global::Cpp2ILInjected.Token(Token = "0x4000DC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 Size;

	// Token: 0x04000A30 RID: 2608
	[global::Cpp2ILInjected.Token(Token = "0x4000DCA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool AnchorForSize;

	// Token: 0x04000A31 RID: 2609
	[global::Cpp2ILInjected.Token(Token = "0x4000DCB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public ControlAnchor.ControlId SizeAnchorControl;

	// Token: 0x04000A32 RID: 2610
	[global::Cpp2ILInjected.Token(Token = "0x4000DCC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public LayoutCalculator.AnchorType SizeAnchor;

	// Token: 0x04000A33 RID: 2611
	[global::Cpp2ILInjected.Token(Token = "0x4000DCD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 SizeLocation;

	// Token: 0x04000A34 RID: 2612
	[global::Cpp2ILInjected.Token(Token = "0x4000DCE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Vector2 PickBorder;

	// Token: 0x04000A35 RID: 2613
	[global::Cpp2ILInjected.Token(Token = "0x4000DCF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Vector2 PickOffset;

	// Token: 0x04000A36 RID: 2614
	[global::Cpp2ILInjected.Token(Token = "0x4000DD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public Color Color;

	// Token: 0x04000A37 RID: 2615
	[global::Cpp2ILInjected.Token(Token = "0x4000DD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Texture_Layout Texture;

	// Token: 0x04000A38 RID: 2616
	[global::Cpp2ILInjected.Token(Token = "0x4000DD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public int NumXFrames;

	// Token: 0x04000A39 RID: 2617
	[global::Cpp2ILInjected.Token(Token = "0x4000DD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public int NumYFrames;
}
