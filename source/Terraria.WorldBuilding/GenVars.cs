using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.DataStructures;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000367")]
public static class GenVars
{
	[Cpp2IlInjected.Token(Token = "0x40030CF")]
	public static WorldGenConfiguration configuration;

	[Cpp2IlInjected.Token(Token = "0x40030D0")]
	public static StructureMap structures;

	[Cpp2IlInjected.Token(Token = "0x40030D1")]
	public static int copper;

	[Cpp2IlInjected.Token(Token = "0x40030D2")]
	public static int iron;

	[Cpp2IlInjected.Token(Token = "0x40030D3")]
	public static int silver;

	[Cpp2IlInjected.Token(Token = "0x40030D4")]
	public static int gold;

	[Cpp2IlInjected.Token(Token = "0x40030D5")]
	public static int copperBar;

	[Cpp2IlInjected.Token(Token = "0x40030D6")]
	public static int ironBar;

	[Cpp2IlInjected.Token(Token = "0x40030D7")]
	public static int silverBar;

	[Cpp2IlInjected.Token(Token = "0x40030D8")]
	public static int goldBar;

	[Cpp2IlInjected.Token(Token = "0x40030D9")]
	public static ushort mossTile;

	[Cpp2IlInjected.Token(Token = "0x40030DA")]
	public static ushort mossWall;

	[Cpp2IlInjected.Token(Token = "0x40030DB")]
	public static int lavaLine;

	[Cpp2IlInjected.Token(Token = "0x40030DC")]
	public static int waterLine;

	[Cpp2IlInjected.Token(Token = "0x40030DD")]
	public static double worldSurfaceLow;

	[Cpp2IlInjected.Token(Token = "0x40030DE")]
	public static double worldSurface;

	[Cpp2IlInjected.Token(Token = "0x40030DF")]
	public static double worldSurfaceHigh;

	[Cpp2IlInjected.Token(Token = "0x40030E0")]
	public static double rockLayerLow;

	[Cpp2IlInjected.Token(Token = "0x40030E1")]
	public static double rockLayer;

	[Cpp2IlInjected.Token(Token = "0x40030E2")]
	public static double rockLayerHigh;

	[Cpp2IlInjected.Token(Token = "0x40030E3")]
	public static int snowTop;

	[Cpp2IlInjected.Token(Token = "0x40030E4")]
	public static int snowBottom;

	[Cpp2IlInjected.Token(Token = "0x40030E5")]
	public static int snowOriginLeft;

	[Cpp2IlInjected.Token(Token = "0x40030E6")]
	public static int snowOriginRight;

	[Cpp2IlInjected.Token(Token = "0x40030E7")]
	public static int[] snowMinX;

	[Cpp2IlInjected.Token(Token = "0x40030E8")]
	public static int[] snowMaxX;

	[Cpp2IlInjected.Token(Token = "0x40030E9")]
	public static int leftBeachEnd;

	[Cpp2IlInjected.Token(Token = "0x40030EA")]
	public static int rightBeachStart;

	[Cpp2IlInjected.Token(Token = "0x40030EB")]
	public static int beachBordersWidth;

	[Cpp2IlInjected.Token(Token = "0x40030EC")]
	public static int beachSandRandomCenter;

	[Cpp2IlInjected.Token(Token = "0x40030ED")]
	public static int beachSandRandomWidthRange;

	[Cpp2IlInjected.Token(Token = "0x40030EE")]
	public static int beachSandDungeonExtraWidth;

	[Cpp2IlInjected.Token(Token = "0x40030EF")]
	public static int beachSandJungleExtraWidth;

	[Cpp2IlInjected.Token(Token = "0x40030F0")]
	public static int shellStartXLeft;

	[Cpp2IlInjected.Token(Token = "0x40030F1")]
	public static int shellStartYLeft;

	[Cpp2IlInjected.Token(Token = "0x40030F2")]
	public static int shellStartXRight;

	[Cpp2IlInjected.Token(Token = "0x40030F3")]
	public static int shellStartYRight;

