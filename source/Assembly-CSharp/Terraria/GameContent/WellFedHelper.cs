using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent
{
	// Token: 0x02000576 RID: 1398
	[global::Cpp2ILInjected.Token(Token = "0x200080E")]
	public struct WellFedHelper
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x0002C801 File Offset: 0x0002AA01
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

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06003ACF RID: 15055 RVA: 0x0002C804 File Offset: 0x0002AA04
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

		// Token: 0x06003AD0 RID: 15056 RVA: 0x0002C807 File Offset: 0x0002AA07
		[global::Cpp2ILInjected.Token(Token = "0x60041E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x786900", Offset = "0x786900", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Eat(int foodRank, int foodBuffTime)
		{
			throw null;
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x0002C80A File Offset: 0x0002AA0A
		[global::Cpp2ILInjected.Token(Token = "0x60041E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7869D8", Offset = "0x7869D8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x0002C80D File Offset: 0x0002AA0D
		[global::Cpp2ILInjected.Token(Token = "0x60041E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x786A50", Offset = "0x786A50", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x0002C810 File Offset: 0x0002AA10
		[global::Cpp2ILInjected.Token(Token = "0x60041EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7869A4", Offset = "0x7869A4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AddTimeTo(ref int foodTimeCounter, ref int timeLeftToAdd, int counterMaximumTime)
		{
			throw null;
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x0002C813 File Offset: 0x0002AA13
		[global::Cpp2ILInjected.Token(Token = "0x60041EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x786A14", Offset = "0x786A14", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ReduceTimeLeft()
		{
			throw null;
		}

		// Token: 0x04006AD0 RID: 27344
		[global::Cpp2ILInjected.Token(Token = "0x40080AE")]
		private const int MAXIMUM_TIME_LEFT_PER_COUNTER = 72000;

		// Token: 0x04006AD1 RID: 27345
		[global::Cpp2ILInjected.Token(Token = "0x40080AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _timeLeftRank1;

		// Token: 0x04006AD2 RID: 27346
		[global::Cpp2ILInjected.Token(Token = "0x40080B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int _timeLeftRank2;

		// Token: 0x04006AD3 RID: 27347
		[global::Cpp2ILInjected.Token(Token = "0x40080B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int _timeLeftRank3;
	}
}
