using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200021B")]
[Serializable]
public class SettingsOverlayVideo_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CCB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D03C4", Offset = "0x9D03C4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayVideo_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001495")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public StringButton_Layout FrameSkip;

	[global::Cpp2ILInjected.Token(Token = "0x4001496")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout BatterySavingMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001497")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout ScreenEffects;

	[global::Cpp2ILInjected.Token(Token = "0x4001498")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout ShowFPS;
}
