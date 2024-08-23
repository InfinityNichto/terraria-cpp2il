using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000511 RID: 1297
	[global::Cpp2ILInjected.Token(Token = "0x2000629")]
	public interface ICollection<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002C0E RID: 11278
		[global::Cpp2ILInjected.Token(Token = "0x170007CB")]
		int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600307F")]
			get;
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002C0F RID: 11279
		[global::Cpp2ILInjected.Token(Token = "0x170007CC")]
		bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003080")]
			get;
		}

		// Token: 0x06002C10 RID: 11280
		[global::Cpp2ILInjected.Token(Token = "0x6003081")]
		void Add(T item);

		// Token: 0x06002C11 RID: 11281
		[global::Cpp2ILInjected.Token(Token = "0x6003082")]
		void Clear();

		// Token: 0x06002C12 RID: 11282
		[global::Cpp2ILInjected.Token(Token = "0x6003083")]
		bool Contains(T item);

		// Token: 0x06002C13 RID: 11283
		[global::Cpp2ILInjected.Token(Token = "0x6003084")]
		void CopyTo(T[] array, int arrayIndex);

		// Token: 0x06002C14 RID: 11284
		[global::Cpp2ILInjected.Token(Token = "0x6003085")]
		bool Remove(T item);
	}
}
