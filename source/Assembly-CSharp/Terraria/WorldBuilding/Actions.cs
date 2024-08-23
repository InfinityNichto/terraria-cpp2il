using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.GameContent.Biomes.Desert;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000355 RID: 853
	[global::Cpp2ILInjected.Token(Token = "0x200048C")]
	public static class Actions
	{
		// Token: 0x06002C29 RID: 11305 RVA: 0x00029EAF File Offset: 0x000280AF
		[global::Cpp2ILInjected.Token(Token = "0x6002F8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3F40", Offset = "0x12F3F40", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 87)]
		public static GenAction Chain(params GenAction[] actions)
		{
			throw null;
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x00029EB2 File Offset: 0x000280B2
		[global::Cpp2ILInjected.Token(Token = "0x6002F90")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3F78", Offset = "0x12F3F78", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static GenAction Continue(GenAction action)
		{
			throw null;
		}

		// Token: 0x0200088A RID: 2186
		[global::Cpp2ILInjected.Token(Token = "0x200048D")]
		public class ContinueWrapper : GenAction
		{
			// Token: 0x06004B17 RID: 19223 RVA: 0x0002F4E6 File Offset: 0x0002D6E6
			[global::Cpp2ILInjected.Token(Token = "0x6002F91")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F3FDC", Offset = "0x12F3FDC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ContinueWrapper(GenAction action)
			{
				throw null;
			}

			// Token: 0x06004B18 RID: 19224 RVA: 0x0002F4E9 File Offset: 0x0002D6E9
			[global::Cpp2ILInjected.Token(Token = "0x6002F92")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F400C", Offset = "0x12F400C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008060 RID: 32864
			[global::Cpp2ILInjected.Token(Token = "0x4003976")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private GenAction _action;
		}

		// Token: 0x0200088B RID: 2187
		[global::Cpp2ILInjected.Token(Token = "0x200048E")]
		public class Count : GenAction
		{
			// Token: 0x06004B19 RID: 19225 RVA: 0x0002F4EC File Offset: 0x0002D6EC
			[global::Cpp2ILInjected.Token(Token = "0x6002F93")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4060", Offset = "0x12F4060", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "GetRoomSolidPrecentage", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Count(Ref<int> count)
			{
				throw null;
			}

			// Token: 0x06004B1A RID: 19226 RVA: 0x0002F4EF File Offset: 0x0002D6EF
			[global::Cpp2ILInjected.Token(Token = "0x6002F94")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4090", Offset = "0x12F4090", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008061 RID: 32865
			[global::Cpp2ILInjected.Token(Token = "0x4003977")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Ref<int> _count;
		}

		// Token: 0x0200088C RID: 2188
		[global::Cpp2ILInjected.Token(Token = "0x200048F")]
		public class Scanner : GenAction
		{
			// Token: 0x06004B1B RID: 19227 RVA: 0x0002F4F2 File Offset: 0x0002D6F2
			[global::Cpp2ILInjected.Token(Token = "0x6002F95")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F40A4", Offset = "0x12F40A4", Length = "0x30")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Scanner(Ref<int> count)
			{
				throw null;
			}

			// Token: 0x06004B1C RID: 19228 RVA: 0x0002F4F5 File Offset: 0x0002D6F5
			[global::Cpp2ILInjected.Token(Token = "0x6002F96")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F40D4", Offset = "0x12F40D4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008062 RID: 32866
			[global::Cpp2ILInjected.Token(Token = "0x4003978")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Ref<int> _count;
		}

		// Token: 0x0200088D RID: 2189
		[global::Cpp2ILInjected.Token(Token = "0x2000490")]
		public class TileScanner : GenAction
		{
			// Token: 0x06004B1D RID: 19229 RVA: 0x0002F4F8 File Offset: 0x0002D6F8
			[global::Cpp2ILInjected.Token(Token = "0x6002F97")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F40E8", Offset = "0x12F40E8", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_Tiles_PlaceIt_StaffOfRegrowthCheck", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThinIceBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "GetHouseType", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(HouseType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public TileScanner(params ushort[] tiles)
			{
				throw null;
			}

			// Token: 0x06004B1E RID: 19230 RVA: 0x0002F4FB File Offset: 0x0002D6FB
			[global::Cpp2ILInjected.Token(Token = "0x6002F98")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F41E8", Offset = "0x12F41E8", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = "get_Item", MemberParameters = new object[] { typeof(ushort) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x06004B1F RID: 19231 RVA: 0x0002F4FE File Offset: 0x0002D6FE
			[global::Cpp2ILInjected.Token(Token = "0x6002F99")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F435C", Offset = "0x12F435C", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_Tiles_PlaceIt_StaffOfRegrowthCheck", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThinIceBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "GetHouseType", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(HouseType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Actions.TileScanner Output(Dictionary<ushort, int> resultsOutput)
			{
				throw null;
			}

			// Token: 0x06004B20 RID: 19232 RVA: 0x0002F501 File Offset: 0x0002D701
			[global::Cpp2ILInjected.Token(Token = "0x6002F9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4420", Offset = "0x12F4420", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public Dictionary<ushort, int> GetResults()
			{
				throw null;
			}

			// Token: 0x06004B21 RID: 19233 RVA: 0x0002F504 File Offset: 0x0002D704
			[global::Cpp2ILInjected.Token(Token = "0x6002F9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4428", Offset = "0x12F4428", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = "get_Item", MemberParameters = new object[] { typeof(ushort) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public int GetCount(ushort tileId)
			{
				throw null;
			}

			// Token: 0x04008063 RID: 32867
			[global::Cpp2ILInjected.Token(Token = "0x4003979")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ushort[] _tileIds;

			// Token: 0x04008064 RID: 32868
			[global::Cpp2ILInjected.Token(Token = "0x400397A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Dictionary<ushort, int> _tileCounts;
		}

		// Token: 0x0200088E RID: 2190
		[global::Cpp2ILInjected.Token(Token = "0x2000491")]
		public class Blank : GenAction
		{
			// Token: 0x06004B22 RID: 19234 RVA: 0x0002F507 File Offset: 0x0002D707
			[global::Cpp2ILInjected.Token(Token = "0x6002F9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F44BC", Offset = "0x12F44BC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x06004B23 RID: 19235 RVA: 0x0002F50A File Offset: 0x0002D70A
			[global::Cpp2ILInjected.Token(Token = "0x6002F9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F44C0", Offset = "0x12F44C0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Blank()
			{
				throw null;
			}
		}

		// Token: 0x0200088F RID: 2191
		[global::Cpp2ILInjected.Token(Token = "0x2000492")]
		public class Custom : GenAction
		{
			// Token: 0x06004B24 RID: 19236 RVA: 0x0002F50D File Offset: 0x0002D70D
			[global::Cpp2ILInjected.Token(Token = "0x6002F9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F44D0", Offset = "0x12F44D0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Custom(GenBase.CustomPerUnitAction perUnit)
			{
				throw null;
			}

			// Token: 0x06004B25 RID: 19237 RVA: 0x0002F510 File Offset: 0x0002D710
			[global::Cpp2ILInjected.Token(Token = "0x6002F9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4500", Offset = "0x12F4500", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008065 RID: 32869
			[global::Cpp2ILInjected.Token(Token = "0x400397B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private GenBase.CustomPerUnitAction _perUnit;
		}

		// Token: 0x02000890 RID: 2192
		[global::Cpp2ILInjected.Token(Token = "0x2000493")]
		public class ClearMetadata : GenAction
		{
			// Token: 0x06004B26 RID: 19238 RVA: 0x0002F513 File Offset: 0x0002D713
			[global::Cpp2ILInjected.Token(Token = "0x6002FA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F457C", Offset = "0x12F457C", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearMetadata", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x06004B27 RID: 19239 RVA: 0x0002F516 File Offset: 0x0002D716
			[global::Cpp2ILInjected.Token(Token = "0x6002FA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4638", Offset = "0x12F4638", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlacePlatforms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ClearMetadata()
			{
				throw null;
			}
		}

		// Token: 0x02000891 RID: 2193
		[global::Cpp2ILInjected.Token(Token = "0x2000494")]
		public class Clear : GenAction
		{
			// Token: 0x06004B28 RID: 19240 RVA: 0x0002F519 File Offset: 0x0002D719
			[global::Cpp2ILInjected.Token(Token = "0x6002FA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4648", Offset = "0x12F4648", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearEverything", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x06004B29 RID: 19241 RVA: 0x0002F51C File Offset: 0x0002D71C
			[global::Cpp2ILInjected.Token(Token = "0x6002FA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4704", Offset = "0x12F4704", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnthillEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LarvaHoleEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceStairs", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Clear()
			{
				throw null;
			}
		}

		// Token: 0x02000892 RID: 2194
		[global::Cpp2ILInjected.Token(Token = "0x2000495")]
		public class ClearTile : GenAction
		{
			// Token: 0x06004B2A RID: 19242 RVA: 0x0002F51F File Offset: 0x0002D71F
			[global::Cpp2ILInjected.Token(Token = "0x6002FA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4714", Offset = "0x12F4714", Length = "0x30")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnthillEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceEmptyRooms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceDoors", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ClearTile(bool frameNeighbors = false)
			{
				throw null;
			}

			// Token: 0x06004B2B RID: 19243 RVA: 0x0002F522 File Offset: 0x0002D722
			[global::Cpp2ILInjected.Token(Token = "0x6002FA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4744", Offset = "0x12F4744", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "ClearTile", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008066 RID: 32870
			[global::Cpp2ILInjected.Token(Token = "0x400397C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _frameNeighbors;
		}

		// Token: 0x02000893 RID: 2195
		[global::Cpp2ILInjected.Token(Token = "0x2000496")]
		public class ClearWall : GenAction
		{
			// Token: 0x06004B2C RID: 19244 RVA: 0x0002F525 File Offset: 0x0002D725
			[global::Cpp2ILInjected.Token(Token = "0x6002FA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F48B8", Offset = "0x12F48B8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ClearWall(bool frameNeighbors = false)
			{
				throw null;
			}

			// Token: 0x06004B2D RID: 19245 RVA: 0x0002F528 File Offset: 0x0002D728
			[global::Cpp2ILInjected.Token(Token = "0x6002FA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F48E8", Offset = "0x12F48E8", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "ClearWall", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008067 RID: 32871
			[global::Cpp2ILInjected.Token(Token = "0x400397D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _frameNeighbors;
		}

		// Token: 0x02000894 RID: 2196
		[global::Cpp2ILInjected.Token(Token = "0x2000497")]
		public class HalfBlock : GenAction
		{
			// Token: 0x06004B2E RID: 19246 RVA: 0x0002F52B File Offset: 0x0002D72B
			[global::Cpp2ILInjected.Token(Token = "0x6002FA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4A50", Offset = "0x12F4A50", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HalfBlock(bool value = true)
			{
				throw null;
			}

			// Token: 0x06004B2F RID: 19247 RVA: 0x0002F52E File Offset: 0x0002D72E
			[global::Cpp2ILInjected.Token(Token = "0x6002FA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4A80", Offset = "0x12F4A80", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008068 RID: 32872
			[global::Cpp2ILInjected.Token(Token = "0x400397E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _value;
		}

		// Token: 0x02000895 RID: 2197
		[global::Cpp2ILInjected.Token(Token = "0x2000498")]
		public class SetTile : GenAction
		{
			// Token: 0x06004B30 RID: 19248 RVA: 0x0002F531 File Offset: 0x0002D731
			[global::Cpp2ILInjected.Token(Token = "0x6002FAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4B40", Offset = "0x12F4B40", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThinIceBiome), Member = "Place", MemberParameters = new object[]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LarvaHoleEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SetTile(ushort type, bool setSelfFrames = false, bool setNeighborFrames = true)
			{
				throw null;
			}

			// Token: 0x06004B31 RID: 19249 RVA: 0x0002F534 File Offset: 0x0002D734
			[global::Cpp2ILInjected.Token(Token = "0x6002FAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4B88", Offset = "0x12F4B88", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "TileFrame", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008069 RID: 32873
			[global::Cpp2ILInjected.Token(Token = "0x400397F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
			private ushort _type;

			// Token: 0x0400806A RID: 32874
			[global::Cpp2ILInjected.Token(Token = "0x4003980")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private bool _doFraming;

			// Token: 0x0400806B RID: 32875
			[global::Cpp2ILInjected.Token(Token = "0x4003981")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
			private bool _doNeighborFraming;
		}

		// Token: 0x02000896 RID: 2198
		[global::Cpp2ILInjected.Token(Token = "0x2000499")]
		public class SetTileKeepWall : GenAction
		{
			// Token: 0x06004B32 RID: 19250 RVA: 0x0002F537 File Offset: 0x0002D737
			[global::Cpp2ILInjected.Token(Token = "0x6002FAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4D78", Offset = "0x12F4D78", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceEmptyRooms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceSupportBeams", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SetTileKeepWall(ushort type, bool setSelfFrames = false, bool setNeighborFrames = true)
			{
				throw null;
			}

			// Token: 0x06004B33 RID: 19251 RVA: 0x0002F53A File Offset: 0x0002D73A
			[global::Cpp2ILInjected.Token(Token = "0x6002FAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4DC0", Offset = "0x12F4DC0", Length = "0x170")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wallFrameX", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wallFrameY", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wallFrameX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wallFrameY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "TileFrame", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x0400806C RID: 32876
			[global::Cpp2ILInjected.Token(Token = "0x4003982")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
			private ushort _type;

			// Token: 0x0400806D RID: 32877
			[global::Cpp2ILInjected.Token(Token = "0x4003983")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private bool _doFraming;

			// Token: 0x0400806E RID: 32878
			[global::Cpp2ILInjected.Token(Token = "0x4003984")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
			private bool _doNeighborFraming;
		}

		// Token: 0x02000897 RID: 2199
		[global::Cpp2ILInjected.Token(Token = "0x200049A")]
		public class DebugDraw : GenAction
		{
			// Token: 0x06004B34 RID: 19252 RVA: 0x0002F53D File Offset: 0x0002D73D
			[global::Cpp2ILInjected.Token(Token = "0x6002FAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4F30", Offset = "0x12F4F30", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DebugDraw(SpriteBatch spriteBatch, Color color = default(Color))
			{
				throw null;
			}

			// Token: 0x06004B35 RID: 19253 RVA: 0x0002F540 File Offset: 0x0002D740
			[global::Cpp2ILInjected.Token(Token = "0x6002FAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F4F68", Offset = "0x12F4F68", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Rectangle),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x0400806F RID: 32879
			[global::Cpp2ILInjected.Token(Token = "0x4003985")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private Color _color;

			// Token: 0x04008070 RID: 32880
			[global::Cpp2ILInjected.Token(Token = "0x4003986")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private SpriteBatch _spriteBatch;
		}

		// Token: 0x02000898 RID: 2200
		[global::Cpp2ILInjected.Token(Token = "0x200049B")]
		public class SetSlope : GenAction
		{
			// Token: 0x06004B36 RID: 19254 RVA: 0x0002F543 File Offset: 0x0002D743
			[global::Cpp2ILInjected.Token(Token = "0x6002FB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F50C8", Offset = "0x12F50C8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceStairs", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SetSlope(int slope)
			{
				throw null;
			}

			// Token: 0x06004B37 RID: 19255 RVA: 0x0002F546 File Offset: 0x0002D746
			[global::Cpp2ILInjected.Token(Token = "0x6002FB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F50F8", Offset = "0x12F50F8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SlopeTile", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008071 RID: 32881
			[global::Cpp2ILInjected.Token(Token = "0x4003987")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _slope;
		}

		// Token: 0x02000899 RID: 2201
		[global::Cpp2ILInjected.Token(Token = "0x200049C")]
		public class SetHalfTile : GenAction
		{
			// Token: 0x06004B38 RID: 19256 RVA: 0x0002F549 File Offset: 0x0002D749
			[global::Cpp2ILInjected.Token(Token = "0x6002FB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5198", Offset = "0x12F5198", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SetHalfTile(bool halfTile)
			{
				throw null;
			}

			// Token: 0x06004B39 RID: 19257 RVA: 0x0002F54C File Offset: 0x0002D74C
			[global::Cpp2ILInjected.Token(Token = "0x6002FB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F51C8", Offset = "0x12F51C8", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008072 RID: 32882
			[global::Cpp2ILInjected.Token(Token = "0x4003988")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _halfTile;
		}

		// Token: 0x0200089A RID: 2202
		[global::Cpp2ILInjected.Token(Token = "0x200049D")]
		public class SetTileAndWallRainbowPaint : GenAction
		{
			// Token: 0x06004B3A RID: 19258 RVA: 0x0002F54F File Offset: 0x0002D74F
			[global::Cpp2ILInjected.Token(Token = "0x6002FB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5288", Offset = "0x12F5288", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "RainbowifyOnTenthAnniversaryWorlds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SetTileAndWallRainbowPaint()
			{
				throw null;
			}

			// Token: 0x06004B3B RID: 19259 RVA: 0x0002F552 File Offset: 0x0002D752
			[global::Cpp2ILInjected.Token(Token = "0x6002FB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5298", Offset = "0x12F5298", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetTileAndWallRainbowPaint), Member = "GetPaintIDForPosition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "color", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wallColor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x06004B3C RID: 19260 RVA: 0x0002F555 File Offset: 0x0002D755
			[global::Cpp2ILInjected.Token(Token = "0x6002FB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F53CC", Offset = "0x12F53CC", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetTileAndWallRainbowPaint), Member = "Apply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private byte GetPaintIDForPosition(int x, int y)
			{
				throw null;
			}
		}

		// Token: 0x0200089B RID: 2203
		[global::Cpp2ILInjected.Token(Token = "0x200049E")]
		public class PlaceTile : GenAction
		{
			// Token: 0x06004B3D RID: 19261 RVA: 0x0002F558 File Offset: 0x0002D758
			[global::Cpp2ILInjected.Token(Token = "0x6002FB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F54AC", Offset = "0x12F54AC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceStairs", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlacePlatforms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PlaceTile(ushort type, int style = 0)
			{
				throw null;
			}

			// Token: 0x06004B3E RID: 19262 RVA: 0x0002F55B File Offset: 0x0002D75B
			[global::Cpp2ILInjected.Token(Token = "0x6002FB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F54E4", Offset = "0x12F54E4", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008073 RID: 32883
			[global::Cpp2ILInjected.Token(Token = "0x4003989")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
			private ushort _type;

			// Token: 0x04008074 RID: 32884
			[global::Cpp2ILInjected.Token(Token = "0x400398A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _style;
		}

		// Token: 0x0200089C RID: 2204
		[global::Cpp2ILInjected.Token(Token = "0x200049F")]
		public class RemoveWall : GenAction
		{
			// Token: 0x06004B3F RID: 19263 RVA: 0x0002F55E File Offset: 0x0002D75E
			[global::Cpp2ILInjected.Token(Token = "0x6002FB9")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5594", Offset = "0x12F5594", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x06004B40 RID: 19264 RVA: 0x0002F561 File Offset: 0x0002D761
			[global::Cpp2ILInjected.Token(Token = "0x6002FBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5654", Offset = "0x12F5654", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RemoveWall()
			{
				throw null;
			}
		}

		// Token: 0x0200089D RID: 2205
		[global::Cpp2ILInjected.Token(Token = "0x20004A0")]
		public class PlaceWall : GenAction
		{
			// Token: 0x06004B41 RID: 19265 RVA: 0x0002F564 File Offset: 0x0002D764
			[global::Cpp2ILInjected.Token(Token = "0x6002FBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5664", Offset = "0x12F5664", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LarvaHoleEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceEmptyRooms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceStairs", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PlaceWall(ushort type, bool neighbors = true)
			{
				throw null;
			}

			// Token: 0x06004B42 RID: 19266 RVA: 0x0002F567 File Offset: 0x0002D767
			[global::Cpp2ILInjected.Token(Token = "0x6002FBC")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F569C", Offset = "0x12F569C", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SquareWallFrame", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008075 RID: 32885
			[global::Cpp2ILInjected.Token(Token = "0x400398B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
			private ushort _type;

			// Token: 0x04008076 RID: 32886
			[global::Cpp2ILInjected.Token(Token = "0x400398C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private bool _neighbors;
		}

		// Token: 0x0200089E RID: 2206
		[global::Cpp2ILInjected.Token(Token = "0x20004A1")]
		public class SetLiquid : GenAction
		{
			// Token: 0x06004B43 RID: 19267 RVA: 0x0002F56A File Offset: 0x0002D76A
			[global::Cpp2ILInjected.Token(Token = "0x6002FBD")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5818", Offset = "0x12F5818", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HoneyPatchBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThinIceBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SetLiquid(int type = 0, byte value = 255)
			{
				throw null;
			}

			// Token: 0x06004B44 RID: 19268 RVA: 0x0002F56D File Offset: 0x0002D76D
			[global::Cpp2ILInjected.Token(Token = "0x6002FBE")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5850", Offset = "0x12F5850", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_liquid", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008077 RID: 32887
			[global::Cpp2ILInjected.Token(Token = "0x400398D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _type;

			// Token: 0x04008078 RID: 32888
			[global::Cpp2ILInjected.Token(Token = "0x400398E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private byte _value;
		}

		// Token: 0x0200089F RID: 2207
		[global::Cpp2ILInjected.Token(Token = "0x20004A2")]
		public class SwapSolidTile : GenAction
		{
			// Token: 0x06004B45 RID: 19269 RVA: 0x0002F570 File Offset: 0x0002D770
			[global::Cpp2ILInjected.Token(Token = "0x6002FBF")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5920", Offset = "0x12F5920", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SwapSolidTile(ushort type)
			{
				throw null;
			}

			// Token: 0x06004B46 RID: 19270 RVA: 0x0002F573 File Offset: 0x0002D773
			[global::Cpp2ILInjected.Token(Token = "0x6002FC0")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5950", Offset = "0x12F5950", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x04008079 RID: 32889
			[global::Cpp2ILInjected.Token(Token = "0x400398F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
			private ushort _type;
		}

		// Token: 0x020008A0 RID: 2208
		[global::Cpp2ILInjected.Token(Token = "0x20004A3")]
		public class SetFrames : GenAction
		{
			// Token: 0x06004B47 RID: 19271 RVA: 0x0002F576 File Offset: 0x0002D776
			[global::Cpp2ILInjected.Token(Token = "0x6002FC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5A78", Offset = "0x12F5A78", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceEmptyRooms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceStairs", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlacePlatforms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceSupportBeams", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SetFrames(bool frameNeighbors = false)
			{
				throw null;
			}

			// Token: 0x06004B48 RID: 19272 RVA: 0x0002F579 File Offset: 0x0002D779
			[global::Cpp2ILInjected.Token(Token = "0x6002FC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5AA8", Offset = "0x12F5AA8", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "TileFrame", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x0400807A RID: 32890
			[global::Cpp2ILInjected.Token(Token = "0x4003990")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _frameNeighbors;
		}

		// Token: 0x020008A1 RID: 2209
		[global::Cpp2ILInjected.Token(Token = "0x20004A4")]
		public class Smooth : GenAction
		{
			// Token: 0x06004B49 RID: 19273 RVA: 0x0002F57C File Offset: 0x0002D77C
			[global::Cpp2ILInjected.Token(Token = "0x6002FC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5AFC", Offset = "0x12F5AFC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnthillEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LarvaHoleEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Smooth(bool applyToNeighbors = false)
			{
				throw null;
			}

			// Token: 0x06004B4A RID: 19274 RVA: 0x0002F57F File Offset: 0x0002D77F
			[global::Cpp2ILInjected.Token(Token = "0x6002FC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5B2C", Offset = "0x12F5B2C", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x0400807B RID: 32891
			[global::Cpp2ILInjected.Token(Token = "0x4003991")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _applyToNeighbors;
		}
	}
}
