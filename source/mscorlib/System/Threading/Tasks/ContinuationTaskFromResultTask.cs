using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	[global::Cpp2ILInjected.Token(Token = "0x2000242")]
	internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001401")]
		[global::Cpp2ILInjected.Address(RVA = "0x1921EC8", Offset = "0x1921EC8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new object[] { typeof(TaskCreationOptions) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(object),
			typeof(Task),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(InternalTaskOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ContinuationTaskFromResultTask(Task<TAntecedentResult> antecedent, global::System.Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001402")]
		[global::Cpp2ILInjected.Address(RVA = "0x1921F84", Offset = "0x1921F84", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override void InnerInvoke()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Task<TAntecedentResult> m_antecedent;
	}
}
