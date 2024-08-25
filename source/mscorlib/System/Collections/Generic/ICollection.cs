using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000629")]
	public interface ICollection<T> : IEnumerable<T>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007CB")]
		int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600307F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007CC")]
		bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003080")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003081")]
		void Add(T item);

		[global::Cpp2ILInjected.Token(Token = "0x6003082")]
		void Clear();

		[global::Cpp2ILInjected.Token(Token = "0x6003083")]
		bool Contains(T item);

		[global::Cpp2ILInjected.Token(Token = "0x6003084")]
		void CopyTo(T[] array, int arrayIndex);

		[global::Cpp2ILInjected.Token(Token = "0x6003085")]
		bool Remove(T item);
	}
}
