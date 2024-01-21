using System;
using Cpp2IlInjected;

namespace DataPlatform;

[Cpp2IlInjected.Token(Token = "0x2000255")]
public class Events
{
	[Cpp2IlInjected.Token(Token = "0x600111D")]
	[Cpp2IlInjected.Address(RVA = "0x20C91B4", Offset = "0x20C91B4", VA = "0x20C91B4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D634", Offset = "0x38D634")]
	public static void SendEnemyDefeated(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, ref Guid RoundId, int PlayerRoleId, int PlayerWeaponId, int EnemyRoleId, int KillTypeId, float LocationX, float LocationY, float LocationZ, int EnemyWeaponId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600111E")]
	[Cpp2IlInjected.Address(RVA = "0x20C91B8", Offset = "0x20C91B8", VA = "0x20C91B8")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D668", Offset = "0x38D668")]
	public static void SendGameProgress(string UserId, ref Guid PlayerSessionId, float CompletionPercent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600111F")]
	[Cpp2IlInjected.Address(RVA = "0x20C91BC", Offset = "0x20C91BC", VA = "0x20C91BC")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D69C", Offset = "0x38D69C")]
	public static void SendIncCrafting(string UserId, ref Guid PlayerSessionId, string CraftingId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001120")]
	[Cpp2IlInjected.Address(RVA = "0x20C91C0", Offset = "0x20C91C0", VA = "0x20C91C0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D6D0", Offset = "0x38D6D0")]
	public static void SendIncDistance(string UserId, ref Guid PlayerSessionId, string DistanceId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001121")]
	[Cpp2IlInjected.Address(RVA = "0x20C91C4", Offset = "0x20C91C4", VA = "0x20C91C4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D704", Offset = "0x38D704")]
	public static void SendIncHardBoss(string UserId, ref Guid PlayerSessionId, string BossId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001122")]
	[Cpp2IlInjected.Address(RVA = "0x20C91C8", Offset = "0x20C91C8", VA = "0x20C91C8")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D738", Offset = "0x38D738")]
	public static void SendIncMining(string UserId, ref Guid PlayerSessionId, string MiningId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001123")]
	[Cpp2IlInjected.Address(RVA = "0x20C91CC", Offset = "0x20C91CC", VA = "0x20C91CC")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D76C", Offset = "0x38D76C")]
	public static void SendIncNormalBoss(string UserId, ref Guid PlayerSessionId, string BossId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001124")]
	[Cpp2IlInjected.Address(RVA = "0x20C91D0", Offset = "0x20C91D0", VA = "0x20C91D0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D7A0", Offset = "0x38D7A0")]
	public static void SendIncStat(string UserId, ref Guid PlayerSessionId, string StatId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001125")]
	[Cpp2IlInjected.Address(RVA = "0x20C91D4", Offset = "0x20C91D4", VA = "0x20C91D4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D7D4", Offset = "0x38D7D4")]
	public static void SendIncTrigger(string UserId, ref Guid PlayerSessionId, string TrigId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001126")]
	[Cpp2IlInjected.Address(RVA = "0x20C91D8", Offset = "0x20C91D8", VA = "0x20C91D8")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D808", Offset = "0x38D808")]
	public static void SendItemAcquired(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ItemId, int AcquisitionMethodId, float LocationX, float LocationY, float LocationZ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001127")]
	[Cpp2IlInjected.Address(RVA = "0x20C91DC", Offset = "0x20C91DC", VA = "0x20C91DC")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D83C", Offset = "0x38D83C")]
	public static void SendItemUsed(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ItemId, float LocationX, float LocationY, float LocationZ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001128")]
	[Cpp2IlInjected.Address(RVA = "0x20C91E0", Offset = "0x20C91E0", VA = "0x20C91E0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D870", Offset = "0x38D870")]
	public static void SendMediaUsage(string AppSessionId, string AppSessionStartDateTime, uint UserIdType, string UserId, string SubscriptionTierType, string SubscriptionTier, string MediaType, string ProviderId, string ProviderMediaId, string ProviderMediaInstanceId, ref Guid BingId, ulong MediaLengthMs, uint MediaControlAction, float PlaybackSpeed, ulong MediaPositionMs, ulong PlaybackDurationMs, string AcquisitionType, string AcquisitionContext, string AcquisitionContextType, string AcquisitionContextId, int PlaybackIsStream, int PlaybackIsTethered, string MarketplaceLocation, string ContentLocale, float TimeZoneOffset, uint ScreenState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001129")]
	[Cpp2IlInjected.Address(RVA = "0x20C91E4", Offset = "0x20C91E4", VA = "0x20C91E4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D8A4", Offset = "0x38D8A4")]
	public static void SendMultiplayerRoundEnd(string UserId, ref Guid RoundId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int MatchTypeId, int DifficultyLevelId, float TimeInSeconds, int ExitStatusId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600112A")]
	[Cpp2IlInjected.Address(RVA = "0x20C91E8", Offset = "0x20C91E8", VA = "0x20C91E8")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D8D8", Offset = "0x38D8D8")]
	public static void SendMultiplayerRoundStart(string UserId, ref Guid RoundId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int MatchTypeId, int DifficultyLevelId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600112B")]
	[Cpp2IlInjected.Address(RVA = "0x20C91EC", Offset = "0x20C91EC", VA = "0x20C91EC")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D90C", Offset = "0x38D90C")]
	public static void SendObjectiveEnd(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ObjectiveId, int ExitStatusId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600112C")]
	[Cpp2IlInjected.Address(RVA = "0x20C91F0", Offset = "0x20C91F0", VA = "0x20C91F0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D940", Offset = "0x38D940")]
	public static void SendObjectiveStart(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ObjectiveId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600112D")]
	[Cpp2IlInjected.Address(RVA = "0x20C91F4", Offset = "0x20C91F4", VA = "0x20C91F4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D974", Offset = "0x38D974")]
	public static void SendPageAction(string UserId, ref Guid PlayerSessionId, int ActionTypeId, int ActionInputMethodId, string Page, string TemplateId, string DestinationPage, string Content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600112E")]
	[Cpp2IlInjected.Address(RVA = "0x20C91F8", Offset = "0x20C91F8", VA = "0x20C91F8")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D9A8", Offset = "0x38D9A8")]
	public static void SendPageView(string UserId, ref Guid PlayerSessionId, string Page, string RefererPage, int PageTypeId, string PageTags, string TemplateId, string Content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600112F")]
	[Cpp2IlInjected.Address(RVA = "0x20C91FC", Offset = "0x20C91FC", VA = "0x20C91FC")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D9DC", Offset = "0x38D9DC")]
	public static void SendPlayerDefeated(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, ref Guid RoundId, int PlayerRoleId, int PlayerWeaponId, int EnemyRoleId, int EnemyWeaponId, float LocationX, float LocationY, float LocationZ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001130")]
	[Cpp2IlInjected.Address(RVA = "0x20C9200", Offset = "0x20C9200", VA = "0x20C9200")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38DA10", Offset = "0x38DA10")]
	public static void SendPlayerSessionEnd(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ExitStatusId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001131")]
	[Cpp2IlInjected.Address(RVA = "0x20C9204", Offset = "0x20C9204", VA = "0x20C9204")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38DA44", Offset = "0x38DA44")]
	public static void SendPlayerSessionPause(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001132")]
	[Cpp2IlInjected.Address(RVA = "0x20C9208", Offset = "0x20C9208", VA = "0x20C9208")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38DA78", Offset = "0x38DA78")]
	public static void SendPlayerSessionResume(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001133")]
	[Cpp2IlInjected.Address(RVA = "0x20C920C", Offset = "0x20C920C", VA = "0x20C920C")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38DAAC", Offset = "0x38DAAC")]
	public static void SendPlayerSessionStart(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001134")]
	[Cpp2IlInjected.Address(RVA = "0x20C9210", Offset = "0x20C9210", VA = "0x20C9210")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38DAE0", Offset = "0x38DAE0")]
	public static void SendPlayerSpawned(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, ref Guid RoundId, int PlayerRoleId, float LocationX, float LocationY, float LocationZ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001135")]
	[Cpp2IlInjected.Address(RVA = "0x20C9214", Offset = "0x20C9214", VA = "0x20C9214")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38DB14", Offset = "0x38DB14")]
	public static void SendPuzzleSolved(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, float TimeInSeconds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001136")]
	[Cpp2IlInjected.Address(RVA = "0x20C9218", Offset = "0x20C9218", VA = "0x20C9218")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38DB48", Offset = "0x38DB48")]
	public static void SendSectionEnd(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ExitStatusId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001137")]
	[Cpp2IlInjected.Address(RVA = "0x20C921C", Offset = "0x20C921C", VA = "0x20C921C")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38DB7C", Offset = "0x38DB7C")]
	public static void SendSectionStart(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001138")]
	[Cpp2IlInjected.Address(RVA = "0x20C9220", Offset = "0x20C9220", VA = "0x20C9220")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38DBB0", Offset = "0x38DBB0")]
	public static void SendViewOffer(string UserId, ref Guid PlayerSessionId, ref Guid OfferGuid, ref Guid ProductGuid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001139")]
	[Cpp2IlInjected.Address(RVA = "0x20C9224", Offset = "0x20C9224", VA = "0x20C9224")]
	public Events()
	{
	}
}
