using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005A7")]
public abstract class AHoverInteractionChecker
{
	[Cpp2IlInjected.Token(Token = "0x20009A0")]
	internal enum HoverStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4008CA0")]
		NotSelectable,
		[Cpp2IlInjected.Token(Token = "0x4008CA1")]
		SelectableButNotSelected,
		[Cpp2IlInjected.Token(Token = "0x4008CA2")]
		Selected
	}

	[Cpp2IlInjected.Token(Token = "0x6003C28")]
	[Cpp2IlInjected.Address(RVA = "0x105E6D0", Offset = "0x105E6D0", VA = "0x105E6D0")]
	internal HoverStatus AttemptInteraction(Player player, Rectangle Hitbox)
	{
		return default(HoverStatus);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C29")]
	[Cpp2IlInjected.Address(Slot = "4")]
	internal abstract bool? AttemptOverridingHoverStatus(Player player, Rectangle rectangle);

	[Cpp2IlInjected.Token(Token = "0x6003C2A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	internal abstract void DoHoverEffect(Player player, Rectangle hitbox);

	[Cpp2IlInjected.Token(Token = "0x6003C2B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	internal abstract bool ShouldBlockInteraction(Player player, Rectangle hitbox);

	[Cpp2IlInjected.Token(Token = "0x6003C2C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal abstract void PerformInteraction(Player player, Rectangle hitbox);

	[Cpp2IlInjected.Token(Token = "0x6003C2D")]
	[Cpp2IlInjected.Address(RVA = "0x105EE08", Offset = "0x105EE08", VA = "0x105EE08")]
	protected AHoverInteractionChecker()
	{
	}
}
