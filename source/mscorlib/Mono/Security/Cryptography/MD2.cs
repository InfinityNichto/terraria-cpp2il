using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200002F RID: 47
	[global::Cpp2ILInjected.Token(Token = "0x2000045")]
	internal abstract class MD2 : global::System.Security.Cryptography.HashAlgorithm
	{
		// Token: 0x0600010A RID: 266 RVA: 0x000148D6 File Offset: 0x00012AD6
		[global::Cpp2ILInjected.Token(Token = "0x600014C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA500", Offset = "0x1ABA500", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		protected MD2()
		{
			throw null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000148D9 File Offset: 0x00012AD9
		[global::Cpp2ILInjected.Token(Token = "0x600014D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA520", Offset = "0x1ABA520", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Security.Cryptography.HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD2Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static MD2 Create()
		{
			throw null;
		}
	}
}
