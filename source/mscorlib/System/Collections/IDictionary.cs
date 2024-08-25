using System;
using Cpp2ILInjected;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005E5")]
	public interface IDictionary : ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170006F9")]
		object this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DA8")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6002DA9")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006FA")]
		ICollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DAA")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006FB")]
		ICollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DAB")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DAC")]
		bool Contains(object key);

		[global::Cpp2ILInjected.Token(Token = "0x6002DAD")]
		void Add(object key, object value);

		[global::Cpp2ILInjected.Token(Token = "0x6002DAE")]
		void Clear();

		[global::Cpp2ILInjected.Token(Token = "0x170006FC")]
		bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DAF")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006FD")]
		bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB0")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DB1")]
		IDictionaryEnumerator GetEnumerator();

		[global::Cpp2ILInjected.Token(Token = "0x6002DB2")]
		void Remove(object key);
	}
}
