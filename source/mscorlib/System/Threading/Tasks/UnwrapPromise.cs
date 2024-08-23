using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x020001C1 RID: 449
	[global::Cpp2ILInjected.Token(Token = "0x200023F")]
	internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction
	{
		// Token: 0x0600124A RID: 4682 RVA: 0x0001785E File Offset: 0x00015A5E
		[global::Cpp2ILInjected.Token(Token = "0x60013F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1898170", Offset = "0x1898170", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_CreationOptions", ReturnType = typeof(TaskCreationOptions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "get_LoggingOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "TraceOperationCreation", MemberParameters = new object[]
		{
			typeof(CausalityTraceLevel),
			typeof(Task),
			typeof(string),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new object[] { typeof(ITaskCompletionAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public UnwrapPromise(Task outerTask, bool lookForOce)
		{
			throw null;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00017861 File Offset: 0x00015A61
		[global::Cpp2ILInjected.Token(Token = "0x60013F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1898320", Offset = "0x1898320", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_CurrentStackGuard", ReturnType = typeof(StackGuard))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackGuard), Member = "TryBeginInliningScope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackGuard), Member = "EndInliningScope", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Invoke(Task completingTask)
		{
			throw null;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00017864 File Offset: 0x00015A64
		[global::Cpp2ILInjected.Token(Token = "0x60013F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1898454", Offset = "0x1898454", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void InvokeCore(Task completingTask)
		{
			throw null;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00017867 File Offset: 0x00015A67
		[global::Cpp2ILInjected.Token(Token = "0x60013F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x18984B4", Offset = "0x18984B4", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void InvokeCoreAsync(Task completingTask)
		{
			throw null;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0001786A File Offset: 0x00015A6A
		[global::Cpp2ILInjected.Token(Token = "0x60013F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1898614", Offset = "0x1898614", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Result", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ProcessCompletedOuterTask(Task task)
		{
			throw null;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0001786D File Offset: 0x00015A6D
		[global::Cpp2ILInjected.Token(Token = "0x60013F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x189878C", Offset = "0x189878C", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "get_LoggingOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "TraceOperationRelation", MemberParameters = new object[]
		{
			typeof(CausalityTraceLevel),
			typeof(Task),
			typeof(CausalityRelation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_CancellationToken", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "GetCancellationExceptionDispatchInfo", ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "GetExceptionDispatchInfos", ReturnType = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "TraceOperationCompletion", MemberParameters = new object[]
		{
			typeof(CausalityTraceLevel),
			typeof(Task),
			typeof(Internal.Runtime.Augments.AsyncStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private bool TrySetFromTask(Task task, bool lookForOce)
		{
			throw null;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00017870 File Offset: 0x00015A70
		[global::Cpp2ILInjected.Token(Token = "0x60013FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1898AC8", Offset = "0x1898AC8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new object[] { typeof(ITaskCompletionAction) }, ReturnType = typeof(void))]
		private void ProcessInnerTask(Task task)
		{
			throw null;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00017873 File Offset: 0x00015A73
		[global::Cpp2ILInjected.Token(Token = "0x170001F4")]
		public bool InvokeMayRunArbitraryCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1898B4C", Offset = "0x1898B4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400083B RID: 2107
		[global::Cpp2ILInjected.Token(Token = "0x4000AA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private byte _state;

		// Token: 0x0400083C RID: 2108
		[global::Cpp2ILInjected.Token(Token = "0x4000AA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly bool _lookForOce;

		// Token: 0x020005C9 RID: 1481
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000240")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06004081 RID: 16513 RVA: 0x0001FC34 File Offset: 0x0001DE34
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60013FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B042C", Offset = "0x15B042C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004082 RID: 16514 RVA: 0x0001FC37 File Offset: 0x0001DE37
			[global::Cpp2ILInjected.Token(Token = "0x60013FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0518", Offset = "0x15B0518", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004083 RID: 16515 RVA: 0x0001FC3A File Offset: 0x0001DE3A
			[global::Cpp2ILInjected.Token(Token = "0x60013FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0520", Offset = "0x15B0520", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <InvokeCoreAsync>b__8_0(object state)
			{
				throw null;
			}

			// Token: 0x040018ED RID: 6381
			[global::Cpp2ILInjected.Token(Token = "0x4000AA2")]
			public static readonly UnwrapPromise<TResult>.<>c <>9;

			// Token: 0x040018EE RID: 6382
			[global::Cpp2ILInjected.Token(Token = "0x4000AA3")]
			public static WaitCallback <>9__8_0;
		}
	}
}
