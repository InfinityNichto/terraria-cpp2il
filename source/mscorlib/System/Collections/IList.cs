using System;
using Cpp2ILInjected;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005EA")]
	public interface IList : ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000702")]
		object this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DBC")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6002DBD")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DBE")]
		int Add(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6002DBF")]
		bool Contains(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6002DC0")]
		void Clear();

		[global::Cpp2ILInjected.Token(Token = "0x17000703")]
		bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DC1")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000704")]
		bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DC2")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DC3")]
		int IndexOf(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6002DC4")]
		void Insert(int index, object value);

		[global::Cpp2ILInjected.Token(Token = "0x6002DC5")]
		void Remove(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6002DC6")]
		void RemoveAt(int index);
	}
}
