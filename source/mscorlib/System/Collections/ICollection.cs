using System;
using Cpp2ILInjected;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005E3")]
	public interface ICollection : IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002DA3")]
		void CopyTo(global::System.Array array, int index);

		[global::Cpp2ILInjected.Token(Token = "0x170006F6")]
		int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DA4")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006F7")]
		object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DA5")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006F8")]
		bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DA6")]
			get;
		}
	}
}
