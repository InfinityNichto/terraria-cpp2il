using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002AF")]
	internal static class IPGlobalPropertiesFactoryPal
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C864", Offset = "0x1E1C864", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPGlobalProperties), Member = "InternalGetIPGlobalProperties", ReturnType = typeof(IPGlobalProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnixIPGlobalPropertiesFactoryPal), Member = "Create", ReturnType = typeof(IPGlobalProperties))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IPGlobalProperties Create()
		{
			throw null;
		}
	}
}
