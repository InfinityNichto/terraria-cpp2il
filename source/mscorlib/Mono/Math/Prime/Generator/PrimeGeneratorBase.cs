using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x0200003B RID: 59
	[global::Cpp2ILInjected.Token(Token = "0x2000056")]
	internal abstract class PrimeGeneratorBase
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00014AB0 File Offset: 0x00012CB0
		[global::Cpp2ILInjected.Token(Token = "0x17000033")]
		public virtual ConfidenceFactor Confidence
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000207")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC6204", Offset = "0x1AC6204", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00014AB3 File Offset: 0x00012CB3
		[global::Cpp2ILInjected.Token(Token = "0x17000034")]
		public virtual PrimalityTest PrimalityTest
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000208")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC620C", Offset = "0x1AC620C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrimalityTest), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00014AB6 File Offset: 0x00012CB6
		[global::Cpp2ILInjected.Token(Token = "0x17000035")]
		public virtual int TrialDivisionBounds
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000209")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC6278", Offset = "0x1AC6278", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001AE RID: 430
		[global::Cpp2ILInjected.Token(Token = "0x600020A")]
		public abstract BigInteger GenerateNewPrime(int bits);

		// Token: 0x060001AF RID: 431 RVA: 0x00014AB9 File Offset: 0x00012CB9
		[global::Cpp2ILInjected.Token(Token = "0x600020B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6280", Offset = "0x1AC6280", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected PrimeGeneratorBase()
		{
			throw null;
		}
	}
}
