using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000730 RID: 1840
	[global::Cpp2ILInjected.Token(Token = "0x2000B2F")]
	internal class FnaIme : PlatformIme
	{
		// Token: 0x060046C8 RID: 18120 RVA: 0x0002EA8D File Offset: 0x0002CC8D
		[global::Cpp2ILInjected.Token(Token = "0x600537D")]
		[global::Cpp2ILInjected.Address(RVA = "0x944750", Offset = "0x944750", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public FnaIme()
		{
			throw null;
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x0002EA90 File Offset: 0x0002CC90
		[global::Cpp2ILInjected.Token(Token = "0x600537E")]
		[global::Cpp2ILInjected.Address(RVA = "0x9447D8", Offset = "0x9447D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnCharCallback(char key)
		{
			throw null;
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x0002EA93 File Offset: 0x0002CC93
		[global::Cpp2ILInjected.Token(Token = "0x170008FC")]
		public override uint CandidateCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600537F")]
			[global::Cpp2ILInjected.Address(RVA = "0x944928", Offset = "0x944928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x0002EA96 File Offset: 0x0002CC96
		[global::Cpp2ILInjected.Token(Token = "0x170008FD")]
		public override string CompositionString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005380")]
			[global::Cpp2ILInjected.Address(RVA = "0x944930", Offset = "0x944930", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x0002EA99 File Offset: 0x0002CC99
		[global::Cpp2ILInjected.Token(Token = "0x170008FE")]
		public override bool IsCandidateListVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005381")]
			[global::Cpp2ILInjected.Address(RVA = "0x944978", Offset = "0x944978", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x0002EA9C File Offset: 0x0002CC9C
		[global::Cpp2ILInjected.Token(Token = "0x170008FF")]
		public override uint SelectedCandidate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005382")]
			[global::Cpp2ILInjected.Address(RVA = "0x944980", Offset = "0x944980", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x0002EA9F File Offset: 0x0002CC9F
		[global::Cpp2ILInjected.Token(Token = "0x6005383")]
		[global::Cpp2ILInjected.Address(RVA = "0x944988", Offset = "0x944988", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string GetCandidate(uint index)
		{
			throw null;
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x0002EAA2 File Offset: 0x0002CCA2
		[global::Cpp2ILInjected.Token(Token = "0x6005384")]
		[global::Cpp2ILInjected.Address(RVA = "0x9449D0", Offset = "0x9449D0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x0002EAA5 File Offset: 0x0002CCA5
		[global::Cpp2ILInjected.Token(Token = "0x6005385")]
		[global::Cpp2ILInjected.Address(RVA = "0x944A3C", Offset = "0x944A3C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformIme), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x04007193 RID: 29075
		[global::Cpp2ILInjected.Token(Token = "0x4008B30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool _disposedValue;
	}
}
