using System;
using System.Security.Authentication;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200012E")]
	internal static class SecurityProtocol
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000595")]
		public const SslProtocols DefaultSecurityProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;

		[global::Cpp2ILInjected.Token(Token = "0x4000596")]
		public const SslProtocols SystemDefaultSecurityProtocols = SslProtocols.None;
	}
}
