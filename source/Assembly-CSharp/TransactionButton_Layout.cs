using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;

// Token: 0x02000143 RID: 323
[global::Cpp2ILInjected.Token(Token = "0x20001C4")]
[Serializable]
public class TransactionButton_Layout : QuickActionButton_Layout
{
	// Token: 0x06000AD8 RID: 2776 RVA: 0x00023BCD File Offset: 0x00021DCD
	[global::Cpp2ILInjected.Token(Token = "0x6000BE7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B4E18", Offset = "0x9B4E18", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	private bool IsNotUsingStyle()
	{
		throw null;
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00023BD0 File Offset: 0x00021DD0
	// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00023BD3 File Offset: 0x00021DD3
	[global::Cpp2ILInjected.Token(Token = "0x17000146")]
	public ControllerActionButton LinkedActionMapping
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B4E28", Offset = "0x9B4E28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000BE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B4E30", Offset = "0x9B4E30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00023BD6 File Offset: 0x00021DD6
	[global::Cpp2ILInjected.Token(Token = "0x6000BEA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B4E38", Offset = "0x9B4E38", Length = "0x40C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QuickActionButton_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public TransactionButton_Layout()
	{
		throw null;
	}

	// Token: 0x04000B4E RID: 2894
	[BoxGroup("Style", -1, null, "IsNotUsingStyle")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButtonStyle_Layout Style;

	// Token: 0x04000B4F RID: 2895
	[BoxGroup("Setup", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public bool DrawLabel;

	// Token: 0x04000B50 RID: 2896
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
	public bool DrawIcon;

	// Token: 0x04000B51 RID: 2897
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA2")]
	public bool DrawItem;

	// Token: 0x04000B52 RID: 2898
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA3")]
	public bool DrawControlsIconOnFocus;

	// Token: 0x04000B53 RID: 2899
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public bool ClickOnRelease;

	// Token: 0x04000B54 RID: 2900
	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout Label;

	// Token: 0x04000B55 RID: 2901
	[global::Cpp2ILInjected.Token(Token = "0x4000F45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public bool MouseHoverFade;

	// Token: 0x04000B56 RID: 2902
	[BoxGroup("Label", -1, null, null)]
	[ShowIf("DrawLabel")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB1")]
	public Color DisabledLabelColour;

	// Token: 0x04000B57 RID: 2903
	[BoxGroup("Label", -1, null, null)]
	[ShowIf("DrawLabel")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F47")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB5")]
	public Color PressedLabelColour;

	// Token: 0x04000B58 RID: 2904
	[BoxGroup("Icon", -1, "Style", null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F48")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB9")]
	public bool DisableIconResize;

	// Token: 0x04000B59 RID: 2905
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F49")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public Vector2 IconOffset;

	// Token: 0x04000B5A RID: 2906
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public bool ForceIconScale;

	// Token: 0x04000B5B RID: 2907
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public float ForcedIconScale;

	// Token: 0x04000B5C RID: 2908
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Texture_Layout IconTexture;

	// Token: 0x04000B5D RID: 2909
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Texture_Layout IconTextureHighlight;

	// Token: 0x04000B5E RID: 2910
	[ShowIf("DrawControlsIconOnFocus")]
	[BoxGroup("Controls", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public bool DisableIconOnFocus;

	// Token: 0x04000B5F RID: 2911
	[BoxGroup("Controls", -1, "Style", null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE1")]
	public bool DisableItemOnFocus;

	// Token: 0x04000B60 RID: 2912
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	public GUIControllerInputButton.LinkedControlType LinkedControl;

	// Token: 0x04000B61 RID: 2913
	[global::Cpp2ILInjected.Token(Token = "0x4000F51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	private ControllerActionButton _linkedActionMapping;

	// Token: 0x04000B62 RID: 2914
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public bool DisableControlIconResize;

	// Token: 0x04000B63 RID: 2915
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public Vector2 ControlIconOffset;

	// Token: 0x04000B64 RID: 2916
	[ShowIf("DrawControlsIconOnFocus")]
	[BoxGroup("Controls", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	public bool ForceControlIconScale;

	// Token: 0x04000B65 RID: 2917
	[ShowIf("DrawControlsIconOnFocus")]
	[BoxGroup("Controls", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public float ForcedControlIconScale;

	// Token: 0x04000B66 RID: 2918
	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
	public bool DisableItemResize;

	// Token: 0x04000B67 RID: 2919
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x105")]
	public bool ForceItemScale;

	// Token: 0x04000B68 RID: 2920
	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public float ForcedItemScale;

	// Token: 0x04000B69 RID: 2921
	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
	public Vector2 ItemOffset;

	// Token: 0x04000B6A RID: 2922
	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Texture_Layout DefaultItemTexture;

	// Token: 0x04000B6B RID: 2923
	[BoxGroup("Normal", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Color ItemColour;

	// Token: 0x04000B6C RID: 2924
	[BoxGroup("Disabled", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
	public Color DisabledItemColour;

	// Token: 0x04000B6D RID: 2925
	[BoxGroup("Pressed", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Color PressedItemColour;

	// Token: 0x04000B6E RID: 2926
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
	public bool overloadSize;

	// Token: 0x04000B6F RID: 2927
	[BoxGroup("Setup", -1, null, null)]
	[ShowIf("overloadSize")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Vector2 overloadedSize;

	// Token: 0x04000B70 RID: 2928
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public Texture_Layout HighlightBackingDisabled;

	// Token: 0x04000B71 RID: 2929
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public Color HighlightDisabledColour;

	// Token: 0x04000B72 RID: 2930
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Texture_Layout HighlightBackingNormal;

	// Token: 0x04000B73 RID: 2931
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Color HighlightColour;

	// Token: 0x04000B74 RID: 2932
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Texture_Layout HighlightBackingPressed;

	// Token: 0x04000B75 RID: 2933
	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public Color HighlightPressedColour;

	// Token: 0x04000B76 RID: 2934
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	public bool DrawDivider;

	// Token: 0x04000B77 RID: 2935
	[BoxGroup("Divider", -1, "Style", null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout Divider;

	// Token: 0x04000B78 RID: 2936
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public bool UseDividerHighlightColours;

	// Token: 0x04000B79 RID: 2937
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x171")]
	public Color DividerHighlightColour;

	// Token: 0x04000B7A RID: 2938
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x175")]
	public Color DividerHighlightBorderColour;

	// Token: 0x04000B7B RID: 2939
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x179")]
	public Color DividerPressedColour;

	// Token: 0x04000B7C RID: 2940
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x17D")]
	public Color DividerPressedBorderColour;

	// Token: 0x04000B7D RID: 2941
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x181")]
	public Color DividerPressedHighlightColour;

	// Token: 0x04000B7E RID: 2942
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x185")]
	public Color DividerPressedHighlightBorderColour;

	// Token: 0x04000B7F RID: 2943
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x189")]
	public Color DividerDisabledColour;

	// Token: 0x04000B80 RID: 2944
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18D")]
	public Color DividerDisabledBorderColour;

	// Token: 0x04000B81 RID: 2945
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x191")]
	public Color DividerDisabledHighlightColour;

	// Token: 0x04000B82 RID: 2946
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x195")]
	public Color DividerDisabledHighlightBorderColour;

	// Token: 0x04000B83 RID: 2947
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public Texture_Layout BorderDisabled;

	// Token: 0x04000B84 RID: 2948
	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public Color DisabledBorderColour;

	// Token: 0x04000B85 RID: 2949
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public Texture_Layout BorderNormal;

	// Token: 0x04000B86 RID: 2950
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public Color NormalBorderColour;

	// Token: 0x04000B87 RID: 2951
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public Texture_Layout BorderPressed;

	// Token: 0x04000B88 RID: 2952
	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public Color PressedBorderColour;
}
