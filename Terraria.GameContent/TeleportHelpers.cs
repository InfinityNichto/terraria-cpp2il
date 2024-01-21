using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200056A")]
public class TeleportHelpers
{
	[Cpp2IlInjected.Token(Token = "0x6003AB5")]
	[Cpp2IlInjected.Address(RVA = "0x127631C", Offset = "0x127631C", VA = "0x127631C")]
	public static bool RequestMagicConchTeleportPosition(Player player, int crawlOffsetX, int startX, out Point landingPoint)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AB6")]
	[Cpp2IlInjected.Address(RVA = "0x1276F80", Offset = "0x1276F80", VA = "0x1276F80")]
	private static bool TileIsDangerous(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AB7")]
	[Cpp2IlInjected.Address(RVA = "0x12768F0", Offset = "0x12768F0", VA = "0x12768F0")]
	private static bool IsInSolidTilesExtended(Vector2 testPosition, Vector2 playerVelocity, int width, int height, int gravDir)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AB8")]
	[Cpp2IlInjected.Address(RVA = "0x12771BC", Offset = "0x12771BC", VA = "0x12771BC")]
	public TeleportHelpers()
	{
	}
}
