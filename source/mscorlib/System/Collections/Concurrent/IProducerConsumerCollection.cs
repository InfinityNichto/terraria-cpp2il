using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Collections.Concurrent
{
	[global::Cpp2ILInjected.Token(Token = "0x200061C")]
	public interface IProducerConsumerCollection<T> : global::System.Collections.Generic.IEnumerable<T>, IEnumerable, ICollection
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002FC7")]
		bool TryAdd(T item);

		[global::Cpp2ILInjected.Token(Token = "0x6002FC8")]
		bool TryTake(out T item);

		[global::Cpp2ILInjected.Token(Token = "0x6002FC9")]
		T[] ToArray();
	}
}
