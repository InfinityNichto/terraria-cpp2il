using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001FF")]
public class LowMemoryPopup_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C9E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF248", Offset = "0x9CF248", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C9F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF294", Offset = "0x9CF294", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public LowMemoryPopup_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40012A9")]
	public static LowMemoryPopup_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40012AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x40012AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Cancel;

	[global::Cpp2ILInjected.Token(Token = "0x40012AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Continue;
}
