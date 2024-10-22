﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001BC")]
[Serializable]
public class StringButton_Layout
{
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

	[global::Cpp2ILInjected.Token(Token = "0x4000EBD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000EBE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000EBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 Size;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 PickBorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 PickOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int TextInset;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Color BackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color DisabledBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color PressedBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Color BorderColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public Color DisabledBorderColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000EC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Color PressedBorderColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000ECA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public Color TextColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000ECB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Color DisabledTextColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000ECC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public Color PressedTextColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000ECD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4000ECE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public float DisabledScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000ECF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public float PressedScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public float ScaleSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Texture_Layout BackingDisabled;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout BorderDisabled;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Texture_Layout BackingNormal;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout BorderNormal;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Texture_Layout BackingPressed;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Texture_Layout BorderPressed;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Texture_Layout BackingHighlightPressed;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Vector2 HighlightSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000ED9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color HighlightColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000EDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Texture_Layout OverBackingHighlight;

	[global::Cpp2ILInjected.Token(Token = "0x4000EDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public StringButton_Layout.FontType RenderFont;

	[global::Cpp2ILInjected.Token(Token = "0x20001BD")]
	public enum FontType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000EDD")]
		MouseText,
		[global::Cpp2ILInjected.Token(Token = "0x4000EDE")]
		DeathText
	}
}
