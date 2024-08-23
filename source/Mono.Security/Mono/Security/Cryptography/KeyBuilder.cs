using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000038 RID: 56
	[global::Cpp2ILInjected.Token(Token = "0x2000053")]
	public sealed class KeyBuilder
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000034DA File Offset: 0x000016DA
		[global::Cpp2ILInjected.Token(Token = "0x170000B0")]
		private static RandomNumberGenerator Rng
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000240")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9CFE8", Offset = "0x1A9CFE8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000034DD File Offset: 0x000016DD
		[global::Cpp2ILInjected.Token(Token = "0x6000241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C078", Offset = "0x1A9C078", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ARC4Managed), Member = "GenerateKey", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyBuilder), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] Key(int size)
		{
			throw null;
		}

		// Token: 0x04000226 RID: 550
		[global::Cpp2ILInjected.Token(Token = "0x4000253")]
		private static RandomNumberGenerator rng;
	}
}
