using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000200")]
public class LowMemorySettings_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CA0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF2EC", Offset = "0x9CF2EC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CA1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF338", Offset = "0x9CF338", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public LowMemorySettings_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40012AD")]
	public static LowMemorySettings_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40012AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x40012AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Cancel;

	[global::Cpp2ILInjected.Token(Token = "0x40012B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Continue;
}
