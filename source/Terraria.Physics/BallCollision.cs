using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Physics;

[Cpp2IlInjected.Token(Token = "0x20003A1")]
public static class BallCollision
{
	[Cpp2IlInjected.Token(Token = "0x20008E5")]
	[Flags]
	private enum TileEdges : uint
	{
		[Cpp2IlInjected.Token(Token = "0x4008126")]
		None = 0u,
		[Cpp2IlInjected.Token(Token = "0x4008127")]
		Top = 1u,
		[Cpp2IlInjected.Token(Token = "0x4008128")]
		Bottom = 2u,
		[Cpp2IlInjected.Token(Token = "0x4008129")]
		Left = 4u,
		[Cpp2IlInjected.Token(Token = "0x400812A")]
		Right = 8u,
		[Cpp2IlInjected.Token(Token = "0x400812B")]
		TopLeftSlope = 0x10u,
		[Cpp2IlInjected.Token(Token = "0x400812C")]
		TopRightSlope = 0x20u,
		[Cpp2IlInjected.Token(Token = "0x400812D")]
		BottomLeftSlope = 0x40u,
		[Cpp2IlInjected.Token(Token = "0x400812E")]
		BottomRightSlope = 0x80u
	}

	[Cpp2IlInjected.Token(Token = "0x6002E2F")]
	[Cpp2IlInjected.Address(RVA = "0xB79928", Offset = "0xB79928", VA = "0xB79928")]
	public static BallStepResult Step(PhysicsProperties physicsProperties, Entity entity, ref float entityAngularVelocity, IBallContactListener listener)
	{
		return default(BallStepResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E30")]
	[Cpp2IlInjected.Address(RVA = "0xB7A300", Offset = "0xB7A300", VA = "0xB7A300")]
	private static bool CheckForPassThrough(Vector2 center, out BallPassThroughType type, out Tile contactTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E31")]
	[Cpp2IlInjected.Address(RVA = "0xB7AACC", Offset = "0xB7AACC", VA = "0xB7AACC")]
	private static bool IsPositionInsideTile(Vector2 position, Point tileCoordinates, Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E32")]
	[Cpp2IlInjected.Address(RVA = "0xB7A4F0", Offset = "0xB7A4F0", VA = "0xB7A4F0")]
	private static bool IsBallInWorld(Vector2 position, Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E33")]
	[Cpp2IlInjected.Address(RVA = "0xB7A62C", Offset = "0xB7A62C", VA = "0xB7A62C")]
	private static bool GetClosestEdgeToCircle(Vector2 position, Vector2 size, Vector2 velocity, out Vector2 collisionPoint, out Tile collisionTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E34")]
	[Cpp2IlInjected.Address(RVA = "0xB7ADE8", Offset = "0xB7ADE8", VA = "0xB7ADE8")]
	private static bool GetCollisionPointForTile(TileEdges edgesToTest, int x, int y, Vector2 center, ref Vector2 closestPointOut, ref float distanceSquaredOut)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E35")]
	[Cpp2IlInjected.Address(RVA = "0xB7B2E8", Offset = "0xB7B2E8", VA = "0xB7B2E8")]
	private static bool GetSlopeEdge(ref TileEdges edgesToTest, Tile tile, Vector2 tilePosition, ref LineSegment edge)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E36")]
	[Cpp2IlInjected.Address(RVA = "0xB7B600", Offset = "0xB7B600", VA = "0xB7B600")]
	private static bool GetTopOrBottomEdge(TileEdges edgesToTest, int x, int y, Vector2 tilePosition, ref LineSegment edge)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E37")]
	[Cpp2IlInjected.Address(RVA = "0xB7B90C", Offset = "0xB7B90C", VA = "0xB7B90C")]
	private static bool GetLeftOrRightEdge(TileEdges edgesToTest, int x, int y, Vector2 tilePosition, ref LineSegment edge)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E38")]
	[Cpp2IlInjected.Address(RVA = "0xB7ACA0", Offset = "0xB7ACA0", VA = "0xB7ACA0")]
	private static Rectangle GetTileBounds(Vector2 position, Vector2 size)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E39")]
	[Cpp2IlInjected.Address(RVA = "0xB7BC44", Offset = "0xB7BC44", VA = "0xB7BC44")]
	private static bool IsNeighborSolid(Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E3A")]
	[Cpp2IlInjected.Address(RVA = "0xB7B458", Offset = "0xB7B458", VA = "0xB7B458")]
	private static Vector2 ClosestPointOnLineSegment(Vector2 point, LineSegment lineSegment)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E3B")]
	[Cpp2IlInjected.Address(RVA = "0xB7BD4C", Offset = "0xB7BD4C", VA = "0xB7BD4C")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x393954", Offset = "0x393954")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x393954", Offset = "0x393954")]
	private static void DrawEdge(LineSegment edge)
	{
	}
}
