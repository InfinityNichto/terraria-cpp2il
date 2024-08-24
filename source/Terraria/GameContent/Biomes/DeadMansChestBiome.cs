using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.IO;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020005F2 RID: 1522
	[global::Cpp2ILInjected.Token(Token = "0x20008E4")]
	public class DeadMansChestBiome : MicroBiome
	{
		// Token: 0x06003D68 RID: 15720 RVA: 0x0002CF6C File Offset: 0x0002B16C
		[global::Cpp2ILInjected.Token(Token = "0x60045DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C3E40", Offset = "0x7C3E40", Length = "0x4E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "IsAGoodSpot", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "ClearCaches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "FindBoulderTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "FindDartTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "FindExplosiveTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "AreThereEnoughTraps", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "TurnGoldChestIntoDeadMansChest", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "ActuallyPlaceDartTrap", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Tile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "PlaceWireLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "ActuallyPlaceBoulderTrap", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "ActuallyPlaceExplosive", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "PlaceWiresForExplosives", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public override bool Place(Point origin, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x0002CF6F File Offset: 0x0002B16F
		[global::Cpp2ILInjected.Token(Token = "0x60045DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C58DC", Offset = "0x7C58DC", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "PlaceWireLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PlaceWiresForExplosives(Point origin)
		{
			throw null;
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x0002CF72 File Offset: 0x0002B172
		[global::Cpp2ILInjected.Token(Token = "0x60045DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C5054", Offset = "0x7C5054", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "GetPossibleChestsToTrapify", MemberParameters = new object[] { typeof(StructureMap) }, ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool AreThereEnoughTraps()
		{
			throw null;
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x0002CF75 File Offset: 0x0002B175
		[global::Cpp2ILInjected.Token(Token = "0x60045E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C4520", Offset = "0x7C4520", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "GetPossibleChestsToTrapify", MemberParameters = new object[] { typeof(StructureMap) }, ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ClearCaches()
		{
			throw null;
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x0002CF78 File Offset: 0x0002B178
		[global::Cpp2ILInjected.Token(Token = "0x60045E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C4624", Offset = "0x7C4624", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "GetPossibleChestsToTrapify", MemberParameters = new object[] { typeof(StructureMap) }, ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Next", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(IntRange)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "FindBoulderTrapSpot", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void FindBoulderTrapSpots(Point position)
		{
			throw null;
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x0002CF7B File Offset: 0x0002B17B
		[global::Cpp2ILInjected.Token(Token = "0x60045E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C5A28", Offset = "0x7C5A28", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "FindBoulderTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "PlaceBoulderTrapSpot", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void FindBoulderTrapSpot(Point position)
		{
			throw null;
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x0002CF7E File Offset: 0x0002B17E
		[global::Cpp2ILInjected.Token(Token = "0x60045E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C5B50", Offset = "0x7C5B50", Length = "0x4AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "FindBoulderTrapSpot", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void PlaceBoulderTrapSpot(Point position, int yPush)
		{
			throw null;
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x0002CF81 File Offset: 0x0002B181
		[global::Cpp2ILInjected.Token(Token = "0x60045E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C491C", Offset = "0x7C491C", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "GetPossibleChestsToTrapify", MemberParameters = new object[] { typeof(StructureMap) }, ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Next", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(IntRange)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "FindDartTrapSpotSingle", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void FindDartTrapSpots(Point position)
		{
			throw null;
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x0002CF84 File Offset: 0x0002B184
		[global::Cpp2ILInjected.Token(Token = "0x60045E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C6040", Offset = "0x7C6040", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "FindDartTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "actuator", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private bool FindDartTrapSpotSingle(Point position, int directionX)
		{
			throw null;
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x0002CF87 File Offset: 0x0002B187
		[global::Cpp2ILInjected.Token(Token = "0x60045E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C4ADC", Offset = "0x7C4ADC", Length = "0x578")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "IsGoodSpotsForExplosive", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void FindExplosiveTrapSpots(Point position)
		{
			throw null;
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x0002CF8A File Offset: 0x0002B18A
		[global::Cpp2ILInjected.Token(Token = "0x60045E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C634C", Offset = "0x7C634C", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "FindExplosiveTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool IsGoodSpotsForExplosive(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x0002CF8D File Offset: 0x0002B18D
		[global::Cpp2ILInjected.Token(Token = "0x60045E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C6528", Offset = "0x7C6528", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_100", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "IsAGoodSpot", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "ClearCaches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "FindBoulderTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "FindDartTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "AreThereEnoughTraps", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(bool[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public List<int> GetPossibleChestsToTrapify(StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x0002CF90 File Offset: 0x0002B190
		[global::Cpp2ILInjected.Token(Token = "0x60045E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C4324", Offset = "0x7C4324", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "GetPossibleChestsToTrapify", MemberParameters = new object[] { typeof(StructureMap) }, ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "oceanDepths", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "countWires", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "countTiles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool IsAGoodSpot(Point position)
		{
			throw null;
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x0002CF93 File Offset: 0x0002B193
		[global::Cpp2ILInjected.Token(Token = "0x60045EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C50DC", Offset = "0x7C50DC", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "FindChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DeepClone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void TurnGoldChestIntoDeadMansChest(Point position)
		{
			throw null;
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x0002CF96 File Offset: 0x0002B196
		[global::Cpp2ILInjected.Token(Token = "0x60045EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C5360", Offset = "0x7C5360", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "PlaceWireLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ActuallyPlaceDartTrap(Point position, int directionX, int x, int y, int xPush, Tile t)
		{
			throw null;
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x0002CF99 File Offset: 0x0002B199
		[global::Cpp2ILInjected.Token(Token = "0x60045EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C5460", Offset = "0x7C5460", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "PlaceWiresForExplosives", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "ActuallyPlaceDartTrap", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Tile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "ActuallyPlaceBoulderTrap", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PlaceWireLine(Point start, int offsetX, int offsetY, int steps)
		{
			throw null;
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x0002CF9C File Offset: 0x0002B19C
		[global::Cpp2ILInjected.Token(Token = "0x60045ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C5528", Offset = "0x7C5528", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearTile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "actuator", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadMansChestBiome), Member = "PlaceWireLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ActuallyPlaceBoulderTrap(Point position, int yPush, int requiredHeight, int bestType)
		{
			throw null;
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x0002CF9F File Offset: 0x0002B19F
		[global::Cpp2ILInjected.Token(Token = "0x60045EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C57D0", Offset = "0x7C57D0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ActuallyPlaceExplosive(Point position)
		{
			throw null;
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x0002CFA2 File Offset: 0x0002B1A2
		[global::Cpp2ILInjected.Token(Token = "0x60045EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C67BC", Offset = "0x7C67BC", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntRange), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MicroBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public DeadMansChestBiome()
		{
			throw null;
		}

		// Token: 0x04006BEF RID: 27631
		[global::Cpp2ILInjected.Token(Token = "0x4008239")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<DeadMansChestBiome.DartTrapPlacementAttempt> _dartTrapPlacementSpots;

		// Token: 0x04006BF0 RID: 27632
		[global::Cpp2ILInjected.Token(Token = "0x400823A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<DeadMansChestBiome.WirePlacementAttempt> _wirePlacementSpots;

		// Token: 0x04006BF1 RID: 27633
		[global::Cpp2ILInjected.Token(Token = "0x400823B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<DeadMansChestBiome.BoulderPlacementAttempt> _boulderPlacementSpots;

		// Token: 0x04006BF2 RID: 27634
		[global::Cpp2ILInjected.Token(Token = "0x400823C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<DeadMansChestBiome.ExplosivePlacementAttempt> _explosivePlacementAttempt;

		// Token: 0x04006BF3 RID: 27635
		[JsonProperty("NumberOfDartTraps")]
		[global::Cpp2ILInjected.Token(Token = "0x400823D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private IntRange _numberOfDartTraps;

		// Token: 0x04006BF4 RID: 27636
		[JsonProperty("NumberOfBoulderTraps")]
		[global::Cpp2ILInjected.Token(Token = "0x400823E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private IntRange _numberOfBoulderTraps;

		// Token: 0x04006BF5 RID: 27637
		[JsonProperty("NumberOfStepsBetweenBoulderTraps")]
		[global::Cpp2ILInjected.Token(Token = "0x400823F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private IntRange _numberOfStepsBetweenBoulderTraps;

		// Token: 0x020009FC RID: 2556
		[global::Cpp2ILInjected.Token(Token = "0x20008E5")]
		private class DartTrapPlacementAttempt
		{
			// Token: 0x06004F47 RID: 20295 RVA: 0x00030005 File Offset: 0x0002E205
			[global::Cpp2ILInjected.Token(Token = "0x60045F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7C62F4", Offset = "0x7C62F4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DartTrapPlacementAttempt(Point position, int directionX, int x, int y, int xPush, Tile t)
			{
				throw null;
			}

			// Token: 0x04008CFD RID: 36093
			[global::Cpp2ILInjected.Token(Token = "0x4008240")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int directionX;

			// Token: 0x04008CFE RID: 36094
			[global::Cpp2ILInjected.Token(Token = "0x4008241")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int xPush;

			// Token: 0x04008CFF RID: 36095
			[global::Cpp2ILInjected.Token(Token = "0x4008242")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int x;

			// Token: 0x04008D00 RID: 36096
			[global::Cpp2ILInjected.Token(Token = "0x4008243")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int y;

			// Token: 0x04008D01 RID: 36097
			[global::Cpp2ILInjected.Token(Token = "0x4008244")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Point position;

			// Token: 0x04008D02 RID: 36098
			[global::Cpp2ILInjected.Token(Token = "0x4008245")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Tile t;
		}

		// Token: 0x020009FD RID: 2557
		[global::Cpp2ILInjected.Token(Token = "0x20008E6")]
		private class BoulderPlacementAttempt
		{
			// Token: 0x06004F48 RID: 20296 RVA: 0x00030008 File Offset: 0x0002E208
			[global::Cpp2ILInjected.Token(Token = "0x60045F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7C5FFC", Offset = "0x7C5FFC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BoulderPlacementAttempt(Point position, int yPush, int requiredHeight, int bestType)
			{
				throw null;
			}

			// Token: 0x04008D03 RID: 36099
			[global::Cpp2ILInjected.Token(Token = "0x4008246")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Point position;

			// Token: 0x04008D04 RID: 36100
			[global::Cpp2ILInjected.Token(Token = "0x4008247")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int yPush;

			// Token: 0x04008D05 RID: 36101
			[global::Cpp2ILInjected.Token(Token = "0x4008248")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int requiredHeight;

			// Token: 0x04008D06 RID: 36102
			[global::Cpp2ILInjected.Token(Token = "0x4008249")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int bestType;
		}

		// Token: 0x020009FE RID: 2558
		[global::Cpp2ILInjected.Token(Token = "0x20008E7")]
		private class WirePlacementAttempt
		{
			// Token: 0x06004F49 RID: 20297 RVA: 0x0003000B File Offset: 0x0002E20B
			[global::Cpp2ILInjected.Token(Token = "0x60045F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7C5B0C", Offset = "0x7C5B0C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public WirePlacementAttempt(Point position, int dirX, int dirY, int steps)
			{
				throw null;
			}

			// Token: 0x04008D07 RID: 36103
			[global::Cpp2ILInjected.Token(Token = "0x400824A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Point position;

			// Token: 0x04008D08 RID: 36104
			[global::Cpp2ILInjected.Token(Token = "0x400824B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int dirX;

			// Token: 0x04008D09 RID: 36105
			[global::Cpp2ILInjected.Token(Token = "0x400824C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int dirY;

			// Token: 0x04008D0A RID: 36106
			[global::Cpp2ILInjected.Token(Token = "0x400824D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int steps;
		}

		// Token: 0x020009FF RID: 2559
		[global::Cpp2ILInjected.Token(Token = "0x20008E8")]
		private class ExplosivePlacementAttempt
		{
			// Token: 0x06004F4A RID: 20298 RVA: 0x0003000E File Offset: 0x0002E20E
			[global::Cpp2ILInjected.Token(Token = "0x60045F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7C6500", Offset = "0x7C6500", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ExplosivePlacementAttempt(Point position)
			{
				throw null;
			}

			// Token: 0x04008D0B RID: 36107
			[global::Cpp2ILInjected.Token(Token = "0x400824E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Point position;
		}
	}
}
