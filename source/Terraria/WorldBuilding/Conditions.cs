using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.GameContent.Events;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000358 RID: 856
	[global::Cpp2ILInjected.Token(Token = "0x20004A9")]
	public static class Conditions
	{
		// Token: 0x020008A4 RID: 2212
		[global::Cpp2ILInjected.Token(Token = "0x20004AA")]
		public class IsTile : GenCondition
		{
			// Token: 0x06004B4F RID: 19279 RVA: 0x0002F582 File Offset: 0x0002D782
			[global::Cpp2ILInjected.Token(Token = "0x6002FD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6068", Offset = "0x12F6068", Length = "0x30")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsTile(params ushort[] types)
			{
				throw null;
			}

			// Token: 0x06004B50 RID: 19280 RVA: 0x0002F585 File Offset: 0x0002D785
			[global::Cpp2ILInjected.Token(Token = "0x6002FD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6098", Offset = "0x12F6098", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			protected override bool CheckValidity(int x, int y)
			{
				throw null;
			}

			// Token: 0x04008080 RID: 32896
			[global::Cpp2ILInjected.Token(Token = "0x400399A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private ushort[] _types;
		}

		// Token: 0x020008A5 RID: 2213
		[global::Cpp2ILInjected.Token(Token = "0x20004AB")]
		public class Continue : GenCondition
		{
			// Token: 0x06004B51 RID: 19281 RVA: 0x0002F588 File Offset: 0x0002D788
			[global::Cpp2ILInjected.Token(Token = "0x6002FD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F61D4", Offset = "0x12F61D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected override bool CheckValidity(int x, int y)
			{
				throw null;
			}

			// Token: 0x06004B52 RID: 19282 RVA: 0x0002F58B File Offset: 0x0002D78B
			[global::Cpp2ILInjected.Token(Token = "0x6002FD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F61DC", Offset = "0x12F61DC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Continue()
			{
				throw null;
			}
		}

		// Token: 0x020008A6 RID: 2214
		[global::Cpp2ILInjected.Token(Token = "0x20004AC")]
		public class MysticSnake : GenCondition
		{
			// Token: 0x06004B53 RID: 19283 RVA: 0x0002F58E File Offset: 0x0002D78E
			[global::Cpp2ILInjected.Token(Token = "0x6002FD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F61EC", Offset = "0x12F61EC", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			protected override bool CheckValidity(int x, int y)
			{
				throw null;
			}

			// Token: 0x06004B54 RID: 19284 RVA: 0x0002F591 File Offset: 0x0002D791
			[global::Cpp2ILInjected.Token(Token = "0x6002FD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F638C", Offset = "0x12F638C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_Shoot", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MysticSnake()
			{
				throw null;
			}
		}

		// Token: 0x020008A7 RID: 2215
		[global::Cpp2ILInjected.Token(Token = "0x20004AD")]
		public class IsSolid : GenCondition
		{
			// Token: 0x06004B55 RID: 19285 RVA: 0x0002F594 File Offset: 0x0002D794
			[global::Cpp2ILInjected.Token(Token = "0x6002FDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F639C", Offset = "0x12F639C", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			protected override bool CheckValidity(int x, int y)
			{
				throw null;
			}

			// Token: 0x06004B56 RID: 19286 RVA: 0x0002F597 File Offset: 0x0002D797
			[global::Cpp2ILInjected.Token(Token = "0x6002FDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6518", Offset = "0x12F6518", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = ".cctor", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "CreateSupportBeamList", ReturnType = typeof(List<Rectangle>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "FindVerticalExit", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(bool),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "FindSideExit", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(bool),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateRooms", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(List<Rectangle>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "FindRoom", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "RaiseGoblins", MemberParameters = new object[]
			{
				typeof(NPC),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsSolid()
			{
				throw null;
			}
		}

		// Token: 0x020008A8 RID: 2216
		[global::Cpp2ILInjected.Token(Token = "0x20004AE")]
		public class HasLava : GenCondition
		{
			// Token: 0x06004B57 RID: 19287 RVA: 0x0002F59A File Offset: 0x0002D79A
			[global::Cpp2ILInjected.Token(Token = "0x6002FDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6528", Offset = "0x12F6528", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			protected override bool CheckValidity(int x, int y)
			{
				throw null;
			}

			// Token: 0x06004B58 RID: 19288 RVA: 0x0002F59D File Offset: 0x0002D79D
			[global::Cpp2ILInjected.Token(Token = "0x6002FDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6628", Offset = "0x12F6628", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "AreRoomsValid", MemberParameters = new object[]
			{
				typeof(IEnumerable<Rectangle>),
				typeof(StructureMap),
				typeof(HouseType)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HasLava()
			{
				throw null;
			}
		}

		// Token: 0x020008A9 RID: 2217
		[global::Cpp2ILInjected.Token(Token = "0x20004AF")]
		public class NotNull : GenCondition
		{
			// Token: 0x06004B59 RID: 19289 RVA: 0x0002F5A0 File Offset: 0x0002D7A0
			[global::Cpp2ILInjected.Token(Token = "0x6002FDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F6638", Offset = "0x12F6638", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			protected override bool CheckValidity(int x, int y)
			{
				throw null;
			}

			// Token: 0x06004B5A RID: 19290 RVA: 0x0002F5A3 File Offset: 0x0002D7A3
			[global::Cpp2ILInjected.Token(Token = "0x6002FDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F66AC", Offset = "0x12F66AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NotNull()
			{
				throw null;
			}
		}
	}
}
