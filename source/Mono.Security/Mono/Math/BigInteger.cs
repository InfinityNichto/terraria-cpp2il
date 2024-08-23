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
	// Token: 0x02000044 RID: 68
	[global::Cpp2ILInjected.Token(Token = "0x2000062")]
	public class BigInteger
	{
		// Token: 0x0600023C RID: 572 RVA: 0x000035D0 File Offset: 0x000017D0
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA51C8", Offset = "0x1AA51C8", Length = "0x74")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RandomNumberGenerator)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BigInteger(BigInteger.Sign sign, uint len)
		{
			throw null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000035D3 File Offset: 0x000017D3
		[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA523C", Offset = "0x1AA523C", Length = "0xB4")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BigInteger(BigInteger bi)
		{
			throw null;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000035D6 File Offset: 0x000017D6
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA52F0", Offset = "0x1AA52F0", Length = "0xB0")]
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

		// Token: 0x0600023F RID: 575 RVA: 0x000035D9 File Offset: 0x000017D9
		[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA53A0", Offset = "0x1AA53A0", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BigInteger(byte[] inData)
		{
			throw null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000035DC File Offset: 0x000017DC
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA556C", Offset = "0x1AA556C", Length = "0x74")]
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

		// Token: 0x06000241 RID: 577 RVA: 0x000035DF File Offset: 0x000017DF
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA55E0", Offset = "0x1AA55E0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator BigInteger(uint value)
		{
			throw null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000035E2 File Offset: 0x000017E2
		[global::Cpp2ILInjected.Token(Token = "0x60002B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA5638", Offset = "0x1AA5638", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static implicit operator BigInteger(int value)
		{
			throw null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000035E5 File Offset: 0x000017E5
		[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA56DC", Offset = "0x1AA56DC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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

		// Token: 0x06000244 RID: 580 RVA: 0x000035E8 File Offset: 0x000017E8
		[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA5980", Offset = "0x1AA5980", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Difference", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000035EB File Offset: 0x000017EB
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA5D00", Offset = "0x1AA5D00", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static uint operator %(BigInteger bi, uint ui)
		{
			throw null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000035EE File Offset: 0x000017EE
		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA5D90", Offset = "0x1AA5D90", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger[]))]
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000035F1 File Offset: 0x000017F1
		[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA61C4", Offset = "0x1AA61C4", Length = "0x14")]
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

		// Token: 0x06000248 RID: 584 RVA: 0x000035F4 File Offset: 0x000017F4
		[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA61D8", Offset = "0x1AA61D8", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000035F7 File Offset: 0x000017F7
		[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6490", Offset = "0x1AA6490", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			throw null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000035FA File Offset: 0x000017FA
		[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6610", Offset = "0x1AA6610", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			throw null;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000035FD File Offset: 0x000017FD
		[global::Cpp2ILInjected.Token(Token = "0x170000C0")]
		private static RandomNumberGenerator Rng
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA6770", Offset = "0x1AA6770", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00003600 File Offset: 0x00001800
		[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6818", Offset = "0x1AA6818", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BigInteger.Sign),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng)
		{
			throw null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00003603 File Offset: 0x00001803
		[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6968", Offset = "0x1AA6968", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SequentialSearchPrimeGeneratorBase), Member = "GenerateSearchBase", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RandomNumberGenerator)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static BigInteger GenerateRandom(int bits)
		{
			throw null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00003606 File Offset: 0x00001806
		[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA69C4", Offset = "0x1AA69C4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "get_KeySize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "GetSPPRounds", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public int BitCount()
		{
			throw null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00003609 File Offset: 0x00001809
		[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6A24", Offset = "0x1AA6A24", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool TestBit(int bitNum)
		{
			throw null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000360C File Offset: 0x0000180C
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6AA0", Offset = "0x1AA6AA0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetBit(uint bitNum)
		{
			throw null;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000360F File Offset: 0x0000180F
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6AD0", Offset = "0x1AA6AD0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetBit(uint bitNum, bool value)
		{
			throw null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00003612 File Offset: 0x00001812
		[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6B0C", Offset = "0x1AA6B0C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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

		// Token: 0x06000253 RID: 595 RVA: 0x00003615 File Offset: 0x00001815
		[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6B88", Offset = "0x1AA6B88", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GetPaddedValue", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
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

		// Token: 0x06000254 RID: 596 RVA: 0x00003618 File Offset: 0x00001818
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA57B8", Offset = "0x1AA57B8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		public static bool operator ==(BigInteger bi1, uint ui)
		{
			throw null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000361B File Offset: 0x0000181B
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6C94", Offset = "0x1AA6C94", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static bool operator !=(BigInteger bi1, uint ui)
		{
			throw null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000361E File Offset: 0x0000181E
		[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6CEC", Offset = "0x1AA6CEC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
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

		// Token: 0x06000257 RID: 599 RVA: 0x00003621 File Offset: 0x00001821
		[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6D9C", Offset = "0x1AA6D9C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
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

		// Token: 0x06000258 RID: 600 RVA: 0x00003624 File Offset: 0x00001824
		[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6E4C", Offset = "0x1AA6E4C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00003627 File Offset: 0x00001827
		[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6E64", Offset = "0x1AA6E64", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.Kernel), Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000362A File Offset: 0x0000182A
		[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6E78", Offset = "0x1AA6E78", Length = "0x18")]
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

		// Token: 0x0600025B RID: 603 RVA: 0x0000362D File Offset: 0x0000182D
		[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6E90", Offset = "0x1AA6E90", Length = "0x18")]
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

		// Token: 0x0600025C RID: 604 RVA: 0x00003630 File Offset: 0x00001830
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6EA8", Offset = "0x1AA6EA8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string ToString(uint radix)
		{
			throw null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00003633 File Offset: 0x00001833
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA6F00", Offset = "0x1AA6F00", Length = "0x200")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public string ToString(uint radix, string characterSet)
		{
			throw null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00003636 File Offset: 0x00001836
		[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA5534", Offset = "0x1AA5534", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Normalize()
		{
			throw null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00003639 File Offset: 0x00001839
		[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA7184", Offset = "0x1AA7184", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000363C File Offset: 0x0000183C
		[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA71B8", Offset = "0x1AA71B8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000363F File Offset: 0x0000183F
		[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA71F4", Offset = "0x1AA71F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00003642 File Offset: 0x00001842
		[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA71FC", Offset = "0x1AA71FC", Length = "0x140")]
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

		// Token: 0x06000263 RID: 611 RVA: 0x00003645 File Offset: 0x00001845
		[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA733C", Offset = "0x1AA733C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public BigInteger ModInverse(BigInteger modulus)
		{
			throw null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00003648 File Offset: 0x00001848
		[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA7708", Offset = "0x1AA7708", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
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

		// Token: 0x06000265 RID: 613 RVA: 0x0000364B File Offset: 0x0000184B
		[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA7934", Offset = "0x1AA7934", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static BigInteger GeneratePseudoPrime(int bits)
		{
			throw null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000364E File Offset: 0x0000184E
		[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA79A0", Offset = "0x1AA79A0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SequentialSearchPrimeGeneratorBase), Member = "GenerateNewPrime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Incr2()
		{
			throw null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00003651 File Offset: 0x00001851
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA79F8", Offset = "0x1AA79F8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static BigInteger()
		{
			throw null;
		}

		// Token: 0x0400025F RID: 607
		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint length;

		// Token: 0x04000260 RID: 608
		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private uint[] data;

		// Token: 0x04000261 RID: 609
		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		internal static readonly uint[] smallPrimes;

		// Token: 0x04000262 RID: 610
		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		private static RandomNumberGenerator rng;

		// Token: 0x02000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x2000063")]
		public enum Sign
		{
			// Token: 0x040002CB RID: 715
			[global::Cpp2ILInjected.Token(Token = "0x4000299")]
			Negative = -1,
			// Token: 0x040002CC RID: 716
			[global::Cpp2ILInjected.Token(Token = "0x400029A")]
			Zero,
			// Token: 0x040002CD RID: 717
			[global::Cpp2ILInjected.Token(Token = "0x400029B")]
			Positive
		}

		// Token: 0x02000075 RID: 117
		[global::Cpp2ILInjected.Token(Token = "0x2000064")]
		public sealed class ModulusRing
		{
			// Token: 0x060002F5 RID: 757 RVA: 0x000037EC File Offset: 0x000019EC
			[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA7778", Offset = "0x1AA7778", Length = "0xC0")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
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

			// Token: 0x060002F6 RID: 758 RVA: 0x000037EF File Offset: 0x000019EF
			[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA7A8C", Offset = "0x1AA7A8C", Length = "0x280")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public void BarrettReduction(BigInteger x)
			{
				throw null;
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x000037F2 File Offset: 0x000019F2
			[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA8018", Offset = "0x1AA8018", Length = "0x17C")]
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

			// Token: 0x060002F8 RID: 760 RVA: 0x000037F5 File Offset: 0x000019F5
			[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA8194", Offset = "0x1AA8194", Length = "0x1A8")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public BigInteger Difference(BigInteger a, BigInteger b)
			{
				throw null;
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x000037F8 File Offset: 0x000019F8
			[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA7838", Offset = "0x1AA7838", Length = "0xFC")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(ConfidenceFactor)
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

			// Token: 0x060002FA RID: 762 RVA: 0x000037FB File Offset: 0x000019FB
			[CLSCompliant(false)]
			[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA833C", Offset = "0x1AA833C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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

			// Token: 0x040002CE RID: 718
			[global::Cpp2ILInjected.Token(Token = "0x400029C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private BigInteger mod;

			// Token: 0x040002CF RID: 719
			[global::Cpp2ILInjected.Token(Token = "0x400029D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private BigInteger constant;
		}

		// Token: 0x02000076 RID: 118
		[global::Cpp2ILInjected.Token(Token = "0x2000065")]
		private sealed class Kernel
		{
			// Token: 0x060002FB RID: 763 RVA: 0x000037FE File Offset: 0x000019FE
			[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA5810", Offset = "0x1AA5810", Length = "0x170")]
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

			// Token: 0x060002FC RID: 764 RVA: 0x00003801 File Offset: 0x00001A01
			[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA5BAC", Offset = "0x1AA5BAC", Length = "0x154")]
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

			// Token: 0x060002FD RID: 765 RVA: 0x00003804 File Offset: 0x00001A04
			[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA7E3C", Offset = "0x1AA7E3C", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			public static void MinusEq(BigInteger big, BigInteger small)
			{
				throw null;
			}

			// Token: 0x060002FE RID: 766 RVA: 0x00003807 File Offset: 0x00001A07
			[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA7EFC", Offset = "0x1AA7EFC", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			public static void PlusEq(BigInteger bi1, BigInteger bi2)
			{
				throw null;
			}

			// Token: 0x060002FF RID: 767 RVA: 0x0000380A File Offset: 0x00001A0A
			[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA5AEC", Offset = "0x1AA5AEC", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_GreaterThan", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_LessThan", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
			public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2)
			{
				throw null;
			}

			// Token: 0x06000300 RID: 768 RVA: 0x0000380D File Offset: 0x00001A0D
			[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA7100", Offset = "0x1AA7100", Length = "0x84")]
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

			// Token: 0x06000301 RID: 769 RVA: 0x00003810 File Offset: 0x00001A10
			[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA5D48", Offset = "0x1AA5D48", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static uint DwordMod(BigInteger n, uint d)
			{
				throw null;
			}

			// Token: 0x06000302 RID: 770 RVA: 0x00003813 File Offset: 0x00001A13
			[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA83AC", Offset = "0x1AA83AC", Length = "0x174")]
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

			// Token: 0x06000303 RID: 771 RVA: 0x00003816 File Offset: 0x00001A16
			[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA5DA4", Offset = "0x1AA5DA4", Length = "0x420")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
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

			// Token: 0x06000304 RID: 772 RVA: 0x00003819 File Offset: 0x00001A19
			[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA6494", Offset = "0x1AA6494", Length = "0x17C")]
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

			// Token: 0x06000305 RID: 773 RVA: 0x0000381C File Offset: 0x00001A1C
			[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA6614", Offset = "0x1AA6614", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.Kernel), Member = "multiByteDivide", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(BigInteger)
			}, ReturnType = typeof(BigInteger[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
			{
				typeof(BigInteger),
				typeof(ConfidenceFactor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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

			// Token: 0x06000306 RID: 774 RVA: 0x0000381F File Offset: 0x00001A1F
			[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA6394", Offset = "0x1AA6394", Length = "0xFC")]
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

			// Token: 0x06000307 RID: 775 RVA: 0x00003822 File Offset: 0x00001A22
			[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA7D0C", Offset = "0x1AA7D0C", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger.ModulusRing), Member = "BarrettReduction", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod)
			{
				throw null;
			}

			// Token: 0x06000308 RID: 776 RVA: 0x00003825 File Offset: 0x00001A25
			[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA8520", Offset = "0x1AA8520", Length = "0xF0")]
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

			// Token: 0x06000309 RID: 777 RVA: 0x00003828 File Offset: 0x00001A28
			[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA7340", Offset = "0x1AA7340", Length = "0x3C8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus)
			{
				throw null;
			}
		}
	}
}
