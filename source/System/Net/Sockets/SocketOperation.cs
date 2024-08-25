using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x200030D")]
	internal enum SocketOperation
	{
		[global::Cpp2ILInjected.Token(Token = "0x400110C")]
		Accept,
		[global::Cpp2ILInjected.Token(Token = "0x400110D")]
		Connect,
		[global::Cpp2ILInjected.Token(Token = "0x400110E")]
		Receive,
		[global::Cpp2ILInjected.Token(Token = "0x400110F")]
		ReceiveFrom,
		[global::Cpp2ILInjected.Token(Token = "0x4001110")]
		Send,
		[global::Cpp2ILInjected.Token(Token = "0x4001111")]
		SendTo,
		[global::Cpp2ILInjected.Token(Token = "0x4001112")]
		RecvJustCallback,
		[global::Cpp2ILInjected.Token(Token = "0x4001113")]
		SendJustCallback,
		[global::Cpp2ILInjected.Token(Token = "0x4001114")]
		Disconnect,
		[global::Cpp2ILInjected.Token(Token = "0x4001115")]
		AcceptReceive,
		[global::Cpp2ILInjected.Token(Token = "0x4001116")]
		ReceiveGeneric,
		[global::Cpp2ILInjected.Token(Token = "0x4001117")]
		SendGeneric
	}
}
