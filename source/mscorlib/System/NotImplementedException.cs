using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000B0 RID: 176
	[global::Cpp2ILInjected.Token(Token = "0x20000E0")]
	[global::System.Serializable]
	public class NotImplementedException : global::System.SystemException
	{
		// Token: 0x0600079E RID: 1950 RVA: 0x00015B51 File Offset: 0x00013D51
		[global::Cpp2ILInjected.Token(Token = "0x6000843")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37634", Offset = "0x1C37634", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 146)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NotImplementedException()
		{
			throw null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00015B54 File Offset: 0x00013D54
		[global::Cpp2ILInjected.Token(Token = "0x6000844")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37690", Offset = "0x1C37690", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public NotImplementedException(string message)
		{
			throw null;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00015B57 File Offset: 0x00013D57
		[global::Cpp2ILInjected.Token(Token = "0x6000845")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C376B4", Offset = "0x1C376B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected NotImplementedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
