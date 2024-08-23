using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime
{
	// Token: 0x02000297 RID: 663
	[global::Cpp2ILInjected.Token(Token = "0x2000335")]
	[global::System.Serializable]
	public sealed class AmbiguousImplementationException : global::System.Exception
	{
		// Token: 0x06001984 RID: 6532 RVA: 0x00018CBC File Offset: 0x00016EBC
		[global::Cpp2ILInjected.Token(Token = "0x6001BA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24808", Offset = "0x1B24808", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public AmbiguousImplementationException()
		{
			throw null;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00018CBF File Offset: 0x00016EBF
		[global::Cpp2ILInjected.Token(Token = "0x6001BA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24888", Offset = "0x1B24888", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AmbiguousImplementationException(string message)
		{
			throw null;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00018CC2 File Offset: 0x00016EC2
		[global::Cpp2ILInjected.Token(Token = "0x6001BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24900", Offset = "0x1B24900", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private AmbiguousImplementationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
