using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200019C RID: 412
	[global::Cpp2ILInjected.Token(Token = "0x2000204")]
	internal sealed class ThreadPoolWorkQueueThreadLocals
	{
		// Token: 0x060010E9 RID: 4329 RVA: 0x000174A7 File Offset: 0x000156A7
		[global::Cpp2ILInjected.Token(Token = "0x6001252")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E6B4", Offset = "0x1C9E6B4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureCurrentThreadHasQueue", ReturnType = typeof(ThreadPoolWorkQueueThreadLocals))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.SparseArray<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq)
		{
			throw null;
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x000174AA File Offset: 0x000156AA
		[global::Cpp2ILInjected.Token(Token = "0x6001253")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9FDC4", Offset = "0x1C9FDC4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalPop", MemberParameters = new object[] { typeof(ref IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.SparseArray<>), Member = "Remove", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void CleanUp()
		{
			throw null;
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x000174AD File Offset: 0x000156AD
		[global::Cpp2ILInjected.Token(Token = "0x6001254")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9FE84", Offset = "0x1C9FE84", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_HasShutdownStarted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(global::System.AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "IsFinalizingForUnload", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "CleanUp", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x04000792 RID: 1938
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40009C5")]
		public static ThreadPoolWorkQueueThreadLocals threadLocals;

		// Token: 0x04000793 RID: 1939
		[global::Cpp2ILInjected.Token(Token = "0x40009C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly ThreadPoolWorkQueue workQueue;

		// Token: 0x04000794 RID: 1940
		[global::Cpp2ILInjected.Token(Token = "0x40009C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue;

		// Token: 0x04000795 RID: 1941
		[global::Cpp2ILInjected.Token(Token = "0x40009C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly global::System.Random random;
	}
}
