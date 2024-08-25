using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000198")]
public class ChestQuickStack_Layout : PageControllerLayoutDefinition<ChestQuickStack_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B60")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC42C", Offset = "0x9AC42C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public ChestQuickStack_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000CC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout ChestQuickStack;

	[global::Cpp2ILInjected.Token(Token = "0x4000CC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ChestQuickStack_Horizontal;
}
