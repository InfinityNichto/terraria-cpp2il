using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200013D RID: 317
[global::Cpp2ILInjected.Token(Token = "0x20001BC")]
[Serializable]
public class StringButton_Layout
{
	// Token: 0x06000AC3 RID: 2755 RVA: 0x00023B8E File Offset: 0x00021D8E
	[global::Cpp2ILInjected.Token(Token = "0x6000BD2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B3840", Offset = "0x9B3840", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawTitle", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public SpriteFont GetFont()
	{
		throw null;
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00023B91 File Offset: 0x00021D91
	[global::Cpp2ILInjected.Token(Token = "0x6000BD3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B38C0", Offset = "0x9B38C0", Length = "0x344")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public StringButton_Layout()
	{
		throw null;
	}

	// Token: 0x04000AD3 RID: 2771
	[global::Cpp2ILInjected.Token(Token = "0x4000EBD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000AD4 RID: 2772
	[global::Cpp2ILInjected.Token(Token = "0x4000EBE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000AD5 RID: 2773
	[global::Cpp2ILInjected.Token(Token = "0x4000EBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;

	// Token: 0x04000AD6 RID: 2774
	[global::Cpp2ILInjected.Token(Token = "0x4000EC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 Size;

	// Token: 0x04000AD7 RID: 2775
	[global::Cpp2ILInjected.Token(Token = "0x4000EC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 PickBorder;

	// Token: 0x04000AD8 RID: 2776
	[global::Cpp2ILInjected.Token(Token = "0x4000EC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 PickOffset;

	// Token: 0x04000AD9 RID: 2777
	[global::Cpp2ILInjected.Token(Token = "0x4000EC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int TextInset;

	// Token: 0x04000ADA RID: 2778
	[global::Cpp2ILInjected.Token(Token = "0x4000EC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Color BackingColor;

	// Token: 0x04000ADB RID: 2779
	[global::Cpp2ILInjected.Token(Token = "0x4000EC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color DisabledBackingColour;

	// Token: 0x04000ADC RID: 2780
	[global::Cpp2ILInjected.Token(Token = "0x4000EC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color PressedBackingColour;

	// Token: 0x04000ADD RID: 2781
	[global::Cpp2ILInjected.Token(Token = "0x4000EC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Color BorderColor;

	// Token: 0x04000ADE RID: 2782
	[global::Cpp2ILInjected.Token(Token = "0x4000EC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public Color DisabledBorderColour;

	// Token: 0x04000ADF RID: 2783
	[global::Cpp2ILInjected.Token(Token = "0x4000EC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Color PressedBorderColour;

	// Token: 0x04000AE0 RID: 2784
	[global::Cpp2ILInjected.Token(Token = "0x4000ECA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public Color TextColour;

	// Token: 0x04000AE1 RID: 2785
	[global::Cpp2ILInjected.Token(Token = "0x4000ECB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Color DisabledTextColour;

	// Token: 0x04000AE2 RID: 2786
	[global::Cpp2ILInjected.Token(Token = "0x4000ECC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public Color PressedTextColour;

	// Token: 0x04000AE3 RID: 2787
	[global::Cpp2ILInjected.Token(Token = "0x4000ECD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float Scale;

	// Token: 0x04000AE4 RID: 2788
	[global::Cpp2ILInjected.Token(Token = "0x4000ECE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public float DisabledScale;

	// Token: 0x04000AE5 RID: 2789
	[global::Cpp2ILInjected.Token(Token = "0x4000ECF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public float PressedScale;

	// Token: 0x04000AE6 RID: 2790
	[global::Cpp2ILInjected.Token(Token = "0x4000ED0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public float ScaleSpeed;

	// Token: 0x04000AE7 RID: 2791
	[global::Cpp2ILInjected.Token(Token = "0x4000ED1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Texture_Layout BackingDisabled;

	// Token: 0x04000AE8 RID: 2792
	[global::Cpp2ILInjected.Token(Token = "0x4000ED2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout BorderDisabled;

	// Token: 0x04000AE9 RID: 2793
	[global::Cpp2ILInjected.Token(Token = "0x4000ED3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Texture_Layout BackingNormal;

	// Token: 0x04000AEA RID: 2794
	[global::Cpp2ILInjected.Token(Token = "0x4000ED4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout BorderNormal;

	// Token: 0x04000AEB RID: 2795
	[global::Cpp2ILInjected.Token(Token = "0x4000ED5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Texture_Layout BackingPressed;

	// Token: 0x04000AEC RID: 2796
	[global::Cpp2ILInjected.Token(Token = "0x4000ED6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Texture_Layout BorderPressed;

	// Token: 0x04000AED RID: 2797
	[global::Cpp2ILInjected.Token(Token = "0x4000ED7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Texture_Layout BackingHighlightPressed;

	// Token: 0x04000AEE RID: 2798
	[global::Cpp2ILInjected.Token(Token = "0x4000ED8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Vector2 HighlightSize;

	// Token: 0x04000AEF RID: 2799
	[global::Cpp2ILInjected.Token(Token = "0x4000ED9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color HighlightColour;

	// Token: 0x04000AF0 RID: 2800
	[global::Cpp2ILInjected.Token(Token = "0x4000EDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Texture_Layout OverBackingHighlight;

	// Token: 0x04000AF1 RID: 2801
	[global::Cpp2ILInjected.Token(Token = "0x4000EDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public StringButton_Layout.FontType RenderFont;

	// Token: 0x020007E0 RID: 2016
	[global::Cpp2ILInjected.Token(Token = "0x20001BD")]
	public enum FontType
	{
		// Token: 0x04007BB5 RID: 31669
		[global::Cpp2ILInjected.Token(Token = "0x4000EDD")]
		MouseText,
		// Token: 0x04007BB6 RID: 31670
		[global::Cpp2ILInjected.Token(Token = "0x4000EDE")]
		DeathText
	}
}
