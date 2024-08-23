using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001A9 RID: 425
	[global::Cpp2ILInjected.Token(Token = "0x2000217")]
	[global::System.Serializable]
	public class TaskCanceledException : global::System.OperationCanceledException
	{
		// Token: 0x06001156 RID: 4438 RVA: 0x00017588 File Offset: 0x00015788
		[global::Cpp2ILInjected.Token(Token = "0x60012D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA354C", Offset = "0x1CA354C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OperationCanceledException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TaskCanceledException()
		{
			throw null;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0001758B File Offset: 0x0001578B
		[global::Cpp2ILInjected.Token(Token = "0x60012D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3598", Offset = "0x1CA3598", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OperationCanceledException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TaskCanceledException(Task task)
		{
			throw null;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0001758E File Offset: 0x0001578E
		[global::Cpp2ILInjected.Token(Token = "0x60012D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA363C", Offset = "0x1CA363C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OperationCanceledException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected TaskCanceledException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x040007DF RID: 2015
		[global::Cpp2ILInjected.Token(Token = "0x4000A1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		[global::System.NonSerialized]
		private readonly Task _canceledTask;
	}
}
