using System;
using Cpp2ILInjected;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005E6")]
	public interface IDictionaryEnumerator : IEnumerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x170006FE")]
		object Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB3")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006FF")]
		object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB4")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000700")]
		DictionaryEntry Entry
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB5")]
			get;
		}
	}
}
