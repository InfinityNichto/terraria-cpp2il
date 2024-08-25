using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Localization.IME
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B2F")]
	internal class FnaIme : PlatformIme
	{
		[global::Cpp2ILInjected.Token(Token = "0x600537D")]
		[global::Cpp2ILInjected.Address(RVA = "0x944750", Offset = "0x944750", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public FnaIme()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600537E")]
		[global::Cpp2ILInjected.Address(RVA = "0x9447D8", Offset = "0x9447D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnCharCallback(char key)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6005383")]
		[global::Cpp2ILInjected.Address(RVA = "0x944988", Offset = "0x944988", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string GetCandidate(uint index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005384")]
		[global::Cpp2ILInjected.Address(RVA = "0x9449D0", Offset = "0x9449D0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4008B30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool _disposedValue;
	}
}
