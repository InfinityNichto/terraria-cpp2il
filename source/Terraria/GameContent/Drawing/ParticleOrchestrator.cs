using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.GameContent.NetModules;
using Terraria.Graphics.Renderers;
using Terraria.Graphics.Shaders;
using Terraria.Net;
using Terraria.Utilities;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000666 RID: 1638
	[global::Cpp2ILInjected.Token(Token = "0x20009E5")]
	public class ParticleOrchestrator
	{
		// Token: 0x0600401E RID: 16414 RVA: 0x0002D737 File Offset: 0x0002B937
		[global::Cpp2ILInjected.Token(Token = "0x6004A9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x85D9D0", Offset = "0x85D9D0", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "UpdateNPC_BuffApplyVFX", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TrySwitchingLoadout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DoBootsEffect_PlaceFlamesOnTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryToPoop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "MakeFloorDust", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ProcessHitAgainstNPC", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_ApplyUseStyle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Item),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "EmitBlackLightningParticles", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_186_PrincessWeapon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_165_Whip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_043", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_092", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateFrame", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetParticlesModule), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerAndSelf", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void RequestParticleSpawn(bool clientOnly, ParticleOrchestraType type, ParticleOrchestraSettings settings, int? overrideInvokingPlayerIndex = null)
		{
			throw null;
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x0002D73A File Offset: 0x0002B93A
		[global::Cpp2ILInjected.Token(Token = "0x6004A9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E3B4", Offset = "0x85E3B4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "TransformElderSlime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "TransformCopperSlime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities_Shimmer_TeleportToLandingSpot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "ViolentlySpawnNerdySlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "RerollVariation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetParticlesModule), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "BroadcastOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void BroadcastParticleSpawn(ParticleOrchestraType type, ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x0002D73D File Offset: 0x0002B93D
		[global::Cpp2ILInjected.Token(Token = "0x6004A9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E490", Offset = "0x85E490", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "VisualizeChestTransfer", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "VisualizeChestTransfer_CoinsBatch", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ShimmerUnstuck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShimmerUnstuckHelper), Member = "Update", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetParticlesModule), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerAndSelf", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "BroadcastOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void BroadcastOrRequestParticleSpawn(ParticleOrchestraType type, ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x0002D740 File Offset: 0x0002B940
		[global::Cpp2ILInjected.Token(Token = "0x6004A9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E5C0", Offset = "0x85E5C0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FadingParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static FadingParticle GetNewFadingParticle()
		{
			throw null;
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x0002D743 File Offset: 0x0002B943
		[global::Cpp2ILInjected.Token(Token = "0x6004A9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E614", Offset = "0x85E614", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LittleFlyingCritterParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static LittleFlyingCritterParticle GetNewPooFlyParticle()
		{
			throw null;
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x0002D746 File Offset: 0x0002B946
		[global::Cpp2ILInjected.Token(Token = "0x6004AA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E668", Offset = "0x85E668", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTransferParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static ItemTransferParticle GetNewItemTransferParticle()
		{
			throw null;
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x0002D749 File Offset: 0x0002B949
		[global::Cpp2ILInjected.Token(Token = "0x6004AA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E6BC", Offset = "0x85E6BC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlameParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static FlameParticle GetNewFlameParticle()
		{
			throw null;
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x0002D74C File Offset: 0x0002B94C
		[global::Cpp2ILInjected.Token(Token = "0x6004AA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E710", Offset = "0x85E710", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomizedFrameParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static RandomizedFrameParticle GetNewRandomizedFrameParticle()
		{
			throw null;
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x0002D74F File Offset: 0x0002B94F
		[global::Cpp2ILInjected.Token(Token = "0x6004AA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E764", Offset = "0x85E764", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrettySparkleParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static PrettySparkleParticle GetNewPrettySparkleParticle()
		{
			throw null;
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x0002D752 File Offset: 0x0002B952
		[global::Cpp2ILInjected.Token(Token = "0x6004AA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E7B8", Offset = "0x85E7B8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GasParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static GasParticle GetNewGasParticle()
		{
			throw null;
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x0002D755 File Offset: 0x0002B955
		[global::Cpp2ILInjected.Token(Token = "0x6004AA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x85DB4C", Offset = "0x85DB4C", Length = "0x868")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "RequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetParticlesModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_Keybrand", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_FlameWaders", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_StellarTune", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_WallOfFleshGoatMountFlames", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_BlackLightningHit", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_RainbowRodHit", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_BlackLightningSmall", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_StardustPunch", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_PrincessWeapon", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_PaladinsHammer", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_NightsEdge", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_SilverBulletSparkle", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_TrueNightsEdge", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_Excalibur", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_TrueExcalibur", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_TerraBlade", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_LeafCrystalPassive", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_LeafCrystalShot", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_AshTreeShake", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_PetExchange", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_SlapHand", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_FlyMeal", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_GasTrap", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_ItemTransfer", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_ShimmerArrow", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_TownSlimeTransform", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_LoadOutChange", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_ShimmerBlock", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_Digestion", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_WaffleIron", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_PooFly", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_ShimmerTownNPC", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "Spawn_ShimmerTownNPCSend", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public static void SpawnParticlesDirect(ParticleOrchestraType type, ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x0002D758 File Offset: 0x0002B958
		[global::Cpp2ILInjected.Token(Token = "0x6004AA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x86996C", Offset = "0x86996C", Length = "0x3CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2FromRectangle", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(Rectangle)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void Spawn_ShimmerTownNPCSend(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x0002D75B File Offset: 0x0002B95B
		[global::Cpp2ILInjected.Token(Token = "0x6004AA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x869360", Offset = "0x869360", Length = "0x60C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2FromRectangle", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(Rectangle)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private static void Spawn_ShimmerTownNPC(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x0002D75E File Offset: 0x0002B95E
		[global::Cpp2ILInjected.Token(Token = "0x6004AA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8691B0", Offset = "0x8691B0", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "CountParticlesInUse", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LittleFlyingCritterParticle), Member = "Prepare", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void Spawn_PooFly(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x0002D761 File Offset: 0x0002B961
		[global::Cpp2ILInjected.Token(Token = "0x6004AA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x868C60", Offset = "0x868C60", Length = "0x550")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private static void Spawn_Digestion(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x0002D764 File Offset: 0x0002B964
		[global::Cpp2ILInjected.Token(Token = "0x6004AAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8689E4", Offset = "0x8689E4", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void Spawn_ShimmerBlock(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x0002D767 File Offset: 0x0002B967
		[global::Cpp2ILInjected.Token(Token = "0x6004AAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8684BC", Offset = "0x8684BC", Length = "0x528")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2FromRectangle", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(Rectangle)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static void Spawn_LoadOutChange(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x0002D76A File Offset: 0x0002B96A
		[global::Cpp2ILInjected.Token(Token = "0x6004AAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8683AC", Offset = "0x8683AC", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "NerdySlimeEffect", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "ElderSlimeEffect", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "CopperSlimeEffect", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void Spawn_TownSlimeTransform(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x0002D76D File Offset: 0x0002B96D
		[global::Cpp2ILInjected.Token(Token = "0x6004AAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x86A2F0", Offset = "0x86A2F0", Length = "0x4C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_TownSlimeTransform", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomVector2", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGoreDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(Gore))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private static void ElderSlimeEffect(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x0002D770 File Offset: 0x0002B970
		[global::Cpp2ILInjected.Token(Token = "0x6004AAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x869D38", Offset = "0x869D38", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_TownSlimeTransform", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void NerdySlimeEffect(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x0002D773 File Offset: 0x0002B973
		[global::Cpp2ILInjected.Token(Token = "0x6004AAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x869F94", Offset = "0x869F94", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_TownSlimeTransform", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void CopperSlimeEffect(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x0002D776 File Offset: 0x0002B976
		[global::Cpp2ILInjected.Token(Token = "0x6004AB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x867AF8", Offset = "0x867AF8", Length = "0x8B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private static void Spawn_ShimmerArrow(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x0002D779 File Offset: 0x0002B979
		[global::Cpp2ILInjected.Token(Token = "0x6004AB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8677B0", Offset = "0x8677B0", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "AskForChestToEatItem", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTransferParticle), Member = "Prepare", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void Spawn_ItemTransfer(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x0002D77C File Offset: 0x0002B97C
		[global::Cpp2ILInjected.Token(Token = "0x6004AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x866DE0", Offset = "0x866DE0", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGoreDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(Gore))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void Spawn_PetExchange(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x0002D77F File Offset: 0x0002B97F
		[global::Cpp2ILInjected.Token(Token = "0x6004AB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x865044", Offset = "0x865044", Length = "0x920")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private static void Spawn_TerraBlade(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x0002D782 File Offset: 0x0002B982
		[global::Cpp2ILInjected.Token(Token = "0x6004AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x865964", Offset = "0x865964", Length = "0x788")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private static void Spawn_Excalibur(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x0002D785 File Offset: 0x0002B985
		[global::Cpp2ILInjected.Token(Token = "0x6004AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8670BC", Offset = "0x8670BC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void Spawn_SlapHand(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x0002D788 File Offset: 0x0002B988
		[global::Cpp2ILInjected.Token(Token = "0x6004AB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x867120", Offset = "0x867120", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void Spawn_WaffleIron(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x0002D78B File Offset: 0x0002B98B
		[global::Cpp2ILInjected.Token(Token = "0x6004AB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x867184", Offset = "0x867184", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void Spawn_FlyMeal(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x0002D78E File Offset: 0x0002B98E
		[global::Cpp2ILInjected.Token(Token = "0x6004AB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8671E8", Offset = "0x8671E8", Length = "0x5C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedByRandom", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private static void Spawn_GasTrap(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x0002D791 File Offset: 0x0002B991
		[global::Cpp2ILInjected.Token(Token = "0x6004AB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8660EC", Offset = "0x8660EC", Length = "0xCF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		private static void Spawn_TrueExcalibur(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x0002D794 File Offset: 0x0002B994
		[global::Cpp2ILInjected.Token(Token = "0x6004ABA")]
		[global::Cpp2ILInjected.Address(RVA = "0x86470C", Offset = "0x86470C", Length = "0x938")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private static void Spawn_AshTreeShake(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x0002D797 File Offset: 0x0002B997
		[global::Cpp2ILInjected.Token(Token = "0x6004ABB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8641B8", Offset = "0x8641B8", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static void Spawn_LeafCrystalPassive(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x0002D79A File Offset: 0x0002B99A
		[global::Cpp2ILInjected.Token(Token = "0x6004ABC")]
		[global::Cpp2ILInjected.Address(RVA = "0x864498", Offset = "0x864498", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void Spawn_LeafCrystalShot(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0002D79D File Offset: 0x0002B99D
		[global::Cpp2ILInjected.Token(Token = "0x6004ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0x863AB8", Offset = "0x863AB8", Length = "0x700")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static void Spawn_TrueNightsEdge(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x0002D7A0 File Offset: 0x0002B9A0
		[global::Cpp2ILInjected.Token(Token = "0x6004ABE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8632DC", Offset = "0x8632DC", Length = "0x548")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void Spawn_NightsEdge(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x0002D7A3 File Offset: 0x0002B9A3
		[global::Cpp2ILInjected.Token(Token = "0x6004ABF")]
		[global::Cpp2ILInjected.Address(RVA = "0x863824", Offset = "0x863824", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void Spawn_SilverBulletSparkle(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x0002D7A6 File Offset: 0x0002B9A6
		[global::Cpp2ILInjected.Token(Token = "0x6004AC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x862BAC", Offset = "0x862BAC", Length = "0x730")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "CloneDust", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static void Spawn_PaladinsHammer(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x0002D7A9 File Offset: 0x0002B9A9
		[global::Cpp2ILInjected.Token(Token = "0x6004AC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x862308", Offset = "0x862308", Length = "0x8A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "CloneDust", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static void Spawn_PrincessWeapon(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x0002D7AC File Offset: 0x0002B9AC
		[global::Cpp2ILInjected.Token(Token = "0x6004AC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x861AD4", Offset = "0x861AD4", Length = "0x834")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "CloneDust", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private static void Spawn_StardustPunch(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x0002D7AF File Offset: 0x0002B9AF
		[global::Cpp2ILInjected.Token(Token = "0x6004AC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x860A68", Offset = "0x860A68", Length = "0x878")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "CloneDust", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private static void Spawn_RainbowRodHit(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x0002D7B2 File Offset: 0x0002B9B2
		[global::Cpp2ILInjected.Token(Token = "0x6004AC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8612E0", Offset = "0x8612E0", Length = "0x7F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomizedFrameParticle), Member = "SetTypeInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		private static void Spawn_BlackLightningSmall(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x0002D7B5 File Offset: 0x0002B9B5
		[global::Cpp2ILInjected.Token(Token = "0x6004AC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8602EC", Offset = "0x8602EC", Length = "0x77C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomizedFrameParticle), Member = "SetTypeInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private static void Spawn_BlackLightningHit(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x0002D7B8 File Offset: 0x0002B9B8
		[global::Cpp2ILInjected.Token(Token = "0x6004AC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x85F8F4", Offset = "0x85F8F4", Length = "0x488")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private static void Spawn_StellarTune(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x0002D7BB File Offset: 0x0002B9BB
		[global::Cpp2ILInjected.Token(Token = "0x6004AC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x85E80C", Offset = "0x85E80C", Length = "0xB78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Square", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		private static void Spawn_Keybrand(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x0002D7BE File Offset: 0x0002B9BE
		[global::Cpp2ILInjected.Token(Token = "0x6004AC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x85F384", Offset = "0x85F384", Length = "0x570")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFromList", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			"T[]"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlameParticle), Member = "SetTypeInfo", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetSecondaryShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static void Spawn_FlameWaders(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x0002D7C1 File Offset: 0x0002B9C1
		[global::Cpp2ILInjected.Token(Token = "0x6004AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x85FD7C", Offset = "0x85FD7C", Length = "0x570")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFromList", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			"T[]"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = "RequestParticle", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlameParticle), Member = "SetTypeInfo", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetSecondaryShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static void Spawn_WallOfFleshGoatMountFlames(ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x0002D7C4 File Offset: 0x0002B9C4
		[global::Cpp2ILInjected.Token(Token = "0x6004ACA")]
		[global::Cpp2ILInjected.Address(RVA = "0x86A7B8", Offset = "0x86A7B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ParticleOrchestrator()
		{
			throw null;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x0002D7C7 File Offset: 0x0002B9C7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0x86A7C0", Offset = "0x86A7C0", Length = "0x1468")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>.ParticleInstantiator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticlePool<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			"ParticleInstantiator<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		static ParticleOrchestrator()
		{
			throw null;
		}

		// Token: 0x04006D1B RID: 27931
		[global::Cpp2ILInjected.Token(Token = "0x4008524")]
		private static ParticlePool<FadingParticle> _poolFading;

		// Token: 0x04006D1C RID: 27932
		[global::Cpp2ILInjected.Token(Token = "0x4008525")]
		private static ParticlePool<FlameParticle> _poolFlame;

		// Token: 0x04006D1D RID: 27933
		[global::Cpp2ILInjected.Token(Token = "0x4008526")]
		private static ParticlePool<RandomizedFrameParticle> _poolRandomizedFrame;

		// Token: 0x04006D1E RID: 27934
		[global::Cpp2ILInjected.Token(Token = "0x4008527")]
		private static ParticlePool<PrettySparkleParticle> _poolPrettySparkle;

		// Token: 0x04006D1F RID: 27935
		[global::Cpp2ILInjected.Token(Token = "0x4008528")]
		private static ParticlePool<ItemTransferParticle> _poolItemTransfer;

		// Token: 0x04006D20 RID: 27936
		[global::Cpp2ILInjected.Token(Token = "0x4008529")]
		private static ParticlePool<LittleFlyingCritterParticle> _poolFlies;

		// Token: 0x04006D21 RID: 27937
		[global::Cpp2ILInjected.Token(Token = "0x400852A")]
		private static ParticlePool<GasParticle> _poolGas;
	}
}
