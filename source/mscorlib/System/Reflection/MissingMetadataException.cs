using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004FA")]
	public sealed class MissingMetadataException : global::System.TypeAccessException
	{
		[global::Cpp2ILInjected.Token(Token = "0x60024F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87FA0", Offset = "0x1B87FA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Runtime.Augments.ReflectionExecutionDomainCallbacks), Member = "CreateMissingMetadataException", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeAccessException), Member = ".ctor", ReturnType = typeof(void))]
		public MissingMetadataException()
		{
			throw null;
		}
	}
}
