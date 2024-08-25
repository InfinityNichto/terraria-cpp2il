using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000632")]
	public interface IEqualityComparer<in T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003091")]
		bool Equals(T x, T y);

		[global::Cpp2ILInjected.Token(Token = "0x6003092")]
		int GetHashCode(T obj);
	}
}
