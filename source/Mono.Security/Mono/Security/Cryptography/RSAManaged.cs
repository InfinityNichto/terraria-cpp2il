using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Math;
using Mono.Security.Authenticode;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000040 RID: 64
	[global::Cpp2ILInjected.Token(Token = "0x200005D")]
	public class RSAManaged : RSA
	{
		// Token: 0x06000215 RID: 533 RVA: 0x0000355B File Offset: 0x0000175B
		[global::Cpp2ILInjected.Token(Token = "0x6000285")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA0AA0", Offset = "0x1AA0AA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new object[]
		{
			typeof(PKCS7.SignerInfo),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public RSAManaged()
		{
			throw null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000355E File Offset: 0x0000175E
		[global::Cpp2ILInjected.Token(Token = "0x6000286")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA0AA8", Offset = "0x1AA0AA8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeySizes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public RSAManaged(int keySize)
		{
			throw null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00003561 File Offset: 0x00001761
		[global::Cpp2ILInjected.Token(Token = "0x6000287")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA0B84", Offset = "0x1AA0B84", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00003564 File Offset: 0x00001764
		[global::Cpp2ILInjected.Token(Token = "0x6000288")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA0C24", Offset = "0x1AA0C24", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GeneratePseudoPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "BitCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "ModInverse", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void GenerateKeyPair()
		{
			throw null;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00003567 File Offset: 0x00001767
		[global::Cpp2ILInjected.Token(Token = "0x170000B8")]
		public override int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000289")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA0EC0", Offset = "0x1AA0EC0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "BitCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000356A File Offset: 0x0000176A
		[global::Cpp2ILInjected.Token(Token = "0x170000B9")]
		public override string KeyExchangeAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA0F58", Offset = "0x1AA0F58", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000356D File Offset: 0x0000176D
		[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
		public bool PublicOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA0F98", Offset = "0x1AA0F98", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00003570 File Offset: 0x00001770
		[global::Cpp2ILInjected.Token(Token = "0x170000BB")]
		public override string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA1040", Offset = "0x1AA1040", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003573 File Offset: 0x00001773
		[global::Cpp2ILInjected.Token(Token = "0x600028D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA1080", Offset = "0x1AA1080", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "BitCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "ModInverse", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GetPaddedValue", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override byte[] DecryptValue(byte[] rgb)
		{
			throw null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00003576 File Offset: 0x00001776
		[global::Cpp2ILInjected.Token(Token = "0x600028E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA147C", Offset = "0x1AA147C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GetPaddedValue", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override byte[] EncryptValue(byte[] rgb)
		{
			throw null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00003579 File Offset: 0x00001779
		[global::Cpp2ILInjected.Token(Token = "0x600028F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA1588", Offset = "0x1AA1588", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GetPaddedValue", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000357C File Offset: 0x0000177C
		[global::Cpp2ILInjected.Token(Token = "0x6000290")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA18BC", Offset = "0x1AA18BC", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "ModInverse", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override void ImportParameters(RSAParameters parameters)
		{
			throw null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000357F File Offset: 0x0000177F
		[global::Cpp2ILInjected.Token(Token = "0x6000291")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA1D58", Offset = "0x1AA1D58", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00003582 File Offset: 0x00001782
		[global::Cpp2ILInjected.Token(Token = "0x6000292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA1F78", Offset = "0x1AA1F78", Length = "0x680")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public override string ToXmlString(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00003585 File Offset: 0x00001785
		[global::Cpp2ILInjected.Token(Token = "0x6000293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA13D4", Offset = "0x1AA13D4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] GetPaddedValue(BigInteger value, int length)
		{
			throw null;
		}

		// Token: 0x04000238 RID: 568
		[global::Cpp2ILInjected.Token(Token = "0x400026D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool isCRTpossible;

		// Token: 0x04000239 RID: 569
		[global::Cpp2ILInjected.Token(Token = "0x400026E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool keyBlinding;

		// Token: 0x0400023A RID: 570
		[global::Cpp2ILInjected.Token(Token = "0x400026F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		private bool keypairGenerated;

		// Token: 0x0400023B RID: 571
		[global::Cpp2ILInjected.Token(Token = "0x4000270")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x23")]
		private bool m_disposed;

		// Token: 0x0400023C RID: 572
		[global::Cpp2ILInjected.Token(Token = "0x4000271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private BigInteger d;

		// Token: 0x0400023D RID: 573
		[global::Cpp2ILInjected.Token(Token = "0x4000272")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private BigInteger p;

		// Token: 0x0400023E RID: 574
		[global::Cpp2ILInjected.Token(Token = "0x4000273")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private BigInteger q;

		// Token: 0x0400023F RID: 575
		[global::Cpp2ILInjected.Token(Token = "0x4000274")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private BigInteger dp;

		// Token: 0x04000240 RID: 576
		[global::Cpp2ILInjected.Token(Token = "0x4000275")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private BigInteger dq;

		// Token: 0x04000241 RID: 577
		[global::Cpp2ILInjected.Token(Token = "0x4000276")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private BigInteger qInv;

		// Token: 0x04000242 RID: 578
		[global::Cpp2ILInjected.Token(Token = "0x4000277")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private BigInteger n;

		// Token: 0x04000243 RID: 579
		[global::Cpp2ILInjected.Token(Token = "0x4000278")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private BigInteger e;

		// Token: 0x04000244 RID: 580
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000279")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private RSAManaged.KeyGeneratedEventHandler KeyGenerated;

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060002F4 RID: 756
		[global::Cpp2ILInjected.Token(Token = "0x200005E")]
		public delegate void KeyGeneratedEventHandler(object sender, EventArgs e);
	}
}
