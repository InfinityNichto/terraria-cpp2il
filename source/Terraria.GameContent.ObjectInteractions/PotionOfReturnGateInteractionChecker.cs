using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005B3")]
public class PotionOfReturnGateInteractionChecker : AHoverInteractionChecker
{
	[Cpp2IlInjected.Token(Token = "0x6003C49")]
	[Cpp2IlInjected.Address(RVA = "0x1193CB8", Offset = "0x1193CB8", VA = "0x1193CB8", Slot = "4")]
	internal override bool? AttemptOverridingHoverStatus(Player player, Rectangle rectangle)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C4A")]
	[Cpp2IlInjected.Address(RVA = "0x1193D68", Offset = "0x1193D68", VA = "0x1193D68", Slot = "5")]
	internal override void DoHoverEffect(Player player, Rectangle hitbox)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C4B")]
	[Cpp2IlInjected.Address(RVA = "0x1193D84", Offset = "0x1193D84", VA = "0x1193D84", Slot = "6")]
	internal override bool ShouldBlockInteraction(Player player, Rectangle hitbox)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C4C")]
	[Cpp2IlInjected.Address(RVA = "0x1193E00", Offset = "0x1193E00", VA = "0x1193E00", Slot = "7")]
	internal override void PerformInteraction(Player player, Rectangle hitbox)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C4D")]
	[Cpp2IlInjected.Address(RVA = "0x1193E0C", Offset = "0x1193E0C", VA = "0x1193E0C")]
	public PotionOfReturnGateInteractionChecker()
	{
	}
}
