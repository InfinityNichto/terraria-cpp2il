using System;
using Cpp2ILInjected;

namespace System.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000313")]
	internal enum SecurityBufferType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001120")]
		SECBUFFER_EMPTY,
		[global::Cpp2ILInjected.Token(Token = "0x4001121")]
		SECBUFFER_DATA,
		[global::Cpp2ILInjected.Token(Token = "0x4001122")]
		SECBUFFER_TOKEN,
		[global::Cpp2ILInjected.Token(Token = "0x4001123")]
		SECBUFFER_PKG_PARAMS,
		[global::Cpp2ILInjected.Token(Token = "0x4001124")]
		SECBUFFER_MISSING,
		[global::Cpp2ILInjected.Token(Token = "0x4001125")]
		SECBUFFER_EXTRA,
		[global::Cpp2ILInjected.Token(Token = "0x4001126")]
		SECBUFFER_STREAM_TRAILER,
		[global::Cpp2ILInjected.Token(Token = "0x4001127")]
		SECBUFFER_STREAM_HEADER,
		[global::Cpp2ILInjected.Token(Token = "0x4001128")]
		SECBUFFER_PADDING = 9,
		[global::Cpp2ILInjected.Token(Token = "0x4001129")]
		SECBUFFER_STREAM,
		[global::Cpp2ILInjected.Token(Token = "0x400112A")]
		SECBUFFER_CHANNEL_BINDINGS = 14,
		[global::Cpp2ILInjected.Token(Token = "0x400112B")]
		SECBUFFER_TARGET_HOST = 16,
		[global::Cpp2ILInjected.Token(Token = "0x400112C")]
		SECBUFFER_ALERT,
		[global::Cpp2ILInjected.Token(Token = "0x400112D")]
		SECBUFFER_APPLICATION_PROTOCOLS,
		[global::Cpp2ILInjected.Token(Token = "0x400112E")]
		SECBUFFER_READONLY = -2147483648,
		[global::Cpp2ILInjected.Token(Token = "0x400112F")]
		SECBUFFER_READONLY_WITH_CHECKSUM = 268435456
	}
}
