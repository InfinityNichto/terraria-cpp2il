﻿using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200007F RID: 127
	[global::System.Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
	[global::Cpp2ILInjected.Token(Token = "0x20000A6")]
	[global::System.Serializable]
	public sealed class ExecutionEngineException : global::System.SystemException
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x000156A7 File Offset: 0x000138A7
		[global::Cpp2ILInjected.Token(Token = "0x6000678")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1EEF0", Offset = "0x1C1EEF0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ExecutionEngineException()
		{
			throw null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000156AA File Offset: 0x000138AA
		[global::Cpp2ILInjected.Token(Token = "0x6000679")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1EF4C", Offset = "0x1C1EF4C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public ExecutionEngineException(string message)
		{
			throw null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000156AD File Offset: 0x000138AD
		[global::Cpp2ILInjected.Token(Token = "0x600067A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1EF70", Offset = "0x1C1EF70", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		internal ExecutionEngineException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}