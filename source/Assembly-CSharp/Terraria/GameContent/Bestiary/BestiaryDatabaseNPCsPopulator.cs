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
	// Token: 0x02000614 RID: 1556
	[global::Cpp2ILInjected.Token(Token = "0x200091A")]
	public class BestiaryDatabaseNPCsPopulator
	{
		// Token: 0x06003E3C RID: 15932 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		[global::Cpp2ILInjected.Token(Token = "0x60046E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E4034", Offset = "0x7E4034", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BestiaryDatabaseNPCsPopulator()
		{
			throw null;
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x0002D1EB File Offset: 0x0002B3EB
		[global::Cpp2ILInjected.Token(Token = "0x60046E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E403C", Offset = "0x7E403C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		private BestiaryEntry FindEntryByNPCID(int npcNetId)
		{
			throw null;
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0002D1EE File Offset: 0x0002B3EE
		[global::Cpp2ILInjected.Token(Token = "0x60046E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E4048", Offset = "0x7E4048", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(BestiaryEntry))]
		private BestiaryEntry Register(BestiaryEntry entry)
		{
			throw null;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x0002D1F1 File Offset: 0x0002B3F1
		[global::Cpp2ILInjected.Token(Token = "0x60046EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E4054", Offset = "0x7E4054", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "Register", MemberParameters = new object[] { typeof(IBestiaryEntryFilter) }, ReturnType = typeof(IBestiaryEntryFilter))]
		private IBestiaryEntryFilter Register(IBestiaryEntryFilter filter)
		{
			throw null;
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x0002D1F4 File Offset: 0x0002B3F4
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

		// Token: 0x06003E41 RID: 15937 RVA: 0x0002D1F7 File Offset: 0x0002B3F7
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

		// Token: 0x06003E42 RID: 15938 RVA: 0x0002D1FA File Offset: 0x0002B3FA
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

		// Token: 0x06003E43 RID: 15939 RVA: 0x0002D1FD File Offset: 0x0002B3FD
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

		// Token: 0x06003E44 RID: 15940 RVA: 0x0002D200 File Offset: 0x0002B400
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

		// Token: 0x06003E45 RID: 15941 RVA: 0x0002D203 File Offset: 0x0002B403
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

		// Token: 0x06003E46 RID: 15942 RVA: 0x0002D206 File Offset: 0x0002B406
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

		// Token: 0x06003E47 RID: 15943 RVA: 0x0002D209 File Offset: 0x0002B409
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

		// Token: 0x06003E48 RID: 15944 RVA: 0x0002D20C File Offset: 0x0002B40C
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

		// Token: 0x06003E49 RID: 15945 RVA: 0x0002D20F File Offset: 0x0002B40F
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

		// Token: 0x06003E4A RID: 15946 RVA: 0x0002D212 File Offset: 0x0002B412
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

		// Token: 0x06003E4B RID: 15947 RVA: 0x0002D215 File Offset: 0x0002B415
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

		// Token: 0x06003E4C RID: 15948 RVA: 0x0002D218 File Offset: 0x0002B418
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

		// Token: 0x06003E4D RID: 15949 RVA: 0x0002D21B File Offset: 0x0002B41B
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

		// Token: 0x06003E4E RID: 15950 RVA: 0x0002D21E File Offset: 0x0002B41E
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

		// Token: 0x06003E4F RID: 15951 RVA: 0x0002D221 File Offset: 0x0002B421
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

		// Token: 0x06003E50 RID: 15952 RVA: 0x0002D224 File Offset: 0x0002B424
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

		// Token: 0x04006C3C RID: 27708
		[global::Cpp2ILInjected.Token(Token = "0x40082BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BestiaryDatabase _currentDatabase;

		// Token: 0x02000A10 RID: 2576
		[global::Cpp2ILInjected.Token(Token = "0x200091B")]
		public static class CommonTags
		{
			// Token: 0x06004F7D RID: 20349 RVA: 0x0003008F File Offset: 0x0002E28F
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

			// Token: 0x02000BAB RID: 2987
			[global::Cpp2ILInjected.Token(Token = "0x200091C")]
			public static class SpawnConditions
			{
				// Token: 0x02000BD8 RID: 3032
				[global::Cpp2ILInjected.Token(Token = "0x200091D")]
				public static class Invasions
				{
					// Token: 0x060054BD RID: 21693 RVA: 0x00030F0E File Offset: 0x0002F10E
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

					// Token: 0x0400917B RID: 37243
					[global::Cpp2ILInjected.Token(Token = "0x40082BE")]
					public static SpawnConditionBestiaryInfoElement Goblins;

					// Token: 0x0400917C RID: 37244
					[global::Cpp2ILInjected.Token(Token = "0x40082BF")]
					public static SpawnConditionBestiaryInfoElement Pirates;

					// Token: 0x0400917D RID: 37245
					[global::Cpp2ILInjected.Token(Token = "0x40082C0")]
					public static SpawnConditionBestiaryInfoElement Martian;

					// Token: 0x0400917E RID: 37246
					[global::Cpp2ILInjected.Token(Token = "0x40082C1")]
					public static SpawnConditionBestiaryInfoElement OldOnesArmy;

					// Token: 0x0400917F RID: 37247
					[global::Cpp2ILInjected.Token(Token = "0x40082C2")]
					public static SpawnConditionBestiaryInfoElement PumpkinMoon;

					// Token: 0x04009180 RID: 37248
					[global::Cpp2ILInjected.Token(Token = "0x40082C3")]
					public static SpawnConditionBestiaryInfoElement FrostMoon;

					// Token: 0x04009181 RID: 37249
					[global::Cpp2ILInjected.Token(Token = "0x40082C4")]
					public static SpawnConditionBestiaryInfoElement FrostLegion;
				}

				// Token: 0x02000BD9 RID: 3033
				[global::Cpp2ILInjected.Token(Token = "0x200091E")]
				public static class Events
				{
					// Token: 0x060054BE RID: 21694 RVA: 0x00030F11 File Offset: 0x0002F111
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

					// Token: 0x04009182 RID: 37250
					[global::Cpp2ILInjected.Token(Token = "0x40082C5")]
					public static SpawnConditionBestiaryInfoElement SlimeRain;

					// Token: 0x04009183 RID: 37251
					[global::Cpp2ILInjected.Token(Token = "0x40082C6")]
					public static SpawnConditionBestiaryInfoElement WindyDay;

					// Token: 0x04009184 RID: 37252
					[global::Cpp2ILInjected.Token(Token = "0x40082C7")]
					public static SpawnConditionBestiaryInfoElement BloodMoon;

					// Token: 0x04009185 RID: 37253
					[global::Cpp2ILInjected.Token(Token = "0x40082C8")]
					public static SpawnConditionBestiaryInfoElement Halloween;

					// Token: 0x04009186 RID: 37254
					[global::Cpp2ILInjected.Token(Token = "0x40082C9")]
					public static SpawnConditionBestiaryOverlayInfoElement Rain;

					// Token: 0x04009187 RID: 37255
					[global::Cpp2ILInjected.Token(Token = "0x40082CA")]
					public static SpawnConditionBestiaryInfoElement Christmas;

					// Token: 0x04009188 RID: 37256
					[global::Cpp2ILInjected.Token(Token = "0x40082CB")]
					public static SpawnConditionBestiaryInfoElement Eclipse;

					// Token: 0x04009189 RID: 37257
					[global::Cpp2ILInjected.Token(Token = "0x40082CC")]
					public static SpawnConditionBestiaryInfoElement Party;

					// Token: 0x0400918A RID: 37258
					[global::Cpp2ILInjected.Token(Token = "0x40082CD")]
					public static SpawnConditionBestiaryOverlayInfoElement Blizzard;

					// Token: 0x0400918B RID: 37259
					[global::Cpp2ILInjected.Token(Token = "0x40082CE")]
					public static SpawnConditionBestiaryOverlayInfoElement Sandstorm;
				}

				// Token: 0x02000BDA RID: 3034
				[global::Cpp2ILInjected.Token(Token = "0x200091F")]
				public static class Biomes
				{
					// Token: 0x060054BF RID: 21695 RVA: 0x00030F14 File Offset: 0x0002F114
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

					// Token: 0x0400918C RID: 37260
					[global::Cpp2ILInjected.Token(Token = "0x40082CF")]
					public static SpawnConditionBestiaryInfoElement TheCorruption;

					// Token: 0x0400918D RID: 37261
					[global::Cpp2ILInjected.Token(Token = "0x40082D0")]
					public static SpawnConditionBestiaryInfoElement TheCrimson;

					// Token: 0x0400918E RID: 37262
					[global::Cpp2ILInjected.Token(Token = "0x40082D1")]
					public static SpawnConditionBestiaryInfoElement Surface;

					// Token: 0x0400918F RID: 37263
					[global::Cpp2ILInjected.Token(Token = "0x40082D2")]
					public static SpawnConditionBestiaryInfoElement Graveyard;

					// Token: 0x04009190 RID: 37264
					[global::Cpp2ILInjected.Token(Token = "0x40082D3")]
					public static SpawnConditionBestiaryInfoElement UndergroundJungle;

					// Token: 0x04009191 RID: 37265
					[global::Cpp2ILInjected.Token(Token = "0x40082D4")]
					public static SpawnConditionBestiaryInfoElement TheUnderworld;

					// Token: 0x04009192 RID: 37266
					[global::Cpp2ILInjected.Token(Token = "0x40082D5")]
					public static SpawnConditionBestiaryInfoElement TheDungeon;

					// Token: 0x04009193 RID: 37267
					[global::Cpp2ILInjected.Token(Token = "0x40082D6")]
					public static SpawnConditionBestiaryInfoElement Underground;

					// Token: 0x04009194 RID: 37268
					[global::Cpp2ILInjected.Token(Token = "0x40082D7")]
					public static SpawnConditionBestiaryInfoElement TheHallow;

					// Token: 0x04009195 RID: 37269
					[global::Cpp2ILInjected.Token(Token = "0x40082D8")]
					public static SpawnConditionBestiaryInfoElement UndergroundMushroom;

					// Token: 0x04009196 RID: 37270
					[global::Cpp2ILInjected.Token(Token = "0x40082D9")]
					public static SpawnConditionBestiaryInfoElement Jungle;

					// Token: 0x04009197 RID: 37271
					[global::Cpp2ILInjected.Token(Token = "0x40082DA")]
					public static SpawnConditionBestiaryInfoElement Caverns;

					// Token: 0x04009198 RID: 37272
					[global::Cpp2ILInjected.Token(Token = "0x40082DB")]
					public static SpawnConditionBestiaryInfoElement UndergroundSnow;

					// Token: 0x04009199 RID: 37273
					[global::Cpp2ILInjected.Token(Token = "0x40082DC")]
					public static SpawnConditionBestiaryInfoElement Ocean;

					// Token: 0x0400919A RID: 37274
					[global::Cpp2ILInjected.Token(Token = "0x40082DD")]
					public static SpawnConditionBestiaryInfoElement SurfaceMushroom;

					// Token: 0x0400919B RID: 37275
					[global::Cpp2ILInjected.Token(Token = "0x40082DE")]
					public static SpawnConditionBestiaryInfoElement UndergroundDesert;

					// Token: 0x0400919C RID: 37276
					[global::Cpp2ILInjected.Token(Token = "0x40082DF")]
					public static SpawnConditionBestiaryInfoElement Snow;

					// Token: 0x0400919D RID: 37277
					[global::Cpp2ILInjected.Token(Token = "0x40082E0")]
					public static SpawnConditionBestiaryInfoElement Desert;

					// Token: 0x0400919E RID: 37278
					[global::Cpp2ILInjected.Token(Token = "0x40082E1")]
					public static SpawnConditionBestiaryInfoElement Meteor;

					// Token: 0x0400919F RID: 37279
					[global::Cpp2ILInjected.Token(Token = "0x40082E2")]
					public static SpawnConditionBestiaryInfoElement Oasis;

					// Token: 0x040091A0 RID: 37280
					[global::Cpp2ILInjected.Token(Token = "0x40082E3")]
					public static SpawnConditionBestiaryInfoElement SpiderNest;

					// Token: 0x040091A1 RID: 37281
					[global::Cpp2ILInjected.Token(Token = "0x40082E4")]
					public static SpawnConditionBestiaryInfoElement TheTemple;

					// Token: 0x040091A2 RID: 37282
					[global::Cpp2ILInjected.Token(Token = "0x40082E5")]
					public static SpawnConditionBestiaryInfoElement CorruptUndergroundDesert;

					// Token: 0x040091A3 RID: 37283
					[global::Cpp2ILInjected.Token(Token = "0x40082E6")]
					public static SpawnConditionBestiaryInfoElement CrimsonUndergroundDesert;

					// Token: 0x040091A4 RID: 37284
					[global::Cpp2ILInjected.Token(Token = "0x40082E7")]
					public static SpawnConditionBestiaryInfoElement HallowUndergroundDesert;

					// Token: 0x040091A5 RID: 37285
					[global::Cpp2ILInjected.Token(Token = "0x40082E8")]
					public static SpawnConditionBestiaryInfoElement CorruptDesert;

					// Token: 0x040091A6 RID: 37286
					[global::Cpp2ILInjected.Token(Token = "0x40082E9")]
					public static SpawnConditionBestiaryInfoElement CrimsonDesert;

					// Token: 0x040091A7 RID: 37287
					[global::Cpp2ILInjected.Token(Token = "0x40082EA")]
					public static SpawnConditionBestiaryInfoElement HallowDesert;

					// Token: 0x040091A8 RID: 37288
					[global::Cpp2ILInjected.Token(Token = "0x40082EB")]
					public static SpawnConditionBestiaryInfoElement Granite;

					// Token: 0x040091A9 RID: 37289
					[global::Cpp2ILInjected.Token(Token = "0x40082EC")]
					public static SpawnConditionBestiaryInfoElement UndergroundCorruption;

					// Token: 0x040091AA RID: 37290
					[global::Cpp2ILInjected.Token(Token = "0x40082ED")]
					public static SpawnConditionBestiaryInfoElement UndergroundCrimson;

					// Token: 0x040091AB RID: 37291
					[global::Cpp2ILInjected.Token(Token = "0x40082EE")]
					public static SpawnConditionBestiaryInfoElement UndergroundHallow;

					// Token: 0x040091AC RID: 37292
					[global::Cpp2ILInjected.Token(Token = "0x40082EF")]
					public static SpawnConditionBestiaryInfoElement Marble;

					// Token: 0x040091AD RID: 37293
					[global::Cpp2ILInjected.Token(Token = "0x40082F0")]
					public static SpawnConditionBestiaryInfoElement CorruptIce;

					// Token: 0x040091AE RID: 37294
					[global::Cpp2ILInjected.Token(Token = "0x40082F1")]
					public static SpawnConditionBestiaryInfoElement HallowIce;

					// Token: 0x040091AF RID: 37295
					[global::Cpp2ILInjected.Token(Token = "0x40082F2")]
					public static SpawnConditionBestiaryInfoElement CrimsonIce;

					// Token: 0x040091B0 RID: 37296
					[global::Cpp2ILInjected.Token(Token = "0x40082F3")]
					public static SpawnConditionBestiaryInfoElement Sky;

					// Token: 0x040091B1 RID: 37297
					[global::Cpp2ILInjected.Token(Token = "0x40082F4")]
					public static SpawnConditionBestiaryInfoElement NebulaPillar;

					// Token: 0x040091B2 RID: 37298
					[global::Cpp2ILInjected.Token(Token = "0x40082F5")]
					public static SpawnConditionBestiaryInfoElement SolarPillar;

					// Token: 0x040091B3 RID: 37299
					[global::Cpp2ILInjected.Token(Token = "0x40082F6")]
					public static SpawnConditionBestiaryInfoElement VortexPillar;

					// Token: 0x040091B4 RID: 37300
					[global::Cpp2ILInjected.Token(Token = "0x40082F7")]
					public static SpawnConditionBestiaryInfoElement StardustPillar;
				}

				// Token: 0x02000BDB RID: 3035
				[global::Cpp2ILInjected.Token(Token = "0x2000920")]
				public static class Times
				{
					// Token: 0x060054C0 RID: 21696 RVA: 0x00030F17 File Offset: 0x0002F117
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

					// Token: 0x040091B5 RID: 37301
					[global::Cpp2ILInjected.Token(Token = "0x40082F8")]
					public static SpawnConditionBestiaryInfoElement DayTime;

					// Token: 0x040091B6 RID: 37302
					[global::Cpp2ILInjected.Token(Token = "0x40082F9")]
					public static SpawnConditionBestiaryInfoElement NightTime;
				}

				// Token: 0x02000BDC RID: 3036
				[global::Cpp2ILInjected.Token(Token = "0x2000921")]
				public static class Visuals
				{
					// Token: 0x060054C1 RID: 21697 RVA: 0x00030F1A File Offset: 0x0002F11A
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

					// Token: 0x040091B7 RID: 37303
					[global::Cpp2ILInjected.Token(Token = "0x40082FA")]
					public static SpawnConditionDecorativeOverlayInfoElement Sun;

					// Token: 0x040091B8 RID: 37304
					[global::Cpp2ILInjected.Token(Token = "0x40082FB")]
					public static SpawnConditionDecorativeOverlayInfoElement Moon;

					// Token: 0x040091B9 RID: 37305
					[global::Cpp2ILInjected.Token(Token = "0x40082FC")]
					public static SpawnConditionDecorativeOverlayInfoElement EclipseSun;

					// Token: 0x040091BA RID: 37306
					[global::Cpp2ILInjected.Token(Token = "0x40082FD")]
					public static SpawnConditionDecorativeOverlayInfoElement PumpkinMoon;

					// Token: 0x040091BB RID: 37307
					[global::Cpp2ILInjected.Token(Token = "0x40082FE")]
					public static SpawnConditionDecorativeOverlayInfoElement FrostMoon;

					// Token: 0x040091BC RID: 37308
					[global::Cpp2ILInjected.Token(Token = "0x40082FF")]
					public static SpawnConditionDecorativeOverlayInfoElement Meteor;

					// Token: 0x040091BD RID: 37309
					[global::Cpp2ILInjected.Token(Token = "0x4008300")]
					public static SpawnConditionDecorativeOverlayInfoElement Rain;

					// Token: 0x040091BE RID: 37310
					[global::Cpp2ILInjected.Token(Token = "0x4008301")]
					public static SpawnConditionDecorativeOverlayInfoElement Blizzard;
				}
			}
		}

		// Token: 0x02000A11 RID: 2577
		[global::Cpp2ILInjected.Token(Token = "0x2000922")]
		public static class Conditions
		{
			// Token: 0x06004F7E RID: 20350 RVA: 0x00030092 File Offset: 0x0002E292
			[global::Cpp2ILInjected.Token(Token = "0x6004702")]
			[global::Cpp2ILInjected.Address(RVA = "0x813DFC", Offset = "0x813DFC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static bool ReachHardMode()
			{
				throw null;
			}
		}

		// Token: 0x02000A12 RID: 2578
		[global::Cpp2ILInjected.Token(Token = "0x2000923")]
		public static class CrownosIconIndexes
		{
			// Token: 0x04008D34 RID: 36148
			[global::Cpp2ILInjected.Token(Token = "0x4008302")]
			public const int Surface = 0;

			// Token: 0x04008D35 RID: 36149
			[global::Cpp2ILInjected.Token(Token = "0x4008303")]
			public const int Underground = 1;

			// Token: 0x04008D36 RID: 36150
			[global::Cpp2ILInjected.Token(Token = "0x4008304")]
			public const int Cave = 2;

			// Token: 0x04008D37 RID: 36151
			[global::Cpp2ILInjected.Token(Token = "0x4008305")]
			public const int Desert = 3;

			// Token: 0x04008D38 RID: 36152
			[global::Cpp2ILInjected.Token(Token = "0x4008306")]
			public const int UndergroundDesert = 4;

			// Token: 0x04008D39 RID: 36153
			[global::Cpp2ILInjected.Token(Token = "0x4008307")]
			public const int Snow = 5;

			// Token: 0x04008D3A RID: 36154
			[global::Cpp2ILInjected.Token(Token = "0x4008308")]
			public const int UndergroundIce = 6;

			// Token: 0x04008D3B RID: 36155
			[global::Cpp2ILInjected.Token(Token = "0x4008309")]
			public const int Corruption = 7;

			// Token: 0x04008D3C RID: 36156
			[global::Cpp2ILInjected.Token(Token = "0x400830A")]
			public const int CorruptionUnderground = 8;

			// Token: 0x04008D3D RID: 36157
			[global::Cpp2ILInjected.Token(Token = "0x400830B")]
			public const int CorruptionDesert = 9;

			// Token: 0x04008D3E RID: 36158
			[global::Cpp2ILInjected.Token(Token = "0x400830C")]
			public const int CorruptionUndergroundDesert = 10;

			// Token: 0x04008D3F RID: 36159
			[global::Cpp2ILInjected.Token(Token = "0x400830D")]
			public const int CorruptionIce = 11;

			// Token: 0x04008D40 RID: 36160
			[global::Cpp2ILInjected.Token(Token = "0x400830E")]
			public const int Crimson = 12;

			// Token: 0x04008D41 RID: 36161
			[global::Cpp2ILInjected.Token(Token = "0x400830F")]
			public const int CrimsonUnderground = 13;

			// Token: 0x04008D42 RID: 36162
			[global::Cpp2ILInjected.Token(Token = "0x4008310")]
			public const int CrimsonDesert = 14;

			// Token: 0x04008D43 RID: 36163
			[global::Cpp2ILInjected.Token(Token = "0x4008311")]
			public const int CrimsonUndergroundDesert = 15;

			// Token: 0x04008D44 RID: 36164
			[global::Cpp2ILInjected.Token(Token = "0x4008312")]
			public const int CrimsonIce = 16;

			// Token: 0x04008D45 RID: 36165
			[global::Cpp2ILInjected.Token(Token = "0x4008313")]
			public const int Hallow = 17;

			// Token: 0x04008D46 RID: 36166
			[global::Cpp2ILInjected.Token(Token = "0x4008314")]
			public const int HallowUnderground = 18;

			// Token: 0x04008D47 RID: 36167
			[global::Cpp2ILInjected.Token(Token = "0x4008315")]
			public const int HallowDesert = 19;

			// Token: 0x04008D48 RID: 36168
			[global::Cpp2ILInjected.Token(Token = "0x4008316")]
			public const int HallowUndergroundDesert = 20;

			// Token: 0x04008D49 RID: 36169
			[global::Cpp2ILInjected.Token(Token = "0x4008317")]
			public const int HallowIce = 21;

			// Token: 0x04008D4A RID: 36170
			[global::Cpp2ILInjected.Token(Token = "0x4008318")]
			public const int Jungle = 22;

			// Token: 0x04008D4B RID: 36171
			[global::Cpp2ILInjected.Token(Token = "0x4008319")]
			public const int UndergroundJungle = 23;

			// Token: 0x04008D4C RID: 36172
			[global::Cpp2ILInjected.Token(Token = "0x400831A")]
			public const int SurfaceMushroom = 24;

			// Token: 0x04008D4D RID: 36173
			[global::Cpp2ILInjected.Token(Token = "0x400831B")]
			public const int UndergroundMushroom = 25;

			// Token: 0x04008D4E RID: 36174
			[global::Cpp2ILInjected.Token(Token = "0x400831C")]
			public const int Sky = 26;

			// Token: 0x04008D4F RID: 36175
			[global::Cpp2ILInjected.Token(Token = "0x400831D")]
			public const int Oasis = 27;

			// Token: 0x04008D50 RID: 36176
			[global::Cpp2ILInjected.Token(Token = "0x400831E")]
			public const int Ocean = 28;

			// Token: 0x04008D51 RID: 36177
			[global::Cpp2ILInjected.Token(Token = "0x400831F")]
			public const int Marble = 29;

			// Token: 0x04008D52 RID: 36178
			[global::Cpp2ILInjected.Token(Token = "0x4008320")]
			public const int Granite = 30;

			// Token: 0x04008D53 RID: 36179
			[global::Cpp2ILInjected.Token(Token = "0x4008321")]
			public const int JungleTemple = 31;

			// Token: 0x04008D54 RID: 36180
			[global::Cpp2ILInjected.Token(Token = "0x4008322")]
			public const int Dungeon = 32;

			// Token: 0x04008D55 RID: 36181
			[global::Cpp2ILInjected.Token(Token = "0x4008323")]
			public const int Underworld = 33;

			// Token: 0x04008D56 RID: 36182
			[global::Cpp2ILInjected.Token(Token = "0x4008324")]
			public const int SpiderNest = 34;

			// Token: 0x04008D57 RID: 36183
			[global::Cpp2ILInjected.Token(Token = "0x4008325")]
			public const int Graveyard = 35;

			// Token: 0x04008D58 RID: 36184
			[global::Cpp2ILInjected.Token(Token = "0x4008326")]
			public const int Day = 36;

			// Token: 0x04008D59 RID: 36185
			[global::Cpp2ILInjected.Token(Token = "0x4008327")]
			public const int Night = 37;

			// Token: 0x04008D5A RID: 36186
			[global::Cpp2ILInjected.Token(Token = "0x4008328")]
			public const int BloodMoon = 38;

			// Token: 0x04008D5B RID: 36187
			[global::Cpp2ILInjected.Token(Token = "0x4008329")]
			public const int Eclipse = 39;

			// Token: 0x04008D5C RID: 36188
			[global::Cpp2ILInjected.Token(Token = "0x400832A")]
			public const int Rain = 40;

			// Token: 0x04008D5D RID: 36189
			[global::Cpp2ILInjected.Token(Token = "0x400832B")]
			public const int WindyDay = 41;

			// Token: 0x04008D5E RID: 36190
			[global::Cpp2ILInjected.Token(Token = "0x400832C")]
			public const int Blizzard = 42;

			// Token: 0x04008D5F RID: 36191
			[global::Cpp2ILInjected.Token(Token = "0x400832D")]
			public const int Sandstorm = 43;

			// Token: 0x04008D60 RID: 36192
			[global::Cpp2ILInjected.Token(Token = "0x400832E")]
			public const int Meteor = 44;

			// Token: 0x04008D61 RID: 36193
			[global::Cpp2ILInjected.Token(Token = "0x400832F")]
			public const int Halloween = 45;

			// Token: 0x04008D62 RID: 36194
			[global::Cpp2ILInjected.Token(Token = "0x4008330")]
			public const int Christmas = 46;

			// Token: 0x04008D63 RID: 36195
			[global::Cpp2ILInjected.Token(Token = "0x4008331")]
			public const int SlimeRain = 47;

			// Token: 0x04008D64 RID: 36196
			[global::Cpp2ILInjected.Token(Token = "0x4008332")]
			public const int Party = 48;

			// Token: 0x04008D65 RID: 36197
			[global::Cpp2ILInjected.Token(Token = "0x4008333")]
			public const int GoblinInvasion = 49;

			// Token: 0x04008D66 RID: 36198
			[global::Cpp2ILInjected.Token(Token = "0x4008334")]
			public const int PirateInvasion = 50;

			// Token: 0x04008D67 RID: 36199
			[global::Cpp2ILInjected.Token(Token = "0x4008335")]
			public const int PumpkinMoon = 51;

			// Token: 0x04008D68 RID: 36200
			[global::Cpp2ILInjected.Token(Token = "0x4008336")]
			public const int FrostMoon = 52;

			// Token: 0x04008D69 RID: 36201
			[global::Cpp2ILInjected.Token(Token = "0x4008337")]
			public const int AlienInvasion = 53;

			// Token: 0x04008D6A RID: 36202
			[global::Cpp2ILInjected.Token(Token = "0x4008338")]
			public const int FrostLegion = 54;

			// Token: 0x04008D6B RID: 36203
			[global::Cpp2ILInjected.Token(Token = "0x4008339")]
			public const int OldOnesArmy = 55;

			// Token: 0x04008D6C RID: 36204
			[global::Cpp2ILInjected.Token(Token = "0x400833A")]
			public const int SolarTower = 56;

			// Token: 0x04008D6D RID: 36205
			[global::Cpp2ILInjected.Token(Token = "0x400833B")]
			public const int VortexTower = 57;

			// Token: 0x04008D6E RID: 36206
			[global::Cpp2ILInjected.Token(Token = "0x400833C")]
			public const int NebulaTower = 58;

			// Token: 0x04008D6F RID: 36207
			[global::Cpp2ILInjected.Token(Token = "0x400833D")]
			public const int StardustTower = 59;

			// Token: 0x04008D70 RID: 36208
			[global::Cpp2ILInjected.Token(Token = "0x400833E")]
			public const int Hardmode = 60;

			// Token: 0x04008D71 RID: 36209
			[global::Cpp2ILInjected.Token(Token = "0x400833F")]
			public const int ItemSpawn = 61;
		}

		// Token: 0x02000A13 RID: 2579
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000924")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004F7F RID: 20351 RVA: 0x00030095 File Offset: 0x0002E295
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

			// Token: 0x06004F80 RID: 20352 RVA: 0x00030098 File Offset: 0x0002E298
			[global::Cpp2ILInjected.Token(Token = "0x6004704")]
			[global::Cpp2ILInjected.Address(RVA = "0x813EB0", Offset = "0x813EB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004F81 RID: 20353 RVA: 0x0003009B File Offset: 0x0002E29B
			[global::Cpp2ILInjected.Token(Token = "0x6004705")]
			[global::Cpp2ILInjected.Address(RVA = "0x813EB8", Offset = "0x813EB8", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ModifyEntriesThatNeedIt_NameOverride>b__12_0(IBestiaryInfoElement x)
			{
				throw null;
			}

			// Token: 0x06004F82 RID: 20354 RVA: 0x0003009E File Offset: 0x0002E29E
			[global::Cpp2ILInjected.Token(Token = "0x6004706")]
			[global::Cpp2ILInjected.Address(RVA = "0x813F30", Offset = "0x813F30", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ModifyEntriesThatNeedIt>b__13_0(IBestiaryInfoElement x)
			{
				throw null;
			}

			// Token: 0x06004F83 RID: 20355 RVA: 0x000300A1 File Offset: 0x0002E2A1
			[global::Cpp2ILInjected.Token(Token = "0x6004707")]
			[global::Cpp2ILInjected.Address(RVA = "0x813FA8", Offset = "0x813FA8", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ModifyEntriesThatNeedIt>b__13_1(IBestiaryInfoElement x)
			{
				throw null;
			}

			// Token: 0x06004F84 RID: 20356 RVA: 0x000300A4 File Offset: 0x0002E2A4
			[global::Cpp2ILInjected.Token(Token = "0x6004708")]
			[global::Cpp2ILInjected.Address(RVA = "0x814020", Offset = "0x814020", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ModifyEntriesThatNeedIt>b__13_2(IBestiaryInfoElement x)
			{
				throw null;
			}

			// Token: 0x06004F85 RID: 20357 RVA: 0x000300A7 File Offset: 0x0002E2A7
			[global::Cpp2ILInjected.Token(Token = "0x6004709")]
			[global::Cpp2ILInjected.Address(RVA = "0x814098", Offset = "0x814098", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal NPCStatsReportInfoElement <ModifyEntriesThatNeedIt>b__13_3(IBestiaryInfoElement x)
			{
				throw null;
			}

			// Token: 0x06004F86 RID: 20358 RVA: 0x000300AA File Offset: 0x0002E2AA
			[global::Cpp2ILInjected.Token(Token = "0x600470A")]
			[global::Cpp2ILInjected.Address(RVA = "0x814110", Offset = "0x814110", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <ModifyEntriesThatNeedIt>b__13_4(NPCStatsReportInfoElement x)
			{
				throw null;
			}

			// Token: 0x06004F87 RID: 20359 RVA: 0x000300AD File Offset: 0x0002E2AD
			[global::Cpp2ILInjected.Token(Token = "0x600470B")]
			[global::Cpp2ILInjected.Address(RVA = "0x81411C", Offset = "0x81411C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal NPCStatsReportInfoElement <ModifyEntriesThatNeedIt>b__13_5(IBestiaryInfoElement x)
			{
				throw null;
			}

			// Token: 0x06004F88 RID: 20360 RVA: 0x000300B0 File Offset: 0x0002E2B0
			[global::Cpp2ILInjected.Token(Token = "0x600470C")]
			[global::Cpp2ILInjected.Address(RVA = "0x814194", Offset = "0x814194", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <ModifyEntriesThatNeedIt>b__13_6(NPCStatsReportInfoElement x)
			{
				throw null;
			}

			// Token: 0x06004F89 RID: 20361 RVA: 0x000300B3 File Offset: 0x0002E2B3
			[global::Cpp2ILInjected.Token(Token = "0x600470D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8141A0", Offset = "0x8141A0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <TryGivingEntryFlavorTextIfItIsMissing>b__16_0(IBestiaryInfoElement x)
			{
				throw null;
			}

			// Token: 0x04008D72 RID: 36210
			[global::Cpp2ILInjected.Token(Token = "0x4008340")]
			public static readonly BestiaryDatabaseNPCsPopulator.<>c <>9;

			// Token: 0x04008D73 RID: 36211
			[global::Cpp2ILInjected.Token(Token = "0x4008341")]
			public static Predicate<IBestiaryInfoElement> <>9__12_0;

			// Token: 0x04008D74 RID: 36212
			[global::Cpp2ILInjected.Token(Token = "0x4008342")]
			public static Predicate<IBestiaryInfoElement> <>9__13_0;

			// Token: 0x04008D75 RID: 36213
			[global::Cpp2ILInjected.Token(Token = "0x4008343")]
			public static Predicate<IBestiaryInfoElement> <>9__13_1;

			// Token: 0x04008D76 RID: 36214
			[global::Cpp2ILInjected.Token(Token = "0x4008344")]
			public static Predicate<IBestiaryInfoElement> <>9__13_2;

			// Token: 0x04008D77 RID: 36215
			[global::Cpp2ILInjected.Token(Token = "0x4008345")]
			public static Func<IBestiaryInfoElement, NPCStatsReportInfoElement> <>9__13_3;

			// Token: 0x04008D78 RID: 36216
			[global::Cpp2ILInjected.Token(Token = "0x4008346")]
			public static Func<NPCStatsReportInfoElement, bool> <>9__13_4;

			// Token: 0x04008D79 RID: 36217
			[global::Cpp2ILInjected.Token(Token = "0x4008347")]
			public static Func<IBestiaryInfoElement, NPCStatsReportInfoElement> <>9__13_5;

			// Token: 0x04008D7A RID: 36218
			[global::Cpp2ILInjected.Token(Token = "0x4008348")]
			public static Func<NPCStatsReportInfoElement, bool> <>9__13_6;

			// Token: 0x04008D7B RID: 36219
			[global::Cpp2ILInjected.Token(Token = "0x4008349")]
			public static Func<IBestiaryInfoElement, bool> <>9__16_0;
		}
	}
}
