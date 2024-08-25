using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000492")]
	internal struct AsyncMethodBuilderCore
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40012D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal IAsyncStateMachine m_stateMachine;

		[global::Cpp2ILInjected.Token(Token = "0x40012D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal global::System.Action m_defaultContextAction;

		[global::Cpp2ILInjected.Token(Token = "0x2000493")]
		internal sealed class MoveNextRunner
		{
			[global::Cpp2ILInjected.Token(Token = "0x600227B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75054", Offset = "0x1B75054", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal MoveNextRunner(global::System.Threading.ExecutionContext context, IAsyncStateMachine stateMachine)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x600227D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75644", Offset = "0x1B75644", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private static void InvokeMoveNext(object stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40012D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly global::System.Threading.ExecutionContext m_context;

			[global::Cpp2ILInjected.Token(Token = "0x40012D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal IAsyncStateMachine m_stateMachine;

			[global::Cpp2ILInjected.Token(Token = "0x40012D6")]
			private static global::System.Threading.ContextCallback s_invokeMoveNext;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000494")]
		private class ContinuationWrapper
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600227F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7571C", Offset = "0x1B7571C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void Invoke()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40012D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal readonly global::System.Action m_continuation;

			[global::Cpp2ILInjected.Token(Token = "0x40012D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly global::System.Action m_invokeAction;

			[global::Cpp2ILInjected.Token(Token = "0x40012D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal readonly global::System.Threading.Tasks.Task m_innerTask;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000495")]
		private sealed class <>c__DisplayClass5_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002280")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7513C", Offset = "0x1B7513C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass5_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40012DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public global::System.Threading.Tasks.Task innerTask;

			[global::Cpp2ILInjected.Token(Token = "0x40012DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public global::System.Action continuation;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000496")]
		[global::System.Serializable]
		private sealed class <>c
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6002283")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B757DC", Offset = "0x1B757DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002284")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B757E4", Offset = "0x1B757E4", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <ThrowAsync>b__7_0(object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002285")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75834", Offset = "0x1B75834", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <ThrowAsync>b__7_1(object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40012DC")]
			public static readonly AsyncMethodBuilderCore.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x40012DD")]
			public static global::System.Threading.SendOrPostCallback <>9__7_0;

			[global::Cpp2ILInjected.Token(Token = "0x40012DE")]
			public static global::System.Threading.WaitCallback <>9__7_1;
		}
	}
}
