using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.Achievements;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Initializers;

namespace Terraria.Audio
{
	// Token: 0x02000487 RID: 1159
	[global::Cpp2ILInjected.Token(Token = "0x200068B")]
	public static class SoundEngine
	{
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x0002B148 File Offset: 0x00029348
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x0002B14B File Offset: 0x0002934B
		[global::Cpp2ILInjected.Token(Token = "0x170006C4")]
		public static bool IsAudioSupported
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60037F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1434B54", Offset = "0x1434B54", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60037F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1434B9C", Offset = "0x1434B9C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x0002B14E File Offset: 0x0002934E
		[global::Cpp2ILInjected.Token(Token = "0x60037F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434BE8", Offset = "0x1434BE8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x0002B151 File Offset: 0x00029351
		[global::Cpp2ILInjected.Token(Token = "0x60037F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434C34", Offset = "0x1434C34", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadSounds", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundPlayer), Member = ".ctor", MemberParameters = new object[] { typeof(IServiceProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundPlayer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Load(IServiceProvider services)
		{
			throw null;
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x0002B154 File Offset: 0x00029354
		[global::Cpp2ILInjected.Token(Token = "0x60037F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434D94", Offset = "0x1434D94", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateAudio", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstanceGarbageCollector), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundPlayer), Member = "PauseAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundPlayer), Member = "ResumeAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundPlayer), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x0002B157 File Offset: 0x00029357
		[global::Cpp2ILInjected.Token(Token = "0x60037FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435948", Offset = "0x1435948", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundPlayer), Member = "Reload", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundPlayer), Member = "StopAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Reload()
		{
			throw null;
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x0002B15A File Offset: 0x0002935A
		[global::Cpp2ILInjected.Token(Token = "0x60037FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14359E4", Offset = "0x14359E4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "UpdateChestFrames", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TeleportEffect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(TeleportationSide),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateWeather", MemberParameters = new object[]
		{
			typeof(GameTime),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_121_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_026_Unicorns", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "moneyPing", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_ManageRightClickFeatures_ShieldRaise", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayGuitarChord", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayDrums", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		public static void PlaySound(int type, Vector2 position, int style = 1)
		{
			throw null;
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x0002B15D File Offset: 0x0002935D
		[global::Cpp2ILInjected.Token(Token = "0x60037FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435B24", Offset = "0x1435B24", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 331)]
		public static SoundEffectInstance PlaySound(LegacySoundStyle type, Vector2 position)
		{
			throw null;
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x0002B160 File Offset: 0x00029360
		[global::Cpp2ILInjected.Token(Token = "0x60037FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435B4C", Offset = "0x1435B4C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "get_Style", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundStyle), Member = "GetRandomPitch", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		public static SoundEffectInstance PlaySound(LegacySoundStyle type, int x = -1, int y = -1)
		{
			throw null;
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x0002B163 File Offset: 0x00029363
		[global::Cpp2ILInjected.Token(Token = "0x60037FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435A18", Offset = "0x1435A18", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 967)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundPlayer), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static SoundEffectInstance PlaySound(int type, int x = -1, int y = -1, int Style = 1, float volumeScale = 1f, float pitchOffset = 0f)
		{
			throw null;
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x0002B166 File Offset: 0x00029366
		[global::Cpp2ILInjected.Token(Token = "0x60037FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435C58", Offset = "0x1435C58", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_110_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_108_DivingFlyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_187_ShadowHand", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_177_IceWhipSlicer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_143_MonkStaffT2Ghast", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_145_BookStaffStorm", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static ActiveSound GetActiveSound(SlotId id)
		{
			throw null;
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x0002B169 File Offset: 0x00029369
		[global::Cpp2ILInjected.Token(Token = "0x6003800")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435DAC", Offset = "0x1435DAC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_110_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_108_DivingFlyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_111_DD2LightningBug", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_187_ShadowHand", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_177_IceWhipSlicer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_131_FlameBurstShot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_134_Ballista", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_137_LightningAura", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_140_MonkStaffT1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_143_MonkStaffT2Ghast", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_145_BookStaffStorm", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 53)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundPlayer), Member = "Play", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static SlotId PlayTrackedSound(SoundStyle style, Vector2 position)
		{
			throw null;
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0002B16C File Offset: 0x0002936C
		[global::Cpp2ILInjected.Token(Token = "0x6003801")]
		[global::Cpp2ILInjected.Address(RVA = "0x143609C", Offset = "0x143609C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundPlayer), Member = "PlayLooped", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2),
			typeof(ActiveSound.LoopedPlayCondition)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static SlotId PlayTrackedLoopedSound(SoundStyle style, Vector2 position, ActiveSound.LoopedPlayCondition loopingCondition = null)
		{
			throw null;
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x0002B16F File Offset: 0x0002936F
		[global::Cpp2ILInjected.Token(Token = "0x6003802")]
		[global::Cpp2ILInjected.Address(RVA = "0x14363A4", Offset = "0x14363A4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_110_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_138_ExplosiveTrap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "OnAchievementCompleted", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundPlayer), Member = "Play", MemberParameters = new object[] { typeof(SoundStyle) }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static SlotId PlayTrackedSound(SoundStyle style)
		{
			throw null;
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x0002B172 File Offset: 0x00029372
		[global::Cpp2ILInjected.Token(Token = "0x6003803")]
		[global::Cpp2ILInjected.Address(RVA = "0x14365A0", Offset = "0x14365A0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "JustQuit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SaveAndQuitCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void StopTrackedSounds()
		{
			throw null;
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x0002B175 File Offset: 0x00029375
		[global::Cpp2ILInjected.Token(Token = "0x6003804")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434A24", Offset = "0x1434A24", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundPlayer), Member = "GetTrackableSoundByStyleId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SoundEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static SoundEffect GetTrackableSoundByStyleId(int id)
		{
			throw null;
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x0002B178 File Offset: 0x00029378
		[global::Cpp2ILInjected.Token(Token = "0x6003805")]
		[global::Cpp2ILInjected.Address(RVA = "0x143692C", Offset = "0x143692C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateAudio", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundPlayer), Member = "StopAmbientSounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void StopAmbientSounds()
		{
			throw null;
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x0002B17B File Offset: 0x0002937B
		[global::Cpp2ILInjected.Token(Token = "0x6003806")]
		[global::Cpp2ILInjected.Address(RVA = "0x14369E4", Offset = "0x14369E4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "OnAchievementCompleted", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static ActiveSound FindActiveSound(SoundStyle style)
		{
			throw null;
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x0002B17E File Offset: 0x0002937E
		[global::Cpp2ILInjected.Token(Token = "0x6003807")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434C2C", Offset = "0x1434C2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool TestAudioSupport()
		{
			throw null;
		}

		// Token: 0x04006507 RID: 25863
		[global::Cpp2ILInjected.Token(Token = "0x4007903")]
		public static LegacySoundPlayer LegacySoundPlayer;

		// Token: 0x04006508 RID: 25864
		[global::Cpp2ILInjected.Token(Token = "0x4007904")]
		public static SoundPlayer SoundPlayer;

		// Token: 0x04006509 RID: 25865
		[global::Cpp2ILInjected.Token(Token = "0x4007905")]
		public static bool AreSoundsPaused;

		// Token: 0x0400650A RID: 25866
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007906")]
		private static bool <IsAudioSupported>k__BackingField;
	}
}
