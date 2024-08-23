using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	// Token: 0x0200020D RID: 525
	[global::Cpp2ILInjected.Token(Token = "0x20002FC")]
	public enum ProtocolType
	{
		// Token: 0x04000C34 RID: 3124
		[global::Cpp2ILInjected.Token(Token = "0x400102D")]
		IP,
		// Token: 0x04000C35 RID: 3125
		[global::Cpp2ILInjected.Token(Token = "0x400102E")]
		IPv6HopByHopOptions = 0,
		// Token: 0x04000C36 RID: 3126
		[global::Cpp2ILInjected.Token(Token = "0x400102F")]
		Icmp,
		// Token: 0x04000C37 RID: 3127
		[global::Cpp2ILInjected.Token(Token = "0x4001030")]
		Igmp,
		// Token: 0x04000C38 RID: 3128
		[global::Cpp2ILInjected.Token(Token = "0x4001031")]
		Ggp,
		// Token: 0x04000C39 RID: 3129
		[global::Cpp2ILInjected.Token(Token = "0x4001032")]
		IPv4,
		// Token: 0x04000C3A RID: 3130
		[global::Cpp2ILInjected.Token(Token = "0x4001033")]
		Tcp = 6,
		// Token: 0x04000C3B RID: 3131
		[global::Cpp2ILInjected.Token(Token = "0x4001034")]
		Pup = 12,
		// Token: 0x04000C3C RID: 3132
		[global::Cpp2ILInjected.Token(Token = "0x4001035")]
		Udp = 17,
		// Token: 0x04000C3D RID: 3133
		[global::Cpp2ILInjected.Token(Token = "0x4001036")]
		Idp = 22,
		// Token: 0x04000C3E RID: 3134
		[global::Cpp2ILInjected.Token(Token = "0x4001037")]
		IPv6 = 41,
		// Token: 0x04000C3F RID: 3135
		[global::Cpp2ILInjected.Token(Token = "0x4001038")]
		IPv6RoutingHeader = 43,
		// Token: 0x04000C40 RID: 3136
		[global::Cpp2ILInjected.Token(Token = "0x4001039")]
		IPv6FragmentHeader,
		// Token: 0x04000C41 RID: 3137
		[global::Cpp2ILInjected.Token(Token = "0x400103A")]
		IPSecEncapsulatingSecurityPayload = 50,
		// Token: 0x04000C42 RID: 3138
		[global::Cpp2ILInjected.Token(Token = "0x400103B")]
		IPSecAuthenticationHeader,
		// Token: 0x04000C43 RID: 3139
		[global::Cpp2ILInjected.Token(Token = "0x400103C")]
		IcmpV6 = 58,
		// Token: 0x04000C44 RID: 3140
		[global::Cpp2ILInjected.Token(Token = "0x400103D")]
		IPv6NoNextHeader,
		// Token: 0x04000C45 RID: 3141
		[global::Cpp2ILInjected.Token(Token = "0x400103E")]
		IPv6DestinationOptions,
		// Token: 0x04000C46 RID: 3142
		[global::Cpp2ILInjected.Token(Token = "0x400103F")]
		ND = 77,
		// Token: 0x04000C47 RID: 3143
		[global::Cpp2ILInjected.Token(Token = "0x4001040")]
		Raw = 255,
		// Token: 0x04000C48 RID: 3144
		[global::Cpp2ILInjected.Token(Token = "0x4001041")]
		Unspecified = 0,
		// Token: 0x04000C49 RID: 3145
		[global::Cpp2ILInjected.Token(Token = "0x4001042")]
		Ipx = 1000,
		// Token: 0x04000C4A RID: 3146
		[global::Cpp2ILInjected.Token(Token = "0x4001043")]
		Spx = 1256,
		// Token: 0x04000C4B RID: 3147
		[global::Cpp2ILInjected.Token(Token = "0x4001044")]
		SpxII,
		// Token: 0x04000C4C RID: 3148
		[global::Cpp2ILInjected.Token(Token = "0x4001045")]
		Unknown = -1
	}
}
