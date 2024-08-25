using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200027A")]
	internal class WebCompletionSource<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x600117A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18D9F18", Offset = "0x18D9F18", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpWebRequest),
			typeof(BufferOffsetSize),
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WebCompletionSource(bool runAsync = true)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003FD")]
		internal WebCompletionSource<T>.Result CurrentResult
		{
			[global::Cpp2ILInjected.Token(Token = "0x600117B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18D9F88", Offset = "0x18D9F88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003FE")]
		internal WebCompletionSource<T>.Status CurrentStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x600117C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18D9F90", Offset = "0x18D9F90", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003FF")]
		internal Task Task
		{
			[global::Cpp2ILInjected.Token(Token = "0x600117D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18D9FB0", Offset = "0x18D9FB0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600117E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18D9FC8", Offset = "0x18D9FC8", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool TrySetCompleted(T argument)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600117F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18DA07C", Offset = "0x18DA07C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool TrySetCompleted()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001180")]
		[global::Cpp2ILInjected.Address(RVA = "0x18DA11C", Offset = "0x18DA11C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OperationCanceledException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool TrySetCanceled()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001181")]
		[global::Cpp2ILInjected.Address(RVA = "0x18DA194", Offset = "0x18DA194", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool TrySetCanceled(OperationCanceledException error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001182")]
		[global::Cpp2ILInjected.Address(RVA = "0x18DA250", Offset = "0x18DA250", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool TrySetException(Exception error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001183")]
		[global::Cpp2ILInjected.Address(RVA = "0x18DA30C", Offset = "0x18DA30C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		public void ThrowOnError()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001184")]
		[global::Cpp2ILInjected.Address(RVA = "0x18DA3A0", Offset = "0x18DA3A0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<bool, object>>), Member = "Start", MemberTypeParameters = new object[] { typeof(WebCompletionSource<ValueTuple<bool, object>>.<WaitForCompletion>d__15) }, MemberParameters = new object[] { typeof(ref WebCompletionSource<ValueTuple<bool, object>>.<WaitForCompletion>d__15) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<bool, object>>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Task<T> WaitForCompletion()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TaskCompletionSource<WebCompletionSource<T>.Result> completion;

		[global::Cpp2ILInjected.Token(Token = "0x4000D87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private WebCompletionSource<T>.Result currentResult;

		[global::Cpp2ILInjected.Token(Token = "0x200027B")]
		internal enum Status
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000D89")]
			Running,
			[global::Cpp2ILInjected.Token(Token = "0x4000D8A")]
			Completed,
			[global::Cpp2ILInjected.Token(Token = "0x4000D8B")]
			Canceled,
			[global::Cpp2ILInjected.Token(Token = "0x4000D8C")]
			Faulted
		}

		[global::Cpp2ILInjected.Token(Token = "0x200027C")]
		internal class Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000400")]
			public WebCompletionSource<T>.Status Status
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6001185")]
				[global::Cpp2ILInjected.Address(RVA = "0x1862CC8", Offset = "0x1862CC8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000401")]
			public bool Success
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001186")]
				[global::Cpp2ILInjected.Address(RVA = "0x1862CD0", Offset = "0x1862CD0", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new object[]
				{
					"System.Net.ServicePointScheduler.ConnectionGroup",
					typeof(WebOperation)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000402")]
			public ExceptionDispatchInfo Error
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6001187")]
				[global::Cpp2ILInjected.Address(RVA = "0x1862CF8", Offset = "0x1862CF8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000403")]
			public T Argument
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6001188")]
				[global::Cpp2ILInjected.Address(RVA = "0x1862D00", Offset = "0x1862D00", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001189")]
			[global::Cpp2ILInjected.Address(RVA = "0x1862D0C", Offset = "0x1862D0C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Result(T argument)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600118A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1862D40", Offset = "0x1862D40", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Result(WebCompletionSource<T>.Status state, ExceptionDispatchInfo error)
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000D8D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly WebCompletionSource<T>.Status <Status>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000D8E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly ExceptionDispatchInfo <Error>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000D8F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly T <Argument>k__BackingField;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200027D")]
		[StructLayout(3)]
		private struct <WaitForCompletion>d__15 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x600118B")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C0548", Offset = "0x15C0548", Length = "0x3B4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<bool, object>>), Member = "SetResult", MemberParameters = new object[] { typeof(ValueTuple<bool, object>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<bool, object>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(WebCompletionSource<ValueTuple<bool, object>>.<WaitForCompletion>d__15)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref WebCompletionSource<ValueTuple<bool, object>>.<WaitForCompletion>d__15)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<bool, object>>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600118C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C08FC", Offset = "0x15C08FC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<bool, object>>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000D90")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000D91")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000D92")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public WebCompletionSource<T> <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000D93")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<WebCompletionSource<T>.Result>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
