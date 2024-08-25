using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200037D")]
	public interface IBindingListView : IBindingList, IList, ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001774")]
		void ApplySort(ListSortDescriptionCollection sorts);

		[global::Cpp2ILInjected.Token(Token = "0x17000558")]
		string Filter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001775")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001776")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000559")]
		ListSortDescriptionCollection SortDescriptions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001777")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001778")]
		void RemoveFilter();

		[global::Cpp2ILInjected.Token(Token = "0x1700055A")]
		bool SupportsAdvancedSorting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001779")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700055B")]
		bool SupportsFiltering
		{
			[global::Cpp2ILInjected.Token(Token = "0x600177A")]
			get;
		}
	}
}
