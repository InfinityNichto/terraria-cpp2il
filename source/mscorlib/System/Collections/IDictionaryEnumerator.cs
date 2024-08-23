using System;
using Cpp2ILInjected;

namespace System.Collections
{
	// Token: 0x020004F2 RID: 1266
	[global::Cpp2ILInjected.Token(Token = "0x20005E6")]
	public interface IDictionaryEnumerator : IEnumerator
	{
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002A4F RID: 10831
		[global::Cpp2ILInjected.Token(Token = "0x170006FE")]
		object Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB3")]
			get;
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002A50 RID: 10832
		[global::Cpp2ILInjected.Token(Token = "0x170006FF")]
		object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB4")]
			get;
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002A51 RID: 10833
		[global::Cpp2ILInjected.Token(Token = "0x17000700")]
		DictionaryEntry Entry
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB5")]
			get;
		}
	}
}
