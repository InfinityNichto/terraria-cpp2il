using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200003A RID: 58
[global::Cpp2ILInjected.Token(Token = "0x200005E")]
public class SimpleProfilerFrameData
{
	// Token: 0x0600016E RID: 366 RVA: 0x00021FC2 File Offset: 0x000201C2
	[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A43C", Offset = "0x70A43C", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleProfiler), Member = "Initialise", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public SimpleProfilerFrameData(int size)
	{
		throw null;
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00021FC5 File Offset: 0x000201C5
	[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A694", Offset = "0x70A694", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleProfiler), Member = "BeginFrame", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x040000FB RID: 251
	[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public long Overheads;

	// Token: 0x040000FC RID: 252
	[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public long FrameTime;

	// Token: 0x040000FD RID: 253
	[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public readonly int[] CallCount;

	// Token: 0x040000FE RID: 254
	[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public readonly long[] ExececutionTime;
}
