using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003C9")]
	public interface IChangeTracking
	{
		[global::Cpp2ILInjected.Token(Token = "0x170005DD")]
		bool IsChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019BE")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019BF")]
		void AcceptChanges();
	}
}
