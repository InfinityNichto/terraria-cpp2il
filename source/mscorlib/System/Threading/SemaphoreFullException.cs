using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200016D RID: 365
	[global::Cpp2ILInjected.Token(Token = "0x20001BF")]
	[global::System.Serializable]
	public class SemaphoreFullException : global::System.SystemException
	{
		// Token: 0x06000F8A RID: 3978 RVA: 0x000170FF File Offset: 0x000152FF
		[global::Cpp2ILInjected.Token(Token = "0x60010BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94088", Offset = "0x1C94088", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public SemaphoreFullException()
		{
			throw null;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00017102 File Offset: 0x00015302
		[global::Cpp2ILInjected.Token(Token = "0x60010BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C940D4", Offset = "0x1C940D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected SemaphoreFullException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
