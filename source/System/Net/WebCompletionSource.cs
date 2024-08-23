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
	// Token: 0x020001B2 RID: 434
	[global::Cpp2ILInjected.Token(Token = "0x200027A")]
	internal class WebCompletionSource<T>
	{
		// Token: 0x06000FB9 RID: 4025 RVA: 0x00005B52 File Offset: 0x00003D52
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

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00005B55 File Offset: 0x00003D55
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

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00005B58 File Offset: 0x00003D58
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

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00005B5B File Offset: 0x00003D5B
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

		// Token: 0x06000FBD RID: 4029 RVA: 0x00005B5E File Offset: 0x00003D5E
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

		// Token: 0x06000FBE RID: 4030 RVA: 0x00005B61 File Offset: 0x00003D61
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

		// Token: 0x06000FBF RID: 4031 RVA: 0x00005B64 File Offset: 0x00003D64
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

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00005B67 File Offset: 0x00003D67
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

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00005B6A File Offset: 0x00003D6A
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

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00005B6D File Offset: 0x00003D6D
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

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00005B70 File Offset: 0x00003D70
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

		// Token: 0x04000A68 RID: 2664
		[global::Cpp2ILInjected.Token(Token = "0x4000D86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TaskCompletionSource<WebCompletionSource<T>.Result> completion;

		// Token: 0x04000A69 RID: 2665
		[global::Cpp2ILInjected.Token(Token = "0x4000D87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private WebCompletionSource<T>.Result currentResult;

		// Token: 0x0200042B RID: 1067
		[global::Cpp2ILInjected.Token(Token = "0x200027B")]
		internal enum Status
		{
			// Token: 0x040012A6 RID: 4774
			[global::Cpp2ILInjected.Token(Token = "0x4000D89")]
			Running,
			// Token: 0x040012A7 RID: 4775
			[global::Cpp2ILInjected.Token(Token = "0x4000D8A")]
			Completed,
			// Token: 0x040012A8 RID: 4776
			[global::Cpp2ILInjected.Token(Token = "0x4000D8B")]
			Canceled,
			// Token: 0x040012A9 RID: 4777
			[global::Cpp2ILInjected.Token(Token = "0x4000D8C")]
			Faulted
		}

		// Token: 0x0200042C RID: 1068
		[global::Cpp2ILInjected.Token(Token = "0x200027C")]
		internal class Result
		{
			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00008396 File Offset: 0x00006596
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

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00008399 File Offset: 0x00006599
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

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x06001E5F RID: 7775 RVA: 0x0000839C File Offset: 0x0000659C
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

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0000839F File Offset: 0x0000659F
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

			// Token: 0x06001E61 RID: 7777 RVA: 0x000083A2 File Offset: 0x000065A2
			[global::Cpp2ILInjected.Token(Token = "0x6001189")]
			[global::Cpp2ILInjected.Address(RVA = "0x1862D0C", Offset = "0x1862D0C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Result(T argument)
			{
				throw null;
			}

			// Token: 0x06001E62 RID: 7778 RVA: 0x000083A5 File Offset: 0x000065A5
			[global::Cpp2ILInjected.Token(Token = "0x600118A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1862D40", Offset = "0x1862D40", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Result(WebCompletionSource<T>.Status state, ExceptionDispatchInfo error)
			{
				throw null;
			}

			// Token: 0x040012AA RID: 4778
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000D8D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly WebCompletionSource<T>.Status <Status>k__BackingField;

			// Token: 0x040012AB RID: 4779
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000D8E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly ExceptionDispatchInfo <Error>k__BackingField;

			// Token: 0x040012AC RID: 4780
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000D8F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly T <Argument>k__BackingField;
		}

		// Token: 0x0200042D RID: 1069
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200027D")]
		[StructLayout(3)]
		private struct <WaitForCompletion>d__15 : IAsyncStateMachine
		{
			// Token: 0x06001E63 RID: 7779 RVA: 0x000083A8 File Offset: 0x000065A8
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

			// Token: 0x06001E64 RID: 7780 RVA: 0x000083AB File Offset: 0x000065AB
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

			// Token: 0x040012AD RID: 4781
			[global::Cpp2ILInjected.Token(Token = "0x4000D90")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040012AE RID: 4782
			[global::Cpp2ILInjected.Token(Token = "0x4000D91")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			// Token: 0x040012AF RID: 4783
			[global::Cpp2ILInjected.Token(Token = "0x4000D92")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public WebCompletionSource<T> <>4__this;

			// Token: 0x040012B0 RID: 4784
			[global::Cpp2ILInjected.Token(Token = "0x4000D93")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<WebCompletionSource<T>.Result>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
