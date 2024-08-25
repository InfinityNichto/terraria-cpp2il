using System;
using Cpp2ILInjected;

namespace System.Configuration.Internal
{
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public interface IConfigErrorInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		string Filename
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000021")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		int LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000022")]
			get;
		}
	}
}
