using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;

// Token: 0x02000140 RID: 320
[global::Cpp2ILInjected.Token(Token = "0x20001C1")]
[Serializable]
public class TransactionButtonStyle_Definition
{
	// Token: 0x06000ACB RID: 2763 RVA: 0x00023BA6 File Offset: 0x00021DA6
	[global::Cpp2ILInjected.Token(Token = "0x6000BDA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B3F84", Offset = "0x9B3F84", Length = "0x2F8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "RefreshFields", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(object),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Panel_Layout), Member = "Copy", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(void))]
	public void Apply(TransactionButton_Layout layout)
	{
		throw null;
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00023BA9 File Offset: 0x00021DA9
	[global::Cpp2ILInjected.Token(Token = "0x6000BDB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B427C", Offset = "0x9B427C", Length = "0x360")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Panel_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Panel_Layout), Member = "Copy", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void Copy(TransactionButton_Layout layout)
	{
		throw null;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00023BAC File Offset: 0x00021DAC
	[global::Cpp2ILInjected.Token(Token = "0x6000BDC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B45DC", Offset = "0x9B45DC", Length = "0x594")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
	public TransactionButtonStyle_Definition()
	{
		throw null;
	}

	// Token: 0x04000AFF RID: 2815
	[BoxGroup("Style", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string StyleId;

	// Token: 0x04000B00 RID: 2816
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float Scale;

	// Token: 0x04000B01 RID: 2817
	[BoxGroup("Picking", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public Vector2 PickBorder;

	// Token: 0x04000B02 RID: 2818
	[BoxGroup("Picking", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Vector2 PickOffset;

	// Token: 0x04000B03 RID: 2819
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Color Color;

	// Token: 0x04000B04 RID: 2820
	[BoxGroup("Picking", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool UseCirclePickingRegion;

	// Token: 0x04000B05 RID: 2821
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
	public Color DisabledColour;

	// Token: 0x04000B06 RID: 2822
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
	public Color PressedColour;

	// Token: 0x04000B07 RID: 2823
	[ShowIf("DrawIcon")]
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
	public Color IconColour;

	// Token: 0x04000B08 RID: 2824
	[BoxGroup("Disabled", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D")]
	public Color DisabledIconColour;

	// Token: 0x04000B09 RID: 2825
	[BoxGroup("Pressed", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
	public Color PressedIconColour;

	// Token: 0x04000B0A RID: 2826
	[BoxGroup("Highlight", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
	public Color LabelHighlightTint;

	// Token: 0x04000B0B RID: 2827
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float ScaleSpeed;

	// Token: 0x04000B0C RID: 2828
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float DisabledScale;

	// Token: 0x04000B0D RID: 2829
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float PressedScale;

	// Token: 0x04000B0E RID: 2830
	[BoxGroup("Icon", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public int IconMaxSizeInset;

	// Token: 0x04000B0F RID: 2831
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Texture_Layout BackingDisabled;

	// Token: 0x04000B10 RID: 2832
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Texture_Layout BackingNormal;

	// Token: 0x04000B11 RID: 2833
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Texture_Layout BackingPressed;

	// Token: 0x04000B12 RID: 2834
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout BackingPressedHighlight;

	// Token: 0x04000B13 RID: 2835
	[BoxGroup("Pressed", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Color BackingPressedHighlightColour;

	// Token: 0x04000B14 RID: 2836
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout OverBackingHighlight;

	// Token: 0x04000B15 RID: 2837
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Texture_Layout HighlightBackingDisabled;

	// Token: 0x04000B16 RID: 2838
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Color HighlightDisabledColour;

	// Token: 0x04000B17 RID: 2839
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Texture_Layout HighlightBackingNormal;

	// Token: 0x04000B18 RID: 2840
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Color HighlightColour;

	// Token: 0x04000B19 RID: 2841
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Texture_Layout HighlightBackingPressed;

	// Token: 0x04000B1A RID: 2842
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Color HighlightPressedColour;

	// Token: 0x04000B1B RID: 2843
	[BoxGroup("Setup", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public bool DrawLabel;

	// Token: 0x04000B1C RID: 2844
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBD")]
	public bool DrawIcon;

	// Token: 0x04000B1D RID: 2845
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBE")]
	public bool DrawItem;

	// Token: 0x04000B1E RID: 2846
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBF")]
	public bool DrawControlsIconOnFocus;

	// Token: 0x04000B1F RID: 2847
	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout Label;

	// Token: 0x04000B20 RID: 2848
	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Color DisabledLabelColour;

	// Token: 0x04000B21 RID: 2849
	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	public Color PressedLabelColour;

	// Token: 0x04000B22 RID: 2850
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public bool DisableIconResize;

	// Token: 0x04000B23 RID: 2851
	[BoxGroup("Icon", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
	public Vector2 IconOffset;

	// Token: 0x04000B24 RID: 2852
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	public bool ForceIconScale;

	// Token: 0x04000B25 RID: 2853
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public float ForcedIconScale;

	// Token: 0x04000B26 RID: 2854
	[BoxGroup("Controls", -1, "Style", null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F16")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	public bool DisableIconOnFocus;

	// Token: 0x04000B27 RID: 2855
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE5")]
	public bool DisableControlIconResize;

	// Token: 0x04000B28 RID: 2856
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Vector2 ControlIconOffset;

	// Token: 0x04000B29 RID: 2857
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public bool ForceControlIconScale;

	// Token: 0x04000B2A RID: 2858
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public float ForcedControlIconScale;

	// Token: 0x04000B2B RID: 2859
	[BoxGroup("Item", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public bool DisableItemResize;

	// Token: 0x04000B2C RID: 2860
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF9")]
	public bool ForceItemScale;

	// Token: 0x04000B2D RID: 2861
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	public float ForcedItemScale;

	// Token: 0x04000B2E RID: 2862
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Vector2 ItemOffset;

	// Token: 0x04000B2F RID: 2863
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Texture_Layout DefaultItemTexture;

	// Token: 0x04000B30 RID: 2864
	[BoxGroup("Normal", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Color ItemColour;

	// Token: 0x04000B31 RID: 2865
	[BoxGroup("Disabled", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
	public Color DisabledItemColour;

	// Token: 0x04000B32 RID: 2866
	[BoxGroup("Pressed", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Color PressedItemColour;

	// Token: 0x04000B33 RID: 2867
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
	public bool overloadSize;

	// Token: 0x04000B34 RID: 2868
	[ShowIf("overloadSize")]
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Vector2 overloadedSize;

	// Token: 0x04000B35 RID: 2869
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public bool DrawDivider;

	// Token: 0x04000B36 RID: 2870
	[BoxGroup("Divider", -1, "Style", null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Panel_Layout Divider;

	// Token: 0x04000B37 RID: 2871
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public bool UseDividerHighlightColours;

	// Token: 0x04000B38 RID: 2872
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x139")]
	public Color DividerHighlightColour;

	// Token: 0x04000B39 RID: 2873
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13D")]
	public Color DividerHighlightBorderColour;

	// Token: 0x04000B3A RID: 2874
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x141")]
	public Color DividerPressedColour;

	// Token: 0x04000B3B RID: 2875
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x145")]
	public Color DividerPressedBorderColour;

	// Token: 0x04000B3C RID: 2876
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x149")]
	public Color DividerPressedHighlightColour;

	// Token: 0x04000B3D RID: 2877
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14D")]
	public Color DividerPressedHighlightBorderColour;

	// Token: 0x04000B3E RID: 2878
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x151")]
	public Color DividerDisabledColour;

	// Token: 0x04000B3F RID: 2879
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x155")]
	public Color DividerDisabledBorderColour;

	// Token: 0x04000B40 RID: 2880
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
	public Color DividerDisabledHighlightColour;

	// Token: 0x04000B41 RID: 2881
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15D")]
	public Color DividerDisabledHighlightBorderColour;

	// Token: 0x04000B42 RID: 2882
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Texture_Layout BorderDisabled;

	// Token: 0x04000B43 RID: 2883
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public Color DisabledBorderColour;

	// Token: 0x04000B44 RID: 2884
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Texture_Layout BorderNormal;

	// Token: 0x04000B45 RID: 2885
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public Color NormalBorderColour;

	// Token: 0x04000B46 RID: 2886
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public Texture_Layout BorderPressed;

	// Token: 0x04000B47 RID: 2887
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public Color PressedBorderColour;
}
