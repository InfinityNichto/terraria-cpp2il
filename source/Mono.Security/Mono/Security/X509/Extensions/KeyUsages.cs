using System;
using Cpp2ILInjected;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x0200001B RID: 27
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000036")]
	public enum KeyUsages
	{
		// Token: 0x04000094 RID: 148
		[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
		digitalSignature = 128,
		// Token: 0x04000095 RID: 149
		[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
		nonRepudiation = 64,
		// Token: 0x04000096 RID: 150
		[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
		keyEncipherment = 32,
		// Token: 0x04000097 RID: 151
		[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
		dataEncipherment = 16,
		// Token: 0x04000098 RID: 152
		[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
		keyAgreement = 8,
		// Token: 0x04000099 RID: 153
		[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
		keyCertSign = 4,
		// Token: 0x0400009A RID: 154
		[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
		cRLSign = 2,
		// Token: 0x0400009B RID: 155
		[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
		encipherOnly = 1,
		// Token: 0x0400009C RID: 156
		[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
		decipherOnly = 2048,
		// Token: 0x0400009D RID: 157
		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		none = 0
	}
}
