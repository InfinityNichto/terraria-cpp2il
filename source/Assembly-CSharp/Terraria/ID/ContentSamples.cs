using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Reflection;
using Terraria.GameContent.Bestiary;
using Terraria.Graphics.Shaders;

namespace Terraria.ID
{
	// Token: 0x020003E4 RID: 996
	[global::Cpp2ILInjected.Token(Token = "0x20005BD")]
	public static class ContentSamples
	{
		// Token: 0x0600303F RID: 12351 RVA: 0x0002AA07 File Offset: 0x00028C07
		[global::Cpp2ILInjected.Token(Token = "0x6003512")]
		[global::Cpp2ILInjected.Address(RVA = "0x1386070", Offset = "0x1386070", Length = "0x5CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples), Member = "ModifyNPCIds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples), Member = "FillResearchItemOverrides", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples), Member = "FillNpcRarities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x0002AA0A File Offset: 0x00028C0A
		[global::Cpp2ILInjected.Token(Token = "0x6003513")]
		[global::Cpp2ILInjected.Address(RVA = "0x13887E0", Offset = "0x13887E0", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void ResetItemTooltips()
		{
			throw null;
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0002AA0D File Offset: 0x00028C0D
		[global::Cpp2ILInjected.Token(Token = "0x6003514")]
		[global::Cpp2ILInjected.Address(RVA = "0x1388968", Offset = "0x1388968", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void RefreshItemsOnWorldLoad()
		{
			throw null;
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x0002AA10 File Offset: 0x00028C10
		[global::Cpp2ILInjected.Token(Token = "0x6003515")]
		[global::Cpp2ILInjected.Address(RVA = "0x1387648", Offset = "0x1387648", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples), Member = "AddItemResearchOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void FillResearchItemOverrides()
		{
			throw null;
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x0002AA13 File Offset: 0x00028C13
		[global::Cpp2ILInjected.Token(Token = "0x6003516")]
		[global::Cpp2ILInjected.Address(RVA = "0x1388AF0", Offset = "0x1388AF0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples), Member = "FillResearchItemOverrides", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples), Member = "AddItemResearchOverride_Inner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void AddItemResearchOverride(int itemTypeToUnlock, params int[] itemsThatWillResearchTheItemToUnlock)
		{
			throw null;
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x0002AA16 File Offset: 0x00028C16
		[global::Cpp2ILInjected.Token(Token = "0x6003517")]
		[global::Cpp2ILInjected.Address(RVA = "0x1388B88", Offset = "0x1388B88", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples), Member = "AddItemResearchOverride", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void AddItemResearchOverride_Inner(int itemTypeToSacrifice, int itemTypeToUnlock)
		{
			throw null;
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0002AA19 File Offset: 0x00028C19
		[global::Cpp2ILInjected.Token(Token = "0x6003518")]
		[global::Cpp2ILInjected.Address(RVA = "0x1388C10", Offset = "0x1388C10", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void FixItemsAfterRecipesAreAdded()
		{
			throw null;
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0002AA1C File Offset: 0x00028C1C
		[global::Cpp2ILInjected.Token(Token = "0x6003519")]
		[global::Cpp2ILInjected.Address(RVA = "0x1388DBC", Offset = "0x1388DBC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void RebuildBestiarySortingIDsByBestiaryDatabaseContents(BestiaryDatabase database)
		{
			throw null;
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x0002AA1F File Offset: 0x00028C1F
		[global::Cpp2ILInjected.Token(Token = "0x600351A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1388FDC", Offset = "0x1388FDC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PostContentLoadInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void RebuildItemCreativeSortingIDsAfterRecipesAreSetUp()
		{
			throw null;
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x0002AA22 File Offset: 0x00028C22
		[global::Cpp2ILInjected.Token(Token = "0x600351B")]
		[global::Cpp2ILInjected.Address(RVA = "0x138663C", Offset = "0x138663C", Length = "0x100C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void ModifyNPCIds()
		{
			throw null;
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0002AA25 File Offset: 0x00028C25
		[global::Cpp2ILInjected.Token(Token = "0x600351C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1388E38", Offset = "0x1388E38", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.BestiaryHelper), Member = "GetSortedBestiaryEntriesList", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(List<KeyValuePair<int, NPC>>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<KeyValuePair<int, object>>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<KeyValuePair<int, object>>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<KeyValuePair<int, object>>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static void CreateBestiarySortingIds(BestiaryDatabase database)
		{
			throw null;
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x0002AA28 File Offset: 0x00028C28
		[global::Cpp2ILInjected.Token(Token = "0x600351D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13877B0", Offset = "0x13877B0", Length = "0x1030")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples), Member = "GetNPCBestiaryRarityStarsCount", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void FillNpcRarities()
		{
			throw null;
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x0002AA2B File Offset: 0x00028C2B
		[global::Cpp2ILInjected.Token(Token = "0x600351E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13890A0", Offset = "0x13890A0", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples), Member = "FillNpcRarities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int GetNPCBestiaryRarityStarsCount(NPC npc)
		{
			throw null;
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0002AA2E File Offset: 0x00028C2E
		[global::Cpp2ILInjected.Token(Token = "0x600351F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1389050", Offset = "0x1389050", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.CreativeHelper), Member = "SetCreativeMenuOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void CreateCreativeItemSortingIds()
		{
			throw null;
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x0002AA31 File Offset: 0x00028C31
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003520")]
		[global::Cpp2ILInjected.Address(RVA = "0x13891D8", Offset = "0x13891D8", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		static ContentSamples()
		{
			throw null;
		}

		// Token: 0x0400357D RID: 13693
		[global::Cpp2ILInjected.Token(Token = "0x400476E")]
		public static Dictionary<int, NPC> NpcsByNetId;

		// Token: 0x0400357E RID: 13694
		[global::Cpp2ILInjected.Token(Token = "0x400476F")]
		public static Dictionary<int, Item> ItemsByType;

		// Token: 0x0400357F RID: 13695
		[global::Cpp2ILInjected.Token(Token = "0x4004770")]
		public static Dictionary<string, int> ItemNetIdsByPersistentIds;

		// Token: 0x04003580 RID: 13696
		[global::Cpp2ILInjected.Token(Token = "0x4004771")]
		public static Dictionary<int, string> ItemPersistentIdsByNetIds;

		// Token: 0x04003581 RID: 13697
		[global::Cpp2ILInjected.Token(Token = "0x4004772")]
		public static Dictionary<int, int> CreativeResearchItemPersistentIdOverride;

		// Token: 0x04003582 RID: 13698
		[global::Cpp2ILInjected.Token(Token = "0x4004773")]
		public static Dictionary<string, int> NpcNetIdsByPersistentIds;

		// Token: 0x04003583 RID: 13699
		[global::Cpp2ILInjected.Token(Token = "0x4004774")]
		public static Dictionary<int, string> NpcPersistentIdsByNetIds;

		// Token: 0x04003584 RID: 13700
		[global::Cpp2ILInjected.Token(Token = "0x4004775")]
		public static Dictionary<int, int> NpcBestiarySortingId;

		// Token: 0x04003585 RID: 13701
		[global::Cpp2ILInjected.Token(Token = "0x4004776")]
		public static Dictionary<int, int> NpcBestiaryRarityStars;

		// Token: 0x04003586 RID: 13702
		[global::Cpp2ILInjected.Token(Token = "0x4004777")]
		public static Dictionary<int, string> NpcBestiaryCreditIdsByNpcNetIds;

		// Token: 0x04003587 RID: 13703
		[global::Cpp2ILInjected.Token(Token = "0x4004778")]
		public static Dictionary<int, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> ItemCreativeSortingId;

		// Token: 0x0200091A RID: 2330
		[global::Cpp2ILInjected.Token(Token = "0x20005BE")]
		public static class CommonlyUsedContentSamples
		{
			// Token: 0x06004C63 RID: 19555 RVA: 0x0002F852 File Offset: 0x0002DA52
			[global::Cpp2ILInjected.Token(Token = "0x6003521")]
			[global::Cpp2ILInjected.Address(RVA = "0x1389484", Offset = "0x1389484", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PostContentLoadInitialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderDataSet), Member = "GetShaderIdFromItemId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetShaderIdFromItemId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public static void PrepareAfterEverythingElseLoaded()
			{
				throw null;
			}

			// Token: 0x06004C64 RID: 19556 RVA: 0x0002F855 File Offset: 0x0002DA55
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003522")]
			[global::Cpp2ILInjected.Address(RVA = "0x1389548", Offset = "0x1389548", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			static CommonlyUsedContentSamples()
			{
				throw null;
			}

			// Token: 0x04008961 RID: 35169
			[global::Cpp2ILInjected.Token(Token = "0x4004779")]
			public static int TeamDyeShaderIndex;

			// Token: 0x04008962 RID: 35170
			[global::Cpp2ILInjected.Token(Token = "0x400477A")]
			public static int ColorOnlyShaderIndex;
		}

		// Token: 0x0200091B RID: 2331
		[global::Cpp2ILInjected.Token(Token = "0x20005BF")]
		public static class CreativeHelper
		{
			// Token: 0x06004C65 RID: 19557 RVA: 0x0002F858 File Offset: 0x0002DA58
			[global::Cpp2ILInjected.Token(Token = "0x6003523")]
			[global::Cpp2ILInjected.Address(RVA = "0x1389594", Offset = "0x1389594", Length = "0x108C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup), Member = ".ctor", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "IndexOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsACoin", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_PaintOrCoating", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
			public static ContentSamples.CreativeHelper.ItemGroup GetItemGroup(Item item, out int orderInGroup)
			{
				throw null;
			}

			// Token: 0x06004C66 RID: 19558 RVA: 0x0002F85B File Offset: 0x0002DA5B
			[global::Cpp2ILInjected.Token(Token = "0x6003524")]
			[global::Cpp2ILInjected.Address(RVA = "0x138A620", Offset = "0x138A620", Length = "0x9F0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples), Member = "CreateCreativeItemSortingIds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
			{
				typeof(object),
				typeof(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup)
			}, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(Func<object, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>)
			}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup, Int32Enum>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "GroupBy", MemberTypeParameters = new object[]
			{
				typeof(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup),
				"System.Int32Enum"
			}, MemberParameters = new object[]
			{
				typeof(IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>),
				typeof(Func<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup, Int32Enum>)
			}, ReturnType = "System.Collections.Generic.IEnumerable`1<IGrouping`2<TKey, TSource>>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, int>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "OrderBy", MemberTypeParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(Func<object, int>)
			}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "SelectMany", MemberTypeParameters = new object[]
			{
				typeof(object),
				typeof(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup)
			}, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(Func<object, IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>>)
			}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup) }, MemberParameters = new object[] { typeof(IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 61)]
			public static void SetCreativeMenuOrder()
			{
				throw null;
			}

			// Token: 0x06004C67 RID: 19559 RVA: 0x0002F85E File Offset: 0x0002DA5E
			[global::Cpp2ILInjected.Token(Token = "0x6003525")]
			[global::Cpp2ILInjected.Address(RVA = "0x138B010", Offset = "0x138B010", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static bool ShouldRemoveFromList(Item item)
			{
				throw null;
			}

			// Token: 0x06004C68 RID: 19560 RVA: 0x0002F861 File Offset: 0x0002DA61
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003526")]
			[global::Cpp2ILInjected.Address(RVA = "0x138B078", Offset = "0x138B078", Length = "0x2278")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			static CreativeHelper()
			{
				throw null;
			}

			// Token: 0x04008963 RID: 35171
			[global::Cpp2ILInjected.Token(Token = "0x400477B")]
			private static List<int> _manualEventItemsOrder;

			// Token: 0x04008964 RID: 35172
			[global::Cpp2ILInjected.Token(Token = "0x400477C")]
			private static List<int> _manualBossSpawnItemsOrder;

			// Token: 0x04008965 RID: 35173
			[global::Cpp2ILInjected.Token(Token = "0x400477D")]
			public static List<int> _manualCraftingStations;

			// Token: 0x04008966 RID: 35174
			[global::Cpp2ILInjected.Token(Token = "0x400477E")]
			private static List<int> _manualGolfItemsOrder;

			// Token: 0x02000B74 RID: 2932
			[global::Cpp2ILInjected.Token(Token = "0x20005C0")]
			public enum ItemGroup
			{
				// Token: 0x04009047 RID: 36935
				[global::Cpp2ILInjected.Token(Token = "0x4004780")]
				Coin = 10,
				// Token: 0x04009048 RID: 36936
				[global::Cpp2ILInjected.Token(Token = "0x4004781")]
				CraftingObjects,
				// Token: 0x04009049 RID: 36937
				[global::Cpp2ILInjected.Token(Token = "0x4004782")]
				Torches = 20,
				// Token: 0x0400904A RID: 36938
				[global::Cpp2ILInjected.Token(Token = "0x4004783")]
				Glowsticks = 25,
				// Token: 0x0400904B RID: 36939
				[global::Cpp2ILInjected.Token(Token = "0x4004784")]
				Wood = 30,
				// Token: 0x0400904C RID: 36940
				[global::Cpp2ILInjected.Token(Token = "0x4004785")]
				Bombs = 40,
				// Token: 0x0400904D RID: 36941
				[global::Cpp2ILInjected.Token(Token = "0x4004786")]
				LifePotions = 50,
				// Token: 0x0400904E RID: 36942
				[global::Cpp2ILInjected.Token(Token = "0x4004787")]
				ManaPotions,
				// Token: 0x0400904F RID: 36943
				[global::Cpp2ILInjected.Token(Token = "0x4004788")]
				BuffPotion,
				// Token: 0x04009050 RID: 36944
				[global::Cpp2ILInjected.Token(Token = "0x4004789")]
				Flask,
				// Token: 0x04009051 RID: 36945
				[global::Cpp2ILInjected.Token(Token = "0x400478A")]
				Food,
				// Token: 0x04009052 RID: 36946
				[global::Cpp2ILInjected.Token(Token = "0x400478B")]
				Crates = 60,
				// Token: 0x04009053 RID: 36947
				[global::Cpp2ILInjected.Token(Token = "0x400478C")]
				BossBags = 70,
				// Token: 0x04009054 RID: 36948
				[global::Cpp2ILInjected.Token(Token = "0x400478D")]
				GoodieBags = 80,
				// Token: 0x04009055 RID: 36949
				[global::Cpp2ILInjected.Token(Token = "0x400478E")]
				AlchemyPlants = 83,
				// Token: 0x04009056 RID: 36950
				[global::Cpp2ILInjected.Token(Token = "0x400478F")]
				AlchemySeeds,
				// Token: 0x04009057 RID: 36951
				[global::Cpp2ILInjected.Token(Token = "0x4004790")]
				DyeMaterial = 87,
				// Token: 0x04009058 RID: 36952
				[global::Cpp2ILInjected.Token(Token = "0x4004791")]
				BossItem = 90,
				// Token: 0x04009059 RID: 36953
				[global::Cpp2ILInjected.Token(Token = "0x4004792")]
				EventItem,
				// Token: 0x0400905A RID: 36954
				[global::Cpp2ILInjected.Token(Token = "0x4004793")]
				ConsumableThatDoesNotDamage = 94,
				// Token: 0x0400905B RID: 36955
				[global::Cpp2ILInjected.Token(Token = "0x4004794")]
				Solutions,
				// Token: 0x0400905C RID: 36956
				[global::Cpp2ILInjected.Token(Token = "0x4004795")]
				Ammo,
				// Token: 0x0400905D RID: 36957
				[global::Cpp2ILInjected.Token(Token = "0x4004796")]
				ConsumableThatDamages,
				// Token: 0x0400905E RID: 36958
				[global::Cpp2ILInjected.Token(Token = "0x4004797")]
				PlacableObjects = 100,
				// Token: 0x0400905F RID: 36959
				[global::Cpp2ILInjected.Token(Token = "0x4004798")]
				Blocks = 120,
				// Token: 0x04009060 RID: 36960
				[global::Cpp2ILInjected.Token(Token = "0x4004799")]
				Wands = 130,
				// Token: 0x04009061 RID: 36961
				[global::Cpp2ILInjected.Token(Token = "0x400479A")]
				Rope = 140,
				// Token: 0x04009062 RID: 36962
				[global::Cpp2ILInjected.Token(Token = "0x400479B")]
				Walls = 150,
				// Token: 0x04009063 RID: 36963
				[global::Cpp2ILInjected.Token(Token = "0x400479C")]
				Wiring = 200,
				// Token: 0x04009064 RID: 36964
				[global::Cpp2ILInjected.Token(Token = "0x400479D")]
				Pickaxe = 500,
				// Token: 0x04009065 RID: 36965
				[global::Cpp2ILInjected.Token(Token = "0x400479E")]
				Axe = 510,
				// Token: 0x04009066 RID: 36966
				[global::Cpp2ILInjected.Token(Token = "0x400479F")]
				Hammer = 520,
				// Token: 0x04009067 RID: 36967
				[global::Cpp2ILInjected.Token(Token = "0x40047A0")]
				MeleeWeapon = 530,
				// Token: 0x04009068 RID: 36968
				[global::Cpp2ILInjected.Token(Token = "0x40047A1")]
				RangedWeapon = 540,
				// Token: 0x04009069 RID: 36969
				[global::Cpp2ILInjected.Token(Token = "0x40047A2")]
				MagicWeapon = 550,
				// Token: 0x0400906A RID: 36970
				[global::Cpp2ILInjected.Token(Token = "0x40047A3")]
				SummonWeapon = 560,
				// Token: 0x0400906B RID: 36971
				[global::Cpp2ILInjected.Token(Token = "0x40047A4")]
				Headgear = 600,
				// Token: 0x0400906C RID: 36972
				[global::Cpp2ILInjected.Token(Token = "0x40047A5")]
				Torso = 610,
				// Token: 0x0400906D RID: 36973
				[global::Cpp2ILInjected.Token(Token = "0x40047A6")]
				Pants = 620,
				// Token: 0x0400906E RID: 36974
				[global::Cpp2ILInjected.Token(Token = "0x40047A7")]
				Accessories = 630,
				// Token: 0x0400906F RID: 36975
				[global::Cpp2ILInjected.Token(Token = "0x40047A8")]
				Hook = 700,
				// Token: 0x04009070 RID: 36976
				[global::Cpp2ILInjected.Token(Token = "0x40047A9")]
				Mount = 710,
				// Token: 0x04009071 RID: 36977
				[global::Cpp2ILInjected.Token(Token = "0x40047AA")]
				Minecart = 720,
				// Token: 0x04009072 RID: 36978
				[global::Cpp2ILInjected.Token(Token = "0x40047AB")]
				VanityPet = 800,
				// Token: 0x04009073 RID: 36979
				[global::Cpp2ILInjected.Token(Token = "0x40047AC")]
				LightPet = 810,
				// Token: 0x04009074 RID: 36980
				[global::Cpp2ILInjected.Token(Token = "0x40047AD")]
				Golf = 900,
				// Token: 0x04009075 RID: 36981
				[global::Cpp2ILInjected.Token(Token = "0x40047AE")]
				BossSpawners,
				// Token: 0x04009076 RID: 36982
				[global::Cpp2ILInjected.Token(Token = "0x40047AF")]
				Dye = 910,
				// Token: 0x04009077 RID: 36983
				[global::Cpp2ILInjected.Token(Token = "0x40047B0")]
				HairDye = 920,
				// Token: 0x04009078 RID: 36984
				[global::Cpp2ILInjected.Token(Token = "0x40047B1")]
				Paint = 930,
				// Token: 0x04009079 RID: 36985
				[global::Cpp2ILInjected.Token(Token = "0x40047B2")]
				FishingRods = 1000,
				// Token: 0x0400907A RID: 36986
				[global::Cpp2ILInjected.Token(Token = "0x40047B3")]
				FishingQuestFish = 1010,
				// Token: 0x0400907B RID: 36987
				[global::Cpp2ILInjected.Token(Token = "0x40047B4")]
				Fish = 1015,
				// Token: 0x0400907C RID: 36988
				[global::Cpp2ILInjected.Token(Token = "0x40047B5")]
				FishingBait = 1020,
				// Token: 0x0400907D RID: 36989
				[global::Cpp2ILInjected.Token(Token = "0x40047B6")]
				Critters = 1030,
				// Token: 0x0400907E RID: 36990
				[global::Cpp2ILInjected.Token(Token = "0x40047B7")]
				Keys = 2000,
				// Token: 0x0400907F RID: 36991
				[global::Cpp2ILInjected.Token(Token = "0x40047B8")]
				RemainingUseItems = 5000,
				// Token: 0x04009080 RID: 36992
				[global::Cpp2ILInjected.Token(Token = "0x40047B9")]
				Material = 10000,
				// Token: 0x04009081 RID: 36993
				[global::Cpp2ILInjected.Token(Token = "0x40047BA")]
				EverythingElse = 11000
			}

			// Token: 0x02000B75 RID: 2933
			[global::Cpp2ILInjected.Token(Token = "0x20005C1")]
			public struct ItemGroupAndOrderInGroup
			{
				// Token: 0x06005361 RID: 21345 RVA: 0x00030B15 File Offset: 0x0002ED15
				[global::Cpp2ILInjected.Token(Token = "0x6003527")]
				[global::Cpp2ILInjected.Address(RVA = "0x138D2F0", Offset = "0x138D2F0", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.ContentSamples.CreativeHelper.<>c", Member = "<SetCreativeMenuOrder>b__7_0", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.CreativeHelper), Member = "GetItemGroup", MemberParameters = new object[]
				{
					typeof(Item),
					typeof(ref int)
				}, ReturnType = typeof(ContentSamples.CreativeHelper.ItemGroup))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				public ItemGroupAndOrderInGroup(Item item)
				{
					throw null;
				}

				// Token: 0x04009082 RID: 36994
				[global::Cpp2ILInjected.Token(Token = "0x40047BB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public int ItemType;

				// Token: 0x04009083 RID: 36995
				[global::Cpp2ILInjected.Token(Token = "0x40047BC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
				public ContentSamples.CreativeHelper.ItemGroup Group;

				// Token: 0x04009084 RID: 36996
				[global::Cpp2ILInjected.Token(Token = "0x40047BD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				public int OrderInGroup;
			}

			// Token: 0x02000B76 RID: 2934
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20005C2")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005362 RID: 21346 RVA: 0x00030B18 File Offset: 0x0002ED18
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6003528")]
				[global::Cpp2ILInjected.Address(RVA = "0x138D368", Offset = "0x138D368", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x06005363 RID: 21347 RVA: 0x00030B1B File Offset: 0x0002ED1B
				[global::Cpp2ILInjected.Token(Token = "0x6003529")]
				[global::Cpp2ILInjected.Address(RVA = "0x138D3C4", Offset = "0x138D3C4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x06005364 RID: 21348 RVA: 0x00030B1E File Offset: 0x0002ED1E
				[global::Cpp2ILInjected.Token(Token = "0x600352A")]
				[global::Cpp2ILInjected.Address(RVA = "0x138D3CC", Offset = "0x138D3CC", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup), Member = ".ctor", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
				internal ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup <SetCreativeMenuOrder>b__7_0(Item x)
				{
					throw null;
				}

				// Token: 0x06005365 RID: 21349 RVA: 0x00030B21 File Offset: 0x0002ED21
				[global::Cpp2ILInjected.Token(Token = "0x600352B")]
				[global::Cpp2ILInjected.Address(RVA = "0x138D3F8", Offset = "0x138D3F8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal ContentSamples.CreativeHelper.ItemGroup <SetCreativeMenuOrder>b__7_1(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup x)
				{
					throw null;
				}

				// Token: 0x06005366 RID: 21350 RVA: 0x00030B24 File Offset: 0x0002ED24
				[global::Cpp2ILInjected.Token(Token = "0x600352C")]
				[global::Cpp2ILInjected.Address(RVA = "0x138D400", Offset = "0x138D400", Length = "0x94")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				internal int <SetCreativeMenuOrder>b__7_2(IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> group)
				{
					throw null;
				}

				// Token: 0x06005367 RID: 21351 RVA: 0x00030B27 File Offset: 0x0002ED27
				[global::Cpp2ILInjected.Token(Token = "0x600352D")]
				[global::Cpp2ILInjected.Address(RVA = "0x138D494", Offset = "0x138D494", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup) }, MemberParameters = new object[] { typeof(IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> <SetCreativeMenuOrder>b__7_3(IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> group)
				{
					throw null;
				}

				// Token: 0x04009085 RID: 36997
				[global::Cpp2ILInjected.Token(Token = "0x40047BE")]
				public static readonly ContentSamples.CreativeHelper.<>c <>9;

				// Token: 0x04009086 RID: 36998
				[global::Cpp2ILInjected.Token(Token = "0x40047BF")]
				public static Func<Item, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> <>9__7_0;

				// Token: 0x04009087 RID: 36999
				[global::Cpp2ILInjected.Token(Token = "0x40047C0")]
				public static Func<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup, ContentSamples.CreativeHelper.ItemGroup> <>9__7_1;

				// Token: 0x04009088 RID: 37000
				[global::Cpp2ILInjected.Token(Token = "0x40047C1")]
				public static Func<IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>, int> <>9__7_2;

				// Token: 0x04009089 RID: 37001
				[global::Cpp2ILInjected.Token(Token = "0x40047C2")]
				public static Func<IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>, IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>> <>9__7_3;
			}
		}

		// Token: 0x0200091C RID: 2332
		[global::Cpp2ILInjected.Token(Token = "0x20005C3")]
		public static class BestiaryHelper
		{
			// Token: 0x06004C69 RID: 19561 RVA: 0x0002F864 File Offset: 0x0002DA64
			[global::Cpp2ILInjected.Token(Token = "0x600352E")]
			[global::Cpp2ILInjected.Address(RVA = "0x138D4DC", Offset = "0x138D4DC", Length = "0x78C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples), Member = "CreateBestiarySortingIds", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabaseNPCsPopulator.CommonTags), Member = "GetCommonInfoElementsForFilters", ReturnType = typeof(List<IBestiaryInfoElement>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<int, object>, int>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new object[] { "TSource", "TKey" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>" }, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<int, object>, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new object[] { "TSource", "TKey" }, MemberParameters = new object[] { "System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>" }, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ThenBy", MemberTypeParameters = new object[]
			{
				typeof(KeyValuePair<int, object>),
				typeof(int)
			}, MemberParameters = new object[]
			{
				typeof(IOrderedEnumerable<KeyValuePair<int, object>>),
				typeof(Func<KeyValuePair<int, object>, int>)
			}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<int, object>, float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ThenBy", MemberTypeParameters = new object[]
			{
				typeof(KeyValuePair<int, object>),
				typeof(float)
			}, MemberParameters = new object[]
			{
				typeof(IOrderedEnumerable<KeyValuePair<int, object>>),
				typeof(Func<KeyValuePair<int, object>, float>)
			}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<KeyValuePair<int, object>>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<KeyValuePair<int, object>>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<KeyValuePair<int, object>>) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
			public static List<KeyValuePair<int, NPC>> GetSortedBestiaryEntriesList(BestiaryDatabase database)
			{
				throw null;
			}

			// Token: 0x06004C6A RID: 19562 RVA: 0x0002F867 File Offset: 0x0002DA67
			[global::Cpp2ILInjected.Token(Token = "0x600352F")]
			[global::Cpp2ILInjected.Address(RVA = "0x138DC70", Offset = "0x138DC70", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.BestiaryHelper.<>c__DisplayClass0_0), Member = "<GetSortedBestiaryEntriesList>b__6", MemberParameters = new object[] { typeof(KeyValuePair<int, NPC>) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static int GetLowestBiomeGroupIndex(NPC npc, BestiaryDatabase database, List<IBestiaryInfoElement> commonElements)
			{
				throw null;
			}

			// Token: 0x06004C6B RID: 19563 RVA: 0x0002F86A File Offset: 0x0002DA6A
			[global::Cpp2ILInjected.Token(Token = "0x6003530")]
			[global::Cpp2ILInjected.Address(RVA = "0x138DD34", Offset = "0x138DD34", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.BestiaryHelper.<>c), Member = "<GetSortedBestiaryEntriesList>b__0_10", MemberParameters = new object[] { typeof(KeyValuePair<int, NPC>) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "TryGetValue", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref NPCID.Sets.NPCBestiaryDrawModifiers)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static bool ShouldHideBestiaryEntry(NPC npc)
			{
				throw null;
			}

			// Token: 0x06004C6C RID: 19564 RVA: 0x0002F86D File Offset: 0x0002DA6D
			[global::Cpp2ILInjected.Token(Token = "0x6003531")]
			[global::Cpp2ILInjected.Address(RVA = "0x138DDE0", Offset = "0x138DDE0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static float GetBestiaryPowerLevel(NPC npc)
			{
				throw null;
			}

			// Token: 0x06004C6D RID: 19565 RVA: 0x0002F870 File Offset: 0x0002DA70
			[global::Cpp2ILInjected.Token(Token = "0x6003532")]
			[global::Cpp2ILInjected.Address(RVA = "0x138DE08", Offset = "0x138DE08", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.BestiaryHelper.<>c), Member = "<GetSortedBestiaryEntriesList>b__0_0", MemberParameters = new object[] { typeof(KeyValuePair<int, NPC>) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "IndexOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static int GetBestiaryTownPriority(NPC npc)
			{
				throw null;
			}

			// Token: 0x06004C6E RID: 19566 RVA: 0x0002F873 File Offset: 0x0002DA73
			[global::Cpp2ILInjected.Token(Token = "0x6003533")]
			[global::Cpp2ILInjected.Address(RVA = "0x138DE90", Offset = "0x138DE90", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.BestiaryHelper.<>c), Member = "<GetSortedBestiaryEntriesList>b__0_2", MemberParameters = new object[] { typeof(KeyValuePair<int, NPC>) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "IndexOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static int GetBestiaryNormalGoldCritterPriority(NPC npc)
			{
				throw null;
			}

			// Token: 0x06004C6F RID: 19567 RVA: 0x0002F876 File Offset: 0x0002DA76
			[global::Cpp2ILInjected.Token(Token = "0x6003534")]
			[global::Cpp2ILInjected.Address(RVA = "0x138DF18", Offset = "0x138DF18", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.BestiaryHelper.<>c), Member = "<GetSortedBestiaryEntriesList>b__0_4", MemberParameters = new object[] { typeof(KeyValuePair<int, NPC>) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "IndexOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static int GetBestiaryBossPriority(NPC npc)
			{
				throw null;
			}

			// Token: 0x06004C70 RID: 19568 RVA: 0x0002F879 File Offset: 0x0002DA79
			[global::Cpp2ILInjected.Token(Token = "0x6003535")]
			[global::Cpp2ILInjected.Address(RVA = "0x138DF90", Offset = "0x138DF90", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.BestiaryHelper.<>c), Member = "<GetSortedBestiaryEntriesList>b__0_9", MemberParameters = new object[] { typeof(KeyValuePair<int, NPC>) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static int GetBestiaryStarsPriority(NPC npc)
			{
				throw null;
			}

			// Token: 0x02000B77 RID: 2935
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20005C4")]
			private sealed class <>c__DisplayClass0_0
			{
				// Token: 0x06005368 RID: 21352 RVA: 0x00030B2A File Offset: 0x0002ED2A
				[global::Cpp2ILInjected.Token(Token = "0x6003536")]
				[global::Cpp2ILInjected.Address(RVA = "0x138DC68", Offset = "0x138DC68", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass0_0()
				{
					throw null;
				}

				// Token: 0x06005369 RID: 21353 RVA: 0x00030B2D File Offset: 0x0002ED2D
				[global::Cpp2ILInjected.Token(Token = "0x6003537")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E008", Offset = "0x138E008", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.BestiaryHelper), Member = "GetLowestBiomeGroupIndex", MemberParameters = new object[]
				{
					typeof(NPC),
					typeof(BestiaryDatabase),
					typeof(List<IBestiaryInfoElement>)
				}, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal int <GetSortedBestiaryEntriesList>b__6(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x0400908A RID: 37002
				[global::Cpp2ILInjected.Token(Token = "0x40047C3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public BestiaryDatabase database;

				// Token: 0x0400908B RID: 37003
				[global::Cpp2ILInjected.Token(Token = "0x40047C4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				public List<IBestiaryInfoElement> commonFilters;
			}

			// Token: 0x02000B78 RID: 2936
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20005C5")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600536A RID: 21354 RVA: 0x00030B30 File Offset: 0x0002ED30
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6003538")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E04C", Offset = "0x138E04C", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x0600536B RID: 21355 RVA: 0x00030B33 File Offset: 0x0002ED33
				[global::Cpp2ILInjected.Token(Token = "0x6003539")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E0A8", Offset = "0x138E0A8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x0600536C RID: 21356 RVA: 0x00030B36 File Offset: 0x0002ED36
				[global::Cpp2ILInjected.Token(Token = "0x600353A")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E0B0", Offset = "0x138E0B0", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.BestiaryHelper), Member = "GetBestiaryTownPriority", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal int <GetSortedBestiaryEntriesList>b__0_0(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x0600536D RID: 21357 RVA: 0x00030B39 File Offset: 0x0002ED39
				[global::Cpp2ILInjected.Token(Token = "0x600353B")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E0EC", Offset = "0x138E0EC", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_isLikeATownNPC", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <GetSortedBestiaryEntriesList>b__0_1(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x0600536E RID: 21358 RVA: 0x00030B3C File Offset: 0x0002ED3C
				[global::Cpp2ILInjected.Token(Token = "0x600353C")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E138", Offset = "0x138E138", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.BestiaryHelper), Member = "GetBestiaryNormalGoldCritterPriority", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal int <GetSortedBestiaryEntriesList>b__0_2(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x0600536F RID: 21359 RVA: 0x00030B3F File Offset: 0x0002ED3F
				[global::Cpp2ILInjected.Token(Token = "0x600353D")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E174", Offset = "0x138E174", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_CountsAsACritter", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <GetSortedBestiaryEntriesList>b__0_3(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x06005370 RID: 21360 RVA: 0x00030B42 File Offset: 0x0002ED42
				[global::Cpp2ILInjected.Token(Token = "0x600353E")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E1C0", Offset = "0x138E1C0", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.BestiaryHelper), Member = "GetBestiaryBossPriority", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal int <GetSortedBestiaryEntriesList>b__0_4(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x06005371 RID: 21361 RVA: 0x00030B45 File Offset: 0x0002ED45
				[global::Cpp2ILInjected.Token(Token = "0x600353F")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E1FC", Offset = "0x138E1FC", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				internal bool <GetSortedBestiaryEntriesList>b__0_5(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x06005372 RID: 21362 RVA: 0x00030B48 File Offset: 0x0002ED48
				[global::Cpp2ILInjected.Token(Token = "0x6003540")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E288", Offset = "0x138E288", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal int <GetSortedBestiaryEntriesList>b__0_7(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x06005373 RID: 21363 RVA: 0x00030B4B File Offset: 0x0002ED4B
				[global::Cpp2ILInjected.Token(Token = "0x6003541")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E2C4", Offset = "0x138E2C4", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal float <GetSortedBestiaryEntriesList>b__0_8(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x06005374 RID: 21364 RVA: 0x00030B4E File Offset: 0x0002ED4E
				[global::Cpp2ILInjected.Token(Token = "0x6003542")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E320", Offset = "0x138E320", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.BestiaryHelper), Member = "GetBestiaryStarsPriority", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal int <GetSortedBestiaryEntriesList>b__0_9(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x06005375 RID: 21365 RVA: 0x00030B51 File Offset: 0x0002ED51
				[global::Cpp2ILInjected.Token(Token = "0x6003543")]
				[global::Cpp2ILInjected.Address(RVA = "0x138E35C", Offset = "0x138E35C", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples.BestiaryHelper), Member = "ShouldHideBestiaryEntry", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <GetSortedBestiaryEntriesList>b__0_10(KeyValuePair<int, NPC> x)
				{
					throw null;
				}

				// Token: 0x0400908C RID: 37004
				[global::Cpp2ILInjected.Token(Token = "0x40047C5")]
				public static readonly ContentSamples.BestiaryHelper.<>c <>9;

				// Token: 0x0400908D RID: 37005
				[global::Cpp2ILInjected.Token(Token = "0x40047C6")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_0;

				// Token: 0x0400908E RID: 37006
				[global::Cpp2ILInjected.Token(Token = "0x40047C7")]
				public static Func<KeyValuePair<int, NPC>, bool> <>9__0_1;

				// Token: 0x0400908F RID: 37007
				[global::Cpp2ILInjected.Token(Token = "0x40047C8")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_2;

				// Token: 0x04009090 RID: 37008
				[global::Cpp2ILInjected.Token(Token = "0x40047C9")]
				public static Func<KeyValuePair<int, NPC>, bool> <>9__0_3;

				// Token: 0x04009091 RID: 37009
				[global::Cpp2ILInjected.Token(Token = "0x40047CA")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_4;

				// Token: 0x04009092 RID: 37010
				[global::Cpp2ILInjected.Token(Token = "0x40047CB")]
				public static Func<KeyValuePair<int, NPC>, bool> <>9__0_5;

				// Token: 0x04009093 RID: 37011
				[global::Cpp2ILInjected.Token(Token = "0x40047CC")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_7;

				// Token: 0x04009094 RID: 37012
				[global::Cpp2ILInjected.Token(Token = "0x40047CD")]
				public static Func<KeyValuePair<int, NPC>, float> <>9__0_8;

				// Token: 0x04009095 RID: 37013
				[global::Cpp2ILInjected.Token(Token = "0x40047CE")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_9;

				// Token: 0x04009096 RID: 37014
				[global::Cpp2ILInjected.Token(Token = "0x40047CF")]
				public static Predicate<KeyValuePair<int, NPC>> <>9__0_10;
			}
		}
	}
}
