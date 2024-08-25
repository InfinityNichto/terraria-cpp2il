using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000199")]
public class ChestSort_Layout : PageControllerLayoutDefinition<ChestSort_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B61")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC474", Offset = "0x9AC474", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public ChestSort_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000CC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout ChestSort;

	[global::Cpp2ILInjected.Token(Token = "0x4000CC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ChestSort_Horizontal;
}
