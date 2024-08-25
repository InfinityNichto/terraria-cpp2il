using System;
using Cpp2ILInjected;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005EC")]
	public interface IStructuralEquatable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002DC8")]
		bool Equals(object other, IEqualityComparer comparer);

		[global::Cpp2ILInjected.Token(Token = "0x6002DC9")]
		int GetHashCode(IEqualityComparer comparer);
	}
}
