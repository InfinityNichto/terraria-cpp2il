using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002D9")]
	internal struct sockaddr_in
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000F44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sin_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000F45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sin_family;

		[global::Cpp2ILInjected.Token(Token = "0x4000F46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin_port;

		[global::Cpp2ILInjected.Token(Token = "0x4000F47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin_addr;
	}
}
