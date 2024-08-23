using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200009D RID: 157
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000FA")]
	public enum X509ChainStatusFlags
	{
		// Token: 0x04000329 RID: 809
		[global::Cpp2ILInjected.Token(Token = "0x4000492")]
		NoError = 0,
		// Token: 0x0400032A RID: 810
		[global::Cpp2ILInjected.Token(Token = "0x4000493")]
		NotTimeValid = 1,
		// Token: 0x0400032B RID: 811
		[global::Cpp2ILInjected.Token(Token = "0x4000494")]
		NotTimeNested = 2,
		// Token: 0x0400032C RID: 812
		[global::Cpp2ILInjected.Token(Token = "0x4000495")]
		Revoked = 4,
		// Token: 0x0400032D RID: 813
		[global::Cpp2ILInjected.Token(Token = "0x4000496")]
		NotSignatureValid = 8,
		// Token: 0x0400032E RID: 814
		[global::Cpp2ILInjected.Token(Token = "0x4000497")]
		NotValidForUsage = 16,
		// Token: 0x0400032F RID: 815
		[global::Cpp2ILInjected.Token(Token = "0x4000498")]
		UntrustedRoot = 32,
		// Token: 0x04000330 RID: 816
		[global::Cpp2ILInjected.Token(Token = "0x4000499")]
		RevocationStatusUnknown = 64,
		// Token: 0x04000331 RID: 817
		[global::Cpp2ILInjected.Token(Token = "0x400049A")]
		Cyclic = 128,
		// Token: 0x04000332 RID: 818
		[global::Cpp2ILInjected.Token(Token = "0x400049B")]
		InvalidExtension = 256,
		// Token: 0x04000333 RID: 819
		[global::Cpp2ILInjected.Token(Token = "0x400049C")]
		InvalidPolicyConstraints = 512,
		// Token: 0x04000334 RID: 820
		[global::Cpp2ILInjected.Token(Token = "0x400049D")]
		InvalidBasicConstraints = 1024,
		// Token: 0x04000335 RID: 821
		[global::Cpp2ILInjected.Token(Token = "0x400049E")]
		InvalidNameConstraints = 2048,
		// Token: 0x04000336 RID: 822
		[global::Cpp2ILInjected.Token(Token = "0x400049F")]
		HasNotSupportedNameConstraint = 4096,
		// Token: 0x04000337 RID: 823
		[global::Cpp2ILInjected.Token(Token = "0x40004A0")]
		HasNotDefinedNameConstraint = 8192,
		// Token: 0x04000338 RID: 824
		[global::Cpp2ILInjected.Token(Token = "0x40004A1")]
		HasNotPermittedNameConstraint = 16384,
		// Token: 0x04000339 RID: 825
		[global::Cpp2ILInjected.Token(Token = "0x40004A2")]
		HasExcludedNameConstraint = 32768,
		// Token: 0x0400033A RID: 826
		[global::Cpp2ILInjected.Token(Token = "0x40004A3")]
		PartialChain = 65536,
		// Token: 0x0400033B RID: 827
		[global::Cpp2ILInjected.Token(Token = "0x40004A4")]
		CtlNotTimeValid = 131072,
		// Token: 0x0400033C RID: 828
		[global::Cpp2ILInjected.Token(Token = "0x40004A5")]
		CtlNotSignatureValid = 262144,
		// Token: 0x0400033D RID: 829
		[global::Cpp2ILInjected.Token(Token = "0x40004A6")]
		CtlNotValidForUsage = 524288,
		// Token: 0x0400033E RID: 830
		[global::Cpp2ILInjected.Token(Token = "0x40004A7")]
		OfflineRevocation = 16777216,
		// Token: 0x0400033F RID: 831
		[global::Cpp2ILInjected.Token(Token = "0x40004A8")]
		NoIssuanceChainPolicy = 33554432,
		// Token: 0x04000340 RID: 832
		[global::Cpp2ILInjected.Token(Token = "0x40004A9")]
		ExplicitDistrust = 67108864,
		// Token: 0x04000341 RID: 833
		[global::Cpp2ILInjected.Token(Token = "0x40004AA")]
		HasNotSupportedCriticalExtension = 134217728,
		// Token: 0x04000342 RID: 834
		[global::Cpp2ILInjected.Token(Token = "0x40004AB")]
		HasWeakSignature = 1048576
	}
}
