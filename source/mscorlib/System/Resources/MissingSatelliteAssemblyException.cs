using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	[global::Cpp2ILInjected.Token(Token = "0x20004A7")]
	[global::System.Serializable]
	public class MissingSatelliteAssemblyException : global::System.SystemException
	{
		[global::Cpp2ILInjected.Token(Token = "0x60022C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75BC8", Offset = "0x1B75BC8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MissingSatelliteAssemblyException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75C24", Offset = "0x1B75C24", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "HandleSatelliteMissing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MissingSatelliteAssemblyException(string message, string cultureName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75C58", Offset = "0x1B75C58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected MissingSatelliteAssemblyException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string _cultureName;
	}
}
