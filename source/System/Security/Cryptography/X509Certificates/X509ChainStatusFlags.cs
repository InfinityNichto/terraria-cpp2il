using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000FA")]
	public enum X509ChainStatusFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000492")]
		NoError = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000493")]
		NotTimeValid = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000494")]
		NotTimeNested = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000495")]
		Revoked = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000496")]
		NotSignatureValid = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000497")]
		NotValidForUsage = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000498")]
		UntrustedRoot = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000499")]
		RevocationStatusUnknown = 64,
		[global::Cpp2ILInjected.Token(Token = "0x400049A")]
		Cyclic = 128,
		[global::Cpp2ILInjected.Token(Token = "0x400049B")]
		InvalidExtension = 256,
		[global::Cpp2ILInjected.Token(Token = "0x400049C")]
		InvalidPolicyConstraints = 512,
		[global::Cpp2ILInjected.Token(Token = "0x400049D")]
		InvalidBasicConstraints = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x400049E")]
		InvalidNameConstraints = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x400049F")]
		HasNotSupportedNameConstraint = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x40004A0")]
		HasNotDefinedNameConstraint = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x40004A1")]
		HasNotPermittedNameConstraint = 16384,
		[global::Cpp2ILInjected.Token(Token = "0x40004A2")]
		HasExcludedNameConstraint = 32768,
		[global::Cpp2ILInjected.Token(Token = "0x40004A3")]
		PartialChain = 65536,
		[global::Cpp2ILInjected.Token(Token = "0x40004A4")]
		CtlNotTimeValid = 131072,
		[global::Cpp2ILInjected.Token(Token = "0x40004A5")]
		CtlNotSignatureValid = 262144,
		[global::Cpp2ILInjected.Token(Token = "0x40004A6")]
		CtlNotValidForUsage = 524288,
		[global::Cpp2ILInjected.Token(Token = "0x40004A7")]
		OfflineRevocation = 16777216,
		[global::Cpp2ILInjected.Token(Token = "0x40004A8")]
		NoIssuanceChainPolicy = 33554432,
		[global::Cpp2ILInjected.Token(Token = "0x40004A9")]
		ExplicitDistrust = 67108864,
		[global::Cpp2ILInjected.Token(Token = "0x40004AA")]
		HasNotSupportedCriticalExtension = 134217728,
		[global::Cpp2ILInjected.Token(Token = "0x40004AB")]
		HasWeakSignature = 1048576
	}
}
