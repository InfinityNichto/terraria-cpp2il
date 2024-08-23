using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001B9 RID: 441
	[global::Cpp2ILInjected.Token(Token = "0x2000237")]
	internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
	{
		// Token: 0x06001242 RID: 4674 RVA: 0x0001784C File Offset: 0x00015A4C
		[global::Cpp2ILInjected.Token(Token = "0x60013EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA438", Offset = "0x1CAA438", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
		{
			throw null;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0001784F File Offset: 0x00015A4F
		[global::Cpp2ILInjected.Token(Token = "0x60013ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC894", Offset = "0x1CAC894", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		{
			throw null;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00017852 File Offset: 0x00015A52
		[global::Cpp2ILInjected.Token(Token = "0x60013EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC930", Offset = "0x1CAC930", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void MarkAborted(ThreadAbortException e)
		{
			throw null;
		}

		// Token: 0x04000818 RID: 2072
		[global::Cpp2ILInjected.Token(Token = "0x4000A7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ITaskCompletionAction m_action;

		// Token: 0x04000819 RID: 2073
		[global::Cpp2ILInjected.Token(Token = "0x4000A7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Task m_completingTask;
	}
}
