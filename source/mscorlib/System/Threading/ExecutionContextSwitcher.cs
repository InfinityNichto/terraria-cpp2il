using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200018C RID: 396
	[global::Cpp2ILInjected.Token(Token = "0x20001EB")]
	internal struct ExecutionContextSwitcher
	{
		// Token: 0x06001037 RID: 4151 RVA: 0x000172F4 File Offset: 0x000154F4
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

		// Token: 0x06001038 RID: 4152 RVA: 0x000172F7 File Offset: 0x000154F7
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

		// Token: 0x0400075A RID: 1882
		[global::Cpp2ILInjected.Token(Token = "0x4000976")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal ExecutionContext.Reader outerEC;

		// Token: 0x0400075B RID: 1883
		[global::Cpp2ILInjected.Token(Token = "0x4000977")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal bool outerECBelongsToScope;

		// Token: 0x0400075C RID: 1884
		[global::Cpp2ILInjected.Token(Token = "0x4000978")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal object hecsw;

		// Token: 0x0400075D RID: 1885
		[global::Cpp2ILInjected.Token(Token = "0x4000979")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal Thread thread;
	}
}
