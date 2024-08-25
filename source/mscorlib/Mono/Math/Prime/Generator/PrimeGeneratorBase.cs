using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Math.Prime.Generator
{
	[global::Cpp2ILInjected.Token(Token = "0x2000056")]
	internal abstract class PrimeGeneratorBase
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600020A")]
		public abstract BigInteger GenerateNewPrime(int bits);

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
