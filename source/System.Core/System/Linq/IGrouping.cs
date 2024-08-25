using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Linq
{
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		TKey Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
			get;
		}
	}
}
