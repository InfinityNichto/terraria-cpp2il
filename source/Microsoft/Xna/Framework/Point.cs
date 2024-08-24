using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.WorldBuilding;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200026B RID: 619
	[global::Cpp2ILInjected.Token(Token = "0x200032C")]
	[Serializable]
	public struct Point : IEquatable<Point>
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0002501F File Offset: 0x0002321F
		[global::Cpp2ILInjected.Token(Token = "0x170001DF")]
		public static Point Zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001323")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8D52C", Offset = "0xA8D52C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00025022 File Offset: 0x00023222
		[global::Cpp2ILInjected.Token(Token = "0x6001324")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D584", Offset = "0xA8D584", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 590)]
		public Point(int x, int y)
		{
			throw null;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00025025 File Offset: 0x00023225
		[global::Cpp2ILInjected.Token(Token = "0x6001325")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D58C", Offset = "0xA8D58C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PostDrawMenu", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_FindGoodRestingSpot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TryForcingSitting", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "ReduceRemainingChumsInPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldUtils), Member = "Find", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenSearch),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnchoredEntitiesCollection), Member = "GetEntitiesInCoords", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownRoomManager), Member = "AddOccupantsToList", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(List<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceCurvedLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Point),
			"Terraria.GameContent.Biomes.DunesBiome.DunesDescription"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateRooms", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(List<Rectangle>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		public static bool operator ==(Point a, Point b)
		{
			throw null;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00025028 File Offset: 0x00023228
		[global::Cpp2ILInjected.Token(Token = "0x6001326")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D5D4", Offset = "0xA8D5D4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "UpdateUINavigation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_FindGoodRestingSpot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ModifyFlexibleWandPlacementInfo", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static bool operator !=(Point a, Point b)
		{
			throw null;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0002502B File Offset: 0x0002322B
		[global::Cpp2ILInjected.Token(Token = "0x6001327")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D5AC", Offset = "0xA8D5AC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Point other)
		{
			throw null;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0002502E File Offset: 0x0002322E
		[global::Cpp2ILInjected.Token(Token = "0x6001328")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D5F4", Offset = "0xA8D5F4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00025031 File Offset: 0x00023231
		[global::Cpp2ILInjected.Token(Token = "0x6001329")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D67C", Offset = "0xA8D67C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00025034 File Offset: 0x00023234
		[global::Cpp2ILInjected.Token(Token = "0x600132A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D688", Offset = "0xA8D688", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00025037 File Offset: 0x00023237
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600132B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D728", Offset = "0xA8D728", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		static Point()
		{
			throw null;
		}

		// Token: 0x04001C8B RID: 7307
		[global::Cpp2ILInjected.Token(Token = "0x4002265")]
		private static Point zeroPoint;

		// Token: 0x04001C8C RID: 7308
		[global::Cpp2ILInjected.Token(Token = "0x4002266")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int X;

		// Token: 0x04001C8D RID: 7309
		[global::Cpp2ILInjected.Token(Token = "0x4002267")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int Y;
	}
}
