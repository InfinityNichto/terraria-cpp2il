using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000612 RID: 1554
	[global::Cpp2ILInjected.Token(Token = "0x2000917")]
	public class BestiaryDatabase
	{
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06003E30 RID: 15920 RVA: 0x0002D1C4 File Offset: 0x0002B3C4
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

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06003E31 RID: 15921 RVA: 0x0002D1C7 File Offset: 0x0002B3C7
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

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x0002D1CA File Offset: 0x0002B3CA
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

		// Token: 0x06003E33 RID: 15923 RVA: 0x0002D1CD File Offset: 0x0002B3CD
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

		// Token: 0x06003E34 RID: 15924 RVA: 0x0002D1D0 File Offset: 0x0002B3D0
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

		// Token: 0x06003E35 RID: 15925 RVA: 0x0002D1D3 File Offset: 0x0002B3D3
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

		// Token: 0x06003E36 RID: 15926 RVA: 0x0002D1D6 File Offset: 0x0002B3D6
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

		// Token: 0x06003E37 RID: 15927 RVA: 0x0002D1D9 File Offset: 0x0002B3D9
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

		// Token: 0x06003E38 RID: 15928 RVA: 0x0002D1DC File Offset: 0x0002B3DC
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

		// Token: 0x06003E39 RID: 15929 RVA: 0x0002D1DF File Offset: 0x0002B3DF
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

		// Token: 0x06003E3A RID: 15930 RVA: 0x0002D1E2 File Offset: 0x0002B3E2
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

		// Token: 0x04006C35 RID: 27701
		[global::Cpp2ILInjected.Token(Token = "0x40082B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<BestiaryEntry> _entries;

		// Token: 0x04006C36 RID: 27702
		[global::Cpp2ILInjected.Token(Token = "0x40082B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<IBestiaryEntryFilter> _filters;

		// Token: 0x04006C37 RID: 27703
		[global::Cpp2ILInjected.Token(Token = "0x40082B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IBestiarySortStep> _sortSteps;

		// Token: 0x04006C38 RID: 27704
		[global::Cpp2ILInjected.Token(Token = "0x40082B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Dictionary<int, BestiaryEntry> _byNpcId;

		// Token: 0x04006C39 RID: 27705
		[global::Cpp2ILInjected.Token(Token = "0x40082BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private BestiaryEntry _trashEntry;

		// Token: 0x02000A0F RID: 2575
		// (Invoke) Token: 0x06004F7A RID: 20346
		[global::Cpp2ILInjected.Token(Token = "0x2000918")]
		public delegate void BestiaryEntriesPass(BestiaryEntry entry);
	}
}
