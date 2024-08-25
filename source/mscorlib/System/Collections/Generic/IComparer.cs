using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x200062B")]
	public interface IComparer<in T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003086")]
		int Compare(T x, T y);
	}
}
