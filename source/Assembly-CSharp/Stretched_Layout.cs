using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200013C RID: 316
[global::Cpp2ILInjected.Token(Token = "0x20001BB")]
[Serializable]
public class Stretched_Layout
{
	// Token: 0x06000AC2 RID: 2754 RVA: 0x00023B8B File Offset: 0x00021D8B
	[global::Cpp2ILInjected.Token(Token = "0x6000BD1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B3754", Offset = "0x9B3754", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public Stretched_Layout()
	{
		throw null;
	}

	// Token: 0x04000ACB RID: 2763
	[global::Cpp2ILInjected.Token(Token = "0x4000EB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000ACC RID: 2764
	[global::Cpp2ILInjected.Token(Token = "0x4000EB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000ACD RID: 2765
	[global::Cpp2ILInjected.Token(Token = "0x4000EB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;

	// Token: 0x04000ACE RID: 2766
	[global::Cpp2ILInjected.Token(Token = "0x4000EB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Color Color;

	// Token: 0x04000ACF RID: 2767
	[global::Cpp2ILInjected.Token(Token = "0x4000EB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float Size;

	// Token: 0x04000AD0 RID: 2768
	[global::Cpp2ILInjected.Token(Token = "0x4000EBA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float Scale;

	// Token: 0x04000AD1 RID: 2769
	[global::Cpp2ILInjected.Token(Token = "0x4000EBB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public bool Vertical;

	// Token: 0x04000AD2 RID: 2770
	[global::Cpp2ILInjected.Token(Token = "0x4000EBC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout Backing;
}
