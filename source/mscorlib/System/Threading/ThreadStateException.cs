using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000173 RID: 371
	[global::Cpp2ILInjected.Token(Token = "0x20001C5")]
	[global::System.Serializable]
	public class ThreadStateException : global::System.SystemException
	{
		// Token: 0x06000F93 RID: 3987 RVA: 0x0001710E File Offset: 0x0001530E
		[global::Cpp2ILInjected.Token(Token = "0x60010C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94374", Offset = "0x1C94374", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ThreadStateException()
		{
			throw null;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00017111 File Offset: 0x00015311
		[global::Cpp2ILInjected.Token(Token = "0x60010C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C943D0", Offset = "0x1C943D0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "TrySetApartmentState", MemberParameters = new object[] { typeof(ApartmentState) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "ValidateThreadState", ReturnType = typeof(ThreadState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public ThreadStateException(string message)
		{
			throw null;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00017114 File Offset: 0x00015314
		[global::Cpp2ILInjected.Token(Token = "0x60010C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C943F4", Offset = "0x1C943F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected ThreadStateException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
