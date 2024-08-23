using System;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	// Token: 0x0200002E RID: 46
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000049")]
	public enum MonoSslPolicyErrors
	{
		// Token: 0x040001FC RID: 508
		[global::Cpp2ILInjected.Token(Token = "0x4000229")]
		None = 0,
		// Token: 0x040001FD RID: 509
		[global::Cpp2ILInjected.Token(Token = "0x400022A")]
		RemoteCertificateNotAvailable = 1,
		// Token: 0x040001FE RID: 510
		[global::Cpp2ILInjected.Token(Token = "0x400022B")]
		RemoteCertificateNameMismatch = 2,
		// Token: 0x040001FF RID: 511
		[global::Cpp2ILInjected.Token(Token = "0x400022C")]
		RemoteCertificateChainErrors = 4
	}
}
