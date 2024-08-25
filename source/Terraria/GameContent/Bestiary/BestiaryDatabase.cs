using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000917")]
	public class BestiaryDatabase
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000810")]
		public List<BestiaryEntry> Entries
		{
			[global::Cpp2ILInjected.Token(Token = "0x60046D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x80F934", Offset = "0x80F934", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000811")]
		public List<IBestiaryEntryFilter> Filters
		{
			[global::Cpp2ILInjected.Token(Token = "0x60046D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x80F93C", Offset = "0x80F93C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000812")]
		public List<IBestiarySortStep> SortSteps
		{
			[global::Cpp2ILInjected.Token(Token = "0x60046D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x80F944", Offset = "0x80F944", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x80F94C", Offset = "0x80F94C", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Register", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterTestEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddTownNPCs_Manual", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddMultiEntryNPCS_Manual", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddEmptyEntries_CrittersAndEnemies_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public BestiaryEntry Register(BestiaryEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x80FABC", Offset = "0x80FABC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "Register", MemberParameters = new object[] { typeof(IBestiaryEntryFilter) }, ReturnType = typeof(IBestiaryEntryFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IBestiaryEntryFilter Register(IBestiaryEntryFilter filter)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x80FB60", Offset = "0x80FB60", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IBestiarySortStep Register(IBestiarySortStep sortStep)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x80FC04", Offset = "0x80FC04", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "DidDiscoverBestiaryEntry", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.BestiaryHelper), Member = "GetLowestBiomeGroupIndex", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(BestiaryDatabase),
			typeof(List<IBestiaryInfoElement>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabase), Member = "ExtractDropsForNPC", MemberParameters = new object[]
		{
			typeof(ItemDropDatabase),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt_NameOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddNPCBiomeRelationships_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddNPCBiomeRelationships_Manual", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddNPCBiomeRelationships_AddDecorations_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddDropOverrides", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 813)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BestiaryEntry FindEntryByNPCID(int npcNetId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x80FCB0", Offset = "0x80FCB0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "ExtractDropsForNPC", MemberParameters = new object[]
		{
			typeof(ItemDropDatabase),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Merge(ItemDropDatabase dropsDatabase)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x80FCEC", Offset = "0x80FCEC", Length = "0x444")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabase), Member = "Merge", MemberParameters = new object[] { typeof(ItemDropDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "GetRulesForNPCID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(List<IItemDropRule>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DropRateInfo>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DropRateInfo>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DropRateInfo>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DropRateInfo>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private void ExtractDropsForNPC(ItemDropDatabase dropsDatabase, int npcId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x810164", Offset = "0x810164", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ApplyPass(BestiaryDatabase.BestiaryEntriesPass pass)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60046E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x810208", Offset = "0x810208", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public BestiaryDatabase()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40082B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<BestiaryEntry> _entries;

		[global::Cpp2ILInjected.Token(Token = "0x40082B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<IBestiaryEntryFilter> _filters;

		[global::Cpp2ILInjected.Token(Token = "0x40082B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IBestiarySortStep> _sortSteps;

		[global::Cpp2ILInjected.Token(Token = "0x40082B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Dictionary<int, BestiaryEntry> _byNpcId;

		[global::Cpp2ILInjected.Token(Token = "0x40082BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private BestiaryEntry _trashEntry;

		[global::Cpp2ILInjected.Token(Token = "0x2000918")]
		public delegate void BestiaryEntriesPass(BestiaryEntry entry);
	}
}
