using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001B4 RID: 436
	[global::System.Diagnostics.DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
	[global::Cpp2ILInjected.Token(Token = "0x200022A")]
	public class Task<TResult> : Task
	{
		// Token: 0x060011A5 RID: 4517 RVA: 0x00017675 File Offset: 0x00015875
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

		// Token: 0x060011A6 RID: 4518 RVA: 0x00017678 File Offset: 0x00015878
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

		// Token: 0x060011A7 RID: 4519 RVA: 0x0001767B File Offset: 0x0001587B
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

		// Token: 0x060011A8 RID: 4520 RVA: 0x0001767E File Offset: 0x0001587E
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

		// Token: 0x060011A9 RID: 4521 RVA: 0x00017681 File Offset: 0x00015881
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

		// Token: 0x060011AA RID: 4522 RVA: 0x00017684 File Offset: 0x00015884
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

		// Token: 0x060011AB RID: 4523 RVA: 0x00017687 File Offset: 0x00015887
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

		// Token: 0x060011AC RID: 4524 RVA: 0x0001768A File Offset: 0x0001588A
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

		// Token: 0x060011AD RID: 4525 RVA: 0x0001768D File Offset: 0x0001588D
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

		// Token: 0x060011AE RID: 4526 RVA: 0x00017690 File Offset: 0x00015890
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

		// Token: 0x060011AF RID: 4527 RVA: 0x00017693 File Offset: 0x00015893
		[global::Cpp2ILInjected.Token(Token = "0x6001340")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876220", Offset = "0x1876220", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void DangerousSetResult(TResult result)
		{
			throw null;
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00017696 File Offset: 0x00015896
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00017699 File Offset: 0x00015899
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

		// Token: 0x060011B2 RID: 4530 RVA: 0x0001769C File Offset: 0x0001589C
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

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0001769F File Offset: 0x0001589F
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

		// Token: 0x060011B4 RID: 4532 RVA: 0x000176A2 File Offset: 0x000158A2
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

		// Token: 0x060011B5 RID: 4533 RVA: 0x000176A5 File Offset: 0x000158A5
		[global::Cpp2ILInjected.Token(Token = "0x6001346")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876524", Offset = "0x1876524", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public new global::System.Runtime.CompilerServices.TaskAwaiter<TResult> GetAwaiter()
		{
			throw null;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x000176A8 File Offset: 0x000158A8
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

		// Token: 0x060011B7 RID: 4535 RVA: 0x000176AB File Offset: 0x000158AB
		[global::Cpp2ILInjected.Token(Token = "0x6001348")]
		[global::Cpp2ILInjected.Address(RVA = "0x1876564", Offset = "0x1876564", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task ContinueWith(global::System.Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x000176AE File Offset: 0x000158AE
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

		// Token: 0x060011B9 RID: 4537 RVA: 0x000176B1 File Offset: 0x000158B1
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

		// Token: 0x060011BA RID: 4538 RVA: 0x000176B4 File Offset: 0x000158B4
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

		// Token: 0x040007F3 RID: 2035
		[global::Cpp2ILInjected.Token(Token = "0x4000A3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal TResult m_result;

		// Token: 0x040007F4 RID: 2036
		[global::Cpp2ILInjected.Token(Token = "0x4000A3F")]
		private static TaskFactory<TResult> s_defaultFactory;
	}
}
