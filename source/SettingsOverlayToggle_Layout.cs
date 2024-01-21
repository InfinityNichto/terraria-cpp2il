using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200018F")]
public class SettingsOverlayToggle_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001030")]
	public TransactionButton_Layout ToggleButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001031")]
	public Panel_Layout Option1Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001032")]
	public Panel_Layout Option1Disabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001033")]
	public String_Layout Option1Label;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001034")]
	public Color Option1DisabledLabelColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001035")]
	public Panel_Layout Option2Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001036")]
	public Panel_Layout Option2Disabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001037")]
	public String_Layout Option2Label;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001038")]
	public Color Option2DisabledLabelColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001039")]
	public float ElementSpacing;

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x105F5EC", Offset = "0x105F5EC", VA = "0x105F5EC")]
	public SettingsOverlayToggle_Layout()
	{
	}
}
