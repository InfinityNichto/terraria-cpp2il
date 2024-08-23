using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001CE RID: 462
	[global::Cpp2ILInjected.Token(Token = "0x20002B0")]
	internal class LinuxIPInterfaceProperties : UnixIPInterfaceProperties
	{
		// Token: 0x060010B0 RID: 4272 RVA: 0x00005E13 File Offset: 0x00004013
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
