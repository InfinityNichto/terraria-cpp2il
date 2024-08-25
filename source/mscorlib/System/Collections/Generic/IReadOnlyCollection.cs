using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000634")]
	public interface IReadOnlyCollection<out T> : IEnumerable<T>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007D2")]
		int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003098")]
			get;
		}
	}
}
