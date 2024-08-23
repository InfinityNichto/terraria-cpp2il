using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000049 RID: 73
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		// Token: 0x06000271 RID: 625 RVA: 0x00003666 File Offset: 0x00001866
		[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA8BDC", Offset = "0x1AA8BDC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual BigInteger GenerateSearchBase(int bits, object context)
		{
			throw null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00003669 File Offset: 0x00001869
		[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA8C4C", Offset = "0x1AA8C4C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override BigInteger GenerateNewPrime(int bits)
		{
			throw null;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000366C File Offset: 0x0000186C
		[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA8C5C", Offset = "0x1AA8C5C", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "Incr2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual BigInteger GenerateNewPrime(int bits, object context)
		{
			throw null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000366F File Offset: 0x0000186F
		[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA8F94", Offset = "0x1AA8F94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context)
		{
			throw null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00003672 File Offset: 0x00001872
		[global::Cpp2ILInjected.Token(Token = "0x60002FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA7998", Offset = "0x1AA7998", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SequentialSearchPrimeGeneratorBase()
		{
			throw null;
		}
	}
}
