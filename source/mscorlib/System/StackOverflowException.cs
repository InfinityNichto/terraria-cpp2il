using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000CA RID: 202
	[global::Cpp2ILInjected.Token(Token = "0x20000FC")]
	[global::System.Serializable]
	public sealed class StackOverflowException : global::System.SystemException
	{
		// Token: 0x060008D2 RID: 2258 RVA: 0x00015EE7 File Offset: 0x000140E7
		[global::Cpp2ILInjected.Token(Token = "0x600097A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A3FC", Offset = "0x1C4A3FC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public StackOverflowException()
		{
			throw null;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00015EEA File Offset: 0x000140EA
		[global::Cpp2ILInjected.Token(Token = "0x600097B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A454", Offset = "0x1C4A454", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public StackOverflowException(string message)
		{
			throw null;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00015EED File Offset: 0x000140ED
		[global::Cpp2ILInjected.Token(Token = "0x600097C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A474", Offset = "0x1C4A474", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		internal StackOverflowException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
