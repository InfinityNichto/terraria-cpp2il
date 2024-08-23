using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B4 RID: 180
	[global::Cpp2ILInjected.Token(Token = "0x20000C5")]
	internal sealed class UnitySynchronizationContext : SynchronizationContext
	{
		// Token: 0x0600035D RID: 861 RVA: 0x0000270D File Offset: 0x0000090D
		[global::Cpp2ILInjected.Token(Token = "0x600036F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E268", Offset = "0x1F7E268", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnitySynchronizationContext), Member = "InitializeSynchronizationContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UnitySynchronizationContext.WorkRequest>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private UnitySynchronizationContext(int mainThreadID)
		{
			throw null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002710 File Offset: 0x00000910
		[global::Cpp2ILInjected.Token(Token = "0x6000370")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E314", Offset = "0x1F7E314", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnitySynchronizationContext), Member = "CreateCopy", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UnitySynchronizationContext.WorkRequest>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private UnitySynchronizationContext(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID)
		{
			throw null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002713 File Offset: 0x00000913
		[global::Cpp2ILInjected.Token(Token = "0x6000371")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E3B4", Offset = "0x1F7E3B4", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override void Send(SendOrPostCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002716 File Offset: 0x00000916
		[global::Cpp2ILInjected.Token(Token = "0x6000372")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E6B0", Offset = "0x1F7E6B0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		public override void OperationStarted()
		{
			throw null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002719 File Offset: 0x00000919
		[global::Cpp2ILInjected.Token(Token = "0x6000373")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E6BC", Offset = "0x1F7E6BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		public override void OperationCompleted()
		{
			throw null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000271C File Offset: 0x0000091C
		[global::Cpp2ILInjected.Token(Token = "0x6000374")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E6C8", Offset = "0x1F7E6C8", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void Post(SendOrPostCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000271F File Offset: 0x0000091F
		[global::Cpp2ILInjected.Token(Token = "0x6000375")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E808", Offset = "0x1F7E808", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnitySynchronizationContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(List<UnitySynchronizationContext.WorkRequest>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override SynchronizationContext CreateCopy()
		{
			throw null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002722 File Offset: 0x00000922
		[global::Cpp2ILInjected.Token(Token = "0x6000376")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E86C", Offset = "0x1F7E86C", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnitySynchronizationContext), Member = "ExecuteTasks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnitySynchronizationContext), Member = "ExecutePendingTasks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UnitySynchronizationContext.WorkRequest>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<UnitySynchronizationContext.WorkRequest>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UnitySynchronizationContext.WorkRequest>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UnitySynchronizationContext.WorkRequest>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnitySynchronizationContext.WorkRequest), Member = "Invoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void Exec()
		{
			throw null;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002725 File Offset: 0x00000925
		[global::Cpp2ILInjected.Token(Token = "0x6000377")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EAB4", Offset = "0x1F7EAB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool HasPendingTasks()
		{
			throw null;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002728 File Offset: 0x00000928
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000378")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EB0C", Offset = "0x1F7EB0C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnitySynchronizationContext), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "SetSynchronizationContext", MemberParameters = new object[] { typeof(SynchronizationContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void InitializeSynchronizationContext()
		{
			throw null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000272B File Offset: 0x0000092B
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000379")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EB7C", Offset = "0x1F7EB7C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnitySynchronizationContext), Member = "Exec", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static void ExecuteTasks()
		{
			throw null;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000272E File Offset: 0x0000092E
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600037A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EBD4", Offset = "0x1F7EBD4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnitySynchronizationContext), Member = "Exec", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool ExecutePendingTasks(long millisecondsTimeout)
		{
			throw null;
		}

		// Token: 0x04000341 RID: 833
		[global::Cpp2ILInjected.Token(Token = "0x4000376")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;

		// Token: 0x04000342 RID: 834
		[global::Cpp2ILInjected.Token(Token = "0x4000377")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;

		// Token: 0x04000343 RID: 835
		[global::Cpp2ILInjected.Token(Token = "0x4000378")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly int m_MainThreadID;

		// Token: 0x04000344 RID: 836
		[global::Cpp2ILInjected.Token(Token = "0x4000379")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int m_TrackedCount;

		// Token: 0x02000171 RID: 369
		[global::Cpp2ILInjected.Token(Token = "0x20000C6")]
		private struct WorkRequest
		{
			// Token: 0x060006C6 RID: 1734 RVA: 0x00002F9E File Offset: 0x0000119E
			[global::Cpp2ILInjected.Token(Token = "0x600037B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7E6A4", Offset = "0x1F7E6A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public WorkRequest(SendOrPostCallback callback, object state, ManualResetEvent waitHandle = null)
			{
				throw null;
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x00002FA1 File Offset: 0x000011A1
			[global::Cpp2ILInjected.Token(Token = "0x600037C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7EA14", Offset = "0x1F7EA14", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnitySynchronizationContext), Member = "Exec", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public void Invoke()
			{
				throw null;
			}

			// Token: 0x04000665 RID: 1637
			[global::Cpp2ILInjected.Token(Token = "0x400037A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly SendOrPostCallback m_DelagateCallback;

			// Token: 0x04000666 RID: 1638
			[global::Cpp2ILInjected.Token(Token = "0x400037B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly object m_DelagateState;

			// Token: 0x04000667 RID: 1639
			[global::Cpp2ILInjected.Token(Token = "0x400037C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly ManualResetEvent m_WaitHandle;
		}
	}
}
