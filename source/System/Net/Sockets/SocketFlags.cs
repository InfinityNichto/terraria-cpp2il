using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000300")]
	public enum SocketFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001086")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4001087")]
		OutOfBand = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4001088")]
		Peek = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4001089")]
		DontRoute = 4,
		[global::Cpp2ILInjected.Token(Token = "0x400108A")]
		MaxIOVectorLength = 16,
		[global::Cpp2ILInjected.Token(Token = "0x400108B")]
		Truncated = 256,
		[global::Cpp2ILInjected.Token(Token = "0x400108C")]
		ControlDataTruncated = 512,
		[global::Cpp2ILInjected.Token(Token = "0x400108D")]
		Broadcast = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x400108E")]
		Multicast = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x400108F")]
		Partial = 32768
	}
}
