using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent;
using Terraria.Localization;

namespace Terraria.DataStructures
{
	// Token: 0x02000441 RID: 1089
	[global::Cpp2ILInjected.Token(Token = "0x200063C")]
	public class PlayerDeathReason
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x0002ACC8 File Offset: 0x00028EC8
		[global::Cpp2ILInjected.Token(Token = "0x170006A1")]
		public int? SourceProjectileType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600364F")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DDB8C", Offset = "0x13DDB8C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
			{
				typeof(PlayerDeathReason),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x0002ACCB File Offset: 0x00028ECB
		[global::Cpp2ILInjected.Token(Token = "0x6003650")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDBFC", Offset = "0x13DDBFC", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "AllowShimmerDodge", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public bool TryGetCausingEntity(out Entity entity)
		{
			throw null;
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x0002ACCE File Offset: 0x00028ECE
		[global::Cpp2ILInjected.Token(Token = "0x6003651")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDDD0", Offset = "0x13DDDD0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBuffs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PlayerDeathReason LegacyEmpty()
		{
			throw null;
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x0002ACD1 File Offset: 0x00028ED1
		[global::Cpp2ILInjected.Token(Token = "0x6003652")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDE44", Offset = "0x13DDE44", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "WOFTongue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PlayerDeathReason LegacyDefault()
		{
			throw null;
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x0002ACD4 File Offset: 0x00028ED4
		[global::Cpp2ILInjected.Token(Token = "0x6003653")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDEA8", Offset = "0x13DDEA8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update_NPCCollision", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TakeDamageFromJellyfish", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_CatchCritters", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PlayerDeathReason ByNPC(int index)
		{
			throw null;
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x0002ACD7 File Offset: 0x00028ED7
		[global::Cpp2ILInjected.Token(Token = "0x6003654")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDF0C", Offset = "0x13DDF0C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PlayerDeathReason ByCustomReason(string reasonInEnglish)
		{
			throw null;
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x0002ACDA File Offset: 0x00028EDA
		[global::Cpp2ILInjected.Token(Token = "0x6003655")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDF70", Offset = "0x13DDF70", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_MeleeHitPVP", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static PlayerDeathReason ByPlayer(int index)
		{
			throw null;
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x0002ACDD File Offset: 0x00028EDD
		[global::Cpp2ILInjected.Token(Token = "0x6003656")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DE034", Offset = "0x13DE034", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBuffs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateLifeRegen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "WOFTongue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CheckDrowning", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "BordersMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyTouchDamage", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseTeleportRod", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseMiningTools_ActuallyUseMiningTool", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_067_FreakingPirates", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UseDrill", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "Update", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PlayerDeathReason ByOther(int type)
		{
			throw null;
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x0002ACE0 File Offset: 0x00028EE0
		[global::Cpp2ILInjected.Token(Token = "0x6003657")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DE098", Offset = "0x13DE098", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "BombsHurtPlayers", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static PlayerDeathReason ByProjectile(int playerIndex, int projectileIndex)
		{
			throw null;
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x0002ACE3 File Offset: 0x00028EE3
		[global::Cpp2ILInjected.Token(Token = "0x6003658")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DE194", Offset = "0x13DE194", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "KillMe", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(double),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromLiteral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDeathMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public NetworkText GetDeathText(string deadPlayerName)
		{
			throw null;
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x0002ACE6 File Offset: 0x00028EE6
		[global::Cpp2ILInjected.Token(Token = "0x6003659")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DE26C", Offset = "0x13DE26C", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(BitsByte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public void WriteSelfTo(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x0002ACE9 File Offset: 0x00028EE9
		[global::Cpp2ILInjected.Token(Token = "0x600365A")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DE4E4", Offset = "0x13DE4E4", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(BitsByte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PlayerDeathReason FromReader(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x0002ACEC File Offset: 0x00028EEC
		[global::Cpp2ILInjected.Token(Token = "0x600365B")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDE34", Offset = "0x13DDE34", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlayerDeathReason()
		{
			throw null;
		}

		// Token: 0x0400631D RID: 25373
		[global::Cpp2ILInjected.Token(Token = "0x4007707")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _sourcePlayerIndex;

		// Token: 0x0400631E RID: 25374
		[global::Cpp2ILInjected.Token(Token = "0x4007708")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _sourceNPCIndex;

		// Token: 0x0400631F RID: 25375
		[global::Cpp2ILInjected.Token(Token = "0x4007709")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _sourceProjectileLocalIndex;

		// Token: 0x04006320 RID: 25376
		[global::Cpp2ILInjected.Token(Token = "0x400770A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _sourceOtherIndex;

		// Token: 0x04006321 RID: 25377
		[global::Cpp2ILInjected.Token(Token = "0x400770B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _sourceProjectileType;

		// Token: 0x04006322 RID: 25378
		[global::Cpp2ILInjected.Token(Token = "0x400770C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _sourceItemType;

		// Token: 0x04006323 RID: 25379
		[global::Cpp2ILInjected.Token(Token = "0x400770D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _sourceItemPrefix;

		// Token: 0x04006324 RID: 25380
		[global::Cpp2ILInjected.Token(Token = "0x400770E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _sourceCustomReason;
	}
}
