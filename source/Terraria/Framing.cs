using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x0200032D RID: 813
	[global::Cpp2ILInjected.Token(Token = "0x2000431")]
	public class Framing
	{
		// Token: 0x060025FE RID: 9726 RVA: 0x00028C49 File Offset: 0x00026E49
		[global::Cpp2ILInjected.Token(Token = "0x6002812")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D17BC", Offset = "0x10D17BC", Length = "0xBAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "Add8WayLookup", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "Add8WayLookup", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "AddWallFrameLookup", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00028C4C File Offset: 0x00026E4C
		[global::Cpp2ILInjected.Token(Token = "0x6002813")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D282C", Offset = "0x10D282C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "SelfFrame8Way", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "blockType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static Framing.BlockStyle FindBlockStyle(Tile blockTile)
		{
			throw null;
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x00028C4F File Offset: 0x00026E4F
		[global::Cpp2ILInjected.Token(Token = "0x6002814")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D2368", Offset = "0x10D2368", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Add8WayLookup(int lookup, short point1X, short point1Y, short point2X, short point2Y, short point3X, short point3Y)
		{
			throw null;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00028C52 File Offset: 0x00026E52
		[global::Cpp2ILInjected.Token(Token = "0x6002815")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D24EC", Offset = "0x10D24EC", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Add8WayLookup(int lookup, short x, short y)
		{
			throw null;
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x00028C55 File Offset: 0x00026E55
		[global::Cpp2ILInjected.Token(Token = "0x6002816")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D2664", Offset = "0x10D2664", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void AddWallFrameLookup(int lookup, short point1X, short point1Y, short point2X, short point2Y, short point3X, short point3Y, short point4X, short point4Y)
		{
			throw null;
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00028C58 File Offset: 0x00026E58
		[global::Cpp2ILInjected.Token(Token = "0x6002817")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D288C", Offset = "0x10D288C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "SelfFrame8Way", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool WillItBlend(ushort myType, ushort otherType)
		{
			throw null;
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00028C5B File Offset: 0x00026E5B
		[global::Cpp2ILInjected.Token(Token = "0x6002818")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D29A8", Offset = "0x10D29A8", Length = "0x538")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "FindBlockStyle", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(Framing.BlockStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "WillItBlend", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ushort)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "frameNumber", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "frameNumber", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void SelfFrame8Way(int i, int j, Tile centerTile, bool resetFrame)
		{
			throw null;
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00028C5E File Offset: 0x00026E5E
		[global::Cpp2ILInjected.Token(Token = "0x6002819")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D2FD4", Offset = "0x10D2FD4", Length = "0x5D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SquareWallFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "Reframe", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RangeFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "EveryTileFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PrepareForAreaDrawing", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_SkipFramingBecauseOfGen", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CacheUpdateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ShouldShowInvisibleWalls", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void WallFrame(int i, int j, bool resetFrame = false)
		{
			throw null;
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00028C61 File Offset: 0x00026E61
		[global::Cpp2ILInjected.Token(Token = "0x600281A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D35A8", Offset = "0x10D35A8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "UpdateDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryUsingDiggerCart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_067_FreakingPirates", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Tile GetTileSafely(Vector2 position)
		{
			throw null;
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00028C64 File Offset: 0x00026E64
		[global::Cpp2ILInjected.Token(Token = "0x600281B")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D3644", Offset = "0x10D3644", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "BuildInfoAccs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_112_FairyCritter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "MowTheLawn", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_149_GolfBall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_007_GrapplingHooks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Minecart), Member = "TryFittingTileOrientation", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int?),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "TryDigging", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "AlreadyLeadsIntoWantedTrack", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "CorrectTrackConnections", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSittingHelper), Member = "TryGetSittingBlock", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref Tile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TreeTopsInfo), Member = "RandomizeTreeStyleBasedOnWorldPosition", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		public static Tile GetTileSafely(Point pt)
		{
			throw null;
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00028C67 File Offset: 0x00026E67
		[global::Cpp2ILInjected.Token(Token = "0x600281C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D365C", Offset = "0x10D365C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		public static Tile GetTileSafely(Point16 pt)
		{
			throw null;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00028C6A File Offset: 0x00026E6A
		[global::Cpp2ILInjected.Token(Token = "0x600281D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D2EE0", Offset = "0x10D2EE0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 181)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Tile GetTileSafely(int i, int j)
		{
			throw null;
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00028C6D File Offset: 0x00026E6D
		[global::Cpp2ILInjected.Token(Token = "0x600281E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D367C", Offset = "0x10D367C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Framing()
		{
			throw null;
		}

		// Token: 0x04002CEB RID: 11499
		[global::Cpp2ILInjected.Token(Token = "0x400340C")]
		private static Point16[][] selfFrame8WayLookup;

		// Token: 0x04002CEC RID: 11500
		[global::Cpp2ILInjected.Token(Token = "0x400340D")]
		private static Point16[][] wallFrameLookup;

		// Token: 0x04002CED RID: 11501
		[global::Cpp2ILInjected.Token(Token = "0x400340E")]
		private static Point16 frameSize8Way;

		// Token: 0x04002CEE RID: 11502
		[global::Cpp2ILInjected.Token(Token = "0x400340F")]
		private static Point16 wallFrameSize;

		// Token: 0x04002CEF RID: 11503
		[global::Cpp2ILInjected.Token(Token = "0x4003410")]
		private static Framing.BlockStyle[] blockStyleLookup;

		// Token: 0x04002CF0 RID: 11504
		[global::Cpp2ILInjected.Token(Token = "0x4003411")]
		private static int[][] phlebasTileFrameNumberLookup;

		// Token: 0x04002CF1 RID: 11505
		[global::Cpp2ILInjected.Token(Token = "0x4003412")]
		private static int[][] lazureTileFrameNumberLookup;

		// Token: 0x04002CF2 RID: 11506
		[global::Cpp2ILInjected.Token(Token = "0x4003413")]
		private static int[][] centerWallFrameLookup;

		// Token: 0x0200085E RID: 2142
		[global::Cpp2ILInjected.Token(Token = "0x2000432")]
		private struct BlockStyle
		{
			// Token: 0x060049DF RID: 18911 RVA: 0x0002F16E File Offset: 0x0002D36E
			[global::Cpp2ILInjected.Token(Token = "0x600281F")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D2640", Offset = "0x10D2640", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public BlockStyle(bool up, bool down, bool left, bool right)
			{
				throw null;
			}

			// Token: 0x060049E0 RID: 18912 RVA: 0x0002F171 File Offset: 0x0002D371
			[global::Cpp2ILInjected.Token(Token = "0x6002820")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D2FCC", Offset = "0x10D2FCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x04007ED7 RID: 32471
			[global::Cpp2ILInjected.Token(Token = "0x4003414")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public bool top;

			// Token: 0x04007ED8 RID: 32472
			[global::Cpp2ILInjected.Token(Token = "0x4003415")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
			public bool bottom;

			// Token: 0x04007ED9 RID: 32473
			[global::Cpp2ILInjected.Token(Token = "0x4003416")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
			public bool left;

			// Token: 0x04007EDA RID: 32474
			[global::Cpp2ILInjected.Token(Token = "0x4003417")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3")]
			public bool right;
		}
	}
}
