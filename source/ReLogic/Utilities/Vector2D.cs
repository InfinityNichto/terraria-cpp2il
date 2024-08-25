using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.Desert;
using Terraria.GameContent.Generation;
using Terraria.IO;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace ReLogic.Utilities
{
	[DebuggerDisplay("{DebugDisplayString,nq}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000B0D")]
	[Serializable]
	public struct Vector2D : IEquatable<Vector2D>
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008EA")]
		public static Vector2D Zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x93EEC8", Offset = "0x93EEC8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008EB")]
		public static Vector2D One
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x93EF20", Offset = "0x93EF20", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008EC")]
		public static Vector2D UnitX
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x93EF78", Offset = "0x93EF78", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008ED")]
		public static Vector2D UnitY
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x93EFD0", Offset = "0x93EFD0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008EE")]
		internal string DebugDisplayString
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x93F028", Offset = "0x93F028", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F094", Offset = "0x93F094", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "ToVector2D", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "ToVector2D", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "ToVector2D", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffset", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffsetTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "RandomVector2D", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_20", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_37", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_43", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_64", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "placeTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "neonMossBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "StonePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShellPile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MarblePileWithStatues", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "OrePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceOasis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowLivingTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowDungeonTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "templePather", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "makeTemple", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsSafeFromRain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CrimStart", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CrimEnt", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "oceanCave", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "WavyCaverer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(double),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "Caverer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "digTunnel", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IslandHouse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Modifiers.RadialDither), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.Tail), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnthillEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.Desert.ChambersEntrance.PathConnection", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertDescription), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.Desert.DesertHive.Block", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup", Member = "Generate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LarvaHoleEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 80)]
		public Vector2D(double x, double y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F09C", Offset = "0x93F09C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Vector2D(double value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F0A4", Offset = "0x93F0A4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F12C", Offset = "0x93F12C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Vector2D other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F150", Offset = "0x93F150", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F228", Offset = "0x93F228", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffset", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffsetTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "neonMossBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "StonePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShellPile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MarblePileWithStatues", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "OrePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowLivingTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowDungeonTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "oceanCave", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "SimulatePressure", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public double Length()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F294", Offset = "0x93F294", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public double LengthSquared()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F2A8", Offset = "0x93F2A8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Normalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F334", Offset = "0x93F334", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F498", Offset = "0x93F498", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Add(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F4A4", Offset = "0x93F4A4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Add(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F4B8", Offset = "0x93F4B8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Barycentric(Vector2D value1, Vector2D value2, Vector2D value3, double amount1, double amount2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F590", Offset = "0x93F590", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Barycentric(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, double amount1, double amount2, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F664", Offset = "0x93F664", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D CatmullRom(Vector2D value1, Vector2D value2, Vector2D value3, Vector2D value4, double amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F7EC", Offset = "0x93F7EC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CatmullRom(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, ref Vector2D value4, double amount, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F920", Offset = "0x93F920", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Clamp(Vector2D value1, Vector2D min, Vector2D max)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F9D0", Offset = "0x93F9D0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Clamp(ref Vector2D value1, ref Vector2D min, ref Vector2D max, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FA8C", Offset = "0x93FA8C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_20", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_43", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_64", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "placeTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceOasis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Modifiers.RadialDither), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static double Distance(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FB10", Offset = "0x93FB10", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Distance(ref Vector2D value1, ref Vector2D value2, out double result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FB9C", Offset = "0x93FB9C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double DistanceSquared(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FBB4", Offset = "0x93FBB4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void DistanceSquared(ref Vector2D value1, ref Vector2D value2, out double result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FBD8", Offset = "0x93FBD8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Divide(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FBE4", Offset = "0x93FBE4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FBF8", Offset = "0x93FBF8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Divide(Vector2D value1, double divider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FC0C", Offset = "0x93FC0C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector2D value1, double divider, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FC24", Offset = "0x93FC24", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double Dot(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FC34", Offset = "0x93FC34", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dot(ref Vector2D value1, ref Vector2D value2, out double result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FC50", Offset = "0x93FC50", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(double),
			typeof(ref Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Hermite(Vector2D value1, Vector2D tangent1, Vector2D value2, Vector2D tangent2, double amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FCE4", Offset = "0x93FCE4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Hermite(ref Vector2D value1, ref Vector2D tangent1, ref Vector2D value2, ref Vector2D tangent2, double amount, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FED4", Offset = "0x93FED4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceCurvedLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Point),
			"Terraria.GameContent.Biomes.DunesBiome.DunesDescription"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Lerp(Vector2D value1, Vector2D value2, double amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FF74", Offset = "0x93FF74", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Lerp(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x940018", Offset = "0x940018", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Max(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x94002C", Offset = "0x94002C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Max(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x940058", Offset = "0x940058", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Min(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x94006C", Offset = "0x94006C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Min(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x940098", Offset = "0x940098", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Multiply(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400A4", Offset = "0x9400A4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Multiply(Vector2D value1, double scaleFactor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400B0", Offset = "0x9400B0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector2D value1, double scaleFactor, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400C0", Offset = "0x9400C0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400D4", Offset = "0x9400D4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Negate(Vector2D value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400E0", Offset = "0x9400E0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Negate(ref Vector2D value, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400F0", Offset = "0x9400F0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Normalize(Vector2D value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x94016C", Offset = "0x94016C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Normalize(ref Vector2D value, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x940204", Offset = "0x940204", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Reflect(Vector2D vector, Vector2D normal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x940228", Offset = "0x940228", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Reflect(ref Vector2D vector, ref Vector2D normal, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x940258", Offset = "0x940258", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D SmoothStep(Vector2D value1, Vector2D value2, double amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x940384", Offset = "0x940384", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SmoothStep(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x940428", Offset = "0x940428", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Subtract(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x940434", Offset = "0x940434", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Subtract(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x940448", Offset = "0x940448", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsSafeFromRain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static Vector2D operator -(Vector2D value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x940454", Offset = "0x940454", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator ==(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x94046C", Offset = "0x94046C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonHalls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x9404EC", Offset = "0x9404EC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffset", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "<PlotLineOffsetTale>g__PlotAtOffset|150_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Utils.<>c__DisplayClass150_0)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "neonMossBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "StonePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShellPile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MarblePileWithStatues", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "OrePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonStairs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonHalls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonRoom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "OreRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsSafeFromRain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ChasmRunnerSideways", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CrimStart", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CrimEnt", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CrimVein", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ChasmRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GERunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(double),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "oceanCave", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(double),
			typeof(double),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DirtyRockRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MudWallRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SnowCloudIsland", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DesertCloudIsland", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CloudIsland", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CloudLake", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FloatingIsland", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "Mountinater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "Lakinater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SonOfLakinater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShroomPatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "Cavinator", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CaveOpenater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.Tail), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "SimulatePressure", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "CreateHiveTunnel", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JunglePass), Member = "GenerateTunnelToSurface", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 59)]
		public static Vector2D operator +(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x9404F8", Offset = "0x9404F8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffset", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffsetTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "<PlotLineOffsetTale>g__PlotAtOffset|150_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Utils.<>c__DisplayClass150_0)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "StonePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShellPile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MarblePileWithStatues", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "OrePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowLivingTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowDungeonTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public static Vector2D operator -(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x940504", Offset = "0x940504", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static Vector2D operator *(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x940510", Offset = "0x940510", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffset", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "<PlotLineOffsetTale>g__PlotAtOffset|150_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Utils.<>c__DisplayClass150_0)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "neonMossBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsSafeFromRain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.Tail), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		public static Vector2D operator *(Vector2D value, double scaleFactor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x94051C", Offset = "0x94051C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "SimulatePressure", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static Vector2D operator *(double scaleFactor, Vector2D value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x94052C", Offset = "0x94052C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static Vector2D operator /(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x940538", Offset = "0x940538", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffset", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffsetTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static Vector2D operator /(Vector2D value1, double divider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F9BC", Offset = "0x93F9BC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double Clamp(double value, double min, double max)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FF64", Offset = "0x93FF64", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double Lerp(double value1, double value2, double amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x9402FC", Offset = "0x9402FC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(double),
			typeof(ref Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static double SmoothStep(double value1, double value2, double amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FDB8", Offset = "0x93FDB8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(double),
			typeof(ref Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static double Hermite(double value1, double tangent1, double value2, double tangent2, double amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F574", Offset = "0x93F574", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double Barycentric(double value1, double value2, double value3, double amount1, double amount2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F780", Offset = "0x93F780", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double CatmullRom(double value1, double value2, double value3, double value4, double amount)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6005300")]
		[global::Cpp2ILInjected.Address(RVA = "0x94054C", Offset = "0x94054C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Vector2D()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008AE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public double X;

		[global::Cpp2ILInjected.Token(Token = "0x4008AE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public double Y;

		[global::Cpp2ILInjected.Token(Token = "0x4008AE2")]
		private static Vector2D zeroVector;

		[global::Cpp2ILInjected.Token(Token = "0x4008AE3")]
		private static Vector2D unitVector;

		[global::Cpp2ILInjected.Token(Token = "0x4008AE4")]
		private static Vector2D unitXVector;

		[global::Cpp2ILInjected.Token(Token = "0x4008AE5")]
		private static Vector2D unitYVector;

		[global::Cpp2ILInjected.Token(Token = "0x4008AE6")]
		public static readonly double DoubleEpsilon;
	}
}