	[Cpp2IlInjected.Token(Token = "0x40030F4")]
	public static int oceanWaterStartRandomMin;

	[Cpp2IlInjected.Token(Token = "0x40030F5")]
	public static int oceanWaterStartRandomMax;

	[Cpp2IlInjected.Token(Token = "0x40030F6")]
	public static int oceanWaterForcedJungleLength;

	[Cpp2IlInjected.Token(Token = "0x40030F7")]
	public static int evilBiomeBeachAvoidance;

	[Cpp2IlInjected.Token(Token = "0x40030F8")]
	public static int evilBiomeAvoidanceMidFixer;

	[Cpp2IlInjected.Token(Token = "0x40030F9")]
	public static int lakesBeachAvoidance;

	[Cpp2IlInjected.Token(Token = "0x40030FA")]
	public static int smallHolesBeachAvoidance;

	[Cpp2IlInjected.Token(Token = "0x40030FB")]
	public static int surfaceCavesBeachAvoidance;

	[Cpp2IlInjected.Token(Token = "0x40030FC")]
	public static int surfaceCavesBeachAvoidance2;

	[Cpp2IlInjected.Token(Token = "0x40030FD")]
	public static readonly int maxOceanCaveTreasure;

	[Cpp2IlInjected.Token(Token = "0x40030FE")]
	public static int numOceanCaveTreasure;

	[Cpp2IlInjected.Token(Token = "0x40030FF")]
	public static Point[] oceanCaveTreasure;

	[Cpp2IlInjected.Token(Token = "0x4003100")]
	public static bool skipDesertTileCheck;

	[Cpp2IlInjected.Token(Token = "0x4003101")]
	public static Rectangle UndergroundDesertLocation;

	[Cpp2IlInjected.Token(Token = "0x4003102")]
	public static Rectangle UndergroundDesertHiveLocation;

	[Cpp2IlInjected.Token(Token = "0x4003103")]
	public static int desertHiveHigh;

	[Cpp2IlInjected.Token(Token = "0x4003104")]
	public static int desertHiveLow;

	[Cpp2IlInjected.Token(Token = "0x4003105")]
	public static int desertHiveLeft;

	[Cpp2IlInjected.Token(Token = "0x4003106")]
	public static int desertHiveRight;

	[Cpp2IlInjected.Token(Token = "0x4003107")]
	public static int numLarva;

	[Cpp2IlInjected.Token(Token = "0x4003108")]
	public static int[] larvaY;

	[Cpp2IlInjected.Token(Token = "0x4003109")]
	public static int[] larvaX;

	[Cpp2IlInjected.Token(Token = "0x400310A")]
	public static int numPyr;

	[Cpp2IlInjected.Token(Token = "0x400310B")]
	public static int[] PyrX;

	[Cpp2IlInjected.Token(Token = "0x400310C")]
	public static int[] PyrY;

	[Cpp2IlInjected.Token(Token = "0x400310D")]
	public static int extraBastStatueCount;

	[Cpp2IlInjected.Token(Token = "0x400310E")]
	public static int extraBastStatueCountMax;

	[Cpp2IlInjected.Token(Token = "0x400310F")]
	public static int jungleOriginX;

	[Cpp2IlInjected.Token(Token = "0x4003110")]
	public static int jungleMinX;

	[Cpp2IlInjected.Token(Token = "0x4003111")]
	public static int jungleMaxX;

	[Cpp2IlInjected.Token(Token = "0x4003112")]
	public static int JungleX;

	[Cpp2IlInjected.Token(Token = "0x4003113")]
	public static ushort jungleHut;

	[Cpp2IlInjected.Token(Token = "0x4003114")]
	public static bool mudWall;

	[Cpp2IlInjected.Token(Token = "0x4003115")]
	public static int JungleItemCount;

	[Cpp2IlInjected.Token(Token = "0x4003116")]
	public static int[] JChestX;

	[Cpp2IlInjected.Token(Token = "0x4003117")]
	public static int[] JChestY;

