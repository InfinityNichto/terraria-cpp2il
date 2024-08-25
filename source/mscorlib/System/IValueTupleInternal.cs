using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200011A")]
	internal interface IValueTupleInternal : global::System.Runtime.CompilerServices.ITuple
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B0A")]
		int GetHashCode(global::System.Collections.IEqualityComparer comparer);

		[global::Cpp2ILInjected.Token(Token = "0x6000B0B")]
		string ToStringEnd();
	}
}
