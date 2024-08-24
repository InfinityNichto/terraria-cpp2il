using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;

// Token: 0x02000216 RID: 534
[JsonObject(MemberSerialization.Fields)]
[global::Cpp2ILInjected.Token(Token = "0x20002BD")]
public class PersistentUserData
{
	// Token: 0x06000F08 RID: 3848 RVA: 0x00024815 File Offset: 0x00022A15
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

	// Token: 0x06000F09 RID: 3849 RVA: 0x00024818 File Offset: 0x00022A18
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

	// Token: 0x06000F0A RID: 3850 RVA: 0x0002481B File Offset: 0x00022A1B
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

	// Token: 0x06000F0B RID: 3851 RVA: 0x0002481E File Offset: 0x00022A1E
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

	// Token: 0x06000F0C RID: 3852 RVA: 0x00024821 File Offset: 0x00022A21
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

	// Token: 0x06000F0D RID: 3853 RVA: 0x00024824 File Offset: 0x00022A24
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

	// Token: 0x06000F0E RID: 3854 RVA: 0x00024827 File Offset: 0x00022A27
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

	// Token: 0x06000F0F RID: 3855 RVA: 0x0002482A File Offset: 0x00022A2A
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

	// Token: 0x06000F10 RID: 3856 RVA: 0x0002482D File Offset: 0x00022A2D
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

	// Token: 0x040019F1 RID: 6641
	[global::Cpp2ILInjected.Token(Token = "0x4001F1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public uint TotalBarsCrafted;

	// Token: 0x040019F2 RID: 6642
	[global::Cpp2ILInjected.Token(Token = "0x4001F20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public uint TotalPicked;

	// Token: 0x040019F3 RID: 6643
	[global::Cpp2ILInjected.Token(Token = "0x4001F21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public uint TotalAnvilCrafting;

	// Token: 0x040019F4 RID: 6644
	[global::Cpp2ILInjected.Token(Token = "0x4001F22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public uint TotalWires;

	// Token: 0x040019F5 RID: 6645
	[global::Cpp2ILInjected.Token(Token = "0x4001F23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public uint TotalAirTime;

	// Token: 0x040019F6 RID: 6646
	[global::Cpp2ILInjected.Token(Token = "0x4001F24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public uint CurrentAirTime;

	// Token: 0x040019F7 RID: 6647
	[global::Cpp2ILInjected.Token(Token = "0x4001F25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public IntHashSet ArmorCollected;

	// Token: 0x040019F8 RID: 6648
	[global::Cpp2ILInjected.Token(Token = "0x4001F26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public IntHashSet CraftingsStationsUsed;

	// Token: 0x040019F9 RID: 6649
	[global::Cpp2ILInjected.Token(Token = "0x4001F27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public IntHashSet SlimeTypesKilled;

	// Token: 0x040019FA RID: 6650
	[global::Cpp2ILInjected.Token(Token = "0x4001F28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public IntHashSet PetBuffsSpawned;

	// Token: 0x040019FB RID: 6651
	[global::Cpp2ILInjected.Token(Token = "0x4001F29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Dictionary<int, int> BossesKilled;

	// Token: 0x040019FC RID: 6652
	[global::Cpp2ILInjected.Token(Token = "0x4001F2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public long TotalGemsMined;

	// Token: 0x040019FD RID: 6653
	[global::Cpp2ILInjected.Token(Token = "0x4001F2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public long TotalOresMined;

	// Token: 0x040019FE RID: 6654
	[global::Cpp2ILInjected.Token(Token = "0x4001F2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public long TotalSoilMined;

	// Token: 0x040019FF RID: 6655
	[global::Cpp2ILInjected.Token(Token = "0x4001F2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public long TotalWoodMined;

	// Token: 0x04001A00 RID: 6656
	[global::Cpp2ILInjected.Token(Token = "0x4001F2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public long TotalResourcesMined;
}
