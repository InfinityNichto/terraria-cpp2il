using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000187 RID: 391
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
	[global::System.Diagnostics.DebuggerDisplay("IsHeld = {IsHeld}")]
	[global::Cpp2ILInjected.Token(Token = "0x20001E1")]
	public struct SpinLock
	{
		// Token: 0x06001017 RID: 4119 RVA: 0x0001729A File Offset: 0x0001549A
		[global::Cpp2ILInjected.Token(Token = "0x600115A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C99A9C", Offset = "0x1C99A9C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SpinLock(bool enableThreadOwnerTracking)
		{
			throw null;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0001729D File Offset: 0x0001549D
		[global::Cpp2ILInjected.Token(Token = "0x600115B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C99AD4", Offset = "0x1C99AD4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalPush", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalFindAndPop", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalPop", MemberParameters = new object[] { typeof(ref IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Enter(ref bool lockTaken)
		{
			throw null;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000172A0 File Offset: 0x000154A0
		[global::Cpp2ILInjected.Token(Token = "0x600115C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A00C", Offset = "0x1C9A00C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "TrySteal", MemberParameters = new object[]
		{
			typeof(ref IThreadPoolWorkItem),
			typeof(ref bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void TryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			throw null;
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000172A3 File Offset: 0x000154A3
		[global::Cpp2ILInjected.Token(Token = "0x600115D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C99B90", Offset = "0x1C99B90", Length = "0x47C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "TryEnter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "DecrementWaiters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			throw null;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000172A6 File Offset: 0x000154A6
		[global::Cpp2ILInjected.Token(Token = "0x600115E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A228", Offset = "0x1C9A228", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void DecrementWaiters()
		{
			throw null;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000172A9 File Offset: 0x000154A9
		[global::Cpp2ILInjected.Token(Token = "0x600115F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A100", Offset = "0x1C9A100", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "get_NextSpinWillYield", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockRecursionException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
		{
			throw null;
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x000172AC File Offset: 0x000154AC
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A3AC", Offset = "0x1C9A3AC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalPush", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalFindAndPop", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "LocalPop", MemberParameters = new object[] { typeof(ref IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolWorkQueue.WorkStealingQueue), Member = "TrySteal", MemberParameters = new object[]
		{
			typeof(ref IThreadPoolWorkItem),
			typeof(ref bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Exit(bool useMemoryBarrier)
		{
			throw null;
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000172AF File Offset: 0x000154AF
		[global::Cpp2ILInjected.Token(Token = "0x6001161")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A3FC", Offset = "0x1C9A3FC", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinLock), Member = "get_IsHeldByCurrentThread", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void ExitSlowPath(bool useMemoryBarrier)
		{
			throw null;
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x000172B2 File Offset: 0x000154B2
		[global::Cpp2ILInjected.Token(Token = "0x1700019E")]
		public bool IsHeldByCurrentThread
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6001162")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9A4D4", Offset = "0x1C9A4D4", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x000172B5 File Offset: 0x000154B5
		[global::Cpp2ILInjected.Token(Token = "0x1700019F")]
		public bool IsThreadOwnerTrackingEnabled
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6001163")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9A0E4", Offset = "0x1C9A0E4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000172B8 File Offset: 0x000154B8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A578", Offset = "0x1C9A578", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static SpinLock()
		{
			throw null;
		}

		// Token: 0x04000750 RID: 1872
		[global::Cpp2ILInjected.Token(Token = "0x4000963")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_owner;

		// Token: 0x04000751 RID: 1873
		[global::Cpp2ILInjected.Token(Token = "0x4000964")]
		private static int MAXIMUM_WAITERS;

		// Token: 0x020005A7 RID: 1447
		[global::Cpp2ILInjected.Token(Token = "0x20001E2")]
		internal class SystemThreading_SpinLockDebugView
		{
		}
	}
}
