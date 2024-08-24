using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000132 RID: 306
[global::Cpp2ILInjected.Token(Token = "0x20001AE")]
[Serializable]
public class DPad_Layout
{
	// Token: 0x06000AAB RID: 2731 RVA: 0x00023B46 File Offset: 0x00021D46
	[global::Cpp2ILInjected.Token(Token = "0x6000BBA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B23A0", Offset = "0x9B23A0", Length = "0x184")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public DPad_Layout()
	{
		throw null;
	}

	// Token: 0x04000A5D RID: 2653
	[global::Cpp2ILInjected.Token(Token = "0x4000E1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000A5E RID: 2654
	[global::Cpp2ILInjected.Token(Token = "0x4000E1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000A5F RID: 2655
	[global::Cpp2ILInjected.Token(Token = "0x4000E1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 CentreLocation;

	// Token: 0x04000A60 RID: 2656
	[global::Cpp2ILInjected.Token(Token = "0x4000E20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float Scale;

	// Token: 0x04000A61 RID: 2657
	[global::Cpp2ILInjected.Token(Token = "0x4000E21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Vector2 LeftOffset;

	// Token: 0x04000A62 RID: 2658
	[global::Cpp2ILInjected.Token(Token = "0x4000E22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Vector2 RightOffset;

	// Token: 0x04000A63 RID: 2659
	[global::Cpp2ILInjected.Token(Token = "0x4000E23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 TopOffset;

	// Token: 0x04000A64 RID: 2660
	[global::Cpp2ILInjected.Token(Token = "0x4000E24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Vector2 BottomOffset;

	// Token: 0x04000A65 RID: 2661
	[global::Cpp2ILInjected.Token(Token = "0x4000E25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color Color;

	// Token: 0x04000A66 RID: 2662
	[global::Cpp2ILInjected.Token(Token = "0x4000E26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Vector2 PickSize;

	// Token: 0x04000A67 RID: 2663
	[global::Cpp2ILInjected.Token(Token = "0x4000E27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 DeadZone;
}
