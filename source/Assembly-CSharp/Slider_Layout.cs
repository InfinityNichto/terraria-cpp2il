using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200013B RID: 315
[global::Cpp2ILInjected.Token(Token = "0x20001BA")]
[Serializable]
public class Slider_Layout
{
	// Token: 0x06000AC0 RID: 2752 RVA: 0x00023B85 File Offset: 0x00021D85
	[global::Cpp2ILInjected.Token(Token = "0x6000BCF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B361C", Offset = "0x9B361C", Length = "0x138")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public Slider_Layout()
	{
		throw null;
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00023B88 File Offset: 0x00021D88
	[global::Cpp2ILInjected.Token(Token = "0x6000BD0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC71C", Offset = "0x9AC71C", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClothesWindow_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairWindow_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerCreateMenu_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public Slider_Layout(string backingTexture, string notchTexture)
	{
		throw null;
	}

	// Token: 0x04000ABB RID: 2747
	[global::Cpp2ILInjected.Token(Token = "0x4000EA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Backing;

	// Token: 0x04000ABC RID: 2748
	[global::Cpp2ILInjected.Token(Token = "0x4000EA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Color BackingColour;

	// Token: 0x04000ABD RID: 2749
	[global::Cpp2ILInjected.Token(Token = "0x4000EA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Texture_Layout Notch;

	// Token: 0x04000ABE RID: 2750
	[global::Cpp2ILInjected.Token(Token = "0x4000EA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Color NotchColour;

	// Token: 0x04000ABF RID: 2751
	[global::Cpp2ILInjected.Token(Token = "0x4000EA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout BackingHighlight;

	// Token: 0x04000AC0 RID: 2752
	[global::Cpp2ILInjected.Token(Token = "0x4000EAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Color BackingHighlightColour;

	// Token: 0x04000AC1 RID: 2753
	[global::Cpp2ILInjected.Token(Token = "0x4000EAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Texture_Layout NotchHighlight;

	// Token: 0x04000AC2 RID: 2754
	[global::Cpp2ILInjected.Token(Token = "0x4000EAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Color NotchHighlightColour;

	// Token: 0x04000AC3 RID: 2755
	[global::Cpp2ILInjected.Token(Token = "0x4000EAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float SliderEndCap;

	// Token: 0x04000AC4 RID: 2756
	[global::Cpp2ILInjected.Token(Token = "0x4000EAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float BackingScale;

	// Token: 0x04000AC5 RID: 2757
	[global::Cpp2ILInjected.Token(Token = "0x4000EAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float NotchScale;

	// Token: 0x04000AC6 RID: 2758
	[global::Cpp2ILInjected.Token(Token = "0x4000EB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 PickBorder;

	// Token: 0x04000AC7 RID: 2759
	[global::Cpp2ILInjected.Token(Token = "0x4000EB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public bool Vertical;

	// Token: 0x04000AC8 RID: 2760
	[global::Cpp2ILInjected.Token(Token = "0x4000EB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000AC9 RID: 2761
	[global::Cpp2ILInjected.Token(Token = "0x4000EB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000ACA RID: 2762
	[global::Cpp2ILInjected.Token(Token = "0x4000EB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public Vector2 Location;
}
