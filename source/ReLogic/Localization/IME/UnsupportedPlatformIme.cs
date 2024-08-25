using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Localization.IME
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B32")]
	public class UnsupportedPlatformIme : PlatformIme
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700090A")]
		public override uint CandidateCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60053A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x944D4C", Offset = "0x944D4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700090B")]
		public override string CompositionString
		{
			[global::Cpp2ILInjected.Token(Token = "0x60053A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x944D54", Offset = "0x944D54", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700090C")]
		public override bool IsCandidateListVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x60053A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x944D9C", Offset = "0x944D9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700090D")]
		public override uint SelectedCandidate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60053A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x944DA4", Offset = "0x944DA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60053A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x944DAC", Offset = "0x944DAC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string GetCandidate(uint index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60053A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x944DF4", Offset = "0x944DF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformIme), Member = ".ctor", ReturnType = typeof(void))]
		public UnsupportedPlatformIme()
		{
			throw null;
		}
	}
}
