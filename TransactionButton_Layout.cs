using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000144")]
public class TransactionButton_Layout : QuickActionButton_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000B57")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3888E4", Offset = "0x3888E4")]
	public TransactionButtonStyle_Layout Style;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000B58")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388940", Offset = "0x388940")]
	public bool DrawLabel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000B59")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3889A0", Offset = "0x3889A0")]
	public bool DrawIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
	[Cpp2IlInjected.Token(Token = "0x4000B5A")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3889EC", Offset = "0x3889EC")]
	public bool DrawItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7B")]
	[Cpp2IlInjected.Token(Token = "0x4000B5B")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388A38", Offset = "0x388A38")]
	public bool DrawControlsIconOnFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000B5C")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388A84", Offset = "0x388A84")]
	public bool ClickOnRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000B5D")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388AD0", Offset = "0x388AD0")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388AD0", Offset = "0x388AD0")]
	public String_Layout Label;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000B5E")]
	public bool MouseHoverFade;

	[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
	[Cpp2IlInjected.Token(Token = "0x4000B5F")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388B5C", Offset = "0x388B5C")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388B5C", Offset = "0x388B5C")]
	public Color DisabledLabelColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
	[Cpp2IlInjected.Token(Token = "0x4000B60")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388BD4", Offset = "0x388BD4")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388BD4", Offset = "0x388BD4")]
	public Color PressedLabelColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8D")]
	[Cpp2IlInjected.Token(Token = "0x4000B61")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388C4C", Offset = "0x388C4C")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388C4C", Offset = "0x388C4C")]
	public bool DisableIconResize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000B62")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388CD8", Offset = "0x388CD8")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388CD8", Offset = "0x388CD8")]
	public Vector2 IconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000B63")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388D50", Offset = "0x388D50")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388D50", Offset = "0x388D50")]
	public bool ForceIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000B64")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388DC8", Offset = "0x388DC8")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388DC8", Offset = "0x388DC8")]
	public float ForcedIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000B65")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388E40", Offset = "0x388E40")]
	public Texture_Layout IconTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000B66")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388E74", Offset = "0x388E74")]
	public Texture_Layout IconTextureHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000B67")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388EA8", Offset = "0x388EA8")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388EA8", Offset = "0x388EA8")]
	public bool DisableIconOnFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x4000B68")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388F34", Offset = "0x388F34")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388F34", Offset = "0x388F34")]
	public bool DisableItemOnFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000B69")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388FC0", Offset = "0x388FC0")]
	public GUIControllerInputButton.LinkedControlType LinkedControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000B6A")]
	private ControllerActionButton _linkedActionMapping;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000B6B")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x388FF4", Offset = "0x388FF4")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x388FF4", Offset = "0x388FF4")]
	public bool DisableControlIconResize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000B6C")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x38906C", Offset = "0x38906C")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x38906C", Offset = "0x38906C")]
	public Vector2 ControlIconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000B6D")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3890E4", Offset = "0x3890E4")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x3890E4", Offset = "0x3890E4")]
	public bool ForceControlIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000B6E")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x38915C", Offset = "0x38915C")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x38915C", Offset = "0x38915C")]
	public float ForcedControlIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000B6F")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3891D4", Offset = "0x3891D4")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x3891D4", Offset = "0x3891D4")]
	public bool DisableItemResize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x4000B70")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389260", Offset = "0x389260")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389260", Offset = "0x389260")]
	public bool ForceItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000B71")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3892D8", Offset = "0x3892D8")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x3892D8", Offset = "0x3892D8")]
	public float ForcedItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000B72")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389350", Offset = "0x389350")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389350", Offset = "0x389350")]
	public Vector2 ItemOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000B73")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3893C8", Offset = "0x3893C8")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x3893C8", Offset = "0x3893C8")]
	public Texture_Layout DefaultItemTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000B74")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389440", Offset = "0x389440")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389440", Offset = "0x389440")]
	public Color ItemColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000B75")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3894CC", Offset = "0x3894CC")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x3894CC", Offset = "0x3894CC")]
	public Color DisabledItemColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000B76")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389558", Offset = "0x389558")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389558", Offset = "0x389558")]
	public Color PressedItemColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000B77")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3895E4", Offset = "0x3895E4")]
	public bool overloadSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000B78")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389630", Offset = "0x389630")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389630", Offset = "0x389630")]
	public Vector2 overloadedSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4000B79")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3896A8", Offset = "0x3896A8")]
	public Texture_Layout HighlightBackingDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000B7A")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3896F4", Offset = "0x3896F4")]
	public Color HighlightDisabledColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000B7B")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389740", Offset = "0x389740")]
	public Texture_Layout HighlightBackingNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000B7C")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x38978C", Offset = "0x38978C")]
	public Color HighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000B7D")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3897D8", Offset = "0x3897D8")]
	public Texture_Layout HighlightBackingPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000B7E")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389824", Offset = "0x389824")]
	public Color HighlightPressedColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000B7F")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389870", Offset = "0x389870")]
	public bool DrawDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000B80")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3898BC", Offset = "0x3898BC")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x3898BC", Offset = "0x3898BC")]
	public Panel_Layout Divider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4000B81")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389948", Offset = "0x389948")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389948", Offset = "0x389948")]
	public bool UseDividerHighlightColours;

	[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
	[Cpp2IlInjected.Token(Token = "0x4000B82")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3899C0", Offset = "0x3899C0")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x3899C0", Offset = "0x3899C0")]
	public Color DividerHighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x119")]
	[Cpp2IlInjected.Token(Token = "0x4000B83")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389A38", Offset = "0x389A38")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389A38", Offset = "0x389A38")]
	public Color DividerHighlightBorderColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x4000B84")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389AB0", Offset = "0x389AB0")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389AB0", Offset = "0x389AB0")]
	public Color DividerPressedColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
	[Cpp2IlInjected.Token(Token = "0x4000B85")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389B28", Offset = "0x389B28")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389B28", Offset = "0x389B28")]
	public Color DividerPressedBorderColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
	[Cpp2IlInjected.Token(Token = "0x4000B86")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389BA0", Offset = "0x389BA0")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389BA0", Offset = "0x389BA0")]
	public Color DividerPressedHighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x129")]
	[Cpp2IlInjected.Token(Token = "0x4000B87")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389C18", Offset = "0x389C18")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389C18", Offset = "0x389C18")]
	public Color DividerPressedHighlightBorderColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x4000B88")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389C90", Offset = "0x389C90")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389C90", Offset = "0x389C90")]
	public Color DividerDisabledColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
	[Cpp2IlInjected.Token(Token = "0x4000B89")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389D08", Offset = "0x389D08")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389D08", Offset = "0x389D08")]
	public Color DividerDisabledBorderColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x135")]
	[Cpp2IlInjected.Token(Token = "0x4000B8A")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389D80", Offset = "0x389D80")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389D80", Offset = "0x389D80")]
	public Color DividerDisabledHighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
	[Cpp2IlInjected.Token(Token = "0x4000B8B")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389DF8", Offset = "0x389DF8")]
	[Cpp2IlInjected.Attribute(Name = "ShowIfAttribute", RVA = "0x389DF8", Offset = "0x389DF8")]
	public Color DividerDisabledHighlightBorderColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000B8C")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389E70", Offset = "0x389E70")]
	public Texture_Layout BorderDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000B8D")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389EBC", Offset = "0x389EBC")]
	public Color DisabledBorderColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000B8E")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389F08", Offset = "0x389F08")]
	public Texture_Layout BorderNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x4000B8F")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389F54", Offset = "0x389F54")]
	public Color NormalBorderColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000B90")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389FA0", Offset = "0x389FA0")]
	public Texture_Layout BorderPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000B91")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x389FEC", Offset = "0x389FEC")]
	public Color PressedBorderColour;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public ControllerActionButton LinkedActionMapping
	{
		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x10D1FA4", Offset = "0x10D1FA4", VA = "0x10D1FA4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x10D1FAC", Offset = "0x10D1FAC", VA = "0x10D1FAC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x10D1F94", Offset = "0x10D1F94", VA = "0x10D1F94")]
	private bool IsNotUsingStyle()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x10D1FB4", Offset = "0x10D1FB4", VA = "0x10D1FB4")]
	public TransactionButton_Layout()
	{
	}
}
