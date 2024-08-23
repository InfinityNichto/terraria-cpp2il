using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200026A RID: 618
	[global::Cpp2ILInjected.Token(Token = "0x2000307")]
	internal class DSASignatureDescription : SignatureDescription
	{
		// Token: 0x0600180C RID: 6156 RVA: 0x000188B4 File Offset: 0x00016AB4
		[global::Cpp2ILInjected.Token(Token = "0x6001A26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10C20", Offset = "0x1B10C20", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public DSASignatureDescription()
		{
			throw null;
		}
	}
}
