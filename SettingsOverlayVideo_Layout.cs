using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class SettingsOverlayVideo_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400103A")]
	public StringButton_Layout FrameSkip;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400103B")]
	public StringButton_Layout BatterySavingMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400103C")]
	public StringButton_Layout ScreenEffects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400103D")]
	public StringButton_Layout ShowFPS;

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0x105F5F4", Offset = "0x105F5F4", VA = "0x105F5F4")]
	public SettingsOverlayVideo_Layout()
	{
	}
}
