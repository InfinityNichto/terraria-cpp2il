using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ObjectInteractions
{
	[global::Cpp2ILInjected.Token(Token = "0x2000846")]
	public interface ISmartInteractCandidateProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004318")]
		void ClearSelfAndPrepareForCheck();

		[global::Cpp2ILInjected.Token(Token = "0x6004319")]
		bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate);
	}
}
