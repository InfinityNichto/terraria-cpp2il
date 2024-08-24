using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Enums;

namespace Terraria.DataStructures
{
	// Token: 0x0200043C RID: 1084
	[global::Cpp2ILInjected.Token(Token = "0x2000637")]
	public struct NPCAimedTarget
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x0002AC71 File Offset: 0x00028E71
		[global::Cpp2ILInjected.Token(Token = "0x1700069B")]
		public bool Invalid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003632")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DCF88", Offset = "0x13DCF88", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_125_ClumsySlimeBalloon", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops_TryMakingSpike_FindBestY", MemberParameters = new object[]
			{
				typeof(ref Point),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_122_PirateGhost", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_065_Butterflies", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_120_HallowBoss", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_113_WindyBalloon", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x0002AC74 File Offset: 0x00028E74
		[global::Cpp2ILInjected.Token(Token = "0x1700069C")]
		public Vector2 Center
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003633")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DCF98", Offset = "0x13DCF98", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_125_ClumsySlimeBalloon", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops_ShootRubbleUp", MemberParameters = new object[]
			{
				typeof(ref NPCAimedTarget),
				typeof(ref Point),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_124_DeerclopsLeg", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_122_PirateGhost", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_065_Butterflies", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_120_HallowBoss", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_117_BloodNautilus", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_113_WindyBalloon", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_112_FairyCritter", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_005_EaterOfSouls", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_110_Betsy", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_108_DivingFlyer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_111_DD2LightningBug", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "Collision_WaterCollision", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 111)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x0002AC77 File Offset: 0x00028E77
		[global::Cpp2ILInjected.Token(Token = "0x1700069D")]
		public Vector2 Size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003634")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DD050", Offset = "0x13DD050", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0002AC7A File Offset: 0x00028E7A
		[global::Cpp2ILInjected.Token(Token = "0x6003635")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD07C", Offset = "0x13DD07C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetTargetData", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(NPCAimedTarget))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		public NPCAimedTarget(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x0002AC7D File Offset: 0x00028E7D
		[global::Cpp2ILInjected.Token(Token = "0x6003636")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD0CC", Offset = "0x13DD0CC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetTargetData", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(NPCAimedTarget))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NPCAimedTarget(Player player, bool ignoreTank = true)
		{
			throw null;
		}

		// Token: 0x04006308 RID: 25352
		[global::Cpp2ILInjected.Token(Token = "0x40076F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public NPCTargetType Type;

		// Token: 0x04006309 RID: 25353
		[global::Cpp2ILInjected.Token(Token = "0x40076F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public Rectangle Hitbox;

		// Token: 0x0400630A RID: 25354
		[global::Cpp2ILInjected.Token(Token = "0x40076F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int Width;

		// Token: 0x0400630B RID: 25355
		[global::Cpp2ILInjected.Token(Token = "0x40076F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int Height;

		// Token: 0x0400630C RID: 25356
		[global::Cpp2ILInjected.Token(Token = "0x40076F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Vector2 Position;

		// Token: 0x0400630D RID: 25357
		[global::Cpp2ILInjected.Token(Token = "0x40076F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public Vector2 Velocity;
	}
}
