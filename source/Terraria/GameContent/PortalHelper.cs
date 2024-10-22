﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.Graphics.Light;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007B1")]
	public class PortalHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004022")]
		[global::Cpp2ILInjected.Address(RVA = "0x750328", Offset = "0x750328", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static PortalHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004023")]
		[global::Cpp2ILInjected.Address(RVA = "0x7506AC", Offset = "0x7506AC", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static void UpdatePortalPoints()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004024")]
		[global::Cpp2ILInjected.Address(RVA = "0x750A38", Offset = "0x750A38", Length = "0xF20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "TryPortalJumping", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryPortalJumping", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "GetPortalEdges", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "CheckAABBvLineCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "GetPortalOutingPoint", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "TileCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "HasNaNs", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "Teleport", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "Teleport", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 63)]
		public static void TryGoingThroughPortals(Entity ent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004025")]
		[global::Cpp2ILInjected.Address(RVA = "0x751CE8", Offset = "0x751CE8", Length = "0x61C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "HandleMovement", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "FindCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidOrSlopedTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Dot", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "FindValidLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "AddPortal", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static int TryPlacingPortal(Projectile theBolt, Vector2 velocity, Vector2 theCrashVelocity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004026")]
		[global::Cpp2ILInjected.Address(RVA = "0x752458", Offset = "0x752458", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "TryPlacingPortal", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "IsValidLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool FindValidLine(Point position, int xOffset, int yOffset, out Point bestPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004027")]
		[global::Cpp2ILInjected.Address(RVA = "0x7526FC", Offset = "0x7526FC", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "FindValidLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "BlockPortals", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "CanPlacePortalOn", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "HasSameSlope", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool IsValidLine(Point position, int xOffset, int yOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004028")]
		[global::Cpp2ILInjected.Address(RVA = "0x752A84", Offset = "0x752A84", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "IsValidLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidOrSlopedTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool CanPlacePortalOn(Tile t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004029")]
		[global::Cpp2ILInjected.Address(RVA = "0x752B34", Offset = "0x752B34", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool DoesTileTypeSupportPortals(ushort tileType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600402A")]
		[global::Cpp2ILInjected.Address(RVA = "0x752978", Offset = "0x752978", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "IsValidLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool BlockPortals(Tile t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600402B")]
		[global::Cpp2ILInjected.Address(RVA = "0x752304", Offset = "0x752304", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "TryPlacingPortal", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper.<>c__DisplayClass17_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils.TileActionAttempt), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static Vector2 FindCollision(Vector2 startPosition, Vector2 stopPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600402C")]
		[global::Cpp2ILInjected.Address(RVA = "0x752580", Offset = "0x752580", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "TryPlacingPortal", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "SupportedTilesAreFine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "RemoveMyOldPortal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "RemoveIntersectingPortals", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "InheritSource", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "NewProjectile", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static int AddPortal(Projectile sourceProjectile, Vector2 position, float angle, int form, int direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600402D")]
		[global::Cpp2ILInjected.Address(RVA = "0x753060", Offset = "0x753060", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "AddPortal", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void RemoveMyOldPortal(int form)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600402E")]
		[global::Cpp2ILInjected.Address(RVA = "0x75314C", Offset = "0x75314C", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "AddPortal", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "GetPortalEdges", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "CheckLinevLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void RemoveIntersectingPortals(Vector2 position, float angle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600402F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7533F8", Offset = "0x7533F8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TeleportEffect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(TeleportationSide),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "UpdateNPC_TeleportVisuals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateTeleportVisuals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "GetPortalColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Color GetPortalColor(int colorIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004030")]
		[global::Cpp2ILInjected.Address(RVA = "0x753464", Offset = "0x753464", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetAlpha", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ExportTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(LightMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplyTileLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref FastRandom),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "GetPortalColor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Color GetPortalColor(int player, int portal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004031")]
		[global::Cpp2ILInjected.Address(RVA = "0x751958", Offset = "0x751958", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "TryGoingThroughPortals", MemberParameters = new object[] { typeof(Entity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "RemoveIntersectingPortals", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void GetPortalEdges(Vector2 position, float angle, out Vector2 start, out Vector2 end)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004032")]
		[global::Cpp2ILInjected.Address(RVA = "0x751A68", Offset = "0x751A68", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "TryGoingThroughPortals", MemberParameters = new object[] { typeof(Entity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "WrapAngle", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static Vector2 GetPortalOutingPoint(Vector2 objectSize, Vector2 portalPosition, float portalAngle, out int bonusX, out int bonusY)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004033")]
		[global::Cpp2ILInjected.Address(RVA = "0x7535A4", Offset = "0x7535A4", Length = "0x368")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "GetSectionX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "GetSectionY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void SyncPortalsOnPlayerJoin(int plr, int fluff, List<Point> dontInclude, out List<Point> portalSections)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004034")]
		[global::Cpp2ILInjected.Address(RVA = "0x75390C", Offset = "0x75390C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemoteClient), Member = "CheckSection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SyncPortalSections(Vector2 portalPosition, int fluff)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004035")]
		[global::Cpp2ILInjected.Address(RVA = "0x752B44", Offset = "0x752B44", Length = "0x51C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "AddPortal", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "WrapAngle", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "SupportedSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "SupportedNormal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PortalHelper), Member = "SupportedHalfbrick", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public static bool SupportedTilesAreFine(Vector2 portalCenter, float portalAngle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004036")]
		[global::Cpp2ILInjected.Address(RVA = "0x7539F8", Offset = "0x7539F8", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "SupportedTilesAreFine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool SupportedSlope(int x, int y, int slope)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004037")]
		[global::Cpp2ILInjected.Address(RVA = "0x753D88", Offset = "0x753D88", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "SupportedTilesAreFine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool SupportedHalfbrick(int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004038")]
		[global::Cpp2ILInjected.Address(RVA = "0x753BA4", Offset = "0x753BA4", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "SupportedTilesAreFine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool SupportedNormal(int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004039")]
		[global::Cpp2ILInjected.Address(RVA = "0x753F24", Offset = "0x753F24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PortalHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E01")]
		private static int[,] FoundPortals;

		[global::Cpp2ILInjected.Token(Token = "0x4007E02")]
		private static int[] PortalCooldownForPlayers;

		[global::Cpp2ILInjected.Token(Token = "0x4007E03")]
		private static int[] PortalCooldownForNPCs;

		[global::Cpp2ILInjected.Token(Token = "0x4007E04")]
		private static bool anyPortalAtAll;

		[global::Cpp2ILInjected.Token(Token = "0x4007E05")]
		public const int PORTALS_PER_PERSON = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4007E06")]
		private static readonly Vector2[] EDGES;

		[global::Cpp2ILInjected.Token(Token = "0x4007E07")]
		private static readonly Vector2[] SLOPE_EDGES;

		[global::Cpp2ILInjected.Token(Token = "0x4007E08")]
		private static readonly Point[] SLOPE_OFFSETS;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007B2")]
		private sealed class <>c__DisplayClass17_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x600403A")]
			[global::Cpp2ILInjected.Address(RVA = "0x76AFBC", Offset = "0x76AFBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "FindCollision", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass17_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600403B")]
			[global::Cpp2ILInjected.Address(RVA = "0x76AFC4", Offset = "0x76AFC4", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidOrSlopedTile", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <FindCollision>b__0(int x, int y)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007E09")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int lastX;

			[global::Cpp2ILInjected.Token(Token = "0x4007E0A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int lastY;
		}
	}
}
