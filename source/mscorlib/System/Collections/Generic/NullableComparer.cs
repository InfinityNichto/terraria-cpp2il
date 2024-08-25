using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000653")]
	[global::System.Serializable]
	internal class NullableComparer<T> : Comparer<T?> where T : struct, global::System.IComparable<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003175")]
		public override int Compare(T? x, T? y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003176")]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003177")]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003178")]
		public NullableComparer()
		{
			throw null;
		}
	}
}
