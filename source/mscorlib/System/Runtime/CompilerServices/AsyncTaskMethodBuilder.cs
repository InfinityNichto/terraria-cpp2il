using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003DB RID: 987
	[global::Cpp2ILInjected.Token(Token = "0x200048F")]
	public struct AsyncTaskMethodBuilder
	{
		// Token: 0x06001FFA RID: 8186 RVA: 0x00019E8F File Offset: 0x0001808F
		[global::Cpp2ILInjected.Token(Token = "0x600225F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74B24", Offset = "0x1B74B24", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		public static AsyncTaskMethodBuilder Create()
		{
			throw null;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00019E92 File Offset: 0x00018092
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::Cpp2ILInjected.Token(Token = "0x6002260")]
		[global::Cpp2ILInjected.Address(RVA = "0x15725D8", Offset = "0x15725D8", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "EstablishCopyOnWriteScope", MemberParameters = new object[] { typeof(ref global::System.Threading.ExecutionContextSwitcher) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			throw null;
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00019E95 File Offset: 0x00018095
		[global::Cpp2ILInjected.Token(Token = "0x6002261")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74B30", Offset = "0x1B74B30", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<global::System.Threading.Tasks.VoidTaskResult>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00019E98 File Offset: 0x00018098
		[global::Cpp2ILInjected.Token(Token = "0x6002262")]
		[global::Cpp2ILInjected.Address(RVA = "0x157247C", Offset = "0x157247C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<global::System.Threading.Tasks.VoidTaskResult>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
		{
			typeof(ConfiguredTaskAwaitable<int?>.ConfiguredTaskAwaiter),
			"Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24"
		}, MemberParameters = new object[]
		{
			typeof(ref ConfiguredTaskAwaitable<int?>.ConfiguredTaskAwaiter),
			typeof(ref AsyncProtocolRequest.<ProcessOperation>d__24)
		}, ReturnType = typeof(void))]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			throw null;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x00019E9B File Offset: 0x0001809B
		[global::Cpp2ILInjected.Token(Token = "0x17000478")]
		public global::System.Threading.Tasks.Task Task
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002263")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B74B88", Offset = "0x1B74B88", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<global::System.Threading.Tasks.VoidTaskResult>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00019E9E File Offset: 0x0001809E
		[global::Cpp2ILInjected.Token(Token = "0x6002264")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74BD0", Offset = "0x1B74BD0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<global::System.Threading.Tasks.VoidTaskResult>), Member = "SetResult", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task<global::System.Threading.Tasks.VoidTaskResult>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetResult()
		{
			throw null;
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00019EA1 File Offset: 0x000180A1
		[global::Cpp2ILInjected.Token(Token = "0x6002265")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74C48", Offset = "0x1B74C48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<global::System.Threading.Tasks.VoidTaskResult>), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetException(global::System.Exception exception)
		{
			throw null;
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00019EA4 File Offset: 0x000180A4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002266")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74CA0", Offset = "0x1B74CA0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static AsyncTaskMethodBuilder()
		{
			throw null;
		}

		// Token: 0x04000FC8 RID: 4040
		[global::Cpp2ILInjected.Token(Token = "0x40012CA")]
		private static readonly global::System.Threading.Tasks.Task<global::System.Threading.Tasks.VoidTaskResult> s_cachedCompleted;

		// Token: 0x04000FC9 RID: 4041
		[global::Cpp2ILInjected.Token(Token = "0x40012CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private AsyncTaskMethodBuilder<global::System.Threading.Tasks.VoidTaskResult> m_builder;
	}
}
