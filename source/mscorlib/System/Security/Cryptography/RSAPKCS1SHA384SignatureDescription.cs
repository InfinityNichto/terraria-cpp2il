using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000268 RID: 616
	[global::Cpp2ILInjected.Token(Token = "0x2000305")]
	internal class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x0600180A RID: 6154 RVA: 0x000188AE File Offset: 0x00016AAE
		[global::Cpp2ILInjected.Token(Token = "0x6001A24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10B50", Offset = "0x1B10B50", Length = "0x68")]
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
		public RSAPKCS1SHA384SignatureDescription()
		{
			throw null;
		}
	}
}
