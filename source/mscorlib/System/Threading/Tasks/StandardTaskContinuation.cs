using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	[global::Cpp2ILInjected.Token(Token = "0x2000245")]
	internal class StandardTaskContinuation : TaskContinuation
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000AA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal readonly Task m_task;

		[global::Cpp2ILInjected.Token(Token = "0x4000AA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal readonly TaskContinuationOptions m_options;

		[global::Cpp2ILInjected.Token(Token = "0x4000AA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly TaskScheduler m_taskScheduler;
	}
}
