using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x020000E9 RID: 233
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000159")]
	public enum SecurityProtocolType
	{
		// Token: 0x04000556 RID: 1366
		[global::Cpp2ILInjected.Token(Token = "0x40006FC")]
		SystemDefault = 0,
		// Token: 0x04000557 RID: 1367
		[global::Cpp2ILInjected.Token(Token = "0x40006FD")]
		Ssl3 = 48,
		// Token: 0x04000558 RID: 1368
		[global::Cpp2ILInjected.Token(Token = "0x40006FE")]
		Tls = 192,
		// Token: 0x04000559 RID: 1369
		[global::Cpp2ILInjected.Token(Token = "0x40006FF")]
		Tls11 = 768,
		// Token: 0x0400055A RID: 1370
		[global::Cpp2ILInjected.Token(Token = "0x4000700")]
		Tls12 = 3072,
		// Token: 0x0400055B RID: 1371
		[global::Cpp2ILInjected.Token(Token = "0x4000701")]
		Tls13 = 12288
	}
}
