using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Math.Prime
{
	// Token: 0x0200003A RID: 58
	[global::Cpp2ILInjected.Token(Token = "0x2000055")]
	internal sealed class PrimalityTests
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x00014AA4 File Offset: 0x00012CA4
		[global::Cpp2ILInjected.Token(Token = "0x6000203")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC5C4C", Offset = "0x1AC5C4C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "BitCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence)
		{
			throw null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00014AA7 File Offset: 0x00012CA7
		[global::Cpp2ILInjected.Token(Token = "0x6000204")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC4E4C", Offset = "0x1AC4E4C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "IsProbablePrime", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "BitCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		public static bool Test(BigInteger n, ConfidenceFactor confidence)
		{
			throw null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00014AAA File Offset: 0x00012CAA
		[global::Cpp2ILInjected.Token(Token = "0x6000205")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC5F84", Offset = "0x1AC5F84", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "Test", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "BitCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrimalityTests), Member = "GetSPPRounds", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "RightShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "Compare", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger.Sign))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence)
		{
			throw null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00014AAD File Offset: 0x00012CAD
		[global::Cpp2ILInjected.Token(Token = "0x6000206")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC5DD0", Offset = "0x1AC5DD0", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimalityTests), Member = "Test", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrimalityTests), Member = "GetSPPRounds", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(ConfidenceFactor)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "RightShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = ".ctor", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger.ModulusRing), Member = "Pow", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Math.BigInteger.Kernel", Member = "multiByteDivide", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence)
		{
			throw null;
		}
	}
}
