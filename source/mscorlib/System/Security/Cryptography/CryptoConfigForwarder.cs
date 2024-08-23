using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000280 RID: 640
	[global::Cpp2ILInjected.Token(Token = "0x200031D")]
	internal static class CryptoConfigForwarder
	{
		// Token: 0x060018EA RID: 6378 RVA: 0x00018B36 File Offset: 0x00016D36
		[global::Cpp2ILInjected.Token(Token = "0x6001B04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CE94", Offset = "0x1B1CE94", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static object CreateFromName(string name)
		{
			throw null;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00018B39 File Offset: 0x00016D39
		[global::Cpp2ILInjected.Token(Token = "0x6001B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CEEC", Offset = "0x1B1CEEC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashAlgorithm), Member = "Create", ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static HashAlgorithm CreateDefaultHashAlgorithm()
		{
			throw null;
		}
	}
}
