using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Metadata
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Parameter)]
	[global::Cpp2ILInjected.Token(Token = "0x2000390")]
	public sealed class SoapParameterAttribute : SoapAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4319C", Offset = "0x1B4319C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(SoapAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SoapParameterAttribute()
		{
			throw null;
		}
	}
}