	[Cpp2IlInjected.Token(Token = "0x4003118")]
	public static int numJChests;

	[Cpp2IlInjected.Token(Token = "0x4003119")]
	public static int tLeft;

	[Cpp2IlInjected.Token(Token = "0x400311A")]
	public static int tRight;

	[Cpp2IlInjected.Token(Token = "0x400311B")]
	public static int tTop;

	[Cpp2IlInjected.Token(Token = "0x400311C")]
	public static int tBottom;

	[Cpp2IlInjected.Token(Token = "0x400311D")]
	public static int tRooms;

	[Cpp2IlInjected.Token(Token = "0x400311E")]
	public static int lAltarX;

	[Cpp2IlInjected.Token(Token = "0x400311F")]
	public static int lAltarY;

	[Cpp2IlInjected.Token(Token = "0x4003120")]
	public static int dungeonSide;

	[Cpp2IlInjected.Token(Token = "0x4003121")]
	public static int dungeonLocation;

	[Cpp2IlInjected.Token(Token = "0x4003122")]
	public static bool dungeonLake;

	[Cpp2IlInjected.Token(Token = "0x4003123")]
	public static ushort crackedType;

	[Cpp2IlInjected.Token(Token = "0x4003124")]
	public static int dungeonX;

	[Cpp2IlInjected.Token(Token = "0x4003125")]
	public static int dungeonY;

	[Cpp2IlInjected.Token(Token = "0x4003126")]
	public static Vector2D lastDungeonHall;

	[Cpp2IlInjected.Token(Token = "0x4003127")]
	public static readonly int maxDRooms;

	[Cpp2IlInjected.Token(Token = "0x4003128")]
	public static int numDRooms;

	[Cpp2IlInjected.Token(Token = "0x4003129")]
	public static int[] dRoomX;

	[Cpp2IlInjected.Token(Token = "0x400312A")]
	public static int[] dRoomY;

	[Cpp2IlInjected.Token(Token = "0x400312B")]
	public static int[] dRoomSize;

	[Cpp2IlInjected.Token(Token = "0x400312C")]
	public static bool[] dRoomTreasure;

	[Cpp2IlInjected.Token(Token = "0x400312D")]
	public static int[] dRoomL;

	[Cpp2IlInjected.Token(Token = "0x400312E")]
	public static int[] dRoomR;

	[Cpp2IlInjected.Token(Token = "0x400312F")]
	public static int[] dRoomT;

	[Cpp2IlInjected.Token(Token = "0x4003130")]
	public static int[] dRoomB;

	[Cpp2IlInjected.Token(Token = "0x4003131")]
	public static int numDDoors;

	[Cpp2IlInjected.Token(Token = "0x4003132")]
	public static int[] DDoorX;

	[Cpp2IlInjected.Token(Token = "0x4003133")]
	public static int[] DDoorY;

	[Cpp2IlInjected.Token(Token = "0x4003134")]
	public static int[] DDoorPos;

	[Cpp2IlInjected.Token(Token = "0x4003135")]
	public static int numDungeonPlatforms;

	[Cpp2IlInjected.Token(Token = "0x4003136")]
	public static int[] dungeonPlatformX;

	[Cpp2IlInjected.Token(Token = "0x4003137")]
	public static int[] dungeonPlatformY;

	[Cpp2IlInjected.Token(Token = "0x4003138")]
	public static int dEnteranceX;

	[Cpp2IlInjected.Token(Token = "0x4003139")]
	public static bool dSurface;

	[Cpp2IlInjected.Token(Token = "0x400313A")]
	public static double dxStrength1;

	[Cpp2IlInjected.Token(Token = "0x400313B")]
	public static double dyStrength1;

	[Cpp2IlInjected.Token(Token = "0x400313C")]
	public static double dxStrength2;

	[Cpp2IlInjected.Token(Token = "0x400313D")]
	public static double dyStrength2;

	[Cpp2IlInjected.Token(Token = "0x400313E")]
	public static int dMinX;

	[Cpp2IlInjected.Token(Token = "0x400313F")]
	public static int dMaxX;

