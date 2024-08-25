using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000219")]
[Serializable]
public class SettingsOverlaySlider_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CC9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAFF0", Offset = "0x9CAFF0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlaySlider_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001482")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001483")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Slider_Layout Option;

	[global::Cpp2ILInjected.Token(Token = "0x4001484")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Slider_Layout HueOption;

	[global::Cpp2ILInjected.Token(Token = "0x4001485")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Slider_Layout SaturationOption;

	[global::Cpp2ILInjected.Token(Token = "0x4001486")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Slider_Layout LightOption;

	[global::Cpp2ILInjected.Token(Token = "0x4001487")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout Value;

	[global::Cpp2ILInjected.Token(Token = "0x4001488")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color DisabledNotchColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001489")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color DisabledValueColor;

	[global::Cpp2ILInjected.Token(Token = "0x400148A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float ElementSpacing;
}
