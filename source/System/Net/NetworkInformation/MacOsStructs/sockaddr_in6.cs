using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.MacOsStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002CF")]
	internal struct sockaddr_in6
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000F29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sin6_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000F2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sin6_family;

		[global::Cpp2ILInjected.Token(Token = "0x4000F2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin6_port;

		[global::Cpp2ILInjected.Token(Token = "0x4000F2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin6_flowinfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000F2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public in6_addr sin6_addr;

		[global::Cpp2ILInjected.Token(Token = "0x4000F2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint sin6_scope_id;
	}
}
