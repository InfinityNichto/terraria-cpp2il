using System;
using Cpp2ILInjected;

namespace System.Collections
{
	[global::System.Obsolete("Please use IEqualityComparer instead.")]
	[global::Cpp2ILInjected.Token(Token = "0x200060F")]
	public interface IHashCodeProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002F56")]
		int GetHashCode(object obj);
	}
}
