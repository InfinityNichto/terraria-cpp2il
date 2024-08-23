using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000039 RID: 57
	[global::Cpp2ILInjected.Token(Token = "0x2000054")]
	public abstract class MD2 : HashAlgorithm
	{
		// Token: 0x060001EC RID: 492 RVA: 0x000034E0 File Offset: 0x000016E0
		[global::Cpp2ILInjected.Token(Token = "0x6000242")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D050", Offset = "0x1A9D050", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		protected MD2()
		{
			throw null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000034E3 File Offset: 0x000016E3
		[global::Cpp2ILInjected.Token(Token = "0x6000243")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9D070", Offset = "0x1A9D070", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD2Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static MD2 Create()
		{
			throw null;
		}
	}
}
