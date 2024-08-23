using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Math.Prime;
using Mono.Math.Prime.Generator;
using Mono.Security.Cryptography;

namespace Mono.Math
{
	// Token: 0x02000037 RID: 55
	[global::Cpp2ILInjected.Token(Token = "0x200004F")]
	internal class BigInteger
	{
		// Token: 0x06000174 RID: 372 RVA: 0x00014A11 File Offset: 0x00012C11
		[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC3028", Offset = "0x1AC3028", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "AddSameSign", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "DwordDivMod", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "LeftShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "RightShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "MultiplyByDword", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Security.Cryptography.RandomNumberGenerator)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BigInteger(BigInteger.Sign sign, uint len)
		{
			throw null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00014A14 File Offset: 0x00012C14
		[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC309C", Offset = "0x1AC309C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "RightShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BigInteger(BigInteger bi)
		{
			throw null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00014A17 File Offset: 0x00012C17
		[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC3150", Offset = "0x1AC3150", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "LeftShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BigInteger(BigInteger bi, uint len)
		{
			throw null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00014A1A File Offset: 0x00012C1A
		[global::Cpp2ILInjected.Token(Token = "0x60001BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABE1EC", Offset = "0x1ABE1EC", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "EncryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.DSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BigInteger(byte[] inData)
		{
			throw null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00014A1D File Offset: 0x00012C1D
		[global::Cpp2ILInjected.Token(Token = "0x60001BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC3238", Offset = "0x1AC3238", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BigInteger(uint ui)
		{
			throw null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00014A20 File Offset: 0x00012C20
		[global::Cpp2ILInjected.Token(Token = "0x60001BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD610", Offset = "0x1ABD610", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "DwordDivMod", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "modInverse", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "IsProbablePrime", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator BigInteger(uint value)
		{
			throw null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00014A23 File Offset: 0x00012C23
		[global::Cpp2ILInjected.Token(Token = "0x60001C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD9F4", Offset = "0x1ABD9F4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.DSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Difference", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "modInverse", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static implicit operator BigInteger(int value)
		{
			throw null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00014A26 File Offset: 0x00012C26
		[global::Cpp2ILInjected.Token(Token = "0x60001C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABE464", Offset = "0x1ABE464", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "AddSameSign", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00014A29 File Offset: 0x00012C29
		[global::Cpp2ILInjected.Token(Token = "0x60001C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABDA98", Offset = "0x1ABDA98", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.DSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Difference", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00014A2C File Offset: 0x00012C2C
		[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD6CC", Offset = "0x1ABD6CC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static uint operator %(BigInteger bi, uint ui)
		{
			throw null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00014A2F File Offset: 0x00012C2F
		[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABDC08", Offset = "0x1ABDC08", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger[]))]
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00014A32 File Offset: 0x00012C32
		[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1CC8", Offset = "0x1AC1CC8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger[]))]
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00014A35 File Offset: 0x00012C35
		[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD7C4", Offset = "0x1ABD7C4", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "modInverse", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BigInteger.Sign),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Multiply", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(uint),
			typeof(uint),
			typeof(uint[]),
			typeof(uint),
			typeof(uint),
			typeof(uint[]),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00014A38 File Offset: 0x00012C38
		[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1BBC", Offset = "0x1AC1BBC", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "MultiplyByDword", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static BigInteger operator *(BigInteger bi, int i)
		{
			throw null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00014A3B File Offset: 0x00012C3B
		[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC3C74", Offset = "0x1AC3C74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			throw null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00014A3E File Offset: 0x00012C3E
		[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC3DF4", Offset = "0x1AC3DF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			throw null;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00014A41 File Offset: 0x00012C41
		[global::Cpp2ILInjected.Token(Token = "0x17000032")]
		private static global::System.Security.Cryptography.RandomNumberGenerator Rng
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC3F54", Offset = "0x1AC3F54", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Randomize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00014A44 File Offset: 0x00012C44
		[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC3FFC", Offset = "0x1AC3FFC", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BigInteger.Sign),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static BigInteger GenerateRandom(int bits, global::System.Security.Cryptography.RandomNumberGenerator rng)
		{
			throw null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00014A47 File Offset: 0x00012C47
		[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABE380", Offset = "0x1ABE380", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.Generator.SequentialSearchPrimeGeneratorBase), Member = "GenerateSearchBase", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Security.Cryptography.RandomNumberGenerator)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static BigInteger GenerateRandom(int bits)
		{
			throw null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00014A4A File Offset: 0x00012C4A
		[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC414C", Offset = "0x1AC414C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Randomize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "BitCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Randomize(global::System.Security.Cryptography.RandomNumberGenerator rng)
		{
			throw null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00014A4D File Offset: 0x00012C4D
		[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC18E4", Offset = "0x1AC18E4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "Randomize", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RandomNumberGenerator) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Randomize()
		{
			throw null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00014A50 File Offset: 0x00012C50
		[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD980", Offset = "0x1ABD980", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "get_KeySize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "get_KeySize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Randomize", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RandomNumberGenerator) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "GetSPPRounds", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "Test", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		public int BitCount()
		{
			throw null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00014A53 File Offset: 0x00012C53
		[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1CA4", Offset = "0x1AC1CA4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool TestBit(uint bitNum)
		{
			throw null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00014A56 File Offset: 0x00012C56
		[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC42B0", Offset = "0x1AC42B0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool TestBit(int bitNum)
		{
			throw null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00014A59 File Offset: 0x00012C59
		[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC432C", Offset = "0x1AC432C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetBit(uint bitNum)
		{
			throw null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00014A5C File Offset: 0x00012C5C
		[global::Cpp2ILInjected.Token(Token = "0x60001D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC435C", Offset = "0x1AC435C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetBit(uint bitNum, bool value)
		{
			throw null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00014A5F File Offset: 0x00012C5F
		[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC4398", Offset = "0x1AC4398", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int LowestSetBit()
		{
			throw null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00014A62 File Offset: 0x00012C62
		[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABEA68", Offset = "0x1ABEA68", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GetPaddedValue", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.DSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "BitCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public byte[] GetBytes()
		{
			throw null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00014A65 File Offset: 0x00012C65
		[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1940", Offset = "0x1AC1940", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Randomize", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RandomNumberGenerator) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "IsProbablePrime", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		public static bool operator ==(BigInteger bi1, uint ui)
		{
			throw null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00014A68 File Offset: 0x00012C68
		[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC20AC", Offset = "0x1AC20AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.DSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "modInverse", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static bool operator !=(BigInteger bi1, uint ui)
		{
			throw null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00014A6B File Offset: 0x00012C6B
		[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABDD90", Offset = "0x1ABDD90", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.DSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00014A6E File Offset: 0x00012C6E
		[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD714", Offset = "0x1ABD714", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator !=(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00014A71 File Offset: 0x00012C71
		[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABE44C", Offset = "0x1ABE44C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00014A74 File Offset: 0x00012C74
		[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD9E0", Offset = "0x1ABD9E0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00014A77 File Offset: 0x00012C77
		[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1998", Offset = "0x1AC1998", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		public static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00014A7A File Offset: 0x00012C7A
		[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1CDC", Offset = "0x1AC1CDC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		public static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00014A7D File Offset: 0x00012C7D
		[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC4414", Offset = "0x1AC4414", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string ToString(uint radix)
		{
			throw null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00014A80 File Offset: 0x00012C80
		[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC446C", Offset = "0x1AC446C", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "SingleByteDivideInPlace", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public string ToString(uint radix, string characterSet)
		{
			throw null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00014A83 File Offset: 0x00012C83
		[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC3200", Offset = "0x1AC3200", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Normalize()
		{
			throw null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00014A86 File Offset: 0x00012C86
		[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABE540", Offset = "0x1ABE540", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00014A89 File Offset: 0x00012C89
		[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC4744", Offset = "0x1AC4744", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00014A8C File Offset: 0x00012C8C
		[global::Cpp2ILInjected.Token(Token = "0x60001E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC4780", Offset = "0x1AC4780", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00014A8F File Offset: 0x00012C8F
		[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC4788", Offset = "0x1AC4788", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00014A92 File Offset: 0x00012C92
		[global::Cpp2ILInjected.Token(Token = "0x60001E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABDC04", Offset = "0x1ABDC04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "modInverse", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		public BigInteger ModInverse(BigInteger modulus)
		{
			throw null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00014A95 File Offset: 0x00012C95
		[global::Cpp2ILInjected.Token(Token = "0x60001E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABE3DC", Offset = "0x1ABE3DC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "EncryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.DSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			throw null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00014A98 File Offset: 0x00012C98
		[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC1A2C", Offset = "0x1AC1A2C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "Test", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(Mono.Math.Prime.ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool IsProbablePrime()
		{
			throw null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00014A9B File Offset: 0x00012C9B
		[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD668", Offset = "0x1ABD668", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static BigInteger GeneratePseudoPrime(int bits)
		{
			throw null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00014A9E File Offset: 0x00012C9E
		[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC4E98", Offset = "0x1AC4E98", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.Generator.SequentialSearchPrimeGeneratorBase), Member = "GenerateNewPrime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Incr2()
		{
			throw null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00014AA1 File Offset: 0x00012CA1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC4EF0", Offset = "0x1AC4EF0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static BigInteger()
		{
			throw null;
		}

		// Token: 0x040000D0 RID: 208
		[global::Cpp2ILInjected.Token(Token = "0x400017D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint length;

		// Token: 0x040000D1 RID: 209
		[global::Cpp2ILInjected.Token(Token = "0x400017E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private uint[] data;

		// Token: 0x040000D2 RID: 210
		[global::Cpp2ILInjected.Token(Token = "0x400017F")]
		internal static readonly uint[] smallPrimes;

		// Token: 0x040000D3 RID: 211
		[global::Cpp2ILInjected.Token(Token = "0x4000180")]
		private static global::System.Security.Cryptography.RandomNumberGenerator rng;

		// Token: 0x0200056D RID: 1389
		[global::Cpp2ILInjected.Token(Token = "0x2000050")]
		public enum Sign
		{
			// Token: 0x04001755 RID: 5973
			[global::Cpp2ILInjected.Token(Token = "0x4000182")]
			Negative = -1,
			// Token: 0x04001756 RID: 5974
			[global::Cpp2ILInjected.Token(Token = "0x4000183")]
			Zero,
			// Token: 0x04001757 RID: 5975
			[global::Cpp2ILInjected.Token(Token = "0x4000184")]
			Positive
		}

		// Token: 0x0200056E RID: 1390
		[global::Cpp2ILInjected.Token(Token = "0x2000051")]
		internal sealed class ModulusRing
		{
			// Token: 0x06003F35 RID: 16181 RVA: 0x0001F865 File Offset: 0x0001DA65
			[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC4C90", Offset = "0x1AC4C90", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Math.BigInteger.Kernel", Member = "modInverse", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(Mono.Math.Prime.ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(Mono.Math.Prime.ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger.Sign),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "multiByteDivide", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public ModulusRing(BigInteger modulus)
			{
				throw null;
			}

			// Token: 0x06003F36 RID: 16182 RVA: 0x0001F868 File Offset: 0x0001DA68
			[global::Cpp2ILInjected.Token(Token = "0x60001EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC4F84", Offset = "0x1AC4F84", Length = "0x280")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Multiply", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Difference", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger.Sign),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Multiply", MemberParameters = new object[]
			{
				typeof(uint[]),
				typeof(uint),
				typeof(uint),
				typeof(uint[]),
				typeof(uint),
				typeof(uint),
				typeof(uint[]),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "MultiplyMod2p32pmod", MemberParameters = new object[]
			{
				typeof(uint[]),
				typeof(int),
				typeof(int),
				typeof(uint[]),
				typeof(int),
				typeof(int),
				typeof(uint[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger.Sign))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "MinusEq", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "PlusEq", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public void BarrettReduction(BigInteger x)
			{
				throw null;
			}

			// Token: 0x06003F37 RID: 16183 RVA: 0x0001F86B File Offset: 0x0001DA6B
			[global::Cpp2ILInjected.Token(Token = "0x60001ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC5510", Offset = "0x1AC5510", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(uint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger.Sign))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "multiByteDivide", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public BigInteger Multiply(BigInteger a, BigInteger b)
			{
				throw null;
			}

			// Token: 0x06003F38 RID: 16184 RVA: 0x0001F86E File Offset: 0x0001DA6E
			[global::Cpp2ILInjected.Token(Token = "0x60001EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC568C", Offset = "0x1AC568C", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Math.BigInteger.Kernel", Member = "modInverse", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger.Sign))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "multiByteDivide", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public BigInteger Difference(BigInteger a, BigInteger b)
			{
				throw null;
			}

			// Token: 0x06003F39 RID: 16185 RVA: 0x0001F871 File Offset: 0x0001DA71
			[global::Cpp2ILInjected.Token(Token = "0x60001EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC4D50", Offset = "0x1AC4D50", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
			{
				typeof(uint),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(Mono.Math.Prime.ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(uint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "BitCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = "Multiply", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public BigInteger Pow(BigInteger a, BigInteger k)
			{
				throw null;
			}

			// Token: 0x06003F3A RID: 16186 RVA: 0x0001F874 File Offset: 0x0001DA74
			[global::Cpp2ILInjected.Token(Token = "0x60001F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC5834", Offset = "0x1AC5834", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(Mono.Math.Prime.ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(Mono.Math.Prime.ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public BigInteger Pow(uint b, BigInteger exp)
			{
				throw null;
			}

			// Token: 0x04001758 RID: 5976
			[global::Cpp2ILInjected.Token(Token = "0x4000185")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private BigInteger mod;

			// Token: 0x04001759 RID: 5977
			[global::Cpp2ILInjected.Token(Token = "0x4000186")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private BigInteger constant;
		}

		// Token: 0x0200056F RID: 1391
		[global::Cpp2ILInjected.Token(Token = "0x2000052")]
		private sealed class Kernel
		{
			// Token: 0x06003F3B RID: 16187 RVA: 0x0001F877 File Offset: 0x0001DA77
			[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC32AC", Offset = "0x1AC32AC", Length = "0x170")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger.Sign),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2)
			{
				throw null;
			}

			// Token: 0x06003F3C RID: 16188 RVA: 0x0001F87A File Offset: 0x0001DA7A
			[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC34DC", Offset = "0x1AC34DC", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger.Sign),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static BigInteger Subtract(BigInteger big, BigInteger small)
			{
				throw null;
			}

			// Token: 0x06003F3D RID: 16189 RVA: 0x0001F87D File Offset: 0x0001DA7D
			[global::Cpp2ILInjected.Token(Token = "0x60001F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC5334", Offset = "0x1AC5334", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			public static void MinusEq(BigInteger big, BigInteger small)
			{
				throw null;
			}

			// Token: 0x06003F3E RID: 16190 RVA: 0x0001F880 File Offset: 0x0001DA80
			[global::Cpp2ILInjected.Token(Token = "0x60001F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC53F4", Offset = "0x1AC53F4", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			public static void PlusEq(BigInteger bi1, BigInteger bi2)
			{
				throw null;
			}

			// Token: 0x06003F3F RID: 16191 RVA: 0x0001F883 File Offset: 0x0001DA83
			[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC341C", Offset = "0x1AC341C", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
			public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2)
			{
				throw null;
			}

			// Token: 0x06003F40 RID: 16192 RVA: 0x0001F886 File Offset: 0x0001DA86
			[global::Cpp2ILInjected.Token(Token = "0x60001F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC4684", Offset = "0x1AC4684", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new object[]
			{
				typeof(uint),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			public static uint SingleByteDivideInPlace(BigInteger n, uint d)
			{
				throw null;
			}

			// Token: 0x06003F41 RID: 16193 RVA: 0x0001F889 File Offset: 0x0001DA89
			[global::Cpp2ILInjected.Token(Token = "0x60001F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC3630", Offset = "0x1AC3630", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static uint DwordMod(BigInteger n, uint d)
			{
				throw null;
			}

			// Token: 0x06003F42 RID: 16194 RVA: 0x0001F88C File Offset: 0x0001DA8C
			[global::Cpp2ILInjected.Token(Token = "0x60001F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC58A4", Offset = "0x1AC58A4", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger.Sign),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public static BigInteger[] DwordDivMod(BigInteger n, uint d)
			{
				throw null;
			}

			// Token: 0x06003F43 RID: 16195 RVA: 0x0001F88F File Offset: 0x0001DA8F
			[global::Cpp2ILInjected.Token(Token = "0x60001F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC3678", Offset = "0x1AC3678", Length = "0x420")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RSAParameters) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "GenerateParams", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.DSAParameters) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "VerifySignature", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(byte[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Multiply", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Difference", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "modInverse", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Division", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(Mono.Math.Prime.ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger.Sign))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "DwordDivMod", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(uint)
			}, ReturnType = typeof(BigInteger[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger.Sign),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "LeftShift", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(int)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "RightShift", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(int)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2)
			{
				throw null;
			}

			// Token: 0x06003F44 RID: 16196 RVA: 0x0001F892 File Offset: 0x0001DA92
			[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC3C78", Offset = "0x1AC3C78", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger.Sign),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public static BigInteger LeftShift(BigInteger bi, int n)
			{
				throw null;
			}

			// Token: 0x06003F45 RID: 16197 RVA: 0x0001F895 File Offset: 0x0001DA95
			[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC3DF8", Offset = "0x1AC3DF8", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(Mono.Math.Prime.ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.Prime.PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(Mono.Math.Prime.ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger.Sign),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public static BigInteger RightShift(BigInteger bi, int n)
			{
				throw null;
			}

			// Token: 0x06003F46 RID: 16198 RVA: 0x0001F898 File Offset: 0x0001DA98
			[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC3B94", Offset = "0x1AC3B94", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(int)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BigInteger.Sign),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static BigInteger MultiplyByDword(BigInteger n, uint f)
			{
				throw null;
			}

			// Token: 0x06003F47 RID: 16199 RVA: 0x0001F89B File Offset: 0x0001DA9B
			[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC3A98", Offset = "0x1AC3A98", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset)
			{
				throw null;
			}

			// Token: 0x06003F48 RID: 16200 RVA: 0x0001F89E File Offset: 0x0001DA9E
			[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC5204", Offset = "0x1AC5204", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod)
			{
				throw null;
			}

			// Token: 0x06003F49 RID: 16201 RVA: 0x0001F8A1 File Offset: 0x0001DAA1
			[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC5A18", Offset = "0x1AC5A18", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "modInverse", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static uint modInverse(BigInteger bi, uint modulus)
			{
				throw null;
			}

			// Token: 0x06003F4A RID: 16202 RVA: 0x0001F8A4 File Offset: 0x0001DAA4
			[global::Cpp2ILInjected.Token(Token = "0x6000200")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC48C8", Offset = "0x1AC48C8", Length = "0x3C8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RSAParameters) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "VerifySignature", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(byte[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ModInverse", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "modInverse", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(uint)
			}, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(uint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = "Difference", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus)
			{
				throw null;
			}
		}
	}
}
