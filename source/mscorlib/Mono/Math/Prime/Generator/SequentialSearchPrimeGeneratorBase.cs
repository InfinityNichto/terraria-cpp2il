using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x0200003C RID: 60
	[global::Cpp2ILInjected.Token(Token = "0x2000057")]
	internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x00014ABC File Offset: 0x00012CBC
		[global::Cpp2ILInjected.Token(Token = "0x600020C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6288", Offset = "0x1AC6288", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual BigInteger GenerateSearchBase(int bits, object context)
		{
			throw null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00014ABF File Offset: 0x00012CBF
		[global::Cpp2ILInjected.Token(Token = "0x600020D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC62F8", Offset = "0x1AC62F8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override BigInteger GenerateNewPrime(int bits)
		{
			throw null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00014AC2 File Offset: 0x00012CC2
		[global::Cpp2ILInjected.Token(Token = "0x600020E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6308", Offset = "0x1AC6308", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "Incr2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual BigInteger GenerateNewPrime(int bits, object context)
		{
			throw null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00014AC5 File Offset: 0x00012CC5
		[global::Cpp2ILInjected.Token(Token = "0x600020F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6640", Offset = "0x1AC6640", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context)
		{
			throw null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00014AC8 File Offset: 0x00012CC8
		[global::Cpp2ILInjected.Token(Token = "0x6000210")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC4E90", Offset = "0x1AC4E90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SequentialSearchPrimeGeneratorBase()
		{
			throw null;
		}
	}
}
