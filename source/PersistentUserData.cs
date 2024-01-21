using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json;

[Cpp2IlInjected.Token(Token = "0x2000217")]
[JsonObject]
public class PersistentUserData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40019FA")]
	public uint TotalBarsCrafted;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40019FB")]
	public uint TotalPicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40019FC")]
	public uint TotalAnvilCrafting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40019FD")]
	public uint TotalWires;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40019FE")]
	public uint TotalAirTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40019FF")]
	public uint CurrentAirTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001A00")]
	public IntHashSet ArmorCollected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001A01")]
	public IntHashSet CraftingsStationsUsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001A02")]
	public IntHashSet SlimeTypesKilled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001A03")]
	public IntHashSet PetBuffsSpawned;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001A04")]
	public Dictionary<int, int> BossesKilled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001A05")]
	public long TotalGemsMined;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001A06")]
	public long TotalOresMined;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001A07")]
	public long TotalSoilMined;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001A08")]
	public long TotalWoodMined;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001A09")]
	public long TotalResourcesMined;

	[Cpp2IlInjected.Token(Token = "0x6000F1D")]
	[Cpp2IlInjected.Address(RVA = "0x10B36C4", Offset = "0x10B36C4", VA = "0x10B36C4")]
	public void EnsureObjects()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F1E")]
	[Cpp2IlInjected.Address(RVA = "0x10B3808", Offset = "0x10B3808", VA = "0x10B3808")]
	public void OnKillBoss(eBossKillStatistics bossID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F1F")]
	[Cpp2IlInjected.Address(RVA = "0x10B38D8", Offset = "0x10B38D8", VA = "0x10B38D8")]
	public int GetProgressNumberOfTimesKilledAllBosses()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F20")]
	[Cpp2IlInjected.Address(RVA = "0x10B3C58", Offset = "0x10B3C58", VA = "0x10B3C58")]
	public int GetNormlBossCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F21")]
	[Cpp2IlInjected.Address(RVA = "0x10B3F9C", Offset = "0x10B3F9C", VA = "0x10B3F9C")]
	public int GetHardBossCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F22")]
	[Cpp2IlInjected.Address(RVA = "0x10B4308", Offset = "0x10B4308", VA = "0x10B4308")]
	public int GetNumberOfTimesKilledAllBosses()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F23")]
	[Cpp2IlInjected.Address(RVA = "0x10B469C", Offset = "0x10B469C", VA = "0x10B469C")]
	public int GetNumberOfTimesKilledPrimeBosses()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F24")]
	[Cpp2IlInjected.Address(RVA = "0x10B47FC", Offset = "0x10B47FC", VA = "0x10B47FC")]
	public int GetNumberOfRequiredSlimesKilled()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F25")]
	[Cpp2IlInjected.Address(RVA = "0x10B4AFC", Offset = "0x10B4AFC", VA = "0x10B4AFC")]
	public PersistentUserData()
	{
	}
}
