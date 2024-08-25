using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x200021A")]
[Serializable]
public class SettingsOverlayToggle_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CCA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CB000", Offset = "0x9CB000", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayToggle_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400148B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout ToggleButton;

	[global::Cpp2ILInjected.Token(Token = "0x400148C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Option1Enabled;

	[global::Cpp2ILInjected.Token(Token = "0x400148D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Option1Disabled;

	[global::Cpp2ILInjected.Token(Token = "0x400148E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout Option1Label;

	[global::Cpp2ILInjected.Token(Token = "0x400148F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Color Option1DisabledLabelColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001490")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout Option2Enabled;

	[global::Cpp2ILInjected.Token(Token = "0x4001491")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout Option2Disabled;

	[global::Cpp2ILInjected.Token(Token = "0x4001492")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout Option2Label;

	[global::Cpp2ILInjected.Token(Token = "0x4001493")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Color Option2DisabledLabelColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001494")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float ElementSpacing;
}
