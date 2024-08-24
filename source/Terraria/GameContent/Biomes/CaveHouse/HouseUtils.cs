using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x0200060C RID: 1548
	[global::Cpp2ILInjected.Token(Token = "0x2000911")]
	public static class HouseUtils
	{
		// Token: 0x06003E1B RID: 15899 RVA: 0x0002D185 File Offset: 0x0002B385
		[global::Cpp2ILInjected.Token(Token = "0x60046C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E177C", Offset = "0x7E177C", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaveHouseBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseUtils), Member = "CreateRooms", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(List<Rectangle>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseUtils), Member = "AreRoomLocationsValid", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseUtils), Member = "GetHouseType", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(HouseType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseUtils), Member = "AreRoomsValid", MemberParameters = new object[]
		{
			typeof(IEnumerable<Rectangle>),
			typeof(StructureMap),
			typeof(HouseType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WoodHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IceHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JungleHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MushroomHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraniteHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarbleHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static HouseBuilder CreateBuilder(Point origin, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x0002D188 File Offset: 0x0002B388
		[global::Cpp2ILInjected.Token(Token = "0x60046C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E19E0", Offset = "0x7E19E0", Length = "0x448")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateBuilder", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(HouseBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Down), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches), Member = "Chain", MemberParameters = new object[]
		{
			typeof(GenSearch),
			typeof(GenCondition[])
		}, ReturnType = typeof(GenSearch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Find", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenSearch),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseUtils), Member = "FindRoom", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseUtils), Member = "GetRoomSolidPrecentage", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static List<Rectangle> CreateRooms(Point origin)
		{
			throw null;
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x0002D18B File Offset: 0x0002B38B
		[global::Cpp2ILInjected.Token(Token = "0x60046C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E3010", Offset = "0x7E3010", Length = "0x4A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateRooms", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(List<Rectangle>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Left), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches), Member = "Chain", MemberParameters = new object[]
		{
			typeof(GenSearch),
			typeof(GenCondition[])
		}, ReturnType = typeof(GenSearch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Find", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenSearch),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Right), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Up), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private static Rectangle FindRoom(Point origin)
		{
			throw null;
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x0002D18E File Offset: 0x0002B38E
		[global::Cpp2ILInjected.Token(Token = "0x60046C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E34B0", Offset = "0x7E34B0", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateRooms", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(List<Rectangle>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Count), Member = ".ctor", MemberParameters = new object[] { typeof(Ref<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions), Member = "Chain", MemberParameters = new object[] { typeof(GenAction[]) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static double GetRoomSolidPrecentage(Rectangle room)
		{
			throw null;
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x0002D191 File Offset: 0x0002B391
		[global::Cpp2ILInjected.Token(Token = "0x60046C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E3688", Offset = "0x7E3688", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int SortBiomeResults(Tuple<HouseType, int> item1, Tuple<HouseType, int> item2)
		{
			throw null;
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x0002D194 File Offset: 0x0002B394
		[global::Cpp2ILInjected.Token(Token = "0x60046C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E1E28", Offset = "0x7E1E28", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateBuilder", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(HouseBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static bool AreRoomLocationsValid(IEnumerable<Rectangle> rooms)
		{
			throw null;
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x0002D197 File Offset: 0x0002B397
		[global::Cpp2ILInjected.Token(Token = "0x60046C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E2150", Offset = "0x7E2150", Length = "0x8F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateBuilder", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(HouseBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.TileScanner), Member = ".ctor", MemberParameters = new object[] { typeof(ushort[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.TileScanner), Member = "Output", MemberParameters = new object[] { typeof(Dictionary<ushort, int>) }, ReturnType = typeof(Actions.TileScanner))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, int>), Member = "get_Item", MemberParameters = new object[] { typeof(ushort) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple[]), Member = "Create", MemberTypeParameters = new object[]
		{
			"System.Int32Enum",
			typeof(int)
		}, MemberParameters = new object[]
		{
			"System.Int32Enum",
			typeof(int)
		}, ReturnType = "System.Tuple`2<T1, T2>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private static HouseType GetHouseType(IEnumerable<Rectangle> rooms)
		{
			throw null;
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x0002D19A File Offset: 0x0002B39A
		[global::Cpp2ILInjected.Token(Token = "0x60046C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E2A48", Offset = "0x7E2A48", Length = "0x520")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateBuilder", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(HouseBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenSearch), Member = "RequireAll", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(GenSearch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.HasLava), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches), Member = "Chain", MemberParameters = new object[]
		{
			typeof(GenSearch),
			typeof(GenCondition[])
		}, ReturnType = typeof(GenSearch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Find", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenSearch),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(bool[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private static bool AreRoomsValid(IEnumerable<Rectangle> rooms, StructureMap structures, HouseType style)
		{
			throw null;
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x0002D19D File Offset: 0x0002B39D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60046CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E36E4", Offset = "0x7E36E4", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int[])
		}, ReturnType = typeof(bool[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static HouseUtils()
		{
			throw null;
		}

		// Token: 0x04006C33 RID: 27699
		[global::Cpp2ILInjected.Token(Token = "0x40082B4")]
		private static readonly bool[] BlacklistedTiles;

		// Token: 0x04006C34 RID: 27700
		[global::Cpp2ILInjected.Token(Token = "0x40082B5")]
		private static readonly bool[] BeelistedTiles;
	}
}
