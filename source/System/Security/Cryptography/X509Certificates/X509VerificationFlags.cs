using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000A4 RID: 164
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000101")]
	public enum X509VerificationFlags
	{
		// Token: 0x04000372 RID: 882
		[global::Cpp2ILInjected.Token(Token = "0x40004DB")]
		NoFlag = 0,
		// Token: 0x04000373 RID: 883
		[global::Cpp2ILInjected.Token(Token = "0x40004DC")]
		IgnoreNotTimeValid = 1,
		// Token: 0x04000374 RID: 884
		[global::Cpp2ILInjected.Token(Token = "0x40004DD")]
		IgnoreCtlNotTimeValid = 2,
		// Token: 0x04000375 RID: 885
		[global::Cpp2ILInjected.Token(Token = "0x40004DE")]
		IgnoreNotTimeNested = 4,
		// Token: 0x04000376 RID: 886
		[global::Cpp2ILInjected.Token(Token = "0x40004DF")]
		IgnoreInvalidBasicConstraints = 8,
		// Token: 0x04000377 RID: 887
		[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
		AllowUnknownCertificateAuthority = 16,
		// Token: 0x04000378 RID: 888
		[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
		IgnoreWrongUsage = 32,
		// Token: 0x04000379 RID: 889
		[global::Cpp2ILInjected.Token(Token = "0x40004E2")]
		IgnoreInvalidName = 64,
		// Token: 0x0400037A RID: 890
		[global::Cpp2ILInjected.Token(Token = "0x40004E3")]
		IgnoreInvalidPolicy = 128,
		// Token: 0x0400037B RID: 891
		[global::Cpp2ILInjected.Token(Token = "0x40004E4")]
		IgnoreEndRevocationUnknown = 256,
		// Token: 0x0400037C RID: 892
		[global::Cpp2ILInjected.Token(Token = "0x40004E5")]
		IgnoreCtlSignerRevocationUnknown = 512,
		// Token: 0x0400037D RID: 893
		[global::Cpp2ILInjected.Token(Token = "0x40004E6")]
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		// Token: 0x0400037E RID: 894
		[global::Cpp2ILInjected.Token(Token = "0x40004E7")]
		IgnoreRootRevocationUnknown = 2048,
		// Token: 0x0400037F RID: 895
		[global::Cpp2ILInjected.Token(Token = "0x40004E8")]
		AllFlags = 4095
	}
}
