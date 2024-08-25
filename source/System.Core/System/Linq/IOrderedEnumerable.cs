using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Linq
{
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	}
}
