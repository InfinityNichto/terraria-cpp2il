using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001AB RID: 427
	[global::Cpp2ILInjected.Token(Token = "0x2000219")]
	[global::System.Serializable]
	public class TaskSchedulerException : global::System.Exception
	{
		// Token: 0x06001163 RID: 4451 RVA: 0x000175AF File Offset: 0x000157AF
		[global::Cpp2ILInjected.Token(Token = "0x60012DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3644", Offset = "0x1CA3644", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public TaskSchedulerException()
		{
			throw null;
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000175B2 File Offset: 0x000157B2
		[global::Cpp2ILInjected.Token(Token = "0x60012DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA36B4", Offset = "0x1CA36B4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "WrappedTryRunInline", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public TaskSchedulerException(global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x000175B5 File Offset: 0x000157B5
		[global::Cpp2ILInjected.Token(Token = "0x60012DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3734", Offset = "0x1CA3734", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected TaskSchedulerException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
