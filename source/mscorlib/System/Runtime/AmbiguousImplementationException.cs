using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime
{
	[global::Cpp2ILInjected.Token(Token = "0x2000335")]
	[global::System.Serializable]
	public sealed class AmbiguousImplementationException : global::System.Exception
	{
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
