using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.Desert;
using Terraria.GameContent.Skies;
using Terraria.Graphics;
using Terraria.Graphics.Light;

namespace Terraria.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x20004F8")]
	public struct FastRandom
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000614")]
		public ulong Seed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x13006BC", Offset = "0x13006BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60030C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x13006C4", Offset = "0x13006C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x13006CC", Offset = "0x13006CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public FastRandom(ulong seed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x13006D4", Offset = "0x13006D4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceDecorations", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public FastRandom(int seed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x13006E0", Offset = "0x13006E0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceDecorations", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public FastRandom WithModifier(ulong modifier)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300720", Offset = "0x1300720", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "GetTileLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceDecorations", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public FastRandom WithModifier(int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300760", Offset = "0x1300760", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ResetWindCounter", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Star), Member = "SpawnStars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "GetHashCode", ReturnType = typeof(int))]
		public static FastRandom CreateWithRandomSeed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300790", Offset = "0x1300790", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessBlur2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "BlurPass2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public void NextSeed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x13007B4", Offset = "0x13007B4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int NextBits(int bits)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x13007E8", Offset = "0x13007E8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.ButterfliesSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.LostKiteSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PegasusSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.VultureSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PixiePosseSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BirdsPackSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.SeagullsGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.GastropodGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.SlimeBalloonGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.HellBatsGoupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.BatsGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.WyvernSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirshipSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirBalloonSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = "BeginZigZag", MemberParameters = new object[]
		{
			typeof(ref FastRandom),
			typeof(VirtualCamera),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = "BeginChasingPlayer", MemberParameters = new object[]
		{
			typeof(ref FastRandom),
			typeof(VirtualCamera)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.MeteorSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 84)]
		public float NextFloat()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300820", Offset = "0x1300820", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public double NextDouble()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x130085C", Offset = "0x130085C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Star), Member = "SpawnStars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceDecorations", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.ButterfliesSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.LostKiteSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.SeagullsGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.GastropodGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.SlimeBalloonGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.HellBatsGoupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.BatsGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirshipSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirBalloonSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.MeteorSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		public int Next(int max)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x13008D0", Offset = "0x13008D0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ResetWindCounter", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Star), Member = "SpawnStars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplyWallLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref FastRandom),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplyTileLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref FastRandom),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.ButterfliesSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.LostKiteSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PegasusSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.VultureSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PixiePosseSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BirdsPackSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.SeagullsGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.GastropodGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.SlimeBalloonGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.HellBatsGoupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.BatsGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.WyvernSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirshipSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirBalloonSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = "BeginZigZag", MemberParameters = new object[]
		{
			typeof(ref FastRandom),
			typeof(VirtualCamera),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = "BeginChasingPlayer", MemberParameters = new object[]
		{
			typeof(ref FastRandom),
			typeof(VirtualCamera)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.MeteorSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 68)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		public int Next(int min, int max)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1300704", Offset = "0x1300704", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong NextSeed(ulong seed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003AC8")]
		public const ulong RANDOM_MULTIPLIER = 25214903917UL;

		[global::Cpp2ILInjected.Token(Token = "0x4003AC9")]
		public const ulong RANDOM_ADD = 11UL;

		[global::Cpp2ILInjected.Token(Token = "0x4003ACA")]
		public const ulong RANDOM_MASK = 281474976710655UL;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003ACB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ulong <Seed>k__BackingField;
	}
}
