using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Events
{
	// Token: 0x0200068E RID: 1678
	[global::Cpp2ILInjected.Token(Token = "0x2000A4E")]
	public class CultistRitual
	{
		// Token: 0x060041C3 RID: 16835 RVA: 0x0002DBFF File Offset: 0x0002BDFF
		[global::Cpp2ILInjected.Token(Token = "0x6004DAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C58E0", Offset = "0x8C58E0", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyDanger", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void UpdateTime()
		{
			throw null;
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x0002DC02 File Offset: 0x0002BE02
		[global::Cpp2ILInjected.Token(Token = "0x6004DB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C5B84", Offset = "0x8C5B84", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void CultistSlain()
		{
			throw null;
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x0002DC05 File Offset: 0x0002BE05
		[global::Cpp2ILInjected.Token(Token = "0x6004DB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C5BD4", Offset = "0x8C5BD4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void TabletDestroyed()
		{
			throw null;
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x0002DC08 File Offset: 0x0002BE08
		[global::Cpp2ILInjected.Token(Token = "0x6004DB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C5A50", Offset = "0x8C5A50", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlayerLOS", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultistRitual), Member = "CheckRitual", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_WorldEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void TrySpawning(int x, int y)
		{
			throw null;
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x0002DC0B File Offset: 0x0002BE0B
		[global::Cpp2ILInjected.Token(Token = "0x6004DB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C5C20", Offset = "0x8C5C20", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultistRitual), Member = "TrySpawning", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultistRitual), Member = "CheckFloor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref Point[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool CheckRitual(int x, int y)
		{
			throw null;
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x0002DC0E File Offset: 0x0002BE0E
		[global::Cpp2ILInjected.Token(Token = "0x6004DB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C5DEC", Offset = "0x8C5DEC", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultistRitual), Member = "CheckRitual", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "SolidTiles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static bool CheckFloor(Vector2 Center, out Point[] spawnPoints)
		{
			throw null;
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x0002DC11 File Offset: 0x0002BE11
		[global::Cpp2ILInjected.Token(Token = "0x6004DB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C60C4", Offset = "0x8C60C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CultistRitual()
		{
			throw null;
		}

		// Token: 0x04006DDC RID: 28124
		[global::Cpp2ILInjected.Token(Token = "0x40086A2")]
		public static int delay;

		// Token: 0x04006DDD RID: 28125
		[global::Cpp2ILInjected.Token(Token = "0x40086A3")]
		public static int recheck;

		// Token: 0x04006DDE RID: 28126
		[global::Cpp2ILInjected.Token(Token = "0x40086A4")]
		public const int delayStart = 86400;

		// Token: 0x04006DDF RID: 28127
		[global::Cpp2ILInjected.Token(Token = "0x40086A5")]
		public const int respawnDelay = 43200;

		// Token: 0x04006DE0 RID: 28128
		[global::Cpp2ILInjected.Token(Token = "0x40086A6")]
		private const int timePerCultist = 3600;

		// Token: 0x04006DE1 RID: 28129
		[global::Cpp2ILInjected.Token(Token = "0x40086A7")]
		private const int recheckStart = 600;
	}
}
