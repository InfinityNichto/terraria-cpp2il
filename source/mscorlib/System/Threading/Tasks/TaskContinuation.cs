using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001C5 RID: 453
	[global::Cpp2ILInjected.Token(Token = "0x2000244")]
	internal abstract class TaskContinuation
	{
		// Token: 0x06001258 RID: 4696
		[global::Cpp2ILInjected.Token(Token = "0x6001405")]
		internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

		// Token: 0x06001259 RID: 4697 RVA: 0x00017888 File Offset: 0x00015A88
		[global::Cpp2ILInjected.Token(Token = "0x6001406")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CACA50", Offset = "0x1CACA50", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandardTaskContinuation), Member = "Run", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "TryRunInline", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskSchedulerException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
		{
			throw null;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0001788B File Offset: 0x00015A8B
		[global::Cpp2ILInjected.Token(Token = "0x6001407")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CACB74", Offset = "0x1CACB74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TaskContinuation()
		{
			throw null;
		}
	}
}
