using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200018E")]
public class SettingsOverlaySlider_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001027")]
	public TransactionButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001028")]
	public Slider_Layout Option;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001029")]
	public Slider_Layout HueOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400102A")]
	public Slider_Layout SaturationOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400102B")]
	public Slider_Layout LightOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400102C")]
	public String_Layout Value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400102D")]
	public Color DisabledNotchColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400102E")]
	public Color DisabledValueColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400102F")]
	public float ElementSpacing;

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x105F5E4", Offset = "0x105F5E4", VA = "0x105F5E4")]
	public SettingsOverlaySlider_Layout()
	{
	}
}
