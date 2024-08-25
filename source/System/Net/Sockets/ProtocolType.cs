using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x20002FC")]
	public enum ProtocolType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400102D")]
		IP,
		[global::Cpp2ILInjected.Token(Token = "0x400102E")]
		IPv6HopByHopOptions = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400102F")]
		Icmp,
		[global::Cpp2ILInjected.Token(Token = "0x4001030")]
		Igmp,
		[global::Cpp2ILInjected.Token(Token = "0x4001031")]
		Ggp,
		[global::Cpp2ILInjected.Token(Token = "0x4001032")]
		IPv4,
		[global::Cpp2ILInjected.Token(Token = "0x4001033")]
		Tcp = 6,
		[global::Cpp2ILInjected.Token(Token = "0x4001034")]
		Pup = 12,
		[global::Cpp2ILInjected.Token(Token = "0x4001035")]
		Udp = 17,
		[global::Cpp2ILInjected.Token(Token = "0x4001036")]
		Idp = 22,
		[global::Cpp2ILInjected.Token(Token = "0x4001037")]
		IPv6 = 41,
		[global::Cpp2ILInjected.Token(Token = "0x4001038")]
		IPv6RoutingHeader = 43,
		[global::Cpp2ILInjected.Token(Token = "0x4001039")]
		IPv6FragmentHeader,
		[global::Cpp2ILInjected.Token(Token = "0x400103A")]
		IPSecEncapsulatingSecurityPayload = 50,
		[global::Cpp2ILInjected.Token(Token = "0x400103B")]
		IPSecAuthenticationHeader,
		[global::Cpp2ILInjected.Token(Token = "0x400103C")]
		IcmpV6 = 58,
		[global::Cpp2ILInjected.Token(Token = "0x400103D")]
		IPv6NoNextHeader,
		[global::Cpp2ILInjected.Token(Token = "0x400103E")]
		IPv6DestinationOptions,
		[global::Cpp2ILInjected.Token(Token = "0x400103F")]
		ND = 77,
		[global::Cpp2ILInjected.Token(Token = "0x4001040")]
		Raw = 255,
		[global::Cpp2ILInjected.Token(Token = "0x4001041")]
		Unspecified = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4001042")]
		Ipx = 1000,
		[global::Cpp2ILInjected.Token(Token = "0x4001043")]
		Spx = 1256,
		[global::Cpp2ILInjected.Token(Token = "0x4001044")]
		SpxII,
		[global::Cpp2ILInjected.Token(Token = "0x4001045")]
		Unknown = -1
	}
}
