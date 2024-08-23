using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.ID
{
	// Token: 0x020003F6 RID: 1014
	[global::Cpp2ILInjected.Token(Token = "0x20005DA")]
	public class MessageID
	{
		// Token: 0x06003061 RID: 12385 RVA: 0x0002AA6D File Offset: 0x00028C6D
		[global::Cpp2ILInjected.Token(Token = "0x600355D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2640", Offset = "0x13C2640", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MessageID()
		{
			throw null;
		}

		// Token: 0x040051A4 RID: 20900
		[global::Cpp2ILInjected.Token(Token = "0x400644C")]
		public const byte NeverCalled = 0;

		// Token: 0x040051A5 RID: 20901
		[global::Cpp2ILInjected.Token(Token = "0x400644D")]
		public const byte Hello = 1;

		// Token: 0x040051A6 RID: 20902
		[global::Cpp2ILInjected.Token(Token = "0x400644E")]
		public const byte Kick = 2;

		// Token: 0x040051A7 RID: 20903
		[global::Cpp2ILInjected.Token(Token = "0x400644F")]
		public const byte PlayerInfo = 3;

		// Token: 0x040051A8 RID: 20904
		[global::Cpp2ILInjected.Token(Token = "0x4006450")]
		public const byte SyncPlayer = 4;

		// Token: 0x040051A9 RID: 20905
		[global::Cpp2ILInjected.Token(Token = "0x4006451")]
		public const byte SyncEquipment = 5;

		// Token: 0x040051AA RID: 20906
		[global::Cpp2ILInjected.Token(Token = "0x4006452")]
		public const byte RequestWorldData = 6;

		// Token: 0x040051AB RID: 20907
		[global::Cpp2ILInjected.Token(Token = "0x4006453")]
		public const byte WorldData = 7;

		// Token: 0x040051AC RID: 20908
		[global::Cpp2ILInjected.Token(Token = "0x4006454")]
		public const byte SpawnTileData = 8;

		// Token: 0x040051AD RID: 20909
		[global::Cpp2ILInjected.Token(Token = "0x4006455")]
		public const byte StatusTextSize = 9;

		// Token: 0x040051AE RID: 20910
		[global::Cpp2ILInjected.Token(Token = "0x4006456")]
		public const byte TileSection = 10;

		// Token: 0x040051AF RID: 20911
		[Old("Deprecated. Framing happens as needed after TileSection is sent.")]
		[global::Cpp2ILInjected.Token(Token = "0x4006457")]
		public const byte TileFrameSection = 11;

		// Token: 0x040051B0 RID: 20912
		[global::Cpp2ILInjected.Token(Token = "0x4006458")]
		public const byte PlayerSpawn = 12;

		// Token: 0x040051B1 RID: 20913
		[global::Cpp2ILInjected.Token(Token = "0x4006459")]
		public const byte PlayerControls = 13;

		// Token: 0x040051B2 RID: 20914
		[global::Cpp2ILInjected.Token(Token = "0x400645A")]
		public const byte PlayerActive = 14;

		// Token: 0x040051B3 RID: 20915
		[Obsolete("Deprecated.")]
		[global::Cpp2ILInjected.Token(Token = "0x400645B")]
		public const byte Unknown15 = 15;

		// Token: 0x040051B4 RID: 20916
		[global::Cpp2ILInjected.Token(Token = "0x400645C")]
		public const byte PlayerLifeMana = 16;

		// Token: 0x040051B5 RID: 20917
		[global::Cpp2ILInjected.Token(Token = "0x400645D")]
		public const byte TileManipulation = 17;

		// Token: 0x040051B6 RID: 20918
		[global::Cpp2ILInjected.Token(Token = "0x400645E")]
		public const byte SetTime = 18;

		// Token: 0x040051B7 RID: 20919
		[global::Cpp2ILInjected.Token(Token = "0x400645F")]
		public const byte ToggleDoorState = 19;

		// Token: 0x040051B8 RID: 20920
		[global::Cpp2ILInjected.Token(Token = "0x4006460")]
		public const byte Unknown20 = 20;

		// Token: 0x040051B9 RID: 20921
		[global::Cpp2ILInjected.Token(Token = "0x4006461")]
		public const byte SyncItem = 21;

		// Token: 0x040051BA RID: 20922
		[global::Cpp2ILInjected.Token(Token = "0x4006462")]
		public const byte ItemOwner = 22;

		// Token: 0x040051BB RID: 20923
		[global::Cpp2ILInjected.Token(Token = "0x4006463")]
		public const byte SyncNPC = 23;

		// Token: 0x040051BC RID: 20924
		[global::Cpp2ILInjected.Token(Token = "0x4006464")]
		public const byte UnusedMeleeStrike = 24;

		// Token: 0x040051BD RID: 20925
		[Obsolete("Deprecated. Use NetTextModule instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x4006465")]
		public const byte Unused25 = 25;

		// Token: 0x040051BE RID: 20926
		[Obsolete("Deprecated.")]
		[global::Cpp2ILInjected.Token(Token = "0x4006466")]
		public const byte Unused26 = 26;

		// Token: 0x040051BF RID: 20927
		[global::Cpp2ILInjected.Token(Token = "0x4006467")]
		public const byte SyncProjectile = 27;

		// Token: 0x040051C0 RID: 20928
		[global::Cpp2ILInjected.Token(Token = "0x4006468")]
		public const byte DamageNPC = 28;

		// Token: 0x040051C1 RID: 20929
		[global::Cpp2ILInjected.Token(Token = "0x4006469")]
		public const byte KillProjectile = 29;

		// Token: 0x040051C2 RID: 20930
		[global::Cpp2ILInjected.Token(Token = "0x400646A")]
		public const byte TogglePVP = 30;

		// Token: 0x040051C3 RID: 20931
		[global::Cpp2ILInjected.Token(Token = "0x400646B")]
		public const byte RequestChestOpen = 31;

		// Token: 0x040051C4 RID: 20932
		[global::Cpp2ILInjected.Token(Token = "0x400646C")]
		public const byte SyncChestItem = 32;

		// Token: 0x040051C5 RID: 20933
		[global::Cpp2ILInjected.Token(Token = "0x400646D")]
		public const byte SyncPlayerChest = 33;

		// Token: 0x040051C6 RID: 20934
		[global::Cpp2ILInjected.Token(Token = "0x400646E")]
		public const byte ChestUpdates = 34;

		// Token: 0x040051C7 RID: 20935
		[global::Cpp2ILInjected.Token(Token = "0x400646F")]
		public const byte PlayerHeal = 35;

		// Token: 0x040051C8 RID: 20936
		[global::Cpp2ILInjected.Token(Token = "0x4006470")]
		public const byte SyncPlayerZone = 36;

		// Token: 0x040051C9 RID: 20937
		[global::Cpp2ILInjected.Token(Token = "0x4006471")]
		public const byte RequestPassword = 37;

		// Token: 0x040051CA RID: 20938
		[global::Cpp2ILInjected.Token(Token = "0x4006472")]
		public const byte SendPassword = 38;

		// Token: 0x040051CB RID: 20939
		[global::Cpp2ILInjected.Token(Token = "0x4006473")]
		public const byte ReleaseItemOwnership = 39;

		// Token: 0x040051CC RID: 20940
		[global::Cpp2ILInjected.Token(Token = "0x4006474")]
		public const byte SyncTalkNPC = 40;

		// Token: 0x040051CD RID: 20941
		[global::Cpp2ILInjected.Token(Token = "0x4006475")]
		public const byte ShotAnimationAndSound = 41;

		// Token: 0x040051CE RID: 20942
		[global::Cpp2ILInjected.Token(Token = "0x4006476")]
		public const byte Unknown42 = 42;

		// Token: 0x040051CF RID: 20943
		[global::Cpp2ILInjected.Token(Token = "0x4006477")]
		public const byte Unknown43 = 43;

		// Token: 0x040051D0 RID: 20944
		[Obsolete("Deprecated.")]
		[global::Cpp2ILInjected.Token(Token = "0x4006478")]
		public const byte Unknown44 = 44;

		// Token: 0x040051D1 RID: 20945
		[global::Cpp2ILInjected.Token(Token = "0x4006479")]
		public const byte Unknown45 = 45;

		// Token: 0x040051D2 RID: 20946
		[global::Cpp2ILInjected.Token(Token = "0x400647A")]
		public const byte Unknown46 = 46;

		// Token: 0x040051D3 RID: 20947
		[global::Cpp2ILInjected.Token(Token = "0x400647B")]
		public const byte Unknown47 = 47;

		// Token: 0x040051D4 RID: 20948
		[Obsolete("Deprecated. Use NetLiquidModule instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x400647C")]
		public const byte LiquidUpdate = 48;

		// Token: 0x040051D5 RID: 20949
		[global::Cpp2ILInjected.Token(Token = "0x400647D")]
		public const byte InitialSpawn = 49;

		// Token: 0x040051D6 RID: 20950
		[global::Cpp2ILInjected.Token(Token = "0x400647E")]
		public const byte PlayerBuffs = 50;

		// Token: 0x040051D7 RID: 20951
		[global::Cpp2ILInjected.Token(Token = "0x400647F")]
		public const byte MiscDataSync = 51;

		// Token: 0x040051D8 RID: 20952
		[global::Cpp2ILInjected.Token(Token = "0x4006480")]
		public const byte LockAndUnlock = 52;

		// Token: 0x040051D9 RID: 20953
		[global::Cpp2ILInjected.Token(Token = "0x4006481")]
		public const byte AddNPCBuff = 53;

		// Token: 0x040051DA RID: 20954
		[global::Cpp2ILInjected.Token(Token = "0x4006482")]
		public const byte NPCBuffs = 54;

		// Token: 0x040051DB RID: 20955
		[global::Cpp2ILInjected.Token(Token = "0x4006483")]
		public const byte AddPlayerBuff = 55;

		// Token: 0x040051DC RID: 20956
		[global::Cpp2ILInjected.Token(Token = "0x4006484")]
		public const byte UniqueTownNPCInfoSyncRequest = 56;

		// Token: 0x040051DD RID: 20957
		[global::Cpp2ILInjected.Token(Token = "0x4006485")]
		public const byte Unknown57 = 57;

		// Token: 0x040051DE RID: 20958
		[global::Cpp2ILInjected.Token(Token = "0x4006486")]
		public const byte InstrumentSound = 58;

		// Token: 0x040051DF RID: 20959
		[global::Cpp2ILInjected.Token(Token = "0x4006487")]
		public const byte HitSwitch = 59;

		// Token: 0x040051E0 RID: 20960
		[global::Cpp2ILInjected.Token(Token = "0x4006488")]
		public const byte Unknown60 = 60;

		// Token: 0x040051E1 RID: 20961
		[global::Cpp2ILInjected.Token(Token = "0x4006489")]
		public const byte SpawnBossUseLicenseStartEvent = 61;

		// Token: 0x040051E2 RID: 20962
		[global::Cpp2ILInjected.Token(Token = "0x400648A")]
		public const byte Unknown62 = 62;

		// Token: 0x040051E3 RID: 20963
		[global::Cpp2ILInjected.Token(Token = "0x400648B")]
		public const byte Unknown63 = 63;

		// Token: 0x040051E4 RID: 20964
		[global::Cpp2ILInjected.Token(Token = "0x400648C")]
		public const byte Unknown64 = 64;

		// Token: 0x040051E5 RID: 20965
		[global::Cpp2ILInjected.Token(Token = "0x400648D")]
		public const byte TeleportEntity = 65;

		// Token: 0x040051E6 RID: 20966
		[global::Cpp2ILInjected.Token(Token = "0x400648E")]
		public const byte Unknown66 = 66;

		// Token: 0x040051E7 RID: 20967
		[global::Cpp2ILInjected.Token(Token = "0x400648F")]
		public const byte Unknown67 = 67;

		// Token: 0x040051E8 RID: 20968
		[global::Cpp2ILInjected.Token(Token = "0x4006490")]
		public const byte Unknown68 = 68;

		// Token: 0x040051E9 RID: 20969
		[global::Cpp2ILInjected.Token(Token = "0x4006491")]
		public const byte ChestName = 69;

		// Token: 0x040051EA RID: 20970
		[global::Cpp2ILInjected.Token(Token = "0x4006492")]
		public const byte BugCatching = 70;

		// Token: 0x040051EB RID: 20971
		[global::Cpp2ILInjected.Token(Token = "0x4006493")]
		public const byte BugReleasing = 71;

		// Token: 0x040051EC RID: 20972
		[global::Cpp2ILInjected.Token(Token = "0x4006494")]
		public const byte TravelMerchantItems = 72;

		// Token: 0x040051ED RID: 20973
		[global::Cpp2ILInjected.Token(Token = "0x4006495")]
		public const byte RequestTeleportationByServer = 73;

		// Token: 0x040051EE RID: 20974
		[global::Cpp2ILInjected.Token(Token = "0x4006496")]
		public const byte AnglerQuest = 74;

		// Token: 0x040051EF RID: 20975
		[global::Cpp2ILInjected.Token(Token = "0x4006497")]
		public const byte AnglerQuestFinished = 75;

		// Token: 0x040051F0 RID: 20976
		[global::Cpp2ILInjected.Token(Token = "0x4006498")]
		public const byte QuestsCountSync = 76;

		// Token: 0x040051F1 RID: 20977
		[global::Cpp2ILInjected.Token(Token = "0x4006499")]
		public const byte TemporaryAnimation = 77;

		// Token: 0x040051F2 RID: 20978
		[global::Cpp2ILInjected.Token(Token = "0x400649A")]
		public const byte InvasionProgressReport = 78;

		// Token: 0x040051F3 RID: 20979
		[global::Cpp2ILInjected.Token(Token = "0x400649B")]
		public const byte PlaceObject = 79;

		// Token: 0x040051F4 RID: 20980
		[global::Cpp2ILInjected.Token(Token = "0x400649C")]
		public const byte SyncPlayerChestIndex = 80;

		// Token: 0x040051F5 RID: 20981
		[global::Cpp2ILInjected.Token(Token = "0x400649D")]
		public const byte CombatTextInt = 81;

		// Token: 0x040051F6 RID: 20982
		[global::Cpp2ILInjected.Token(Token = "0x400649E")]
		public const byte NetModules = 82;

		// Token: 0x040051F7 RID: 20983
		[global::Cpp2ILInjected.Token(Token = "0x400649F")]
		public const byte NPCKillCountDeathTally = 83;

		// Token: 0x040051F8 RID: 20984
		[global::Cpp2ILInjected.Token(Token = "0x40064A0")]
		public const byte PlayerStealth = 84;

		// Token: 0x040051F9 RID: 20985
		[global::Cpp2ILInjected.Token(Token = "0x40064A1")]
		public const byte QuickStackChests = 85;

		// Token: 0x040051FA RID: 20986
		[global::Cpp2ILInjected.Token(Token = "0x40064A2")]
		public const byte TileEntitySharing = 86;

		// Token: 0x040051FB RID: 20987
		[global::Cpp2ILInjected.Token(Token = "0x40064A3")]
		public const byte TileEntityPlacement = 87;

		// Token: 0x040051FC RID: 20988
		[global::Cpp2ILInjected.Token(Token = "0x40064A4")]
		public const byte ItemTweaker = 88;

		// Token: 0x040051FD RID: 20989
		[global::Cpp2ILInjected.Token(Token = "0x40064A5")]
		public const byte ItemFrameTryPlacing = 89;

		// Token: 0x040051FE RID: 20990
		[global::Cpp2ILInjected.Token(Token = "0x40064A6")]
		public const byte InstancedItem = 90;

		// Token: 0x040051FF RID: 20991
		[global::Cpp2ILInjected.Token(Token = "0x40064A7")]
		public const byte SyncEmoteBubble = 91;

		// Token: 0x04005200 RID: 20992
		[global::Cpp2ILInjected.Token(Token = "0x40064A8")]
		public const byte SyncExtraValue = 92;

		// Token: 0x04005201 RID: 20993
		[global::Cpp2ILInjected.Token(Token = "0x40064A9")]
		public const byte SocialHandshake = 93;

		// Token: 0x04005202 RID: 20994
		[global::Cpp2ILInjected.Token(Token = "0x40064AA")]
		public const byte Deprecated1 = 94;

		// Token: 0x04005203 RID: 20995
		[global::Cpp2ILInjected.Token(Token = "0x40064AB")]
		public const byte MurderSomeoneElsesPortal = 95;

		// Token: 0x04005204 RID: 20996
		[global::Cpp2ILInjected.Token(Token = "0x40064AC")]
		public const byte TeleportPlayerThroughPortal = 96;

		// Token: 0x04005205 RID: 20997
		[global::Cpp2ILInjected.Token(Token = "0x40064AD")]
		public const byte AchievementMessageNPCKilled = 97;

		// Token: 0x04005206 RID: 20998
		[global::Cpp2ILInjected.Token(Token = "0x40064AE")]
		public const byte AchievementMessageEventHappened = 98;

		// Token: 0x04005207 RID: 20999
		[global::Cpp2ILInjected.Token(Token = "0x40064AF")]
		public const byte MinionRestTargetUpdate = 99;

		// Token: 0x04005208 RID: 21000
		[global::Cpp2ILInjected.Token(Token = "0x40064B0")]
		public const byte TeleportNPCThroughPortal = 100;

		// Token: 0x04005209 RID: 21001
		[global::Cpp2ILInjected.Token(Token = "0x40064B1")]
		public const byte UpdateTowerShieldStrengths = 101;

		// Token: 0x0400520A RID: 21002
		[global::Cpp2ILInjected.Token(Token = "0x40064B2")]
		public const byte NebulaLevelupRequest = 102;

		// Token: 0x0400520B RID: 21003
		[global::Cpp2ILInjected.Token(Token = "0x40064B3")]
		public const byte MoonlordHorror = 103;

		// Token: 0x0400520C RID: 21004
		[global::Cpp2ILInjected.Token(Token = "0x40064B4")]
		public const byte ShopOverride = 104;

		// Token: 0x0400520D RID: 21005
		[global::Cpp2ILInjected.Token(Token = "0x40064B5")]
		public const byte GemLockToggle = 105;

		// Token: 0x0400520E RID: 21006
		[global::Cpp2ILInjected.Token(Token = "0x40064B6")]
		public const byte PoofOfSmoke = 106;

		// Token: 0x0400520F RID: 21007
		[global::Cpp2ILInjected.Token(Token = "0x40064B7")]
		public const byte SmartTextMessage = 107;

		// Token: 0x04005210 RID: 21008
		[global::Cpp2ILInjected.Token(Token = "0x40064B8")]
		public const byte WiredCannonShot = 108;

		// Token: 0x04005211 RID: 21009
		[global::Cpp2ILInjected.Token(Token = "0x40064B9")]
		public const byte MassWireOperation = 109;

		// Token: 0x04005212 RID: 21010
		[global::Cpp2ILInjected.Token(Token = "0x40064BA")]
		public const byte MassWireOperationPay = 110;

		// Token: 0x04005213 RID: 21011
		[global::Cpp2ILInjected.Token(Token = "0x40064BB")]
		public const byte ToggleParty = 111;

		// Token: 0x04005214 RID: 21012
		[global::Cpp2ILInjected.Token(Token = "0x40064BC")]
		public const byte SpecialFX = 112;

		// Token: 0x04005215 RID: 21013
		[global::Cpp2ILInjected.Token(Token = "0x40064BD")]
		public const byte CrystalInvasionStart = 113;

		// Token: 0x04005216 RID: 21014
		[global::Cpp2ILInjected.Token(Token = "0x40064BE")]
		public const byte CrystalInvasionWipeAllTheThingsss = 114;

		// Token: 0x04005217 RID: 21015
		[global::Cpp2ILInjected.Token(Token = "0x40064BF")]
		public const byte MinionAttackTargetUpdate = 115;

		// Token: 0x04005218 RID: 21016
		[global::Cpp2ILInjected.Token(Token = "0x40064C0")]
		public const byte CrystalInvasionSendWaitTime = 116;

		// Token: 0x04005219 RID: 21017
		[global::Cpp2ILInjected.Token(Token = "0x40064C1")]
		public const byte PlayerHurtV2 = 117;

		// Token: 0x0400521A RID: 21018
		[global::Cpp2ILInjected.Token(Token = "0x40064C2")]
		public const byte PlayerDeathV2 = 118;

		// Token: 0x0400521B RID: 21019
		[global::Cpp2ILInjected.Token(Token = "0x40064C3")]
		public const byte CombatTextString = 119;

		// Token: 0x0400521C RID: 21020
		[global::Cpp2ILInjected.Token(Token = "0x40064C4")]
		public const byte Emoji = 120;

		// Token: 0x0400521D RID: 21021
		[global::Cpp2ILInjected.Token(Token = "0x40064C5")]
		public const byte TEDisplayDollItemSync = 121;

		// Token: 0x0400521E RID: 21022
		[global::Cpp2ILInjected.Token(Token = "0x40064C6")]
		public const byte RequestTileEntityInteraction = 122;

		// Token: 0x0400521F RID: 21023
		[global::Cpp2ILInjected.Token(Token = "0x40064C7")]
		public const byte WeaponsRackTryPlacing = 123;

		// Token: 0x04005220 RID: 21024
		[global::Cpp2ILInjected.Token(Token = "0x40064C8")]
		public const byte TEHatRackItemSync = 124;

		// Token: 0x04005221 RID: 21025
		[global::Cpp2ILInjected.Token(Token = "0x40064C9")]
		public const byte SyncTilePicking = 125;

		// Token: 0x04005222 RID: 21026
		[global::Cpp2ILInjected.Token(Token = "0x40064CA")]
		public const byte SyncRevengeMarker = 126;

		// Token: 0x04005223 RID: 21027
		[global::Cpp2ILInjected.Token(Token = "0x40064CB")]
		public const byte RemoveRevengeMarker = 127;

		// Token: 0x04005224 RID: 21028
		[global::Cpp2ILInjected.Token(Token = "0x40064CC")]
		public const byte LandGolfBallInCup = 128;

		// Token: 0x04005225 RID: 21029
		[global::Cpp2ILInjected.Token(Token = "0x40064CD")]
		public const byte FinishedConnectingToServer = 129;

		// Token: 0x04005226 RID: 21030
		[global::Cpp2ILInjected.Token(Token = "0x40064CE")]
		public const byte FishOutNPC = 130;

		// Token: 0x04005227 RID: 21031
		[global::Cpp2ILInjected.Token(Token = "0x40064CF")]
		public const byte TamperWithNPC = 131;

		// Token: 0x04005228 RID: 21032
		[global::Cpp2ILInjected.Token(Token = "0x40064D0")]
		public const byte PlayLegacySound = 132;

		// Token: 0x04005229 RID: 21033
		[global::Cpp2ILInjected.Token(Token = "0x40064D1")]
		public const byte FoodPlatterTryPlacing = 133;

		// Token: 0x0400522A RID: 21034
		[global::Cpp2ILInjected.Token(Token = "0x40064D2")]
		public const byte UpdatePlayerLuckFactors = 134;

		// Token: 0x0400522B RID: 21035
		[global::Cpp2ILInjected.Token(Token = "0x40064D3")]
		public const byte DeadPlayer = 135;

		// Token: 0x0400522C RID: 21036
		[global::Cpp2ILInjected.Token(Token = "0x40064D4")]
		public const byte SyncCavernMonsterType = 136;

		// Token: 0x0400522D RID: 21037
		[global::Cpp2ILInjected.Token(Token = "0x40064D5")]
		public const byte RequestNPCBuffRemoval = 137;

		// Token: 0x0400522E RID: 21038
		[global::Cpp2ILInjected.Token(Token = "0x40064D6")]
		public const byte ClientSyncedInventory = 138;

		// Token: 0x0400522F RID: 21039
		[global::Cpp2ILInjected.Token(Token = "0x40064D7")]
		public const byte SetCountsAsHostForGameplay = 139;

		// Token: 0x04005230 RID: 21040
		[global::Cpp2ILInjected.Token(Token = "0x40064D8")]
		public const byte SetMiscEventValues = 140;

		// Token: 0x04005231 RID: 21041
		[global::Cpp2ILInjected.Token(Token = "0x40064D9")]
		public const byte RequestLucyPopup = 141;

		// Token: 0x04005232 RID: 21042
		[global::Cpp2ILInjected.Token(Token = "0x40064DA")]
		public const byte SyncProjectileTrackers = 142;

		// Token: 0x04005233 RID: 21043
		[global::Cpp2ILInjected.Token(Token = "0x40064DB")]
		public const byte CrystalInvasionRequestedToSkipWaitTime = 143;

		// Token: 0x04005234 RID: 21044
		[global::Cpp2ILInjected.Token(Token = "0x40064DC")]
		public const byte RequestQuestEffect = 144;

		// Token: 0x04005235 RID: 21045
		[global::Cpp2ILInjected.Token(Token = "0x40064DD")]
		public const byte SyncItemsWithShimmer = 145;

		// Token: 0x04005236 RID: 21046
		[global::Cpp2ILInjected.Token(Token = "0x40064DE")]
		public const byte ShimmerActions = 146;

		// Token: 0x04005237 RID: 21047
		[global::Cpp2ILInjected.Token(Token = "0x40064DF")]
		public const byte SyncLoadout = 147;

		// Token: 0x04005238 RID: 21048
		[global::Cpp2ILInjected.Token(Token = "0x40064E0")]
		public const byte SyncItemCannotBeTakenByEnemies = 148;

		// Token: 0x04005239 RID: 21049
		[global::Cpp2ILInjected.Token(Token = "0x40064E1")]
		public const byte ServerInfo = 149;

		// Token: 0x0400523A RID: 21050
		[global::Cpp2ILInjected.Token(Token = "0x40064E2")]
		public const byte PlayerPlatformInfo = 150;

		// Token: 0x0400523B RID: 21051
		[global::Cpp2ILInjected.Token(Token = "0x40064E3")]
		public const byte Count = 151;
	}
}
