using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.Internal
{
	// Token: 0x02000068 RID: 104
	[global::Cpp2ILInjected.Token(Token = "0x2000075")]
	public class RingBuffer<T>
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x00003026 File Offset: 0x00001226
		[global::Cpp2ILInjected.Token(Token = "0x6000570")]
		[global::Cpp2ILInjected.Address(RVA = "0x1862E10", Offset = "0x1862E10", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public RingBuffer(int size)
		{
			throw null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00003029 File Offset: 0x00001229
		[global::Cpp2ILInjected.Token(Token = "0x6000571")]
		[global::Cpp2ILInjected.Address(RVA = "0x1862F00", Offset = "0x1862F00", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Enqueue(T value)
		{
			throw null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000302C File Offset: 0x0000122C
		[global::Cpp2ILInjected.Token(Token = "0x6000572")]
		[global::Cpp2ILInjected.Address(RVA = "0x1863000", Offset = "0x1863000", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public T Dequeue()
		{
			throw null;
		}

		// Token: 0x040003B8 RID: 952
		[global::Cpp2ILInjected.Token(Token = "0x400040C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int size;

		// Token: 0x040003B9 RID: 953
		[global::Cpp2ILInjected.Token(Token = "0x400040D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T[] data;

		// Token: 0x040003BA RID: 954
		[global::Cpp2ILInjected.Token(Token = "0x400040E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int head;

		// Token: 0x040003BB RID: 955
		[global::Cpp2ILInjected.Token(Token = "0x400040F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int tail;

		// Token: 0x040003BC RID: 956
		[global::Cpp2ILInjected.Token(Token = "0x4000410")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly object sync;
	}
}
