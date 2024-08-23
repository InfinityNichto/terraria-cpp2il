using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000034 RID: 52
	[global::Cpp2ILInjected.Token(Token = "0x200004A")]
	internal class RSAManaged : global::System.Security.Cryptography.RSA
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00014963 File Offset: 0x00012B63
		[global::Cpp2ILInjected.Token(Token = "0x600017B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD1D4", Offset = "0x1ABD1D4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.RSA), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.KeySizes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public RSAManaged(int keySize)
		{
			throw null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00014966 File Offset: 0x00012B66
		[global::Cpp2ILInjected.Token(Token = "0x600017C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD2B0", Offset = "0x1ABD2B0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00014969 File Offset: 0x00012B69
		[global::Cpp2ILInjected.Token(Token = "0x600017D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD350", Offset = "0x1ABD350", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "GeneratePseudoPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "BitCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "modInverse", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void GenerateKeyPair()
		{
			throw null;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0001496C File Offset: 0x00012B6C
		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		public override int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABDC1C", Offset = "0x1ABDC1C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "BitCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0001496F File Offset: 0x00012B6F
		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		public override string KeyExchangeAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABDCB0", Offset = "0x1ABDCB0", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00014972 File Offset: 0x00012B72
		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		public bool PublicOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000180")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABDCF0", Offset = "0x1ABDCF0", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "OnKeyGenerated", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.EventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "ImportCspBlob", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Mono.Math.BigInteger),
				typeof(Mono.Math.BigInteger)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00014975 File Offset: 0x00012B75
		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		public override string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000181")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABDE40", Offset = "0x1ABDE40", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00014978 File Offset: 0x00012B78
		[global::Cpp2ILInjected.Token(Token = "0x6000182")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABDE80", Offset = "0x1ABDE80", Length = "0x36C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "BitCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "ModPow", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "modInverse", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GetPaddedValue", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override byte[] DecryptValue(byte[] rgb)
		{
			throw null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0001497B File Offset: 0x00012B7B
		[global::Cpp2ILInjected.Token(Token = "0x6000183")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABE618", Offset = "0x1ABE618", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "ModPow", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GetPaddedValue", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override byte[] EncryptValue(byte[] rgb)
		{
			throw null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0001497E File Offset: 0x00012B7E
		[global::Cpp2ILInjected.Token(Token = "0x6000184")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABE75C", Offset = "0x1ABE75C", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "GetPaddedValue", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override global::System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00014981 File Offset: 0x00012B81
		[global::Cpp2ILInjected.Token(Token = "0x6000185")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABEB74", Offset = "0x1ABEB74", Length = "0x42C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "modInverse", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override void ImportParameters(global::System.Security.Cryptography.RSAParameters parameters)
		{
			throw null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00014984 File Offset: 0x00012B84
		[global::Cpp2ILInjected.Token(Token = "0x6000186")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABEFA0", Offset = "0x1ABEFA0", Length = "0x340")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000145 RID: 325 RVA: 0x00014987 File Offset: 0x00012B87
		// (remove) Token: 0x06000146 RID: 326 RVA: 0x0001498A File Offset: 0x00012B8A
		[global::Cpp2ILInjected.Token(Token = "0x14000001")]
		public event RSAManaged.KeyGeneratedEventHandler KeyGenerated
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000187")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABF2E0", Offset = "0x1ABF2E0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(global::System.Delegate)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000188")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABF37C", Offset = "0x1ABF37C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(global::System.Delegate)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001498D File Offset: 0x00012B8D
		[global::Cpp2ILInjected.Token(Token = "0x6000189")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABF418", Offset = "0x1ABF418", Length = "0x680")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public override string ToXmlString(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00014990 File Offset: 0x00012B90
		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		public bool IsCrtPossible
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABFA98", Offset = "0x1ABFA98", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00014993 File Offset: 0x00012B93
		[global::Cpp2ILInjected.Token(Token = "0x600018B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABE574", Offset = "0x1ABE574", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] GetPaddedValue(Mono.Math.BigInteger value, int length)
		{
			throw null;
		}

		// Token: 0x040000AA RID: 170
		[global::Cpp2ILInjected.Token(Token = "0x4000157")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool isCRTpossible;

		// Token: 0x040000AB RID: 171
		[global::Cpp2ILInjected.Token(Token = "0x4000158")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool keyBlinding;

		// Token: 0x040000AC RID: 172
		[global::Cpp2ILInjected.Token(Token = "0x4000159")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		private bool keypairGenerated;

		// Token: 0x040000AD RID: 173
		[global::Cpp2ILInjected.Token(Token = "0x400015A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x23")]
		private bool m_disposed;

		// Token: 0x040000AE RID: 174
		[global::Cpp2ILInjected.Token(Token = "0x400015B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Mono.Math.BigInteger d;

		// Token: 0x040000AF RID: 175
		[global::Cpp2ILInjected.Token(Token = "0x400015C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Mono.Math.BigInteger p;

		// Token: 0x040000B0 RID: 176
		[global::Cpp2ILInjected.Token(Token = "0x400015D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Mono.Math.BigInteger q;

		// Token: 0x040000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x400015E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Mono.Math.BigInteger dp;

		// Token: 0x040000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Mono.Math.BigInteger dq;

		// Token: 0x040000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Mono.Math.BigInteger qInv;

		// Token: 0x040000B4 RID: 180
		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Mono.Math.BigInteger n;

		// Token: 0x040000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Mono.Math.BigInteger e;

		// Token: 0x040000B6 RID: 182
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private RSAManaged.KeyGeneratedEventHandler KeyGenerated;

		// Token: 0x0200056B RID: 1387
		// (Invoke) Token: 0x06003F32 RID: 16178
		[global::Cpp2ILInjected.Token(Token = "0x200004B")]
		public delegate void KeyGeneratedEventHandler(object sender, global::System.EventArgs e);
	}
}
