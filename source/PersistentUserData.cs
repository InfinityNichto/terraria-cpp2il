using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;

[JsonObject(MemberSerialization.Fields)]
[global::Cpp2ILInjected.Token(Token = "0x20002BD")]
public class PersistentUserData
{
	[global::Cpp2ILInjected.Token(Token = "0x600103B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3FD20", Offset = "0xA3FD20", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "LoadPersistantData", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntHashSet), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void EnsureObjects()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600103C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3A660", Offset = "0xA3A660", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteBossKillForAllLocalUsers", MemberParameters = new object[] { typeof(eBossKillStatistics) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Add", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void OnKillBoss(eBossKillStatistics bossID)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600103D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA40B64", Offset = "0xA40B64", Length = "0x3E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Array))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public int GetProgressNumberOfTimesKilledAllBosses()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600103E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA40F4C", Offset = "0xA40F4C", Length = "0x3A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Array))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public int GetNormlBossCount()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600103F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA412F0", Offset = "0xA412F0", Length = "0x3AC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Array))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public int GetHardBossCount()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001040")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4169C", Offset = "0xA4169C", Length = "0x3B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Array))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public int GetNumberOfTimesKilledAllBosses()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001041")]
	[global::Cpp2ILInjected.Address(RVA = "0xA41A50", Offset = "0xA41A50", Length = "0x150")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public int GetNumberOfTimesKilledPrimeBosses()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001042")]
	[global::Cpp2ILInjected.Address(RVA = "0xA41BA0", Offset = "0xA41BA0", Length = "0x360")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Array))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntHashSet), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public int GetNumberOfRequiredSlimesKilled()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001043")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3D8F0", Offset = "0xA3D8F0", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "LoadPersistantData", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntHashSet), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public PersistentUserData()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001F1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public uint TotalBarsCrafted;

	[global::Cpp2ILInjected.Token(Token = "0x4001F20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public uint TotalPicked;

	[global::Cpp2ILInjected.Token(Token = "0x4001F21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public uint TotalAnvilCrafting;

	[global::Cpp2ILInjected.Token(Token = "0x4001F22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public uint TotalWires;

	[global::Cpp2ILInjected.Token(Token = "0x4001F23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public uint TotalAirTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001F24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public uint CurrentAirTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001F25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public IntHashSet ArmorCollected;

	[global::Cpp2ILInjected.Token(Token = "0x4001F26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public IntHashSet CraftingsStationsUsed;

	[global::Cpp2ILInjected.Token(Token = "0x4001F27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public IntHashSet SlimeTypesKilled;

	[global::Cpp2ILInjected.Token(Token = "0x4001F28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public IntHashSet PetBuffsSpawned;

	[global::Cpp2ILInjected.Token(Token = "0x4001F29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Dictionary<int, int> BossesKilled;

	[global::Cpp2ILInjected.Token(Token = "0x4001F2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public long TotalGemsMined;

	[global::Cpp2ILInjected.Token(Token = "0x4001F2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public long TotalOresMined;

	[global::Cpp2ILInjected.Token(Token = "0x4001F2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public long TotalSoilMined;

	[global::Cpp2ILInjected.Token(Token = "0x4001F2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public long TotalWoodMined;

	[global::Cpp2ILInjected.Token(Token = "0x4001F2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public long TotalResourcesMined;
}
