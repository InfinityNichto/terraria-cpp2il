using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x2000304")]
	public enum SocketType
	{
		[global::Cpp2ILInjected.Token(Token = "0x40010CA")]
		Stream = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40010CB")]
		Dgram,
		[global::Cpp2ILInjected.Token(Token = "0x40010CC")]
		Raw,
		[global::Cpp2ILInjected.Token(Token = "0x40010CD")]
		Rdm,
		[global::Cpp2ILInjected.Token(Token = "0x40010CE")]
		Seqpacket,
		[global::Cpp2ILInjected.Token(Token = "0x40010CF")]
		Unknown = -1
	}
}
