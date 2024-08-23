using System;
using Cpp2ILInjected;

namespace System.Collections
{
	// Token: 0x020004F1 RID: 1265
	[global::Cpp2ILInjected.Token(Token = "0x20005E5")]
	public interface IDictionary : ICollection, IEnumerable
	{
		// Token: 0x17000662 RID: 1634
		[global::Cpp2ILInjected.Token(Token = "0x170006F9")]
		object this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DA8")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6002DA9")]
			set;
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002A46 RID: 10822
		[global::Cpp2ILInjected.Token(Token = "0x170006FA")]
		ICollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DAA")]
			get;
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002A47 RID: 10823
		[global::Cpp2ILInjected.Token(Token = "0x170006FB")]
		ICollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DAB")]
			get;
		}

		// Token: 0x06002A48 RID: 10824
		[global::Cpp2ILInjected.Token(Token = "0x6002DAC")]
		bool Contains(object key);

		// Token: 0x06002A49 RID: 10825
		[global::Cpp2ILInjected.Token(Token = "0x6002DAD")]
		void Add(object key, object value);

		// Token: 0x06002A4A RID: 10826
		[global::Cpp2ILInjected.Token(Token = "0x6002DAE")]
		void Clear();

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002A4B RID: 10827
		[global::Cpp2ILInjected.Token(Token = "0x170006FC")]
		bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DAF")]
			get;
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002A4C RID: 10828
		[global::Cpp2ILInjected.Token(Token = "0x170006FD")]
		bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB0")]
			get;
		}

		// Token: 0x06002A4D RID: 10829
		[global::Cpp2ILInjected.Token(Token = "0x6002DB1")]
		IDictionaryEnumerator GetEnumerator();

		// Token: 0x06002A4E RID: 10830
		[global::Cpp2ILInjected.Token(Token = "0x6002DB2")]
		void Remove(object key);
	}
}
