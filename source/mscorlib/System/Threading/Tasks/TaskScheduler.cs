using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	[global::System.Diagnostics.DebuggerDisplay("Id={Id}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
	[global::Cpp2ILInjected.Token(Token = "0x200024E")]
	public abstract class TaskScheduler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001440")]
		protected internal abstract void QueueTask(Task task);

		[global::Cpp2ILInjected.Token(Token = "0x6001441")]
		protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

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

		[global::Cpp2ILInjected.Token(Token = "0x6001443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAECF4", Offset = "0x1CAECF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected internal virtual bool TryDequeue(Task task)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001444")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAECFC", Offset = "0x1CAECFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void NotifyWorkItemProgress()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001446")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAED08", Offset = "0x1CAED08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TaskScheduler()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000ABE")]
		private static readonly TaskScheduler s_defaultTaskScheduler;

		[global::Cpp2ILInjected.Token(Token = "0x4000ABF")]
		internal static int s_taskSchedulerIdCounter;

		[global::Cpp2ILInjected.Token(Token = "0x4000AC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_taskSchedulerId;

		[global::Cpp2ILInjected.Token(Token = "0x4000AC1")]
		private static global::System.EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;

		[global::Cpp2ILInjected.Token(Token = "0x4000AC2")]
		private static readonly Lock _unobservedTaskExceptionLockObject;

		[global::Cpp2ILInjected.Token(Token = "0x200024F")]
		internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
		{
		}
	}
}
