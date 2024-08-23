using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200003B RID: 59
[global::Cpp2ILInjected.Token(Token = "0x200005F")]
public class SimpleProfilerSampleFrame
{
	// Token: 0x06000170 RID: 368 RVA: 0x00021FC8 File Offset: 0x000201C8
	[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A55C", Offset = "0x70A55C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SimpleProfilerSampleFrame()
	{
		throw null;
	}

	// Token: 0x040000FF RID: 255
	[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public SimpleProfilerSampleFrame Next;

	// Token: 0x04000100 RID: 256
	[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int Id;

	// Token: 0x04000101 RID: 257
	[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DateTime StartTime;
}
