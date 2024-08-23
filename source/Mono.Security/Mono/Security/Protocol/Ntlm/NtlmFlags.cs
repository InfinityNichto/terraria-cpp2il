using System;
using Cpp2ILInjected;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000022 RID: 34
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200003D")]
	public enum NtlmFlags
	{
		// Token: 0x040000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
		NegotiateUnicode = 1,
		// Token: 0x040000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
		NegotiateOem = 2,
		// Token: 0x040000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
		RequestTarget = 4,
		// Token: 0x040000B4 RID: 180
		[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
		NegotiateNtlm = 512,
		// Token: 0x040000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
		NegotiateDomainSupplied = 4096,
		// Token: 0x040000B6 RID: 182
		[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
		NegotiateWorkstationSupplied = 8192,
		// Token: 0x040000B7 RID: 183
		[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
		NegotiateAlwaysSign = 32768,
		// Token: 0x040000B8 RID: 184
		[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
		NegotiateNtlm2Key = 524288,
		// Token: 0x040000B9 RID: 185
		[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
		Negotiate128 = 536870912,
		// Token: 0x040000BA RID: 186
		[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
		Negotiate56 = -2147483648
	}
}
