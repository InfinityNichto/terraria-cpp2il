using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200009F RID: 159
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000FC")]
	public enum X509KeyUsageFlags
	{
		// Token: 0x04000354 RID: 852
		[global::Cpp2ILInjected.Token(Token = "0x40004BD")]
		None = 0,
		// Token: 0x04000355 RID: 853
		[global::Cpp2ILInjected.Token(Token = "0x40004BE")]
		EncipherOnly = 1,
		// Token: 0x04000356 RID: 854
		[global::Cpp2ILInjected.Token(Token = "0x40004BF")]
		CrlSign = 2,
		// Token: 0x04000357 RID: 855
		[global::Cpp2ILInjected.Token(Token = "0x40004C0")]
		KeyCertSign = 4,
		// Token: 0x04000358 RID: 856
		[global::Cpp2ILInjected.Token(Token = "0x40004C1")]
		KeyAgreement = 8,
		// Token: 0x04000359 RID: 857
		[global::Cpp2ILInjected.Token(Token = "0x40004C2")]
		DataEncipherment = 16,
		// Token: 0x0400035A RID: 858
		[global::Cpp2ILInjected.Token(Token = "0x40004C3")]
		KeyEncipherment = 32,
		// Token: 0x0400035B RID: 859
		[global::Cpp2ILInjected.Token(Token = "0x40004C4")]
		NonRepudiation = 64,
		// Token: 0x0400035C RID: 860
		[global::Cpp2ILInjected.Token(Token = "0x40004C5")]
		DigitalSignature = 128,
		// Token: 0x0400035D RID: 861
		[global::Cpp2ILInjected.Token(Token = "0x40004C6")]
		DecipherOnly = 32768
	}
}
