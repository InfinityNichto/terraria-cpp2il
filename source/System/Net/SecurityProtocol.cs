using System;
using System.Security.Authentication;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x020000CC RID: 204
	[global::Cpp2ILInjected.Token(Token = "0x200012E")]
	internal static class SecurityProtocol
	{
		// Token: 0x0400041D RID: 1053
		[global::Cpp2ILInjected.Token(Token = "0x4000595")]
		public const SslProtocols DefaultSecurityProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;

		// Token: 0x0400041E RID: 1054
		[global::Cpp2ILInjected.Token(Token = "0x4000596")]
		public const SslProtocols SystemDefaultSecurityProtocols = SslProtocols.None;
	}
}
