using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000048 RID: 72
	[global::Cpp2ILInjected.Token(Token = "0x2000069")]
	public abstract class PrimeGeneratorBase
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000365A File Offset: 0x0000185A
		[global::Cpp2ILInjected.Token(Token = "0x170000C1")]
		public virtual ConfidenceFactor Confidence
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA8B58", Offset = "0x1AA8B58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000365D File Offset: 0x0000185D
		[global::Cpp2ILInjected.Token(Token = "0x170000C2")]
		public virtual PrimalityTest PrimalityTest
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA8B60", Offset = "0x1AA8B60", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrimalityTest), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00003660 File Offset: 0x00001860
		[global::Cpp2ILInjected.Token(Token = "0x170000C3")]
		public virtual int TrialDivisionBounds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA8BCC", Offset = "0x1AA8BCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600026F RID: 623
		[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
		public abstract BigInteger GenerateNewPrime(int bits);

		// Token: 0x06000270 RID: 624 RVA: 0x00003663 File Offset: 0x00001863
		[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA8BD4", Offset = "0x1AA8BD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected PrimeGeneratorBase()
		{
			throw null;
		}
	}
}
