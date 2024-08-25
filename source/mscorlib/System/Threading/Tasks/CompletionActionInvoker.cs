using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	[global::Cpp2ILInjected.Token(Token = "0x2000237")]
	internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x60013EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA438", Offset = "0x1CAA438", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC894", Offset = "0x1CAC894", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC930", Offset = "0x1CAC930", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void MarkAborted(ThreadAbortException e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000A7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ITaskCompletionAction m_action;

		[global::Cpp2ILInjected.Token(Token = "0x4000A7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Task m_completingTask;
	}
}
