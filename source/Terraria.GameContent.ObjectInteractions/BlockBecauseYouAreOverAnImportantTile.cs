using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005AD")]
public class BlockBecauseYouAreOverAnImportantTile : ISmartInteractBlockReasonProvider
{
	[Cpp2IlInjected.Token(Token = "0x6003C36")]
	[Cpp2IlInjected.Address(RVA = "0x105EE10", Offset = "0x105EE10", VA = "0x105EE10", Slot = "4")]
	public bool ShouldBlockSmartInteract(SmartInteractScanSettings settings)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C37")]
	[Cpp2IlInjected.Address(RVA = "0x105F000", Offset = "0x105F000", VA = "0x105F000")]
	public BlockBecauseYouAreOverAnImportantTile()
	{
	}
}
