using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x2000204")]
	internal sealed class ThreadPoolWorkQueueThreadLocals
	{
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

		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40009C5")]
		public static ThreadPoolWorkQueueThreadLocals threadLocals;

		[global::Cpp2ILInjected.Token(Token = "0x40009C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly ThreadPoolWorkQueue workQueue;

		[global::Cpp2ILInjected.Token(Token = "0x40009C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue;

		[global::Cpp2ILInjected.Token(Token = "0x40009C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly global::System.Random random;
	}
}
