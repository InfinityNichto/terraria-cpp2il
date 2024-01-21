using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000430")]
public class EntryFilterer<T, U> where T : new() where U : IEntryFilter<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062E0")]
	public List<U> AvailableFilters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062E1")]
	public List<U> ActiveFilters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062E2")]
	public List<U> AlwaysActiveFilters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062E3")]
	private ISearchFilter<T> _searchFilter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062E4")]
	private ISearchFilter<T> _searchFilterFromConstructor;

	[Cpp2IlInjected.Token(Token = "0x6003116")]
	[Cpp2IlInjected.Address(RVA = "0x163DC5C", Offset = "0x163DC5C", VA = "0x163DC5C")]
	public EntryFilterer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003117")]
	[Cpp2IlInjected.Address(RVA = "0x163DD50", Offset = "0x163DD50", VA = "0x163DD50")]
	public void AddFilters(List<U> filters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003118")]
	[Cpp2IlInjected.Address(RVA = "0x163DD68", Offset = "0x163DD68", VA = "0x163DD68")]
	public bool FitsFilter(T entry)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003119")]
	[Cpp2IlInjected.Address(RVA = "0x163E064", Offset = "0x163E064", VA = "0x163E064")]
	public void ToggleFilter(int filterIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600311A")]
	[Cpp2IlInjected.Address(RVA = "0x163E0D8", Offset = "0x163E0D8", VA = "0x163E0D8")]
	public bool IsFilterActive(int filterIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600311B")]
	[Cpp2IlInjected.Address(RVA = "0x15A57F4", Offset = "0x15A57F4", VA = "0x15A57F4")]
	public void SetSearchFilterObject<Z>(Z searchFilter) where Z : ISearchFilter<T>, U
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600311C")]
	[Cpp2IlInjected.Address(RVA = "0x163E1B8", Offset = "0x163E1B8", VA = "0x163E1B8")]
	public void SetSearchFilter(string searchFilter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600311D")]
	[Cpp2IlInjected.Address(RVA = "0x163E288", Offset = "0x163E288", VA = "0x163E288")]
	public string GetDisplayName()
	{
		return null;
	}
}
