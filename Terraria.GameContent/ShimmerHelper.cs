using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000565")]
public class ShimmerHelper
{
	[Cpp2IlInjected.Token(Token = "0x6003A6D")]
	[Cpp2IlInjected.Address(RVA = "0x110E89C", Offset = "0x110E89C", VA = "0x110E89C")]
	public static Vector2? FindSpotWithoutShimmer(Entity entity, int startX, int startY, int expand, bool allowSolidTop)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A6E")]
	[Cpp2IlInjected.Address(RVA = "0x110EFD0", Offset = "0x110EFD0", VA = "0x110EFD0")]
	private static bool IsSpotShimmerFree(Entity entity, Vector2 landingPosition, bool allowSolidTop)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A6F")]
	[Cpp2IlInjected.Address(RVA = "0x110F1F4", Offset = "0x110F1F4", VA = "0x110F1F4")]
	public ShimmerHelper()
	{
	}
}
