using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography;
using Mono.Math;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x0200024C RID: 588
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002E9")]
	public abstract class RandomNumberGenerator : global::System.IDisposable
	{
		// Token: 0x060016E4 RID: 5860 RVA: 0x00018545 File Offset: 0x00016745
		[global::Cpp2ILInjected.Token(Token = "0x60018FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B012C0", Offset = "0x1B012C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected RandomNumberGenerator()
		{
			throw null;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00018548 File Offset: 0x00016748
		[global::Cpp2ILInjected.Token(Token = "0x60018FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B012C8", Offset = "0x1B012C8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyBuilder), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = "Random", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "get_Random", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.BigInteger), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Cryptography.Helpers), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = "CreateKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeFormatter), Member = "CreateKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestSession", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "get_RNG", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "GetBytes", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "EncryptedContentInfo", MemberParameters = new object[]
		{
			"Mono.Security.ASN1",
			typeof(string)
		}, ReturnType = "Mono.Security.PKCS7.ContentInfo")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2_Session", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]",
			"System.Byte[]&",
			"System.Byte[]&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new object[]
		{
			"Mono.Security.Protocol.Ntlm.Type2Message",
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.KeyBuilder", Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS8.EncryptedPrivateKeyInfo", Member = "get_Salt", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Math.BigInteger", Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static RandomNumberGenerator Create()
		{
			throw null;
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0001854B File Offset: 0x0001674B
		[global::Cpp2ILInjected.Token(Token = "0x6001900")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0131C", Offset = "0x1B0131C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static RandomNumberGenerator Create(string rngName)
		{
			throw null;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0001854E File Offset: 0x0001674E
		[global::Cpp2ILInjected.Token(Token = "0x6001901")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B013C0", Offset = "0x1B013C0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00018551 File Offset: 0x00016751
		[global::Cpp2ILInjected.Token(Token = "0x6001902")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0142C", Offset = "0x1B0142C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060016E9 RID: 5865
		[global::Cpp2ILInjected.Token(Token = "0x6001903")]
		public abstract void GetBytes(byte[] data);

		// Token: 0x060016EA RID: 5866 RVA: 0x00018554 File Offset: 0x00016754
		[global::Cpp2ILInjected.Token(Token = "0x6001904")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01430", Offset = "0x1B01430", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual void GetBytes(byte[] data, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00018557 File Offset: 0x00016757
		[global::Cpp2ILInjected.Token(Token = "0x6001905")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01614", Offset = "0x1B01614", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void GetNonZeroBytes(byte[] data)
		{
			throw null;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0001855A File Offset: 0x0001675A
		[global::Cpp2ILInjected.Token(Token = "0x6001906")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0164C", Offset = "0x1B0164C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Fill(global::System.Span<byte> data)
		{
			throw null;
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0001855D File Offset: 0x0001675D
		[global::Cpp2ILInjected.Token(Token = "0x6001907")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01650", Offset = "0x1B01650", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RandomNumberGenerator), Member = "GetInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "GetPinnableReference", ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetRandomBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static void FillSpan(global::System.Span<byte> data)
		{
			throw null;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00018560 File Offset: 0x00016760
		[global::Cpp2ILInjected.Token(Token = "0x6001908")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B016C8", Offset = "0x1B016C8", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual void GetBytes(global::System.Span<byte> data)
		{
			throw null;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00018563 File Offset: 0x00016763
		[global::Cpp2ILInjected.Token(Token = "0x6001909")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B018C0", Offset = "0x1B018C0", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual void GetNonZeroBytes(global::System.Span<byte> data)
		{
			throw null;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00018566 File Offset: 0x00016766
		[global::Cpp2ILInjected.Token(Token = "0x600190A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01AB0", Offset = "0x1B01AB0", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RandomNumberGenerator), Member = "GetInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "FillSpan", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static int GetInt32(int fromInclusive, int toExclusive)
		{
			throw null;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00018569 File Offset: 0x00016769
		[global::Cpp2ILInjected.Token(Token = "0x600190B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01C40", Offset = "0x1B01C40", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "GetInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int GetInt32(int toExclusive)
		{
			throw null;
		}
	}
}
