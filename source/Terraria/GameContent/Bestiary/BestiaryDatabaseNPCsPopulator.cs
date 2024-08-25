using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x200091A")]
	public class BestiaryDatabaseNPCsPopulator
	{
		[global::Cpp2ILInjected.Token(Token = "0x60046E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E4034", Offset = "0x7E4034", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BestiaryDatabaseNPCsPopulator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E403C", Offset = "0x7E403C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		private BestiaryEntry FindEntryByNPCID(int npcNetId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E4048", Offset = "0x7E4048", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(BestiaryEntry))]
		private BestiaryEntry Register(BestiaryEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E4054", Offset = "0x7E4054", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(IBestiaryEntryFilter) }, ReturnType = typeof(IBestiaryEntryFilter))]
		private IBestiaryEntryFilter Register(IBestiaryEntryFilter filter)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E4060", Offset = "0x7E4060", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddEmptyEntries_CrittersAndEnemies_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddTownNPCs_Manual", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddNPCBiomeRelationships_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddNPCBiomeRelationships_Manual", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddNPCBiomeRelationships_AddDecorations_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
		public void Populate(BestiaryDatabase database)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FA988", Offset = "0x7FA988", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = "Biome", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Func<bool>)
		}, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void RegisterTestEntries()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FA3A0", Offset = "0x7FA3A0", Length = "0x5E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Populate", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByUnlockState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByBestiarySortingId), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.Alphabetical), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByNetId), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByAttack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByDefense), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByCoins), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByHP), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByBestiaryRarity), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(IBestiarySortStep) }, ReturnType = typeof(IBestiarySortStep))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private void RegisterSortSteps()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FA21C", Offset = "0x7FA21C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Populate", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Filters.ByUnlockState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(IBestiaryEntryFilter) }, ReturnType = typeof(IBestiaryEntryFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Filters.ByBoss), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Filters.ByRareCreature), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator.CommonTags), Member = "GetCommonInfoElementsForFilters", ReturnType = typeof(List<IBestiaryInfoElement>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Filters.ByInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(IBestiaryInfoElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void RegisterFilters()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FAA54", Offset = "0x7FAA54", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamePlateInfoElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnlockableNPCEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void ModifyEntriesThatNeedIt_NameOverride(int npcID, string newNameKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7F68D0", Offset = "0x7F68D0", Length = "0x394C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Populate", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryPortraitBackgroundProviderPreferenceInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(IBestiaryBackgroundImagePathAndColorProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = "AddTags", MemberParameters = new object[] { typeof(IBestiaryInfoElement[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IBestiaryBackgroundImagePathAndColorProvider),
			typeof(IBestiaryBackgroundImagePathAndColorProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase.BestiaryEntriesPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "ApplyPass", MemberParameters = new object[] { typeof(BestiaryDatabase.BestiaryEntriesPass) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonLordPortraitBackgroundProviderBestiaryInfoElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamePlateInfoElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnlockableNPCEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt_NameOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SalamanderShellyDadUICollectionInfoProvider), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonEnemyUICollectionInfoProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCUICollectionInfoProvider), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HighestOfMultipleUICollectionInfoProvider), Member = ".ctor", MemberParameters = new object[] { typeof(IBestiaryUICollectionInfoProvider[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCStatsReportInfoElement.StatAdjustmentStep), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCStatsReportInfoElement), Member = "add_OnRefreshStats", MemberParameters = new object[] { typeof(NPCStatsReportInfoElement.StatAdjustmentStep) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GoldCritterUICollectionInfoProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CritterUICollectionInfoProvider), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SearchAliasInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 364)]
		private void ModifyEntriesThatNeedIt()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FAC60", Offset = "0x7FAC60", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GameMode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetEaterOfWorldsSegmentsCountByGamemode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void AdjustEaterOfWorldStats(NPCStatsReportInfoElement element)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FACFC", Offset = "0x7FACFC", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void AdjustPirateShipStats(NPCStatsReportInfoElement element)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FAE48", Offset = "0x7FAE48", Length = "0x430")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlavorTextBestiaryInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private void TryGivingEntryFlavorTextIfItIsMissing(BestiaryEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E42E4", Offset = "0x7E42E4", Length = "0x50C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Populate", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = "TownNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(BestiaryEntry))]
		private void AddTownNPCs_Manual()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FB278", Offset = "0x7FB278", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = "Enemy", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnlockableNPCEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddMultiEntryNPCS_Manual()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E40AC", Offset = "0x7E40AC", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Populate", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "GetExclusions", ReturnType = typeof(HashSet<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_isLikeATownNPC", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_CountsAsACritter", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = "Critter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = "Enemy", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void AddEmptyEntries_CrittersAndEnemies_Automated()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FB310", Offset = "0x7FB310", Length = "0x398")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddEmptyEntries_CrittersAndEnemies_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static HashSet<int> GetExclusions()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E47F0", Offset = "0x7E47F0", Length = "0xDDE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Populate", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1250)]
		private void AddNPCBiomeRelationships_Automated()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7F25D4", Offset = "0x7F25D4", Length = "0x3AFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Populate", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 329)]
		private void AddNPCBiomeRelationships_Manual()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7F60D0", Offset = "0x7F60D0", Length = "0x800")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Populate", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = "AddTags", MemberParameters = new object[] { typeof(IBestiaryInfoElement[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 72)]
		private void AddNPCBiomeRelationships_AddDecorations_Automated()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7FB6A8", Offset = "0x7FB6A8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddDropOverrides(BestiaryDatabase bestiaryDatabase)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40082BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BestiaryDatabase _currentDatabase;

		[global::Cpp2ILInjected.Token(Token = "0x200091B")]
		public static class CommonTags
		{
			[global::Cpp2ILInjected.Token(Token = "0x60046FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x810590", Offset = "0x810590", Length = "0x14D8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.BestiaryHelper), Member = "GetSortedBestiaryEntriesList", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(List<KeyValuePair<int, NPC>>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public static List<IBestiaryInfoElement> GetCommonInfoElementsForFilters()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x200091C")]
			public static class SpawnConditions
			{
				[global::Cpp2ILInjected.Token(Token = "0x200091D")]
				public static class Invasions
				{
					// Note: this type is marked as 'beforefieldinit'.
					[global::Cpp2ILInjected.Token(Token = "0x60046FD")]
					[global::Cpp2ILInjected.Address(RVA = "0x811A68", Offset = "0x811A68", Length = "0x3E4")]
					[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
					{
						typeof(int),
						typeof(int),
						typeof(int)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
					static Invasions()
					{
						throw null;
					}

					[global::Cpp2ILInjected.Token(Token = "0x40082BE")]
					public static SpawnConditionBestiaryInfoElement Goblins;

					[global::Cpp2ILInjected.Token(Token = "0x40082BF")]
					public static SpawnConditionBestiaryInfoElement Pirates;

					[global::Cpp2ILInjected.Token(Token = "0x40082C0")]
					public static SpawnConditionBestiaryInfoElement Martian;

					[global::Cpp2ILInjected.Token(Token = "0x40082C1")]
					public static SpawnConditionBestiaryInfoElement OldOnesArmy;

					[global::Cpp2ILInjected.Token(Token = "0x40082C2")]
					public static SpawnConditionBestiaryInfoElement PumpkinMoon;

					[global::Cpp2ILInjected.Token(Token = "0x40082C3")]
					public static SpawnConditionBestiaryInfoElement FrostMoon;

					[global::Cpp2ILInjected.Token(Token = "0x40082C4")]
					public static SpawnConditionBestiaryInfoElement FrostLegion;
				}

				[global::Cpp2ILInjected.Token(Token = "0x200091E")]
				public static class Events
				{
					// Note: this type is marked as 'beforefieldinit'.
					[global::Cpp2ILInjected.Token(Token = "0x60046FE")]
					[global::Cpp2ILInjected.Address(RVA = "0x811EB4", Offset = "0x811EB4", Length = "0x588")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
					{
						typeof(int),
						typeof(int),
						typeof(int)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
					static Events()
					{
						throw null;
					}

					[global::Cpp2ILInjected.Token(Token = "0x40082C5")]
					public static SpawnConditionBestiaryInfoElement SlimeRain;

					[global::Cpp2ILInjected.Token(Token = "0x40082C6")]
					public static SpawnConditionBestiaryInfoElement WindyDay;

					[global::Cpp2ILInjected.Token(Token = "0x40082C7")]
					public static SpawnConditionBestiaryInfoElement BloodMoon;

					[global::Cpp2ILInjected.Token(Token = "0x40082C8")]
					public static SpawnConditionBestiaryInfoElement Halloween;

					[global::Cpp2ILInjected.Token(Token = "0x40082C9")]
					public static SpawnConditionBestiaryOverlayInfoElement Rain;

					[global::Cpp2ILInjected.Token(Token = "0x40082CA")]
					public static SpawnConditionBestiaryInfoElement Christmas;

					[global::Cpp2ILInjected.Token(Token = "0x40082CB")]
					public static SpawnConditionBestiaryInfoElement Eclipse;

					[global::Cpp2ILInjected.Token(Token = "0x40082CC")]
					public static SpawnConditionBestiaryInfoElement Party;

					[global::Cpp2ILInjected.Token(Token = "0x40082CD")]
					public static SpawnConditionBestiaryOverlayInfoElement Blizzard;

					[global::Cpp2ILInjected.Token(Token = "0x40082CE")]
					public static SpawnConditionBestiaryOverlayInfoElement Sandstorm;
				}

				[global::Cpp2ILInjected.Token(Token = "0x200091F")]
				public static class Biomes
				{
					// Note: this type is marked as 'beforefieldinit'.
					[global::Cpp2ILInjected.Token(Token = "0x60046FF")]
					[global::Cpp2ILInjected.Address(RVA = "0x8124A4", Offset = "0x8124A4", Length = "0x1340")]
					[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
					{
						typeof(int),
						typeof(int),
						typeof(int)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 124)]
					static Biomes()
					{
						throw null;
					}

					[global::Cpp2ILInjected.Token(Token = "0x40082CF")]
					public static SpawnConditionBestiaryInfoElement TheCorruption;

					[global::Cpp2ILInjected.Token(Token = "0x40082D0")]
					public static SpawnConditionBestiaryInfoElement TheCrimson;

					[global::Cpp2ILInjected.Token(Token = "0x40082D1")]
					public static SpawnConditionBestiaryInfoElement Surface;

					[global::Cpp2ILInjected.Token(Token = "0x40082D2")]
					public static SpawnConditionBestiaryInfoElement Graveyard;

					[global::Cpp2ILInjected.Token(Token = "0x40082D3")]
					public static SpawnConditionBestiaryInfoElement UndergroundJungle;

					[global::Cpp2ILInjected.Token(Token = "0x40082D4")]
					public static SpawnConditionBestiaryInfoElement TheUnderworld;

					[global::Cpp2ILInjected.Token(Token = "0x40082D5")]
					public static SpawnConditionBestiaryInfoElement TheDungeon;

					[global::Cpp2ILInjected.Token(Token = "0x40082D6")]
					public static SpawnConditionBestiaryInfoElement Underground;

					[global::Cpp2ILInjected.Token(Token = "0x40082D7")]
					public static SpawnConditionBestiaryInfoElement TheHallow;

					[global::Cpp2ILInjected.Token(Token = "0x40082D8")]
					public static SpawnConditionBestiaryInfoElement UndergroundMushroom;

					[global::Cpp2ILInjected.Token(Token = "0x40082D9")]
					public static SpawnConditionBestiaryInfoElement Jungle;

					[global::Cpp2ILInjected.Token(Token = "0x40082DA")]
					public static SpawnConditionBestiaryInfoElement Caverns;

					[global::Cpp2ILInjected.Token(Token = "0x40082DB")]
					public static SpawnConditionBestiaryInfoElement UndergroundSnow;

					[global::Cpp2ILInjected.Token(Token = "0x40082DC")]
					public static SpawnConditionBestiaryInfoElement Ocean;

					[global::Cpp2ILInjected.Token(Token = "0x40082DD")]
					public static SpawnConditionBestiaryInfoElement SurfaceMushroom;

					[global::Cpp2ILInjected.Token(Token = "0x40082DE")]
					public static SpawnConditionBestiaryInfoElement UndergroundDesert;

					[global::Cpp2ILInjected.Token(Token = "0x40082DF")]
					public static SpawnConditionBestiaryInfoElement Snow;

					[global::Cpp2ILInjected.Token(Token = "0x40082E0")]
					public static SpawnConditionBestiaryInfoElement Desert;

					[global::Cpp2ILInjected.Token(Token = "0x40082E1")]
					public static SpawnConditionBestiaryInfoElement Meteor;

					[global::Cpp2ILInjected.Token(Token = "0x40082E2")]
					public static SpawnConditionBestiaryInfoElement Oasis;

					[global::Cpp2ILInjected.Token(Token = "0x40082E3")]
					public static SpawnConditionBestiaryInfoElement SpiderNest;

					[global::Cpp2ILInjected.Token(Token = "0x40082E4")]
					public static SpawnConditionBestiaryInfoElement TheTemple;

					[global::Cpp2ILInjected.Token(Token = "0x40082E5")]
					public static SpawnConditionBestiaryInfoElement CorruptUndergroundDesert;

					[global::Cpp2ILInjected.Token(Token = "0x40082E6")]
					public static SpawnConditionBestiaryInfoElement CrimsonUndergroundDesert;

					[global::Cpp2ILInjected.Token(Token = "0x40082E7")]
					public static SpawnConditionBestiaryInfoElement HallowUndergroundDesert;

					[global::Cpp2ILInjected.Token(Token = "0x40082E8")]
					public static SpawnConditionBestiaryInfoElement CorruptDesert;

					[global::Cpp2ILInjected.Token(Token = "0x40082E9")]
					public static SpawnConditionBestiaryInfoElement CrimsonDesert;

					[global::Cpp2ILInjected.Token(Token = "0x40082EA")]
					public static SpawnConditionBestiaryInfoElement HallowDesert;

					[global::Cpp2ILInjected.Token(Token = "0x40082EB")]
					public static SpawnConditionBestiaryInfoElement Granite;

					[global::Cpp2ILInjected.Token(Token = "0x40082EC")]
					public static SpawnConditionBestiaryInfoElement UndergroundCorruption;

					[global::Cpp2ILInjected.Token(Token = "0x40082ED")]
					public static SpawnConditionBestiaryInfoElement UndergroundCrimson;

					[global::Cpp2ILInjected.Token(Token = "0x40082EE")]
					public static SpawnConditionBestiaryInfoElement UndergroundHallow;

					[global::Cpp2ILInjected.Token(Token = "0x40082EF")]
					public static SpawnConditionBestiaryInfoElement Marble;

					[global::Cpp2ILInjected.Token(Token = "0x40082F0")]
					public static SpawnConditionBestiaryInfoElement CorruptIce;

					[global::Cpp2ILInjected.Token(Token = "0x40082F1")]
					public static SpawnConditionBestiaryInfoElement HallowIce;

					[global::Cpp2ILInjected.Token(Token = "0x40082F2")]
					public static SpawnConditionBestiaryInfoElement CrimsonIce;

					[global::Cpp2ILInjected.Token(Token = "0x40082F3")]
					public static SpawnConditionBestiaryInfoElement Sky;

					[global::Cpp2ILInjected.Token(Token = "0x40082F4")]
					public static SpawnConditionBestiaryInfoElement NebulaPillar;

					[global::Cpp2ILInjected.Token(Token = "0x40082F5")]
					public static SpawnConditionBestiaryInfoElement SolarPillar;

					[global::Cpp2ILInjected.Token(Token = "0x40082F6")]
					public static SpawnConditionBestiaryInfoElement VortexPillar;

					[global::Cpp2ILInjected.Token(Token = "0x40082F7")]
					public static SpawnConditionBestiaryInfoElement StardustPillar;
				}

				[global::Cpp2ILInjected.Token(Token = "0x2000920")]
				public static class Times
				{
					// Note: this type is marked as 'beforefieldinit'.
					[global::Cpp2ILInjected.Token(Token = "0x6004700")]
					[global::Cpp2ILInjected.Address(RVA = "0x8137E4", Offset = "0x8137E4", Length = "0x198")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
					{
						typeof(int),
						typeof(int),
						typeof(int)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
					static Times()
					{
						throw null;
					}

					[global::Cpp2ILInjected.Token(Token = "0x40082F8")]
					public static SpawnConditionBestiaryInfoElement DayTime;

					[global::Cpp2ILInjected.Token(Token = "0x40082F9")]
					public static SpawnConditionBestiaryInfoElement NightTime;
				}

				[global::Cpp2ILInjected.Token(Token = "0x2000921")]
				public static class Visuals
				{
					// Note: this type is marked as 'beforefieldinit'.
					[global::Cpp2ILInjected.Token(Token = "0x6004701")]
					[global::Cpp2ILInjected.Address(RVA = "0x81397C", Offset = "0x81397C", Length = "0x448")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
					{
						typeof(int),
						typeof(int),
						typeof(int)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
					static Visuals()
					{
						throw null;
					}

					[global::Cpp2ILInjected.Token(Token = "0x40082FA")]
					public static SpawnConditionDecorativeOverlayInfoElement Sun;

					[global::Cpp2ILInjected.Token(Token = "0x40082FB")]
					public static SpawnConditionDecorativeOverlayInfoElement Moon;

					[global::Cpp2ILInjected.Token(Token = "0x40082FC")]
					public static SpawnConditionDecorativeOverlayInfoElement EclipseSun;

					[global::Cpp2ILInjected.Token(Token = "0x40082FD")]
					public static SpawnConditionDecorativeOverlayInfoElement PumpkinMoon;

					[global::Cpp2ILInjected.Token(Token = "0x40082FE")]
					public static SpawnConditionDecorativeOverlayInfoElement FrostMoon;

					[global::Cpp2ILInjected.Token(Token = "0x40082FF")]
					public static SpawnConditionDecorativeOverlayInfoElement Meteor;

					[global::Cpp2ILInjected.Token(Token = "0x4008300")]
					public static SpawnConditionDecorativeOverlayInfoElement Rain;

					[global::Cpp2ILInjected.Token(Token = "0x4008301")]
					public static SpawnConditionDecorativeOverlayInfoElement Blizzard;
				}
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000922")]
		public static class Conditions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004702")]
			[global::Cpp2ILInjected.Address(RVA = "0x813DFC", Offset = "0x813DFC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static bool ReachHardMode()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000923")]
		public static class CrownosIconIndexes
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008302")]
			public const int Surface = 0;

			[global::Cpp2ILInjected.Token(Token = "0x4008303")]
			public const int Underground = 1;

			[global::Cpp2ILInjected.Token(Token = "0x4008304")]
			public const int Cave = 2;

			[global::Cpp2ILInjected.Token(Token = "0x4008305")]
			public const int Desert = 3;

			[global::Cpp2ILInjected.Token(Token = "0x4008306")]
			public const int UndergroundDesert = 4;

			[global::Cpp2ILInjected.Token(Token = "0x4008307")]
			public const int Snow = 5;

			[global::Cpp2ILInjected.Token(Token = "0x4008308")]
			public const int UndergroundIce = 6;

			[global::Cpp2ILInjected.Token(Token = "0x4008309")]
			public const int Corruption = 7;

			[global::Cpp2ILInjected.Token(Token = "0x400830A")]
			public const int CorruptionUnderground = 8;

			[global::Cpp2ILInjected.Token(Token = "0x400830B")]
			public const int CorruptionDesert = 9;

			[global::Cpp2ILInjected.Token(Token = "0x400830C")]
			public const int CorruptionUndergroundDesert = 10;

			[global::Cpp2ILInjected.Token(Token = "0x400830D")]
			public const int CorruptionIce = 11;

			[global::Cpp2ILInjected.Token(Token = "0x400830E")]
			public const int Crimson = 12;

			[global::Cpp2ILInjected.Token(Token = "0x400830F")]
			public const int CrimsonUnderground = 13;

			[global::Cpp2ILInjected.Token(Token = "0x4008310")]
			public const int CrimsonDesert = 14;

			[global::Cpp2ILInjected.Token(Token = "0x4008311")]
			public const int CrimsonUndergroundDesert = 15;

			[global::Cpp2ILInjected.Token(Token = "0x4008312")]
			public const int CrimsonIce = 16;

			[global::Cpp2ILInjected.Token(Token = "0x4008313")]
			public const int Hallow = 17;

			[global::Cpp2ILInjected.Token(Token = "0x4008314")]
			public const int HallowUnderground = 18;

			[global::Cpp2ILInjected.Token(Token = "0x4008315")]
			public const int HallowDesert = 19;

			[global::Cpp2ILInjected.Token(Token = "0x4008316")]
			public const int HallowUndergroundDesert = 20;

			[global::Cpp2ILInjected.Token(Token = "0x4008317")]
			public const int HallowIce = 21;

			[global::Cpp2ILInjected.Token(Token = "0x4008318")]
			public const int Jungle = 22;

			[global::Cpp2ILInjected.Token(Token = "0x4008319")]
			public const int UndergroundJungle = 23;

			[global::Cpp2ILInjected.Token(Token = "0x400831A")]
			public const int SurfaceMushroom = 24;

			[global::Cpp2ILInjected.Token(Token = "0x400831B")]
			public const int UndergroundMushroom = 25;

			[global::Cpp2ILInjected.Token(Token = "0x400831C")]
			public const int Sky = 26;

			[global::Cpp2ILInjected.Token(Token = "0x400831D")]
			public const int Oasis = 27;

			[global::Cpp2ILInjected.Token(Token = "0x400831E")]
			public const int Ocean = 28;

			[global::Cpp2ILInjected.Token(Token = "0x400831F")]
			public const int Marble = 29;

			[global::Cpp2ILInjected.Token(Token = "0x4008320")]
			public const int Granite = 30;

			[global::Cpp2ILInjected.Token(Token = "0x4008321")]
			public const int JungleTemple = 31;

			[global::Cpp2ILInjected.Token(Token = "0x4008322")]
			public const int Dungeon = 32;

			[global::Cpp2ILInjected.Token(Token = "0x4008323")]
			public const int Underworld = 33;

			[global::Cpp2ILInjected.Token(Token = "0x4008324")]
			public const int SpiderNest = 34;

			[global::Cpp2ILInjected.Token(Token = "0x4008325")]
			public const int Graveyard = 35;

			[global::Cpp2ILInjected.Token(Token = "0x4008326")]
			public const int Day = 36;

			[global::Cpp2ILInjected.Token(Token = "0x4008327")]
			public const int Night = 37;

			[global::Cpp2ILInjected.Token(Token = "0x4008328")]
			public const int BloodMoon = 38;

			[global::Cpp2ILInjected.Token(Token = "0x4008329")]
			public const int Eclipse = 39;

			[global::Cpp2ILInjected.Token(Token = "0x400832A")]
			public const int Rain = 40;

			[global::Cpp2ILInjected.Token(Token = "0x400832B")]
			public const int WindyDay = 41;

			[global::Cpp2ILInjected.Token(Token = "0x400832C")]
			public const int Blizzard = 42;

			[global::Cpp2ILInjected.Token(Token = "0x400832D")]
			public const int Sandstorm = 43;

			[global::Cpp2ILInjected.Token(Token = "0x400832E")]
			public const int Meteor = 44;

			[global::Cpp2ILInjected.Token(Token = "0x400832F")]
			public const int Halloween = 45;

			[global::Cpp2ILInjected.Token(Token = "0x4008330")]
			public const int Christmas = 46;

			[global::Cpp2ILInjected.Token(Token = "0x4008331")]
			public const int SlimeRain = 47;

			[global::Cpp2ILInjected.Token(Token = "0x4008332")]
			public const int Party = 48;

			[global::Cpp2ILInjected.Token(Token = "0x4008333")]
			public const int GoblinInvasion = 49;

			[global::Cpp2ILInjected.Token(Token = "0x4008334")]
			public const int PirateInvasion = 50;

			[global::Cpp2ILInjected.Token(Token = "0x4008335")]
			public const int PumpkinMoon = 51;

			[global::Cpp2ILInjected.Token(Token = "0x4008336")]
			public const int FrostMoon = 52;

			[global::Cpp2ILInjected.Token(Token = "0x4008337")]
			public const int AlienInvasion = 53;

			[global::Cpp2ILInjected.Token(Token = "0x4008338")]
			public const int FrostLegion = 54;

			[global::Cpp2ILInjected.Token(Token = "0x4008339")]
			public const int OldOnesArmy = 55;

			[global::Cpp2ILInjected.Token(Token = "0x400833A")]
			public const int SolarTower = 56;

			[global::Cpp2ILInjected.Token(Token = "0x400833B")]
			public const int VortexTower = 57;

			[global::Cpp2ILInjected.Token(Token = "0x400833C")]
			public const int NebulaTower = 58;

			[global::Cpp2ILInjected.Token(Token = "0x400833D")]
			public const int StardustTower = 59;

			[global::Cpp2ILInjected.Token(Token = "0x400833E")]
			public const int Hardmode = 60;

			[global::Cpp2ILInjected.Token(Token = "0x400833F")]
			public const int ItemSpawn = 61;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000924")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004703")]
			[global::Cpp2ILInjected.Address(RVA = "0x813E54", Offset = "0x813E54", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004704")]
			[global::Cpp2ILInjected.Address(RVA = "0x813EB0", Offset = "0x813EB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004705")]
			[global::Cpp2ILInjected.Address(RVA = "0x813EB8", Offset = "0x813EB8", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ModifyEntriesThatNeedIt_NameOverride>b__12_0(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004706")]
			[global::Cpp2ILInjected.Address(RVA = "0x813F30", Offset = "0x813F30", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ModifyEntriesThatNeedIt>b__13_0(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004707")]
			[global::Cpp2ILInjected.Address(RVA = "0x813FA8", Offset = "0x813FA8", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ModifyEntriesThatNeedIt>b__13_1(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004708")]
			[global::Cpp2ILInjected.Address(RVA = "0x814020", Offset = "0x814020", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ModifyEntriesThatNeedIt>b__13_2(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004709")]
			[global::Cpp2ILInjected.Address(RVA = "0x814098", Offset = "0x814098", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal NPCStatsReportInfoElement <ModifyEntriesThatNeedIt>b__13_3(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600470A")]
			[global::Cpp2ILInjected.Address(RVA = "0x814110", Offset = "0x814110", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <ModifyEntriesThatNeedIt>b__13_4(NPCStatsReportInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600470B")]
			[global::Cpp2ILInjected.Address(RVA = "0x81411C", Offset = "0x81411C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal NPCStatsReportInfoElement <ModifyEntriesThatNeedIt>b__13_5(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600470C")]
			[global::Cpp2ILInjected.Address(RVA = "0x814194", Offset = "0x814194", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <ModifyEntriesThatNeedIt>b__13_6(NPCStatsReportInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600470D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8141A0", Offset = "0x8141A0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <TryGivingEntryFlavorTextIfItIsMissing>b__16_0(IBestiaryInfoElement x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008340")]
			public static readonly BestiaryDatabaseNPCsPopulator.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4008341")]
			public static Predicate<IBestiaryInfoElement> <>9__12_0;

			[global::Cpp2ILInjected.Token(Token = "0x4008342")]
			public static Predicate<IBestiaryInfoElement> <>9__13_0;

			[global::Cpp2ILInjected.Token(Token = "0x4008343")]
			public static Predicate<IBestiaryInfoElement> <>9__13_1;

			[global::Cpp2ILInjected.Token(Token = "0x4008344")]
			public static Predicate<IBestiaryInfoElement> <>9__13_2;

			[global::Cpp2ILInjected.Token(Token = "0x4008345")]
			public static Func<IBestiaryInfoElement, NPCStatsReportInfoElement> <>9__13_3;

			[global::Cpp2ILInjected.Token(Token = "0x4008346")]
			public static Func<NPCStatsReportInfoElement, bool> <>9__13_4;

			[global::Cpp2ILInjected.Token(Token = "0x4008347")]
			public static Func<IBestiaryInfoElement, NPCStatsReportInfoElement> <>9__13_5;

			[global::Cpp2ILInjected.Token(Token = "0x4008348")]
			public static Func<NPCStatsReportInfoElement, bool> <>9__13_6;

			[global::Cpp2ILInjected.Token(Token = "0x4008349")]
			public static Func<IBestiaryInfoElement, bool> <>9__16_0;
		}
	}
}
