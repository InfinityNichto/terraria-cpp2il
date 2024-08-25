using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005DA")]
	public class MessageID
	{
		[global::Cpp2ILInjected.Token(Token = "0x600355D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2640", Offset = "0x13C2640", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MessageID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400644C")]
		public const byte NeverCalled = 0;

		[global::Cpp2ILInjected.Token(Token = "0x400644D")]
		public const byte Hello = 1;

		[global::Cpp2ILInjected.Token(Token = "0x400644E")]
		public const byte Kick = 2;

		[global::Cpp2ILInjected.Token(Token = "0x400644F")]
		public const byte PlayerInfo = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4006450")]
		public const byte SyncPlayer = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4006451")]
		public const byte SyncEquipment = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4006452")]
		public const byte RequestWorldData = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4006453")]
		public const byte WorldData = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4006454")]
		public const byte SpawnTileData = 8;

		[global::Cpp2ILInjected.Token(Token = "0x4006455")]
		public const byte StatusTextSize = 9;

		[global::Cpp2ILInjected.Token(Token = "0x4006456")]
		public const byte TileSection = 10;

		[Old("Deprecated. Framing happens as needed after TileSection is sent.")]
		[global::Cpp2ILInjected.Token(Token = "0x4006457")]
		public const byte TileFrameSection = 11;

		[global::Cpp2ILInjected.Token(Token = "0x4006458")]
		public const byte PlayerSpawn = 12;

		[global::Cpp2ILInjected.Token(Token = "0x4006459")]
		public const byte PlayerControls = 13;

		[global::Cpp2ILInjected.Token(Token = "0x400645A")]
		public const byte PlayerActive = 14;

		[Obsolete("Deprecated.")]
		[global::Cpp2ILInjected.Token(Token = "0x400645B")]
		public const byte Unknown15 = 15;

		[global::Cpp2ILInjected.Token(Token = "0x400645C")]
		public const byte PlayerLifeMana = 16;

		[global::Cpp2ILInjected.Token(Token = "0x400645D")]
		public const byte TileManipulation = 17;

		[global::Cpp2ILInjected.Token(Token = "0x400645E")]
		public const byte SetTime = 18;

		[global::Cpp2ILInjected.Token(Token = "0x400645F")]
		public const byte ToggleDoorState = 19;

		[global::Cpp2ILInjected.Token(Token = "0x4006460")]
		public const byte Unknown20 = 20;

		[global::Cpp2ILInjected.Token(Token = "0x4006461")]
		public const byte SyncItem = 21;

		[global::Cpp2ILInjected.Token(Token = "0x4006462")]
		public const byte ItemOwner = 22;

		[global::Cpp2ILInjected.Token(Token = "0x4006463")]
		public const byte SyncNPC = 23;

		[global::Cpp2ILInjected.Token(Token = "0x4006464")]
		public const byte UnusedMeleeStrike = 24;

		[Obsolete("Deprecated. Use NetTextModule instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x4006465")]
		public const byte Unused25 = 25;

		[Obsolete("Deprecated.")]
		[global::Cpp2ILInjected.Token(Token = "0x4006466")]
		public const byte Unused26 = 26;

		[global::Cpp2ILInjected.Token(Token = "0x4006467")]
		public const byte SyncProjectile = 27;

		[global::Cpp2ILInjected.Token(Token = "0x4006468")]
		public const byte DamageNPC = 28;

		[global::Cpp2ILInjected.Token(Token = "0x4006469")]
		public const byte KillProjectile = 29;

		[global::Cpp2ILInjected.Token(Token = "0x400646A")]
		public const byte TogglePVP = 30;

		[global::Cpp2ILInjected.Token(Token = "0x400646B")]
		public const byte RequestChestOpen = 31;

		[global::Cpp2ILInjected.Token(Token = "0x400646C")]
		public const byte SyncChestItem = 32;

		[global::Cpp2ILInjected.Token(Token = "0x400646D")]
		public const byte SyncPlayerChest = 33;

		[global::Cpp2ILInjected.Token(Token = "0x400646E")]
		public const byte ChestUpdates = 34;

		[global::Cpp2ILInjected.Token(Token = "0x400646F")]
		public const byte PlayerHeal = 35;

		[global::Cpp2ILInjected.Token(Token = "0x4006470")]
		public const byte SyncPlayerZone = 36;

		[global::Cpp2ILInjected.Token(Token = "0x4006471")]
		public const byte RequestPassword = 37;

		[global::Cpp2ILInjected.Token(Token = "0x4006472")]
		public const byte SendPassword = 38;

		[global::Cpp2ILInjected.Token(Token = "0x4006473")]
		public const byte ReleaseItemOwnership = 39;

		[global::Cpp2ILInjected.Token(Token = "0x4006474")]
		public const byte SyncTalkNPC = 40;

		[global::Cpp2ILInjected.Token(Token = "0x4006475")]
		public const byte ShotAnimationAndSound = 41;

		[global::Cpp2ILInjected.Token(Token = "0x4006476")]
		public const byte Unknown42 = 42;

		[global::Cpp2ILInjected.Token(Token = "0x4006477")]
		public const byte Unknown43 = 43;

		[Obsolete("Deprecated.")]
		[global::Cpp2ILInjected.Token(Token = "0x4006478")]
		public const byte Unknown44 = 44;

		[global::Cpp2ILInjected.Token(Token = "0x4006479")]
		public const byte Unknown45 = 45;

		[global::Cpp2ILInjected.Token(Token = "0x400647A")]
		public const byte Unknown46 = 46;

		[global::Cpp2ILInjected.Token(Token = "0x400647B")]
		public const byte Unknown47 = 47;

		[Obsolete("Deprecated. Use NetLiquidModule instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x400647C")]
		public const byte LiquidUpdate = 48;

		[global::Cpp2ILInjected.Token(Token = "0x400647D")]
		public const byte InitialSpawn = 49;

		[global::Cpp2ILInjected.Token(Token = "0x400647E")]
		public const byte PlayerBuffs = 50;

		[global::Cpp2ILInjected.Token(Token = "0x400647F")]
		public const byte MiscDataSync = 51;

		[global::Cpp2ILInjected.Token(Token = "0x4006480")]
		public const byte LockAndUnlock = 52;

		[global::Cpp2ILInjected.Token(Token = "0x4006481")]
		public const byte AddNPCBuff = 53;

		[global::Cpp2ILInjected.Token(Token = "0x4006482")]
		public const byte NPCBuffs = 54;

		[global::Cpp2ILInjected.Token(Token = "0x4006483")]
		public const byte AddPlayerBuff = 55;

		[global::Cpp2ILInjected.Token(Token = "0x4006484")]
		public const byte UniqueTownNPCInfoSyncRequest = 56;

		[global::Cpp2ILInjected.Token(Token = "0x4006485")]
		public const byte Unknown57 = 57;

		[global::Cpp2ILInjected.Token(Token = "0x4006486")]
		public const byte InstrumentSound = 58;

		[global::Cpp2ILInjected.Token(Token = "0x4006487")]
		public const byte HitSwitch = 59;

		[global::Cpp2ILInjected.Token(Token = "0x4006488")]
		public const byte Unknown60 = 60;

		[global::Cpp2ILInjected.Token(Token = "0x4006489")]
		public const byte SpawnBossUseLicenseStartEvent = 61;

		[global::Cpp2ILInjected.Token(Token = "0x400648A")]
		public const byte Unknown62 = 62;

		[global::Cpp2ILInjected.Token(Token = "0x400648B")]
		public const byte Unknown63 = 63;

		[global::Cpp2ILInjected.Token(Token = "0x400648C")]
		public const byte Unknown64 = 64;

		[global::Cpp2ILInjected.Token(Token = "0x400648D")]
		public const byte TeleportEntity = 65;

		[global::Cpp2ILInjected.Token(Token = "0x400648E")]
		public const byte Unknown66 = 66;

		[global::Cpp2ILInjected.Token(Token = "0x400648F")]
		public const byte Unknown67 = 67;

		[global::Cpp2ILInjected.Token(Token = "0x4006490")]
		public const byte Unknown68 = 68;

		[global::Cpp2ILInjected.Token(Token = "0x4006491")]
		public const byte ChestName = 69;

		[global::Cpp2ILInjected.Token(Token = "0x4006492")]
		public const byte BugCatching = 70;

		[global::Cpp2ILInjected.Token(Token = "0x4006493")]
		public const byte BugReleasing = 71;

		[global::Cpp2ILInjected.Token(Token = "0x4006494")]
		public const byte TravelMerchantItems = 72;

		[global::Cpp2ILInjected.Token(Token = "0x4006495")]
		public const byte RequestTeleportationByServer = 73;

		[global::Cpp2ILInjected.Token(Token = "0x4006496")]
		public const byte AnglerQuest = 74;

		[global::Cpp2ILInjected.Token(Token = "0x4006497")]
		public const byte AnglerQuestFinished = 75;

		[global::Cpp2ILInjected.Token(Token = "0x4006498")]
		public const byte QuestsCountSync = 76;

		[global::Cpp2ILInjected.Token(Token = "0x4006499")]
		public const byte TemporaryAnimation = 77;

		[global::Cpp2ILInjected.Token(Token = "0x400649A")]
		public const byte InvasionProgressReport = 78;

		[global::Cpp2ILInjected.Token(Token = "0x400649B")]
		public const byte PlaceObject = 79;

		[global::Cpp2ILInjected.Token(Token = "0x400649C")]
		public const byte SyncPlayerChestIndex = 80;

		[global::Cpp2ILInjected.Token(Token = "0x400649D")]
		public const byte CombatTextInt = 81;

		[global::Cpp2ILInjected.Token(Token = "0x400649E")]
		public const byte NetModules = 82;

		[global::Cpp2ILInjected.Token(Token = "0x400649F")]
		public const byte NPCKillCountDeathTally = 83;

		[global::Cpp2ILInjected.Token(Token = "0x40064A0")]
		public const byte PlayerStealth = 84;

		[global::Cpp2ILInjected.Token(Token = "0x40064A1")]
		public const byte QuickStackChests = 85;

		[global::Cpp2ILInjected.Token(Token = "0x40064A2")]
		public const byte TileEntitySharing = 86;

		[global::Cpp2ILInjected.Token(Token = "0x40064A3")]
		public const byte TileEntityPlacement = 87;

		[global::Cpp2ILInjected.Token(Token = "0x40064A4")]
		public const byte ItemTweaker = 88;

		[global::Cpp2ILInjected.Token(Token = "0x40064A5")]
		public const byte ItemFrameTryPlacing = 89;

		[global::Cpp2ILInjected.Token(Token = "0x40064A6")]
		public const byte InstancedItem = 90;

		[global::Cpp2ILInjected.Token(Token = "0x40064A7")]
		public const byte SyncEmoteBubble = 91;

		[global::Cpp2ILInjected.Token(Token = "0x40064A8")]
		public const byte SyncExtraValue = 92;

		[global::Cpp2ILInjected.Token(Token = "0x40064A9")]
		public const byte SocialHandshake = 93;

		[global::Cpp2ILInjected.Token(Token = "0x40064AA")]
		public const byte Deprecated1 = 94;

		[global::Cpp2ILInjected.Token(Token = "0x40064AB")]
		public const byte MurderSomeoneElsesPortal = 95;

		[global::Cpp2ILInjected.Token(Token = "0x40064AC")]
		public const byte TeleportPlayerThroughPortal = 96;

		[global::Cpp2ILInjected.Token(Token = "0x40064AD")]
		public const byte AchievementMessageNPCKilled = 97;

		[global::Cpp2ILInjected.Token(Token = "0x40064AE")]
		public const byte AchievementMessageEventHappened = 98;

		[global::Cpp2ILInjected.Token(Token = "0x40064AF")]
		public const byte MinionRestTargetUpdate = 99;

		[global::Cpp2ILInjected.Token(Token = "0x40064B0")]
		public const byte TeleportNPCThroughPortal = 100;

		[global::Cpp2ILInjected.Token(Token = "0x40064B1")]
		public const byte UpdateTowerShieldStrengths = 101;

		[global::Cpp2ILInjected.Token(Token = "0x40064B2")]
		public const byte NebulaLevelupRequest = 102;

		[global::Cpp2ILInjected.Token(Token = "0x40064B3")]
		public const byte MoonlordHorror = 103;

		[global::Cpp2ILInjected.Token(Token = "0x40064B4")]
		public const byte ShopOverride = 104;

		[global::Cpp2ILInjected.Token(Token = "0x40064B5")]
		public const byte GemLockToggle = 105;

		[global::Cpp2ILInjected.Token(Token = "0x40064B6")]
		public const byte PoofOfSmoke = 106;

		[global::Cpp2ILInjected.Token(Token = "0x40064B7")]
		public const byte SmartTextMessage = 107;

		[global::Cpp2ILInjected.Token(Token = "0x40064B8")]
		public const byte WiredCannonShot = 108;

		[global::Cpp2ILInjected.Token(Token = "0x40064B9")]
		public const byte MassWireOperation = 109;

		[global::Cpp2ILInjected.Token(Token = "0x40064BA")]
		public const byte MassWireOperationPay = 110;

		[global::Cpp2ILInjected.Token(Token = "0x40064BB")]
		public const byte ToggleParty = 111;

		[global::Cpp2ILInjected.Token(Token = "0x40064BC")]
		public const byte SpecialFX = 112;

		[global::Cpp2ILInjected.Token(Token = "0x40064BD")]
		public const byte CrystalInvasionStart = 113;

		[global::Cpp2ILInjected.Token(Token = "0x40064BE")]
		public const byte CrystalInvasionWipeAllTheThingsss = 114;

		[global::Cpp2ILInjected.Token(Token = "0x40064BF")]
		public const byte MinionAttackTargetUpdate = 115;

		[global::Cpp2ILInjected.Token(Token = "0x40064C0")]
		public const byte CrystalInvasionSendWaitTime = 116;

		[global::Cpp2ILInjected.Token(Token = "0x40064C1")]
		public const byte PlayerHurtV2 = 117;

		[global::Cpp2ILInjected.Token(Token = "0x40064C2")]
		public const byte PlayerDeathV2 = 118;

		[global::Cpp2ILInjected.Token(Token = "0x40064C3")]
		public const byte CombatTextString = 119;

		[global::Cpp2ILInjected.Token(Token = "0x40064C4")]
		public const byte Emoji = 120;

		[global::Cpp2ILInjected.Token(Token = "0x40064C5")]
		public const byte TEDisplayDollItemSync = 121;

		[global::Cpp2ILInjected.Token(Token = "0x40064C6")]
		public const byte RequestTileEntityInteraction = 122;

		[global::Cpp2ILInjected.Token(Token = "0x40064C7")]
		public const byte WeaponsRackTryPlacing = 123;

		[global::Cpp2ILInjected.Token(Token = "0x40064C8")]
		public const byte TEHatRackItemSync = 124;

		[global::Cpp2ILInjected.Token(Token = "0x40064C9")]
		public const byte SyncTilePicking = 125;

		[global::Cpp2ILInjected.Token(Token = "0x40064CA")]
		public const byte SyncRevengeMarker = 126;

		[global::Cpp2ILInjected.Token(Token = "0x40064CB")]
		public const byte RemoveRevengeMarker = 127;

		[global::Cpp2ILInjected.Token(Token = "0x40064CC")]
		public const byte LandGolfBallInCup = 128;

		[global::Cpp2ILInjected.Token(Token = "0x40064CD")]
		public const byte FinishedConnectingToServer = 129;

		[global::Cpp2ILInjected.Token(Token = "0x40064CE")]
		public const byte FishOutNPC = 130;

		[global::Cpp2ILInjected.Token(Token = "0x40064CF")]
		public const byte TamperWithNPC = 131;

		[global::Cpp2ILInjected.Token(Token = "0x40064D0")]
		public const byte PlayLegacySound = 132;

		[global::Cpp2ILInjected.Token(Token = "0x40064D1")]
		public const byte FoodPlatterTryPlacing = 133;

		[global::Cpp2ILInjected.Token(Token = "0x40064D2")]
		public const byte UpdatePlayerLuckFactors = 134;

		[global::Cpp2ILInjected.Token(Token = "0x40064D3")]
		public const byte DeadPlayer = 135;

		[global::Cpp2ILInjected.Token(Token = "0x40064D4")]
		public const byte SyncCavernMonsterType = 136;

		[global::Cpp2ILInjected.Token(Token = "0x40064D5")]
		public const byte RequestNPCBuffRemoval = 137;

		[global::Cpp2ILInjected.Token(Token = "0x40064D6")]
		public const byte ClientSyncedInventory = 138;

		[global::Cpp2ILInjected.Token(Token = "0x40064D7")]
		public const byte SetCountsAsHostForGameplay = 139;

		[global::Cpp2ILInjected.Token(Token = "0x40064D8")]
		public const byte SetMiscEventValues = 140;

		[global::Cpp2ILInjected.Token(Token = "0x40064D9")]
		public const byte RequestLucyPopup = 141;

		[global::Cpp2ILInjected.Token(Token = "0x40064DA")]
		public const byte SyncProjectileTrackers = 142;

		[global::Cpp2ILInjected.Token(Token = "0x40064DB")]
		public const byte CrystalInvasionRequestedToSkipWaitTime = 143;

		[global::Cpp2ILInjected.Token(Token = "0x40064DC")]
		public const byte RequestQuestEffect = 144;

		[global::Cpp2ILInjected.Token(Token = "0x40064DD")]
		public const byte SyncItemsWithShimmer = 145;

		[global::Cpp2ILInjected.Token(Token = "0x40064DE")]
		public const byte ShimmerActions = 146;

		[global::Cpp2ILInjected.Token(Token = "0x40064DF")]
		public const byte SyncLoadout = 147;

		[global::Cpp2ILInjected.Token(Token = "0x40064E0")]
		public const byte SyncItemCannotBeTakenByEnemies = 148;

		[global::Cpp2ILInjected.Token(Token = "0x40064E1")]
		public const byte ServerInfo = 149;

		[global::Cpp2ILInjected.Token(Token = "0x40064E2")]
		public const byte PlayerPlatformInfo = 150;

		[global::Cpp2ILInjected.Token(Token = "0x40064E3")]
		public const byte Count = 151;
	}
}
