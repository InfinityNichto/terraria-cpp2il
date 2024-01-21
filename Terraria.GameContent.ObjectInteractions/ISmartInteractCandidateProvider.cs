using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005AA")]
public interface ISmartInteractCandidateProvider
{
	[Cpp2IlInjected.Token(Token = "0x6003C31")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearSelfAndPrepareForCheck();

	[Cpp2IlInjected.Token(Token = "0x6003C32")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate);
}
