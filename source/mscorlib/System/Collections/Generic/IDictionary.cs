using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x200062C")]
	public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007CD")]
		TValue this[TKey key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003087")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6003088")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007CE")]
		ICollection<TKey> Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003089")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007CF")]
		ICollection<TValue> Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x600308A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600308B")]
		bool ContainsKey(TKey key);

		[global::Cpp2ILInjected.Token(Token = "0x600308C")]
		void Add(TKey key, TValue value);

		[global::Cpp2ILInjected.Token(Token = "0x600308D")]
		bool Remove(TKey key);

		[global::Cpp2ILInjected.Token(Token = "0x600308E")]
		bool TryGetValue(TKey key, out TValue value);
	}
}
