using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000514 RID: 1300
	[global::Cpp2ILInjected.Token(Token = "0x200062C")]
	public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x170006DA RID: 1754
		[global::Cpp2ILInjected.Token(Token = "0x170007CD")]
		TValue this[TKey key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003087")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6003088")]
			set;
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002C18 RID: 11288
		[global::Cpp2ILInjected.Token(Token = "0x170007CE")]
		ICollection<TKey> Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003089")]
			get;
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002C19 RID: 11289
		[global::Cpp2ILInjected.Token(Token = "0x170007CF")]
		ICollection<TValue> Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x600308A")]
			get;
		}

		// Token: 0x06002C1A RID: 11290
		[global::Cpp2ILInjected.Token(Token = "0x600308B")]
		bool ContainsKey(TKey key);

		// Token: 0x06002C1B RID: 11291
		[global::Cpp2ILInjected.Token(Token = "0x600308C")]
		void Add(TKey key, TValue value);

		// Token: 0x06002C1C RID: 11292
		[global::Cpp2ILInjected.Token(Token = "0x600308D")]
		bool Remove(TKey key);

		// Token: 0x06002C1D RID: 11293
		[global::Cpp2ILInjected.Token(Token = "0x600308E")]
		bool TryGetValue(TKey key, out TValue value);
	}
}
