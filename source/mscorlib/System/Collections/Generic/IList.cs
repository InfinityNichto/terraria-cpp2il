using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200051B RID: 1307
	[global::Cpp2ILInjected.Token(Token = "0x2000633")]
	public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x170006DE RID: 1758
		[global::Cpp2ILInjected.Token(Token = "0x170007D1")]
		T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003093")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6003094")]
			set;
		}

		// Token: 0x06002C24 RID: 11300
		[global::Cpp2ILInjected.Token(Token = "0x6003095")]
		int IndexOf(T item);

		// Token: 0x06002C25 RID: 11301
		[global::Cpp2ILInjected.Token(Token = "0x6003096")]
		void Insert(int index, T item);

		// Token: 0x06002C26 RID: 11302
		[global::Cpp2ILInjected.Token(Token = "0x6003097")]
		void RemoveAt(int index);
	}
}
