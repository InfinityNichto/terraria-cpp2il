using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001AB")]
	internal enum BufferType
	{
		[global::Cpp2ILInjected.Token(Token = "0x40008B4")]
		Empty,
		[global::Cpp2ILInjected.Token(Token = "0x40008B5")]
		Data,
		[global::Cpp2ILInjected.Token(Token = "0x40008B6")]
		Token,
		[global::Cpp2ILInjected.Token(Token = "0x40008B7")]
		Parameters,
		[global::Cpp2ILInjected.Token(Token = "0x40008B8")]
		Missing,
		[global::Cpp2ILInjected.Token(Token = "0x40008B9")]
		Extra,
		[global::Cpp2ILInjected.Token(Token = "0x40008BA")]
		Trailer,
		[global::Cpp2ILInjected.Token(Token = "0x40008BB")]
		Header,
		[global::Cpp2ILInjected.Token(Token = "0x40008BC")]
		Padding = 9,
		[global::Cpp2ILInjected.Token(Token = "0x40008BD")]
		Stream,
		[global::Cpp2ILInjected.Token(Token = "0x40008BE")]
		ChannelBindings = 14,
		[global::Cpp2ILInjected.Token(Token = "0x40008BF")]
		TargetHost = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40008C0")]
		ReadOnlyFlag = -2147483648,
		[global::Cpp2ILInjected.Token(Token = "0x40008C1")]
		ReadOnlyWithChecksum = 268435456
	}
}
