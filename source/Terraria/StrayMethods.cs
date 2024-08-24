using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Events;

namespace Terraria
{
	// Token: 0x02000347 RID: 839
	[global::Cpp2ILInjected.Token(Token = "0x200045D")]
	public class StrayMethods
	{
		// Token: 0x06002780 RID: 10112 RVA: 0x000290B7 File Offset: 0x000272B7
		[global::Cpp2ILInjected.Token(Token = "0x6002A3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1170EBC", Offset = "0x1170EBC", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTileAllowBottomSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool CountSandHorizontally(int i, int j, bool[] fittingTypes, int requiredTotalSpread = 4, int spreadInEachAxis = 5)
		{
			throw null;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000290BA File Offset: 0x000272BA
		[global::Cpp2ILInjected.Token(Token = "0x6002A3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171134", Offset = "0x1171134", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "ExpandVertically", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool CanSpawnSandstormHostile(Vector2 position, int expandUp, int expandDown)
		{
			throw null;
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000290BD File Offset: 0x000272BD
		[global::Cpp2ILInjected.Token(Token = "0x6002A3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171240", Offset = "0x1171240", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CommandForbiddenStorm", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "ExpandVertically", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool CanSpawnSandstormFriendly(Vector2 position, int expandUp, int expandDown)
		{
			throw null;
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000290C0 File Offset: 0x000272C0
		[global::Cpp2ILInjected.Token(Token = "0x6002A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x117134C", Offset = "0x117134C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "WouldFailSpawningHere", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "ExpandVertically", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StrayMethods), Member = "SendWalker", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref Point),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void CheckArenaScore(Vector2 arenaCenter, out Point xLeftEnd, out Point xRightEnd, int walkerWidthInTiles = 5, int walkerHeightInTiles = 10)
		{
			throw null;
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000290C3 File Offset: 0x000272C3
		[global::Cpp2ILInjected.Token(Token = "0x6002A3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x11714C4", Offset = "0x11714C4", Length = "0x42C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StrayMethods), Member = "CheckArenaScore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref Point),
			typeof(ref Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "ExpandVertically", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "QuickBox", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(Color),
			typeof(Action<Dust>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "QuickDust", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Color)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void SendWalker(Point startFloorPosition, int height, int direction, out int distanceCoveredInTiles, out Point lastIteratedFloorSpot, int maxDistance = 100, bool showDebug = false)
		{
			throw null;
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000290C6 File Offset: 0x000272C6
		[global::Cpp2ILInjected.Token(Token = "0x6002A3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x11718F0", Offset = "0x11718F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public StrayMethods()
		{
			throw null;
		}
	}
}
