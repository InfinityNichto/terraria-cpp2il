using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002DB")]
	internal struct sockaddr_in6
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000F49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sin6_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sin6_family;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin6_port;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin6_flowinfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public in6_addr sin6_addr;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint sin6_scope_id;
	}
}
