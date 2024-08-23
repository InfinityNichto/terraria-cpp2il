using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001C2 RID: 450
	[global::Cpp2ILInjected.Token(Token = "0x2000241")]
	internal sealed class ContinuationTaskFromTask : Task
	{
		// Token: 0x06001252 RID: 4690 RVA: 0x00017876 File Offset: 0x00015A76
		[global::Cpp2ILInjected.Token(Token = "0x60013FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAA840", Offset = "0x1CAA840", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[]
		{
			typeof(global::System.Action<Task>),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[]
		{
			typeof(global::System.Action<Task, object>),
			typeof(object),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		public ContinuationTaskFromTask(Task antecedent, global::System.Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
			throw null;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00017879 File Offset: 0x00015A79
		[global::Cpp2ILInjected.Token(Token = "0x6001400")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC988", Offset = "0x1CAC988", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override void InnerInvoke()
		{
			throw null;
		}

		// Token: 0x0400083D RID: 2109
		[global::Cpp2ILInjected.Token(Token = "0x4000AA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Task m_antecedent;
	}
}
