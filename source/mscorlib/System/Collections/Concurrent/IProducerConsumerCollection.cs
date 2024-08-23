using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Collections.Concurrent
{
	// Token: 0x0200050A RID: 1290
	[global::Cpp2ILInjected.Token(Token = "0x200061C")]
	public interface IProducerConsumerCollection<T> : global::System.Collections.Generic.IEnumerable<T>, IEnumerable, ICollection
	{
		// Token: 0x06002B87 RID: 11143
		[global::Cpp2ILInjected.Token(Token = "0x6002FC7")]
		bool TryAdd(T item);

		// Token: 0x06002B88 RID: 11144
		[global::Cpp2ILInjected.Token(Token = "0x6002FC8")]
		bool TryTake(out T item);

		// Token: 0x06002B89 RID: 11145
		[global::Cpp2ILInjected.Token(Token = "0x6002FC9")]
		T[] ToArray();
	}
}
