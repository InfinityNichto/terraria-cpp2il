using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200012C RID: 300
[global::Cpp2ILInjected.Token(Token = "0x20001A7")]
[Serializable]
public class Anchor_Layout
{
	// Token: 0x06000A66 RID: 2662 RVA: 0x00023A77 File Offset: 0x00021C77
	[global::Cpp2ILInjected.Token(Token = "0x6000B75")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE900", Offset = "0x9AE900", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Anchor_Layout()
	{
		throw null;
	}

	// Token: 0x04000A29 RID: 2601
	[global::Cpp2ILInjected.Token(Token = "0x4000DC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000A2A RID: 2602
	[global::Cpp2ILInjected.Token(Token = "0x4000DC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000A2B RID: 2603
	[global::Cpp2ILInjected.Token(Token = "0x4000DC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;
}
