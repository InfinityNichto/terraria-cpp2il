using System;
using Cpp2ILInjected;

namespace Mono
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	internal enum CertificateImportFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000085")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000086")]
		DisableNativeBackend = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000087")]
		DisableAutomaticFallback = 2
	}
}
