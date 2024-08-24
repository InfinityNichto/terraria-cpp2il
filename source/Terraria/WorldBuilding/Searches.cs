using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.GameContent.Events;
using Terraria.ID;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000360 RID: 864
	[global::Cpp2ILInjected.Token(Token = "0x20004D2")]
	public static class Searches
	{
		// Token: 0x06002C49 RID: 11337 RVA: 0x00029F06 File Offset: 0x00028106
		[global::Cpp2ILInjected.Token(Token = "0x6003032")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F94D4", Offset = "0x12F94D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		public static GenSearch Chain(GenSearch search, params GenCondition[] conditions)
		{
			throw null;
		}

		// Token: 0x020008C5 RID: 2245
		[global::Cpp2ILInjected.Token(Token = "0x20004D3")]
		public class Left : GenSearch
		{
			// Token: 0x06004B9A RID: 19354 RVA: 0x0002F663 File Offset: 0x0002D863
			[global::Cpp2ILInjected.Token(Token = "0x6003033")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F94DC", Offset = "0x12F94DC", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "FindVerticalExit", MemberParameters = new object[]
			{
				typeof(Microsoft.Xna.Framework.Rectangle),
				typeof(bool),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "FindRoom", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Microsoft.Xna.Framework.Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Left(int maxDistance)
			{
				throw null;
			}

			// Token: 0x06004B9B RID: 19355 RVA: 0x0002F666 File Offset: 0x0002D866
			[global::Cpp2ILInjected.Token(Token = "0x6003034")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9550", Offset = "0x12F9550", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenSearch), Member = "Check", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Point Find(Point origin)
			{
				throw null;
			}

			// Token: 0x040080AC RID: 32940
			[global::Cpp2ILInjected.Token(Token = "0x40039D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _maxDistance;
		}

		// Token: 0x020008C6 RID: 2246
		[global::Cpp2ILInjected.Token(Token = "0x20004D4")]
		public class Right : GenSearch
		{
			// Token: 0x06004B9C RID: 19356 RVA: 0x0002F669 File Offset: 0x0002D869
			[global::Cpp2ILInjected.Token(Token = "0x6003035")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9618", Offset = "0x12F9618", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(StructureMap)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "FindRoom", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Microsoft.Xna.Framework.Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Right(int maxDistance)
			{
				throw null;
			}

			// Token: 0x06004B9D RID: 19357 RVA: 0x0002F66C File Offset: 0x0002D86C
			[global::Cpp2ILInjected.Token(Token = "0x6003036")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F968C", Offset = "0x12F968C", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenSearch), Member = "Check", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Point Find(Point origin)
			{
				throw null;
			}

			// Token: 0x040080AD RID: 32941
			[global::Cpp2ILInjected.Token(Token = "0x40039D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _maxDistance;
		}

		// Token: 0x020008C7 RID: 2247
		[global::Cpp2ILInjected.Token(Token = "0x20004D5")]
		public class Down : GenSearch
		{
			// Token: 0x06004B9E RID: 19358 RVA: 0x0002F66F File Offset: 0x0002D86F
			[global::Cpp2ILInjected.Token(Token = "0x6003037")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F975C", Offset = "0x12F975C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_Shoot", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_137_LightningAura", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_140_MonkStaffT1", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "CreateSupportBeamList", ReturnType = typeof(List<Microsoft.Xna.Framework.Rectangle>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateRooms", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(List<Microsoft.Xna.Framework.Rectangle>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "RaiseGoblins", MemberParameters = new object[]
			{
				typeof(NPC),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Down(int maxDistance)
			{
				throw null;
			}

			// Token: 0x06004B9F RID: 19359 RVA: 0x0002F672 File Offset: 0x0002D872
			[global::Cpp2ILInjected.Token(Token = "0x6003038")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F97D0", Offset = "0x12F97D0", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenSearch), Member = "Check", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override Point Find(Point origin)
			{
				throw null;
			}

			// Token: 0x040080AE RID: 32942
			[global::Cpp2ILInjected.Token(Token = "0x40039D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _maxDistance;
		}

		// Token: 0x020008C8 RID: 2248
		[global::Cpp2ILInjected.Token(Token = "0x20004D6")]
		public class Up : GenSearch
		{
			// Token: 0x06004BA0 RID: 19360 RVA: 0x0002F675 File Offset: 0x0002D875
			[global::Cpp2ILInjected.Token(Token = "0x6003039")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F98D4", Offset = "0x12F98D4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_137_LightningAura", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "FindSideExit", MemberParameters = new object[]
			{
				typeof(Microsoft.Xna.Framework.Rectangle),
				typeof(bool),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "FindRoom", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Microsoft.Xna.Framework.Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Up(int maxDistance)
			{
				throw null;
			}

			// Token: 0x06004BA1 RID: 19361 RVA: 0x0002F678 File Offset: 0x0002D878
			[global::Cpp2ILInjected.Token(Token = "0x600303A")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9948", Offset = "0x12F9948", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenSearch), Member = "Check", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Point Find(Point origin)
			{
				throw null;
			}

			// Token: 0x040080AF RID: 32943
			[global::Cpp2ILInjected.Token(Token = "0x40039D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _maxDistance;
		}

		// Token: 0x020008C9 RID: 2249
		[global::Cpp2ILInjected.Token(Token = "0x20004D7")]
		public class Rectangle : GenSearch
		{
			// Token: 0x06004BA2 RID: 19362 RVA: 0x0002F67B File Offset: 0x0002D87B
			[global::Cpp2ILInjected.Token(Token = "0x600303B")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9A10", Offset = "0x12F9A10", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "AreRoomsValid", MemberParameters = new object[]
			{
				typeof(IEnumerable<Microsoft.Xna.Framework.Rectangle>),
				typeof(StructureMap),
				typeof(HouseType)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Rectangle(int width, int height)
			{
				throw null;
			}

			// Token: 0x06004BA3 RID: 19363 RVA: 0x0002F67E File Offset: 0x0002D87E
			[global::Cpp2ILInjected.Token(Token = "0x600303C")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9A88", Offset = "0x12F9A88", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenSearch), Member = "Check", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Point Find(Point origin)
			{
				throw null;
			}

			// Token: 0x040080B0 RID: 32944
			[global::Cpp2ILInjected.Token(Token = "0x40039D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _width;

			// Token: 0x040080B1 RID: 32945
			[global::Cpp2ILInjected.Token(Token = "0x40039D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _height;
		}
	}
}
