using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200005F")]
public class SimpleProfilerSampleFrame
{
	[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A55C", Offset = "0x70A55C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SimpleProfilerSampleFrame()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public SimpleProfilerSampleFrame Next;

	[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int Id;

	[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DateTime StartTime;
}
