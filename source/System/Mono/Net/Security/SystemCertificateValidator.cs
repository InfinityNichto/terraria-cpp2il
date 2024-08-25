using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000068")]
	internal static class SystemCertificateValidator
	{
		[global::Cpp2ILInjected.Token(Token = "0x600018D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4EEC0", Offset = "0x1D4EEC0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static SystemCertificateValidator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600018E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4A518", Offset = "0x1D4A518", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool NeedsChain(MonoTlsSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		private static bool is_macosx;

		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		private static X509KeyUsageFlags s_flags;
	}
}
