using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;

[global::Cpp2ILInjected.Token(Token = "0x20001C1")]
[Serializable]
public class TransactionButtonStyle_Definition
{
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

	[BoxGroup("Style", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string StyleId;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float Scale;

	[BoxGroup("Picking", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public Vector2 PickBorder;

	[BoxGroup("Picking", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Vector2 PickOffset;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Color Color;

	[BoxGroup("Picking", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool UseCirclePickingRegion;

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
	public Color DisabledColour;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
	public Color PressedColour;

	[ShowIf("DrawIcon")]
	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
	public Color IconColour;

	[BoxGroup("Disabled", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D")]
	public Color DisabledIconColour;

	[BoxGroup("Pressed", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000EF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
	public Color PressedIconColour;

	[BoxGroup("Highlight", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
	public Color LabelHighlightTint;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float ScaleSpeed;

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float DisabledScale;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float PressedScale;

	[BoxGroup("Icon", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public int IconMaxSizeInset;

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000EFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Texture_Layout BackingDisabled;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Texture_Layout BackingNormal;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Texture_Layout BackingPressed;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout BackingPressedHighlight;

	[BoxGroup("Pressed", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Color BackingPressedHighlightColour;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout OverBackingHighlight;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Texture_Layout HighlightBackingDisabled;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Color HighlightDisabledColour;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Texture_Layout HighlightBackingNormal;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Color HighlightColour;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Texture_Layout HighlightBackingPressed;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Color HighlightPressedColour;

	[BoxGroup("Setup", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public bool DrawLabel;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBD")]
	public bool DrawIcon;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBE")]
	public bool DrawItem;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBF")]
	public bool DrawControlsIconOnFocus;

	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout Label;

	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Color DisabledLabelColour;

	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	public Color PressedLabelColour;

	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public bool DisableIconResize;

	[BoxGroup("Icon", -1, null, null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
	public Vector2 IconOffset;

	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	public bool ForceIconScale;

	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public float ForcedIconScale;

	[BoxGroup("Controls", -1, "Style", null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F16")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	public bool DisableIconOnFocus;

	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE5")]
	public bool DisableControlIconResize;

	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Vector2 ControlIconOffset;

	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public bool ForceControlIconScale;

	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public float ForcedControlIconScale;

	[BoxGroup("Item", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public bool DisableItemResize;

	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF9")]
	public bool ForceItemScale;

	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	public float ForcedItemScale;

	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Vector2 ItemOffset;

	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Texture_Layout DefaultItemTexture;

	[BoxGroup("Normal", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Color ItemColour;

	[BoxGroup("Disabled", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
	public Color DisabledItemColour;

	[BoxGroup("Pressed", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Color PressedItemColour;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
	public bool overloadSize;

	[ShowIf("overloadSize")]
	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Vector2 overloadedSize;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public bool DrawDivider;

	[BoxGroup("Divider", -1, "Style", null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Panel_Layout Divider;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public bool UseDividerHighlightColours;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x139")]
	public Color DividerHighlightColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13D")]
	public Color DividerHighlightBorderColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x141")]
	public Color DividerPressedColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x145")]
	public Color DividerPressedBorderColour;

	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x149")]
	public Color DividerPressedHighlightColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14D")]
	public Color DividerPressedHighlightBorderColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x151")]
	public Color DividerDisabledColour;

	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x155")]
	public Color DividerDisabledBorderColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
	public Color DividerDisabledHighlightColour;

	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15D")]
	public Color DividerDisabledHighlightBorderColour;

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Texture_Layout BorderDisabled;

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public Color DisabledBorderColour;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Texture_Layout BorderNormal;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public Color NormalBorderColour;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public Texture_Layout BorderPressed;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public Color PressedBorderColour;
}
