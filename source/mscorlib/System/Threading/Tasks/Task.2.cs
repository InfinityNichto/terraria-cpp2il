using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Threading.Tasks.Tracing;

namespace System.Threading.Tasks
{
	// Token: 0x020001B8 RID: 440
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
	[global::System.Diagnostics.DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000232")]
	public class Task : IThreadPoolWorkItem, global::System.IAsyncResult, global::System.IDisposable
	{
		// Token: 0x060011C4 RID: 4548 RVA: 0x000176D2 File Offset: 0x000158D2
		[global::Cpp2ILInjected.Token(Token = "0x600135F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA52C0", Offset = "0x1CA52C0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = ".ctor", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			"TResult",
			typeof(TaskCreationOptions),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FromCancellation", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
		{
			throw null;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000176D5 File Offset: 0x000158D5
		[global::Cpp2ILInjected.Token(Token = "0x6001360")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA539C", Offset = "0x1CA539C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Task()
		{
			throw null;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x000176D8 File Offset: 0x000158D8
		[global::Cpp2ILInjected.Token(Token = "0x6001361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA53C4", Offset = "0x1CA53C4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle)
		{
			throw null;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000176DB File Offset: 0x000158DB
		[global::Cpp2ILInjected.Token(Token = "0x6001362")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5630", Offset = "0x1CA5630", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Func`1<TResult>",
			typeof(Task),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(object),
			typeof(Task),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalStartNew", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.Delegate),
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskScheduler),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContinuationTaskFromTask), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.Delegate),
			typeof(object),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContinuationTaskFromResultTask<>), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Threading.Tasks.Task`1<TAntecedentResult>",
			typeof(global::System.Delegate),
			typeof(object),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AwaitTaskContinuation), Member = "CreateTask", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(TaskScheduler)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal Task(global::System.Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x000176DE File Offset: 0x000158DE
		[global::Cpp2ILInjected.Token(Token = "0x6001363")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA54E4", Offset = "0x1CA54E4", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(object),
			typeof(Task),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddNewChild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_CanBeCanceled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(Task),
			typeof(TaskContinuation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "set_CapturedContext", MemberParameters = new object[] { typeof(ExecutionContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void TaskConstructorCore(global::System.Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x000176E1 File Offset: 0x000158E1
		[global::Cpp2ILInjected.Token(Token = "0x6001364")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5774", Offset = "0x1CA5774", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Tuple<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "InternalRegisterWithoutEC", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "DisregardChild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
			throw null;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000176E4 File Offset: 0x000158E4
		[global::Cpp2ILInjected.Token(Token = "0x6001365")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5D20", Offset = "0x1CA5D20", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void TaskCancelCallback(object o)
		{
			throw null;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000176E7 File Offset: 0x000158E7
		[global::Cpp2ILInjected.Token(Token = "0x6001366")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4A10", Offset = "0x1CA4A10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskCompletionSource<>), Member = "TrySetCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask`1.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "ProcessInnerTask", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(bool))]
		internal bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			throw null;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x000176EA File Offset: 0x000158EA
		[global::Cpp2ILInjected.Token(Token = "0x6001367")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4164", Offset = "0x1CA4164", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTask), Member = "GetTaskForValueTaskSource", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Sources.IValueTaskSource) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask`1.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTask<>), Member = "GetTaskForValueTaskSource", MemberParameters = new object[] { "System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>" }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.TaskFactory`1.FromAsyncTrimPromise`1", Member = "Complete", MemberParameters = new object[]
		{
			"TInstance",
			"System.Func`3<TInstance, IAsyncResult, TResult>",
			typeof(global::System.IAsyncResult),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task.DelayPromise), Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FromCancellation", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.OperationCanceledException) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
		internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
		{
			throw null;
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x000176ED File Offset: 0x000158ED
		[global::Cpp2ILInjected.Token(Token = "0x6001368")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4A18", Offset = "0x1CA4A18", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskCompletionSource<>), Member = "TrySetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask`1.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.TaskFactory`1.FromAsyncTrimPromise`1", Member = "Complete", MemberParameters = new object[]
		{
			"TInstance",
			"System.Func`3<TInstance, IAsyncResult, TResult>",
			typeof(global::System.IAsyncResult),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool TrySetException(object exceptionObject)
		{
			throw null;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x000176F0 File Offset: 0x000158F0
		[global::Cpp2ILInjected.Token(Token = "0x170001D6")]
		internal TaskCreationOptions Options
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001369")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA5AB0", Offset = "0x1CA5AB0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(object),
				typeof(CancellationToken),
				typeof(TaskCreationOptions),
				typeof(InternalTaskOptions),
				typeof(TaskScheduler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new object[]
			{
				typeof(CancellationToken),
				typeof(Task),
				typeof(TaskContinuation)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "get_CreationOptions", ReturnType = typeof(TaskCreationOptions))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "UpdateExceptionObservedStatus", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x000176F3 File Offset: 0x000158F3
		[global::Cpp2ILInjected.Token(Token = "0x600136A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA63C4", Offset = "0x1CA63C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static TaskCreationOptions OptionsMethod(int flags)
		{
			throw null;
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x000176F6 File Offset: 0x000158F6
		[global::Cpp2ILInjected.Token(Token = "0x600136B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA604C", Offset = "0x1CA604C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "TrySetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "SetNotificationForWaitCompletion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "MarkStarted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			throw null;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x000176F9 File Offset: 0x000158F9
		[global::Cpp2ILInjected.Token(Token = "0x600136C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA63CC", Offset = "0x1CA63CC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			throw null;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x000176FC File Offset: 0x000158FC
		[global::Cpp2ILInjected.Token(Token = "0x600136D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA646C", Offset = "0x1CA646C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			throw null;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x000176FF File Offset: 0x000158FF
		[global::Cpp2ILInjected.Token(Token = "0x600136E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA64E8", Offset = "0x1CA64E8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "GetResultCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContinuationTaskFromTask), Member = "InnerInvoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContinuationTaskFromResultTask<>), Member = "InnerInvoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContinuationResultTaskFromResultTask<, >), Member = "InnerInvoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			throw null;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00017702 File Offset: 0x00015902
		[global::Cpp2ILInjected.Token(Token = "0x170001D7")]
		internal bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[global::Cpp2ILInjected.Token(Token = "0x600136F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6578", Offset = "0x1CA6578", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00017705 File Offset: 0x00015905
		[global::Cpp2ILInjected.Token(Token = "0x170001D8")]
		internal virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001370")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA65A0", Offset = "0x1CA65A0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00017708 File Offset: 0x00015908
		[global::Cpp2ILInjected.Token(Token = "0x170001D9")]
		internal bool IsWaitNotificationEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001371")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6538", Offset = "0x1CA6538", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0001770B File Offset: 0x0001590B
		[global::Cpp2ILInjected.Token(Token = "0x6001372")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA6550", Offset = "0x1CA6550", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "SetNotificationForWaitCompletion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[MethodImpl(72)]
		private void NotifyDebuggerOfWaitCompletion()
		{
			throw null;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0001770E File Offset: 0x0001590E
		[global::Cpp2ILInjected.Token(Token = "0x6001373")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA65B8", Offset = "0x1CA65B8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		internal bool MarkStarted()
		{
			throw null;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00017711 File Offset: 0x00015911
		[global::Cpp2ILInjected.Token(Token = "0x6001374")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5708", Offset = "0x1CA5708", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void AddNewChild()
		{
			throw null;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00017714 File Offset: 0x00015914
		[global::Cpp2ILInjected.Token(Token = "0x6001375")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5CE0", Offset = "0x1CA5CE0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(Task),
			typeof(TaskContinuation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void DisregardChild()
		{
			throw null;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00017717 File Offset: 0x00015917
		[global::Cpp2ILInjected.Token(Token = "0x6001376")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA65C4", Offset = "0x1CA65C4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Run", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static Task InternalStartNew(Task creatingTask, global::System.Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
		{
			throw null;
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0001771A File Offset: 0x0001591A
		[global::Cpp2ILInjected.Token(Token = "0x170001DA")]
		public int Id
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001377")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA4F94", Offset = "0x1CA4F94", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddToActiveTasks", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter.<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(global::System.Action)
			}, ReturnType = typeof(global::System.Action))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), Member = "SetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.AsyncMethodBuilderCore.<>c__DisplayClass5_0", Member = "<OutputAsyncCausalityEvents>b__0", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine),
				typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore.MoveNextRunner),
				typeof(Task)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0001771D File Offset: 0x0001591D
		[global::Cpp2ILInjected.Token(Token = "0x170001DB")]
		internal static Task InternalCurrent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001378")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA68BC", Offset = "0x1CA68BC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00017720 File Offset: 0x00015920
		[global::Cpp2ILInjected.Token(Token = "0x6001379")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA6914", Offset = "0x1CA6914", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Func`2<Object, TResult>",
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskCreationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContinuationTaskFromTask), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.Delegate),
			typeof(object),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContinuationTaskFromResultTask<>), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Threading.Tasks.Task`1<TAntecedentResult>",
			typeof(global::System.Delegate),
			typeof(object),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContinuationResultTaskFromResultTask<, >), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Threading.Tasks.Task`1<TAntecedentResult>",
			typeof(global::System.Delegate),
			typeof(object),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[]
		{
			"System.Func`1<TResult>",
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskScheduler)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[]
		{
			"System.Func`2<Object, TResult>",
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskScheduler)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			throw null;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x00017723 File Offset: 0x00015923
		[global::Cpp2ILInjected.Token(Token = "0x170001DC")]
		internal static StackGuard CurrentStackGuard
		{
			[global::Cpp2ILInjected.Token(Token = "0x600137A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA69B0", Offset = "0x1CA69B0", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "Invoke", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskScheduler), Member = "TryRunInline", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00017726 File Offset: 0x00015926
		[global::Cpp2ILInjected.Token(Token = "0x170001DD")]
		public global::System.AggregateException Exception
		{
			[global::Cpp2ILInjected.Token(Token = "0x600137B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6A64", Offset = "0x1CA6A64", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<>c__241`1", Member = "<RunWithTimeoutWorker>b__241_0", MemberParameters = new object[] { "System.Threading.Tasks.Task`1<T>" }, ReturnType = "System.Nullable`1<Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new object[] { "System.Threading.Tasks.Task`1<IPAddress[]>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.AggregateException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00017729 File Offset: 0x00015929
		[global::Cpp2ILInjected.Token(Token = "0x170001DE")]
		public TaskStatus Status
		{
			[global::Cpp2ILInjected.Token(Token = "0x600137C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6BE8", Offset = "0x1CA6BE8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "ProcessCompletedOuterTask", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0001772C File Offset: 0x0001592C
		[global::Cpp2ILInjected.Token(Token = "0x170001DF")]
		public bool IsCanceled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600137D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6C48", Offset = "0x1CA6C48", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new object[] { "System.Threading.Tasks.Task`1<IPAddress[]>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0001772F File Offset: 0x0001592F
		[global::Cpp2ILInjected.Token(Token = "0x170001E0")]
		internal bool IsCancellationRequested
		{
			[global::Cpp2ILInjected.Token(Token = "0x600137E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6C68", Offset = "0x1CA6C68", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "HandleException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00017732 File Offset: 0x00015932
		[global::Cpp2ILInjected.Token(Token = "0x600137F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5A70", Offset = "0x1CA5A70", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			throw null;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00017735 File Offset: 0x00015935
		[global::Cpp2ILInjected.Token(Token = "0x6001380")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA6CB8", Offset = "0x1CA6CB8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(Task),
			typeof(TaskContinuation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddNewChild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "DisregardChild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "EnsureContingentPropertiesInitialized", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "get_CompletedEvent", ReturnType = typeof(ManualResetEventSlim))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "set_CapturedContext", MemberParameters = new object[] { typeof(ExecutionContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			throw null;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00017738 File Offset: 0x00015938
		[global::Cpp2ILInjected.Token(Token = "0x170001E1")]
		internal CancellationToken CancellationToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001381")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3618", Offset = "0x1CA3618", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0001773B File Offset: 0x0001593B
		[global::Cpp2ILInjected.Token(Token = "0x170001E2")]
		internal bool IsCancellationAcknowledged
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001382")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6D94", Offset = "0x1CA6D94", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0001773E File Offset: 0x0001593E
		[global::Cpp2ILInjected.Token(Token = "0x170001E3")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001383")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3898", Offset = "0x1CA3898", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 51)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00017741 File Offset: 0x00015941
		[global::Cpp2ILInjected.Token(Token = "0x6001384")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA6DAC", Offset = "0x1CA6DAC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsCompletedMethod(int flags)
		{
			throw null;
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x00017744 File Offset: 0x00015944
		[global::Cpp2ILInjected.Token(Token = "0x170001E4")]
		public bool IsCompletedSuccessfully
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001385")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6DBC", Offset = "0x1CA6DBC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTask<>), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "GetResultCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00017747 File Offset: 0x00015947
		[global::Cpp2ILInjected.Token(Token = "0x170001E5")]
		public TaskCreationOptions CreationOptions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001386")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA56F4", Offset = "0x1CA56F4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x0001774A File Offset: 0x0001594A
		[global::Cpp2ILInjected.Token(Token = "0x170001E6")]
		private WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001387")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6DE4", Offset = "0x1CA6DE4", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_CompletedEvent", ReturnType = typeof(ManualResetEventSlim))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "get_WaitHandle", ReturnType = typeof(WaitHandle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0001774D File Offset: 0x0001594D
		[global::Cpp2ILInjected.Token(Token = "0x170001E7")]
		public object AsyncState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001388")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6F48", Offset = "0x1CA6F48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00017750 File Offset: 0x00015950
		[global::Cpp2ILInjected.Token(Token = "0x170001E8")]
		private bool System.IAsyncResult.CompletedSynchronously
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001389")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6F50", Offset = "0x1CA6F50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00017753 File Offset: 0x00015953
		[global::Cpp2ILInjected.Token(Token = "0x170001E9")]
		internal TaskScheduler ExecutingTaskScheduler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600138A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6F58", Offset = "0x1CA6F58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00017756 File Offset: 0x00015956
		[global::Cpp2ILInjected.Token(Token = "0x170001EA")]
		public static TaskFactory Factory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600138B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6F60", Offset = "0x1CA6F60", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00017759 File Offset: 0x00015959
		[global::Cpp2ILInjected.Token(Token = "0x170001EB")]
		public static Task CompletedTask
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600138C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6FB8", Offset = "0x1CA6FB8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0001775C File Offset: 0x0001595C
		[global::Cpp2ILInjected.Token(Token = "0x170001EC")]
		internal ManualResetEventSlim CompletedEvent
		{
			[global::Cpp2ILInjected.Token(Token = "0x600138D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6E60", Offset = "0x1CA6E60", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "System.IAsyncResult.get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0001775F File Offset: 0x0001595F
		[global::Cpp2ILInjected.Token(Token = "0x170001ED")]
		internal bool ExceptionRecorded
		{
			[global::Cpp2ILInjected.Token(Token = "0x600138E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA7010", Offset = "0x1CA7010", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.AggregateException))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "GetExceptionDispatchInfos", ReturnType = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00017762 File Offset: 0x00015962
		[global::Cpp2ILInjected.Token(Token = "0x170001EE")]
		public bool IsFaulted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600138F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA6AA0", Offset = "0x1CA6AA0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new object[] { "System.Threading.Tasks.Task`1<IPAddress[]>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00017765 File Offset: 0x00015965
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00017768 File Offset: 0x00015968
		[global::Cpp2ILInjected.Token(Token = "0x170001EF")]
		internal ExecutionContext CapturedContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001390")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA7078", Offset = "0x1CA7078", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ExecuteWithThreadLocal", MemberParameters = new object[] { typeof(ref Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001391")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA59E0", Offset = "0x1CA59E0", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(object),
				typeof(CancellationToken),
				typeof(TaskCreationOptions),
				typeof(InternalTaskOptions),
				typeof(TaskScheduler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0001776B File Offset: 0x0001596B
		[global::Cpp2ILInjected.Token(Token = "0x6001392")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA70E8", Offset = "0x1CA70E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0001776E File Offset: 0x0001596E
		[global::Cpp2ILInjected.Token(Token = "0x6001393")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA7154", Offset = "0x1CA7154", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "get_IsSet", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00017771 File Offset: 0x00015971
		[global::Cpp2ILInjected.Token(Token = "0x6001394")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA66C4", Offset = "0x1CA66C4", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "StartNew", MemberParameters = new object[]
		{
			typeof(Task),
			"System.Func`1<TResult>",
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "StartNew", MemberParameters = new object[]
		{
			typeof(Task),
			"System.Func`2<Object, TResult>",
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalStartNew", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.Delegate),
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskScheduler),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandardTaskContinuation), Member = "Run", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "RunReadWriteTask", MemberParameters = new object[] { "System.IO.Stream.ReadWriteTask" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskSchedulerException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "MarkAsHandled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		internal void ScheduleAndStart(bool needsProtection)
		{
			throw null;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00017774 File Offset: 0x00015974
		[global::Cpp2ILInjected.Token(Token = "0x6001395")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA6230", Offset = "0x1CA6230", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal void AddException(object exceptionObject)
		{
			throw null;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00017777 File Offset: 0x00015977
		[global::Cpp2ILInjected.Token(Token = "0x6001396")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA72AC", Offset = "0x1CA72AC", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddExceptionsFromChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "HandleException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "MarkAsHandled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "SetCancellationException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal void AddException(object exceptionObject, bool representsCancellation)
		{
			throw null;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0001777A File Offset: 0x0001597A
		[global::Cpp2ILInjected.Token(Token = "0x6001397")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA6AB8", Offset = "0x1CA6AB8", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "get_Exception", ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ThrowIfExceptional", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCanceledException), Member = ".ctor", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_ExceptionRecorded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "CreateExceptionObject", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Exception)
		}, ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private global::System.AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			throw null;
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0001777D File Offset: 0x0001597D
		[global::Cpp2ILInjected.Token(Token = "0x6001398")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA75F0", Offset = "0x1CA75F0", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_ExceptionRecorded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			throw null;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00017780 File Offset: 0x00015980
		[global::Cpp2ILInjected.Token(Token = "0x6001399")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA7778", Offset = "0x1CA7778", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			throw null;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00017783 File Offset: 0x00015983
		[global::Cpp2ILInjected.Token(Token = "0x600139A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA77A8", Offset = "0x1CA77A8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "GetResultCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "UpdateExceptionObservedStatus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
			throw null;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00017786 File Offset: 0x00015986
		[global::Cpp2ILInjected.Token(Token = "0x600139B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA77F0", Offset = "0x1CA77F0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ThrowIfExceptional", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void UpdateExceptionObservedStatus()
		{
			throw null;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00017789 File Offset: 0x00015989
		[global::Cpp2ILInjected.Token(Token = "0x170001F0")]
		internal bool IsExceptionObservedByParent
		{
			[global::Cpp2ILInjected.Token(Token = "0x600139C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA78BC", Offset = "0x1CA78BC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0001778C File Offset: 0x0001598C
		[global::Cpp2ILInjected.Token(Token = "0x170001F1")]
		internal bool IsDelegateInvoked
		{
			[global::Cpp2ILInjected.Token(Token = "0x600139D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA78D4", Offset = "0x1CA78D4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0001778F File Offset: 0x0001598F
		[global::Cpp2ILInjected.Token(Token = "0x600139E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA6238", Offset = "0x1CA6238", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ExecuteWithThreadLocal", MemberParameters = new object[] { typeof(ref Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "RemoveAll", MemberParameters = new object[] { "System.Predicate`1<T>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal void Finish(bool bUserDelegateExecuted)
		{
			throw null;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00017792 File Offset: 0x00015992
		[global::Cpp2ILInjected.Token(Token = "0x600139F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA78EC", Offset = "0x1CA78EC", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ProcessChildCompletion", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddExceptionsFromChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_ExceptionRecorded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task.ContingentProperties), Member = "UnregisterCancellationCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		internal void FinishStageTwo()
		{
			throw null;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00017795 File Offset: 0x00015995
		[global::Cpp2ILInjected.Token(Token = "0x60013A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA80A0", Offset = "0x1CA80A0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "TrySetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ProcessChildCompletion", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FinishContinuations", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void FinishStageThree()
		{
			throw null;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00017798 File Offset: 0x00015998
		[global::Cpp2ILInjected.Token(Token = "0x60013A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA80E8", Offset = "0x1CA80E8", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelListWithIList<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal void ProcessChildCompletion(Task childTask)
		{
			throw null;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0001779B File Offset: 0x0001599B
		[global::Cpp2ILInjected.Token(Token = "0x60013A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA7B64", Offset = "0x1CA7B64", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "CreateExceptionObject", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Exception)
		}, ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		internal void AddExceptionsFromChildren()
		{
			throw null;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0001779E File Offset: 0x0001599E
		[global::Cpp2ILInjected.Token(Token = "0x60013A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA8968", Offset = "0x1CA8968", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ExecutionContextCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ExecuteWithThreadLocal", MemberParameters = new object[] { typeof(ref Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void Execute()
		{
			throw null;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x000177A1 File Offset: 0x000159A1
		[global::Cpp2ILInjected.Token(Token = "0x60013A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA8B14", Offset = "0x1CA8B14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		{
			throw null;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x000177A4 File Offset: 0x000159A4
		[global::Cpp2ILInjected.Token(Token = "0x60013A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA8B1C", Offset = "0x1CA8B1C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ThreadPoolTaskScheduler.<>c", Member = "<.cctor>b__10_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "TryExecuteTaskInline", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ExecuteWithThreadLocal", MemberParameters = new object[] { typeof(ref Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			throw null;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000177A7 File Offset: 0x000159A7
		[global::Cpp2ILInjected.Token(Token = "0x60013A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA8DD0", Offset = "0x1CA8DD0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Execute", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static void ExecutionContextCallback(object obj)
		{
			throw null;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000177AA File Offset: 0x000159AA
		[global::Cpp2ILInjected.Token(Token = "0x60013A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA8E48", Offset = "0x1CA8E48", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal virtual void InnerInvoke()
		{
			throw null;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000177AD File Offset: 0x000159AD
		[global::Cpp2ILInjected.Token(Token = "0x60013A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA8A14", Offset = "0x1CA8A14", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void HandleException(global::System.Exception unhandledException)
		{
			throw null;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x000177B0 File Offset: 0x000159B0
		[global::Cpp2ILInjected.Token(Token = "0x60013A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3B08", Offset = "0x1CA3B08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.ValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.ValueTaskAwaiter<>), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<Initialize>d__36", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public global::System.Runtime.CompilerServices.TaskAwaiter GetAwaiter()
		{
			throw null;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000177B3 File Offset: 0x000159B3
		[global::Cpp2ILInjected.Token(Token = "0x60013AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3B14", Offset = "0x1CA3B14", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			throw null;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000177B6 File Offset: 0x000159B6
		[global::Cpp2ILInjected.Token(Token = "0x60013AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA8F28", Offset = "0x1CA8F28", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.Action),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = "UnsafeScheduleAction", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void SetContinuationForAwait(global::System.Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			throw null;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000177B9 File Offset: 0x000159B9
		[global::Cpp2ILInjected.Token(Token = "0x60013AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA9344", Offset = "0x1CA9344", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "AuthenticateAsClient", MemberParameters = new object[]
		{
			typeof(string),
			"System.Security.Cryptography.X509Certificates.X509CertificateCollection",
			"System.Security.Authentication.SslProtocols",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "AuthenticateAsServer", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate),
			typeof(bool),
			"System.Security.Authentication.SslProtocols",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "Write", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.AsyncManualResetEvent", Member = "Set", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "Write", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream", Member = "Close_internal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "FinishInitUriString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public void Wait()
		{
			throw null;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x000177BC File Offset: 0x000159BC
		[global::Cpp2ILInjected.Token(Token = "0x60013AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA9468", Offset = "0x1CA9468", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.AsyncManualResetEvent", Member = "WaitOne", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		public bool Wait(int millisecondsTimeout)
		{
			throw null;
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000177BF File Offset: 0x000159BF
		[global::Cpp2ILInjected.Token(Token = "0x60013AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA9350", Offset = "0x1CA9350", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ThrowIfExceptional", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000177C2 File Offset: 0x000159C2
		[global::Cpp2ILInjected.Token(Token = "0x60013AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA9B5C", Offset = "0x1CA9B5C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "TryRunInline", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskSchedulerException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private bool WrappedTryRunInline()
		{
			throw null;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000177C5 File Offset: 0x000159C5
		[global::Cpp2ILInjected.Token(Token = "0x60013B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA9470", Offset = "0x1CA9470", Length = "0x6EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "GetResultCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Threading.Tasks.Tracing.TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Threading.Tasks.Tracing.TaskTrace), Member = "TaskWaitBegin_Synchronous", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_CanBeCanceled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "WrappedTryRunInline", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "SpinThenBlockingWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Threading.Tasks.Tracing.TaskTrace), Member = "TaskWaitEnd", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		[MethodImpl(64)]
		internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x000177C8 File Offset: 0x000159C8
		[global::Cpp2ILInjected.Token(Token = "0x60013B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA9EA8", Offset = "0x1CA9EA8", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "SpinWait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task.SetOnInvokeMres), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new object[]
		{
			typeof(ITaskCompletionAction),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x000177CB File Offset: 0x000159CB
		[global::Cpp2ILInjected.Token(Token = "0x60013B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA03C", Offset = "0x1CAA03C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "SpinThenBlockingWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnce", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool SpinWait(int millisecondsTimeout)
		{
			throw null;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000177CE File Offset: 0x000159CE
		[global::Cpp2ILInjected.Token(Token = "0x60013B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5B0C", Offset = "0x1CA5B0C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(Task),
			typeof(TaskContinuation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TaskCancelCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandardTaskContinuation), Member = "Run", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "RecordInternalCancellationRequest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskSchedulerException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			throw null;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000177D1 File Offset: 0x000159D1
		[global::Cpp2ILInjected.Token(Token = "0x60013B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA224", Offset = "0x1CAA224", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Task.ContingentProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void RecordInternalCancellationRequest()
		{
			throw null;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000177D4 File Offset: 0x000159D4
		[global::Cpp2ILInjected.Token(Token = "0x60013B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA264", Offset = "0x1CAA264", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "RecordInternalCancellationRequest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
			throw null;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000177D7 File Offset: 0x000159D7
		[global::Cpp2ILInjected.Token(Token = "0x60013B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA60D4", Offset = "0x1CA60D4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
		{
			throw null;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x000177DA File Offset: 0x000159DA
		[global::Cpp2ILInjected.Token(Token = "0x60013B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA6110", Offset = "0x1CA6110", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task.ContingentProperties), Member = "UnregisterCancellationCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void CancellationCleanupLogic()
		{
			throw null;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x000177DD File Offset: 0x000159DD
		[global::Cpp2ILInjected.Token(Token = "0x60013B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA8EFC", Offset = "0x1CA8EFC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetCancellationAcknowledged()
		{
			throw null;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x000177E0 File Offset: 0x000159E0
		[global::Cpp2ILInjected.Token(Token = "0x60013B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA828C", Offset = "0x1CA828C", Length = "0x6DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = "RunOrScheduleAction", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool),
			typeof(ref Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		internal void FinishContinuations()
		{
			throw null;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000177E3 File Offset: 0x000159E3
		[global::Cpp2ILInjected.Token(Token = "0x60013BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA464", Offset = "0x1CAA464", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		private void LogFinishCompletionNotification()
		{
			throw null;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000177E6 File Offset: 0x000159E6
		[global::Cpp2ILInjected.Token(Token = "0x60013BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA4B8", Offset = "0x1CAA4B8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(global::System.IntPtr),
			"System.IOSelectorJob"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[]
		{
			typeof(global::System.Action<Task>),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Task ContinueWith(global::System.Action<Task> continuationAction)
		{
			throw null;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x000177E9 File Offset: 0x000159E9
		[global::Cpp2ILInjected.Token(Token = "0x60013BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA5CC", Offset = "0x1CAA5CC", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[] { typeof(global::System.Action<Task>) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new object[]
		{
			typeof(TaskContinuationOptions),
			typeof(ref TaskCreationOptions),
			typeof(ref InternalTaskOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContinuationTaskFromTask), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.Delegate),
			typeof(object),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
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
		private Task ContinueWith(global::System.Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			throw null;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x000177EC File Offset: 0x000159EC
		[global::Cpp2ILInjected.Token(Token = "0x60013BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA9FC", Offset = "0x1CAA9FC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "RunReadWriteTaskWhenReady", MemberParameters = new object[]
		{
			typeof(Task),
			"System.IO.Stream.ReadWriteTask"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Task ContinueWith(global::System.Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x000177EF File Offset: 0x000159EF
		[global::Cpp2ILInjected.Token(Token = "0x60013BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAAA10", Offset = "0x1CAAA10", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new object[]
		{
			typeof(TaskContinuationOptions),
			typeof(ref TaskCreationOptions),
			typeof(ref InternalTaskOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContinuationTaskFromTask), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.Delegate),
			typeof(object),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
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
		private Task ContinueWith(global::System.Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			throw null;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000177F2 File Offset: 0x000159F2
		[global::Cpp2ILInjected.Token(Token = "0x60013BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA720", Offset = "0x1CAA720", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "ContinueWith", MemberParameters = new object[]
		{
			"System.Action`1<Task`1<TResult>>",
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "ContinueWith", MemberTypeParameters = new object[] { "TNewResult" }, MemberParameters = new object[]
		{
			"System.Func`2<Task`1<TResult>, TNewResult>",
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[]
		{
			typeof(global::System.Action<Task>),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[]
		{
			typeof(global::System.Action<Task, object>),
			typeof(object),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
			throw null;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x000177F5 File Offset: 0x000159F5
		[global::Cpp2ILInjected.Token(Token = "0x60013C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA8F4", Offset = "0x1CAA8F4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "ContinueWith", MemberParameters = new object[]
		{
			"System.Action`1<Task`1<TResult>>",
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "ContinueWith", MemberTypeParameters = new object[] { "TNewResult" }, MemberParameters = new object[]
		{
			"System.Func`2<Task`1<TResult>, TNewResult>",
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[]
		{
			typeof(global::System.Action<Task>),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[]
		{
			typeof(global::System.Action<Task, object>),
			typeof(object),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StandardTaskContinuation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(TaskContinuationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_CanBeCanceled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(Task),
			typeof(TaskContinuation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
			throw null;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000177F8 File Offset: 0x000159F8
		[global::Cpp2ILInjected.Token(Token = "0x60013C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAAC90", Offset = "0x1CAAC90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "ProcessInnerTask", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.ReadWriteTask", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(global::System.Func<object, int>),
			typeof(object),
			typeof(global::System.IO.Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new object[]
		{
			typeof(ITaskCompletionAction),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal void AddCompletionAction(ITaskCompletionAction action)
		{
			throw null;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000177FB File Offset: 0x000159FB
		[global::Cpp2ILInjected.Token(Token = "0x60013C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA158", Offset = "0x1CAA158", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "SpinThenBlockingWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new object[] { typeof(ITaskCompletionAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<Task>) }, ReturnType = typeof(Task<Task>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
			throw null;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x000177FE File Offset: 0x000159FE
		[global::Cpp2ILInjected.Token(Token = "0x60013C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAAC98", Offset = "0x1CAAC98", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelListWithIList<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "RemoveAll", MemberParameters = new object[] { "System.Predicate`1<T>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
		{
			throw null;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00017801 File Offset: 0x00015A01
		[global::Cpp2ILInjected.Token(Token = "0x60013C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA922C", Offset = "0x1CA922C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new object[]
		{
			typeof(ITaskCompletionAction),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddTaskContinuationComplex", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool AddTaskContinuation(object tc, bool addBeforeOthers)
		{
			throw null;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00017804 File Offset: 0x00015A04
		[global::Cpp2ILInjected.Token(Token = "0x60013C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5E0C", Offset = "0x1CA5E0C", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "TaskCancelCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "SpinThenBlockingWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory.CompleteOnInvokePromise), Member = "Invoke", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<Task>) }, ReturnType = typeof(Task<Task>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelListWithIList<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "IndexOf", MemberParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal void RemoveContinuation(object continuationObject)
		{
			throw null;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00017807 File Offset: 0x00015A07
		[global::Cpp2ILInjected.Token(Token = "0x60013C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0434", Offset = "0x15A0434", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.AsyncHelper", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Task<TResult> FromResult<TResult>(TResult result)
		{
			throw null;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0001780A File Offset: 0x00015A0A
		[global::Cpp2ILInjected.Token(Token = "0x60013C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA41B8", Offset = "0x1CA41B8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTask), Member = "GetTaskForValueTaskSource", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Sources.IValueTaskSource) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "WriteAsync", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "SendAsyncForNetworkStream", MemberParameters = new object[] { "System.Net.Sockets.Socket" }, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task[]), Member = "FromException", MemberTypeParameters = new object[] { typeof(VoidTaskResult) }, MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Task FromException(global::System.Exception exception)
		{
			throw null;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0001780D File Offset: 0x00015A0D
		[global::Cpp2ILInjected.Token(Token = "0x60013C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A023C", Offset = "0x15A023C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream", Member = "ReadAsync", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "ReceiveAsync", MemberParameters = new object[] { "System.Net.Sockets.Socket" }, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Task<TResult> FromException<TResult>(global::System.Exception exception)
		{
			throw null;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00017810 File Offset: 0x00015A10
		[global::Cpp2ILInjected.Token(Token = "0x60013C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAAF9C", Offset = "0x1CAAF9C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Run", MemberParameters = new object[]
		{
			typeof(global::System.Func<Task>),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TaskCreationOptions),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static Task FromCancellation(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00017813 File Offset: 0x00015A13
		[global::Cpp2ILInjected.Token(Token = "0x60013CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA45F0", Offset = "0x1CA45F0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTask), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.NullStream", Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.NullStream", Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.NullStream", Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream", Member = "WriteAsync", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
		{
			"System.ReadOnlyMemory`1<Byte>",
			"System.Net.Sockets.SocketFlags",
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.ChunkedMemoryStream", Member = "WriteAsync", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCancellation", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Task FromCanceled(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00017816 File Offset: 0x00015A16
		[global::Cpp2ILInjected.Token(Token = "0x60013CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x159FE10", Offset = "0x159FE10", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00017819 File Offset: 0x00015A19
		[global::Cpp2ILInjected.Token(Token = "0x60013CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x159FD38", Offset = "0x159FD38", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "ProcessRead", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new object[]
		{
			"System.Memory`1<Byte>",
			"System.Net.Sockets.SocketFlags",
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0001781C File Offset: 0x00015A1C
		[global::Cpp2ILInjected.Token(Token = "0x60013CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x159FF80", Offset = "0x159FF80", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static Task<TResult> FromCancellation<TResult>(global::System.OperationCanceledException exception)
		{
			throw null;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0001781F File Offset: 0x00015A1F
		[global::Cpp2ILInjected.Token(Token = "0x60013CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAB058", Offset = "0x1CAB058", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RendezvousAwaitable<>), Member = "NotifyAwaiter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RendezvousAwaitable<>), Member = "OnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<InnerWrite>d__67", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalStartNew", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(global::System.Delegate),
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskScheduler),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Task Run(global::System.Action action)
		{
			throw null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00017822 File Offset: 0x00015A22
		[global::Cpp2ILInjected.Token(Token = "0x60013CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0548", Offset = "0x15A0548", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<InnerRead>d__66", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Task<TResult> Run<TResult>(global::System.Func<TResult> function)
		{
			throw null;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00017825 File Offset: 0x00015A25
		[global::Cpp2ILInjected.Token(Token = "0x60013D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAB128", Offset = "0x1CAB128", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler", Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Task Run(global::System.Func<Task> function)
		{
			throw null;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00017828 File Offset: 0x00015A28
		[global::Cpp2ILInjected.Token(Token = "0x60013D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAB180", Offset = "0x1CAB180", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCancellation", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[]
		{
			"System.Func`1<TResult>",
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskScheduler)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnwrapPromise<VoidTaskResult>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static Task Run(global::System.Func<Task> function, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0001782B File Offset: 0x00015A2B
		[global::Cpp2ILInjected.Token(Token = "0x60013D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A06B8", Offset = "0x15A06B8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "GetRequestStreamAsync", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "GetResponseAsync", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Task<TResult> Run<TResult>(global::System.Func<Task<TResult>> function)
		{
			throw null;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0001782E File Offset: 0x00015A2E
		[global::Cpp2ILInjected.Token(Token = "0x60013D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0728", Offset = "0x15A0728", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static Task<TResult> Run<TResult>(global::System.Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00017831 File Offset: 0x00015A31
		[global::Cpp2ILInjected.Token(Token = "0x60013D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAB388", Offset = "0x1CAB388", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler", Member = "OperationCompleted", MemberParameters = new object[] { "System.Net.ServicePointScheduler.ConnectionGroup", "System.Net.WebOperation" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Task Delay(int millisecondsDelay)
		{
			throw null;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00017834 File Offset: 0x00015A34
		[global::Cpp2ILInjected.Token(Token = "0x60013D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAB3E0", Offset = "0x1CAB3E0", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCancellation", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task.DelayPromise), Member = ".ctor", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_CanBeCanceled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "InternalRegisterWithoutEC", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Init", MemberParameters = new object[]
		{
			typeof(TimerCallback),
			typeof(object),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00017837 File Offset: 0x00015A37
		[global::Cpp2ILInjected.Token(Token = "0x60013D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAB818", Offset = "0x1CAB818", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			throw null;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0001783A File Offset: 0x00015A3A
		[global::Cpp2ILInjected.Token(Token = "0x60013D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CABBAC", Offset = "0x1CABBAC", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelListWithIList<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<Task>) }, ReturnType = typeof(Task<Task>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		public static Task<Task> WhenAny(global::System.Collections.Generic.IEnumerable<Task> tasks)
		{
			throw null;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0001783D File Offset: 0x00015A3D
		[global::System.Runtime.CompilerServices.FriendAccessAllowed]
		[global::Cpp2ILInjected.Token(Token = "0x60013D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC004", Offset = "0x1CAC004", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine),
			typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore.MoveNextRunner),
			typeof(Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static bool AddToActiveTasks(Task task)
		{
			throw null;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00017840 File Offset: 0x00015A40
		[global::System.Runtime.CompilerServices.FriendAccessAllowed]
		[global::Cpp2ILInjected.Token(Token = "0x60013D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC154", Offset = "0x1CAC154", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), Member = "SetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static void RemoveFromActiveTasks(int taskId)
		{
			throw null;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00017843 File Offset: 0x00015A43
		[global::Cpp2ILInjected.Token(Token = "0x60013DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC28C", Offset = "0x1CAC28C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void MarkAborted(ThreadAbortException e)
		{
			throw null;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00017846 File Offset: 0x00015A46
		[global::Cpp2ILInjected.Token(Token = "0x60013DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA8C38", Offset = "0x1CA8C38", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_CapturedContext", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Execute", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void ExecuteWithThreadLocal(ref Task currentTaskSlot)
		{
			throw null;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00017849 File Offset: 0x00015A49
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60013DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC29C", Offset = "0x1CAC29C", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskContinuationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TaskCreationOptions),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		static Task()
		{
			throw null;
		}

		// Token: 0x04000802 RID: 2050
		[global::Cpp2ILInjected.Token(Token = "0x4000A59")]
		internal static int s_taskIdCounter;

		// Token: 0x04000803 RID: 2051
		[global::Cpp2ILInjected.Token(Token = "0x4000A5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_taskId;

		// Token: 0x04000804 RID: 2052
		[global::Cpp2ILInjected.Token(Token = "0x4000A5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.Delegate m_action;

		// Token: 0x04000805 RID: 2053
		[global::Cpp2ILInjected.Token(Token = "0x4000A5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal object m_stateObject;

		// Token: 0x04000806 RID: 2054
		[global::Cpp2ILInjected.Token(Token = "0x4000A5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal TaskScheduler m_taskScheduler;

		// Token: 0x04000807 RID: 2055
		[global::Cpp2ILInjected.Token(Token = "0x4000A5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal readonly Task m_parent;

		// Token: 0x04000808 RID: 2056
		[global::Cpp2ILInjected.Token(Token = "0x4000A5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal int m_stateFlags;

		// Token: 0x04000809 RID: 2057
		[global::Cpp2ILInjected.Token(Token = "0x4000A60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object m_continuationObject;

		// Token: 0x0400080A RID: 2058
		[global::Cpp2ILInjected.Token(Token = "0x4000A61")]
		private static readonly object s_taskCompletionSentinel;

		// Token: 0x0400080B RID: 2059
		[global::Cpp2ILInjected.Token(Token = "0x4000A62")]
		internal static bool s_asyncDebuggingEnabled;

		// Token: 0x0400080C RID: 2060
		[global::Cpp2ILInjected.Token(Token = "0x4000A63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal Task.ContingentProperties m_contingentProperties;

		// Token: 0x0400080D RID: 2061
		[global::Cpp2ILInjected.Token(Token = "0x4000A64")]
		private static readonly global::System.Action<object> s_taskCancelCallback;

		// Token: 0x0400080E RID: 2062
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000A65")]
		internal static Task t_currentTask;

		// Token: 0x0400080F RID: 2063
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000A66")]
		private static StackGuard t_stackGuard;

		// Token: 0x04000810 RID: 2064
		[global::Cpp2ILInjected.Token(Token = "0x4000A67")]
		private static readonly global::System.Func<Task.ContingentProperties> s_createContingentProperties;

		// Token: 0x04000811 RID: 2065
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000A68")]
		private static readonly TaskFactory <Factory>k__BackingField;

		// Token: 0x04000812 RID: 2066
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000A69")]
		private static readonly Task <CompletedTask>k__BackingField;

		// Token: 0x04000813 RID: 2067
		[global::Cpp2ILInjected.Token(Token = "0x4000A6A")]
		private static readonly global::System.Predicate<Task> s_IsExceptionObservedByParentPredicate;

		// Token: 0x04000814 RID: 2068
		[global::Cpp2ILInjected.Token(Token = "0x4000A6B")]
		private static ContextCallback s_ecCallback;

		// Token: 0x04000815 RID: 2069
		[global::Cpp2ILInjected.Token(Token = "0x4000A6C")]
		private static readonly global::System.Predicate<object> s_IsTaskContinuationNullPredicate;

		// Token: 0x04000816 RID: 2070
		[global::Cpp2ILInjected.Token(Token = "0x4000A6D")]
		private static readonly global::System.Collections.Generic.Dictionary<int, Task> s_currentActiveTasks;

		// Token: 0x04000817 RID: 2071
		[global::Cpp2ILInjected.Token(Token = "0x4000A6E")]
		private static readonly object s_activeTasksLock;

		// Token: 0x020005C5 RID: 1477
		[global::Cpp2ILInjected.Token(Token = "0x2000233")]
		internal class ContingentProperties
		{
			// Token: 0x06004072 RID: 16498 RVA: 0x0001FC07 File Offset: 0x0001DE07
			[global::Cpp2ILInjected.Token(Token = "0x60013DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA7F70", Offset = "0x1CA7F70", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task<>), Member = "TrySetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void SetCompleted()
			{
				throw null;
			}

			// Token: 0x06004073 RID: 16499 RVA: 0x0001FC0A File Offset: 0x0001DE0A
			[global::Cpp2ILInjected.Token(Token = "0x60013DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA7F98", Offset = "0x1CA7F98", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void UnregisterCancellationCallback()
			{
				throw null;
			}

			// Token: 0x06004074 RID: 16500 RVA: 0x0001FC0D File Offset: 0x0001DE0D
			[global::Cpp2ILInjected.Token(Token = "0x60013DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA5378", Offset = "0x1CA5378", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public ContingentProperties()
			{
				throw null;
			}

			// Token: 0x040018DF RID: 6367
			[global::Cpp2ILInjected.Token(Token = "0x4000A6F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal ExecutionContext m_capturedContext;

			// Token: 0x040018E0 RID: 6368
			[global::Cpp2ILInjected.Token(Token = "0x4000A70")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal ManualResetEventSlim m_completionEvent;

			// Token: 0x040018E1 RID: 6369
			[global::Cpp2ILInjected.Token(Token = "0x4000A71")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal TaskExceptionHolder m_exceptionsHolder;

			// Token: 0x040018E2 RID: 6370
			[global::Cpp2ILInjected.Token(Token = "0x4000A72")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal CancellationToken m_cancellationToken;

			// Token: 0x040018E3 RID: 6371
			[global::Cpp2ILInjected.Token(Token = "0x4000A73")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal object m_cancellationRegistration;

			// Token: 0x040018E4 RID: 6372
			[global::Cpp2ILInjected.Token(Token = "0x4000A74")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal int m_internalCancellationRequested;

			// Token: 0x040018E5 RID: 6373
			[global::Cpp2ILInjected.Token(Token = "0x4000A75")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			internal int m_completionCountdown;

			// Token: 0x040018E6 RID: 6374
			[global::Cpp2ILInjected.Token(Token = "0x4000A76")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			internal global::System.Collections.Generic.LowLevelListWithIList<Task> m_exceptionalChildren;
		}

		// Token: 0x020005C6 RID: 1478
		[global::Cpp2ILInjected.Token(Token = "0x2000234")]
		private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
		{
			// Token: 0x06004075 RID: 16501 RVA: 0x0001FC10 File Offset: 0x0001DE10
			[global::Cpp2ILInjected.Token(Token = "0x60013E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAA0F8", Offset = "0x1CAA0F8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "SpinThenBlockingWait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal SetOnInvokeMres()
			{
				throw null;
			}

			// Token: 0x06004076 RID: 16502 RVA: 0x0001FC13 File Offset: 0x0001DE13
			[global::Cpp2ILInjected.Token(Token = "0x60013E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC5A0", Offset = "0x1CAC5A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
			public void Invoke(Task completingTask)
			{
				throw null;
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06004077 RID: 16503 RVA: 0x0001FC16 File Offset: 0x0001DE16
			[global::Cpp2ILInjected.Token(Token = "0x170001F2")]
			public bool InvokeMayRunArbitraryCode
			{
				[global::Cpp2ILInjected.Token(Token = "0x60013E2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CAC5A8", Offset = "0x1CAC5A8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x020005C7 RID: 1479
		[global::Cpp2ILInjected.Token(Token = "0x2000235")]
		private sealed class DelayPromise : Task<VoidTaskResult>
		{
			// Token: 0x06004078 RID: 16504 RVA: 0x0001FC19 File Offset: 0x0001DE19
			[global::Cpp2ILInjected.Token(Token = "0x60013E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAB704", Offset = "0x1CAB704", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<VoidTaskResult>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			internal DelayPromise(CancellationToken token)
			{
				throw null;
			}

			// Token: 0x06004079 RID: 16505 RVA: 0x0001FC1C File Offset: 0x0001DE1C
			[global::Cpp2ILInjected.Token(Token = "0x60013E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC5B0", Offset = "0x1CAC5B0", Length = "0x138")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.Task.<>c", Member = "<Delay>b__247_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.Task.<>c", Member = "<Delay>b__247_1", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
			{
				typeof(CancellationToken),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<VoidTaskResult>), Member = "TrySetResult", MemberParameters = new object[] { typeof(VoidTaskResult) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal void Complete()
			{
				throw null;
			}

			// Token: 0x040018E7 RID: 6375
			[global::Cpp2ILInjected.Token(Token = "0x4000A77")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal readonly CancellationToken Token;

			// Token: 0x040018E8 RID: 6376
			[global::Cpp2ILInjected.Token(Token = "0x4000A78")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			internal CancellationTokenRegistration Registration;

			// Token: 0x040018E9 RID: 6377
			[global::Cpp2ILInjected.Token(Token = "0x4000A79")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			internal Timer Timer;
		}

		// Token: 0x020005C8 RID: 1480
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000236")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x0600407A RID: 16506 RVA: 0x0001FC1F File Offset: 0x0001DE1F
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60013E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC6E8", Offset = "0x1CAC6E8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x0600407B RID: 16507 RVA: 0x0001FC22 File Offset: 0x0001DE22
			[global::Cpp2ILInjected.Token(Token = "0x60013E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC744", Offset = "0x1CAC744", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x0600407C RID: 16508 RVA: 0x0001FC25 File Offset: 0x0001DE25
			[global::Cpp2ILInjected.Token(Token = "0x60013E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC74C", Offset = "0x1CAC74C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.Task.DelayPromise", Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <Delay>b__247_0(object state)
			{
				throw null;
			}

			// Token: 0x0600407D RID: 16509 RVA: 0x0001FC28 File Offset: 0x0001DE28
			[global::Cpp2ILInjected.Token(Token = "0x60013E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC7AC", Offset = "0x1CAC7AC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.Task.DelayPromise", Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <Delay>b__247_1(object state)
			{
				throw null;
			}

			// Token: 0x0600407E RID: 16510 RVA: 0x0001FC2B File Offset: 0x0001DE2B
			[global::Cpp2ILInjected.Token(Token = "0x60013E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC80C", Offset = "0x1CAC80C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal Task.ContingentProperties <.cctor>b__271_0()
			{
				throw null;
			}

			// Token: 0x0600407F RID: 16511 RVA: 0x0001FC2E File Offset: 0x0001DE2E
			[global::Cpp2ILInjected.Token(Token = "0x60013EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC870", Offset = "0x1CAC870", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <.cctor>b__271_1(Task t)
			{
				throw null;
			}

			// Token: 0x06004080 RID: 16512 RVA: 0x0001FC31 File Offset: 0x0001DE31
			[global::Cpp2ILInjected.Token(Token = "0x60013EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC888", Offset = "0x1CAC888", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <.cctor>b__271_2(object tc)
			{
				throw null;
			}

			// Token: 0x040018EA RID: 6378
			[global::Cpp2ILInjected.Token(Token = "0x4000A7A")]
			public static readonly Task.<>c <>9;

			// Token: 0x040018EB RID: 6379
			[global::Cpp2ILInjected.Token(Token = "0x4000A7B")]
			public static global::System.Action<object> <>9__247_0;

			// Token: 0x040018EC RID: 6380
			[global::Cpp2ILInjected.Token(Token = "0x4000A7C")]
			public static TimerCallback <>9__247_1;
		}
	}
}
