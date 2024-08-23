using System;
using Cpp2ILInjected;

namespace System.Net.Security
{
	// Token: 0x02000230 RID: 560
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000320")]
	public enum SslPolicyErrors
	{
		// Token: 0x04000D55 RID: 3413
		[global::Cpp2ILInjected.Token(Token = "0x4001150")]
		None = 0,
		// Token: 0x04000D56 RID: 3414
		[global::Cpp2ILInjected.Token(Token = "0x4001151")]
		RemoteCertificateNotAvailable = 1,
		// Token: 0x04000D57 RID: 3415
		[global::Cpp2ILInjected.Token(Token = "0x4001152")]
		RemoteCertificateNameMismatch = 2,
		// Token: 0x04000D58 RID: 3416
		[global::Cpp2ILInjected.Token(Token = "0x4001153")]
		RemoteCertificateChainErrors = 4
	}
}
