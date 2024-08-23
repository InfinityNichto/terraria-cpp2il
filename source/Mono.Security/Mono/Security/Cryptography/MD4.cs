using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Protocol.Ntlm;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200003B RID: 59
	[global::Cpp2ILInjected.Token(Token = "0x2000056")]
	public abstract class MD4 : HashAlgorithm
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x000034FB File Offset: 0x000016FB
		[global::Cpp2ILInjected.Token(Token = "0x600024B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D658", Offset = "0x1A9D658", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		protected MD4()
		{
			throw null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000034FE File Offset: 0x000016FE
		[global::Cpp2ILInjected.Token(Token = "0x600024C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A98278", Offset = "0x1A98278", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLM_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD4Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static MD4 Create()
		{
			throw null;
		}
	}
}
