using System;
using Cpp2ILInjected;

namespace Mono.Security.X509
{
	// Token: 0x02000012 RID: 18
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	[Serializable]
	public enum X509ChainStatusFlags
	{
		// Token: 0x04000070 RID: 112
		[global::Cpp2ILInjected.Token(Token = "0x4000094")]
		InvalidBasicConstraints = 1024,
		// Token: 0x04000071 RID: 113
		[global::Cpp2ILInjected.Token(Token = "0x4000095")]
		NoError = 0,
		// Token: 0x04000072 RID: 114
		[global::Cpp2ILInjected.Token(Token = "0x4000096")]
		NotSignatureValid = 8,
		// Token: 0x04000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x4000097")]
		NotTimeNested = 2,
		// Token: 0x04000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		NotTimeValid = 1,
		// Token: 0x04000075 RID: 117
		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		PartialChain = 65536,
		// Token: 0x04000076 RID: 118
		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		UntrustedRoot = 32
	}
}
