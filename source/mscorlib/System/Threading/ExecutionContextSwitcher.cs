using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001EB")]
	internal struct ExecutionContextSwitcher
	{
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6001180")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A840", Offset = "0x1C9A840", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "SetExecutionContext", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(ExecutionContextSwitcher))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal bool UndoNoThrow()
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6001181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A8C8", Offset = "0x1C9A8C8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContextSwitcher), Member = "UndoNoThrow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new object[] { "TStateMachine" }, MemberParameters = new object[] { "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new object[] { "TStateMachine" }, MemberParameters = new object[] { "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), Member = "Start", MemberTypeParameters = new object[] { "TStateMachine" }, MemberParameters = new object[] { "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "OnAsyncLocalContextChanged", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ExecutionContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Undo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000976")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal ExecutionContext.Reader outerEC;

		[global::Cpp2ILInjected.Token(Token = "0x4000977")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal bool outerECBelongsToScope;

		[global::Cpp2ILInjected.Token(Token = "0x4000978")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal object hecsw;

		[global::Cpp2ILInjected.Token(Token = "0x4000979")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal Thread thread;
	}
}
