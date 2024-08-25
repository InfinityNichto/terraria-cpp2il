using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200037C")]
	public interface IBindingList : IList, ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700054F")]
		bool AllowNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001763")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001764")]
		object AddNew();

		[global::Cpp2ILInjected.Token(Token = "0x17000550")]
		bool AllowEdit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001765")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000551")]
		bool AllowRemove
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001766")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000552")]
		bool SupportsChangeNotification
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001767")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000553")]
		bool SupportsSearching
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001768")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000554")]
		bool SupportsSorting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001769")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000555")]
		bool IsSorted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600176A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000556")]
		PropertyDescriptor SortProperty
		{
			[global::Cpp2ILInjected.Token(Token = "0x600176B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000557")]
		ListSortDirection SortDirection
		{
			[global::Cpp2ILInjected.Token(Token = "0x600176C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000013")]
		event ListChangedEventHandler ListChanged;

		[global::Cpp2ILInjected.Token(Token = "0x600176F")]
		void AddIndex(PropertyDescriptor property);

		[global::Cpp2ILInjected.Token(Token = "0x6001770")]
		void ApplySort(PropertyDescriptor property, ListSortDirection direction);

		[global::Cpp2ILInjected.Token(Token = "0x6001771")]
		int Find(PropertyDescriptor property, object key);

		[global::Cpp2ILInjected.Token(Token = "0x6001772")]
		void RemoveIndex(PropertyDescriptor property);

		[global::Cpp2ILInjected.Token(Token = "0x6001773")]
		void RemoveSort();
	}
}
