using System;
using Cpp2ILInjected;

namespace System.Diagnostics.Tracing
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20005D8")]
	public enum EventKeywords : long
	{
		[global::Cpp2ILInjected.Token(Token = "0x400197D")]
		None = 0L,
		[global::Cpp2ILInjected.Token(Token = "0x400197E")]
		All = -1L,
		[global::Cpp2ILInjected.Token(Token = "0x400197F")]
		MicrosoftTelemetry = 562949953421312L,
		[global::Cpp2ILInjected.Token(Token = "0x4001980")]
		WdiContext = 562949953421312L,
		[global::Cpp2ILInjected.Token(Token = "0x4001981")]
		WdiDiagnostic = 1125899906842624L,
		[global::Cpp2ILInjected.Token(Token = "0x4001982")]
		Sqm = 2251799813685248L,
		[global::Cpp2ILInjected.Token(Token = "0x4001983")]
		AuditFailure = 4503599627370496L,
		[global::Cpp2ILInjected.Token(Token = "0x4001984")]
		AuditSuccess = 9007199254740992L,
		[global::Cpp2ILInjected.Token(Token = "0x4001985")]
		CorrelationHint = 4503599627370496L,
		[global::Cpp2ILInjected.Token(Token = "0x4001986")]
		EventLogClassic = 36028797018963968L
	}
}
