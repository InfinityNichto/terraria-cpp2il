using System;
using Cpp2ILInjected;

namespace Mono.Security.X509
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	[Serializable]
	public enum X509ChainStatusFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000094")]
		InvalidBasicConstraints = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x4000095")]
		NoError = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000096")]
		NotSignatureValid = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000097")]
		NotTimeNested = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		NotTimeValid = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		PartialChain = 65536,
		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		UntrustedRoot = 32
	}
}
