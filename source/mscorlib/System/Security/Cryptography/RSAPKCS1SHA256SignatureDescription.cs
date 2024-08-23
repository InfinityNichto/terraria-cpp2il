using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000267 RID: 615
	[global::Cpp2ILInjected.Token(Token = "0x2000304")]
	internal class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x06001809 RID: 6153 RVA: 0x000188AB File Offset: 0x00016AAB
		[global::Cpp2ILInjected.Token(Token = "0x6001A23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10AE8", Offset = "0x1B10AE8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAPKCS1SignatureDescription), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RSAPKCS1SHA256SignatureDescription()
		{
			throw null;
		}
	}
}
