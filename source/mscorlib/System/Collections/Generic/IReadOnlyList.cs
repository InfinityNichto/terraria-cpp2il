using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000636")]
	public interface IReadOnlyList<out T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007D3")]
		T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600309A")]
			get;
		}
	}
}
