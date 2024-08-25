using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002B5")]
	internal struct sockaddr_in
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000EDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public ushort sin_family;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin_port;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin_addr;
	}
}
