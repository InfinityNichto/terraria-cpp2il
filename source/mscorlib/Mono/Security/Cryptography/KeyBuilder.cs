using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200002D RID: 45
	[global::Cpp2ILInjected.Token(Token = "0x2000043")]
	internal sealed class KeyBuilder
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00014885 File Offset: 0x00012A85
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		private static global::System.Security.Cryptography.RandomNumberGenerator Rng
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB8B50", Offset = "0x1AB8B50", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyBuilder), Member = "IV", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00014888 File Offset: 0x00012A88
		[global::Cpp2ILInjected.Token(Token = "0x600012D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB8BB8", Offset = "0x1AB8BB8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DESTransform), Member = "GetStrongKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RC2Transform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RC2),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.TripleDESTransform), Member = "GetStrongKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "GenerateKey", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyBuilder), Member = "get_Rng", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] Key(int size)
		{
			throw null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001488B File Offset: 0x00012A8B
		[global::Cpp2ILInjected.Token(Token = "0x600012E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB8C20", Offset = "0x1AB8C20", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "GenerateIV", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyBuilder), Member = "get_Rng", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] IV(int size)
		{
			throw null;
		}

		// Token: 0x04000091 RID: 145
		[global::Cpp2ILInjected.Token(Token = "0x400013E")]
		private static global::System.Security.Cryptography.RandomNumberGenerator rng;
	}
}
