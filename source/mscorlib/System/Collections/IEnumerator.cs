using System;
using Cpp2ILInjected;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005E8")]
	public interface IEnumerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002DB7")]
		bool MoveNext();

		[global::Cpp2ILInjected.Token(Token = "0x17000701")]
		object Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB8")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DB9")]
		void Reset();
	}
}
