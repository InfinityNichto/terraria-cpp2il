using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001D3 RID: 467
	[global::System.Runtime.CompilerServices.FriendAccessAllowed]
	[global::Cpp2ILInjected.Token(Token = "0x2000257")]
	internal static class AsyncCausalityTracer
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x00017954 File Offset: 0x00015B54
		[global::System.Runtime.CompilerServices.FriendAccessAllowed]
		[global::Cpp2ILInjected.Token(Token = "0x170001FE")]
		internal static bool LoggingOn
		{
			[global::System.Runtime.CompilerServices.FriendAccessAllowed]
			[global::Cpp2ILInjected.Token(Token = "0x6001458")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAC290", Offset = "0x1CAC290", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), Member = "SetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine),
				typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore.MoveNextRunner),
				typeof(Task)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00017957 File Offset: 0x00015B57
		[global::System.Runtime.CompilerServices.FriendAccessAllowed]
		[global::Cpp2ILInjected.Token(Token = "0x6001459")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF2BC", Offset = "0x1CAF2BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine),
			typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore.MoveNextRunner),
			typeof(Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[MethodImpl(8)]
		internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
		{
			throw null;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0001795A File Offset: 0x00015B5A
		[global::System.Runtime.CompilerServices.FriendAccessAllowed]
		[global::Cpp2ILInjected.Token(Token = "0x600145A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF2C0", Offset = "0x1CAF2C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), Member = "SetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[MethodImpl(8)]
		internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
		{
			throw null;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0001795D File Offset: 0x00015B5D
		[global::Cpp2ILInjected.Token(Token = "0x600145B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAF2C4", Offset = "0x1CAF2C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.AsyncMethodBuilderCore.<>c__DisplayClass5_0", Member = "<OutputAsyncCausalityEvents>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[MethodImpl(8)]
		internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
		{
			throw null;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00017960 File Offset: 0x00015B60
		[global::Cpp2ILInjected.Token(Token = "0x600145C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC298", Offset = "0x1CAC298", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.AsyncMethodBuilderCore.<>c__DisplayClass5_0", Member = "<OutputAsyncCausalityEvents>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[MethodImpl(8)]
		internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
			throw null;
		}
	}
}
