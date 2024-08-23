using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003B8 RID: 952
	[global::Cpp2ILInjected.Token(Token = "0x2000465")]
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder<TResult>
	{
		// Token: 0x06001FAA RID: 8106 RVA: 0x00019DAE File Offset: 0x00017FAE
		[global::Cpp2ILInjected.Token(Token = "0x60021F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E57F4", Offset = "0x18E57F4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "<ReadAsync>g__FinishReadAsync|44_0", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task<int>),
			typeof(byte[]),
			typeof(global::System.Memory<byte>)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static AsyncValueTaskMethodBuilder<TResult> Create()
		{
			throw null;
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00019DB1 File Offset: 0x00017FB1
		[global::Cpp2ILInjected.Token(Token = "0x60021F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C2758", Offset = "0x14C2758", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { "System.IO.Stream.<<ReadAsync>g__FinishReadAsync|44_0>d" }, MemberParameters = new object[] { typeof(ref global::System.IO.Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique) }, ReturnType = typeof(void))]
		[MethodImpl(256)]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			throw null;
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00019DB4 File Offset: 0x00017FB4
		[global::Cpp2ILInjected.Token(Token = "0x60021F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E5800", Offset = "0x18E5800", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x00019DB7 File Offset: 0x00017FB7
		[global::Cpp2ILInjected.Token(Token = "0x60021F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E5844", Offset = "0x18E5844", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetResult(TResult result)
		{
			throw null;
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x00019DBA File Offset: 0x00017FBA
		[global::Cpp2ILInjected.Token(Token = "0x60021F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E58A0", Offset = "0x18E58A0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetException(global::System.Exception exception)
		{
			throw null;
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x00019DBD File Offset: 0x00017FBD
		[global::Cpp2ILInjected.Token(Token = "0x17000462")]
		public global::System.Threading.Tasks.ValueTask<TResult> Task
		{
			[global::Cpp2ILInjected.Token(Token = "0x60021F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E58E4", Offset = "0x18E58E4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "<ReadAsync>g__FinishReadAsync|44_0", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task<int>),
				typeof(byte[]),
				typeof(global::System.Memory<byte>)
			}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00019DC0 File Offset: 0x00017FC0
		[global::Cpp2ILInjected.Token(Token = "0x60021F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C2744", Offset = "0x14C2744", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
		{
			typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
			"System.IO.Stream.<<ReadAsync>g__FinishReadAsync|44_0>d"
		}, MemberParameters = new object[]
		{
			typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
			typeof(ref global::System.IO.Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique)
		}, ReturnType = typeof(void))]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			throw null;
		}

		// Token: 0x04000FAF RID: 4015
		[global::Cpp2ILInjected.Token(Token = "0x40012A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private AsyncTaskMethodBuilder<TResult> _methodBuilder;

		// Token: 0x04000FB0 RID: 4016
		[global::Cpp2ILInjected.Token(Token = "0x40012A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TResult _result;

		// Token: 0x04000FB1 RID: 4017
		[global::Cpp2ILInjected.Token(Token = "0x40012A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _haveResult;

		// Token: 0x04000FB2 RID: 4018
		[global::Cpp2ILInjected.Token(Token = "0x40012A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _useBuilder;
	}
}
