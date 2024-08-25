using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x20002FE")]
	public enum SocketAsyncOperation
	{
		[global::Cpp2ILInjected.Token(Token = "0x400104B")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x400104C")]
		Accept,
		[global::Cpp2ILInjected.Token(Token = "0x400104D")]
		Connect,
		[global::Cpp2ILInjected.Token(Token = "0x400104E")]
		Disconnect,
		[global::Cpp2ILInjected.Token(Token = "0x400104F")]
		Receive,
		[global::Cpp2ILInjected.Token(Token = "0x4001050")]
		ReceiveFrom,
		[global::Cpp2ILInjected.Token(Token = "0x4001051")]
		ReceiveMessageFrom,
		[global::Cpp2ILInjected.Token(Token = "0x4001052")]
		Send,
		[global::Cpp2ILInjected.Token(Token = "0x4001053")]
		SendPackets,
		[global::Cpp2ILInjected.Token(Token = "0x4001054")]
		SendTo
	}
}
