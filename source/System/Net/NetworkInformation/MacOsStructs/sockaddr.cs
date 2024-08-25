using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.MacOsStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002CC")]
	internal struct sockaddr
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000F22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sa_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000F23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sa_family;
	}
}
