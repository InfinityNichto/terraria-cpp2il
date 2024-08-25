using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Cache
{
	[global::Cpp2ILInjected.Token(Token = "0x20002E9")]
	internal class RequestCacheProtocol
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001300")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E21860", Offset = "0x1E21860", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "InternalSetCachePolicy", MemberParameters = new object[] { typeof(RequestCachePolicy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public RequestCacheProtocol(object arg1, object arg2)
		{
			throw null;
		}
	}
}
