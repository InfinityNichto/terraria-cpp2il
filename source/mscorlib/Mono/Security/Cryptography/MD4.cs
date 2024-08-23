using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000031 RID: 49
	[global::Cpp2ILInjected.Token(Token = "0x2000047")]
	internal abstract class MD4 : global::System.Security.Cryptography.HashAlgorithm
	{
		// Token: 0x06000113 RID: 275 RVA: 0x000148F1 File Offset: 0x00012AF1
		[global::Cpp2ILInjected.Token(Token = "0x6000155")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABAB08", Offset = "0x1ABAB08", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		protected MD4()
		{
			throw null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000148F4 File Offset: 0x00012AF4
		[global::Cpp2ILInjected.Token(Token = "0x6000156")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABAB28", Offset = "0x1ABAB28", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Security.Cryptography.HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD4Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static MD4 Create()
		{
			throw null;
		}
	}
}
