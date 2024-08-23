using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001CB RID: 459
	[global::Cpp2ILInjected.Token(Token = "0x200024C")]
	public class TaskFactory
	{
		// Token: 0x0600127D RID: 4733 RVA: 0x000178F4 File Offset: 0x00015AF4
		[global::Cpp2ILInjected.Token(Token = "0x6001430")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC58C", Offset = "0x1CAC58C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskContinuationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		public TaskFactory()
		{
			throw null;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000178F7 File Offset: 0x00015AF7
		[global::Cpp2ILInjected.Token(Token = "0x6001431")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE694", Offset = "0x1CAE694", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "CheckMultiTaskContinuationOptions", MemberParameters = new object[] { typeof(TaskContinuationOptions) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "CheckCreationOptions", MemberParameters = new object[] { typeof(TaskCreationOptions) }, ReturnType = typeof(void))]
		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000178FA File Offset: 0x00015AFA
		[global::Cpp2ILInjected.Token(Token = "0x6001432")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE7E0", Offset = "0x1CAE7E0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskContinuationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskContinuationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void CheckCreationOptions(TaskCreationOptions creationOptions)
		{
			throw null;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000178FD File Offset: 0x00015AFD
		[global::Cpp2ILInjected.Token(Token = "0x6001433")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE83C", Offset = "0x1CAE83C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "InvokeContinuation", MemberParameters = new object[]
		{
			"System.Action`1<Object>",
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BackgroundWorker", Member = "RunWorkerAsync", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new object[] { typeof(TaskCreationOptions) }, ReturnType = typeof(Task))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Task StartNew(global::System.Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00017900 File Offset: 0x00015B00
		[global::Cpp2ILInjected.Token(Token = "0x6001434")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A09A8", Offset = "0x15A09A8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "Run", MemberParameters = new object[]
		{
			typeof(global::System.Func<Task>),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new object[] { typeof(TaskCreationOptions) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Task<TResult> StartNew<TResult>(global::System.Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00017903 File Offset: 0x00015B03
		[global::Cpp2ILInjected.Token(Token = "0x6001435")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0A44", Offset = "0x15A0A44", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.AsyncManualResetEvent", Member = "Set", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new object[] { typeof(TaskCreationOptions) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Task<TResult> StartNew<TResult>(global::System.Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00017906 File Offset: 0x00015B06
		[global::Cpp2ILInjected.Token(Token = "0x6001436")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0924", Offset = "0x15A0924", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task FromAsync<TArg1>(global::System.Func<TArg1, global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Action<global::System.IAsyncResult> endMethod, TArg1 arg1, object state)
		{
			throw null;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00017909 File Offset: 0x00015B09
		[global::Cpp2ILInjected.Token(Token = "0x6001437")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0938", Offset = "0x15A0938", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task FromAsync<TArg1>(global::System.Func<TArg1, global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Action<global::System.IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			throw null;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0001790C File Offset: 0x00015B0C
		[global::Cpp2ILInjected.Token(Token = "0x6001438")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0950", Offset = "0x15A0950", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.TcpClient", Member = "ConnectAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task FromAsync<TArg1, TArg2>(global::System.Func<TArg1, TArg2, global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Action<global::System.IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
		{
			throw null;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0001790F File Offset: 0x00015B0F
		[global::Cpp2ILInjected.Token(Token = "0x6001439")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0978", Offset = "0x15A0978", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task FromAsync<TArg1, TArg2>(global::System.Func<TArg1, TArg2, global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Action<global::System.IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			throw null;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00017912 File Offset: 0x00015B12
		[global::Cpp2ILInjected.Token(Token = "0x600143A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE8CC", Offset = "0x1CAE8CC", Length = "0xE8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
		{
			throw null;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00017915 File Offset: 0x00015B15
		[global::Cpp2ILInjected.Token(Token = "0x600143B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAB980", Offset = "0x1CAB980", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "WhenAny", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<Task>) }, ReturnType = typeof(Task<Task>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory.CompleteOnInvokePromise), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<Task>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory.CompleteOnInvokePromise), Member = "Invoke", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new object[]
		{
			typeof(ITaskCompletionAction),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static Task<Task> CommonCWAnyLogic(global::System.Collections.Generic.IList<Task> tasks)
		{
			throw null;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00017918 File Offset: 0x00015B18
		[global::Cpp2ILInjected.Token(Token = "0x600143C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE6E4", Offset = "0x1CAE6E4", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskContinuationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskContinuationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
		{
			throw null;
		}

		// Token: 0x0400084F RID: 2127
		[global::Cpp2ILInjected.Token(Token = "0x4000AB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly CancellationToken m_defaultCancellationToken;

		// Token: 0x04000850 RID: 2128
		[global::Cpp2ILInjected.Token(Token = "0x4000ABA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly TaskScheduler m_defaultScheduler;

		// Token: 0x04000851 RID: 2129
		[global::Cpp2ILInjected.Token(Token = "0x4000ABB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly TaskCreationOptions m_defaultCreationOptions;

		// Token: 0x04000852 RID: 2130
		[global::Cpp2ILInjected.Token(Token = "0x4000ABC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private readonly TaskContinuationOptions m_defaultContinuationOptions;

		// Token: 0x020005CC RID: 1484
		[global::Cpp2ILInjected.Token(Token = "0x200024D")]
		internal sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
		{
			// Token: 0x0600408A RID: 16522 RVA: 0x0001FC4F File Offset: 0x0001DE4F
			[global::Cpp2ILInjected.Token(Token = "0x600143D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAE9B4", Offset = "0x1CAE9B4", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<Task>) }, ReturnType = typeof(Task<Task>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public CompleteOnInvokePromise(global::System.Collections.Generic.IList<Task> tasks)
			{
				throw null;
			}

			// Token: 0x0600408B RID: 16523 RVA: 0x0001FC52 File Offset: 0x0001DE52
			[global::Cpp2ILInjected.Token(Token = "0x600143E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAEAC8", Offset = "0x1CAEAC8", Length = "0x224")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<Task>) }, ReturnType = typeof(Task<Task>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "TrySetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public void Invoke(Task completingTask)
			{
				throw null;
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x0600408C RID: 16524 RVA: 0x0001FC55 File Offset: 0x0001DE55
			[global::Cpp2ILInjected.Token(Token = "0x170001F7")]
			public bool InvokeMayRunArbitraryCode
			{
				[global::Cpp2ILInjected.Token(Token = "0x600143F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CAECEC", Offset = "0x1CAECEC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040018F2 RID: 6386
			[global::Cpp2ILInjected.Token(Token = "0x4000ABD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private global::System.Collections.Generic.IList<Task> _tasks;
		}
	}
}
