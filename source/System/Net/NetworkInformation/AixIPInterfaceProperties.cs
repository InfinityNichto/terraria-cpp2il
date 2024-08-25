using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002A8")]
	internal class AixIPInterfaceProperties : UnixIPInterfaceProperties
	{
		[global::Cpp2ILInjected.Token(Token = "0x600129A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CE9C", Offset = "0x1E1CE9C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AixNetworkInterface), Member = "GetIPProperties", ReturnType = typeof(IPInterfaceProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AixIPInterfaceProperties(AixNetworkInterface iface, List<IPAddress> addresses, int mtu)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000EBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _mtu;
	}
}
