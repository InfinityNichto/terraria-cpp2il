using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200034A")]
public class StrayMethods
{
	[Cpp2IlInjected.Token(Token = "0x60027B8")]
	[Cpp2IlInjected.Address(RVA = "0x14E7724", Offset = "0x14E7724", VA = "0x14E7724")]
	public static bool CountSandHorizontally(int i, int j, bool[] fittingTypes, int requiredTotalSpread = 4, int spreadInEachAxis = 5)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027B9")]
	[Cpp2IlInjected.Address(RVA = "0x14E7A6C", Offset = "0x14E7A6C", VA = "0x14E7A6C")]
	public static bool CanSpawnSandstormHostile(Vector2 position, int expandUp, int expandDown)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027BA")]
	[Cpp2IlInjected.Address(RVA = "0x14E7BA4", Offset = "0x14E7BA4", VA = "0x14E7BA4")]
	public static bool CanSpawnSandstormFriendly(Vector2 position, int expandUp, int expandDown)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027BB")]
	[Cpp2IlInjected.Address(RVA = "0x14E7CDC", Offset = "0x14E7CDC", VA = "0x14E7CDC")]
	public static void CheckArenaScore(Vector2 arenaCenter, out Point xLeftEnd, out Point xRightEnd, int walkerWidthInTiles = 5, int walkerHeightInTiles = 10)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027BC")]
	[Cpp2IlInjected.Address(RVA = "0x14E7E80", Offset = "0x14E7E80", VA = "0x14E7E80")]
	public static void SendWalker(Point startFloorPosition, int height, int direction, out int distanceCoveredInTiles, out Point lastIteratedFloorSpot, int maxDistance = 100, bool showDebug = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027BD")]
	[Cpp2IlInjected.Address(RVA = "0x14E8408", Offset = "0x14E8408", VA = "0x14E8408")]
	public StrayMethods()
	{
	}
}
