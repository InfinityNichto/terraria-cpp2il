using System;
using System.Runtime.ConstrainedExecution;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x2000200")]
	internal sealed class ThreadPoolWorkQueue
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001239")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E568", Offset = "0x1C9E568", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolGlobals), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.QueueSegment), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ThreadPoolWorkQueue()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600123A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E630", Offset = "0x1C9E630", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadPoolWorkQueue) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600123B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E7C4", Offset = "0x1C9E7C4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void EnsureThreadRequested()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600123C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E864", Offset = "0x1C9E864", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void MarkThreadRequestSatisfied()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600123D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E8AC", Offset = "0x1C9E8AC", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "CleanUp", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(ref StackCrawlMark),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalPush", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.QueueSegment), Member = "TryEnqueue", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.QueueSegment), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureThreadRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600123E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9EE38", Offset = "0x1C9EE38", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "TryPopCustomWorkItem", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool LocalFindAndPop(IThreadPoolWorkItem callback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600123F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9F0FC", Offset = "0x1C9F0FC", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalPop", MemberParameters = new object[] { typeof(ref IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.QueueSegment), Member = "TryDequeue", MemberParameters = new object[] { typeof(ref IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.SparseArray<>), Member = "get_Current", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "TrySteal", MemberParameters = new object[]
		{
			typeof(ref IThreadPoolWorkItem),
			typeof(ref bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001240")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9F5B8", Offset = "0x1C9F5B8", Length = "0x440")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_ThreadPoolWaitCallback), Member = "PerformWaitCallback", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "MarkThreadRequestSatisfied", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureCurrentThreadHasQueue", ReturnType = typeof(ThreadPoolWorkQueueThreadLocals))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new object[]
		{
			typeof(ThreadPoolWorkQueueThreadLocals),
			typeof(ref IThreadPoolWorkItem),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureThreadRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		internal static bool Dispatch()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9F9FC", Offset = "0x1C9F9FC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.SparseArray<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ThreadPoolWorkQueue()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40009B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ThreadPoolWorkQueue.QueueSegment queueHead;

		[global::Cpp2ILInjected.Token(Token = "0x40009B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal ThreadPoolWorkQueue.QueueSegment queueTail;

		[global::Cpp2ILInjected.Token(Token = "0x40009BA")]
		internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues;

		[global::Cpp2ILInjected.Token(Token = "0x40009BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int numOutstandingThreadRequests;

		[global::Cpp2ILInjected.Token(Token = "0x2000201")]
		internal class SparseArray<T> where T : class
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001242")]
			[global::Cpp2ILInjected.Address(RVA = "0x186E944", Offset = "0x186E944", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal SparseArray(int initialSize)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170001BF")]
			internal T[] Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001243")]
				[global::Cpp2ILInjected.Address(RVA = "0x186E998", Offset = "0x186E998", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new object[]
				{
					typeof(ThreadPoolWorkQueueThreadLocals),
					typeof(ref IThreadPoolWorkItem),
					typeof(ref bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001244")]
			[global::Cpp2ILInjected.Address(RVA = "0x186E9B0", Offset = "0x186E9B0", Length = "0x1BC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadPoolWorkQueue) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(global::System.Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal int Add(T e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001245")]
			[global::Cpp2ILInjected.Address(RVA = "0x186EB6C", Offset = "0x186EB6C", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "CleanUp", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal void Remove(T e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40009BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T[] m_array;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000202")]
		internal class WorkStealingQueue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001246")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9E9D4", Offset = "0x1C9E9D4", Length = "0x3D4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new object[]
			{
				typeof(IThreadPoolWorkItem),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
			public void LocalPush(IThreadPoolWorkItem obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001247")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9EEA0", Offset = "0x1C9EEA0", Length = "0x25C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalPop", MemberParameters = new object[] { typeof(ref IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			public bool LocalFindAndPop(IThreadPoolWorkItem obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001248")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9F2A0", Offset = "0x1C9F2A0", Length = "0x208")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalFindAndPop", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new object[]
			{
				typeof(ThreadPoolWorkQueueThreadLocals),
				typeof(ref IThreadPoolWorkItem),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "CleanUp", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			public bool LocalPop(out IThreadPoolWorkItem obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001249")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9F5B0", Offset = "0x1C9F5B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "TrySteal", MemberParameters = new object[]
			{
				typeof(ref IThreadPoolWorkItem),
				typeof(ref bool),
				typeof(int)
			}, ReturnType = typeof(bool))]
			public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600124A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9FA90", Offset = "0x1C9FA90", Length = "0x204")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "TrySteal", MemberParameters = new object[]
			{
				typeof(ref IThreadPoolWorkItem),
				typeof(ref bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new object[]
			{
				typeof(ThreadPoolWorkQueueThreadLocals),
				typeof(ref IThreadPoolWorkItem),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "TryEnter", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600124B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9FC94", Offset = "0x1C9FC94", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadPoolWorkQueue) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public WorkStealingQueue()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40009BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal IThreadPoolWorkItem[] m_array;

			[global::Cpp2ILInjected.Token(Token = "0x40009BE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int m_mask;

			[global::Cpp2ILInjected.Token(Token = "0x40009BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int m_headIndex;

			[global::Cpp2ILInjected.Token(Token = "0x40009C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int m_tailIndex;

			[global::Cpp2ILInjected.Token(Token = "0x40009C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private SpinLock m_foreignLock;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000203")]
		internal class QueueSegment
		{
			[global::Cpp2ILInjected.Token(Token = "0x600124C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9FD28", Offset = "0x1C9FD28", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void GetIndexes(out int upper, out int lower)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600124D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9FD5C", Offset = "0x1C9FD5C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower)
			{
				throw null;
			}

			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
			[global::Cpp2ILInjected.Token(Token = "0x600124E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9E5D4", Offset = "0x1C9E5D4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new object[]
			{
				typeof(IThreadPoolWorkItem),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public QueueSegment()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600124F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9F574", Offset = "0x1C9F574", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool IsUsedUp()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001250")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9EDA8", Offset = "0x1C9EDA8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new object[]
			{
				typeof(IThreadPoolWorkItem),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool TryEnqueue(IThreadPoolWorkItem node)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001251")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9F4A8", Offset = "0x1C9F4A8", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new object[]
			{
				typeof(ThreadPoolWorkQueueThreadLocals),
				typeof(ref IThreadPoolWorkItem),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool TryDequeue(out IThreadPoolWorkItem node)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40009C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal readonly IThreadPoolWorkItem[] nodes;

			[global::Cpp2ILInjected.Token(Token = "0x40009C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int indexes;

			[global::Cpp2ILInjected.Token(Token = "0x40009C4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ThreadPoolWorkQueue.QueueSegment Next;
		}
	}
}
