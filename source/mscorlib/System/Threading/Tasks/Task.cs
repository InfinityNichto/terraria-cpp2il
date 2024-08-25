using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	[global::System.Diagnostics.DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
	[global::Cpp2ILInjected.Token(Token = "0x200022A")]
	public class Task<TResult> : Task
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001336")]
		[global::Cpp2ILInjected.Address(RVA = "0x1875AB4", Offset = "0x1875AB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Task()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001337")]
		[global::Cpp2ILInjected.Address(RVA = "0x1875B0C", Offset = "0x1875B0C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(TaskCreationOptions),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Task(object state, TaskCreationOptions options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001338")]
		[global::Cpp2ILInjected.Address(RVA = "0x1875B80", Offset = "0x1875B80", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TaskCreationOptions),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Task(TResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001339")]
		[global::Cpp2ILInjected.Address(RVA = "0x1875BF8", Offset = "0x1875BF8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TaskCreationOptions),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1875C88", Offset = "0x1875C88", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new object[] { typeof(TaskCreationOptions) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Task(global::System.Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1875D50", Offset = "0x1875D50", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		internal Task(global::System.Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1875E00", Offset = "0x1875E00", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		internal Task(global::System.Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1875EB0", Offset = "0x1875EB0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static Task<TResult> StartNew(Task parent, global::System.Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876014", Offset = "0x1876014", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static Task<TResult> StartNew(Task parent, global::System.Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133F")]
		[global::Cpp2ILInjected.Address(RVA = "0x187618C", Offset = "0x187618C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task.ContingentProperties), Member = "SetCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal bool TrySetResult(TResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001340")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876220", Offset = "0x1876220", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void DangerousSetResult(TResult result)
		{
			throw null;
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x170001D3")]
		public TResult Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001341")]
			[global::Cpp2ILInjected.Address(RVA = "0x1876278", Offset = "0x1876278", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D4")]
		internal TResult ResultOnSuccess
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001342")]
			[global::Cpp2ILInjected.Address(RVA = "0x18762D8", Offset = "0x18762D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001343")]
		[global::Cpp2ILInjected.Address(RVA = "0x18762E0", Offset = "0x18762E0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ThrowIfExceptional", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		internal TResult GetResultCore(bool waitCompletionNotification)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D5")]
		public new static TaskFactory<TResult> Factory
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001344")]
			[global::Cpp2ILInjected.Address(RVA = "0x1876350", Offset = "0x1876350", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001345")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876474", Offset = "0x1876474", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override void InnerInvoke()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001346")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876524", Offset = "0x1876524", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public new global::System.Runtime.CompilerServices.TaskAwaiter<TResult> GetAwaiter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001347")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876528", Offset = "0x1876528", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<>), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Threading.Tasks.Task`1<TResult>",
			typeof(bool)
		}, ReturnType = typeof(void))]
		public new global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001348")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876564", Offset = "0x1876564", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task ContinueWith(global::System.Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001349")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876580", Offset = "0x1876580", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new object[]
		{
			typeof(TaskContinuationOptions),
			typeof(ref TaskCreationOptions),
			typeof(ref InternalTaskOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal Task ContinueWith(global::System.Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600134A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C57E4", Offset = "0x14C57E4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Task<TNewResult> ContinueWith<TNewResult>(global::System.Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600134B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C5878", Offset = "0x14C5878", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new object[]
		{
			typeof(TaskContinuationOptions),
			typeof(ref TaskCreationOptions),
			typeof(ref InternalTaskOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal Task<TNewResult> ContinueWith<TNewResult>(global::System.Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000A3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal TResult m_result;

		[global::Cpp2ILInjected.Token(Token = "0x4000A3F")]
		private static TaskFactory<TResult> s_defaultFactory;
	}
}
