using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005A7 RID: 1447
	[global::Cpp2ILInjected.Token(Token = "0x2000846")]
	public interface ISmartInteractCandidateProvider
	{
		// Token: 0x06003BF5 RID: 15349
		[global::Cpp2ILInjected.Token(Token = "0x6004318")]
		void ClearSelfAndPrepareForCheck();

		// Token: 0x06003BF6 RID: 15350
		[global::Cpp2ILInjected.Token(Token = "0x6004319")]
		bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate);
	}
}
