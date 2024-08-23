using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes.Desert;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020005F4 RID: 1524
	[global::Cpp2ILInjected.Token(Token = "0x20008EA")]
	public class DunesBiome : MicroBiome
	{
		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x0002CFB1 File Offset: 0x0002B1B1
		[global::Cpp2ILInjected.Token(Token = "0x170007EB")]
		public int MaximumWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60045F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7C6D60", Offset = "0x7C6D60", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGenRange), Member = "get_ScaledMaximum", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
		[global::Cpp2ILInjected.Token(Token = "0x60045F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C6D7C", Offset = "0x7C6D7C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGenRange), Member = "GetRandom", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DunesBiome.DunesDescription), Member = "CreateFromPlacement", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(DunesBiome.DunesDescription))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DunesBiome), Member = "PlaceSingle", MemberParameters = new object[]
		{
			typeof(DunesBiome.DunesDescription),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		public override bool Place(Point origin, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x0002CFB7 File Offset: 0x0002B1B7
		[global::Cpp2ILInjected.Token(Token = "0x60045FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C701C", Offset = "0x7C701C", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DunesBiome), Member = "PlaceHill", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(DunesBiome.DunesDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "AddStructure", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PlaceSingle(DunesBiome.DunesDescription description, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x0002CFBA File Offset: 0x0002B1BA
		[global::Cpp2ILInjected.Token(Token = "0x60045FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C7288", Offset = "0x7C7288", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceSingle", MemberParameters = new object[]
		{
			typeof(DunesBiome.DunesDescription),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SurfaceMap), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DunesBiome), Member = "PlaceCurvedLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Point),
			typeof(DunesBiome.DunesDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void PlaceHill(int startX, int endX, double scale, DunesBiome.DunesDescription description)
		{
			throw null;
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x0002CFBD File Offset: 0x0002B1BD
		[global::Cpp2ILInjected.Token(Token = "0x60045FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C74A0", Offset = "0x7C74A0", Length = "0x4D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceHill", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(DunesBiome.DunesDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToVector2D", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2D) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SurfaceMap), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static void PlaceCurvedLine(Point startPoint, Point endPoint, Point anchorOffset, DunesBiome.DunesDescription description)
		{
			throw null;
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x0002CFC0 File Offset: 0x0002B1C0
		[global::Cpp2ILInjected.Token(Token = "0x60045FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C7974", Offset = "0x7C7974", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MicroBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DunesBiome()
		{
			throw null;
		}

		// Token: 0x04006BF7 RID: 27639
		[JsonProperty("SingleDunesWidth")]
		[global::Cpp2ILInjected.Token(Token = "0x4008250")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private WorldGenRange _singleDunesWidth;

		// Token: 0x04006BF8 RID: 27640
		[JsonProperty("HeightScale")]
		[global::Cpp2ILInjected.Token(Token = "0x4008251")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private double _heightScale;

		// Token: 0x02000A00 RID: 2560
		[global::Cpp2ILInjected.Token(Token = "0x20008EB")]
		private class DunesDescription
		{
			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06004F4B RID: 20299 RVA: 0x00030011 File Offset: 0x0002E211
			// (set) Token: 0x06004F4C RID: 20300 RVA: 0x00030014 File Offset: 0x0002E214
			[global::Cpp2ILInjected.Token(Token = "0x170007EC")]
			public bool IsValid
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60045FE")]
				[global::Cpp2ILInjected.Address(RVA = "0x7C79E0", Offset = "0x7C79E0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60045FF")]
				[global::Cpp2ILInjected.Address(RVA = "0x7C79E8", Offset = "0x7C79E8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x06004F4D RID: 20301 RVA: 0x00030017 File Offset: 0x0002E217
			// (set) Token: 0x06004F4E RID: 20302 RVA: 0x0003001A File Offset: 0x0002E21A
			[global::Cpp2ILInjected.Token(Token = "0x170007ED")]
			public SurfaceMap Surface
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004600")]
				[global::Cpp2ILInjected.Address(RVA = "0x7C79F4", Offset = "0x7C79F4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004601")]
				[global::Cpp2ILInjected.Address(RVA = "0x7C79FC", Offset = "0x7C79FC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x06004F4F RID: 20303 RVA: 0x0003001D File Offset: 0x0002E21D
			// (set) Token: 0x06004F50 RID: 20304 RVA: 0x00030020 File Offset: 0x0002E220
			[global::Cpp2ILInjected.Token(Token = "0x170007EE")]
			public Rectangle Area
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004602")]
				[global::Cpp2ILInjected.Address(RVA = "0x7C7A04", Offset = "0x7C7A04", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004603")]
				[global::Cpp2ILInjected.Address(RVA = "0x7C7A10", Offset = "0x7C7A10", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x06004F51 RID: 20305 RVA: 0x00030023 File Offset: 0x0002E223
			// (set) Token: 0x06004F52 RID: 20306 RVA: 0x00030026 File Offset: 0x0002E226
			[global::Cpp2ILInjected.Token(Token = "0x170007EF")]
			public DunesBiome.WindDirection WindDirection
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004604")]
				[global::Cpp2ILInjected.Address(RVA = "0x7C7A18", Offset = "0x7C7A18", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004605")]
				[global::Cpp2ILInjected.Address(RVA = "0x7C7A20", Offset = "0x7C7A20", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06004F53 RID: 20307 RVA: 0x00030029 File Offset: 0x0002E229
			[global::Cpp2ILInjected.Token(Token = "0x6004606")]
			[global::Cpp2ILInjected.Address(RVA = "0x7C7A28", Offset = "0x7C7A28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			private DunesDescription()
			{
				throw null;
			}

			// Token: 0x06004F54 RID: 20308 RVA: 0x0003002C File Offset: 0x0002E22C
			[global::Cpp2ILInjected.Token(Token = "0x6004607")]
			[global::Cpp2ILInjected.Address(RVA = "0x7C6F08", Offset = "0x7C6F08", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SurfaceMap), Member = "FromArea", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(SurfaceMap))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public static DunesBiome.DunesDescription CreateFromPlacement(Point origin, int width, int height)
			{
				throw null;
			}

			// Token: 0x04008D0C RID: 36108
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008252")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private bool <IsValid>k__BackingField;

			// Token: 0x04008D0D RID: 36109
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008253")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private SurfaceMap <Surface>k__BackingField;

			// Token: 0x04008D0E RID: 36110
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008254")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Rectangle <Area>k__BackingField;

			// Token: 0x04008D0F RID: 36111
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008255")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private DunesBiome.WindDirection <WindDirection>k__BackingField;
		}

		// Token: 0x02000A01 RID: 2561
		[global::Cpp2ILInjected.Token(Token = "0x20008EC")]
		private enum WindDirection
		{
			// Token: 0x04008D11 RID: 36113
			[global::Cpp2ILInjected.Token(Token = "0x4008257")]
			Left,
			// Token: 0x04008D12 RID: 36114
			[global::Cpp2ILInjected.Token(Token = "0x4008258")]
			Right
		}
	}
}
