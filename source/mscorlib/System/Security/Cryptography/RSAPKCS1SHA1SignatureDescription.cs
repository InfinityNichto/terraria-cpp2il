using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000266 RID: 614
	[global::Cpp2ILInjected.Token(Token = "0x2000303")]
	internal class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x06001808 RID: 6152 RVA: 0x000188A8 File Offset: 0x00016AA8
		[global::Cpp2ILInjected.Token(Token = "0x6001A22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10A80", Offset = "0x1B10A80", Length = "0x68")]
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
		public RSAPKCS1SHA1SignatureDescription()
		{
			throw null;
		}
	}
}
