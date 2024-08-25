using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.DataStructures;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004E3")]
	public static class GenVars
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003058")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FA984", Offset = "0x12FA984", Length = "0x590")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		static GenVars()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40039E9")]
		public static WorldGenConfiguration configuration;

		[global::Cpp2ILInjected.Token(Token = "0x40039EA")]
		public static StructureMap structures;

		[global::Cpp2ILInjected.Token(Token = "0x40039EB")]
		public static int copper;

		[global::Cpp2ILInjected.Token(Token = "0x40039EC")]
		public static int iron;

		[global::Cpp2ILInjected.Token(Token = "0x40039ED")]
		public static int silver;

		[global::Cpp2ILInjected.Token(Token = "0x40039EE")]
		public static int gold;

		[global::Cpp2ILInjected.Token(Token = "0x40039EF")]
		public static int copperBar;

		[global::Cpp2ILInjected.Token(Token = "0x40039F0")]
		public static int ironBar;

		[global::Cpp2ILInjected.Token(Token = "0x40039F1")]
		public static int silverBar;

		[global::Cpp2ILInjected.Token(Token = "0x40039F2")]
		public static int goldBar;

		[global::Cpp2ILInjected.Token(Token = "0x40039F3")]
		public static ushort mossTile;

		[global::Cpp2ILInjected.Token(Token = "0x40039F4")]
		public static ushort mossWall;

		[global::Cpp2ILInjected.Token(Token = "0x40039F5")]
		public static int lavaLine;

		[global::Cpp2ILInjected.Token(Token = "0x40039F6")]
		public static int waterLine;

		[global::Cpp2ILInjected.Token(Token = "0x40039F7")]
		public static double worldSurfaceLow;

		[global::Cpp2ILInjected.Token(Token = "0x40039F8")]
		public static double worldSurface;

		[global::Cpp2ILInjected.Token(Token = "0x40039F9")]
		public static double worldSurfaceHigh;

		[global::Cpp2ILInjected.Token(Token = "0x40039FA")]
		public static double rockLayerLow;

		[global::Cpp2ILInjected.Token(Token = "0x40039FB")]
		public static double rockLayer;

		[global::Cpp2ILInjected.Token(Token = "0x40039FC")]
		public static double rockLayerHigh;

		[global::Cpp2ILInjected.Token(Token = "0x40039FD")]
		public static int snowTop;

		[global::Cpp2ILInjected.Token(Token = "0x40039FE")]
		public static int snowBottom;

		[global::Cpp2ILInjected.Token(Token = "0x40039FF")]
		public static int snowOriginLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4003A00")]
		public static int snowOriginRight;

		[global::Cpp2ILInjected.Token(Token = "0x4003A01")]
		public static int[] snowMinX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A02")]
		public static int[] snowMaxX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A03")]
		public static int leftBeachEnd;

		[global::Cpp2ILInjected.Token(Token = "0x4003A04")]
		public static int rightBeachStart;

		[global::Cpp2ILInjected.Token(Token = "0x4003A05")]
		public static int beachBordersWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4003A06")]
		public static int beachSandRandomCenter;

		[global::Cpp2ILInjected.Token(Token = "0x4003A07")]
		public static int beachSandRandomWidthRange;

		[global::Cpp2ILInjected.Token(Token = "0x4003A08")]
		public static int beachSandDungeonExtraWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4003A09")]
		public static int beachSandJungleExtraWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4003A0A")]
		public static int shellStartXLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4003A0B")]
		public static int shellStartYLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4003A0C")]
		public static int shellStartXRight;

		[global::Cpp2ILInjected.Token(Token = "0x4003A0D")]
		public static int shellStartYRight;

		[global::Cpp2ILInjected.Token(Token = "0x4003A0E")]
		public static int oceanWaterStartRandomMin;

		[global::Cpp2ILInjected.Token(Token = "0x4003A0F")]
		public static int oceanWaterStartRandomMax;

		[global::Cpp2ILInjected.Token(Token = "0x4003A10")]
		public static int oceanWaterForcedJungleLength;

		[global::Cpp2ILInjected.Token(Token = "0x4003A11")]
		public static int evilBiomeBeachAvoidance;

		[global::Cpp2ILInjected.Token(Token = "0x4003A12")]
		public static int evilBiomeAvoidanceMidFixer;

		[global::Cpp2ILInjected.Token(Token = "0x4003A13")]
		public static int lakesBeachAvoidance;

		[global::Cpp2ILInjected.Token(Token = "0x4003A14")]
		public static int smallHolesBeachAvoidance;

		[global::Cpp2ILInjected.Token(Token = "0x4003A15")]
		public static int surfaceCavesBeachAvoidance;

		[global::Cpp2ILInjected.Token(Token = "0x4003A16")]
		public static int surfaceCavesBeachAvoidance2;

		[global::Cpp2ILInjected.Token(Token = "0x4003A17")]
		public static readonly int maxOceanCaveTreasure;

		[global::Cpp2ILInjected.Token(Token = "0x4003A18")]
		public static int numOceanCaveTreasure;

		[global::Cpp2ILInjected.Token(Token = "0x4003A19")]
		public static Point[] oceanCaveTreasure;

		[global::Cpp2ILInjected.Token(Token = "0x4003A1A")]
		public static bool skipDesertTileCheck;

		[global::Cpp2ILInjected.Token(Token = "0x4003A1B")]
		public static Rectangle UndergroundDesertLocation;

		[global::Cpp2ILInjected.Token(Token = "0x4003A1C")]
		public static Rectangle UndergroundDesertHiveLocation;

		[global::Cpp2ILInjected.Token(Token = "0x4003A1D")]
		public static int desertHiveHigh;

		[global::Cpp2ILInjected.Token(Token = "0x4003A1E")]
		public static int desertHiveLow;

		[global::Cpp2ILInjected.Token(Token = "0x4003A1F")]
		public static int desertHiveLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4003A20")]
		public static int desertHiveRight;

		[global::Cpp2ILInjected.Token(Token = "0x4003A21")]
		public static int numLarva;

		[global::Cpp2ILInjected.Token(Token = "0x4003A22")]
		public static int[] larvaY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A23")]
		public static int[] larvaX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A24")]
		public static int numPyr;

		[global::Cpp2ILInjected.Token(Token = "0x4003A25")]
		public static int[] PyrX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A26")]
		public static int[] PyrY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A27")]
		public static int extraBastStatueCount;

		[global::Cpp2ILInjected.Token(Token = "0x4003A28")]
		public static int extraBastStatueCountMax;

		[global::Cpp2ILInjected.Token(Token = "0x4003A29")]
		public static int jungleOriginX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A2A")]
		public static int jungleMinX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A2B")]
		public static int jungleMaxX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A2C")]
		public static int JungleX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A2D")]
		public static ushort jungleHut;

		[global::Cpp2ILInjected.Token(Token = "0x4003A2E")]
		public static bool mudWall;

		[global::Cpp2ILInjected.Token(Token = "0x4003A2F")]
		public static int JungleItemCount;

		[global::Cpp2ILInjected.Token(Token = "0x4003A30")]
		public static int[] JChestX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A31")]
		public static int[] JChestY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A32")]
		public static int numJChests;

		[global::Cpp2ILInjected.Token(Token = "0x4003A33")]
		public static int tLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4003A34")]
		public static int tRight;

		[global::Cpp2ILInjected.Token(Token = "0x4003A35")]
		public static int tTop;

		[global::Cpp2ILInjected.Token(Token = "0x4003A36")]
		public static int tBottom;

		[global::Cpp2ILInjected.Token(Token = "0x4003A37")]
		public static int tRooms;

		[global::Cpp2ILInjected.Token(Token = "0x4003A38")]
		public static int lAltarX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A39")]
		public static int lAltarY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A3A")]
		public static int dungeonSide;

		[global::Cpp2ILInjected.Token(Token = "0x4003A3B")]
		public static int dungeonLocation;

		[global::Cpp2ILInjected.Token(Token = "0x4003A3C")]
		public static bool dungeonLake;

		[global::Cpp2ILInjected.Token(Token = "0x4003A3D")]
		public static ushort crackedType;

		[global::Cpp2ILInjected.Token(Token = "0x4003A3E")]
		public static int dungeonX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A3F")]
		public static int dungeonY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A40")]
		public static Vector2D lastDungeonHall;

		[global::Cpp2ILInjected.Token(Token = "0x4003A41")]
		public static readonly int maxDRooms;

		[global::Cpp2ILInjected.Token(Token = "0x4003A42")]
		public static int numDRooms;

		[global::Cpp2ILInjected.Token(Token = "0x4003A43")]
		public static int[] dRoomX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A44")]
		public static int[] dRoomY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A45")]
		public static int[] dRoomSize;

		[global::Cpp2ILInjected.Token(Token = "0x4003A46")]
		public static bool[] dRoomTreasure;

		[global::Cpp2ILInjected.Token(Token = "0x4003A47")]
		public static int[] dRoomL;

		[global::Cpp2ILInjected.Token(Token = "0x4003A48")]
		public static int[] dRoomR;

		[global::Cpp2ILInjected.Token(Token = "0x4003A49")]
		public static int[] dRoomT;

		[global::Cpp2ILInjected.Token(Token = "0x4003A4A")]
		public static int[] dRoomB;

		[global::Cpp2ILInjected.Token(Token = "0x4003A4B")]
		public static int numDDoors;

		[global::Cpp2ILInjected.Token(Token = "0x4003A4C")]
		public static int[] DDoorX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A4D")]
		public static int[] DDoorY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A4E")]
		public static int[] DDoorPos;

		[global::Cpp2ILInjected.Token(Token = "0x4003A4F")]
		public static int numDungeonPlatforms;

		[global::Cpp2ILInjected.Token(Token = "0x4003A50")]
		public static int[] dungeonPlatformX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A51")]
		public static int[] dungeonPlatformY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A52")]
		public static int dEnteranceX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A53")]
		public static bool dSurface;

		[global::Cpp2ILInjected.Token(Token = "0x4003A54")]
		public static double dxStrength1;

		[global::Cpp2ILInjected.Token(Token = "0x4003A55")]
		public static double dyStrength1;

		[global::Cpp2ILInjected.Token(Token = "0x4003A56")]
		public static double dxStrength2;

		[global::Cpp2ILInjected.Token(Token = "0x4003A57")]
		public static double dyStrength2;

		[global::Cpp2ILInjected.Token(Token = "0x4003A58")]
		public static int dMinX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A59")]
		public static int dMaxX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A5A")]
		public static int dMinY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A5B")]
		public static int dMaxY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A5C")]
		public static int skyLakes;

		[global::Cpp2ILInjected.Token(Token = "0x4003A5D")]
		public static bool generatedShadowKey;

		[global::Cpp2ILInjected.Token(Token = "0x4003A5E")]
		public static int numIslandHouses;

		[global::Cpp2ILInjected.Token(Token = "0x4003A5F")]
		public static int skyIslandHouseCount;

		[global::Cpp2ILInjected.Token(Token = "0x4003A60")]
		public static bool[] skyLake;

		[global::Cpp2ILInjected.Token(Token = "0x4003A61")]
		public static int[] floatingIslandHouseX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A62")]
		public static int[] floatingIslandHouseY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A63")]
		public static int[] floatingIslandStyle;

		[global::Cpp2ILInjected.Token(Token = "0x4003A64")]
		public static int numMCaves;

		[global::Cpp2ILInjected.Token(Token = "0x4003A65")]
		public static int[] mCaveX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A66")]
		public static int[] mCaveY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A67")]
		public static readonly int maxTunnels;

		[global::Cpp2ILInjected.Token(Token = "0x4003A68")]
		public static int numTunnels;

		[global::Cpp2ILInjected.Token(Token = "0x4003A69")]
		public static int[] tunnelX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A6A")]
		public static readonly int maxOrePatch;

		[global::Cpp2ILInjected.Token(Token = "0x4003A6B")]
		public static int numOrePatch;

		[global::Cpp2ILInjected.Token(Token = "0x4003A6C")]
		public static int[] orePatchX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A6D")]
		public static readonly int maxMushroomBiomes;

		[global::Cpp2ILInjected.Token(Token = "0x4003A6E")]
		public static int numMushroomBiomes;

		[global::Cpp2ILInjected.Token(Token = "0x4003A6F")]
		public static Point[] mushroomBiomesPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4003A70")]
		public static int logX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A71")]
		public static int logY;

		[global::Cpp2ILInjected.Token(Token = "0x4003A72")]
		public static readonly int maxLakes;

		[global::Cpp2ILInjected.Token(Token = "0x4003A73")]
		public static int numLakes;

		[global::Cpp2ILInjected.Token(Token = "0x4003A74")]
		public static int[] LakeX;

		[global::Cpp2ILInjected.Token(Token = "0x4003A75")]
		public static readonly int maxOasis;

		[global::Cpp2ILInjected.Token(Token = "0x4003A76")]
		public static int numOasis;

		[global::Cpp2ILInjected.Token(Token = "0x4003A77")]
		public static Point[] oasisPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4003A78")]
		public static int[] oasisWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4003A79")]
		public static readonly int oasisHeight;

		[global::Cpp2ILInjected.Token(Token = "0x4003A7A")]
		public static int hellChest;

		[global::Cpp2ILInjected.Token(Token = "0x4003A7B")]
		public static int[] hellChestItem;

		[global::Cpp2ILInjected.Token(Token = "0x4003A7C")]
		public static Point16[] statueList;

		[global::Cpp2ILInjected.Token(Token = "0x4003A7D")]
		public static List<int> StatuesWithTraps;

		[global::Cpp2ILInjected.Token(Token = "0x4003A7E")]
		public static bool crimsonLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4003A7F")]
		public static Vector2D shimmerPosition;
	}
}
