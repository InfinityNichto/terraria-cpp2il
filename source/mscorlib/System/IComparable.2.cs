using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20000C5")]
	public interface IComparable<in T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000759")]
		int CompareTo(T other);
	}
}
