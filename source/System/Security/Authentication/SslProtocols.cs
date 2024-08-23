using System;
using Cpp2ILInjected;

namespace System.Security.Authentication
{
	// Token: 0x0200008A RID: 138
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
	public enum SslProtocols
	{
		// Token: 0x040002D9 RID: 729
		[global::Cpp2ILInjected.Token(Token = "0x400042E")]
		None = 0,
		// Token: 0x040002DA RID: 730
		[global::Cpp2ILInjected.Token(Token = "0x400042F")]
		Ssl2 = 12,
		// Token: 0x040002DB RID: 731
		[global::Cpp2ILInjected.Token(Token = "0x4000430")]
		Ssl3 = 48,
		// Token: 0x040002DC RID: 732
		[global::Cpp2ILInjected.Token(Token = "0x4000431")]
		Tls = 192,
		// Token: 0x040002DD RID: 733
		[MonoTODO("unsupported")]
		[global::Cpp2ILInjected.Token(Token = "0x4000432")]
		Tls11 = 768,
		// Token: 0x040002DE RID: 734
		[MonoTODO("unsupported")]
		[global::Cpp2ILInjected.Token(Token = "0x4000433")]
		Tls12 = 3072,
		// Token: 0x040002DF RID: 735
		[global::Cpp2ILInjected.Token(Token = "0x4000434")]
		Tls13 = 12288,
		// Token: 0x040002E0 RID: 736
		[global::Cpp2ILInjected.Token(Token = "0x4000435")]
		Default = 240
	}
}
