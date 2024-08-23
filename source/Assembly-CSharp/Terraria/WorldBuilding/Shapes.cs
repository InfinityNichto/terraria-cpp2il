using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.Desert;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000363 RID: 867
	[global::Cpp2ILInjected.Token(Token = "0x20004DA")]
	public static class Shapes
	{
		// Token: 0x020008CA RID: 2250
		[global::Cpp2ILInjected.Token(Token = "0x20004DB")]
		public class Circle : GenShape
		{
			// Token: 0x06004BA4 RID: 19364 RVA: 0x0002F681 File Offset: 0x0002D881
			[global::Cpp2ILInjected.Token(Token = "0x6003043")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9BA0", Offset = "0x12F9BA0", Length = "0x28")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThinIceBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Circle(int radius)
			{
				throw null;
			}

			// Token: 0x06004BA5 RID: 19365 RVA: 0x0002F684 File Offset: 0x0002D884
			[global::Cpp2ILInjected.Token(Token = "0x6003044")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9BC8", Offset = "0x12F9BC8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HoneyPatchBiome), Member = "Place", MemberParameters = new object[]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Circle(int horizontalRadius, int verticalRadius)
			{
				throw null;
			}

			// Token: 0x06004BA6 RID: 19366 RVA: 0x0002F687 File Offset: 0x0002D887
			[global::Cpp2ILInjected.Token(Token = "0x6003045")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9BF4", Offset = "0x12F9BF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetRadius(int radius)
			{
				throw null;
			}

			// Token: 0x06004BA7 RID: 19367 RVA: 0x0002F68A File Offset: 0x0002D88A
			[global::Cpp2ILInjected.Token(Token = "0x6003046")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9BFC", Offset = "0x12F9BFC", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(GenAction),
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override bool Perform(Point origin, GenAction action)
			{
				throw null;
			}

			// Token: 0x040080B2 RID: 32946
			[global::Cpp2ILInjected.Token(Token = "0x40039DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _verticalRadius;

			// Token: 0x040080B3 RID: 32947
			[global::Cpp2ILInjected.Token(Token = "0x40039DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _horizontalRadius;
		}

		// Token: 0x020008CB RID: 2251
		[global::Cpp2ILInjected.Token(Token = "0x20004DC")]
		public class HalfCircle : GenShape
		{
			// Token: 0x06004BA8 RID: 19368 RVA: 0x0002F68D File Offset: 0x0002D88D
			[global::Cpp2ILInjected.Token(Token = "0x6003047")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9DA4", Offset = "0x12F9DA4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HalfCircle(int radius)
			{
				throw null;
			}

			// Token: 0x06004BA9 RID: 19369 RVA: 0x0002F690 File Offset: 0x0002D890
			[global::Cpp2ILInjected.Token(Token = "0x6003048")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9DCC", Offset = "0x12F9DCC", Length = "0x178")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(GenAction),
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override bool Perform(Point origin, GenAction action)
			{
				throw null;
			}

			// Token: 0x040080B4 RID: 32948
			[global::Cpp2ILInjected.Token(Token = "0x40039DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _radius;
		}

		// Token: 0x020008CC RID: 2252
		[global::Cpp2ILInjected.Token(Token = "0x20004DD")]
		public class Slime : GenShape
		{
			// Token: 0x06004BAA RID: 19370 RVA: 0x0002F693 File Offset: 0x0002D893
			[global::Cpp2ILInjected.Token(Token = "0x6003049")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9F44", Offset = "0x12F9F44", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Slime(int radius)
			{
				throw null;
			}

			// Token: 0x06004BAB RID: 19371 RVA: 0x0002F696 File Offset: 0x0002D896
			[global::Cpp2ILInjected.Token(Token = "0x600304A")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9F74", Offset = "0x12F9F74", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Slime(int radius, double xScale, double yScale)
			{
				throw null;
			}

			// Token: 0x06004BAC RID: 19372 RVA: 0x0002F699 File Offset: 0x0002D899
			[global::Cpp2ILInjected.Token(Token = "0x600304B")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9FB0", Offset = "0x12F9FB0", Length = "0x31C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(GenAction),
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public override bool Perform(Point origin, GenAction action)
			{
				throw null;
			}

			// Token: 0x040080B5 RID: 32949
			[global::Cpp2ILInjected.Token(Token = "0x40039DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _radius;

			// Token: 0x040080B6 RID: 32950
			[global::Cpp2ILInjected.Token(Token = "0x40039DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private double _xScale;

			// Token: 0x040080B7 RID: 32951
			[global::Cpp2ILInjected.Token(Token = "0x40039E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private double _yScale;
		}

		// Token: 0x020008CD RID: 2253
		[global::Cpp2ILInjected.Token(Token = "0x20004DE")]
		public class Rectangle : GenShape
		{
			// Token: 0x06004BAD RID: 19373 RVA: 0x0002F69C File Offset: 0x0002D89C
			[global::Cpp2ILInjected.Token(Token = "0x600304C")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA2CC", Offset = "0x12FA2CC", Length = "0x30")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Rectangle(Microsoft.Xna.Framework.Rectangle area)
			{
				throw null;
			}

			// Token: 0x06004BAE RID: 19374 RVA: 0x0002F69F File Offset: 0x0002D89F
			[global::Cpp2ILInjected.Token(Token = "0x600304D")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA2FC", Offset = "0x12FA2FC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 49)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			public Rectangle(int width, int height)
			{
				throw null;
			}

			// Token: 0x06004BAF RID: 19375 RVA: 0x0002F6A2 File Offset: 0x0002D8A2
			[global::Cpp2ILInjected.Token(Token = "0x600304E")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA354", Offset = "0x12FA354", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetArea(Microsoft.Xna.Framework.Rectangle area)
			{
				throw null;
			}

			// Token: 0x06004BB0 RID: 19376 RVA: 0x0002F6A5 File Offset: 0x0002D8A5
			[global::Cpp2ILInjected.Token(Token = "0x600304F")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA360", Offset = "0x12FA360", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Rectangle), Member = "get_Right", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(GenAction),
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override bool Perform(Point origin, GenAction action)
			{
				throw null;
			}

			// Token: 0x040080B8 RID: 32952
			[global::Cpp2ILInjected.Token(Token = "0x40039E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private Microsoft.Xna.Framework.Rectangle _area;
		}

		// Token: 0x020008CE RID: 2254
		[global::Cpp2ILInjected.Token(Token = "0x20004DF")]
		public class Tail : GenShape
		{
			// Token: 0x06004BB1 RID: 19377 RVA: 0x0002F6A8 File Offset: 0x0002D8A8
			[global::Cpp2ILInjected.Token(Token = "0x6003050")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA49C", Offset = "0x12FA49C", Length = "0x9C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2D),
				typeof(double)
			}, ReturnType = typeof(Vector2D))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Tail(double width, Vector2D endOffset)
			{
				throw null;
			}

			// Token: 0x06004BB2 RID: 19378 RVA: 0x0002F6AB File Offset: 0x0002D8AB
			[global::Cpp2ILInjected.Token(Token = "0x6003051")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA538", Offset = "0x12FA538", Length = "0x19C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2D),
				typeof(Vector2D)
			}, ReturnType = typeof(Vector2D))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils.TileActionAttempt), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotTileTale", MemberParameters = new object[]
			{
				typeof(Vector2D),
				typeof(Vector2D),
				typeof(double),
				typeof(Utils.TileActionAttempt)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public override bool Perform(Point origin, GenAction action)
			{
				throw null;
			}

			// Token: 0x040080B9 RID: 32953
			[global::Cpp2ILInjected.Token(Token = "0x40039E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private double _width;

			// Token: 0x040080BA RID: 32954
			[global::Cpp2ILInjected.Token(Token = "0x40039E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Vector2D _endOffset;

			// Token: 0x02000B63 RID: 2915
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20004E0")]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x06005341 RID: 21313 RVA: 0x00030AB5 File Offset: 0x0002ECB5
				[global::Cpp2ILInjected.Token(Token = "0x6003052")]
				[global::Cpp2ILInjected.Address(RVA = "0x12FA6D4", Offset = "0x12FA6D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass3_0()
				{
					throw null;
				}

				// Token: 0x06005342 RID: 21314 RVA: 0x00030AB8 File Offset: 0x0002ECB8
				[global::Cpp2ILInjected.Token(Token = "0x6003053")]
				[global::Cpp2ILInjected.Address(RVA = "0x12FA6DC", Offset = "0x12FA6DC", Length = "0xD4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
				{
					typeof(GenAction),
					typeof(Point),
					typeof(int),
					typeof(int),
					typeof(object[])
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				internal bool <Perform>b__0(int x, int y)
				{
					throw null;
				}

				// Token: 0x0400900E RID: 36878
				[global::Cpp2ILInjected.Token(Token = "0x40039E4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Shapes.Tail <>4__this;

				// Token: 0x0400900F RID: 36879
				[global::Cpp2ILInjected.Token(Token = "0x40039E5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				public GenAction action;

				// Token: 0x04009010 RID: 36880
				[global::Cpp2ILInjected.Token(Token = "0x40039E6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				public Point origin;
			}
		}

		// Token: 0x020008CF RID: 2255
		[global::Cpp2ILInjected.Token(Token = "0x20004E1")]
		public class Mound : GenShape
		{
			// Token: 0x06004BB3 RID: 19379 RVA: 0x0002F6AE File Offset: 0x0002D8AE
			[global::Cpp2ILInjected.Token(Token = "0x6003054")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA7B0", Offset = "0x12FA7B0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Mound(int halfWidth, int height)
			{
				throw null;
			}

			// Token: 0x06004BB4 RID: 19380 RVA: 0x0002F6B1 File Offset: 0x0002D8B1
			[global::Cpp2ILInjected.Token(Token = "0x6003055")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA7DC", Offset = "0x12FA7DC", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(GenAction),
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override bool Perform(Point origin, GenAction action)
			{
				throw null;
			}

			// Token: 0x040080BB RID: 32955
			[global::Cpp2ILInjected.Token(Token = "0x40039E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _halfWidth;

			// Token: 0x040080BC RID: 32956
			[global::Cpp2ILInjected.Token(Token = "0x40039E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _height;
		}
	}
}
