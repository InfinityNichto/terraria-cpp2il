using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x020001C9 RID: 457
	[global::Cpp2ILInjected.Token(Token = "0x200024A")]
	internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x000178A9 File Offset: 0x00015AA9
		[global::Cpp2ILInjected.Token(Token = "0x6001417")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CACD08", Offset = "0x1CACD08", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SynchronizationContextAwaitTaskContinuation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SynchronizationContext),
			typeof(global::System.Action),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TaskScheduler),
			typeof(global::System.Action),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal AwaitTaskContinuation(global::System.Action action, bool flowExecutionContext)
		{
			throw null;
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000178AC File Offset: 0x00015AAC
		[global::Cpp2ILInjected.Token(Token = "0x6001418")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAD72C", Offset = "0x1CAD72C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(object),
			typeof(Task),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected Task CreateTask(global::System.Action<object> action, object state, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000178AF File Offset: 0x00015AAF
		[global::Cpp2ILInjected.Token(Token = "0x6001419")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAD60C", Offset = "0x1CAD60C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new object[]
		{
			typeof(ContextCallback),
			typeof(object),
			typeof(ref Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override void Run(Task ignored, bool canInlineContinuationTask)
		{
			throw null;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x000178B2 File Offset: 0x00015AB2
		[global::Cpp2ILInjected.Token(Token = "0x170001F5")]
		internal static bool IsValidLocationForInlining
		{
			[global::Cpp2ILInjected.Token(Token = "0x600141A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAD95C", Offset = "0x1CAD95C", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AwaitTaskContinuation), Member = "Run", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunOrScheduleAction", MemberParameters = new object[]
			{
				typeof(global::System.Action),
				typeof(bool),
				typeof(ref Task)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x000178B5 File Offset: 0x00015AB5
		[global::Cpp2ILInjected.Token(Token = "0x600141B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CADA90", Offset = "0x1CADA90", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		{
			throw null;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x000178B8 File Offset: 0x00015AB8
		[global::Cpp2ILInjected.Token(Token = "0x600141C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CADBAC", Offset = "0x1CADBAC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void InvokeAction(object state)
		{
			throw null;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x000178BB File Offset: 0x00015ABB
		[global::Cpp2ILInjected.Token(Token = "0x600141D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CADC14", Offset = "0x1CADC14", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		protected static ContextCallback GetInvokeActionCallback()
		{
			throw null;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000178BE File Offset: 0x00015ABE
		[global::Cpp2ILInjected.Token(Token = "0x600141E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CACF68", Offset = "0x1CACF68", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AwaitTaskContinuation), Member = "Run", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_CurrentExplicit", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "SetSynchronizationContext", MemberParameters = new object[] { typeof(SynchronizationContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = "ThrowAsyncIfNecessary", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected void RunCallback(ContextCallback callback, object state, ref Task currentTask)
		{
			throw null;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000178C1 File Offset: 0x00015AC1
		[global::Cpp2ILInjected.Token(Token = "0x600141F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA2E8", Offset = "0x1CAA2E8", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishContinuations", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = "UnsafeScheduleAction", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = "ThrowAsyncIfNecessary", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal static void RunOrScheduleAction(global::System.Action action, bool allowInlining, ref Task currentTask)
		{
			throw null;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000178C4 File Offset: 0x00015AC4
		[global::Cpp2ILInjected.Token(Token = "0x6001420")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA92C0", Offset = "0x1CA92C0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunOrScheduleAction", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool),
			typeof(ref Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void UnsafeScheduleAction(global::System.Action action)
		{
			throw null;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000178C7 File Offset: 0x00015AC7
		[global::Cpp2ILInjected.Token(Token = "0x6001421")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAD904", Offset = "0x1CAD904", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new object[]
		{
			typeof(ContextCallback),
			typeof(object),
			typeof(ref Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunOrScheduleAction", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool),
			typeof(ref Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.RuntimeAugments), Member = "ReportUnhandledException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static void ThrowAsyncIfNecessary(global::System.Exception exc)
		{
			throw null;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x000178CA File Offset: 0x00015ACA
		[global::Cpp2ILInjected.Token(Token = "0x6001422")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CADCB4", Offset = "0x1CADCB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void MarkAborted(ThreadAbortException e)
		{
			throw null;
		}

		// Token: 0x04000847 RID: 2119
		[global::Cpp2ILInjected.Token(Token = "0x4000AB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ExecutionContext m_capturedContext;

		// Token: 0x04000848 RID: 2120
		[global::Cpp2ILInjected.Token(Token = "0x4000AB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected readonly global::System.Action m_action;

		// Token: 0x04000849 RID: 2121
		[global::Cpp2ILInjected.Token(Token = "0x4000AB3")]
		private static ContextCallback s_invokeActionCallback;
	}
}
