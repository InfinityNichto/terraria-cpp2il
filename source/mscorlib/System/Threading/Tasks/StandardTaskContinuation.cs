using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001C6 RID: 454
	[global::Cpp2ILInjected.Token(Token = "0x2000245")]
	internal class StandardTaskContinuation : TaskContinuation
	{
		// Token: 0x0600125B RID: 4699 RVA: 0x0001788E File Offset: 0x00015A8E
		[global::Cpp2ILInjected.Token(Token = "0x6001408")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAAB70", Offset = "0x1CAAB70", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(TaskScheduler),
			typeof(CancellationToken),
			typeof(TaskContinuationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00017891 File Offset: 0x00015A91
		[global::Cpp2ILInjected.Token(Token = "0x6001409")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CACB7C", Offset = "0x1CACB7C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal override void Run(Task completedTask, bool bCanInlineContinuationTask)
		{
			throw null;
		}

		// Token: 0x04000840 RID: 2112
		[global::Cpp2ILInjected.Token(Token = "0x4000AA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal readonly Task m_task;

		// Token: 0x04000841 RID: 2113
		[global::Cpp2ILInjected.Token(Token = "0x4000AA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal readonly TaskContinuationOptions m_options;

		// Token: 0x04000842 RID: 2114
		[global::Cpp2ILInjected.Token(Token = "0x4000AA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly TaskScheduler m_taskScheduler;
	}
}
