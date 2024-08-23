using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000138 RID: 312
[global::Cpp2ILInjected.Token(Token = "0x20001B6")]
[Serializable]
public class ProgressBar_Layout
{
	// Token: 0x06000AB2 RID: 2738 RVA: 0x00023B5B File Offset: 0x00021D5B
	[global::Cpp2ILInjected.Token(Token = "0x6000BC1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2AB4", Offset = "0x9B2AB4", Length = "0x178")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public ProgressBar_Layout()
	{
		throw null;
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00023B5E File Offset: 0x00021D5E
	[global::Cpp2ILInjected.Token(Token = "0x6000BC2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2C2C", Offset = "0x9B2C2C", Length = "0x1B8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public ProgressBar_Layout(string backingTexture)
	{
		throw null;
	}

	// Token: 0x04000A9E RID: 2718
	[global::Cpp2ILInjected.Token(Token = "0x4000E67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Backing;

	// Token: 0x04000A9F RID: 2719
	[global::Cpp2ILInjected.Token(Token = "0x4000E68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float BackingScale;

	// Token: 0x04000AA0 RID: 2720
	[global::Cpp2ILInjected.Token(Token = "0x4000E69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private bool Vertical;

	// Token: 0x04000AA1 RID: 2721
	[global::Cpp2ILInjected.Token(Token = "0x4000E6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000AA2 RID: 2722
	[global::Cpp2ILInjected.Token(Token = "0x4000E6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000AA3 RID: 2723
	[global::Cpp2ILInjected.Token(Token = "0x4000E6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 Location;

	// Token: 0x04000AA4 RID: 2724
	[global::Cpp2ILInjected.Token(Token = "0x4000E6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 FillingSize;

	// Token: 0x04000AA5 RID: 2725
	[global::Cpp2ILInjected.Token(Token = "0x4000E6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Vector2 FillingLocation;

	// Token: 0x04000AA6 RID: 2726
	[global::Cpp2ILInjected.Token(Token = "0x4000E6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color FillingColor;

	// Token: 0x04000AA7 RID: 2727
	[global::Cpp2ILInjected.Token(Token = "0x4000E70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color FillingColorEmpty;
}