	[Cpp2IlInjected.Token(Token = "0x4003140")]
	public static int dMinY;

	[Cpp2IlInjected.Token(Token = "0x4003141")]
	public static int dMaxY;

	[Cpp2IlInjected.Token(Token = "0x4003142")]
	public static int skyLakes;

	[Cpp2IlInjected.Token(Token = "0x4003143")]
	public static bool generatedShadowKey;

	[Cpp2IlInjected.Token(Token = "0x4003144")]
	public static int numIslandHouses;

	[Cpp2IlInjected.Token(Token = "0x4003145")]
	public static int skyIslandHouseCount;

	[Cpp2IlInjected.Token(Token = "0x4003146")]
	public static bool[] skyLake;

	[Cpp2IlInjected.Token(Token = "0x4003147")]
	public static int[] floatingIslandHouseX;

	[Cpp2IlInjected.Token(Token = "0x4003148")]
	public static int[] floatingIslandHouseY;

	[Cpp2IlInjected.Token(Token = "0x4003149")]
	public static int[] floatingIslandStyle;

	[Cpp2IlInjected.Token(Token = "0x400314A")]
	public static int numMCaves;

	[Cpp2IlInjected.Token(Token = "0x400314B")]
	public static int[] mCaveX;

	[Cpp2IlInjected.Token(Token = "0x400314C")]
	public static int[] mCaveY;

	[Cpp2IlInjected.Token(Token = "0x400314D")]
	public static readonly int maxTunnels;

	[Cpp2IlInjected.Token(Token = "0x400314E")]
	public static int numTunnels;

	[Cpp2IlInjected.Token(Token = "0x400314F")]
	public static int[] tunnelX;

	[Cpp2IlInjected.Token(Token = "0x4003150")]
	public static readonly int maxOrePatch;

	[Cpp2IlInjected.Token(Token = "0x4003151")]
	public static int numOrePatch;

	[Cpp2IlInjected.Token(Token = "0x4003152")]
	public static int[] orePatchX;

	[Cpp2IlInjected.Token(Token = "0x4003153")]
	public static readonly int maxMushroomBiomes;

	[Cpp2IlInjected.Token(Token = "0x4003154")]
	public static int numMushroomBiomes;

	[Cpp2IlInjected.Token(Token = "0x4003155")]
	public static Point[] mushroomBiomesPosition;

	[Cpp2IlInjected.Token(Token = "0x4003156")]
	public static int logX;

	[Cpp2IlInjected.Token(Token = "0x4003157")]
	public static int logY;

	[Cpp2IlInjected.Token(Token = "0x4003158")]
	public static readonly int maxLakes;

	[Cpp2IlInjected.Token(Token = "0x4003159")]
	public static int numLakes;

	[Cpp2IlInjected.Token(Token = "0x400315A")]
	public static int[] LakeX;

	[Cpp2IlInjected.Token(Token = "0x400315B")]
	public static readonly int maxOasis;

	[Cpp2IlInjected.Token(Token = "0x400315C")]
	public static int numOasis;

	[Cpp2IlInjected.Token(Token = "0x400315D")]
	public static Point[] oasisPosition;

	[Cpp2IlInjected.Token(Token = "0x400315E")]
	public static int[] oasisWidth;

	[Cpp2IlInjected.Token(Token = "0x400315F")]
	public static readonly int oasisHeight;

	[Cpp2IlInjected.Token(Token = "0x4003160")]
	public static int hellChest;

	[Cpp2IlInjected.Token(Token = "0x4003161")]
	public static int[] hellChestItem;

	[Cpp2IlInjected.Token(Token = "0x4003162")]
	public static Point16[] statueList;

	[Cpp2IlInjected.Token(Token = "0x4003163")]
	public static List<int> StatuesWithTraps;

	[Cpp2IlInjected.Token(Token = "0x4003164")]
	public static bool crimsonLeft;

	[Cpp2IlInjected.Token(Token = "0x4003165")]
	public static Vector2D shimmerPosition;
}
