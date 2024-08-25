using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200012F")]
	[global::System.Serializable]
	public class CannotUnloadAppDomainException : global::System.SystemException
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56224", Offset = "0x1C56224", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CannotUnloadAppDomainException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5627C", Offset = "0x1C5627C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public CannotUnloadAppDomainException(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5629C", Offset = "0x1C5629C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected CannotUnloadAppDomainException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
