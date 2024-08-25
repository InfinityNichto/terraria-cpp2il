using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002B0")]
	internal class LinuxIPInterfaceProperties : UnixIPInterfaceProperties
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E52C", Offset = "0x1E1E52C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterface), Member = "GetIPProperties", ReturnType = typeof(IPInterfaceProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LinuxIPInterfaceProperties(LinuxNetworkInterface iface, List<IPAddress> addresses)
		{
			throw null;
		}
	}
}
