using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005A8")]
public interface ISmartInteractCandidate
{
	[Cpp2IlInjected.Token(Token = "0x17000727")]
	float DistanceFromCursor
	{
		[Cpp2IlInjected.Token(Token = "0x6003C2E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C2F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void WinCandidacy();
}
