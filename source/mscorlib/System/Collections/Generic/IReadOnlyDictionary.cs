using System;
using System.Reflection;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::System.Reflection.DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x2000635")]
	public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003099")]
		bool TryGetValue(TKey key, out TValue value);
	}
}
