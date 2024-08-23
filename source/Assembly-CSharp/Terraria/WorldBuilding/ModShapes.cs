using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.GameContent.Biomes.Desert;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200035C RID: 860
	[global::Cpp2ILInjected.Token(Token = "0x20004C9")]
	public static class ModShapes
	{
		// Token: 0x020008C0 RID: 2240
		[global::Cpp2ILInjected.Token(Token = "0x20004CA")]
		public class All : GenModShape
		{
			// Token: 0x06004B8D RID: 19341 RVA: 0x0002F63C File Offset: 0x0002D83C
			[global::Cpp2ILInjected.Token(Token = "0x600301C")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8640", Offset = "0x12F8640", Length = "0x28")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LarvaHoleEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceStairs", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public All(ShapeData data)
			{
				throw null;
			}

			// Token: 0x06004B8E RID: 19342 RVA: 0x0002F63F File Offset: 0x0002D83F
			[global::Cpp2ILInjected.Token(Token = "0x600301D")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8668", Offset = "0x12F8668", Length = "0x1EC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point16>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point16>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(GenAction),
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point16>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			public override bool Perform(Point origin, GenAction action)
			{
				throw null;
			}
		}

		// Token: 0x020008C1 RID: 2241
		[global::Cpp2ILInjected.Token(Token = "0x20004CB")]
		public class OuterOutline : GenModShape
		{
			// Token: 0x06004B8F RID: 19343 RVA: 0x0002F642 File Offset: 0x0002D842
			[global::Cpp2ILInjected.Token(Token = "0x600301E")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F88B8", Offset = "0x12F88B8", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public OuterOutline(ShapeData data, bool useDiagonals = true, bool useInterior = false)
			{
				throw null;
			}

			// Token: 0x06004B90 RID: 19344 RVA: 0x0002F645 File Offset: 0x0002D845
			[global::Cpp2ILInjected.Token(Token = "0x600301F")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F88F8", Offset = "0x12F88F8", Length = "0x344")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point16>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point16>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(GenAction),
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = "Contains", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point16>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			public override bool Perform(Point origin, GenAction action)
			{
				throw null;
			}

			// Token: 0x06004B91 RID: 19345 RVA: 0x0002F648 File Offset: 0x0002D848
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003020")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8C3C", Offset = "0x12F8C3C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static OuterOutline()
			{
				throw null;
			}

			// Token: 0x040080A5 RID: 32933
			[global::Cpp2ILInjected.Token(Token = "0x40039C5")]
			private static readonly int[] POINT_OFFSETS;

			// Token: 0x040080A6 RID: 32934
			[global::Cpp2ILInjected.Token(Token = "0x40039C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private bool _useDiagonals;

			// Token: 0x040080A7 RID: 32935
			[global::Cpp2ILInjected.Token(Token = "0x40039C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
			private bool _useInterior;
		}

		// Token: 0x020008C2 RID: 2242
		[global::Cpp2ILInjected.Token(Token = "0x20004CC")]
		public class InnerOutline : GenModShape
		{
			// Token: 0x06004B92 RID: 19346 RVA: 0x0002F64B File Offset: 0x0002D84B
			[global::Cpp2ILInjected.Token(Token = "0x6003021")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8CD0", Offset = "0x12F8CD0", Length = "0x30")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public InnerOutline(ShapeData data, bool useDiagonals = true)
			{
				throw null;
			}

			// Token: 0x06004B93 RID: 19347 RVA: 0x0002F64E File Offset: 0x0002D84E
			[global::Cpp2ILInjected.Token(Token = "0x6003022")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8D00", Offset = "0x12F8D00", Length = "0x28C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point16>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point16>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = "Contains", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(GenAction),
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point16>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			public override bool Perform(Point origin, GenAction action)
			{
				throw null;
			}

			// Token: 0x06004B94 RID: 19348 RVA: 0x0002F651 File Offset: 0x0002D851
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003023")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8F8C", Offset = "0x12F8F8C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static InnerOutline()
			{
				throw null;
			}

			// Token: 0x040080A8 RID: 32936
			[global::Cpp2ILInjected.Token(Token = "0x40039C8")]
			private static readonly int[] POINT_OFFSETS;

			// Token: 0x040080A9 RID: 32937
			[global::Cpp2ILInjected.Token(Token = "0x40039C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private bool _useDiagonals;
		}
	}
}
