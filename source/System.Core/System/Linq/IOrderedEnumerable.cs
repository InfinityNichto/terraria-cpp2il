using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Linq
{
	// Token: 0x0200000B RID: 11
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x0600006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	}
}
