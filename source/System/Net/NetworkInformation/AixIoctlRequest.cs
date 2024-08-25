using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002AD")]
	internal enum AixIoctlRequest : uint
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000ECC")]
		SIOCGSIZIFCONF = 1074030954U,
		[global::Cpp2ILInjected.Token(Token = "0x4000ECD")]
		SIOCGIFCONF = 3222300997U,
		[global::Cpp2ILInjected.Token(Token = "0x4000ECE")]
		SIOCGIFFLAGS = 3223873809U,
		[global::Cpp2ILInjected.Token(Token = "0x4000ECF")]
		SIOCGIFNETMASK = 3223873829U,
		[global::Cpp2ILInjected.Token(Token = "0x4000ED0")]
		SIOCGIFMTU = 3223873878U
	}
}
