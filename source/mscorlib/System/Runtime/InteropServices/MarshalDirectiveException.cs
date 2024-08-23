using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000386 RID: 902
	[global::Cpp2ILInjected.Token(Token = "0x2000430")]
	[global::System.Serializable]
	public class MarshalDirectiveException : global::System.SystemException
	{
		// Token: 0x06001F0D RID: 7949 RVA: 0x00019C2E File Offset: 0x00017E2E
		[global::Cpp2ILInjected.Token(Token = "0x600214E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FA18", Offset = "0x1B6FA18", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MarshalDirectiveException()
		{
			throw null;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00019C31 File Offset: 0x00017E31
		[global::Cpp2ILInjected.Token(Token = "0x600214F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FA74", Offset = "0x1B6FA74", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MarshalDirectiveException(string message)
		{
			throw null;
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00019C34 File Offset: 0x00017E34
		[global::Cpp2ILInjected.Token(Token = "0x6002150")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FA98", Offset = "0x1B6FA98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected MarshalDirectiveException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
