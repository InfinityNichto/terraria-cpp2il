using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000383")]
	public interface IIntellisenseBuilder
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700055E")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001798")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001799")]
		bool Show(string language, string value, ref string newValue);
	}
}
