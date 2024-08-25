using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200012A")]
public class GUIChestQuickStack
{
	[global::Cpp2ILInjected.Token(Token = "0x60007BC")]
	[global::Cpp2ILInjected.Address(RVA = "0x1326AC4", Offset = "0x1326AC4", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIChestQuickStack()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400064C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float scale;
}
