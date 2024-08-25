using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002D8")]
	internal struct sockaddr
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000F42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sa_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000F43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sa_family;
	}
}
