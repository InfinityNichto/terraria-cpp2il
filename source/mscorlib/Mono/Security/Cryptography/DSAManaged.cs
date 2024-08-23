using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000036 RID: 54
	[global::Cpp2ILInjected.Token(Token = "0x200004D")]
	internal class DSAManaged : global::System.Security.Cryptography.DSA
	{
		// Token: 0x06000161 RID: 353 RVA: 0x000149D8 File Offset: 0x00012BD8
		[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1190", Offset = "0x1AC1190", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.DSA), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.KeySizes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public DSAManaged(int dwKeySize)
		{
			throw null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000149DB File Offset: 0x00012BDB
		[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC125C", Offset = "0x1AC125C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000149DE File Offset: 0x00012BDE
		[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC12FC", Offset = "0x1AC12FC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.DSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Generate()
		{
			throw null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000149E1 File Offset: 0x00012BE1
		[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1814", Offset = "0x1AC1814", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSAManaged), Member = "Generate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "Randomize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "ModPow", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void GenerateKeyPair()
		{
			throw null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000149E4 File Offset: 0x00012BE4
		[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC19B0", Offset = "0x1AC19B0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		private void add(byte[] a, byte[] b, int value)
		{
			throw null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000149E7 File Offset: 0x00012BE7
		[global::Cpp2ILInjected.Token(Token = "0x60001AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1348", Offset = "0x1AC1348", Length = "0x4CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSAManaged), Member = "Generate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.SHA1), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSAManaged), Member = "add", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "IsProbablePrime", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(int)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "ModPow", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void GenerateParams(int keyLength)
		{
			throw null;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000149EA File Offset: 0x00012BEA
		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		private global::System.Security.Cryptography.RandomNumberGenerator Random
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC1A0C", Offset = "0x1AC1A0C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000149ED File Offset: 0x00012BED
		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		public override int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC1CF4", Offset = "0x1AC1CF4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "BitCount", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000149F0 File Offset: 0x00012BF0
		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		public override string KeyExchangeAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC1D0C", Offset = "0x1AC1D0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000149F3 File Offset: 0x00012BF3
		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		public bool PublicOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC1D14", Offset = "0x1AC1D14", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "OnKeyGenerated", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.EventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "ImportCspBlob", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Mono.Math.BigInteger),
				typeof(Mono.Math.BigInteger)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000149F6 File Offset: 0x00012BF6
		[global::Cpp2ILInjected.Token(Token = "0x17000031")]
		public override string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC1D88", Offset = "0x1AC1D88", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000149F9 File Offset: 0x00012BF9
		[global::Cpp2ILInjected.Token(Token = "0x60001B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1DC8", Offset = "0x1AC1DC8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.DSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] NormalizeArray(byte[] array)
		{
			throw null;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000149FC File Offset: 0x00012BFC
		[global::Cpp2ILInjected.Token(Token = "0x60001B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1E64", Offset = "0x1AC1E64", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSAManaged), Member = "Generate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSAManaged), Member = "NormalizeArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override global::System.Security.Cryptography.DSAParameters ExportParameters(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000149FF File Offset: 0x00012BFF
		[global::Cpp2ILInjected.Token(Token = "0x60001B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC2104", Offset = "0x1AC2104", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "ModPow", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override void ImportParameters(global::System.Security.Cryptography.DSAParameters parameters)
		{
			throw null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00014A02 File Offset: 0x00012C02
		[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC237C", Offset = "0x1AC237C", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSAManaged), Member = "Generate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "Randomize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "ModPow", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "modInverse", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			throw null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00014A05 File Offset: 0x00012C05
		[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC2668", Offset = "0x1AC2668", Length = "0x460")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "modInverse", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "ModPow", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			throw null;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00014A08 File Offset: 0x00012C08
		[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC2AC8", Offset = "0x1AC2AC8", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000172 RID: 370 RVA: 0x00014A0B File Offset: 0x00012C0B
		// (remove) Token: 0x06000173 RID: 371 RVA: 0x00014A0E File Offset: 0x00012C0E
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		public event DSAManaged.KeyGeneratedEventHandler KeyGenerated
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC2DAC", Offset = "0x1AC2DAC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
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
			[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC2E48", Offset = "0x1AC2E48", Length = "0x9C")]
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

		// Token: 0x040000C3 RID: 195
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool keypairGenerated;

		// Token: 0x040000C4 RID: 196
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool m_disposed;

		// Token: 0x040000C5 RID: 197
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Mono.Math.BigInteger p;

		// Token: 0x040000C6 RID: 198
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Mono.Math.BigInteger q;

		// Token: 0x040000C7 RID: 199
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Mono.Math.BigInteger g;

		// Token: 0x040000C8 RID: 200
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Mono.Math.BigInteger x;

		// Token: 0x040000C9 RID: 201
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Mono.Math.BigInteger y;

		// Token: 0x040000CA RID: 202
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Mono.Math.BigInteger j;

		// Token: 0x040000CB RID: 203
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Mono.Math.BigInteger seed;

		// Token: 0x040000CC RID: 204
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int counter;

		// Token: 0x040000CD RID: 205
		[global::Cpp2ILInjected.Token(Token = "0x400017A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private bool j_missing;

		// Token: 0x040000CE RID: 206
		[global::Cpp2ILInjected.Token(Token = "0x400017B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.Security.Cryptography.RandomNumberGenerator rng;

		// Token: 0x040000CF RID: 207
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400017C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private DSAManaged.KeyGeneratedEventHandler KeyGenerated;

		// Token: 0x0200056C RID: 1388
		// (Invoke) Token: 0x06003F34 RID: 16180
		[global::Cpp2ILInjected.Token(Token = "0x200004E")]
		public delegate void KeyGeneratedEventHandler(object sender, global::System.EventArgs e);
	}
}
