using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001D9 RID: 473
	[global::Cpp2ILInjected.Token(Token = "0x20002BB")]
	internal class MacOsIPInterfaceProperties : UnixIPInterfaceProperties
	{
		// Token: 0x060010BC RID: 4284 RVA: 0x00005E37 File Offset: 0x00004037
		[global::Cpp2ILInjected.Token(Token = "0x60012B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1F7BC", Offset = "0x1E1F7BC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MacOsNetworkInterface), Member = "GetIPProperties", ReturnType = typeof(IPInterfaceProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MacOsIPInterfaceProperties(MacOsNetworkInterface iface, List<IPAddress> addresses)
		{
			throw null;
		}
	}
}
