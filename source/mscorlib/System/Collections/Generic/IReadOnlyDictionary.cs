using System;
using System.Reflection;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200051D RID: 1309
	[global::System.Reflection.DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x2000635")]
	public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x06002C28 RID: 11304
		[global::Cpp2ILInjected.Token(Token = "0x6003099")]
		bool TryGetValue(TKey key, out TValue value);
	}
}
