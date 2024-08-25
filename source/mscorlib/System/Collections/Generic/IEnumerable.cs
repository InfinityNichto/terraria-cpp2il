using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000630")]
	public interface IEnumerable<out T> : IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x600308F")]
		IEnumerator<T> GetEnumerator();
	}
}
