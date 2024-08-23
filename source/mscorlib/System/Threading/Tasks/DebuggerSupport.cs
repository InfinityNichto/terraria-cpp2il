using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x020001B3 RID: 435
	[global::Cpp2ILInjected.Token(Token = "0x2000229")]
	internal static class DebuggerSupport
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00017654 File Offset: 0x00015854
		[global::Cpp2ILInjected.Token(Token = "0x170001D2")]
		public static bool LoggingOn
		{
			[global::Cpp2ILInjected.Token(Token = "0x600132B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA4D98", Offset = "0x1CA4D98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberParameters = new object[]
			{
				typeof(global::System.Func<global::System.AsyncCallback, object, global::System.IAsyncResult>),
				"System.Func`2<IAsyncResult, TResult>",
				typeof(global::System.Action<global::System.IAsyncResult>),
				typeof(object),
				typeof(TaskCreationOptions)
			}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1" }, MemberParameters = new object[]
			{
				"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>",
				"System.Func`2<IAsyncResult, TResult>",
				typeof(global::System.Action<global::System.IAsyncResult>),
				"TArg1",
				typeof(object),
				typeof(TaskCreationOptions)
			}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1", "TArg2" }, MemberParameters = new object[]
			{
				"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>",
				"System.Func`2<IAsyncResult, TResult>",
				typeof(global::System.Action<global::System.IAsyncResult>),
				"TArg1",
				"TArg2",
				typeof(object),
				typeof(TaskCreationOptions)
			}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00017657 File Offset: 0x00015857
		[global::Cpp2ILInjected.Token(Token = "0x600132C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4DA0", Offset = "0x1CA4DA0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.AsyncCallback, object, global::System.IAsyncResult>),
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1" }, MemberParameters = new object[]
		{
			"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			"TArg1",
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1", "TArg2" }, MemberParameters = new object[]
		{
			"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			"TArg1",
			"TArg2",
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext)
		{
			throw null;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0001765A File Offset: 0x0001585A
		[global::Cpp2ILInjected.Token(Token = "0x600132D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4DA4", Offset = "0x1CA4DA4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.AsyncCallback, object, global::System.IAsyncResult>),
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1" }, MemberParameters = new object[]
		{
			"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			"TArg1",
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1", "TArg2" }, MemberParameters = new object[]
		{
			"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			"TArg1",
			"TArg2",
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, Internal.Runtime.Augments.AsyncStatus status)
		{
			throw null;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0001765D File Offset: 0x0001585D
		[global::Cpp2ILInjected.Token(Token = "0x600132E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4DA8", Offset = "0x1CA4DA8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation)
		{
			throw null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00017660 File Offset: 0x00015860
		[global::Cpp2ILInjected.Token(Token = "0x600132F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4DAC", Offset = "0x1CA4DAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work)
		{
			throw null;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00017663 File Offset: 0x00015863
		[global::Cpp2ILInjected.Token(Token = "0x6001330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4DB0", Offset = "0x1CA4DB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
			throw null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00017666 File Offset: 0x00015866
		[global::Cpp2ILInjected.Token(Token = "0x6001331")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4DB4", Offset = "0x1CA4DB4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		public static void AddToActiveTasks(Task task)
		{
			throw null;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00017669 File Offset: 0x00015869
		[global::Cpp2ILInjected.Token(Token = "0x6001332")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4E48", Offset = "0x1CA4E48", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.AsyncCallback, object, global::System.IAsyncResult>),
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1" }, MemberParameters = new object[]
		{
			"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			"TArg1",
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1", "TArg2" }, MemberParameters = new object[]
		{
			"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			"TArg1",
			"TArg2",
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.Task.DelayPromise", Member = ".ctor", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandardTaskContinuation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(TaskContinuationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory.CompleteOnInvokePromise), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<Task>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelDictionary<, >), Member = "set_Item", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		[MethodImpl(8)]
		private static void AddToActiveTasksNonInlined(Task task)
		{
			throw null;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0001766C File Offset: 0x0001586C
		[global::Cpp2ILInjected.Token(Token = "0x6001333")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5024", Offset = "0x1CA5024", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		public static void RemoveFromActiveTasks(Task task)
		{
			throw null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0001766F File Offset: 0x0001586F
		[global::Cpp2ILInjected.Token(Token = "0x6001334")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA50B8", Offset = "0x1CA50B8", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.AsyncCallback, object, global::System.IAsyncResult>),
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1" }, MemberParameters = new object[]
		{
			"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			"TArg1",
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = "FromAsyncImpl", MemberTypeParameters = new object[] { "TArg1", "TArg2" }, MemberParameters = new object[]
		{
			"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>",
			"System.Func`2<IAsyncResult, TResult>",
			typeof(global::System.Action<global::System.IAsyncResult>),
			"TArg1",
			"TArg2",
			typeof(object),
			typeof(TaskCreationOptions)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.Task.DelayPromise", Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "TrySetFromTask", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory.CompleteOnInvokePromise), Member = "Invoke", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelDictionary<, >), Member = "Remove", MemberParameters = new object[] { "TKey" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		[MethodImpl(8)]
		private static void RemoveFromActiveTasksNonInlined(Task task)
		{
			throw null;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00017672 File Offset: 0x00015872
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001335")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA5200", Offset = "0x1CA5200", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelDictionary<, >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static DebuggerSupport()
		{
			throw null;
		}

		// Token: 0x040007F1 RID: 2033
		[global::Cpp2ILInjected.Token(Token = "0x4000A3C")]
		private static readonly global::System.Collections.Generic.LowLevelDictionary<int, Task> s_activeTasks;

		// Token: 0x040007F2 RID: 2034
		[global::Cpp2ILInjected.Token(Token = "0x4000A3D")]
		private static readonly object s_activeTasksLock;
	}
}
