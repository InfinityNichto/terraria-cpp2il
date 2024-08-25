using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Math.Prime.Generator
{
	[global::Cpp2ILInjected.Token(Token = "0x2000069")]
	public abstract class PrimeGeneratorBase
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
		public abstract BigInteger GenerateNewPrime(int bits);

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
