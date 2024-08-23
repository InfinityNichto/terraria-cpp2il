using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.DataStructures
{
	// Token: 0x0200042D RID: 1069
	[global::Cpp2ILInjected.Token(Token = "0x2000628")]
	public class EntryFilterer<T, U> where T : new() where U : IEntryFilter<T>
	{
		// Token: 0x060030DA RID: 12506 RVA: 0x0002ABC6 File Offset: 0x00028DC6
		[global::Cpp2ILInjected.Token(Token = "0x60035F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x164119C", Offset = "0x164119C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = ".ctor", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public EntryFilterer()
		{
			throw null;
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x0002ABC9 File Offset: 0x00028DC9
		[global::Cpp2ILInjected.Token(Token = "0x60035F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641268", Offset = "0x1641268", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = ".ctor", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddFilters(List<U> filters)
		{
			throw null;
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0002ABCC File Offset: 0x00028DCC
		[global::Cpp2ILInjected.Token(Token = "0x60035F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641280", Offset = "0x1641280", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "<UpdateContents>b__63_0", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool FitsFilter(T entry)
		{
			throw null;
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x0002ABCF File Offset: 0x00028DCF
		[global::Cpp2ILInjected.Token(Token = "0x60035FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x164151C", Offset = "0x164151C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "ClickOption", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "singleFilterButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ToggleFilter(int filterIndex)
		{
			throw null;
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x0002ABD2 File Offset: 0x00028DD2
		[global::Cpp2ILInjected.Token(Token = "0x60035FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x164159C", Offset = "0x164159C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateButtonSelections", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "UpdateVisuals", MemberParameters = new object[]
		{
			typeof(UIImageFramed),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool IsFilterActive(int filterIndex)
		{
			throw null;
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x0002ABD5 File Offset: 0x00028DD5
		[global::Cpp2ILInjected.Token(Token = "0x60035FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C277C", Offset = "0x14C277C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = ".ctor", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void SetSearchFilterObject<Z>(Z searchFilter) where Z : ISearchFilter<T>, U
		{
			throw null;
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0002ABD8 File Offset: 0x00028DD8
		[global::Cpp2ILInjected.Token(Token = "0x60035FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x164166C", Offset = "0x164166C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "OnSearchContentsChanged", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "OnSearchContentsChanged", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetSearchFilter(string searchFilter)
		{
			throw null;
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0002ABDB File Offset: 0x00028DDB
		[global::Cpp2ILInjected.Token(Token = "0x60035FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641734", Offset = "0x1641734", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType0<>), Member = ".ctor", MemberParameters = new object[] { "<Count>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public string GetDisplayName()
		{
			throw null;
		}

		// Token: 0x040062DF RID: 25311
		[global::Cpp2ILInjected.Token(Token = "0x40076C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public List<U> AvailableFilters;

		// Token: 0x040062E0 RID: 25312
		[global::Cpp2ILInjected.Token(Token = "0x40076CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public List<U> ActiveFilters;

		// Token: 0x040062E1 RID: 25313
		[global::Cpp2ILInjected.Token(Token = "0x40076CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public List<U> AlwaysActiveFilters;

		// Token: 0x040062E2 RID: 25314
		[global::Cpp2ILInjected.Token(Token = "0x40076CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ISearchFilter<T> _searchFilter;

		// Token: 0x040062E3 RID: 25315
		[global::Cpp2ILInjected.Token(Token = "0x40076CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ISearchFilter<T> _searchFilterFromConstructor;
	}
}
