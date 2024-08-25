using System;
using Cpp2ILInjected;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005E9")]
	public interface IEqualityComparer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002DBA")]
		bool Equals(object x, object y);

		[global::Cpp2ILInjected.Token(Token = "0x6002DBB")]
		int GetHashCode(object obj);
	}
}
