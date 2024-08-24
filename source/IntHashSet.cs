using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

// Token: 0x02000215 RID: 533
[global::Cpp2ILInjected.Token(Token = "0x20002BC")]
public class IntHashSet
{
	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00024800 File Offset: 0x00022A00
	// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00024803 File Offset: 0x00022A03
	[global::Cpp2ILInjected.Token(Token = "0x17000192")]
	public List<int> Values
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001034")]
		[global::Cpp2ILInjected.Address(RVA = "0xA409C4", Offset = "0xA409C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6001035")]
		[global::Cpp2ILInjected.Address(RVA = "0xA409CC", Offset = "0xA409CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x00024806 File Offset: 0x00022A06
	[global::Cpp2ILInjected.Token(Token = "0x6001036")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39F30", Offset = "0xA39F30", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteSlimeDefeatedForPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(eSlimeKillStatistics)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteItemPickedUpForPlayer", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformAwardNotifierUtility), Member = "NoteCraftingStationUsed", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CheckForPetAchievement", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntHashSet), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Add(int valueToAdd)
	{
		throw null;
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x00024809 File Offset: 0x00022A09
	[global::Cpp2ILInjected.Token(Token = "0x6001037")]
	[global::Cpp2ILInjected.Address(RVA = "0xA409D4", Offset = "0xA409D4", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IntHashSet), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IntHashSet), Member = "ContainsSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentUserData), Member = "GetNumberOfRequiredSlimesKilled", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool Contains(int valueToCheck)
	{
		throw null;
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x0002480C File Offset: 0x00022A0C
	[global::Cpp2ILInjected.Token(Token = "0x6001038")]
	[global::Cpp2ILInjected.Address(RVA = "0xA40A84", Offset = "0xA40A84", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntHashSet), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	public bool ContainsSet(int[] values)
	{
		throw null;
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0002480F File Offset: 0x00022A0F
	[global::Cpp2ILInjected.Token(Token = "0x17000193")]
	public int Count
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001039")]
		[global::Cpp2ILInjected.Address(RVA = "0xA3ACA8", Offset = "0xA3ACA8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CheckForPetAchievement", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00024812 File Offset: 0x00022A12
	[global::Cpp2ILInjected.Token(Token = "0x600103A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA40AE8", Offset = "0xA40AE8", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentUserData), Member = "EnsureObjects", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentUserData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public IntHashSet()
	{
		throw null;
	}

	// Token: 0x040019F0 RID: 6640
	[global::Cpp2ILInjected.Token(Token = "0x4001F1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private List<int> ValuesInSet;
}
