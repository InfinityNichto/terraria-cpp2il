using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000212")]
[Serializable]
public class SettingsOverlayCycle_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CC1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFEBC", Offset = "0x9CFEBC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayCycle_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40013C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout CycleButton;

	[global::Cpp2ILInjected.Token(Token = "0x40013CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float ElementSpacing;
}
