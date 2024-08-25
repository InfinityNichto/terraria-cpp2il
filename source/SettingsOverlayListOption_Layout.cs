using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000214")]
[Serializable]
public class SettingsOverlayListOption_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CC3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAFE0", Offset = "0x9CAFE0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayListOption_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40013D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Option;

	[global::Cpp2ILInjected.Token(Token = "0x40013DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Caption;

	[global::Cpp2ILInjected.Token(Token = "0x40013DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float ElementSpacing;
}
