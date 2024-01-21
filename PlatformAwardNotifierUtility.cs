using Cpp2IlInjected;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x2000209")]
public class PlatformAwardNotifierUtility
{
	[Cpp2IlInjected.Token(Token = "0x400185D")]
	public static int[] AchievementArmors;

	[Cpp2IlInjected.Token(Token = "0x400185E")]
	public static int[] AchievementCraftingStationsTracking;

	[Cpp2IlInjected.Token(Token = "0x6000EAA")]
	[Cpp2IlInjected.Address(RVA = "0x10B4D38", Offset = "0x10B4D38", VA = "0x10B4D38")]
	public static void NoteSlimeDefeatedForPlayer(Player player, eSlimeKillStatistics slimeID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EAB")]
	[Cpp2IlInjected.Address(RVA = "0x10B4E64", Offset = "0x10B4E64", VA = "0x10B4E64")]
	public static void NoteItemCraftedForPlayer(Player player, eCraftingStatistics craftingID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EAC")]
	[Cpp2IlInjected.Address(RVA = "0x10B4F74", Offset = "0x10B4F74", VA = "0x10B4F74")]
	public static void NoteTraveledForPlayer(Player player, eDistanceStatistics distanceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EAD")]
	[Cpp2IlInjected.Address(RVA = "0x10B5084", Offset = "0x10B5084", VA = "0x10B5084")]
	public static void NoteMinedForPlayer(Player player, eMiningStatistics miningID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EAE")]
	[Cpp2IlInjected.Address(RVA = "0x10B5240", Offset = "0x10B5240", VA = "0x10B5240")]
	public static void NoteTriggerForPlayer(Player player, eTrigger triggerType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EAF")]
	[Cpp2IlInjected.Address(RVA = "0x10B5350", Offset = "0x10B5350", VA = "0x10B5350")]
	public static void NoteBossKillForAllLocalUsers(eBossKillStatistics bossID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EB0")]
	[Cpp2IlInjected.Address(RVA = "0x10B5590", Offset = "0x10B5590", VA = "0x10B5590")]
	public static void NoteTriggerForAllLocalUsers(eTrigger triggerType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EB1")]
	[Cpp2IlInjected.Address(RVA = "0x10B57BC", Offset = "0x10B57BC", VA = "0x10B57BC")]
	public static void NoteItemPickedUpForPlayer(Player player, int itemID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EB2")]
	[Cpp2IlInjected.Address(RVA = "0x10B5B14", Offset = "0x10B5B14", VA = "0x10B5B14")]
	public static bool IsArmorForAchievement(int itemID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000EB3")]
	[Cpp2IlInjected.Address(RVA = "0x10B5BB8", Offset = "0x10B5BB8", VA = "0x10B5BB8")]
	public static void NoteCraftingStationUsed(Player player, int tileID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EB4")]
	[Cpp2IlInjected.Address(RVA = "0x10B5D64", Offset = "0x10B5D64", VA = "0x10B5D64")]
	public static int GetAchievementIDFromTileID(int tileID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000EB5")]
	[Cpp2IlInjected.Address(RVA = "0x10B5E2C", Offset = "0x10B5E2C", VA = "0x10B5E2C")]
	public static eSlimeKillStatistics GetSlimeStatIDFromNetID(int netID)
	{
		return default(eSlimeKillStatistics);
	}

	[Cpp2IlInjected.Token(Token = "0x6000EB6")]
	[Cpp2IlInjected.Address(RVA = "0x10B5F9C", Offset = "0x10B5F9C", VA = "0x10B5F9C")]
	public static eBossKillStatistics GetBossStatIDFromNetID(int netID)
	{
		return default(eBossKillStatistics);
	}

	[Cpp2IlInjected.Token(Token = "0x6000EB7")]
	[Cpp2IlInjected.Address(RVA = "0x10B6134", Offset = "0x10B6134", VA = "0x10B6134")]
	public static void RegisterKillTileStatistic(Player player, int tileType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EB8")]
	[Cpp2IlInjected.Address(RVA = "0x10B6480", Offset = "0x10B6480", VA = "0x10B6480")]
	public PlatformAwardNotifierUtility()
	{
	}
}
