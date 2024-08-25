using System;
using Cpp2ILInjected;

namespace ReLogic.OS
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B1F")]
	public interface IClipboard
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008F8")]
		string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005343")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6005344")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008F9")]
		string MultiLineValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005345")]
			get;
		}
	}
}
