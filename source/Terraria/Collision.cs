using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000328")]
public class Collision
{
	[Cpp2IlInjected.Token(Token = "0x2000851")]
	public struct HurtTile
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007EBF")]
		public int type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007EC0")]
		public int x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007EC1")]
		public int y;
	}

	[Cpp2IlInjected.Token(Token = "0x4002C90")]
	public static bool stair;

	[Cpp2IlInjected.Token(Token = "0x4002C91")]
	public static bool stairFall;

	[Cpp2IlInjected.Token(Token = "0x4002C92")]
	public static bool honey;

	[Cpp2IlInjected.Token(Token = "0x4002C93")]
	public static bool shimmer;

	[Cpp2IlInjected.Token(Token = "0x4002C94")]
	public static bool sloping;

	[Cpp2IlInjected.Token(Token = "0x4002C95")]
	public static bool landMine;

	[Cpp2IlInjected.Token(Token = "0x4002C96")]
	public static bool up;

	[Cpp2IlInjected.Token(Token = "0x4002C97")]
	public static bool down;

	[Cpp2IlInjected.Token(Token = "0x4002C98")]
	public unsafe static uint* tileLookup;

	[Cpp2IlInjected.Token(Token = "0x4002C99")]
	public unsafe static ushort* tileTypeData;

	[Cpp2IlInjected.Token(Token = "0x4002C9A")]
	public unsafe static ushort* tileTypeWall;

	[Cpp2IlInjected.Token(Token = "0x4002C9B")]
	public unsafe static short* tileTypeSHeader;

	[Cpp2IlInjected.Token(Token = "0x4002C9C")]
	public unsafe static byte* tileTypeLiquid;

	[Cpp2IlInjected.Token(Token = "0x4002C9D")]
	public static float Epsilon;

	[Cpp2IlInjected.Token(Token = "0x4002C9E")]
	private static bool[] cSlopes;

	[Cpp2IlInjected.Token(Token = "0x4002C9F")]
	private static bool retesting;

	[Cpp2IlInjected.Token(Token = "0x4002CA0")]
	private static List<Point> EntityEdgeTiles;

	[Cpp2IlInjected.Token(Token = "0x4002CA1")]
	private static List<Point> _cacheForConveyorBelts;

	[Cpp2IlInjected.Token(Token = "0x4002CA2")]
	private static List<int> dummyLaserScanList;

	[Cpp2IlInjected.Token(Token = "0x60025A4")]
	[Cpp2IlInjected.Address(RVA = "0x11B22D4", Offset = "0x11B22D4", VA = "0x11B22D4")]
	public static Vector2[] CheckLinevLine(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60025A5")]
	[Cpp2IlInjected.Address(RVA = "0x11B2ACC", Offset = "0x11B2ACC", VA = "0x11B2ACC")]
	private static double DistFromSeg(Vector2 p, Vector2 q0, Vector2 q1, double radius, ref float u)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60025A6")]
	[Cpp2IlInjected.Address(RVA = "0x11B27F8", Offset = "0x11B27F8", VA = "0x11B27F8")]
	private static bool PointOnLine(Vector2 p, Vector2 a1, Vector2 a2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025A7")]
	[Cpp2IlInjected.Address(RVA = "0x11B28C4", Offset = "0x11B28C4", VA = "0x11B28C4")]
	private static Vector2[] OneDimensionalIntersection(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60025A8")]
	[Cpp2IlInjected.Address(RVA = "0x11B2C90", Offset = "0x11B2C90", VA = "0x11B2C90")]
	private static float[] FindOverlapPoints(float relativePoint1, float relativePoint2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60025A9")]
	[Cpp2IlInjected.Address(RVA = "0x11B2DB8", Offset = "0x11B2DB8", VA = "0x11B2DB8")]
	public static bool CheckAABBvAABBCollision(Vector2 position1, Vector2 dimensions1, Vector2 position2, Vector2 dimensions2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025AA")]
	[Cpp2IlInjected.Address(RVA = "0x11B2E3C", Offset = "0x11B2E3C", VA = "0x11B2E3C")]
	private static int collisionOutcode(Vector2 aabbPosition, Vector2 aabbDimensions, Vector2 point)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60025AB")]
	[Cpp2IlInjected.Address(RVA = "0x11B2ED8", Offset = "0x11B2ED8", VA = "0x11B2ED8")]
	public static bool CheckAABBvLineCollision(Vector2 aabbPosition, Vector2 aabbDimensions, Vector2 lineStart, Vector2 lineEnd)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025AC")]
	[Cpp2IlInjected.Address(RVA = "0x11B309C", Offset = "0x11B309C", VA = "0x11B309C")]
	public static bool CheckAABBvLineCollision2(Vector2 aabbPosition, Vector2 aabbDimensions, Vector2 lineStart, Vector2 lineEnd)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025AD")]
	[Cpp2IlInjected.Address(RVA = "0x11B321C", Offset = "0x11B321C", VA = "0x11B321C")]
	public static bool CheckAABBvLineCollision(Vector2 objectPosition, Vector2 objectDimensions, Vector2 lineStart, Vector2 lineEnd, float lineWidth, ref float collisionPoint)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025AE")]
	[Cpp2IlInjected.Address(RVA = "0x11B3B10", Offset = "0x11B3B10", VA = "0x11B3B10")]
	public static bool CanHit(Entity source, Entity target)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025AF")]
	[Cpp2IlInjected.Address(RVA = "0x11B3CCC", Offset = "0x11B3CCC", VA = "0x11B3CCC")]
	public static bool CanHit(Entity source, NPCAimedTarget target)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025B0")]
	[Cpp2IlInjected.Address(RVA = "0x11B3BC0", Offset = "0x11B3BC0", VA = "0x11B3BC0")]
	public static bool CanHit(Vector2 Position1, int Width1, int Height1, Vector2 Position2, int Width2, int Height2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025B1")]
	[Cpp2IlInjected.Address(RVA = "0x11B3D80", Offset = "0x11B3D80", VA = "0x11B3D80")]
	public static bool CanHit(Point Position1, int Width1, int Height1, Point Position2, int Width2, int Height2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025B2")]
	[Cpp2IlInjected.Address(RVA = "0x11B42B8", Offset = "0x11B42B8", VA = "0x11B42B8")]
	public static bool CanHitWithCheck(Vector2 Position1, int Width1, int Height1, Vector2 Position2, int Width2, int Height2, Utils.TileActionAttempt check)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025B3")]
	[Cpp2IlInjected.Address(RVA = "0x11B538C", Offset = "0x11B538C", VA = "0x11B538C")]
	public static bool CanHitLine(Vector2 Position1, int Width1, int Height1, Vector2 Position2, int Width2, int Height2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025B4")]
	[Cpp2IlInjected.Address(RVA = "0x11B5C88", Offset = "0x11B5C88", VA = "0x11B5C88")]
	public static bool TupleHitLine(int x1, int y1, int x2, int y2, int ignoreX, int ignoreY, List<int> ignoreTargets, out int colX, out int colY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025B5")]
	[Cpp2IlInjected.Address(RVA = "0x11B682C", Offset = "0x11B682C", VA = "0x11B682C")]
	public static void TupleHitLineWall(int x1, int y1, int x2, int y2, out int resX, out int resY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025B6")]
	[Cpp2IlInjected.Address(RVA = "0x11B6FE0", Offset = "0x11B6FE0", VA = "0x11B6FE0")]
	public static bool HitWallSubstep(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025B7")]
	[Cpp2IlInjected.Address(RVA = "0x11B737C", Offset = "0x11B737C", VA = "0x11B737C")]
	public static bool EmptyTile(int i, int j, bool ignoreTiles = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025B8")]
	[Cpp2IlInjected.Address(RVA = "0x11B7728", Offset = "0x11B7728", VA = "0x11B7728")]
	public static bool DrownCollision(Vector2 Position, int Width, int Height, float gravDir = -1f, bool includeSlopes = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025B9")]
	[Cpp2IlInjected.Address(RVA = "0x11B7CA4", Offset = "0x11B7CA4", VA = "0x11B7CA4")]
	public static bool IsWorldPointSolid(Vector2 pos, bool treatPlatformsAsNonSolid = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025BA")]
	[Cpp2IlInjected.Address(RVA = "0x11B8110", Offset = "0x11B8110", VA = "0x11B8110")]
	public static bool GetWaterLine(Point pt, out float waterLineHeight)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025BB")]
	[Cpp2IlInjected.Address(RVA = "0x11B8198", Offset = "0x11B8198", VA = "0x11B8198")]
	public static bool GetWaterLine(int X, int Y, out float waterLineHeight)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025BC")]
	[Cpp2IlInjected.Address(RVA = "0x11B8470", Offset = "0x11B8470", VA = "0x11B8470")]
	public static bool GetWaterLineIterate(Point pt, out float waterLineHeight)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025BD")]
	[Cpp2IlInjected.Address(RVA = "0x11B84F8", Offset = "0x11B84F8", VA = "0x11B84F8")]
	public static bool GetWaterLineIterate(int X, int Y, out float waterLineHeight)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025BE")]
	[Cpp2IlInjected.Address(RVA = "0x11B868C", Offset = "0x11B868C", VA = "0x11B868C")]
	public static bool WetCollision(Vector2 Position, int Width, int Height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025BF")]
	[Cpp2IlInjected.Address(RVA = "0x11B8EAC", Offset = "0x11B8EAC", VA = "0x11B8EAC")]
	public static bool LavaCollision(Vector2 Position, int Width, int Height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025C0")]
	[Cpp2IlInjected.Address(RVA = "0x11B9210", Offset = "0x11B9210", VA = "0x11B9210")]
	public static Vector4 WalkDownSlope(Vector2 Position, Vector2 Velocity, int Width, int Height, float gravity = 0f)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x60025C1")]
	[Cpp2IlInjected.Address(RVA = "0x11B9788", Offset = "0x11B9788", VA = "0x11B9788")]
	public static Vector4 SlopeCollision(Vector2 oldPosition, Vector2 oldVelocity, int Width, int Height, float gravity = 0f, bool fall = false)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x60025C2")]
	[Cpp2IlInjected.Address(RVA = "0x11BB2DC", Offset = "0x11BB2DC", VA = "0x11BB2DC")]
	public static Vector2 noSlopeCollision(Vector2 Position, Vector2 Velocity, int Width, int Height, bool fallThrough = false, bool fall2 = false)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60025C3")]
	[Cpp2IlInjected.Address(RVA = "0x11BBC30", Offset = "0x11BBC30", VA = "0x11BBC30")]
	public static Vector2 OldTileCollision(Vector2 Position, Vector2 Velocity, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60025C4")]
	[Cpp2IlInjected.Address(RVA = "0x11BA754", Offset = "0x11BA754", VA = "0x11BA754")]
	public static Vector2 TileCollision(Vector2 oldPosition, Vector2 oldVelocity, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60025C5")]
	[Cpp2IlInjected.Address(RVA = "0x11BCACC", Offset = "0x11BCACC", VA = "0x11BCACC")]
	public static bool IsClearSpotTest(Vector2 position, float testMagnitude, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1, bool checkCardinals = true, bool checkSlopes = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025C6")]
	[Cpp2IlInjected.Address(RVA = "0x11BD6B4", Offset = "0x11BD6B4", VA = "0x11BD6B4")]
	public static List<Point> FindCollisionTile(int Direction, Vector2 position, float testMagnitude, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1, bool checkCardinals = true, bool checkSlopes = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60025C7")]
	[Cpp2IlInjected.Address(RVA = "0x11BEFC0", Offset = "0x11BEFC0", VA = "0x11BEFC0")]
	public static bool FindCollisionDirection(out int Direction, Vector2 position, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025C8")]
	[Cpp2IlInjected.Address(RVA = "0x11BF5AC", Offset = "0x11BF5AC", VA = "0x11BF5AC")]
	public static bool SolidCollision(Vector2 Position, int Width, int Height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025C9")]
	[Cpp2IlInjected.Address(RVA = "0x11BF930", Offset = "0x11BF930", VA = "0x11BF930")]
	public static bool SolidCollision(Vector2 Position, int Width, int Height, bool acceptTopSurfaces)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025CA")]
	[Cpp2IlInjected.Address(RVA = "0x11BFD9C", Offset = "0x11BFD9C", VA = "0x11BFD9C")]
	public static Vector2 WaterCollision(Vector2 Position, Vector2 Velocity, int Width, int Height, bool fallThrough = false, bool fall2 = false, bool lavaWalk = true)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60025CB")]
	[Cpp2IlInjected.Address(RVA = "0x11C0258", Offset = "0x11C0258", VA = "0x11C0258")]
	public static Vector2 AnyCollisionWithSpecificTiles(Vector2 Position, Vector2 Velocity, int Width, int Height, bool[] tilesWeCanCollideWithByType, bool evenActuated = false)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60025CC")]
	[Cpp2IlInjected.Address(RVA = "0x11C0808", Offset = "0x11C0808", VA = "0x11C0808")]
	public static Vector2 AnyCollision(Vector2 Position, Vector2 Velocity, int Width, int Height, bool evenActuated = false)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60025CD")]
	[Cpp2IlInjected.Address(RVA = "0x11C0EB4", Offset = "0x11C0EB4", VA = "0x11C0EB4")]
	public static void HitTiles(Vector2 Position, Vector2 Velocity, int Width, int Height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025CE")]
	[Cpp2IlInjected.Address(RVA = "0x11C1424", Offset = "0x11C1424", VA = "0x11C1424")]
	public static bool AnyHurtingTiles(Vector2 Position, int Width, int Height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025CF")]
	[Cpp2IlInjected.Address(RVA = "0x11C14D4", Offset = "0x11C14D4", VA = "0x11C14D4")]
	public static HurtTile HurtTiles(Vector2 Position, int Width, int Height, Player player)
	{
		return default(HurtTile);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D0")]
	[Cpp2IlInjected.Address(RVA = "0x11C19E0", Offset = "0x11C19E0", VA = "0x11C19E0")]
	public static bool CanTileHurt(ushort type, int i, int j, Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D1")]
	[Cpp2IlInjected.Address(RVA = "0x11C1BC0", Offset = "0x11C1BC0", VA = "0x11C1BC0")]
	public static bool SwitchTiles(Vector2 Position, int Width, int Height, Vector2 oldPosition, int objType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D2")]
	[Cpp2IlInjected.Address(RVA = "0x11C27B0", Offset = "0x11C27B0", VA = "0x11C27B0")]
	public bool SwitchTilesNew(Vector2 Position, int Width, int Height, Vector2 oldPosition, int objType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D3")]
	[Cpp2IlInjected.Address(RVA = "0x11C2A58", Offset = "0x11C2A58", VA = "0x11C2A58")]
	public static Vector2 StickyTiles(Vector2 Position, Vector2 Velocity, int Width, int Height)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D4")]
	[Cpp2IlInjected.Address(RVA = "0x11C314C", Offset = "0x11C314C", VA = "0x11C314C")]
	public static bool SolidTilesVersatile(int startX, int endX, int startY, int endY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D5")]
	[Cpp2IlInjected.Address(RVA = "0x11C359C", Offset = "0x11C359C", VA = "0x11C359C")]
	public static bool SolidTiles(Vector2 position, int width, int height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D6")]
	[Cpp2IlInjected.Address(RVA = "0x11C32AC", Offset = "0x11C32AC", VA = "0x11C32AC")]
	public static bool SolidTiles(int startX, int endX, int startY, int endY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D7")]
	[Cpp2IlInjected.Address(RVA = "0x11C3684", Offset = "0x11C3684", VA = "0x11C3684")]
	public static bool SolidTiles(Vector2 position, int width, int height, bool allowTopSurfaces)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D8")]
	[Cpp2IlInjected.Address(RVA = "0x11C3774", Offset = "0x11C3774", VA = "0x11C3774")]
	public static bool SolidTiles(int startX, int endX, int startY, int endY, bool allowTopSurfaces)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025D9")]
	[Cpp2IlInjected.Address(RVA = "0x11C3A70", Offset = "0x11C3A70", VA = "0x11C3A70")]
	public static void StepDown(ref Vector2 position, ref Vector2 velocity, int width, int height, ref float stepSpeed, ref float gfxOffY, int gravDir = 1, bool waterWalk = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025DA")]
	[Cpp2IlInjected.Address(RVA = "0x11C3FD0", Offset = "0x11C3FD0", VA = "0x11C3FD0")]
	public static void StepUp(ref Vector2 position, ref Vector2 velocity, int width, int height, ref float stepSpeed, ref float gfxOffY, int gravDir = 1, bool holdsMatching = false, int specialChecksMode = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025DB")]
	[Cpp2IlInjected.Address(RVA = "0x11C4BE8", Offset = "0x11C4BE8", VA = "0x11C4BE8")]
	public static bool InTileBounds(int x, int y, int lx, int ly, int hx, int hy)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025DC")]
	[Cpp2IlInjected.Address(RVA = "0x11C4C1C", Offset = "0x11C4C1C", VA = "0x11C4C1C")]
	public static float GetTileRotation(Vector2 position)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60025DD")]
	[Cpp2IlInjected.Address(RVA = "0x11C4F80", Offset = "0x11C4F80", VA = "0x11C4F80")]
	public static void GetEntityEdgeTopBottom(Entity entity, out int sx, out int ex, out int sy, out int ey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025DE")]
	[Cpp2IlInjected.Address(RVA = "0x11C5058", Offset = "0x11C5058", VA = "0x11C5058")]
	public static void GetEntityEdgeTilesExtents(Entity entity, out int minX, out int minY, out int maxX, out int maxY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025DF")]
	[Cpp2IlInjected.Address(RVA = "0x11C5138", Offset = "0x11C5138", VA = "0x11C5138")]
	public static void GetEntityEdgeTiles(List<Point> p, Entity entity, bool left = true, bool right = true, bool up = true, bool down = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025E0")]
	[Cpp2IlInjected.Address(RVA = "0x11C5390", Offset = "0x11C5390", VA = "0x11C5390")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390920", Offset = "0x390920")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390920", Offset = "0x390920")]
	public static void StepConveyorBelt(Entity entity, float gravDir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025E1")]
	[Cpp2IlInjected.Address(RVA = "0x11C5DF0", Offset = "0x11C5DF0", VA = "0x11C5DF0")]
	public static void GetTilesIn(Vector2 TopLeft, Vector2 BottomRight, List<Point> p)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025E2")]
	[Cpp2IlInjected.Address(RVA = "0x11C603C", Offset = "0x11C603C", VA = "0x11C603C")]
	public static void ExpandVertically(int startX, int startY, out int topY, out int bottomY, int maxExpandUp = 100, int maxExpandDown = 100)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025E3")]
	[Cpp2IlInjected.Address(RVA = "0x11C630C", Offset = "0x11C630C", VA = "0x11C630C")]
	public static Vector2 AdvancedTileCollision(bool[] forcedIgnoredTiles, Vector2 Position, Vector2 Velocity, int Width, int Height, bool fallThrough = false, bool fall2 = false, int gravDir = 1)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60025E4")]
	[Cpp2IlInjected.Address(RVA = "0x11C6F34", Offset = "0x11C6F34", VA = "0x11C6F34")]
	public static void LaserScan(Vector2 samplingPoint, Vector2 directionUnit, float samplingWidth, float maxDistance, float[] samples)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025E5")]
	[Cpp2IlInjected.Address(RVA = "0x11C7338", Offset = "0x11C7338", VA = "0x11C7338")]
	public static void AimingLaserScan(Vector2 startPoint, Vector2 endPoint, float samplingWidth, int samplesToTake, out Vector2 vectorTowardsTarget, out float[] samples)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025E6")]
	[Cpp2IlInjected.Address(RVA = "0x11C7548", Offset = "0x11C7548", VA = "0x11C7548")]
	public Collision()
	{
	}
}
