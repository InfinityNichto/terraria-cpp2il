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
	[global::Cpp2ILInjected.Token(Token = "0x2000628")]
	public class EntryFilterer<T, U> where T : new() where U : IEntryFilter<T>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40076C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public List<U> AvailableFilters;

		[global::Cpp2ILInjected.Token(Token = "0x40076CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public List<U> ActiveFilters;

		[global::Cpp2ILInjected.Token(Token = "0x40076CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public List<U> AlwaysActiveFilters;

		[global::Cpp2ILInjected.Token(Token = "0x40076CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ISearchFilter<T> _searchFilter;

		[global::Cpp2ILInjected.Token(Token = "0x40076CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ISearchFilter<T> _searchFilterFromConstructor;
	}
}
