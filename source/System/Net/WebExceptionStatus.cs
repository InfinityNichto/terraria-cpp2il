using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001CA")]
	public enum WebExceptionStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x400099E")]
		Success,
		[global::Cpp2ILInjected.Token(Token = "0x400099F")]
		NameResolutionFailure,
		[global::Cpp2ILInjected.Token(Token = "0x40009A0")]
		ConnectFailure,
		[global::Cpp2ILInjected.Token(Token = "0x40009A1")]
		ReceiveFailure,
		[global::Cpp2ILInjected.Token(Token = "0x40009A2")]
		SendFailure,
		[global::Cpp2ILInjected.Token(Token = "0x40009A3")]
		PipelineFailure,
		[global::Cpp2ILInjected.Token(Token = "0x40009A4")]
		RequestCanceled,
		[global::Cpp2ILInjected.Token(Token = "0x40009A5")]
		ProtocolError,
		[global::Cpp2ILInjected.Token(Token = "0x40009A6")]
		ConnectionClosed,
		[global::Cpp2ILInjected.Token(Token = "0x40009A7")]
		TrustFailure,
		[global::Cpp2ILInjected.Token(Token = "0x40009A8")]
		SecureChannelFailure,
		[global::Cpp2ILInjected.Token(Token = "0x40009A9")]
		ServerProtocolViolation,
		[global::Cpp2ILInjected.Token(Token = "0x40009AA")]
		KeepAliveFailure,
		[global::Cpp2ILInjected.Token(Token = "0x40009AB")]
		Pending,
		[global::Cpp2ILInjected.Token(Token = "0x40009AC")]
		Timeout,
		[global::Cpp2ILInjected.Token(Token = "0x40009AD")]
		ProxyNameResolutionFailure,
		[global::Cpp2ILInjected.Token(Token = "0x40009AE")]
		UnknownError,
		[global::Cpp2ILInjected.Token(Token = "0x40009AF")]
		MessageLengthLimitExceeded,
		[global::Cpp2ILInjected.Token(Token = "0x40009B0")]
		CacheEntryNotFound,
		[global::Cpp2ILInjected.Token(Token = "0x40009B1")]
		RequestProhibitedByCachePolicy,
		[global::Cpp2ILInjected.Token(Token = "0x40009B2")]
		RequestProhibitedByProxy
	}
}
