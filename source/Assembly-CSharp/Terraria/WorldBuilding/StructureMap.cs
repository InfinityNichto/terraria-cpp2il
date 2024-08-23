using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000369 RID: 873
	[global::Cpp2ILInjected.Token(Token = "0x20004E7")]
	public class StructureMap
	{
		// Token: 0x06002C67 RID: 11367 RVA: 0x00029F5A File Offset: 0x0002815A
		[global::Cpp2ILInjected.Token(Token = "0x600306D")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FBA54", Offset = "0x12FBA54", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_47", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleStructure), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HoneyPatchBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(bool[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool CanPlace(Rectangle area, int padding = 0)
		{
			throw null;
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00029F5D File Offset: 0x0002815D
		[global::Cpp2ILInjected.Token(Token = "0x600306E")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FBC8C", Offset = "0x12FBC8C", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StructureMap), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CorruptionPitBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "GetPossibleChestsToTrapify", MemberParameters = new object[] { typeof(StructureMap) }, ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "AreRoomsValid", MemberParameters = new object[]
		{
			typeof(IEnumerable<Rectangle>),
			typeof(StructureMap),
			typeof(HouseType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public bool CanPlace(Rectangle area, bool[] validTiles, int padding = 0)
		{
			throw null;
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x00029F60 File Offset: 0x00028160
		[global::Cpp2ILInjected.Token(Token = "0x600306F")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FBFBC", Offset = "0x12FBFBC", Length = "0x490")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<Rectangle, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Min", MemberTypeParameters = new object[] { typeof(Rectangle) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<Rectangle>),
			typeof(Func<Rectangle, int>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Max", MemberTypeParameters = new object[] { typeof(Rectangle) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<Rectangle>),
			typeof(Func<Rectangle, int>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public Rectangle GetBoundingBox()
		{
			throw null;
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00029F63 File Offset: 0x00028163
		[global::Cpp2ILInjected.Token(Token = "0x6003070")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FC44C", Offset = "0x12FC44C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceSingle", MemberParameters = new object[]
		{
			"Terraria.GameContent.Biomes.DunesBiome.DunesDescription",
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThinIceBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void AddStructure(Rectangle area, int padding = 0)
		{
			throw null;
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x00029F66 File Offset: 0x00028166
		[global::Cpp2ILInjected.Token(Token = "0x6003071")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FBADC", Offset = "0x12FBADC", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_37", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_47", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleStructure), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CorruptionPitBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HoneyPatchBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void AddProtectedStructure(Rectangle area, int padding = 0)
		{
			throw null;
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00029F69 File Offset: 0x00028169
		[global::Cpp2ILInjected.Token(Token = "0x6003072")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FC5A4", Offset = "0x12FC5A4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x00029F6C File Offset: 0x0002816C
		[global::Cpp2ILInjected.Token(Token = "0x6003073")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FC688", Offset = "0x12FC688", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GenerateWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GenerationProgress)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public StructureMap()
		{
			throw null;
		}

		// Token: 0x04003171 RID: 12657
		[global::Cpp2ILInjected.Token(Token = "0x4003A87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<Rectangle> _structures;

		// Token: 0x04003172 RID: 12658
		[global::Cpp2ILInjected.Token(Token = "0x4003A88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<Rectangle> _protectedStructures;

		// Token: 0x04003173 RID: 12659
		[global::Cpp2ILInjected.Token(Token = "0x4003A89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly object _lock;

		// Token: 0x020008D0 RID: 2256
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20004E8")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004BB5 RID: 19381 RVA: 0x0002F6B4 File Offset: 0x0002D8B4
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003074")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FC750", Offset = "0x12FC750", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004BB6 RID: 19382 RVA: 0x0002F6B7 File Offset: 0x0002D8B7
			[global::Cpp2ILInjected.Token(Token = "0x6003075")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FC7AC", Offset = "0x12FC7AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004BB7 RID: 19383 RVA: 0x0002F6BA File Offset: 0x0002D8BA
			[global::Cpp2ILInjected.Token(Token = "0x6003076")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FC7B4", Offset = "0x12FC7B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal int <GetBoundingBox>b__5_0(Rectangle rect)
			{
				throw null;
			}

			// Token: 0x06004BB8 RID: 19384 RVA: 0x0002F6BD File Offset: 0x0002D8BD
			[global::Cpp2ILInjected.Token(Token = "0x6003077")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FC7BC", Offset = "0x12FC7BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal int <GetBoundingBox>b__5_1(Rectangle rect)
			{
				throw null;
			}

			// Token: 0x06004BB9 RID: 19385 RVA: 0x0002F6C0 File Offset: 0x0002D8C0
			[global::Cpp2ILInjected.Token(Token = "0x6003078")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FC7C4", Offset = "0x12FC7C4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
			internal int <GetBoundingBox>b__5_2(Rectangle rect)
			{
				throw null;
			}

			// Token: 0x06004BBA RID: 19386 RVA: 0x0002F6C3 File Offset: 0x0002D8C3
			[global::Cpp2ILInjected.Token(Token = "0x6003079")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FC7E8", Offset = "0x12FC7E8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
			internal int <GetBoundingBox>b__5_3(Rectangle rect)
			{
				throw null;
			}

			// Token: 0x040080BD RID: 32957
			[global::Cpp2ILInjected.Token(Token = "0x4003A8A")]
			public static readonly StructureMap.<>c <>9;

			// Token: 0x040080BE RID: 32958
			[global::Cpp2ILInjected.Token(Token = "0x4003A8B")]
			public static Func<Rectangle, int> <>9__5_0;

			// Token: 0x040080BF RID: 32959
			[global::Cpp2ILInjected.Token(Token = "0x4003A8C")]
			public static Func<Rectangle, int> <>9__5_1;

			// Token: 0x040080C0 RID: 32960
			[global::Cpp2ILInjected.Token(Token = "0x4003A8D")]
			public static Func<Rectangle, int> <>9__5_2;

			// Token: 0x040080C1 RID: 32961
			[global::Cpp2ILInjected.Token(Token = "0x4003A8E")]
			public static Func<Rectangle, int> <>9__5_3;
		}
	}
}
