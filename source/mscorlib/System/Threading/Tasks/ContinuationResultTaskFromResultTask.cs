using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001C4 RID: 452
	[global::Cpp2ILInjected.Token(Token = "0x2000243")]
	internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult>
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x00017882 File Offset: 0x00015A82
		[global::Cpp2ILInjected.Token(Token = "0x6001403")]
		[global::Cpp2ILInjected.Address(RVA = "0x19219DC", Offset = "0x19219DC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new object[] { typeof(TaskCreationOptions) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ContinuationResultTaskFromResultTask(Task<TAntecedentResult> antecedent, global::System.Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
			throw null;
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00017885 File Offset: 0x00015A85
		[global::Cpp2ILInjected.Token(Token = "0x6001404")]
		[global::Cpp2ILInjected.Address(RVA = "0x1921AAC", Offset = "0x1921AAC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override void InnerInvoke()
		{
			throw null;
		}

		// Token: 0x0400083F RID: 2111
		[global::Cpp2ILInjected.Token(Token = "0x4000AA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Task<TAntecedentResult> m_antecedent;
	}
}
