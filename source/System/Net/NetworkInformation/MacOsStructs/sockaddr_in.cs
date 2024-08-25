using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.MacOsStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002CD")]
	internal struct sockaddr_in
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000F24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sin_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000F25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sin_family;

		[global::Cpp2ILInjected.Token(Token = "0x4000F26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin_port;

		[global::Cpp2ILInjected.Token(Token = "0x4000F27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin_addr;
	}
}
