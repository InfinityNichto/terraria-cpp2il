using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000543")]
public class PortalHelper
{
	[Cpp2IlInjected.Token(Token = "0x40068B3")]
	private static int[,] FoundPortals;

	[Cpp2IlInjected.Token(Token = "0x40068B4")]
	private static int[] PortalCooldownForPlayers;

	[Cpp2IlInjected.Token(Token = "0x40068B5")]
	private static int[] PortalCooldownForNPCs;

	[Cpp2IlInjected.Token(Token = "0x40068B6")]
	private static bool anyPortalAtAll;

	[Cpp2IlInjected.Token(Token = "0x40068B7")]
	public const int PORTALS_PER_PERSON = 2;

	[Cpp2IlInjected.Token(Token = "0x40068B8")]
	private static readonly Vector2[] EDGES;

	[Cpp2IlInjected.Token(Token = "0x40068B9")]
	private static readonly Vector2[] SLOPE_EDGES;

	[Cpp2IlInjected.Token(Token = "0x40068BA")]
	private static readonly Point[] SLOPE_OFFSETS;

	[Cpp2IlInjected.Token(Token = "0x6003999")]
	[Cpp2IlInjected.Address(RVA = "0x119BD28", Offset = "0x119BD28", VA = "0x119BD28")]
	static PortalHelper()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600399A")]
	[Cpp2IlInjected.Address(RVA = "0x119C110", Offset = "0x119C110", VA = "0x119C110")]
	public static void UpdatePortalPoints()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600399B")]
	[Cpp2IlInjected.Address(RVA = "0x119C588", Offset = "0x119C588", VA = "0x119C588")]
	public static void TryGoingThroughPortals(Entity ent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600399C")]
	[Cpp2IlInjected.Address(RVA = "0x119E0A4", Offset = "0x119E0A4", VA = "0x119E0A4")]
	public static int TryPlacingPortal(Projectile theBolt, Vector2 velocity, Vector2 theCrashVelocity)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600399D")]
	[Cpp2IlInjected.Address(RVA = "0x119EA44", Offset = "0x119EA44", VA = "0x119EA44")]
	private static bool FindValidLine(Point position, int xOffset, int yOffset, out Point bestPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600399E")]
	[Cpp2IlInjected.Address(RVA = "0x119EDC0", Offset = "0x119EDC0", VA = "0x119EDC0")]
	private static bool IsValidLine(Point position, int xOffset, int yOffset)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600399F")]
	[Cpp2IlInjected.Address(RVA = "0x119F270", Offset = "0x119F270", VA = "0x119F270")]
	private static bool CanPlacePortalOn(Tile t)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039A0")]
	[Cpp2IlInjected.Address(RVA = "0x119F348", Offset = "0x119F348", VA = "0x119F348")]
	private static bool DoesTileTypeSupportPortals(ushort tileType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039A1")]
	[Cpp2IlInjected.Address(RVA = "0x119F114", Offset = "0x119F114", VA = "0x119F114")]
	private static bool BlockPortals(Tile t)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039A2")]
	[Cpp2IlInjected.Address(RVA = "0x119E8DC", Offset = "0x119E8DC", VA = "0x119E8DC")]
	private static Vector2 FindCollision(Vector2 startPosition, Vector2 stopPosition)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60039A3")]
	[Cpp2IlInjected.Address(RVA = "0x119EBE4", Offset = "0x119EBE4", VA = "0x119EBE4")]
	private static int AddPortal(Projectile sourceProjectile, Vector2 position, float angle, int form, int direction)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60039A4")]
	[Cpp2IlInjected.Address(RVA = "0x119FA38", Offset = "0x119FA38", VA = "0x119FA38")]
	private static void RemoveMyOldPortal(int form)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039A5")]
	[Cpp2IlInjected.Address(RVA = "0x119FB64", Offset = "0x119FB64", VA = "0x119FB64")]
	private static void RemoveIntersectingPortals(Vector2 position, float angle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039A6")]
	[Cpp2IlInjected.Address(RVA = "0x119FEA0", Offset = "0x119FEA0", VA = "0x119FEA0")]
	public static Color GetPortalColor(int colorIndex)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60039A7")]
	[Cpp2IlInjected.Address(RVA = "0x119FF24", Offset = "0x119FF24", VA = "0x119FF24")]
	public static Color GetPortalColor(int player, int portal)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60039A8")]
	[Cpp2IlInjected.Address(RVA = "0x119DBE4", Offset = "0x119DBE4", VA = "0x119DBE4")]
	private static void GetPortalEdges(Vector2 position, float angle, out Vector2 start, out Vector2 end)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039A9")]
	[Cpp2IlInjected.Address(RVA = "0x119DD3C", Offset = "0x119DD3C", VA = "0x119DD3C")]
	private static Vector2 GetPortalOutingPoint(Vector2 objectSize, Vector2 portalPosition, float portalAngle, out int bonusX, out int bonusY)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60039AA")]
	[Cpp2IlInjected.Address(RVA = "0x11A00C8", Offset = "0x11A00C8", VA = "0x11A00C8")]
	public static void SyncPortalsOnPlayerJoin(int plr, int fluff, List<Point> dontInclude, out List<Point> portalSections)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039AB")]
	[Cpp2IlInjected.Address(RVA = "0x11A0440", Offset = "0x11A0440", VA = "0x11A0440")]
	public static void SyncPortalSections(Vector2 portalPosition, int fluff)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039AC")]
	[Cpp2IlInjected.Address(RVA = "0x119F35C", Offset = "0x119F35C", VA = "0x119F35C")]
	public static bool SupportedTilesAreFine(Vector2 portalCenter, float portalAngle)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039AD")]
	[Cpp2IlInjected.Address(RVA = "0x11A0584", Offset = "0x11A0584", VA = "0x11A0584")]
	private static bool SupportedSlope(int x, int y, int slope)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039AE")]
	[Cpp2IlInjected.Address(RVA = "0x11A0A04", Offset = "0x11A0A04", VA = "0x11A0A04")]
	private static bool SupportedHalfbrick(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039AF")]
	[Cpp2IlInjected.Address(RVA = "0x11A0794", Offset = "0x11A0794", VA = "0x11A0794")]
	private static bool SupportedNormal(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039B0")]
	[Cpp2IlInjected.Address(RVA = "0x11A0C10", Offset = "0x11A0C10", VA = "0x11A0C10")]
	public PortalHelper()
	{
	}
}
