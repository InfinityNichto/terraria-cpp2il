using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000052 RID: 82
	[global::Cpp2ILInjected.Token(Token = "0x20000A3")]
	public sealed class HandleCollector
	{
		// Token: 0x06000251 RID: 593 RVA: 0x000034A9 File Offset: 0x000016A9
		[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA817C", Offset = "0x1EA817C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HandleCollector(string name, int initialThreshold)
		{
			throw null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000034AC File Offset: 0x000016AC
		[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8184", Offset = "0x1EA8184", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public HandleCollector(string name, int initialThreshold, int maximumThreshold)
		{
			throw null;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000034AF File Offset: 0x000016AF
		[global::Cpp2ILInjected.Token(Token = "0x17000099")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA831C", Offset = "0x1EA831C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000034B2 File Offset: 0x000016B2
		[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
		public int InitialThreshold
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8324", Offset = "0x1EA8324", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000034B5 File Offset: 0x000016B5
		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		public int MaximumThreshold
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA832C", Offset = "0x1EA832C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000034B8 File Offset: 0x000016B8
		[global::Cpp2ILInjected.Token(Token = "0x1700009C")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8334", Offset = "0x1EA8334", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000034BB File Offset: 0x000016BB
		[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA833C", Offset = "0x1EA833C", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "CollectionCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "Collect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void Add()
		{
			throw null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000034BE File Offset: 0x000016BE
		[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8578", Offset = "0x1EA8578", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "CollectionCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void Remove()
		{
			throw null;
		}

		// Token: 0x0400014F RID: 335
		[global::Cpp2ILInjected.Token(Token = "0x4000278")]
		private const int deltaPercent = 10;

		// Token: 0x04000150 RID: 336
		[global::Cpp2ILInjected.Token(Token = "0x4000279")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04000151 RID: 337
		[global::Cpp2ILInjected.Token(Token = "0x400027A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int initialThreshold;

		// Token: 0x04000152 RID: 338
		[global::Cpp2ILInjected.Token(Token = "0x400027B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int maximumThreshold;

		// Token: 0x04000153 RID: 339
		[global::Cpp2ILInjected.Token(Token = "0x400027C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int threshold;

		// Token: 0x04000154 RID: 340
		[global::Cpp2ILInjected.Token(Token = "0x400027D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int handleCount;

		// Token: 0x04000155 RID: 341
		[global::Cpp2ILInjected.Token(Token = "0x400027E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int[] gc_counts;

		// Token: 0x04000156 RID: 342
		[global::Cpp2ILInjected.Token(Token = "0x400027F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int gc_gen;
	}
}
