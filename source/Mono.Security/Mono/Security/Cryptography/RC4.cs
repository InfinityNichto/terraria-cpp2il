using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Authenticode;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200003F RID: 63
	[global::Cpp2ILInjected.Token(Token = "0x200005C")]
	public abstract class RC4 : SymmetricAlgorithm
	{
		// Token: 0x06000210 RID: 528 RVA: 0x0000354C File Offset: 0x0000174C
		[global::Cpp2ILInjected.Token(Token = "0x6000280")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BC00", Offset = "0x1A9BC00", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ARC4Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RC4()
		{
			throw null;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000354F File Offset: 0x0000174F
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00003552 File Offset: 0x00001752
		[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
		public override byte[] IV
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000281")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA08D8", Offset = "0x1AA08D8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000282")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA091C", Offset = "0x1AA091C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00003555 File Offset: 0x00001755
		[global::Cpp2ILInjected.Token(Token = "0x6000283")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA0920", Offset = "0x1AA0920", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrivateKey), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ARC4Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static RC4 Create()
		{
			throw null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00003558 File Offset: 0x00001758
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000284")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA0970", Offset = "0x1AA0970", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeySizes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static RC4()
		{
			throw null;
		}

		// Token: 0x04000236 RID: 566
		[global::Cpp2ILInjected.Token(Token = "0x400026B")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000237 RID: 567
		[global::Cpp2ILInjected.Token(Token = "0x400026C")]
		private static KeySizes[] s_legalKeySizes;
	}
}
