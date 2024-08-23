using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200009C RID: 156
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000F9")]
	public enum X500DistinguishedNameFlags
	{
		// Token: 0x0400031E RID: 798
		[global::Cpp2ILInjected.Token(Token = "0x4000487")]
		None = 0,
		// Token: 0x0400031F RID: 799
		[global::Cpp2ILInjected.Token(Token = "0x4000488")]
		Reversed = 1,
		// Token: 0x04000320 RID: 800
		[global::Cpp2ILInjected.Token(Token = "0x4000489")]
		UseSemicolons = 16,
		// Token: 0x04000321 RID: 801
		[global::Cpp2ILInjected.Token(Token = "0x400048A")]
		DoNotUsePlusSign = 32,
		// Token: 0x04000322 RID: 802
		[global::Cpp2ILInjected.Token(Token = "0x400048B")]
		DoNotUseQuotes = 64,
		// Token: 0x04000323 RID: 803
		[global::Cpp2ILInjected.Token(Token = "0x400048C")]
		UseCommas = 128,
		// Token: 0x04000324 RID: 804
		[global::Cpp2ILInjected.Token(Token = "0x400048D")]
		UseNewLines = 256,
		// Token: 0x04000325 RID: 805
		[global::Cpp2ILInjected.Token(Token = "0x400048E")]
		UseUTF8Encoding = 4096,
		// Token: 0x04000326 RID: 806
		[global::Cpp2ILInjected.Token(Token = "0x400048F")]
		UseT61Encoding = 8192,
		// Token: 0x04000327 RID: 807
		[global::Cpp2ILInjected.Token(Token = "0x4000490")]
		ForceUTF8Encoding = 16384
	}
}
