using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.GameContent.Biomes.Desert;
using Terraria.IO;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200035A RID: 858
	[global::Cpp2ILInjected.Token(Token = "0x20004B1")]
	public static class Modifiers
	{
		// Token: 0x020008AA RID: 2218
		[global::Cpp2ILInjected.Token(Token = "0x20004B2")]
		public class ShapeScale : GenAction
		{
			// Token: 0x06004B5B RID: 19291 RVA: 0x0002F5A6 File Offset: 0x0002D7A6
			[global::Cpp2ILInjected.Token(Token = "0x6002FE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F68DC", Offset = "0x12F68DC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ShapeScale(int scale)
			{
				throw null;
			}

			// Token: 0x06004B5C RID: 19292 RVA: 0x0002F5A9 File Offset: 0x0002D7A9
			[global::Cpp2ILInjected.Token(Token = "0x6002FEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F690C", Offset = "0x12F690C", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

			// Token: 0x04008081 RID: 32897
			[global::Cpp2ILInjected.Token(Token = "0x40039A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _scale;
		}

		// Token: 0x020008AB RID: 2219
		[global::Cpp2ILInjected.Token(Token = "0x20004B3")]
		public class Expand : GenAction
		{
			// Token: 0x06004B5D RID: 19293 RVA: 0x0002F5AC File Offset: 0x0002D7AC
			[global::Cpp2ILInjected.Token(Token = "0x6002FEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6A38", Offset = "0x12F6A38", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Expand(int expansion)
			{
				throw null;
			}

			// Token: 0x06004B5E RID: 19294 RVA: 0x0002F5AF File Offset: 0x0002D7AF
			[global::Cpp2ILInjected.Token(Token = "0x6002FEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6A68", Offset = "0x12F6A68", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Expand(int xExpansion, int yExpansion)
			{
				throw null;
			}

			// Token: 0x06004B5F RID: 19295 RVA: 0x0002F5B2 File Offset: 0x0002D7B2
			[global::Cpp2ILInjected.Token(Token = "0x6002FED")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6A9C", Offset = "0x12F6A9C", Length = "0xB4")]
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

			// Token: 0x04008082 RID: 32898
			[global::Cpp2ILInjected.Token(Token = "0x40039A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _xExpansion;

			// Token: 0x04008083 RID: 32899
			[global::Cpp2ILInjected.Token(Token = "0x40039A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _yExpansion;
		}

		// Token: 0x020008AC RID: 2220
		[global::Cpp2ILInjected.Token(Token = "0x20004B4")]
		public class RadialDither : GenAction
		{
			// Token: 0x06004B60 RID: 19296 RVA: 0x0002F5B5 File Offset: 0x0002D7B5
			[global::Cpp2ILInjected.Token(Token = "0x6002FEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6B50", Offset = "0x12F6B50", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HoneyPatchBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RadialDither(double innerRadius, double outerRadius)
			{
				throw null;
			}

			// Token: 0x06004B61 RID: 19297 RVA: 0x0002F5B8 File Offset: 0x0002D7B8
			[global::Cpp2ILInjected.Token(Token = "0x6002FEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6B84", Offset = "0x12F6B84", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Distance", MemberParameters = new object[]
			{
				typeof(Vector2D),
				typeof(Vector2D)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
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

			// Token: 0x04008084 RID: 32900
			[global::Cpp2ILInjected.Token(Token = "0x40039A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private double _innerRadius;

			// Token: 0x04008085 RID: 32901
			[global::Cpp2ILInjected.Token(Token = "0x40039A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private double _outerRadius;
		}

		// Token: 0x020008AD RID: 2221
		[global::Cpp2ILInjected.Token(Token = "0x20004B5")]
		public class Blotches : GenAction
		{
			// Token: 0x06004B62 RID: 19298 RVA: 0x0002F5BB File Offset: 0x0002D7BB
			[global::Cpp2ILInjected.Token(Token = "0x6002FF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6D24", Offset = "0x12F6D24", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Blotches(int scale = 2, double chance = 0.3)
			{
				throw null;
			}

			// Token: 0x06004B63 RID: 19299 RVA: 0x0002F5BE File Offset: 0x0002D7BE
			[global::Cpp2ILInjected.Token(Token = "0x6002FF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6D68", Offset = "0x12F6D68", Length = "0x48")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Blotches(int xScale, int yScale, double chance = 0.3)
			{
				throw null;
			}

			// Token: 0x06004B64 RID: 19300 RVA: 0x0002F5C1 File Offset: 0x0002D7C1
			[global::Cpp2ILInjected.Token(Token = "0x6002FF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6DB0", Offset = "0x12F6DB0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Blotches(int leftScale, int upScale, int rightScale, int downScale, double chance = 0.3)
			{
				throw null;
			}

			// Token: 0x06004B65 RID: 19301 RVA: 0x0002F5C4 File Offset: 0x0002D7C4
			[global::Cpp2ILInjected.Token(Token = "0x6002FF3")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6E08", Offset = "0x12F6E08", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
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

			// Token: 0x04008086 RID: 32902
			[global::Cpp2ILInjected.Token(Token = "0x40039A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _minX;

			// Token: 0x04008087 RID: 32903
			[global::Cpp2ILInjected.Token(Token = "0x40039A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _minY;

			// Token: 0x04008088 RID: 32904
			[global::Cpp2ILInjected.Token(Token = "0x40039A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private int _maxX;

			// Token: 0x04008089 RID: 32905
			[global::Cpp2ILInjected.Token(Token = "0x40039A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private int _maxY;

			// Token: 0x0400808A RID: 32906
			[global::Cpp2ILInjected.Token(Token = "0x40039A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private double _chance;
		}

		// Token: 0x020008AE RID: 2222
		[global::Cpp2ILInjected.Token(Token = "0x20004B6")]
		public class InShape : GenAction
		{
			// Token: 0x06004B66 RID: 19302 RVA: 0x0002F5C7 File Offset: 0x0002D7C7
			[global::Cpp2ILInjected.Token(Token = "0x6002FF4")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7004", Offset = "0x12F7004", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public InShape(ShapeData shapeData)
			{
				throw null;
			}

			// Token: 0x06004B67 RID: 19303 RVA: 0x0002F5CA File Offset: 0x0002D7CA
			[global::Cpp2ILInjected.Token(Token = "0x6002FF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7034", Offset = "0x12F7034", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = "Contains", MemberParameters = new object[]
			{
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
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x0400808B RID: 32907
			[global::Cpp2ILInjected.Token(Token = "0x40039AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private readonly ShapeData _shapeData;
		}

		// Token: 0x020008AF RID: 2223
		[global::Cpp2ILInjected.Token(Token = "0x20004B7")]
		public class NotInShape : GenAction
		{
			// Token: 0x06004B68 RID: 19304 RVA: 0x0002F5CD File Offset: 0x0002D7CD
			[global::Cpp2ILInjected.Token(Token = "0x6002FF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7134", Offset = "0x12F7134", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NotInShape(ShapeData shapeData)
			{
				throw null;
			}

			// Token: 0x06004B69 RID: 19305 RVA: 0x0002F5D0 File Offset: 0x0002D7D0
			[global::Cpp2ILInjected.Token(Token = "0x6002FF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7164", Offset = "0x12F7164", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = "Contains", MemberParameters = new object[]
			{
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
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x0400808C RID: 32908
			[global::Cpp2ILInjected.Token(Token = "0x40039AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private readonly ShapeData _shapeData;
		}

		// Token: 0x020008B0 RID: 2224
		[global::Cpp2ILInjected.Token(Token = "0x20004B8")]
		public class Conditions : GenAction
		{
			// Token: 0x06004B6A RID: 19306 RVA: 0x0002F5D3 File Offset: 0x0002D7D3
			[global::Cpp2ILInjected.Token(Token = "0x6002FF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F71DC", Offset = "0x12F71DC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Conditions(params GenCondition[] conditions)
			{
				throw null;
			}

			// Token: 0x06004B6B RID: 19307 RVA: 0x0002F5D6 File Offset: 0x0002D7D6
			[global::Cpp2ILInjected.Token(Token = "0x6002FF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F720C", Offset = "0x12F720C", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenCondition), Member = "IsValid", MemberParameters = new object[]
			{
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
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x0400808D RID: 32909
			[global::Cpp2ILInjected.Token(Token = "0x40039AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private readonly GenCondition[] _conditions;
		}

		// Token: 0x020008B1 RID: 2225
		[global::Cpp2ILInjected.Token(Token = "0x20004B9")]
		public class OnlyWalls : GenAction
		{
			// Token: 0x06004B6C RID: 19308 RVA: 0x0002F5D9 File Offset: 0x0002D7D9
			[global::Cpp2ILInjected.Token(Token = "0x6002FFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F72C0", Offset = "0x12F72C0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public OnlyWalls(params ushort[] types)
			{
				throw null;
			}

			// Token: 0x06004B6D RID: 19309 RVA: 0x0002F5DC File Offset: 0x0002D7DC
			[global::Cpp2ILInjected.Token(Token = "0x6002FFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F72F0", Offset = "0x12F72F0", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
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

			// Token: 0x0400808E RID: 32910
			[global::Cpp2ILInjected.Token(Token = "0x40039AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ushort[] _types;
		}

		// Token: 0x020008B2 RID: 2226
		[global::Cpp2ILInjected.Token(Token = "0x20004BA")]
		public class OnlyTiles : GenAction
		{
			// Token: 0x06004B6E RID: 19310 RVA: 0x0002F5DF File Offset: 0x0002D7DF
			[global::Cpp2ILInjected.Token(Token = "0x6002FFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7400", Offset = "0x12F7400", Length = "0x30")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThinIceBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
			{
				typeof(DesertDescription),
				typeof(Point)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public OnlyTiles(params ushort[] types)
			{
				throw null;
			}

			// Token: 0x06004B6F RID: 19311 RVA: 0x0002F5E2 File Offset: 0x0002D7E2
			[global::Cpp2ILInjected.Token(Token = "0x6002FFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7430", Offset = "0x12F7430", Length = "0x16C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
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

			// Token: 0x0400808F RID: 32911
			[global::Cpp2ILInjected.Token(Token = "0x40039AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ushort[] _types;
		}

		// Token: 0x020008B3 RID: 2227
		[global::Cpp2ILInjected.Token(Token = "0x20004BB")]
		public class IsTouching : GenAction
		{
			// Token: 0x06004B70 RID: 19312 RVA: 0x0002F5E5 File Offset: 0x0002D7E5
			[global::Cpp2ILInjected.Token(Token = "0x6002FFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F759C", Offset = "0x12F759C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsTouching(bool useDiagonals, params ushort[] tileIds)
			{
				throw null;
			}

			// Token: 0x06004B71 RID: 19313 RVA: 0x0002F5E8 File Offset: 0x0002D7E8
			[global::Cpp2ILInjected.Token(Token = "0x6002FFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F75D4", Offset = "0x12F75D4", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
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

			// Token: 0x06004B72 RID: 19314 RVA: 0x0002F5EB File Offset: 0x0002D7EB
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003000")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7780", Offset = "0x12F7780", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static IsTouching()
			{
				throw null;
			}

			// Token: 0x04008090 RID: 32912
			[global::Cpp2ILInjected.Token(Token = "0x40039AF")]
			private static readonly int[] DIRECTIONS;

			// Token: 0x04008091 RID: 32913
			[global::Cpp2ILInjected.Token(Token = "0x40039B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _useDiagonals;

			// Token: 0x04008092 RID: 32914
			[global::Cpp2ILInjected.Token(Token = "0x40039B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ushort[] _tileIds;
		}

		// Token: 0x020008B4 RID: 2228
		[global::Cpp2ILInjected.Token(Token = "0x20004BC")]
		public class NotTouching : GenAction
		{
			// Token: 0x06004B73 RID: 19315 RVA: 0x0002F5EE File Offset: 0x0002D7EE
			[global::Cpp2ILInjected.Token(Token = "0x6003001")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7814", Offset = "0x12F7814", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CorruptionPitBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NotTouching(bool useDiagonals, params ushort[] tileIds)
			{
				throw null;
			}

			// Token: 0x06004B74 RID: 19316 RVA: 0x0002F5F1 File Offset: 0x0002D7F1
			[global::Cpp2ILInjected.Token(Token = "0x6003002")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F784C", Offset = "0x12F784C", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
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

			// Token: 0x06004B75 RID: 19317 RVA: 0x0002F5F4 File Offset: 0x0002D7F4
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003003")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F79F8", Offset = "0x12F79F8", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static NotTouching()
			{
				throw null;
			}

			// Token: 0x04008093 RID: 32915
			[global::Cpp2ILInjected.Token(Token = "0x40039B2")]
			private static readonly int[] DIRECTIONS;

			// Token: 0x04008094 RID: 32916
			[global::Cpp2ILInjected.Token(Token = "0x40039B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _useDiagonals;

			// Token: 0x04008095 RID: 32917
			[global::Cpp2ILInjected.Token(Token = "0x40039B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ushort[] _tileIds;
		}

		// Token: 0x020008B5 RID: 2229
		[global::Cpp2ILInjected.Token(Token = "0x20004BD")]
		public class IsTouchingAir : GenAction
		{
			// Token: 0x06004B76 RID: 19318 RVA: 0x0002F5F7 File Offset: 0x0002D7F7
			[global::Cpp2ILInjected.Token(Token = "0x6003004")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7A8C", Offset = "0x12F7A8C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CorruptionPitBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsTouchingAir(bool useDiagonals = false)
			{
				throw null;
			}

			// Token: 0x06004B77 RID: 19319 RVA: 0x0002F5FA File Offset: 0x0002D7FA
			[global::Cpp2ILInjected.Token(Token = "0x6003005")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7ABC", Offset = "0x12F7ABC", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
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

			// Token: 0x06004B78 RID: 19320 RVA: 0x0002F5FD File Offset: 0x0002D7FD
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003006")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7C18", Offset = "0x12F7C18", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static IsTouchingAir()
			{
				throw null;
			}

			// Token: 0x04008096 RID: 32918
			[global::Cpp2ILInjected.Token(Token = "0x40039B5")]
			private static readonly int[] DIRECTIONS;

			// Token: 0x04008097 RID: 32919
			[global::Cpp2ILInjected.Token(Token = "0x40039B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _useDiagonals;
		}

		// Token: 0x020008B6 RID: 2230
		[global::Cpp2ILInjected.Token(Token = "0x20004BE")]
		public class SkipTiles : GenAction
		{
			// Token: 0x06004B79 RID: 19321 RVA: 0x0002F600 File Offset: 0x0002D800
			[global::Cpp2ILInjected.Token(Token = "0x6003007")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7CAC", Offset = "0x12F7CAC", Length = "0x30")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SkipTiles(params ushort[] types)
			{
				throw null;
			}

			// Token: 0x06004B7A RID: 19322 RVA: 0x0002F603 File Offset: 0x0002D803
			[global::Cpp2ILInjected.Token(Token = "0x6003008")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7CDC", Offset = "0x12F7CDC", Length = "0x16C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
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

			// Token: 0x04008098 RID: 32920
			[global::Cpp2ILInjected.Token(Token = "0x40039B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ushort[] _types;
		}

		// Token: 0x020008B7 RID: 2231
		[global::Cpp2ILInjected.Token(Token = "0x20004BF")]
		public class HasLiquid : GenAction
		{
			// Token: 0x06004B7B RID: 19323 RVA: 0x0002F606 File Offset: 0x0002D806
			[global::Cpp2ILInjected.Token(Token = "0x6003009")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7E48", Offset = "0x12F7E48", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThinIceBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HasLiquid(int liquidLevel = -1, int liquidType = -1)
			{
				throw null;
			}

			// Token: 0x06004B7C RID: 19324 RVA: 0x0002F609 File Offset: 0x0002D809
			[global::Cpp2ILInjected.Token(Token = "0x600300A")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7E7C", Offset = "0x12F7E7C", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
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

			// Token: 0x04008099 RID: 32921
			[global::Cpp2ILInjected.Token(Token = "0x40039B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _liquidType;

			// Token: 0x0400809A RID: 32922
			[global::Cpp2ILInjected.Token(Token = "0x40039B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _liquidLevel;
		}

		// Token: 0x020008B8 RID: 2232
		[global::Cpp2ILInjected.Token(Token = "0x20004C0")]
		public class SkipWalls : GenAction
		{
			// Token: 0x06004B7D RID: 19325 RVA: 0x0002F60C File Offset: 0x0002D80C
			[global::Cpp2ILInjected.Token(Token = "0x600300B")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7F98", Offset = "0x12F7F98", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SkipWalls(params ushort[] types)
			{
				throw null;
			}

			// Token: 0x06004B7E RID: 19326 RVA: 0x0002F60F File Offset: 0x0002D80F
			[global::Cpp2ILInjected.Token(Token = "0x600300C")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F7FC8", Offset = "0x12F7FC8", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
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

			// Token: 0x0400809B RID: 32923
			[global::Cpp2ILInjected.Token(Token = "0x40039BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ushort[] _types;
		}

		// Token: 0x020008B9 RID: 2233
		[global::Cpp2ILInjected.Token(Token = "0x20004C1")]
		public class IsEmpty : GenAction
		{
			// Token: 0x06004B7F RID: 19327 RVA: 0x0002F612 File Offset: 0x0002D812
			[global::Cpp2ILInjected.Token(Token = "0x600300D")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F80D8", Offset = "0x12F80D8", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
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

			// Token: 0x06004B80 RID: 19328 RVA: 0x0002F615 File Offset: 0x0002D815
			[global::Cpp2ILInjected.Token(Token = "0x600300E")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F81A8", Offset = "0x12F81A8", Length = "0x10")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsEmpty()
			{
				throw null;
			}
		}

		// Token: 0x020008BA RID: 2234
		[global::Cpp2ILInjected.Token(Token = "0x20004C2")]
		public class IsSolid : GenAction
		{
			// Token: 0x06004B81 RID: 19329 RVA: 0x0002F618 File Offset: 0x0002D818
			[global::Cpp2ILInjected.Token(Token = "0x600300F")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F81B8", Offset = "0x12F81B8", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidOrSlopedTile", MemberParameters = new object[]
			{
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x06004B82 RID: 19330 RVA: 0x0002F61B File Offset: 0x0002D81B
			[global::Cpp2ILInjected.Token(Token = "0x6003010")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F82D4", Offset = "0x12F82D4", Length = "0x10")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "GetRoomSolidPrecentage", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsSolid()
			{
				throw null;
			}
		}

		// Token: 0x020008BB RID: 2235
		[global::Cpp2ILInjected.Token(Token = "0x20004C3")]
		public class IsNotSolid : GenAction
		{
			// Token: 0x06004B83 RID: 19331 RVA: 0x0002F61E File Offset: 0x0002D81E
			[global::Cpp2ILInjected.Token(Token = "0x6003011")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F82E4", Offset = "0x12F82E4", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidOrSlopedTile", MemberParameters = new object[]
			{
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				throw null;
			}

			// Token: 0x06004B84 RID: 19332 RVA: 0x0002F621 File Offset: 0x0002D821
			[global::Cpp2ILInjected.Token(Token = "0x6003012")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8400", Offset = "0x12F8400", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsNotSolid()
			{
				throw null;
			}
		}

		// Token: 0x020008BC RID: 2236
		[global::Cpp2ILInjected.Token(Token = "0x20004C4")]
		public class RectangleMask : GenAction
		{
			// Token: 0x06004B85 RID: 19333 RVA: 0x0002F624 File Offset: 0x0002D824
			[global::Cpp2ILInjected.Token(Token = "0x6003013")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8410", Offset = "0x12F8410", Length = "0x48")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RectangleMask(int xMin, int xMax, int yMin, int yMax)
			{
				throw null;
			}

			// Token: 0x06004B86 RID: 19334 RVA: 0x0002F627 File Offset: 0x0002D827
			[global::Cpp2ILInjected.Token(Token = "0x6003014")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8458", Offset = "0x12F8458", Length = "0x58")]
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

			// Token: 0x0400809C RID: 32924
			[global::Cpp2ILInjected.Token(Token = "0x40039BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _xMin;

			// Token: 0x0400809D RID: 32925
			[global::Cpp2ILInjected.Token(Token = "0x40039BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _yMin;

			// Token: 0x0400809E RID: 32926
			[global::Cpp2ILInjected.Token(Token = "0x40039BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private int _xMax;

			// Token: 0x0400809F RID: 32927
			[global::Cpp2ILInjected.Token(Token = "0x40039BE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private int _yMax;
		}

		// Token: 0x020008BD RID: 2237
		[global::Cpp2ILInjected.Token(Token = "0x20004C5")]
		public class Offset : GenAction
		{
			// Token: 0x06004B87 RID: 19335 RVA: 0x0002F62A File Offset: 0x0002D82A
			[global::Cpp2ILInjected.Token(Token = "0x6003015")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F84B0", Offset = "0x12F84B0", Length = "0x34")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Offset(int x, int y)
			{
				throw null;
			}

			// Token: 0x06004B88 RID: 19336 RVA: 0x0002F62D File Offset: 0x0002D82D
			[global::Cpp2ILInjected.Token(Token = "0x6003016")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F84E4", Offset = "0x12F84E4", Length = "0x10")]
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

			// Token: 0x040080A0 RID: 32928
			[global::Cpp2ILInjected.Token(Token = "0x40039BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _xOffset;

			// Token: 0x040080A1 RID: 32929
			[global::Cpp2ILInjected.Token(Token = "0x40039C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _yOffset;
		}

		// Token: 0x020008BE RID: 2238
		[global::Cpp2ILInjected.Token(Token = "0x20004C6")]
		public class Dither : GenAction
		{
			// Token: 0x06004B89 RID: 19337 RVA: 0x0002F630 File Offset: 0x0002D830
			[global::Cpp2ILInjected.Token(Token = "0x6003017")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F84F4", Offset = "0x12F84F4", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Dither(double failureChance = 0.5)
			{
				throw null;
			}

			// Token: 0x06004B8A RID: 19338 RVA: 0x0002F633 File Offset: 0x0002D833
			[global::Cpp2ILInjected.Token(Token = "0x6003018")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F8524", Offset = "0x12F8524", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
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

			// Token: 0x040080A2 RID: 32930
			[global::Cpp2ILInjected.Token(Token = "0x40039C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private double _failureChance;
		}

		// Token: 0x020008BF RID: 2239
		[global::Cpp2ILInjected.Token(Token = "0x20004C7")]
		public class Flip : GenAction
		{
			// Token: 0x06004B8B RID: 19339 RVA: 0x0002F636 File Offset: 0x0002D836
			[global::Cpp2ILInjected.Token(Token = "0x6003019")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F85A8", Offset = "0x12F85A8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Flip(bool flipX, bool flipY)
			{
				throw null;
			}

			// Token: 0x06004B8C RID: 19340 RVA: 0x0002F639 File Offset: 0x0002D839
			[global::Cpp2ILInjected.Token(Token = "0x600301A")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F85E0", Offset = "0x12F85E0", Length = "0x30")]
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

			// Token: 0x040080A3 RID: 32931
			[global::Cpp2ILInjected.Token(Token = "0x40039C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			private bool _flipX;

			// Token: 0x040080A4 RID: 32932
			[global::Cpp2ILInjected.Token(Token = "0x40039C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
			private bool _flipY;
		}
	}
}
