using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Linq
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006D RID: 109
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		TKey Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
			get;
		}
	}
}
