using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001CC RID: 460
	[global::System.Diagnostics.DebuggerDisplay("Id={Id}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
	[global::Cpp2ILInjected.Token(Token = "0x200024E")]
	public abstract class TaskScheduler
	{
		// Token: 0x0600128A RID: 4746
		[global::Cpp2ILInjected.Token(Token = "0x6001440")]
		protected internal abstract void QueueTask(Task task);

		// Token: 0x0600128B RID: 4747
		[global::Cpp2ILInjected.Token(Token = "0x6001441")]
		protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

		// Token: 0x0600128C RID: 4748 RVA: 0x0001791B File Offset: 0x00015B1B
		[global::Cpp2ILInjected.Token(Token = "0x6001442")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA9C2C", Offset = "0x1CA9C2C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "WrappedTryRunInline", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_CurrentStackGuard", ReturnType = typeof(StackGuard))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "TryEnsureSufficientExecutionStack", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
		{
			throw null;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0001791E File Offset: 0x00015B1E
		[global::Cpp2ILInjected.Token(Token = "0x6001443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAECF4", Offset = "0x1CAECF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected internal virtual bool TryDequeue(Task task)
		{
			throw null;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00017921 File Offset: 0x00015B21
		[global::Cpp2ILInjected.Token(Token = "0x6001444")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAECFC", Offset = "0x1CAECFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void NotifyWorkItemProgress()
		{
			throw null;
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00017924 File Offset: 0x00015B24
		[global::Cpp2ILInjected.Token(Token = "0x170001F8")]
		internal virtual bool RequiresAtomicStartTransition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001445")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAED00", Offset = "0x1CAED00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00017927 File Offset: 0x00015B27
		[global::Cpp2ILInjected.Token(Token = "0x6001446")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAED08", Offset = "0x1CAED08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TaskScheduler()
		{
			throw null;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x0001792A File Offset: 0x00015B2A
		[global::Cpp2ILInjected.Token(Token = "0x170001F9")]
		public static TaskScheduler Default
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001447")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAED10", Offset = "0x1CAED10", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x0001792D File Offset: 0x00015B2D
		[global::Cpp2ILInjected.Token(Token = "0x170001FA")]
		public static TaskScheduler Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001448")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAA52C", Offset = "0x1CAA52C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "ContinueWith", MemberTypeParameters = new object[] { "TNewResult" }, MemberParameters = new object[]
			{
				"System.Func`2<Task`1<TResult>, TNewResult>",
				typeof(TaskContinuationOptions)
			}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[] { typeof(global::System.Action<Task>) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new object[]
			{
				"System.Action`1<Object>",
				typeof(object),
				typeof(short),
				typeof(global::System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00017930 File Offset: 0x00015B30
		[global::Cpp2ILInjected.Token(Token = "0x170001FB")]
		internal static TaskScheduler InternalCurrent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001449")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA9158", Offset = "0x1CA9158", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new object[]
			{
				typeof(global::System.Action),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00017933 File Offset: 0x00015B33
		[global::Cpp2ILInjected.Token(Token = "0x170001FC")]
		public int Id
		{
			[global::Cpp2ILInjected.Token(Token = "0x600144A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA9E14", Offset = "0x1CA9E14", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter.<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(global::System.Action)
			}, ReturnType = typeof(global::System.Action))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00017936 File Offset: 0x00015B36
		[global::Cpp2ILInjected.Token(Token = "0x600144B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CADF18", Offset = "0x1CADF18", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lock), Member = "Acquire", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lock), Member = "Release", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea)
		{
			throw null;
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00017939 File Offset: 0x00015B39
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600144C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAED68", Offset = "0x1CAED68", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolTaskScheduler), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lock), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static TaskScheduler()
		{
			throw null;
		}

		// Token: 0x04000853 RID: 2131
		[global::Cpp2ILInjected.Token(Token = "0x4000ABE")]
		private static readonly TaskScheduler s_defaultTaskScheduler;

		// Token: 0x04000854 RID: 2132
		[global::Cpp2ILInjected.Token(Token = "0x4000ABF")]
		internal static int s_taskSchedulerIdCounter;

		// Token: 0x04000855 RID: 2133
		[global::Cpp2ILInjected.Token(Token = "0x4000AC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_taskSchedulerId;

		// Token: 0x04000856 RID: 2134
		[global::Cpp2ILInjected.Token(Token = "0x4000AC1")]
		private static global::System.EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;

		// Token: 0x04000857 RID: 2135
		[global::Cpp2ILInjected.Token(Token = "0x4000AC2")]
		private static readonly Lock _unobservedTaskExceptionLockObject;

		// Token: 0x020005CD RID: 1485
		[global::Cpp2ILInjected.Token(Token = "0x200024F")]
		internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
		{
		}
	}
}
