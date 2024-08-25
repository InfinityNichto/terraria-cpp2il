using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;

[global::Cpp2ILInjected.Token(Token = "0x20001C4")]
[Serializable]
public class TransactionButton_Layout : QuickActionButton_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BE7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B4E18", Offset = "0x9B4E18", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	private bool IsNotUsingStyle()
	{
		throw null;
	}

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

	[BoxGroup("Style", -1, null, "IsNotUsingStyle")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButtonStyle_Layout Style;

	[BoxGroup("Setup", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public bool DrawLabel;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
	public bool DrawIcon;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA2")]
	public bool DrawItem;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA3")]
	public bool DrawControlsIconOnFocus;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public bool ClickOnRelease;

	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout Label;

	[global::Cpp2ILInjected.Token(Token = "0x4000F45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public bool MouseHoverFade;

	[BoxGroup("Label", -1, null, null)]
	[ShowIf("DrawLabel")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB1")]
	public Color DisabledLabelColour;

	[BoxGroup("Label", -1, null, null)]
	[ShowIf("DrawLabel")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F47")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB5")]
	public Color PressedLabelColour;

	[BoxGroup("Icon", -1, "Style", null)]
	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F48")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB9")]
	public bool DisableIconResize;

	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F49")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public Vector2 IconOffset;

	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public bool ForceIconScale;

	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public float ForcedIconScale;

	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Texture_Layout IconTexture;

	[ShowIf("DrawIcon")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Texture_Layout IconTextureHighlight;

	[ShowIf("DrawControlsIconOnFocus")]
	[BoxGroup("Controls", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public bool DisableIconOnFocus;

	[BoxGroup("Controls", -1, "Style", null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F4F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE1")]
	public bool DisableItemOnFocus;

	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	public GUIControllerInputButton.LinkedControlType LinkedControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000F51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	private ControllerActionButton _linkedActionMapping;

	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public bool DisableControlIconResize;

	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public Vector2 ControlIconOffset;

	[ShowIf("DrawControlsIconOnFocus")]
	[BoxGroup("Controls", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	public bool ForceControlIconScale;

	[ShowIf("DrawControlsIconOnFocus")]
	[BoxGroup("Controls", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public float ForcedControlIconScale;

	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
	public bool DisableItemResize;

	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x105")]
	public bool ForceItemScale;

	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public float ForcedItemScale;

	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
	public Vector2 ItemOffset;

	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Texture_Layout DefaultItemTexture;

	[BoxGroup("Normal", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Color ItemColour;

	[BoxGroup("Disabled", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
	public Color DisabledItemColour;

	[BoxGroup("Pressed", -1, "Style", null)]
	[ShowIf("DrawItem")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Color PressedItemColour;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
	public bool overloadSize;

	[BoxGroup("Setup", -1, null, null)]
	[ShowIf("overloadSize")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Vector2 overloadedSize;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public Texture_Layout HighlightBackingDisabled;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public Color HighlightDisabledColour;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Texture_Layout HighlightBackingNormal;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Color HighlightColour;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Texture_Layout HighlightBackingPressed;

	[BoxGroup("Highlight", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public Color HighlightPressedColour;

	[BoxGroup("Setup", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	public bool DrawDivider;

	[BoxGroup("Divider", -1, "Style", null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout Divider;

	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public bool UseDividerHighlightColours;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x171")]
	public Color DividerHighlightColour;

	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x175")]
	public Color DividerHighlightBorderColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x179")]
	public Color DividerPressedColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x17D")]
	public Color DividerPressedBorderColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x181")]
	public Color DividerPressedHighlightColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x185")]
	public Color DividerPressedHighlightBorderColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x189")]
	public Color DividerDisabledColour;

	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18D")]
	public Color DividerDisabledBorderColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x191")]
	public Color DividerDisabledHighlightColour;

	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	[global::Cpp2ILInjected.Token(Token = "0x4000F72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x195")]
	public Color DividerDisabledHighlightBorderColour;

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public Texture_Layout BorderDisabled;

	[BoxGroup("Disabled", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public Color DisabledBorderColour;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public Texture_Layout BorderNormal;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public Color NormalBorderColour;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public Texture_Layout BorderPressed;

	[BoxGroup("Pressed", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000F78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public Color PressedBorderColour;
}
