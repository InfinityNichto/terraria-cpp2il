using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002B6")]
	internal struct sockaddr_in6
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000EE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public ushort sin6_family;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin6_port;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin6_flowinfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public in6_addr sin6_addr;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint sin6_scope_id;
	}
}
