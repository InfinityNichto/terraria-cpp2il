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
	[global::Cpp2ILInjected.Token(Token = "0x20008EA")]
	public class DunesBiome : MicroBiome
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60045FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C7974", Offset = "0x7C7974", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MicroBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DunesBiome()
		{
			throw null;
		}

		[JsonProperty("SingleDunesWidth")]
		[global::Cpp2ILInjected.Token(Token = "0x4008250")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private WorldGenRange _singleDunesWidth;

		[JsonProperty("HeightScale")]
		[global::Cpp2ILInjected.Token(Token = "0x4008251")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private double _heightScale;

		[global::Cpp2ILInjected.Token(Token = "0x20008EB")]
		private class DunesDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004606")]
			[global::Cpp2ILInjected.Address(RVA = "0x7C7A28", Offset = "0x7C7A28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			private DunesDescription()
			{
				throw null;
			}

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

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008252")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private bool <IsValid>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008253")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private SurfaceMap <Surface>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008254")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Rectangle <Area>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008255")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private DunesBiome.WindDirection <WindDirection>k__BackingField;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008EC")]
		private enum WindDirection
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008257")]
			Left,
			[global::Cpp2ILInjected.Token(Token = "0x4008258")]
			Right
		}
	}
}
