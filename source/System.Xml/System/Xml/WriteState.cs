using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200005B")]
	public enum WriteState
	{
		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		Start,
		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		Prolog,
		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		Element,
		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		Attribute,
		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		Content,
		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		Closed,
		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		Error
	}
}
