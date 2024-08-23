using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Utilities
{
	// Token: 0x02000377 RID: 887
	[global::Cpp2ILInjected.Token(Token = "0x20004FD")]
	public static class NPCUtils
	{
		// Token: 0x06002CDB RID: 11483 RVA: 0x0002A0B6 File Offset: 0x000282B6
		[global::Cpp2ILInjected.Token(Token = "0x60030F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1302294", Offset = "0x1302294", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils), Member = "SearchForTarget", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(Vector2),
			typeof(NPCUtils.TargetSearchFlag),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(NPCUtils.TargetSearchResults))]
		public static NPCUtils.TargetSearchResults SearchForTarget(Vector2 position, NPCUtils.TargetSearchFlag flags = NPCUtils.TargetSearchFlag.All, float maxPlayerDistance = -1f, int npcFilter = 0)
		{
			throw null;
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x0002A0B9 File Offset: 0x000282B9
		[global::Cpp2ILInjected.Token(Token = "0x60030F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1302800", Offset = "0x1302800", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestOldOnesInvasion", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(bool),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestNonBees", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(bool),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestDownwindFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(float),
			typeof(bool),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestBetsy", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(bool),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils), Member = "SearchForTarget", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(Vector2),
			typeof(NPCUtils.TargetSearchFlag),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(NPCUtils.TargetSearchResults))]
		public static NPCUtils.TargetSearchResults SearchForTarget(NPC searcher, NPCUtils.TargetSearchFlag flags = NPCUtils.TargetSearchFlag.All, float maxPlayerDistance = -1f, int npcFilter = 0)
		{
			throw null;
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x0002A0BC File Offset: 0x000282BC
		[global::Cpp2ILInjected.Token(Token = "0x60030F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x13022D0", Offset = "0x13022D0", Length = "0x530")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "SearchForTarget", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(NPCUtils.TargetSearchFlag),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(NPCUtils.TargetSearchResults))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "SearchForTarget", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(NPCUtils.TargetSearchFlag),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(NPCUtils.TargetSearchResults))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "CanBeChasedBy", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "CanHit", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static NPCUtils.TargetSearchResults SearchForTarget(NPC searcher, Vector2 position, NPCUtils.TargetSearchFlag flags = NPCUtils.TargetSearchFlag.All, float maxPlayerDistance = -1f, int npcFilter = 0)
		{
			throw null;
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x0002A0BF File Offset: 0x000282BF
		[global::Cpp2ILInjected.Token(Token = "0x60030F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x13028C0", Offset = "0x13028C0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_108_DivingFlyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_111_DD2LightningBug", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils), Member = "SearchForTarget", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(NPCUtils.TargetSearchFlag),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(NPCUtils.TargetSearchResults))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetHitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "ShouldFaceTarget", MemberParameters = new object[]
		{
			typeof(ref NPCUtils.TargetSearchResults),
			typeof(NPCUtils.TargetType?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "FaceTarget", ReturnType = typeof(void))]
		public static void TargetClosestOldOnesInvasion(NPC searcher, bool faceTarget = true, Vector2? checkPosition = null)
		{
			throw null;
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0002A0C2 File Offset: 0x000282C2
		[global::Cpp2ILInjected.Token(Token = "0x60030F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1302AB0", Offset = "0x1302AB0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_005_EaterOfSouls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils), Member = "SearchForTarget", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(NPCUtils.TargetSearchFlag),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(NPCUtils.TargetSearchResults))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetHitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "ShouldFaceTarget", MemberParameters = new object[]
		{
			typeof(ref NPCUtils.TargetSearchResults),
			typeof(NPCUtils.TargetType?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "FaceTarget", ReturnType = typeof(void))]
		public static void TargetClosestNonBees(NPC searcher, bool faceTarget = true, Vector2? checkPosition = null)
		{
			throw null;
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x0002A0C5 File Offset: 0x000282C5
		[global::Cpp2ILInjected.Token(Token = "0x60030F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1302B3C", Offset = "0x1302B3C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_119_Dandelion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils), Member = "SearchForTarget", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(NPCUtils.TargetSearchFlag),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(NPCUtils.TargetSearchResults))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetHitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "ShouldFaceTarget", MemberParameters = new object[]
		{
			typeof(ref NPCUtils.TargetSearchResults),
			typeof(NPCUtils.TargetType?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "FaceTarget", ReturnType = typeof(void))]
		public static void TargetClosestDownwindFromNPC(NPC searcher, float distanceMaxX, bool faceTarget = true, Vector2? checkPosition = null)
		{
			throw null;
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x0002A0C8 File Offset: 0x000282C8
		[global::Cpp2ILInjected.Token(Token = "0x60030F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1302BC4", Offset = "0x1302BC4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TargetClosest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public static void TargetClosestCommon(NPC searcher, bool faceTarget = true, Vector2? checkPosition = null)
		{
			throw null;
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x0002A0CB File Offset: 0x000282CB
		[global::Cpp2ILInjected.Token(Token = "0x60030F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1302BD0", Offset = "0x1302BD0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_110_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils), Member = "SearchForTarget", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(NPCUtils.TargetSearchFlag),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(NPCUtils.TargetSearchResults))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTankOwner", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetHitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "ShouldFaceTarget", MemberParameters = new object[]
		{
			typeof(ref NPCUtils.TargetSearchResults),
			typeof(NPCUtils.TargetType?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "FaceTarget", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void TargetClosestBetsy(NPC searcher, bool faceTarget = true, Vector2? checkPosition = null)
		{
			throw null;
		}

		// Token: 0x04003193 RID: 12691
		[global::Cpp2ILInjected.Token(Token = "0x4003AD7")]
		public const int NPCSearchFilter_OnlyCrystal = 1;

		// Token: 0x04003194 RID: 12692
		[global::Cpp2ILInjected.Token(Token = "0x4003AD8")]
		public const int NPCSearchFilter_NonBeeNPCs = 2;

		// Token: 0x04003195 RID: 12693
		[global::Cpp2ILInjected.Token(Token = "0x4003AD9")]
		public const int NPCSearchFilter_DownWind = 3;

		// Token: 0x020008D8 RID: 2264
		// (Invoke) Token: 0x06004BC6 RID: 19398
		[global::Cpp2ILInjected.Token(Token = "0x20004FE")]
		public delegate bool SearchFilter<T>(T entity) where T : Entity;

		// Token: 0x020008D9 RID: 2265
		// (Invoke) Token: 0x06004BCA RID: 19402
		[global::Cpp2ILInjected.Token(Token = "0x20004FF")]
		public delegate void NPCTargetingMethod(NPC searcher, bool faceTarget, Vector2? checkPosition);

		// Token: 0x020008DA RID: 2266
		[global::Cpp2ILInjected.Token(Token = "0x2000500")]
		public static class SearchFilters
		{
			// Token: 0x06004BCD RID: 19405 RVA: 0x0002F6E4 File Offset: 0x0002D8E4
			[global::Cpp2ILInjected.Token(Token = "0x6003101")]
			[global::Cpp2ILInjected.Address(RVA = "0x1302F74", Offset = "0x1302F74", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool OnlyCrystal(NPC npc)
			{
				throw null;
			}

			// Token: 0x06004BCE RID: 19406 RVA: 0x0002F6E7 File Offset: 0x0002D8E7
			[global::Cpp2ILInjected.Token(Token = "0x6003102")]
			[global::Cpp2ILInjected.Address(RVA = "0x1302F98", Offset = "0x1302F98", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.SearchFilter<>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public static NPCUtils.SearchFilter<Player> OnlyPlayersInCertainDistance(Vector2 position, float maxDistance)
			{
				throw null;
			}

			// Token: 0x06004BCF RID: 19407 RVA: 0x0002F6EA File Offset: 0x0002D8EA
			[global::Cpp2ILInjected.Token(Token = "0x6003103")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303064", Offset = "0x1303064", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "CanBeChasedBy", MemberParameters = new object[]
			{
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			public static bool NonBeeNPCs(NPC npc)
			{
				throw null;
			}

			// Token: 0x06004BD0 RID: 19408 RVA: 0x0002F6ED File Offset: 0x0002D8ED
			[global::Cpp2ILInjected.Token(Token = "0x6003104")]
			[global::Cpp2ILInjected.Address(RVA = "0x13030A0", Offset = "0x13030A0", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.SearchFilter<>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public static NPCUtils.SearchFilter<Player> DownwindFromNPC(NPC npc, float maxDistanceX)
			{
				throw null;
			}

			// Token: 0x02000B64 RID: 2916
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000501")]
			private sealed class <>c__DisplayClass1_0
			{
				// Token: 0x06005343 RID: 21315 RVA: 0x00030ABB File Offset: 0x0002ECBB
				[global::Cpp2ILInjected.Token(Token = "0x6003105")]
				[global::Cpp2ILInjected.Address(RVA = "0x130305C", Offset = "0x130305C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass1_0()
				{
					throw null;
				}

				// Token: 0x06005344 RID: 21316 RVA: 0x00030ABE File Offset: 0x0002ECBE
				[global::Cpp2ILInjected.Token(Token = "0x6003106")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303160", Offset = "0x1303160", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "Distance", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
				internal bool <OnlyPlayersInCertainDistance>b__0(Player player)
				{
					throw null;
				}

				// Token: 0x04009011 RID: 36881
				[global::Cpp2ILInjected.Token(Token = "0x4003ADA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Vector2 position;

				// Token: 0x04009012 RID: 36882
				[global::Cpp2ILInjected.Token(Token = "0x4003ADB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				public float maxDistance;
			}

			// Token: 0x02000B65 RID: 2917
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000502")]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x06005345 RID: 21317 RVA: 0x00030AC1 File Offset: 0x0002ECC1
				[global::Cpp2ILInjected.Token(Token = "0x6003107")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303158", Offset = "0x1303158", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass3_0()
				{
					throw null;
				}

				// Token: 0x06005346 RID: 21318 RVA: 0x00030AC4 File Offset: 0x0002ECC4
				[global::Cpp2ILInjected.Token(Token = "0x6003108")]
				[global::Cpp2ILInjected.Address(RVA = "0x130318C", Offset = "0x130318C", Length = "0x148")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				internal bool <DownwindFromNPC>b__0(Player player)
				{
					throw null;
				}

				// Token: 0x04009013 RID: 36883
				[global::Cpp2ILInjected.Token(Token = "0x4003ADC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public NPC npc;

				// Token: 0x04009014 RID: 36884
				[global::Cpp2ILInjected.Token(Token = "0x4003ADD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				public float maxDistanceX;
			}
		}

		// Token: 0x020008DB RID: 2267
		[global::Cpp2ILInjected.Token(Token = "0x2000503")]
		public enum TargetType
		{
			// Token: 0x040080EC RID: 33004
			[global::Cpp2ILInjected.Token(Token = "0x4003ADF")]
			None,
			// Token: 0x040080ED RID: 33005
			[global::Cpp2ILInjected.Token(Token = "0x4003AE0")]
			NPC,
			// Token: 0x040080EE RID: 33006
			[global::Cpp2ILInjected.Token(Token = "0x4003AE1")]
			Player,
			// Token: 0x040080EF RID: 33007
			[global::Cpp2ILInjected.Token(Token = "0x4003AE2")]
			TankPet
		}

		// Token: 0x020008DC RID: 2268
		[global::Cpp2ILInjected.Token(Token = "0x2000504")]
		public struct TargetSearchResults
		{
			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06004BD1 RID: 19409 RVA: 0x0002F6F0 File Offset: 0x0002D8F0
			[global::Cpp2ILInjected.Token(Token = "0x17000616")]
			public int NearestTargetIndex
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003109")]
				[global::Cpp2ILInjected.Address(RVA = "0x1302960", Offset = "0x1302960", Length = "0x40")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestOldOnesInvasion", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(bool),
					typeof(Vector2?)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestNonBees", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(bool),
					typeof(Vector2?)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestDownwindFromNPC", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(float),
					typeof(bool),
					typeof(Vector2?)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestBetsy", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(bool),
					typeof(Vector2?)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestNPC", ReturnType = typeof(NPC))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_WhoAmIToTargettingIndex", ReturnType = typeof(int))]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06004BD2 RID: 19410 RVA: 0x0002F6F3 File Offset: 0x0002D8F3
			[global::Cpp2ILInjected.Token(Token = "0x17000617")]
			public Rectangle NearestTargetHitbox
			{
				[global::Cpp2ILInjected.Token(Token = "0x600310A")]
				[global::Cpp2ILInjected.Address(RVA = "0x13029A0", Offset = "0x13029A0", Length = "0x110")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestOldOnesInvasion", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(bool),
					typeof(Vector2?)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestNonBees", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(bool),
					typeof(Vector2?)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestDownwindFromNPC", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(float),
					typeof(bool),
					typeof(Vector2?)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestBetsy", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(bool),
					typeof(Vector2?)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTankOwner", ReturnType = typeof(Player))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestNPC", ReturnType = typeof(NPC))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06004BD3 RID: 19411 RVA: 0x0002F6F6 File Offset: 0x0002D8F6
			[global::Cpp2ILInjected.Token(Token = "0x17000618")]
			public NPCUtils.TargetType NearestTargetType
			{
				[global::Cpp2ILInjected.Token(Token = "0x600310B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303350", Offset = "0x1303350", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x06004BD4 RID: 19412 RVA: 0x0002F6F9 File Offset: 0x0002D8F9
			[global::Cpp2ILInjected.Token(Token = "0x17000619")]
			public bool FoundTarget
			{
				[global::Cpp2ILInjected.Token(Token = "0x600310C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1302950", Offset = "0x1302950", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x0002F6FC File Offset: 0x0002D8FC
			[global::Cpp2ILInjected.Token(Token = "0x1700061A")]
			public NPC NearestNPC
			{
				[global::Cpp2ILInjected.Token(Token = "0x600310D")]
				[global::Cpp2ILInjected.Address(RVA = "0x13032D4", Offset = "0x13032D4", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetIndex", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetHitbox", ReturnType = typeof(Rectangle))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x0002F6FF File Offset: 0x0002D8FF
			[global::Cpp2ILInjected.Token(Token = "0x1700061B")]
			public bool FoundNPC
			{
				[global::Cpp2ILInjected.Token(Token = "0x600310E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303358", Offset = "0x1303358", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x0002F702 File Offset: 0x0002D902
			[global::Cpp2ILInjected.Token(Token = "0x1700061C")]
			public int NearestNPCIndex
			{
				[global::Cpp2ILInjected.Token(Token = "0x600310F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303368", Offset = "0x1303368", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x06004BD8 RID: 19416 RVA: 0x0002F705 File Offset: 0x0002D905
			[global::Cpp2ILInjected.Token(Token = "0x1700061D")]
			public float NearestNPCDistance
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003110")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303370", Offset = "0x1303370", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x06004BD9 RID: 19417 RVA: 0x0002F708 File Offset: 0x0002D908
			[global::Cpp2ILInjected.Token(Token = "0x1700061E")]
			public Player NearestTankOwner
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003111")]
				[global::Cpp2ILInjected.Address(RVA = "0x1302CD8", Offset = "0x1302CD8", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "ShouldFaceTarget", MemberParameters = new object[]
				{
					typeof(ref NPCUtils.TargetSearchResults),
					typeof(NPCUtils.TargetType?)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils.TargetSearchResults), Member = "get_NearestTargetHitbox", ReturnType = typeof(Rectangle))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "TargetClosestBetsy", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(bool),
					typeof(Vector2?)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x06004BDA RID: 19418 RVA: 0x0002F70B File Offset: 0x0002D90B
			[global::Cpp2ILInjected.Token(Token = "0x1700061F")]
			public bool FoundTank
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003112")]
				[global::Cpp2ILInjected.Address(RVA = "0x1302CC8", Offset = "0x1302CC8", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x06004BDB RID: 19419 RVA: 0x0002F70E File Offset: 0x0002D90E
			[global::Cpp2ILInjected.Token(Token = "0x17000620")]
			public int NearestTankOwnerIndex
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003113")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303378", Offset = "0x1303378", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x06004BDC RID: 19420 RVA: 0x0002F711 File Offset: 0x0002D911
			[global::Cpp2ILInjected.Token(Token = "0x17000621")]
			public float NearestTankDistance
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003114")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303380", Offset = "0x1303380", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x06004BDD RID: 19421 RVA: 0x0002F714 File Offset: 0x0002D914
			[global::Cpp2ILInjected.Token(Token = "0x17000622")]
			public float AdjustedTankDistance
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003115")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303388", Offset = "0x1303388", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x06004BDE RID: 19422 RVA: 0x0002F717 File Offset: 0x0002D917
			[global::Cpp2ILInjected.Token(Token = "0x17000623")]
			public NPCUtils.TargetType NearestTankType
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003116")]
				[global::Cpp2ILInjected.Address(RVA = "0x1303390", Offset = "0x1303390", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004BDF RID: 19423 RVA: 0x0002F71A File Offset: 0x0002D91A
			[global::Cpp2ILInjected.Token(Token = "0x6003117")]
			[global::Cpp2ILInjected.Address(RVA = "0x1302870", Offset = "0x1302870", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TargetSearchResults(NPC searcher, int nearestNPCIndex, float nearestNPCDistance, int nearestTankIndex, float nearestTankDistance, float adjustedTankDistance, NPCUtils.TargetType tankType)
			{
				throw null;
			}

			// Token: 0x040080F0 RID: 33008
			[global::Cpp2ILInjected.Token(Token = "0x4003AE3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private NPCUtils.TargetType _nearestTargetType;

			// Token: 0x040080F1 RID: 33009
			[global::Cpp2ILInjected.Token(Token = "0x4003AE4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			private int _nearestNPCIndex;

			// Token: 0x040080F2 RID: 33010
			[global::Cpp2ILInjected.Token(Token = "0x4003AE5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private float _nearestNPCDistance;

			// Token: 0x040080F3 RID: 33011
			[global::Cpp2ILInjected.Token(Token = "0x4003AE6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			private int _nearestTankIndex;

			// Token: 0x040080F4 RID: 33012
			[global::Cpp2ILInjected.Token(Token = "0x4003AE7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private float _nearestTankDistance;

			// Token: 0x040080F5 RID: 33013
			[global::Cpp2ILInjected.Token(Token = "0x4003AE8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private float _adjustedTankDistance;

			// Token: 0x040080F6 RID: 33014
			[global::Cpp2ILInjected.Token(Token = "0x4003AE9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private NPCUtils.TargetType _nearestTankType;
		}

		// Token: 0x020008DD RID: 2269
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000505")]
		public enum TargetSearchFlag
		{
			// Token: 0x040080F8 RID: 33016
			[global::Cpp2ILInjected.Token(Token = "0x4003AEB")]
			None = 0,
			// Token: 0x040080F9 RID: 33017
			[global::Cpp2ILInjected.Token(Token = "0x4003AEC")]
			NPCs = 1,
			// Token: 0x040080FA RID: 33018
			[global::Cpp2ILInjected.Token(Token = "0x4003AED")]
			Players = 2,
			// Token: 0x040080FB RID: 33019
			[global::Cpp2ILInjected.Token(Token = "0x4003AEE")]
			All = 3
		}
	}
}
