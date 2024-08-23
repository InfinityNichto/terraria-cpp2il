using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003DE RID: 990
	[global::Cpp2ILInjected.Token(Token = "0x2000492")]
	internal struct AsyncMethodBuilderCore
	{
		// Token: 0x0600200F RID: 8207 RVA: 0x00019ECE File Offset: 0x000180CE
		[global::Cpp2ILInjected.Token(Token = "0x6002274")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74534", Offset = "0x1B74534", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncTaskMethodBuilder<>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00019ED1 File Offset: 0x000180D1
		[global::Cpp2ILInjected.Token(Token = "0x6002275")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74E9C", Offset = "0x1B74E9C", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncTaskMethodBuilder<>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Debugger), Member = "NotifyOfCrossThreadDependency", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "FastCapture", ReturnType = typeof(global::System.Threading.ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "get_IsPreAllocatedDefault", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncMethodBuilderCore), Member = "OutputAsyncCausalityEvents", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.Action)
		}, ReturnType = typeof(global::System.Action))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal global::System.Action GetCompletionAction(global::System.Threading.Tasks.Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize)
		{
			throw null;
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00019ED4 File Offset: 0x000180D4
		[global::Cpp2ILInjected.Token(Token = "0x6002276")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75080", Offset = "0x1B75080", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(ref AsyncMethodBuilderCore.MoveNextRunner)
		}, ReturnType = typeof(global::System.Action))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncMethodBuilderCore), Member = "CreateContinuationWrapper", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(global::System.Action),
			typeof(global::System.Threading.Tasks.Task)
		}, ReturnType = typeof(global::System.Action))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.Action OutputAsyncCausalityEvents(global::System.Threading.Tasks.Task innerTask, global::System.Action continuation)
		{
			throw null;
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00019ED7 File Offset: 0x000180D7
		[global::Cpp2ILInjected.Token(Token = "0x6002277")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75200", Offset = "0x1B75200", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncTaskMethodBuilder<>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "get_LoggingOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "TraceOperationCreation", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.CausalityTraceLevel),
			typeof(int),
			typeof(string),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "AddToActiveTasks", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, global::System.Threading.Tasks.Task builtTask)
		{
			throw null;
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00019EDA File Offset: 0x000180DA
		[global::Cpp2ILInjected.Token(Token = "0x6002278")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7486C", Offset = "0x1B7486C", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "NotifySynchronizationContextOfCompletion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncTaskMethodBuilder<>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SendOrPostCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(global::System.Threading.WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		internal static void ThrowAsync(global::System.Exception exception, global::System.Threading.SynchronizationContext targetContext)
		{
			throw null;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00019EDD File Offset: 0x000180DD
		[global::Cpp2ILInjected.Token(Token = "0x6002279")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75144", Offset = "0x1B75144", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "OutputAsyncCausalityEvents", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.Action)
		}, ReturnType = typeof(global::System.Action))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncMethodBuilderCore.ContinuationWrapper), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(global::System.Action),
			typeof(global::System.Threading.Tasks.Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static global::System.Action CreateContinuationWrapper(global::System.Action continuation, global::System.Action invokeAction, global::System.Threading.Tasks.Task innerTask = null)
		{
			throw null;
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00019EE0 File Offset: 0x000180E0
		[global::Cpp2ILInjected.Token(Token = "0x600227A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B753E0", Offset = "0x1B753E0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncMethodBuilderCore.ContinuationWrapper), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(global::System.Action),
			typeof(global::System.Threading.Tasks.Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static global::System.Threading.Tasks.Task TryGetContinuationTask(global::System.Action action)
		{
			throw null;
		}

		// Token: 0x04000FD0 RID: 4048
		[global::Cpp2ILInjected.Token(Token = "0x40012D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal IAsyncStateMachine m_stateMachine;

		// Token: 0x04000FD1 RID: 4049
		[global::Cpp2ILInjected.Token(Token = "0x40012D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal global::System.Action m_defaultContextAction;

		// Token: 0x020005FF RID: 1535
		[global::Cpp2ILInjected.Token(Token = "0x2000493")]
		internal sealed class MoveNextRunner
		{
			// Token: 0x0600413C RID: 16700 RVA: 0x0001FE50 File Offset: 0x0001E050
			[global::Cpp2ILInjected.Token(Token = "0x600227B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75054", Offset = "0x1B75054", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal MoveNextRunner(global::System.Threading.ExecutionContext context, IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0600413D RID: 16701 RVA: 0x0001FE53 File Offset: 0x0001E053
			[global::Cpp2ILInjected.Token(Token = "0x600227C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75464", Offset = "0x1B75464", Length = "0x1E0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ContextCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "Run", MemberParameters = new object[]
			{
				typeof(global::System.Threading.ExecutionContext),
				typeof(global::System.Threading.ContextCallback),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			internal void Run()
			{
				throw null;
			}

			// Token: 0x0600413E RID: 16702 RVA: 0x0001FE56 File Offset: 0x0001E056
			[global::Cpp2ILInjected.Token(Token = "0x600227D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75644", Offset = "0x1B75644", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private static void InvokeMoveNext(object stateMachine)
			{
				throw null;
			}

			// Token: 0x0400198A RID: 6538
			[global::Cpp2ILInjected.Token(Token = "0x40012D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly global::System.Threading.ExecutionContext m_context;

			// Token: 0x0400198B RID: 6539
			[global::Cpp2ILInjected.Token(Token = "0x40012D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal IAsyncStateMachine m_stateMachine;

			// Token: 0x0400198C RID: 6540
			[global::Cpp2ILInjected.Token(Token = "0x40012D6")]
			private static global::System.Threading.ContextCallback s_invokeMoveNext;
		}

		// Token: 0x02000600 RID: 1536
		[global::Cpp2ILInjected.Token(Token = "0x2000494")]
		private class ContinuationWrapper
		{
			// Token: 0x0600413F RID: 16703 RVA: 0x0001FE59 File Offset: 0x0001E059
			[global::Cpp2ILInjected.Token(Token = "0x600227E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75394", Offset = "0x1B75394", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "CreateContinuationWrapper", MemberParameters = new object[]
			{
				typeof(global::System.Action),
				typeof(global::System.Action),
				typeof(global::System.Threading.Tasks.Task)
			}, ReturnType = typeof(global::System.Action))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncMethodBuilderCore), Member = "TryGetContinuationTask", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			internal ContinuationWrapper(global::System.Action continuation, global::System.Action invokeAction, global::System.Threading.Tasks.Task innerTask)
			{
				throw null;
			}

			// Token: 0x06004140 RID: 16704 RVA: 0x0001FE5C File Offset: 0x0001E05C
			[global::Cpp2ILInjected.Token(Token = "0x600227F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7571C", Offset = "0x1B7571C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void Invoke()
			{
				throw null;
			}

			// Token: 0x0400198D RID: 6541
			[global::Cpp2ILInjected.Token(Token = "0x40012D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal readonly global::System.Action m_continuation;

			// Token: 0x0400198E RID: 6542
			[global::Cpp2ILInjected.Token(Token = "0x40012D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly global::System.Action m_invokeAction;

			// Token: 0x0400198F RID: 6543
			[global::Cpp2ILInjected.Token(Token = "0x40012D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal readonly global::System.Threading.Tasks.Task m_innerTask;
		}

		// Token: 0x02000601 RID: 1537
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000495")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004141 RID: 16705 RVA: 0x0001FE5F File Offset: 0x0001E05F
			[global::Cpp2ILInjected.Token(Token = "0x6002280")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7513C", Offset = "0x1B7513C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass5_0()
			{
				throw null;
			}

			// Token: 0x06004142 RID: 16706 RVA: 0x0001FE62 File Offset: 0x0001E062
			[global::Cpp2ILInjected.Token(Token = "0x6002281")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75730", Offset = "0x1B75730", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_Id", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "TraceSynchronousWorkStart", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.CausalityTraceLevel),
				typeof(int),
				typeof(global::System.Threading.Tasks.CausalitySynchronousWork)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "TraceSynchronousWorkCompletion", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.CausalityTraceLevel),
				typeof(global::System.Threading.Tasks.CausalitySynchronousWork)
			}, ReturnType = typeof(void))]
			internal void <OutputAsyncCausalityEvents>b__0()
			{
				throw null;
			}

			// Token: 0x04001990 RID: 6544
			[global::Cpp2ILInjected.Token(Token = "0x40012DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public global::System.Threading.Tasks.Task innerTask;

			// Token: 0x04001991 RID: 6545
			[global::Cpp2ILInjected.Token(Token = "0x40012DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public global::System.Action continuation;
		}

		// Token: 0x02000602 RID: 1538
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000496")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06004143 RID: 16707 RVA: 0x0001FE65 File Offset: 0x0001E065
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6002282")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75780", Offset = "0x1B75780", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004144 RID: 16708 RVA: 0x0001FE68 File Offset: 0x0001E068
			[global::Cpp2ILInjected.Token(Token = "0x6002283")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B757DC", Offset = "0x1B757DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004145 RID: 16709 RVA: 0x0001FE6B File Offset: 0x0001E06B
			[global::Cpp2ILInjected.Token(Token = "0x6002284")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B757E4", Offset = "0x1B757E4", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <ThrowAsync>b__7_0(object state)
			{
				throw null;
			}

			// Token: 0x06004146 RID: 16710 RVA: 0x0001FE6E File Offset: 0x0001E06E
			[global::Cpp2ILInjected.Token(Token = "0x6002285")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75834", Offset = "0x1B75834", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <ThrowAsync>b__7_1(object state)
			{
				throw null;
			}

			// Token: 0x04001992 RID: 6546
			[global::Cpp2ILInjected.Token(Token = "0x40012DC")]
			public static readonly AsyncMethodBuilderCore.<>c <>9;

			// Token: 0x04001993 RID: 6547
			[global::Cpp2ILInjected.Token(Token = "0x40012DD")]
			public static global::System.Threading.SendOrPostCallback <>9__7_0;

			// Token: 0x04001994 RID: 6548
			[global::Cpp2ILInjected.Token(Token = "0x40012DE")]
			public static global::System.Threading.WaitCallback <>9__7_1;
		}
	}
}
