using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005A9")]
public interface ISmartInteractBlockReasonProvider
{
	[Cpp2IlInjected.Token(Token = "0x6003C30")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ShouldBlockSmartInteract(SmartInteractScanSettings settings);
}
