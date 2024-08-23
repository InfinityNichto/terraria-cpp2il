using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x02000286 RID: 646
	[global::Cpp2ILInjected.Token(Token = "0x200037D")]
	public interface IBindingListView : IBindingList, IList, ICollection, IEnumerable
	{
		// Token: 0x06001529 RID: 5417
		[global::Cpp2ILInjected.Token(Token = "0x6001774")]
		void ApplySort(ListSortDescriptionCollection sorts);

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600152A RID: 5418
		// (set) Token: 0x0600152B RID: 5419
		[global::Cpp2ILInjected.Token(Token = "0x17000558")]
		string Filter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001775")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001776")]
			set;
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600152C RID: 5420
		[global::Cpp2ILInjected.Token(Token = "0x17000559")]
		ListSortDescriptionCollection SortDescriptions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001777")]
			get;
		}

		// Token: 0x0600152D RID: 5421
		[global::Cpp2ILInjected.Token(Token = "0x6001778")]
		void RemoveFilter();

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600152E RID: 5422
		[global::Cpp2ILInjected.Token(Token = "0x1700055A")]
		bool SupportsAdvancedSorting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001779")]
			get;
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600152F RID: 5423
		[global::Cpp2ILInjected.Token(Token = "0x1700055B")]
		bool SupportsFiltering
		{
			[global::Cpp2ILInjected.Token(Token = "0x600177A")]
			get;
		}
	}
}
