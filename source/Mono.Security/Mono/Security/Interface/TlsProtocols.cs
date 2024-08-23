using System;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	// Token: 0x02000035 RID: 53
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000050")]
	public enum TlsProtocols
	{
		// Token: 0x04000215 RID: 533
		[global::Cpp2ILInjected.Token(Token = "0x4000242")]
		Zero = 0,
		// Token: 0x04000216 RID: 534
		[global::Cpp2ILInjected.Token(Token = "0x4000243")]
		Tls10Client = 128,
		// Token: 0x04000217 RID: 535
		[global::Cpp2ILInjected.Token(Token = "0x4000244")]
		Tls10Server = 64,
		// Token: 0x04000218 RID: 536
		[global::Cpp2ILInjected.Token(Token = "0x4000245")]
		Tls10 = 192,
		// Token: 0x04000219 RID: 537
		[global::Cpp2ILInjected.Token(Token = "0x4000246")]
		Tls11Client = 512,
		// Token: 0x0400021A RID: 538
		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		Tls11Server = 256,
		// Token: 0x0400021B RID: 539
		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		Tls11 = 768,
		// Token: 0x0400021C RID: 540
		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		Tls12Client = 2048,
		// Token: 0x0400021D RID: 541
		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		Tls12Server = 1024,
		// Token: 0x0400021E RID: 542
		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		Tls12 = 3072,
		// Token: 0x0400021F RID: 543
		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		ClientMask = 2688,
		// Token: 0x04000220 RID: 544
		[global::Cpp2ILInjected.Token(Token = "0x400024D")]
		ServerMask = 1344
	}
}
