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
	// Token: 0x02000365 RID: 869
	[global::Cpp2ILInjected.Token(Token = "0x20004E3")]
	public static class GenVars
	{
		// Token: 0x06002C52 RID: 11346 RVA: 0x00029F1B File Offset: 0x0002811B
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

		// Token: 0x040030D3 RID: 12499
		[global::Cpp2ILInjected.Token(Token = "0x40039E9")]
		public static WorldGenConfiguration configuration;

		// Token: 0x040030D4 RID: 12500
		[global::Cpp2ILInjected.Token(Token = "0x40039EA")]
		public static StructureMap structures;

		// Token: 0x040030D5 RID: 12501
		[global::Cpp2ILInjected.Token(Token = "0x40039EB")]
		public static int copper;

		// Token: 0x040030D6 RID: 12502
		[global::Cpp2ILInjected.Token(Token = "0x40039EC")]
		public static int iron;

		// Token: 0x040030D7 RID: 12503
		[global::Cpp2ILInjected.Token(Token = "0x40039ED")]
		public static int silver;

		// Token: 0x040030D8 RID: 12504
		[global::Cpp2ILInjected.Token(Token = "0x40039EE")]
		public static int gold;

		// Token: 0x040030D9 RID: 12505
		[global::Cpp2ILInjected.Token(Token = "0x40039EF")]
		public static int copperBar;

		// Token: 0x040030DA RID: 12506
		[global::Cpp2ILInjected.Token(Token = "0x40039F0")]
		public static int ironBar;

		// Token: 0x040030DB RID: 12507
		[global::Cpp2ILInjected.Token(Token = "0x40039F1")]
		public static int silverBar;

		// Token: 0x040030DC RID: 12508
		[global::Cpp2ILInjected.Token(Token = "0x40039F2")]
		public static int goldBar;

		// Token: 0x040030DD RID: 12509
		[global::Cpp2ILInjected.Token(Token = "0x40039F3")]
		public static ushort mossTile;

		// Token: 0x040030DE RID: 12510
		[global::Cpp2ILInjected.Token(Token = "0x40039F4")]
		public static ushort mossWall;

		// Token: 0x040030DF RID: 12511
		[global::Cpp2ILInjected.Token(Token = "0x40039F5")]
		public static int lavaLine;

		// Token: 0x040030E0 RID: 12512
		[global::Cpp2ILInjected.Token(Token = "0x40039F6")]
		public static int waterLine;

		// Token: 0x040030E1 RID: 12513
		[global::Cpp2ILInjected.Token(Token = "0x40039F7")]
		public static double worldSurfaceLow;

		// Token: 0x040030E2 RID: 12514
		[global::Cpp2ILInjected.Token(Token = "0x40039F8")]
		public static double worldSurface;

		// Token: 0x040030E3 RID: 12515
		[global::Cpp2ILInjected.Token(Token = "0x40039F9")]
		public static double worldSurfaceHigh;

		// Token: 0x040030E4 RID: 12516
		[global::Cpp2ILInjected.Token(Token = "0x40039FA")]
		public static double rockLayerLow;

		// Token: 0x040030E5 RID: 12517
		[global::Cpp2ILInjected.Token(Token = "0x40039FB")]
		public static double rockLayer;

		// Token: 0x040030E6 RID: 12518
		[global::Cpp2ILInjected.Token(Token = "0x40039FC")]
		public static double rockLayerHigh;

		// Token: 0x040030E7 RID: 12519
		[global::Cpp2ILInjected.Token(Token = "0x40039FD")]
		public static int snowTop;

		// Token: 0x040030E8 RID: 12520
		[global::Cpp2ILInjected.Token(Token = "0x40039FE")]
		public static int snowBottom;

		// Token: 0x040030E9 RID: 12521
		[global::Cpp2ILInjected.Token(Token = "0x40039FF")]
		public static int snowOriginLeft;

		// Token: 0x040030EA RID: 12522
		[global::Cpp2ILInjected.Token(Token = "0x4003A00")]
		public static int snowOriginRight;

		// Token: 0x040030EB RID: 12523
		[global::Cpp2ILInjected.Token(Token = "0x4003A01")]
		public static int[] snowMinX;

		// Token: 0x040030EC RID: 12524
		[global::Cpp2ILInjected.Token(Token = "0x4003A02")]
		public static int[] snowMaxX;

		// Token: 0x040030ED RID: 12525
		[global::Cpp2ILInjected.Token(Token = "0x4003A03")]
		public static int leftBeachEnd;

		// Token: 0x040030EE RID: 12526
		[global::Cpp2ILInjected.Token(Token = "0x4003A04")]
		public static int rightBeachStart;

		// Token: 0x040030EF RID: 12527
		[global::Cpp2ILInjected.Token(Token = "0x4003A05")]
		public static int beachBordersWidth;

		// Token: 0x040030F0 RID: 12528
		[global::Cpp2ILInjected.Token(Token = "0x4003A06")]
		public static int beachSandRandomCenter;

		// Token: 0x040030F1 RID: 12529
		[global::Cpp2ILInjected.Token(Token = "0x4003A07")]
		public static int beachSandRandomWidthRange;

		// Token: 0x040030F2 RID: 12530
		[global::Cpp2ILInjected.Token(Token = "0x4003A08")]
		public static int beachSandDungeonExtraWidth;

		// Token: 0x040030F3 RID: 12531
		[global::Cpp2ILInjected.Token(Token = "0x4003A09")]
		public static int beachSandJungleExtraWidth;

		// Token: 0x040030F4 RID: 12532
		[global::Cpp2ILInjected.Token(Token = "0x4003A0A")]
		public static int shellStartXLeft;

		// Token: 0x040030F5 RID: 12533
		[global::Cpp2ILInjected.Token(Token = "0x4003A0B")]
		public static int shellStartYLeft;

		// Token: 0x040030F6 RID: 12534
		[global::Cpp2ILInjected.Token(Token = "0x4003A0C")]
		public static int shellStartXRight;

		// Token: 0x040030F7 RID: 12535
		[global::Cpp2ILInjected.Token(Token = "0x4003A0D")]
		public static int shellStartYRight;

		// Token: 0x040030F8 RID: 12536
		[global::Cpp2ILInjected.Token(Token = "0x4003A0E")]
		public static int oceanWaterStartRandomMin;

		// Token: 0x040030F9 RID: 12537
		[global::Cpp2ILInjected.Token(Token = "0x4003A0F")]
		public static int oceanWaterStartRandomMax;

		// Token: 0x040030FA RID: 12538
		[global::Cpp2ILInjected.Token(Token = "0x4003A10")]
		public static int oceanWaterForcedJungleLength;

		// Token: 0x040030FB RID: 12539
		[global::Cpp2ILInjected.Token(Token = "0x4003A11")]
		public static int evilBiomeBeachAvoidance;

		// Token: 0x040030FC RID: 12540
		[global::Cpp2ILInjected.Token(Token = "0x4003A12")]
		public static int evilBiomeAvoidanceMidFixer;

		// Token: 0x040030FD RID: 12541
		[global::Cpp2ILInjected.Token(Token = "0x4003A13")]
		public static int lakesBeachAvoidance;

		// Token: 0x040030FE RID: 12542
		[global::Cpp2ILInjected.Token(Token = "0x4003A14")]
		public static int smallHolesBeachAvoidance;

		// Token: 0x040030FF RID: 12543
		[global::Cpp2ILInjected.Token(Token = "0x4003A15")]
		public static int surfaceCavesBeachAvoidance;

		// Token: 0x04003100 RID: 12544
		[global::Cpp2ILInjected.Token(Token = "0x4003A16")]
		public static int surfaceCavesBeachAvoidance2;

		// Token: 0x04003101 RID: 12545
		[global::Cpp2ILInjected.Token(Token = "0x4003A17")]
		public static readonly int maxOceanCaveTreasure;

		// Token: 0x04003102 RID: 12546
		[global::Cpp2ILInjected.Token(Token = "0x4003A18")]
		public static int numOceanCaveTreasure;

		// Token: 0x04003103 RID: 12547
		[global::Cpp2ILInjected.Token(Token = "0x4003A19")]
		public static Point[] oceanCaveTreasure;

		// Token: 0x04003104 RID: 12548
		[global::Cpp2ILInjected.Token(Token = "0x4003A1A")]
		public static bool skipDesertTileCheck;

		// Token: 0x04003105 RID: 12549
		[global::Cpp2ILInjected.Token(Token = "0x4003A1B")]
		public static Rectangle UndergroundDesertLocation;

		// Token: 0x04003106 RID: 12550
		[global::Cpp2ILInjected.Token(Token = "0x4003A1C")]
		public static Rectangle UndergroundDesertHiveLocation;

		// Token: 0x04003107 RID: 12551
		[global::Cpp2ILInjected.Token(Token = "0x4003A1D")]
		public static int desertHiveHigh;

		// Token: 0x04003108 RID: 12552
		[global::Cpp2ILInjected.Token(Token = "0x4003A1E")]
		public static int desertHiveLow;

		// Token: 0x04003109 RID: 12553
		[global::Cpp2ILInjected.Token(Token = "0x4003A1F")]
		public static int desertHiveLeft;

		// Token: 0x0400310A RID: 12554
		[global::Cpp2ILInjected.Token(Token = "0x4003A20")]
		public static int desertHiveRight;

		// Token: 0x0400310B RID: 12555
		[global::Cpp2ILInjected.Token(Token = "0x4003A21")]
		public static int numLarva;

		// Token: 0x0400310C RID: 12556
		[global::Cpp2ILInjected.Token(Token = "0x4003A22")]
		public static int[] larvaY;

		// Token: 0x0400310D RID: 12557
		[global::Cpp2ILInjected.Token(Token = "0x4003A23")]
		public static int[] larvaX;

		// Token: 0x0400310E RID: 12558
		[global::Cpp2ILInjected.Token(Token = "0x4003A24")]
		public static int numPyr;

		// Token: 0x0400310F RID: 12559
		[global::Cpp2ILInjected.Token(Token = "0x4003A25")]
		public static int[] PyrX;

		// Token: 0x04003110 RID: 12560
		[global::Cpp2ILInjected.Token(Token = "0x4003A26")]
		public static int[] PyrY;

		// Token: 0x04003111 RID: 12561
		[global::Cpp2ILInjected.Token(Token = "0x4003A27")]
		public static int extraBastStatueCount;

		// Token: 0x04003112 RID: 12562
		[global::Cpp2ILInjected.Token(Token = "0x4003A28")]
		public static int extraBastStatueCountMax;

		// Token: 0x04003113 RID: 12563
		[global::Cpp2ILInjected.Token(Token = "0x4003A29")]
		public static int jungleOriginX;

		// Token: 0x04003114 RID: 12564
		[global::Cpp2ILInjected.Token(Token = "0x4003A2A")]
		public static int jungleMinX;

		// Token: 0x04003115 RID: 12565
		[global::Cpp2ILInjected.Token(Token = "0x4003A2B")]
		public static int jungleMaxX;

		// Token: 0x04003116 RID: 12566
		[global::Cpp2ILInjected.Token(Token = "0x4003A2C")]
		public static int JungleX;

		// Token: 0x04003117 RID: 12567
		[global::Cpp2ILInjected.Token(Token = "0x4003A2D")]
		public static ushort jungleHut;

		// Token: 0x04003118 RID: 12568
		[global::Cpp2ILInjected.Token(Token = "0x4003A2E")]
		public static bool mudWall;

		// Token: 0x04003119 RID: 12569
		[global::Cpp2ILInjected.Token(Token = "0x4003A2F")]
		public static int JungleItemCount;

		// Token: 0x0400311A RID: 12570
		[global::Cpp2ILInjected.Token(Token = "0x4003A30")]
		public static int[] JChestX;

		// Token: 0x0400311B RID: 12571
		[global::Cpp2ILInjected.Token(Token = "0x4003A31")]
		public static int[] JChestY;

		// Token: 0x0400311C RID: 12572
		[global::Cpp2ILInjected.Token(Token = "0x4003A32")]
		public static int numJChests;

		// Token: 0x0400311D RID: 12573
		[global::Cpp2ILInjected.Token(Token = "0x4003A33")]
		public static int tLeft;

		// Token: 0x0400311E RID: 12574
		[global::Cpp2ILInjected.Token(Token = "0x4003A34")]
		public static int tRight;

		// Token: 0x0400311F RID: 12575
		[global::Cpp2ILInjected.Token(Token = "0x4003A35")]
		public static int tTop;

		// Token: 0x04003120 RID: 12576
		[global::Cpp2ILInjected.Token(Token = "0x4003A36")]
		public static int tBottom;

		// Token: 0x04003121 RID: 12577
		[global::Cpp2ILInjected.Token(Token = "0x4003A37")]
		public static int tRooms;

		// Token: 0x04003122 RID: 12578
		[global::Cpp2ILInjected.Token(Token = "0x4003A38")]
		public static int lAltarX;

		// Token: 0x04003123 RID: 12579
		[global::Cpp2ILInjected.Token(Token = "0x4003A39")]
		public static int lAltarY;

		// Token: 0x04003124 RID: 12580
		[global::Cpp2ILInjected.Token(Token = "0x4003A3A")]
		public static int dungeonSide;

		// Token: 0x04003125 RID: 12581
		[global::Cpp2ILInjected.Token(Token = "0x4003A3B")]
		public static int dungeonLocation;

		// Token: 0x04003126 RID: 12582
		[global::Cpp2ILInjected.Token(Token = "0x4003A3C")]
		public static bool dungeonLake;

		// Token: 0x04003127 RID: 12583
		[global::Cpp2ILInjected.Token(Token = "0x4003A3D")]
		public static ushort crackedType;

		// Token: 0x04003128 RID: 12584
		[global::Cpp2ILInjected.Token(Token = "0x4003A3E")]
		public static int dungeonX;

		// Token: 0x04003129 RID: 12585
		[global::Cpp2ILInjected.Token(Token = "0x4003A3F")]
		public static int dungeonY;

		// Token: 0x0400312A RID: 12586
		[global::Cpp2ILInjected.Token(Token = "0x4003A40")]
		public static Vector2D lastDungeonHall;

		// Token: 0x0400312B RID: 12587
		[global::Cpp2ILInjected.Token(Token = "0x4003A41")]
		public static readonly int maxDRooms;

		// Token: 0x0400312C RID: 12588
		[global::Cpp2ILInjected.Token(Token = "0x4003A42")]
		public static int numDRooms;

		// Token: 0x0400312D RID: 12589
		[global::Cpp2ILInjected.Token(Token = "0x4003A43")]
		public static int[] dRoomX;

		// Token: 0x0400312E RID: 12590
		[global::Cpp2ILInjected.Token(Token = "0x4003A44")]
		public static int[] dRoomY;

		// Token: 0x0400312F RID: 12591
		[global::Cpp2ILInjected.Token(Token = "0x4003A45")]
		public static int[] dRoomSize;

		// Token: 0x04003130 RID: 12592
		[global::Cpp2ILInjected.Token(Token = "0x4003A46")]
		public static bool[] dRoomTreasure;

		// Token: 0x04003131 RID: 12593
		[global::Cpp2ILInjected.Token(Token = "0x4003A47")]
		public static int[] dRoomL;

		// Token: 0x04003132 RID: 12594
		[global::Cpp2ILInjected.Token(Token = "0x4003A48")]
		public static int[] dRoomR;

		// Token: 0x04003133 RID: 12595
		[global::Cpp2ILInjected.Token(Token = "0x4003A49")]
		public static int[] dRoomT;

		// Token: 0x04003134 RID: 12596
		[global::Cpp2ILInjected.Token(Token = "0x4003A4A")]
		public static int[] dRoomB;

		// Token: 0x04003135 RID: 12597
		[global::Cpp2ILInjected.Token(Token = "0x4003A4B")]
		public static int numDDoors;

		// Token: 0x04003136 RID: 12598
		[global::Cpp2ILInjected.Token(Token = "0x4003A4C")]
		public static int[] DDoorX;

		// Token: 0x04003137 RID: 12599
		[global::Cpp2ILInjected.Token(Token = "0x4003A4D")]
		public static int[] DDoorY;

		// Token: 0x04003138 RID: 12600
		[global::Cpp2ILInjected.Token(Token = "0x4003A4E")]
		public static int[] DDoorPos;

		// Token: 0x04003139 RID: 12601
		[global::Cpp2ILInjected.Token(Token = "0x4003A4F")]
		public static int numDungeonPlatforms;

		// Token: 0x0400313A RID: 12602
		[global::Cpp2ILInjected.Token(Token = "0x4003A50")]
		public static int[] dungeonPlatformX;

		// Token: 0x0400313B RID: 12603
		[global::Cpp2ILInjected.Token(Token = "0x4003A51")]
		public static int[] dungeonPlatformY;

		// Token: 0x0400313C RID: 12604
		[global::Cpp2ILInjected.Token(Token = "0x4003A52")]
		public static int dEnteranceX;

		// Token: 0x0400313D RID: 12605
		[global::Cpp2ILInjected.Token(Token = "0x4003A53")]
		public static bool dSurface;

		// Token: 0x0400313E RID: 12606
		[global::Cpp2ILInjected.Token(Token = "0x4003A54")]
		public static double dxStrength1;

		// Token: 0x0400313F RID: 12607
		[global::Cpp2ILInjected.Token(Token = "0x4003A55")]
		public static double dyStrength1;

		// Token: 0x04003140 RID: 12608
		[global::Cpp2ILInjected.Token(Token = "0x4003A56")]
		public static double dxStrength2;

		// Token: 0x04003141 RID: 12609
		[global::Cpp2ILInjected.Token(Token = "0x4003A57")]
		public static double dyStrength2;

		// Token: 0x04003142 RID: 12610
		[global::Cpp2ILInjected.Token(Token = "0x4003A58")]
		public static int dMinX;

		// Token: 0x04003143 RID: 12611
		[global::Cpp2ILInjected.Token(Token = "0x4003A59")]
		public static int dMaxX;

		// Token: 0x04003144 RID: 12612
		[global::Cpp2ILInjected.Token(Token = "0x4003A5A")]
		public static int dMinY;

		// Token: 0x04003145 RID: 12613
		[global::Cpp2ILInjected.Token(Token = "0x4003A5B")]
		public static int dMaxY;

		// Token: 0x04003146 RID: 12614
		[global::Cpp2ILInjected.Token(Token = "0x4003A5C")]
		public static int skyLakes;

		// Token: 0x04003147 RID: 12615
		[global::Cpp2ILInjected.Token(Token = "0x4003A5D")]
		public static bool generatedShadowKey;

		// Token: 0x04003148 RID: 12616
		[global::Cpp2ILInjected.Token(Token = "0x4003A5E")]
		public static int numIslandHouses;

		// Token: 0x04003149 RID: 12617
		[global::Cpp2ILInjected.Token(Token = "0x4003A5F")]
		public static int skyIslandHouseCount;

		// Token: 0x0400314A RID: 12618
		[global::Cpp2ILInjected.Token(Token = "0x4003A60")]
		public static bool[] skyLake;

		// Token: 0x0400314B RID: 12619
		[global::Cpp2ILInjected.Token(Token = "0x4003A61")]
		public static int[] floatingIslandHouseX;

		// Token: 0x0400314C RID: 12620
		[global::Cpp2ILInjected.Token(Token = "0x4003A62")]
		public static int[] floatingIslandHouseY;

		// Token: 0x0400314D RID: 12621
		[global::Cpp2ILInjected.Token(Token = "0x4003A63")]
		public static int[] floatingIslandStyle;

		// Token: 0x0400314E RID: 12622
		[global::Cpp2ILInjected.Token(Token = "0x4003A64")]
		public static int numMCaves;

		// Token: 0x0400314F RID: 12623
		[global::Cpp2ILInjected.Token(Token = "0x4003A65")]
		public static int[] mCaveX;

		// Token: 0x04003150 RID: 12624
		[global::Cpp2ILInjected.Token(Token = "0x4003A66")]
		public static int[] mCaveY;

		// Token: 0x04003151 RID: 12625
		[global::Cpp2ILInjected.Token(Token = "0x4003A67")]
		public static readonly int maxTunnels;

		// Token: 0x04003152 RID: 12626
		[global::Cpp2ILInjected.Token(Token = "0x4003A68")]
		public static int numTunnels;

		// Token: 0x04003153 RID: 12627
		[global::Cpp2ILInjected.Token(Token = "0x4003A69")]
		public static int[] tunnelX;

		// Token: 0x04003154 RID: 12628
		[global::Cpp2ILInjected.Token(Token = "0x4003A6A")]
		public static readonly int maxOrePatch;

		// Token: 0x04003155 RID: 12629
		[global::Cpp2ILInjected.Token(Token = "0x4003A6B")]
		public static int numOrePatch;

		// Token: 0x04003156 RID: 12630
		[global::Cpp2ILInjected.Token(Token = "0x4003A6C")]
		public static int[] orePatchX;

		// Token: 0x04003157 RID: 12631
		[global::Cpp2ILInjected.Token(Token = "0x4003A6D")]
		public static readonly int maxMushroomBiomes;

		// Token: 0x04003158 RID: 12632
		[global::Cpp2ILInjected.Token(Token = "0x4003A6E")]
		public static int numMushroomBiomes;

		// Token: 0x04003159 RID: 12633
		[global::Cpp2ILInjected.Token(Token = "0x4003A6F")]
		public static Point[] mushroomBiomesPosition;

		// Token: 0x0400315A RID: 12634
		[global::Cpp2ILInjected.Token(Token = "0x4003A70")]
		public static int logX;

		// Token: 0x0400315B RID: 12635
		[global::Cpp2ILInjected.Token(Token = "0x4003A71")]
		public static int logY;

		// Token: 0x0400315C RID: 12636
		[global::Cpp2ILInjected.Token(Token = "0x4003A72")]
		public static readonly int maxLakes;

		// Token: 0x0400315D RID: 12637
		[global::Cpp2ILInjected.Token(Token = "0x4003A73")]
		public static int numLakes;

		// Token: 0x0400315E RID: 12638
		[global::Cpp2ILInjected.Token(Token = "0x4003A74")]
		public static int[] LakeX;

		// Token: 0x0400315F RID: 12639
		[global::Cpp2ILInjected.Token(Token = "0x4003A75")]
		public static readonly int maxOasis;

		// Token: 0x04003160 RID: 12640
		[global::Cpp2ILInjected.Token(Token = "0x4003A76")]
		public static int numOasis;

		// Token: 0x04003161 RID: 12641
		[global::Cpp2ILInjected.Token(Token = "0x4003A77")]
		public static Point[] oasisPosition;

		// Token: 0x04003162 RID: 12642
		[global::Cpp2ILInjected.Token(Token = "0x4003A78")]
		public static int[] oasisWidth;

		// Token: 0x04003163 RID: 12643
		[global::Cpp2ILInjected.Token(Token = "0x4003A79")]
		public static readonly int oasisHeight;

		// Token: 0x04003164 RID: 12644
		[global::Cpp2ILInjected.Token(Token = "0x4003A7A")]
		public static int hellChest;

		// Token: 0x04003165 RID: 12645
		[global::Cpp2ILInjected.Token(Token = "0x4003A7B")]
		public static int[] hellChestItem;

		// Token: 0x04003166 RID: 12646
		[global::Cpp2ILInjected.Token(Token = "0x4003A7C")]
		public static Point16[] statueList;

		// Token: 0x04003167 RID: 12647
		[global::Cpp2ILInjected.Token(Token = "0x4003A7D")]
		public static List<int> StatuesWithTraps;

		// Token: 0x04003168 RID: 12648
		[global::Cpp2ILInjected.Token(Token = "0x4003A7E")]
		public static bool crimsonLeft;

		// Token: 0x04003169 RID: 12649
		[global::Cpp2ILInjected.Token(Token = "0x4003A7F")]
		public static Vector2D shimmerPosition;
	}
}
