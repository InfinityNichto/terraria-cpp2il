using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200013D")]
	public enum HttpStatusCode
	{
		[global::Cpp2ILInjected.Token(Token = "0x40005F3")]
		Continue = 100,
		[global::Cpp2ILInjected.Token(Token = "0x40005F4")]
		SwitchingProtocols,
		[global::Cpp2ILInjected.Token(Token = "0x40005F5")]
		Processing,
		[global::Cpp2ILInjected.Token(Token = "0x40005F6")]
		EarlyHints,
		[global::Cpp2ILInjected.Token(Token = "0x40005F7")]
		OK = 200,
		[global::Cpp2ILInjected.Token(Token = "0x40005F8")]
		Created,
		[global::Cpp2ILInjected.Token(Token = "0x40005F9")]
		Accepted,
		[global::Cpp2ILInjected.Token(Token = "0x40005FA")]
		NonAuthoritativeInformation,
		[global::Cpp2ILInjected.Token(Token = "0x40005FB")]
		NoContent,
		[global::Cpp2ILInjected.Token(Token = "0x40005FC")]
		ResetContent,
		[global::Cpp2ILInjected.Token(Token = "0x40005FD")]
		PartialContent,
		[global::Cpp2ILInjected.Token(Token = "0x40005FE")]
		MultiStatus,
		[global::Cpp2ILInjected.Token(Token = "0x40005FF")]
		AlreadyReported,
		[global::Cpp2ILInjected.Token(Token = "0x4000600")]
		IMUsed = 226,
		[global::Cpp2ILInjected.Token(Token = "0x4000601")]
		MultipleChoices = 300,
		[global::Cpp2ILInjected.Token(Token = "0x4000602")]
		Ambiguous = 300,
		[global::Cpp2ILInjected.Token(Token = "0x4000603")]
		MovedPermanently,
		[global::Cpp2ILInjected.Token(Token = "0x4000604")]
		Moved = 301,
		[global::Cpp2ILInjected.Token(Token = "0x4000605")]
		Found,
		[global::Cpp2ILInjected.Token(Token = "0x4000606")]
		Redirect = 302,
		[global::Cpp2ILInjected.Token(Token = "0x4000607")]
		SeeOther,
		[global::Cpp2ILInjected.Token(Token = "0x4000608")]
		RedirectMethod = 303,
		[global::Cpp2ILInjected.Token(Token = "0x4000609")]
		NotModified,
		[global::Cpp2ILInjected.Token(Token = "0x400060A")]
		UseProxy,
		[global::Cpp2ILInjected.Token(Token = "0x400060B")]
		Unused,
		[global::Cpp2ILInjected.Token(Token = "0x400060C")]
		TemporaryRedirect,
		[global::Cpp2ILInjected.Token(Token = "0x400060D")]
		RedirectKeepVerb = 307,
		[global::Cpp2ILInjected.Token(Token = "0x400060E")]
		PermanentRedirect,
		[global::Cpp2ILInjected.Token(Token = "0x400060F")]
		BadRequest = 400,
		[global::Cpp2ILInjected.Token(Token = "0x4000610")]
		Unauthorized,
		[global::Cpp2ILInjected.Token(Token = "0x4000611")]
		PaymentRequired,
		[global::Cpp2ILInjected.Token(Token = "0x4000612")]
		Forbidden,
		[global::Cpp2ILInjected.Token(Token = "0x4000613")]
		NotFound,
		[global::Cpp2ILInjected.Token(Token = "0x4000614")]
		MethodNotAllowed,
		[global::Cpp2ILInjected.Token(Token = "0x4000615")]
		NotAcceptable,
		[global::Cpp2ILInjected.Token(Token = "0x4000616")]
		ProxyAuthenticationRequired,
		[global::Cpp2ILInjected.Token(Token = "0x4000617")]
		RequestTimeout,
		[global::Cpp2ILInjected.Token(Token = "0x4000618")]
		Conflict,
		[global::Cpp2ILInjected.Token(Token = "0x4000619")]
		Gone,
		[global::Cpp2ILInjected.Token(Token = "0x400061A")]
		LengthRequired,
		[global::Cpp2ILInjected.Token(Token = "0x400061B")]
		PreconditionFailed,
		[global::Cpp2ILInjected.Token(Token = "0x400061C")]
		RequestEntityTooLarge,
		[global::Cpp2ILInjected.Token(Token = "0x400061D")]
		RequestUriTooLong,
		[global::Cpp2ILInjected.Token(Token = "0x400061E")]
		UnsupportedMediaType,
		[global::Cpp2ILInjected.Token(Token = "0x400061F")]
		RequestedRangeNotSatisfiable,
		[global::Cpp2ILInjected.Token(Token = "0x4000620")]
		ExpectationFailed,
		[global::Cpp2ILInjected.Token(Token = "0x4000621")]
		MisdirectedRequest = 421,
		[global::Cpp2ILInjected.Token(Token = "0x4000622")]
		UnprocessableEntity,
		[global::Cpp2ILInjected.Token(Token = "0x4000623")]
		Locked,
		[global::Cpp2ILInjected.Token(Token = "0x4000624")]
		FailedDependency,
		[global::Cpp2ILInjected.Token(Token = "0x4000625")]
		UpgradeRequired = 426,
		[global::Cpp2ILInjected.Token(Token = "0x4000626")]
		PreconditionRequired = 428,
		[global::Cpp2ILInjected.Token(Token = "0x4000627")]
		TooManyRequests,
		[global::Cpp2ILInjected.Token(Token = "0x4000628")]
		RequestHeaderFieldsTooLarge = 431,
		[global::Cpp2ILInjected.Token(Token = "0x4000629")]
		UnavailableForLegalReasons = 451,
		[global::Cpp2ILInjected.Token(Token = "0x400062A")]
		InternalServerError = 500,
		[global::Cpp2ILInjected.Token(Token = "0x400062B")]
		NotImplemented,
		[global::Cpp2ILInjected.Token(Token = "0x400062C")]
		BadGateway,
		[global::Cpp2ILInjected.Token(Token = "0x400062D")]
		ServiceUnavailable,
		[global::Cpp2ILInjected.Token(Token = "0x400062E")]
		GatewayTimeout,
		[global::Cpp2ILInjected.Token(Token = "0x400062F")]
		HttpVersionNotSupported,
		[global::Cpp2ILInjected.Token(Token = "0x4000630")]
		VariantAlsoNegotiates,
		[global::Cpp2ILInjected.Token(Token = "0x4000631")]
		InsufficientStorage,
		[global::Cpp2ILInjected.Token(Token = "0x4000632")]
		LoopDetected,
		[global::Cpp2ILInjected.Token(Token = "0x4000633")]
		NotExtended = 510,
		[global::Cpp2ILInjected.Token(Token = "0x4000634")]
		NetworkAuthenticationRequired
	}
}
