using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.GameContent.Biomes.Desert;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004DA")]
	public static class Shapes
	{
		[global::Cpp2ILInjected.Token(Token = "0x20004DB")]
		public class Circle : GenShape
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6003045")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9BF4", Offset = "0x12F9BF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetRadius(int radius)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40039DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _verticalRadius;

			[global::Cpp2ILInjected.Token(Token = "0x40039DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _horizontalRadius;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20004DC")]
		public class HalfCircle : GenShape
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003047")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9DA4", Offset = "0x12F9DA4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HalfCircle(int radius)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40039DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _radius;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20004DD")]
		public class Slime : GenShape
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x40039DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _radius;

			[global::Cpp2ILInjected.Token(Token = "0x40039DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private double _xScale;

			[global::Cpp2ILInjected.Token(Token = "0x40039E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private double _yScale;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20004DE")]
		public class Rectangle : GenShape
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600304D")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA2FC", Offset = "0x12FA2FC", Length = "0x58")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceEmptyRooms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceStairs", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceDoors", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlacePlatforms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceSupportBeams", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "GetRoomSolidPrecentage", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Rectangle) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "GetHouseType", MemberParameters = new object[] { typeof(IEnumerable<Microsoft.Xna.Framework.Rectangle>) }, ReturnType = typeof(HouseType))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "RainbowifyOnTenthAnniversaryWorlds", ReturnType = typeof(void))]
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

			[global::Cpp2ILInjected.Token(Token = "0x600304E")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FA354", Offset = "0x12FA354", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetArea(Microsoft.Xna.Framework.Rectangle area)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40039E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private Microsoft.Xna.Framework.Rectangle _area;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20004DF")]
		public class Tail : GenShape
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x40039E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private double _width;

			[global::Cpp2ILInjected.Token(Token = "0x40039E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Vector2D _endOffset;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20004E0")]
			private sealed class <>c__DisplayClass3_0
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003052")]
				[global::Cpp2ILInjected.Address(RVA = "0x12FA6D4", Offset = "0x12FA6D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass3_0()
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40039E4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Shapes.Tail <>4__this;

				[global::Cpp2ILInjected.Token(Token = "0x40039E5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				public GenAction action;

				[global::Cpp2ILInjected.Token(Token = "0x40039E6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				public Point origin;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20004E1")]
		public class Mound : GenShape
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x40039E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _halfWidth;

			[global::Cpp2ILInjected.Token(Token = "0x40039E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _height;
		}
	}
}
