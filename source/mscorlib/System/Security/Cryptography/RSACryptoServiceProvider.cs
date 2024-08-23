using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000257 RID: 599
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F4")]
	public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
	{
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x000186AA File Offset: 0x000168AA
		[global::Cpp2ILInjected.Token(Token = "0x170002BB")]
		public override string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001978")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B09554", Offset = "0x1B09554", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x000186AD File Offset: 0x000168AD
		// (set) Token: 0x06001760 RID: 5984 RVA: 0x000186B0 File Offset: 0x000168B0
		[global::Cpp2ILInjected.Token(Token = "0x170002BC")]
		public static bool UseMachineKeyStore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001979")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B09594", Offset = "0x1B09594", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "ImportCspBlob", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600197A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B095E8", Offset = "0x1B095E8", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000186B3 File Offset: 0x000168B3
		[global::Cpp2ILInjected.Token(Token = "0x600197B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0963C", Offset = "0x1B0963C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000186B6 File Offset: 0x000168B6
		[global::Cpp2ILInjected.Token(Token = "0x600197C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B09678", Offset = "0x1B09678", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(byte[]))]
		protected override byte[] HashData(global::System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x000186B9 File Offset: 0x000168B9
		[global::Cpp2ILInjected.Token(Token = "0x600197D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0969C", Offset = "0x1B0969C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static int GetAlgorithmId(HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000186BC File Offset: 0x000168BC
		[global::Cpp2ILInjected.Token(Token = "0x600197E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0982C", Offset = "0x1B0982C", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAEncryptionPadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSAEncryptionPadding),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "PaddingModeNotSupported", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			throw null;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000186BF File Offset: 0x000168BF
		[global::Cpp2ILInjected.Token(Token = "0x600197F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B09B0C", Offset = "0x1B09B0C", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAEncryptionPadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSAEncryptionPadding),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "PaddingModeNotSupported", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			throw null;
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000186C2 File Offset: 0x000168C2
		[global::Cpp2ILInjected.Token(Token = "0x6001980")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B09ED4", Offset = "0x1B09ED4", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "GetAlgorithmId", MemberParameters = new object[] { typeof(HashAlgorithmName) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "PaddingModeNotSupported", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000186C5 File Offset: 0x000168C5
		[global::Cpp2ILInjected.Token(Token = "0x6001981")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A0D4", Offset = "0x1B0A0D4", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "GetAlgorithmId", MemberParameters = new object[] { typeof(HashAlgorithmName) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "PaddingModeNotSupported", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000186C8 File Offset: 0x000168C8
		[global::Cpp2ILInjected.Token(Token = "0x6001982")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B09A8C", Offset = "0x1B09A8C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static global::System.Exception PaddingModeNotSupported()
		{
			throw null;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000186CB File Offset: 0x000168CB
		[global::Cpp2ILInjected.Token(Token = "0x6001983")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07128", Offset = "0x1B07128", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsymmetricAlgorithm), Member = "Create", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public RSACryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x000186CE File Offset: 0x000168CE
		[global::Cpp2ILInjected.Token(Token = "0x6001984")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A348", Offset = "0x1B0A348", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.CryptoConvert", Member = "FromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS8.PrivateKeyInfo", Member = "DecodeRSA", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public RSACryptoServiceProvider(CspParameters parameters)
		{
			throw null;
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x000186D1 File Offset: 0x000168D1
		[global::Cpp2ILInjected.Token(Token = "0x6001985")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A310", Offset = "0x1B0A310", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeRSA", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_RSA", ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public RSACryptoServiceProvider(int dwKeySize)
		{
			throw null;
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000186D4 File Offset: 0x000168D4
		[global::Cpp2ILInjected.Token(Token = "0x6001986")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A354", Offset = "0x1B0A354", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
			throw null;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000186D7 File Offset: 0x000168D7
		[global::Cpp2ILInjected.Token(Token = "0x6001987")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A3B0", Offset = "0x1B0A3B0", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "Create", ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeySizes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "add_KeyGenerated", MemberParameters = new object[] { typeof(Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "get_UseMachineKeyStore", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new object[] { typeof(CspProviderFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void Common(int dwKeySize, bool parameters)
		{
			throw null;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000186DA File Offset: 0x000168DA
		[global::Cpp2ILInjected.Token(Token = "0x6001988")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A5B0", Offset = "0x1B0A5B0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void Common(CspParameters p)
		{
			throw null;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x000186DD File Offset: 0x000168DD
		[global::Cpp2ILInjected.Token(Token = "0x6001989")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A6B4", Offset = "0x1B0A6B4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x000186E0 File Offset: 0x000168E0
		[global::Cpp2ILInjected.Token(Token = "0x170002BD")]
		public override string KeyExchangeAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x600198A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0A754", Offset = "0x1B0A754", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x000186E3 File Offset: 0x000168E3
		[global::Cpp2ILInjected.Token(Token = "0x170002BE")]
		public override int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600198B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0A794", Offset = "0x1B0A794", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x000186E6 File Offset: 0x000168E6
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x000186E9 File Offset: 0x000168E9
		[global::Cpp2ILInjected.Token(Token = "0x170002BF")]
		public bool PersistKeyInCsp
		{
			[global::Cpp2ILInjected.Token(Token = "0x600198C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0A7B4", Offset = "0x1B0A7B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600198D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0A7BC", Offset = "0x1B0A7BC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x000186EC File Offset: 0x000168EC
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170002C0")]
		public bool PublicOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600198E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0A844", Offset = "0x1B0A844", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x000186EF File Offset: 0x000168EF
		[global::Cpp2ILInjected.Token(Token = "0x600198F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B09CC4", Offset = "0x1B09CC4", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAOAEPKeyExchangeDeformatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAPKCS1KeyExchangeDeformatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public byte[] Decrypt(byte[] rgb, bool fOAEP)
		{
			throw null;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000186F2 File Offset: 0x000168F2
		[global::Cpp2ILInjected.Token(Token = "0x6001990")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0AA38", Offset = "0x1B0AA38", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "get_IsCrtPossible", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override byte[] DecryptValue(byte[] rgb)
		{
			throw null;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000186F5 File Offset: 0x000168F5
		[global::Cpp2ILInjected.Token(Token = "0x6001991")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B099E4", Offset = "0x1B099E4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAPKCS1KeyExchangeFormatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public byte[] Encrypt(byte[] rgb, bool fOAEP)
		{
			throw null;
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x000186F8 File Offset: 0x000168F8
		[global::Cpp2ILInjected.Token(Token = "0x6001992")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0ACA8", Offset = "0x1B0ACA8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override byte[] EncryptValue(byte[] rgb)
		{
			throw null;
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000186FB File Offset: 0x000168FB
		[global::Cpp2ILInjected.Token(Token = "0x6001993")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0ACBC", Offset = "0x1B0ACBC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000186FE File Offset: 0x000168FE
		[global::Cpp2ILInjected.Token(Token = "0x6001994")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0ADEC", Offset = "0x1B0ADEC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void ImportParameters(RSAParameters parameters)
		{
			throw null;
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00018701 File Offset: 0x00016901
		[global::Cpp2ILInjected.Token(Token = "0x6001995")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0AE30", Offset = "0x1B0AE30", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(object),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "GetHashFromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private HashAlgorithm GetHash(object halg)
		{
			throw null;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00018704 File Offset: 0x00016904
		[global::Cpp2ILInjected.Token(Token = "0x6001996")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B070", Offset = "0x1B0B070", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "GetHash", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "GetHashNameFromOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private HashAlgorithm GetHashFromString(string name)
		{
			throw null;
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00018707 File Offset: 0x00016907
		[global::Cpp2ILInjected.Token(Token = "0x6001997")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B344", Offset = "0x1B0B344", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public byte[] SignData(byte[] buffer, object halg)
		{
			throw null;
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0001870A File Offset: 0x0001690A
		[global::Cpp2ILInjected.Token(Token = "0x6001998")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B454", Offset = "0x1B0B454", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "GetHash", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public byte[] SignData(global::System.IO.Stream inputStream, object halg)
		{
			throw null;
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0001870D File Offset: 0x0001690D
		[global::Cpp2ILInjected.Token(Token = "0x6001999")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B3A8", Offset = "0x1B0B3A8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "GetHash", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public byte[] SignData(byte[] buffer, int offset, int count, object halg)
		{
			throw null;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00018710 File Offset: 0x00016910
		[global::Cpp2ILInjected.Token(Token = "0x600199A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B180", Offset = "0x1B0B180", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "GetHashFromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private string GetHashNameFromOID(string oid)
		{
			throw null;
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00018713 File Offset: 0x00016913
		[global::Cpp2ILInjected.Token(Token = "0x600199B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B4E8", Offset = "0x1B0B4E8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "GetHashNameFromOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public byte[] SignHash(byte[] rgbHash, string str)
		{
			throw null;
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00018716 File Offset: 0x00016916
		[global::Cpp2ILInjected.Token(Token = "0x600199C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A054", Offset = "0x1B0A054", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "InternalHashToHashAlgorithm", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] SignHash(byte[] rgbHash, int calgHash)
		{
			throw null;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00018719 File Offset: 0x00016919
		[global::Cpp2ILInjected.Token(Token = "0x600199D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B5DC", Offset = "0x1B0B5DC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD5), Member = "Create", ReturnType = typeof(MD5))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384), Member = "Create", ReturnType = typeof(SHA384))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256), Member = "Create", ReturnType = typeof(SHA256))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512), Member = "Create", ReturnType = typeof(SHA512))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static HashAlgorithm InternalHashToHashAlgorithm(int calgHash)
		{
			throw null;
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0001871C File Offset: 0x0001691C
		[global::Cpp2ILInjected.Token(Token = "0x600199E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B7DC", Offset = "0x1B0B7DC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "GetHash", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public bool VerifyData(byte[] buffer, object halg, byte[] signature)
		{
			throw null;
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0001871F File Offset: 0x0001691F
		[global::Cpp2ILInjected.Token(Token = "0x600199F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B8E8", Offset = "0x1B0B8E8", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "CheckSignature", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(string),
			"System.Byte[]"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifySignature", MemberParameters = new object[]
		{
			"Mono.Security.PKCS7.SignedData",
			"System.Byte[]",
			typeof(HashAlgorithm)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "GetHashNameFromOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			throw null;
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00018722 File Offset: 0x00016922
		[global::Cpp2ILInjected.Token(Token = "0x60019A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A280", Offset = "0x1B0A280", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "InternalHashToHashAlgorithm", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool VerifyHash(byte[] rgbHash, int calgHash, byte[] rgbSignature)
		{
			throw null;
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00018725 File Offset: 0x00016925
		[global::Cpp2ILInjected.Token(Token = "0x60019A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0BA08", Offset = "0x1B0BA08", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "Remove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = "Clear", ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00018728 File Offset: 0x00016928
		[global::Cpp2ILInjected.Token(Token = "0x60019A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A7D0", Offset = "0x1B0A7D0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "set_KeyValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
		private void OnKeyGenerated(object sender, global::System.EventArgs e)
		{
			throw null;
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x0001872B File Offset: 0x0001692B
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170002C1")]
		public CspKeyContainerInfo CspKeyContainerInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0BA54", Offset = "0x1B0BA54", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_Parameters", ReturnType = typeof(CspParameters))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0001872E File Offset: 0x0001692E
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60019A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0BAFC", Offset = "0x1B0BAFC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "ToCapiPrivateKeyBlob", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "ToCapiPublicKeyBlob", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_Parameters", ReturnType = typeof(CspParameters))]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00018731 File Offset: 0x00016931
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60019A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0BB64", Offset = "0x1B0BB64", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiKeyBlob", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "get_UseMachineKeyStore", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new object[] { typeof(CspProviderFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void ImportCspBlob(byte[] keyBlob)
		{
			throw null;
		}

		// Token: 0x04000A23 RID: 2595
		[global::Cpp2ILInjected.Token(Token = "0x4000CFD")]
		private static CspProviderFlags s_UseMachineKeyStore;

		// Token: 0x04000A24 RID: 2596
		[global::Cpp2ILInjected.Token(Token = "0x4000CFE")]
		private const int PROV_RSA_FULL = 1;

		// Token: 0x04000A25 RID: 2597
		[global::Cpp2ILInjected.Token(Token = "0x4000CFF")]
		private const int AT_KEYEXCHANGE = 1;

		// Token: 0x04000A26 RID: 2598
		[global::Cpp2ILInjected.Token(Token = "0x4000D00")]
		private const int AT_SIGNATURE = 2;

		// Token: 0x04000A27 RID: 2599
		[global::Cpp2ILInjected.Token(Token = "0x4000D01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Mono.Security.Cryptography.KeyPairPersistence store;

		// Token: 0x04000A28 RID: 2600
		[global::Cpp2ILInjected.Token(Token = "0x4000D02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool persistKey;

		// Token: 0x04000A29 RID: 2601
		[global::Cpp2ILInjected.Token(Token = "0x4000D03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool persisted;

		// Token: 0x04000A2A RID: 2602
		[global::Cpp2ILInjected.Token(Token = "0x4000D04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private bool privateKeyExportable;

		// Token: 0x04000A2B RID: 2603
		[global::Cpp2ILInjected.Token(Token = "0x4000D05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
		private bool m_disposed;

		// Token: 0x04000A2C RID: 2604
		[global::Cpp2ILInjected.Token(Token = "0x4000D06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Mono.Security.Cryptography.RSAManaged rsa;
	}
}
