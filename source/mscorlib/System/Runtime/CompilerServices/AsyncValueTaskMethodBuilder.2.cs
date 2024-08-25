using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000465")]
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder<TResult>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40012A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private AsyncTaskMethodBuilder<TResult> _methodBuilder;

		[global::Cpp2ILInjected.Token(Token = "0x40012A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TResult _result;

		[global::Cpp2ILInjected.Token(Token = "0x40012A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _haveResult;

		[global::Cpp2ILInjected.Token(Token = "0x40012A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _useBuilder;
	}
}
