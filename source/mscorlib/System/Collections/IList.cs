using System;
using Cpp2ILInjected;

namespace System.Collections
{
	// Token: 0x020004F6 RID: 1270
	[global::Cpp2ILInjected.Token(Token = "0x20005EA")]
	public interface IList : ICollection, IEnumerable
	{
		// Token: 0x1700066B RID: 1643
		[global::Cpp2ILInjected.Token(Token = "0x17000702")]
		object this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DBC")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6002DBD")]
			set;
		}

		// Token: 0x06002A5A RID: 10842
		[global::Cpp2ILInjected.Token(Token = "0x6002DBE")]
		int Add(object value);

		// Token: 0x06002A5B RID: 10843
		[global::Cpp2ILInjected.Token(Token = "0x6002DBF")]
		bool Contains(object value);

		// Token: 0x06002A5C RID: 10844
		[global::Cpp2ILInjected.Token(Token = "0x6002DC0")]
		void Clear();

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002A5D RID: 10845
		[global::Cpp2ILInjected.Token(Token = "0x17000703")]
		bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DC1")]
			get;
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002A5E RID: 10846
		[global::Cpp2ILInjected.Token(Token = "0x17000704")]
		bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DC2")]
			get;
		}

		// Token: 0x06002A5F RID: 10847
		[global::Cpp2ILInjected.Token(Token = "0x6002DC3")]
		int IndexOf(object value);

		// Token: 0x06002A60 RID: 10848
		[global::Cpp2ILInjected.Token(Token = "0x6002DC4")]
		void Insert(int index, object value);

		// Token: 0x06002A61 RID: 10849
		[global::Cpp2ILInjected.Token(Token = "0x6002DC5")]
		void Remove(object value);

		// Token: 0x06002A62 RID: 10850
		[global::Cpp2ILInjected.Token(Token = "0x6002DC6")]
		void RemoveAt(int index);
	}
}
