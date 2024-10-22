﻿using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.Golf;

namespace Terraria.Physics
{
	[global::Cpp2ILInjected.Token(Token = "0x200053C")]
	public static class BallCollision
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003256")]
		[global::Cpp2ILInjected.Address(RVA = "0x132C7E0", Offset = "0x132C7E0", Length = "0x6D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "StepGolfBall", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(ref float)
		}, ReturnType = typeof(BallStepResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "CheckForPassThrough", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref BallPassThroughType),
			typeof(ref Tile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "IsBallInWorld", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "GetClosestEdgeToCircle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref Vector2),
			typeof(ref Tile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Reflect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static BallStepResult Step(PhysicsProperties physicsProperties, Entity entity, ref float entityAngularVelocity, IBallContactListener listener)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003257")]
		[global::Cpp2ILInjected.Address(RVA = "0x132CEB4", Offset = "0x132CEB4", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "Step", MemberParameters = new object[]
		{
			typeof(PhysicsProperties),
			typeof(Entity),
			typeof(ref float),
			typeof(IBallContactListener)
		}, ReturnType = typeof(BallStepResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "IsPositionInsideTile", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Point),
			typeof(Tile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool CheckForPassThrough(Vector2 center, out BallPassThroughType type, out Tile contactTile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003258")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D4B0", Offset = "0x132D4B0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "CheckForPassThrough", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref BallPassThroughType),
			typeof(ref Tile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsPositionInsideTile(Vector2 position, Point tileCoordinates, Tile tile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003259")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D064", Offset = "0x132D064", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "Step", MemberParameters = new object[]
		{
			typeof(PhysicsProperties),
			typeof(Entity),
			typeof(ref float),
			typeof(IBallContactListener)
		}, ReturnType = typeof(BallStepResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsBallInWorld(Vector2 position, Vector2 size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600325A")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D164", Offset = "0x132D164", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "Step", MemberParameters = new object[]
		{
			typeof(PhysicsProperties),
			typeof(Entity),
			typeof(ref float),
			typeof(IBallContactListener)
		}, ReturnType = typeof(BallStepResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "GetTileBounds", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "GetCollisionPointForTile", MemberParameters = new object[]
		{
			typeof(BallCollision.TileEdges),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref Vector2),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Dot", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool GetClosestEdgeToCircle(Vector2 position, Vector2 size, Vector2 velocity, out Vector2 collisionPoint, out Tile collisionTile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600325B")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D718", Offset = "0x132D718", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "GetClosestEdgeToCircle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref Vector2),
			typeof(ref Tile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "GetSlopeEdge", MemberParameters = new object[]
		{
			typeof(ref BallCollision.TileEdges),
			typeof(Tile),
			typeof(Vector2),
			typeof(ref LineSegment)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "ClosestPointOnLineSegment", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(LineSegment)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "GetTopOrBottomEdge", MemberParameters = new object[]
		{
			typeof(BallCollision.TileEdges),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref LineSegment)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "GetLeftOrRightEdge", MemberParameters = new object[]
		{
			typeof(BallCollision.TileEdges),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref LineSegment)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool GetCollisionPointForTile(BallCollision.TileEdges edgesToTest, int x, int y, Vector2 center, ref Vector2 closestPointOut, ref float distanceSquaredOut)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600325C")]
		[global::Cpp2ILInjected.Address(RVA = "0x132DABC", Offset = "0x132DABC", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "GetCollisionPointForTile", MemberParameters = new object[]
		{
			typeof(BallCollision.TileEdges),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref Vector2),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static bool GetSlopeEdge(ref BallCollision.TileEdges edgesToTest, Tile tile, Vector2 tilePosition, ref LineSegment edge)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600325D")]
		[global::Cpp2ILInjected.Address(RVA = "0x132DD64", Offset = "0x132DD64", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "GetCollisionPointForTile", MemberParameters = new object[]
		{
			typeof(BallCollision.TileEdges),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref Vector2),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "IsNeighborSolid", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool GetTopOrBottomEdge(BallCollision.TileEdges edgesToTest, int x, int y, Vector2 tilePosition, ref LineSegment edge)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600325E")]
		[global::Cpp2ILInjected.Address(RVA = "0x132DFD0", Offset = "0x132DFD0", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "GetCollisionPointForTile", MemberParameters = new object[]
		{
			typeof(BallCollision.TileEdges),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref Vector2),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BallCollision), Member = "IsNeighborSolid", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool GetLeftOrRightEdge(BallCollision.TileEdges edgesToTest, int x, int y, Vector2 tilePosition, ref LineSegment edge)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600325F")]
		[global::Cpp2ILInjected.Address(RVA = "0x132D614", Offset = "0x132D614", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "GetClosestEdgeToCircle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref Vector2),
			typeof(ref Tile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static Rectangle GetTileBounds(Vector2 position, Vector2 size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003260")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E274", Offset = "0x132E274", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "GetTopOrBottomEdge", MemberParameters = new object[]
		{
			typeof(BallCollision.TileEdges),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref LineSegment)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "GetLeftOrRightEdge", MemberParameters = new object[]
		{
			typeof(BallCollision.TileEdges),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref LineSegment)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsNeighborSolid(Tile tile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003261")]
		[global::Cpp2ILInjected.Address(RVA = "0x132DC00", Offset = "0x132DC00", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "GetCollisionPointForTile", MemberParameters = new object[]
		{
			typeof(BallCollision.TileEdges),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref Vector2),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "LengthSquared", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Dot", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static Vector2 ClosestPointOnLineSegment(Vector2 point, LineSegment lineSegment)
		{
			throw null;
		}

		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6003262")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E338", Offset = "0x132E338", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DrawEdge(LineSegment edge)
		{
			throw null;
		}

		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x200053D")]
		private enum TileEdges : uint
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003B85")]
			None = 0U,
			[global::Cpp2ILInjected.Token(Token = "0x4003B86")]
			Top = 1U,
			[global::Cpp2ILInjected.Token(Token = "0x4003B87")]
			Bottom = 2U,
			[global::Cpp2ILInjected.Token(Token = "0x4003B88")]
			Left = 4U,
			[global::Cpp2ILInjected.Token(Token = "0x4003B89")]
			Right = 8U,
			[global::Cpp2ILInjected.Token(Token = "0x4003B8A")]
			TopLeftSlope = 16U,
			[global::Cpp2ILInjected.Token(Token = "0x4003B8B")]
			TopRightSlope = 32U,
			[global::Cpp2ILInjected.Token(Token = "0x4003B8C")]
			BottomLeftSlope = 64U,
			[global::Cpp2ILInjected.Token(Token = "0x4003B8D")]
			BottomRightSlope = 128U
		}
	}
}
