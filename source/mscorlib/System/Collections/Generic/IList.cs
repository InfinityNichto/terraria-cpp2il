using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000633")]
	public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007D1")]
		T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003093")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6003094")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003095")]
		int IndexOf(T item);

		[global::Cpp2ILInjected.Token(Token = "0x6003096")]
		void Insert(int index, T item);

		[global::Cpp2ILInjected.Token(Token = "0x6003097")]
		void RemoveAt(int index);
	}
}
