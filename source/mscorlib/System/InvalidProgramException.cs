using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000A3 RID: 163
	[global::Cpp2ILInjected.Token(Token = "0x20000D3")]
	[global::System.Serializable]
	public sealed class InvalidProgramException : global::System.SystemException
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x00015A43 File Offset: 0x00013C43
		[global::Cpp2ILInjected.Token(Token = "0x60007DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35404", Offset = "0x1C35404", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public InvalidProgramException()
		{
			throw null;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00015A46 File Offset: 0x00013C46
		[global::Cpp2ILInjected.Token(Token = "0x60007DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35460", Offset = "0x1C35460", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public InvalidProgramException(string message)
		{
			throw null;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00015A49 File Offset: 0x00013C49
		[global::Cpp2ILInjected.Token(Token = "0x60007DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35484", Offset = "0x1C35484", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		internal InvalidProgramException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
