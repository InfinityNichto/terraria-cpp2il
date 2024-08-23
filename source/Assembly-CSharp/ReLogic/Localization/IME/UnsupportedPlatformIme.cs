using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000733 RID: 1843
	[global::Cpp2ILInjected.Token(Token = "0x2000B32")]
	public class UnsupportedPlatformIme : PlatformIme
	{
		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x0002EACF File Offset: 0x0002CCCF
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x0002EAD2 File Offset: 0x0002CCD2
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

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x0002EAD5 File Offset: 0x0002CCD5
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

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060046F0 RID: 18160 RVA: 0x0002EAD8 File Offset: 0x0002CCD8
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

		// Token: 0x060046F1 RID: 18161 RVA: 0x0002EADB File Offset: 0x0002CCDB
		[global::Cpp2ILInjected.Token(Token = "0x60053A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x944DAC", Offset = "0x944DAC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string GetCandidate(uint index)
		{
			throw null;
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x0002EADE File Offset: 0x0002CCDE
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
