using System;
using Cpp2ILInjected;

namespace System.Collections
{
	// Token: 0x020004EF RID: 1263
	[global::Cpp2ILInjected.Token(Token = "0x20005E3")]
	public interface ICollection : IEnumerable
	{
		// Token: 0x06002A3F RID: 10815
		[global::Cpp2ILInjected.Token(Token = "0x6002DA3")]
		void CopyTo(global::System.Array array, int index);

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002A40 RID: 10816
		[global::Cpp2ILInjected.Token(Token = "0x170006F6")]
		int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DA4")]
			get;
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002A41 RID: 10817
		[global::Cpp2ILInjected.Token(Token = "0x170006F7")]
		object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DA5")]
			get;
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002A42 RID: 10818
		[global::Cpp2ILInjected.Token(Token = "0x170006F8")]
		bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DA6")]
			get;
		}
	}
}
