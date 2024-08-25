using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x200080E")]
	public struct WellFedHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007C2")]
		public int TimeLeft
		{
			[global::Cpp2ILInjected.Token(Token = "0x60041E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7868B4", Offset = "0x7868B4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007C3")]
		public int Rank
		{
			[global::Cpp2ILInjected.Token(Token = "0x60041E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7868C8", Offset = "0x7868C8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x786900", Offset = "0x786900", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Eat(int foodRank, int foodBuffTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7869D8", Offset = "0x7869D8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x786A50", Offset = "0x786A50", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7869A4", Offset = "0x7869A4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AddTimeTo(ref int foodTimeCounter, ref int timeLeftToAdd, int counterMaximumTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x786A14", Offset = "0x786A14", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ReduceTimeLeft()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40080AE")]
		private const int MAXIMUM_TIME_LEFT_PER_COUNTER = 72000;

		[global::Cpp2ILInjected.Token(Token = "0x40080AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _timeLeftRank1;

		[global::Cpp2ILInjected.Token(Token = "0x40080B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int _timeLeftRank2;

		[global::Cpp2ILInjected.Token(Token = "0x40080B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int _timeLeftRank3;
	}
}
