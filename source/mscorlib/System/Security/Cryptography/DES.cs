using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000237 RID: 567
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D4")]
	public abstract class DES : SymmetricAlgorithm
	{
		// Token: 0x0600164C RID: 5708 RVA: 0x0001839E File Offset: 0x0001659E
		[global::Cpp2ILInjected.Token(Token = "0x6001866")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFAA0C", Offset = "0x1AFAA0C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected DES()
		{
			throw null;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x000183A1 File Offset: 0x000165A1
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x000183A4 File Offset: 0x000165A4
		[global::Cpp2ILInjected.Token(Token = "0x17000298")]
		public override byte[] Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001867")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFAA88", Offset = "0x1AFAA88", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "IsSemiWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001868")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFAEDC", Offset = "0x1AFAEDC", Length = "0x1FC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "IsSemiWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000183A7 File Offset: 0x000165A7
		[global::Cpp2ILInjected.Token(Token = "0x6001869")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB0D8", Offset = "0x1AFB0D8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TripleDES),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "GetResponse", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_LM", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "GetResponse", MemberParameters = new object[] { "System.Byte[]", "System.Byte[]" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DESCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static DES Create()
		{
			throw null;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000183AA File Offset: 0x000165AA
		[global::Cpp2ILInjected.Token(Token = "0x600186A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB20C", Offset = "0x1AFB20C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static DES Create(string algName)
		{
			throw null;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x000183AD File Offset: 0x000165AD
		[global::Cpp2ILInjected.Token(Token = "0x600186B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFAB68", Offset = "0x1AFAB68", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DES), Member = "get_Key", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DES), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESTransform), Member = "GetStrongKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "FixupKeyParity", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static bool IsWeakKey(byte[] rgbKey)
		{
			throw null;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000183B0 File Offset: 0x000165B0
		[global::Cpp2ILInjected.Token(Token = "0x600186C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFACAC", Offset = "0x1AFACAC", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DES), Member = "get_Key", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DES), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESTransform), Member = "GetStrongKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "FixupKeyParity", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static bool IsSemiWeakKey(byte[] rgbKey)
		{
			throw null;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000183B3 File Offset: 0x000165B3
		[global::Cpp2ILInjected.Token(Token = "0x600186D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB2B0", Offset = "0x1AFB2B0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			throw null;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000183B6 File Offset: 0x000165B6
		[global::Cpp2ILInjected.Token(Token = "0x600186E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB2D0", Offset = "0x1AFB2D0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong QuadWordFromBigEndian(byte[] block)
		{
			throw null;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000183B9 File Offset: 0x000165B9
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600186F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB2DC", Offset = "0x1AFB2DC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static DES()
		{
			throw null;
		}

		// Token: 0x040009C9 RID: 2505
		[global::Cpp2ILInjected.Token(Token = "0x4000CA3")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x040009CA RID: 2506
		[global::Cpp2ILInjected.Token(Token = "0x4000CA4")]
		private static KeySizes[] s_legalKeySizes;
	}
}
