using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002B8")]
	internal struct sockaddr_ll
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000EE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public ushort sll_family;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sll_protocol;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int sll_ifindex;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public ushort sll_hatype;

		[global::Cpp2ILInjected.Token(Token = "0x4000EEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		public byte sll_pkttype;

		[global::Cpp2ILInjected.Token(Token = "0x4000EEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB")]
		public byte sll_halen;

		[global::Cpp2ILInjected.Token(Token = "0x4000EEC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public byte[] sll_addr;
	}
}
