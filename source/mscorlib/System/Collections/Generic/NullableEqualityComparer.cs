using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000657")]
	[global::System.Serializable]
	internal class NullableEqualityComparer<T> : EqualityComparer<T?> where T : struct, global::System.IEquatable<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x600318D")]
		public override bool Equals(T? x, T? y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600318E")]
		public override int GetHashCode(T? obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600318F")]
		internal override int IndexOf(T?[] array, T? value, int startIndex, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003190")]
		internal override int LastIndexOf(T?[] array, T? value, int startIndex, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003191")]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003192")]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003193")]
		public NullableEqualityComparer()
		{
			throw null;
		}
	}
}
