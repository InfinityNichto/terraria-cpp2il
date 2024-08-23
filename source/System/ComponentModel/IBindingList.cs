using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x02000285 RID: 645
	[global::Cpp2ILInjected.Token(Token = "0x200037C")]
	public interface IBindingList : IList, ICollection, IEnumerable
	{
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001518 RID: 5400
		[global::Cpp2ILInjected.Token(Token = "0x1700054F")]
		bool AllowNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001763")]
			get;
		}

		// Token: 0x06001519 RID: 5401
		[global::Cpp2ILInjected.Token(Token = "0x6001764")]
		object AddNew();

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600151A RID: 5402
		[global::Cpp2ILInjected.Token(Token = "0x17000550")]
		bool AllowEdit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001765")]
			get;
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600151B RID: 5403
		[global::Cpp2ILInjected.Token(Token = "0x17000551")]
		bool AllowRemove
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001766")]
			get;
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600151C RID: 5404
		[global::Cpp2ILInjected.Token(Token = "0x17000552")]
		bool SupportsChangeNotification
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001767")]
			get;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600151D RID: 5405
		[global::Cpp2ILInjected.Token(Token = "0x17000553")]
		bool SupportsSearching
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001768")]
			get;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600151E RID: 5406
		[global::Cpp2ILInjected.Token(Token = "0x17000554")]
		bool SupportsSorting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001769")]
			get;
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600151F RID: 5407
		[global::Cpp2ILInjected.Token(Token = "0x17000555")]
		bool IsSorted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600176A")]
			get;
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001520 RID: 5408
		[global::Cpp2ILInjected.Token(Token = "0x17000556")]
		PropertyDescriptor SortProperty
		{
			[global::Cpp2ILInjected.Token(Token = "0x600176B")]
			get;
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001521 RID: 5409
		[global::Cpp2ILInjected.Token(Token = "0x17000557")]
		ListSortDirection SortDirection
		{
			[global::Cpp2ILInjected.Token(Token = "0x600176C")]
			get;
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001522 RID: 5410
		// (remove) Token: 0x06001523 RID: 5411
		[global::Cpp2ILInjected.Token(Token = "0x14000013")]
		event ListChangedEventHandler ListChanged;

		// Token: 0x06001524 RID: 5412
		[global::Cpp2ILInjected.Token(Token = "0x600176F")]
		void AddIndex(PropertyDescriptor property);

		// Token: 0x06001525 RID: 5413
		[global::Cpp2ILInjected.Token(Token = "0x6001770")]
		void ApplySort(PropertyDescriptor property, ListSortDirection direction);

		// Token: 0x06001526 RID: 5414
		[global::Cpp2ILInjected.Token(Token = "0x6001771")]
		int Find(PropertyDescriptor property, object key);

		// Token: 0x06001527 RID: 5415
		[global::Cpp2ILInjected.Token(Token = "0x6001772")]
		void RemoveIndex(PropertyDescriptor property);

		// Token: 0x06001528 RID: 5416
		[global::Cpp2ILInjected.Token(Token = "0x6001773")]
		void RemoveSort();
	}
}
